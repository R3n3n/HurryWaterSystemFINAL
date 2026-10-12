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

        cboCustomer.DataSource = dt
        cboCustomer.DisplayMember = "customerName"
        cboCustomer.ValueMember = "customerId"
        cboCustomer.SelectedIndex = -1
    End Sub

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

        If cboCustomer.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCustomer, "Select a customer.")
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
            cmd.Parameters.AddWithValue("@customerId", CInt(cboCustomer.SelectedValue))
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