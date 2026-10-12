Imports MySql.Data.MySqlClient

Public Class frmInventory

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadInventory()
    End Sub

    Private Sub SetupListView()
        lsvInventory.View = View.Details
        lsvInventory.FullRowSelect = True
        lsvInventory.GridLines = True
        lsvInventory.Font = New Font("Microsoft Sans Serif", 20.5F, FontStyle.Regular)  ' remove if you prefer the Designer's 18pt bold

        lsvInventory.Columns.Clear()
        lsvInventory.Columns.Add("Item", 439)
        lsvInventory.Columns.Add("Unit", 117)
        lsvInventory.Columns.Add("Stock", 146, HorizontalAlignment.Right)
        lsvInventory.Columns.Add("Reorder At", 176, HorizontalAlignment.Right)
        lsvInventory.Columns.Add("Unit Cost", 161, HorizontalAlignment.Right)
        lsvInventory.Columns.Add("Value", 190, HorizontalAlignment.Right)
        lsvInventory.Columns.Add("Status", 263)
    End Sub

    ' 1500 -> "1,500"   12.5 -> "12.5"   0 -> "0"
    Private Function FormatQty(q As Decimal) As String
        Return q.ToString("#,0.##")
    End Function

    Private Sub LoadInventory()
        lsvInventory.Items.Clear()

        ' unitCost is a generated column (packCost / packSize); IFNULL guards packSize = 0
        sql = "SELECT itemId, itemName, unit, currentStock, reorderPoint, IFNULL(unitCost, 0) AS unitCost " &
              "FROM tblinventoryitems ORDER BY itemId"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim stock As Decimal = CDec(dr("currentStock"))
                Dim reorder As Decimal = CDec(dr("reorderPoint"))
                Dim cost As Decimal = CDec(dr("unitCost"))

                Dim item As New ListViewItem(dr("itemName").ToString())
                item.SubItems.Add(dr("unit").ToString())
                item.SubItems.Add(FormatQty(stock))
                item.SubItems.Add(FormatQty(reorder))
                item.SubItems.Add("₱" & cost.ToString("N2"))
                item.SubItems.Add("₱" & (stock * cost).ToString("N2"))   ' value of stock on hand

                ' Status like the mockup: OK (green) or Restock (red). Zero stock also counts as Restock.
                item.UseItemStyleForSubItems = False
                Dim status As ListViewItem.ListViewSubItem
                If stock <= reorder Then
                    status = item.SubItems.Add("Restock")
                    status.ForeColor = Color.Firebrick
                Else
                    status = item.SubItems.Add("OK")
                    status.ForeColor = Color.SeaGreen
                End If

                item.Tag = dr("itemId")
                lsvInventory.Items.Add(item)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading inventory: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        Using f As New frmStockIn()
            If f.ShowDialog() = DialogResult.OK Then LoadInventory()
        End Using
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        Using f As New frmStockOut()
            If f.ShowDialog() = DialogResult.OK Then LoadInventory()
        End Using
    End Sub

End Class