Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmAddBorrowRecord

    Private Shared ReadOnly DispenserRefPattern As New Regex("^DSP-\d{3}$", RegexOptions.Compiled)
    Private isFormattingRef As Boolean = False

    Private Sub frmAddBorrowRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        cboCustomer.DataSource = dt
        cboCustomer.DisplayMember = "customerName"
        cboCustomer.ValueMember = "customerId"
        cboCustomer.SelectedIndex = -1
    End Sub

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

        If cboCustomer.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCustomer, "Select a customer.")
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
        cmd.Parameters.AddWithValue("@customerId", CInt(cboCustomer.SelectedValue))
        cmd.Parameters.AddWithValue("@dispenserRef", txtDispenserRef.Text.Trim().ToUpper())
        cmd.Parameters.AddWithValue("@dateBorrowed", dtpDateBorrowed.Value.Date)
        cmd.Parameters.AddWithValue("@expectedReturn", dtpExpectedReturn.Value.Date)
        cmd.ExecuteNonQuery()

        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub

End Class