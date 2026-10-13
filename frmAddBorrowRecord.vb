Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmAddBorrowRecord

    Private Shared ReadOnly DispenserRefPattern As New Regex("^DSP-\d{3}$", RegexOptions.Compiled)
    Private isFormattingRef As Boolean = False

    Private Sub frmAddBorrowRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupCustomerSearch()
        LoadCustomers()

        txtDispenserRef.MaxLength = 7

        dtpDateBorrowed.MaxDate = Date.Today
        dtpDateBorrowed.Value = Date.Today
        dtpExpectedReturn.Value = Date.Today.AddDays(14)
    End Sub

    Private Sub LoadCustomers()
        connection()
        sql = "SELECT customerId, customerName FROM tblCustomers WHERE status = 'Active' ORDER BY customerName"
        cmd = New MySqlCommand(sql, cn)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        cn.Close()

        customers = New DataView(dt)
        customers.Sort = "customerName"
        selectedCustomerId = 0
        selectedCustomerName = ""

        settingCustomerText = True
        txtCustomer.Text = ""
        settingCustomerText = False
    End Sub

#Region "Customer search box"

    ' The drop-down list under txtCustomer. It never takes keyboard focus,
    ' so typing keeps going into the text box.
    Private NotInheritable Class CustomerPopupList
        Inherits ListBox

        Public Sub New()
            SetStyle(ControlStyles.Selectable, False)
            TabStop = False
            IntegralHeight = False
            BorderStyle = BorderStyle.FixedSingle
            Font = New Font("Segoe UI", 13.25F)
            Visible = False
        End Sub
    End Class

    Private WithEvents customerPopup As New CustomerPopupList()
    Private customers As DataView
    Private shownRows As New List(Of DataRow)        ' exactly the rows currently listed, in the same order
    Private selectedCustomerId As Integer = 0        ' 0 = no customer chosen
    Private selectedCustomerName As String = ""
    Private settingCustomerText As Boolean = False   ' True while WE change the text, so it isn't treated as typing
    Private noCustomerMatch As Boolean = False
    Private mouseOverPopup As Boolean = False

    Private Sub SetupCustomerSearch()
        Me.Controls.Add(customerPopup)
        txtCustomer.PlaceholderText = "Type to search customers..."
    End Sub

    Private Sub HideCustomerList()
        customerPopup.Visible = False
        mouseOverPopup = False
    End Sub

    Private Sub txtCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtCustomer.TextChanged
        If settingCustomerText OrElse customers Is Nothing Then Return

        ' a late echo of the name we just filled in is not the user typing
        If selectedCustomerId <> 0 AndAlso txtCustomer.Text = selectedCustomerName Then Return

        selectedCustomerId = 0   ' typing cancels an earlier pick
        selectedCustomerName = ""

        If txtCustomer.Text.Trim() = "" Then
            customers.RowFilter = ""
            HideCustomerList()
            Return
        End If

        customers.RowFilter = BuildCustomerFilter(txtCustomer.Text)
        ShowCustomerList()
    End Sub

    Private Sub txtCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomer.KeyDown
        If customers Is Nothing Then Return

        Select Case e.KeyCode
            Case Keys.Down
                If Not customerPopup.Visible Then
                    If selectedCustomerId <> 0 OrElse txtCustomer.Text.Trim() = "" Then customers.RowFilter = ""
                    ShowCustomerList()
                End If
                If Not noCustomerMatch AndAlso customerPopup.Items.Count > 0 Then
                    If customerPopup.SelectedIndex < customerPopup.Items.Count - 1 Then customerPopup.SelectedIndex += 1
                End If
                e.Handled = True
                e.SuppressKeyPress = True

            Case Keys.Up
                If customerPopup.Visible Then
                    If Not noCustomerMatch AndAlso customerPopup.SelectedIndex > 0 Then customerPopup.SelectedIndex -= 1
                    e.Handled = True
                    e.SuppressKeyPress = True
                End If

            Case Keys.Enter
                If customerPopup.Visible Then
                    Dim idx As Integer = customerPopup.SelectedIndex
                    If idx < 0 AndAlso shownRows.Count = 1 Then idx = 0
                    If Not noCustomerMatch AndAlso idx >= 0 AndAlso idx < shownRows.Count Then ApplyCustomerRow(shownRows(idx))
                    e.Handled = True
                    e.SuppressKeyPress = True
                End If

            Case Keys.Escape
                If customerPopup.Visible Then
                    HideCustomerList()
                    e.Handled = True
                    e.SuppressKeyPress = True
                End If
        End Select
    End Sub

    Private Sub txtCustomer_Leave(sender As Object, e As EventArgs) Handles txtCustomer.Leave
        If mouseOverPopup Then Return      ' the user is clicking the list; let the click finish first
        FinishCustomerSearch(False)
    End Sub

    Private Sub ShowCustomerList()
        If txtCustomer.Parent Is Nothing Then Return

        ' remember exactly which rows are listed, so a click can't map to a different row later
        shownRows.Clear()
        For Each r As DataRowView In customers
            shownRows.Add(r.Row)
        Next

        customerPopup.BeginUpdate()
        customerPopup.Items.Clear()
        noCustomerMatch = (shownRows.Count = 0)
        If noCustomerMatch Then
            customerPopup.Items.Add("No matching customers")
        Else
            For Each r As DataRow In shownRows
                customerPopup.Items.Add(Convert.ToString(r("customerName")))
            Next
        End If
        customerPopup.EndUpdate()
        customerPopup.SelectedIndex = -1

        ' just under the text box, as wide as it, never taller than the space left in the form
        Dim topLeft As Point = Me.PointToClient(txtCustomer.Parent.PointToScreen(New Point(txtCustomer.Left, txtCustomer.Bottom + 2)))
        Dim rowH As Integer = customerPopup.ItemHeight
        Dim maxRows As Integer = Math.Max(1, (Me.ClientSize.Height - topLeft.Y - 10) \ rowH)
        Dim shown As Integer = Math.Min(Math.Max(customerPopup.Items.Count, 1), Math.Min(7, maxRows))
        customerPopup.SetBounds(topLeft.X, topLeft.Y, txtCustomer.Width, rowH * shown + 6)
        customerPopup.BringToFront()
        customerPopup.Visible = True
    End Sub

    Private Sub customerPopup_MouseEnter(sender As Object, e As EventArgs) Handles customerPopup.MouseEnter
        mouseOverPopup = True
    End Sub

    Private Sub customerPopup_MouseLeave(sender As Object, e As EventArgs) Handles customerPopup.MouseLeave
        mouseOverPopup = False
    End Sub

    Private Sub customerPopup_MouseMove(sender As Object, e As MouseEventArgs) Handles customerPopup.MouseMove
        If noCustomerMatch Then Return
        Dim idx As Integer = customerPopup.IndexFromPoint(e.Location)
        If idx >= 0 AndAlso idx <> customerPopup.SelectedIndex Then customerPopup.SelectedIndex = idx
    End Sub

    Private Sub customerPopup_MouseDown(sender As Object, e As MouseEventArgs) Handles customerPopup.MouseDown
        If noCustomerMatch Then Return

        Dim idx As Integer = customerPopup.IndexFromPoint(e.Location)
        If idx >= 0 AndAlso idx < shownRows.Count Then
            ApplyCustomerRow(shownRows(idx))     ' the row that was listed at that position
            txtCustomer.Focus()
        End If
    End Sub

    Private Sub ApplyCustomerRow(r As DataRow)
        selectedCustomerId = CInt(r("customerId"))
        selectedCustomerName = Convert.ToString(r("customerName"))

        settingCustomerText = True
        txtCustomer.Text = selectedCustomerName
        txtCustomer.SelectionStart = txtCustomer.Text.Length
        settingCustomerText = False

        customers.RowFilter = ""
        HideCustomerList()
    End Sub

    ''' <summary>
    ''' Turns typed text into a real choice when it clearly matches one.
    ''' An exact name always counts. A partial match counts only when allowPartial is True
    ''' (used when saving) and exactly one customer still matches.
    ''' </summary>
    Private Sub FinishCustomerSearch(allowPartial As Boolean)
        HideCustomerList()
        If customers Is Nothing OrElse selectedCustomerId <> 0 Then Return

        Dim typed As String = txtCustomer.Text.Trim()
        If typed = "" Then Return

        Dim exactRow As DataRow = Nothing
        Dim exactCount As Integer = 0
        For Each r As DataRow In customers.Table.Rows
            If String.Equals(Convert.ToString(r("customerName")), typed, StringComparison.OrdinalIgnoreCase) Then
                exactRow = r
                exactCount += 1
            End If
        Next

        If exactCount = 1 Then
            ApplyCustomerRow(exactRow)
            Return
        End If

        If allowPartial AndAlso exactCount = 0 Then
            customers.RowFilter = BuildCustomerFilter(typed)
            If customers.Count = 1 Then
                ApplyCustomerRow(customers(0).Row)
                Return
            End If
        End If

        customers.RowFilter = ""
    End Sub

    ' "juan cruz" -> [customerName] LIKE '%juan%' AND [customerName] LIKE '%cruz%'
    Private Function BuildCustomerFilter(typed As String) As String
        Dim words As String() = typed.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        If words.Length = 0 Then Return ""

        Dim parts As New List(Of String)
        For Each w As String In words
            parts.Add("[customerName] LIKE '%" & EscapeLike(w) & "%'")
        Next
        Return String.Join(" AND ", parts)
    End Function

    Private Shared Function EscapeLike(s As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each ch As Char In s
            Select Case ch
                Case "'"c
                    sb.Append("''")
                Case "["c, "]"c, "*"c, "%"c
                    sb.Append("[").Append(ch).Append("]")
                Case Else
                    sb.Append(ch)
            End Select
        Next
        Return sb.ToString()
    End Function

#End Region

    Private Sub txtDispenserRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDispenserRef.KeyPress
        If Char.IsControl(e.KeyChar) Then Return
        If Not (Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar = "-"c) Then e.Handled = True
    End Sub

    Private Sub txtDispenserRef_TextChanged(sender As Object, e As EventArgs) Handles txtDispenserRef.TextChanged
        If isFormattingRef Then Return
        Dim upper As String = txtDispenserRef.Text.ToUpper()
        If upper <> txtDispenserRef.Text Then
            isFormattingRef = True
            Dim pos As Integer = txtDispenserRef.SelectionStart
            txtDispenserRef.Text = upper
            txtDispenserRef.SelectionStart = pos
            isFormattingRef = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveBorrowRecord()
            Me.DialogResult = DialogResult.OK
        Catch ex As InvalidOperationException
            errorProvider1.SetError(txtDispenserRef, ex.Message & " Mark it as returned first.")
            MsgBox(ex.Message & vbCrLf & "Mark it as returned first.", MsgBoxStyle.Exclamation, "Dispenser unavailable")
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        FinishCustomerSearch(True)   ' turn typed text into a real choice first, if it clearly matches one
        If selectedCustomerId = 0 Then
            errorProvider1.SetError(txtCustomer, "Select a customer from the list.")
            isValid = False
        End If

        Dim dispenserRef As String = txtDispenserRef.Text.Trim().ToUpper()
        If String.IsNullOrEmpty(dispenserRef) Then
            errorProvider1.SetError(txtDispenserRef, "Enter a dispenser reference (e.g. DSP-015).")
            isValid = False
        ElseIf Not DispenserRefPattern.IsMatch(dispenserRef) Then
            errorProvider1.SetError(txtDispenserRef, "Use the format DSP-### (e.g. DSP-015). Letters DSP, a dash, then exactly 3 digits.")
            isValid = False
        Else
            Dim holder As String = FindCurrentBorrower(dispenserRef)
            If holder <> "" Then
                errorProvider1.SetError(txtDispenserRef, dispenserRef & " is still borrowed by " & holder & ". Mark it as returned first.")
                isValid = False
            End If
        End If

        If dtpExpectedReturn.Value.Date < dtpDateBorrowed.Value.Date Then
            errorProvider1.SetError(dtpExpectedReturn, "Expected return date can't be before the borrow date.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Function FindCurrentBorrower(dispenserRef As String) As String
        Try
            connection()
            sql = "SELECT c.customerName FROM tblDispenserBorrowing b " &
                  "INNER JOIN tblCustomers c ON c.customerId = b.customerId " &
                  "WHERE UPPER(b.dispenserRef) = @ref AND b.status <> 'Returned' AND b.dateReturned IS NULL " &
                  "LIMIT 1"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@ref", dispenserRef.ToUpper())
            Dim result As Object = cmd.ExecuteScalar()
            Return If(result Is Nothing OrElse IsDBNull(result), "", result.ToString())
        Catch ex As MySqlException
            MsgBox("Couldn't check the dispenser: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return "another customer (check failed)"
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub SaveBorrowRecord()
        Dim holder As String = FindCurrentBorrower(txtDispenserRef.Text.Trim().ToUpper())
        If holder <> "" Then
            Throw New InvalidOperationException(txtDispenserRef.Text.Trim().ToUpper() & " is still borrowed by " & holder & ".")
        End If

        connection()

        sql = "INSERT INTO tblDispenserBorrowing " &
              "(customerId, dispenserRef, dateBorrowed, expectedReturnDate, status) " &
              "VALUES (@customerId, @dispenserRef, @dateBorrowed, @expectedReturn, 'Borrowed')"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@customerId", selectedCustomerId)
        cmd.Parameters.AddWithValue("@dispenserRef", txtDispenserRef.Text.Trim().ToUpper())
        cmd.Parameters.AddWithValue("@dateBorrowed", dtpDateBorrowed.Value.Date)
        cmd.Parameters.AddWithValue("@expectedReturn", dtpExpectedReturn.Value.Date)
        cmd.ExecuteNonQuery()

        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub

End Class