Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class frmAddSalesOrder
    Private Sub frmAddSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nud As Guna2NumericUpDown In {nudQuantity1, nudQuantity2, nudQuantity3}
            nud.Minimum = 0
            nud.Maximum = 500        ' realistic cap per line (default is 100); typical orders are well under this
            nud.Value = 0
        Next
        For Each nud As Guna2NumericUpDown In {nudUnitPrice1, nudUnitPrice2, nudUnitPrice3}
            nud.Minimum = 0
            nud.Maximum = 100000     ' a price above the default max would throw when auto-filled
            nud.DecimalPlaces = 2
            ' Price is fixed per product (from tblProducts): shown for reference, not editable
            nud.Enabled = False                          ' Guna2NumericUpDown has no ReadOnly; disabled = not editable
            nud.Increment = 0
            nud.TabStop = False
            nud.Cursor = Cursors.Default
            nud.UpDownButtonFillColor = nud.FillColor    ' hide the up/down arrows
            nud.UpDownButtonForeColor = nud.FillColor
        Next

        ' THESE WERE MISSING: without them the dropdowns are empty and
        ' blank text gets saved into the database's status columns
        dtpOrderDate.MaxDate = Date.Today   ' no orders dated in the future
        dtpOrderDate.Value = Date.Today

        cboPickupStatus.Items.Clear()
        cboPickupStatus.Items.AddRange({"Pending", "Picked-up", "Delivered"})
        cboPickupStatus.SelectedIndex = 0

        cboPaymentMode.Items.Clear()
        cboPaymentMode.Items.AddRange({"Cash", "Card"})
        cboPaymentMode.SelectedIndex = 0

        cboPaymentStatus.Items.Clear()
        cboPaymentStatus.Items.AddRange({"Unpaid", "Paid"})
        cboPaymentStatus.SelectedIndex = 0

        SetupCustomerSearch()
        LoadCustomers()
        LoadProductsIntoAllRows()
        RecalculateGrandTotal()
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

    Private Sub LoadProductsIntoAllRows()
        connection()
        sql = "SELECT productId, CONCAT(containerType, ' - ', waterType) AS displayName, unitPrice " &
              "FROM tblProducts WHERE status = 'Active' ORDER BY category DESC, containerType, waterType"
        cmd = New MySqlCommand(sql, cn)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        cn.Close()

        For Each cbo As ComboBox In {cboProduct1, cboProduct2, cboProduct3}
            cbo.DisplayMember = "displayName"
            cbo.ValueMember = "productId"
            cbo.DataSource = dt.Copy()
            cbo.SelectedIndex = -1
        Next
    End Sub

    ' Set while we reset a combobox ourselves, so the reset does not re-trigger the checks
    Private isResettingProduct As Boolean = False

    ''' <summary>
    ''' Called as soon as a product is picked. If another row already has the same
    ''' product, show an error, clear this row's selection and return True.
    ''' </summary>
    Private Function IsDuplicateProduct(changed As ComboBox) As Boolean
        If isResettingProduct Then Return True   ' our own reset; nothing more to do
        errorProvider1.SetError(changed, "")
        If changed.SelectedIndex = -1 Then Return False

        Dim chosenId As Integer = ProductIdOf(changed)
        If chosenId = -1 Then Return False
        For Each other As ComboBox In {cboProduct1, cboProduct2, cboProduct3}
            If Not Object.ReferenceEquals(other, changed) AndAlso ProductIdOf(other) = chosenId Then
                Dim name As String = changed.Text
                isResettingProduct = True
                Try
                    changed.SelectedIndex = -1
                Finally
                    isResettingProduct = False
                End Try
                AutoFillPrice(changed, PriceBoxFor(changed))
                RecalculateLine(QtyBoxFor(changed), PriceBoxFor(changed), LineTotalFor(changed))
                errorProvider1.SetError(changed, "'" & name & "' is already selected in another row. Pick a different product.")
                MsgBox("'" & name & "' is already selected in another row." & vbCrLf &
                       "Pick a different product, or increase the quantity on the existing row.",
                       MsgBoxStyle.Exclamation, "Duplicate product")
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>Product id of the selected row, or -1 if nothing (valid) is selected.</summary>
    Private Function ProductIdOf(cbo As ComboBox) As Integer
        Dim drv = TryCast(cbo.SelectedItem, DataRowView)
        If drv Is Nothing Then Return -1
        Return CInt(drv("productId"))
    End Function

    Private Function PriceBoxFor(cbo As ComboBox) As Guna2NumericUpDown
        If cbo Is cboProduct1 Then Return nudUnitPrice1
        If cbo Is cboProduct2 Then Return nudUnitPrice2
        Return nudUnitPrice3
    End Function

    Private Function QtyBoxFor(cbo As ComboBox) As Guna2NumericUpDown
        If cbo Is cboProduct1 Then Return nudQuantity1
        If cbo Is cboProduct2 Then Return nudQuantity2
        Return nudQuantity3
    End Function

    Private Function LineTotalFor(cbo As ComboBox) As Label
        If cbo Is cboProduct1 Then Return lblLineTotal1
        If cbo Is cboProduct2 Then Return lblLineTotal2
        Return lblLineTotal3
    End Function

    Private Sub cboProduct1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct1.SelectedIndexChanged
        If IsDuplicateProduct(cboProduct1) Then Return
        AutoFillPrice(cboProduct1, nudUnitPrice1)
        RecalculateLine(nudQuantity1, nudUnitPrice1, lblLineTotal1)
    End Sub
    Private Sub cboProduct2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct2.SelectedIndexChanged
        If IsDuplicateProduct(cboProduct2) Then Return
        AutoFillPrice(cboProduct2, nudUnitPrice2)
        RecalculateLine(nudQuantity2, nudUnitPrice2, lblLineTotal2)
    End Sub
    Private Sub cboProduct3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct3.SelectedIndexChanged
        If IsDuplicateProduct(cboProduct3) Then Return
        AutoFillPrice(cboProduct3, nudUnitPrice3)
        RecalculateLine(nudQuantity3, nudUnitPrice3, lblLineTotal3)
    End Sub

    Private Sub nudQuantity1_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity1.ValueChanged, nudUnitPrice1.ValueChanged
        RecalculateLine(nudQuantity1, nudUnitPrice1, lblLineTotal1)
    End Sub
    Private Sub nudQuantity2_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity2.ValueChanged, nudUnitPrice2.ValueChanged
        RecalculateLine(nudQuantity2, nudUnitPrice2, lblLineTotal2)
    End Sub
    Private Sub nudQuantity3_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity3.ValueChanged, nudUnitPrice3.ValueChanged
        RecalculateLine(nudQuantity3, nudUnitPrice3, lblLineTotal3)
    End Sub

    Private Sub AutoFillPrice(cbo As ComboBox, nudPrice As Guna2NumericUpDown)
        If cbo.SelectedIndex = -1 Then
            nudPrice.Value = 0
        Else
            nudPrice.Value = CDec(DirectCast(cbo.SelectedItem, DataRowView)("unitPrice"))
        End If
    End Sub

    Private Sub RecalculateLine(nudQty As Guna2NumericUpDown, nudPrice As Guna2NumericUpDown, lblLineTotal As Label)
        Dim lineTotal As Decimal = nudQty.Value * nudPrice.Value
        lblLineTotal.Text = "₱" & lineTotal.ToString("N2")
        RecalculateGrandTotal()
    End Sub

    Private Sub RecalculateGrandTotal()
        Dim total As Decimal = (nudQuantity1.Value * nudUnitPrice1.Value) + (nudQuantity2.Value * nudUnitPrice2.Value) + (nudQuantity3.Value * nudUnitPrice3.Value)
        lblTotal.Text = "₱" & total.ToString("N2")
        CenterTotalLabels()
    End Sub

    ''' <summary>Keeps the TOTAL caption and the amount centered in the blue panel, whatever the amount's length.</summary>
    Private Sub CenterTotalLabels()
        Dim w As Integer = lblTotal.Parent.ClientSize.Width
        Label14.Left = Math.Max(0, (w - Label14.Width) \ 2)
        lblTotal.Left = Math.Max(0, (w - lblTotal.Width) \ 2)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If CurrentUserId <= 0 Then
            MsgBox("No logged-in user. Please log in again.", MsgBoxStyle.Exclamation, "Not logged in")
            Return
        End If

        If Not ValidateOrder() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveOrder()
            MsgBox("Order saved successfully.", MsgBoxStyle.Information, "Success")   ' the missing confirmation
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception    ' was "MySqlException" only, so other error types escaped silently
            MsgBox("Could not save the order: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ValidateOrder() As Boolean
        Dim isValid As Boolean = True

        FinishCustomerSearch(True)   ' turn typed text into a real choice first, if it clearly matches one
        If selectedCustomerId = 0 Then
            errorProvider1.SetError(txtCustomer, "Select a customer from the list.")
            isValid = False
        End If

        Dim hasAtLeastOneLine As Boolean =
            (cboProduct1.SelectedIndex <> -1 AndAlso nudQuantity1.Value > 0) OrElse
            (cboProduct2.SelectedIndex <> -1 AndAlso nudQuantity2.Value > 0) OrElse
            (cboProduct3.SelectedIndex <> -1 AndAlso nudQuantity3.Value > 0)

        If Not hasAtLeastOneLine Then
            errorProvider1.SetError(cboProduct1, "Add at least one product with a quantity greater than 0.")
            isValid = False
        End If

        ' Catch the mismatched case: a product picked but qty left at 0,
        ' or a quantity entered but no product picked. Both are half-filled
        ' rows that would silently insert nothing — better to flag them.
        For Each pair In New List(Of (Product As ComboBox, Qty As Guna2NumericUpDown)) From {
            (cboProduct1, nudQuantity1), (cboProduct2, nudQuantity2), (cboProduct3, nudQuantity3)}

            Dim productChosen As Boolean = pair.Product.SelectedIndex <> -1
            Dim qtyEntered As Boolean = pair.Qty.Value > 0

            If productChosen Xor qtyEntered Then
                errorProvider1.SetError(pair.Product, "Select a product AND enter a quantity, or leave this row fully empty.")
                isValid = False
            End If
        Next

        If dtpOrderDate.Value.Date > Date.Today Then
            errorProvider1.SetError(dtpOrderDate, "The order date can't be in the future.")
            isValid = False
        End If

        Dim payProblem As String = PaymentRuleProblem(cboPickupStatus.Text, cboPaymentStatus.Text)
        If payProblem <> "" Then
            errorProvider1.SetError(cboPaymentStatus, payProblem.Replace(vbCrLf, " "))
            isValid = False
        End If

        ' Safety net: the same product must not appear on two rows
        Dim picked As New HashSet(Of Integer)
        For Each cbo As ComboBox In {cboProduct1, cboProduct2, cboProduct3}
            If cbo.SelectedIndex = -1 Then Continue For
            If ProductIdOf(cbo) <> -1 AndAlso Not picked.Add(ProductIdOf(cbo)) Then
                errorProvider1.SetError(cbo, "This product is already selected in another row.")
                isValid = False
            End If
        Next

        Return isValid
    End Function

    ''' <summary>
    ''' Inserts the order header AND up to 3 line items as ONE transaction.
    ''' Empty rows (no product/qty) are simply skipped, not inserted.
    ''' </summary>
    Private Sub SaveOrder()
        connection()
        Dim txn As MySqlTransaction = cn.BeginTransaction()

        Try
            sql = "INSERT INTO tblSalesOrders " &
                  "(customerId, userId, orderDate, pickupStatus, paymentMode, paymentStatus, totalAmount) " &
                  "VALUES (@customerId, @userId, @orderDate, @pickupStatus, @paymentMode, @paymentStatus, @total)"

            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@customerId", selectedCustomerId)
            cmd.Parameters.AddWithValue("@userId", CurrentUserId)
            cmd.Parameters.AddWithValue("@orderDate", dtpOrderDate.Value.Date)
            cmd.Parameters.AddWithValue("@pickupStatus", cboPickupStatus.Text)
            cmd.Parameters.AddWithValue("@paymentMode", cboPaymentMode.Text)
            cmd.Parameters.AddWithValue("@paymentStatus", cboPaymentStatus.Text)
            cmd.Parameters.AddWithValue("@total", GetGrandTotalValue())
            cmd.ExecuteNonQuery()

            Dim newOrderId As Long = cmd.LastInsertedId

            InsertLineIfUsed(txn, newOrderId, cboProduct1, nudQuantity1, nudUnitPrice1)
            InsertLineIfUsed(txn, newOrderId, cboProduct2, nudQuantity2, nudUnitPrice2)
            InsertLineIfUsed(txn, newOrderId, cboProduct3, nudQuantity3, nudUnitPrice3)

            txn.Commit()
        Catch ex As Exception
            txn.Rollback()
            Throw
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub InsertLineIfUsed(txn As MySqlTransaction, orderId As Long, cboProduct As ComboBox, nudQty As Guna2NumericUpDown, nudPrice As Guna2NumericUpDown)
        ' Skip rows the user left empty
        If cboProduct.SelectedIndex = -1 OrElse nudQty.Value = 0 Then Return

        sql = "INSERT INTO tblSalesOrderDetails (orderId, productId, quantity, unitPrice) " &
              "VALUES (@orderId, @productId, @qty, @price)"

        cmd = New MySqlCommand(sql, cn, txn)
        cmd.Parameters.AddWithValue("@orderId", orderId)
        cmd.Parameters.AddWithValue("@productId", CInt(cboProduct.SelectedValue))
        cmd.Parameters.AddWithValue("@qty", CInt(nudQty.Value))
        cmd.Parameters.AddWithValue("@price", nudPrice.Value)
        cmd.ExecuteNonQuery()
    End Sub

    Private Function GetGrandTotalValue() As Decimal
        Return (nudQuantity1.Value * nudUnitPrice1.Value) +
               (nudQuantity2.Value * nudUnitPrice2.Value) +
               (nudQuantity3.Value * nudUnitPrice3.Value)
    End Function
End Class