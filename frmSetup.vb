Imports MySql.Data.MySqlClient
Public Class frmSetup

    Private Enum SetupTab
        Products
        InventoryItems
        Suppliers
    End Enum

    Private currentTab As SetupTab = SetupTab.Products

    Private Sub frmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsvData.View = View.Details
        lsvData.FullRowSelect = True
        lsvData.GridLines = True

        ShowTab(SetupTab.Products)
    End Sub

    Private Sub btnTabProducts_Click(sender As Object, e As EventArgs) Handles btnTabProducts.Click
        ShowTab(SetupTab.Products)
    End Sub

    Private Sub btnTabItems_Click(sender As Object, e As EventArgs) Handles btnTabItems.Click
        ShowTab(SetupTab.InventoryItems)
    End Sub

    Private Sub btnTabSuppliers_Click(sender As Object, e As EventArgs) Handles btnTabSuppliers.Click
        ShowTab(SetupTab.Suppliers)
    End Sub

    Private Sub StyleTabButton(btn As Guna.UI2.WinForms.Guna2Button, isActive As Boolean)
        btn.FillColor = If(isActive, Color.FromArgb(58, 110, 165), Color.White)
        btn.ForeColor = If(isActive, Color.White, Color.FromArgb(28, 43, 74))
    End Sub

    Private Sub ShowTab(tab As SetupTab)
        currentTab = tab

        StyleTabButton(btnTabProducts, tab = SetupTab.Products)
        StyleTabButton(btnTabItems, tab = SetupTab.InventoryItems)
        StyleTabButton(btnTabSuppliers, tab = SetupTab.Suppliers)

        lsvData.Items.Clear()
        lsvData.Columns.Clear()

        Select Case tab
            Case SetupTab.Products
                lsvData.Columns.Add("Category", 240)
                lsvData.Columns.Add("Container", 240)
                lsvData.Columns.Add("Water Type", 240)
                lsvData.Columns.Add("Unit Price", 300, HorizontalAlignment.Right)
                lsvData.Columns.Add("Status", 400)
                lblHint.Text = "A price change only affects new orders; past orders keep the price they were sold at. " &
                               "To stop selling something, set it to Discontinued."
                btnAdd.Text = "+ Add"
                btnDelete.Visible = False

            Case SetupTab.InventoryItems
                lsvData.Columns.Add("Item", 290)
                lsvData.Columns.Add("Unit", 90)
                lsvData.Columns.Add("Pack Size", 130, HorizontalAlignment.Right)
                lsvData.Columns.Add("Pack Cost", 140, HorizontalAlignment.Right)
                lsvData.Columns.Add("Unit Cost", 130, HorizontalAlignment.Right)
                lsvData.Columns.Add("Stock", 110, HorizontalAlignment.Right)
                lsvData.Columns.Add("Reorder At", 140, HorizontalAlignment.Right)
                lsvData.Columns.Add("Safety", 110, HorizontalAlignment.Right)
                lsvData.Columns.Add("Supplier", 290)
                lblHint.Text = "Stock on hand changes through Stock In / Stock Out on the Inventory screen. " &
                               "The reorder point decides when an item shows up as low stock."
                btnAdd.Text = "+ Add"
                btnDelete.Visible = True

            Case SetupTab.Suppliers
                lsvData.Columns.Add("Supplier", 380)
                lsvData.Columns.Add("Contact", 380)
                lsvData.Columns.Add("Items Supplied", 480)
                lsvData.Columns.Add("Linked Items", 183, HorizontalAlignment.Right)
                lblHint.Text = "Link an item to its supplier from the Inventory Items tab."
                btnAdd.Text = "+ Add"
                btnDelete.Visible = True
        End Select

        LoadCurrent()
    End Sub

    Private Sub LoadCurrent()
        Select Case currentTab
            Case SetupTab.Products : LoadProducts()
            Case SetupTab.InventoryItems : LoadInventoryItems()
            Case SetupTab.Suppliers : LoadSuppliers()
        End Select
    End Sub

    Private Function FormatQty(q As Decimal) As String
        Return q.ToString("#,0.##")
    End Function

    Private Sub LoadProducts()
        lsvData.Items.Clear()

        sql = "SELECT productId, category, containerType, waterType, unitPrice, status " &
              "FROM tblproducts ORDER BY status, category DESC, containerType, waterType"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim price As Decimal = CDec(dr("unitPrice"))
                Dim status As String = dr("status").ToString()

                Dim item As New ListViewItem(dr("category").ToString())
                item.SubItems.Add(dr("containerType").ToString())
                item.SubItems.Add(dr("waterType").ToString())
                item.UseItemStyleForSubItems = False

                Dim priceCell As ListViewItem.ListViewSubItem
                If price <= 0 AndAlso status = "Active" Then
                    ' An active product with no price would be sold for 0 -- flag it
                    priceCell = item.SubItems.Add("Not set")
                    priceCell.ForeColor = Color.Firebrick
                Else
                    priceCell = item.SubItems.Add("₱" & price.ToString("N2"))
                End If

                Dim statusCell As ListViewItem.ListViewSubItem = item.SubItems.Add(status)
                If status = "Discontinued" Then
                    item.ForeColor = Color.Gray
                    priceCell.ForeColor = Color.Gray
                    statusCell.ForeColor = Color.Gray
                End If

                item.Tag = dr("productId")
                lsvData.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading products: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub LoadInventoryItems()
        lsvData.Items.Clear()

        sql = "SELECT i.itemId, i.itemName, i.unit, i.packSize, i.packCost, IFNULL(i.unitCost, 0) AS unitCost, " &
              "       i.currentStock, i.reorderPoint, i.safetyStock, s.supplierName " &
              "FROM tblinventoryitems i " &
              "LEFT JOIN tblsuppliers s ON s.supplierId = i.supplierId " &
              "ORDER BY i.itemId"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("itemName").ToString())
                item.SubItems.Add(dr("unit").ToString())
                item.SubItems.Add(FormatQty(CDec(dr("packSize"))))
                item.SubItems.Add("₱" & CDec(dr("packCost")).ToString("N2"))
                item.SubItems.Add("₱" & CDec(dr("unitCost")).ToString("#,0.00##"))
                item.SubItems.Add(FormatQty(CDec(dr("currentStock"))))
                item.SubItems.Add(FormatQty(CDec(dr("reorderPoint"))))
                item.SubItems.Add(FormatQty(CDec(dr("safetyStock"))))

                item.UseItemStyleForSubItems = False
                If IsDBNull(dr("supplierName")) Then
                    Dim noSupplier As ListViewItem.ListViewSubItem = item.SubItems.Add("(none)")
                    noSupplier.ForeColor = Color.Gray
                Else
                    item.SubItems.Add(dr("supplierName").ToString())
                End If

                item.Tag = dr("itemId")
                lsvData.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading inventory items: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub LoadSuppliers()
        lsvData.Items.Clear()

        sql = "SELECT s.supplierId, s.supplierName, s.contactInfo, s.itemsSupplied, COUNT(i.itemId) AS itemCount " &
              "FROM tblsuppliers s " &
              "LEFT JOIN tblinventoryitems i ON i.supplierId = s.supplierId " &
              "GROUP BY s.supplierId, s.supplierName, s.contactInfo, s.itemsSupplied " &
              "ORDER BY s.supplierName"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("supplierName").ToString())
                item.SubItems.Add(If(IsDBNull(dr("contactInfo")), "", dr("contactInfo").ToString()))
                item.SubItems.Add(If(IsDBNull(dr("itemsSupplied")), "", dr("itemsSupplied").ToString()))
                item.SubItems.Add(CLng(dr("itemCount")).ToString())
                item.Tag = dr("supplierId")
                lsvData.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading suppliers: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- Add / Edit / Delete ---------------------------------------------------

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenEditor(0)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditSelected()
    End Sub

    Private Sub lsvData_DoubleClick(sender As Object, e As EventArgs) Handles lsvData.DoubleClick
        EditSelected()
    End Sub

    Private Sub EditSelected()
        If lsvData.SelectedItems.Count = 0 Then
            MsgBox("Please select a row from the list to edit.", MsgBoxStyle.Information, "No Selection")
            Return
        End If

        OpenEditor(Convert.ToInt32(lsvData.SelectedItems(0).Tag))
    End Sub
    Private Sub OpenEditor(id As Integer)
        Dim saved As Boolean = False

        Select Case currentTab
            Case SetupTab.Products
                Using f As New frmEditProduct()
                    f.ProductID = id
                    saved = (f.ShowDialog() = DialogResult.OK)
                End Using
            Case SetupTab.InventoryItems
                Using f As New frmEditInventoryItem()
                    f.ItemID = id
                    saved = (f.ShowDialog() = DialogResult.OK)
                End Using
            Case SetupTab.Suppliers
                Using f As New frmEditSupplier()
                    f.SupplierID = id
                    saved = (f.ShowDialog() = DialogResult.OK)
                End Using
        End Select

        If saved Then LoadCurrent()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lsvData.SelectedItems.Count = 0 Then
            MsgBox("Please select a row from the list to delete.", MsgBoxStyle.Information, "No Selection")
            Return
        End If

        Dim selected As ListViewItem = lsvData.SelectedItems(0)
        Dim id As Integer = Convert.ToInt32(selected.Tag)
        Dim name As String = selected.Text

        If currentTab = SetupTab.InventoryItems Then
            If MsgBox("Delete inventory item """ & name & """?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete") <> MsgBoxResult.Yes Then Return
            DeleteRow("DELETE FROM tblinventoryitems WHERE itemId = @id", id,
                      """" & name & """ has stock history, so it can't be deleted.")

        ElseIf currentTab = SetupTab.Suppliers Then
            Dim linked As Integer = 0
            Integer.TryParse(selected.SubItems(3).Text, linked)

            Dim msg As String = "Delete supplier """ & name & """?"
            If linked > 0 Then
                msg &= vbCrLf & vbCrLf & linked.ToString() & " inventory item(s) use this supplier. " &
                       "They will be kept, but shown with no supplier."
            End If
            If MsgBox(msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete") <> MsgBoxResult.Yes Then Return

            DeleteRow("DELETE FROM tblsuppliers WHERE supplierId = @id", id,
                      "This supplier can't be deleted because other records still refer to it.")
        End If
    End Sub

    Private Sub DeleteRow(deleteSql As String, id As Integer, inUseMessage As String)
        Try
            connection()
            cmd = New MySqlCommand(deleteSql, cn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException When ex.Number = 1451
            MsgBox(inUseMessage, MsgBoxStyle.Exclamation, "Can't delete")
            Return
        Catch ex As Exception
            MsgBox("Error deleting: " & ex.Message, MsgBoxStyle.Critical)
            Return
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        LoadCurrent()
    End Sub

End Class
