Imports MySql.Data.MySqlClient

Public Class frmEditInventoryItem

    Private Const MAX_AMOUNT As Decimal = 1000000D

    ''' <summary>0 = add a new item, otherwise the item being edited.</summary>
    Public Property ItemID As Integer

    Private Sub frmEditInventoryItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliers()

        If ItemID > 0 Then
            lblFormTitle.Text = "Edit Inventory Item"
            Me.Text = "Edit Inventory Item"
            LoadItemData()
        Else
            txtUnit.Text = "pcs"
            txtPackSize.Text = "1"
            txtPackCost.Text = "0"
            txtReorder.Text = "0"
            txtSafety.Text = "0"
            cboSupplier.SelectedIndex = 0
        End If

        UpdateUnitCostPreview()
    End Sub

    ' Suppliers for the drop-down; value 0 means "no supplier"
    Private Sub LoadSuppliers()
        Dim dt As New DataTable()
        dt.Columns.Add("supplierId", GetType(Integer))
        dt.Columns.Add("supplierName", GetType(String))
        dt.Rows.Add(0, "(No supplier)")

        Try
            connection()
            sql = "SELECT supplierId, supplierName FROM tblsuppliers ORDER BY supplierName"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                dt.Rows.Add(CInt(dr("supplierId")), dr("supplierName").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading suppliers: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "supplierName"
        cboSupplier.ValueMember = "supplierId"
    End Sub

    Private Sub LoadItemData()
        Try
            connection()
            sql = "SELECT itemName, unit, packSize, packCost, reorderPoint, safetyStock, supplierId " &
                  "FROM tblinventoryitems WHERE itemId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", ItemID)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtItemName.Text = dr("itemName").ToString()
                txtUnit.Text = dr("unit").ToString()
                txtPackSize.Text = CDec(dr("packSize")).ToString("0.##")
                txtPackCost.Text = CDec(dr("packCost")).ToString("0.00")
                txtReorder.Text = CDec(dr("reorderPoint")).ToString("0.##")
                txtSafety.Text = CDec(dr("safetyStock")).ToString("0.##")

                If IsDBNull(dr("supplierId")) Then
                    cboSupplier.SelectedValue = 0
                Else
                    cboSupplier.SelectedValue = CInt(dr("supplierId"))
                End If
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading item data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Function TryGetDecimal(text As String, ByRef value As Decimal) As Boolean
        Return Decimal.TryParse(text.Trim(), System.Globalization.NumberStyles.Number,
                                 System.Globalization.CultureInfo.CurrentCulture, value)
    End Function

    ' Live "cost per unit" line under the form, the same maths the database uses (packCost / packSize)
    Private Sub UpdateUnitCostPreview() Handles txtPackSize.TextChanged, txtPackCost.TextChanged
        Dim size, cost As Decimal
        If TryGetDecimal(txtPackSize.Text, size) AndAlso TryGetDecimal(txtPackCost.Text, cost) AndAlso size > 0 Then
            lblUnitCostPreview.Text = "Cost per unit: ₱" & (cost / size).ToString("#,0.00##")
        Else
            lblUnitCostPreview.Text = "Cost per unit: —"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            If NameInUse() Then
                errorProvider1.SetError(txtItemName, "An item with this name already exists.")
                MsgBox("An inventory item with this name already exists.", MsgBoxStyle.Exclamation, "Duplicate item")
                Return
            End If

            If SaveItem() Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("Nothing was updated. The item may have been deleted or changed.", MsgBoxStyle.Exclamation, "Not saved")
            End If
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        Dim name As String = txtItemName.Text.Trim()
        If name = "" Then
            errorProvider1.SetError(txtItemName, "Enter the item name.")
            isValid = False
        ElseIf name.Length > 100 Then
            errorProvider1.SetError(txtItemName, "Name is too long (max 100 characters).")
            isValid = False
        End If

        Dim unit As String = txtUnit.Text.Trim()
        If unit = "" Then
            errorProvider1.SetError(txtUnit, "Enter the unit (pcs, kg, gallon...).")
            isValid = False
        ElseIf unit.Length > 20 Then
            errorProvider1.SetError(txtUnit, "Unit is too long (max 20 characters).")
            isValid = False
        End If

        Dim packSize, packCost, reorder, safety As Decimal

        If Not TryGetDecimal(txtPackSize.Text, packSize) OrElse packSize <= 0 Then
            errorProvider1.SetError(txtPackSize, "Enter a pack size greater than 0 (1 if it is bought one at a time).")
            isValid = False
        ElseIf packSize > MAX_AMOUNT Then
            errorProvider1.SetError(txtPackSize, "That number looks too large — please check it.")
            isValid = False
        End If

        If Not TryGetDecimal(txtPackCost.Text, packCost) OrElse packCost < 0 Then
            errorProvider1.SetError(txtPackCost, "Enter the cost of one pack (0 or more).")
            isValid = False
        ElseIf packCost > MAX_AMOUNT Then
            errorProvider1.SetError(txtPackCost, "That amount looks too large — please check it.")
            isValid = False
        End If

        Dim reorderOk As Boolean = TryGetDecimal(txtReorder.Text, reorder) AndAlso reorder >= 0 AndAlso reorder <= MAX_AMOUNT
        If Not reorderOk Then
            errorProvider1.SetError(txtReorder, "Enter a reorder point of 0 or more.")
            isValid = False
        End If

        Dim safetyOk As Boolean = TryGetDecimal(txtSafety.Text, safety) AndAlso safety >= 0 AndAlso safety <= MAX_AMOUNT
        If Not safetyOk Then
            errorProvider1.SetError(txtSafety, "Enter a safety stock of 0 or more.")
            isValid = False
        ElseIf reorderOk AndAlso safety > reorder Then
            errorProvider1.SetError(txtSafety, "Safety stock shouldn't be more than the reorder point.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Function NameInUse() As Boolean
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblinventoryitems WHERE itemName = @name AND itemId <> @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@name", txtItemName.Text.Trim())
            cmd.Parameters.AddWithValue("@id", ItemID)
            Return CLng(cmd.ExecuteScalar()) > 0
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Function SaveItem() As Boolean
        Dim packSize, packCost, reorder, safety As Decimal
        TryGetDecimal(txtPackSize.Text, packSize)
        TryGetDecimal(txtPackCost.Text, packCost)
        TryGetDecimal(txtReorder.Text, reorder)
        TryGetDecimal(txtSafety.Text, safety)

        Dim supplierValue As Object = DBNull.Value
        If cboSupplier.SelectedValue IsNot Nothing AndAlso CInt(cboSupplier.SelectedValue) > 0 Then
            supplierValue = CInt(cboSupplier.SelectedValue)
        End If

        Dim rowsAffected As Integer = 0

        Try
            connection()

            ' currentStock is never touched here: it only changes through Stock In / Stock Out,
            ' so every movement stays in the transaction history. unitCost is generated by the database.
            If ItemID > 0 Then
                sql = "UPDATE tblinventoryitems SET itemName = @name, unit = @unit, packSize = @packSize, " &
                      "packCost = @packCost, reorderPoint = @reorder, safetyStock = @safety, supplierId = @supplier " &
                      "WHERE itemId = @id"
            Else
                sql = "INSERT INTO tblinventoryitems " &
                      "(itemName, unit, packSize, packCost, currentStock, reorderPoint, safetyStock, supplierId) " &
                      "VALUES (@name, @unit, @packSize, @packCost, 0, @reorder, @safety, @supplier)"
            End If

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@name", txtItemName.Text.Trim())
            cmd.Parameters.AddWithValue("@unit", txtUnit.Text.Trim())
            cmd.Parameters.AddWithValue("@packSize", Math.Round(packSize, 2))
            cmd.Parameters.AddWithValue("@packCost", Math.Round(packCost, 2))
            cmd.Parameters.AddWithValue("@reorder", Math.Round(reorder, 2))
            cmd.Parameters.AddWithValue("@safety", Math.Round(safety, 2))
            cmd.Parameters.AddWithValue("@supplier", supplierValue)
            If ItemID > 0 Then cmd.Parameters.AddWithValue("@id", ItemID)

            rowsAffected = cmd.ExecuteNonQuery()
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        Return rowsAffected > 0
    End Function
End Class
