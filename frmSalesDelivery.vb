Imports MySql.Data.MySqlClient

Public Class frmSalesDelivery
    Private isLoading As Boolean = True

    Private auditAvailable As Boolean = True


    Private Sub frmSalesDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auditAvailable = EnsureOrderAuditColumns()
        SetupListView()

        cboFilterPickup.Items.Clear()
        cboFilterPickup.Items.AddRange({"All pickup statuses", "Pending", "Picked-up", "Delivered", "Missed"})
        cboFilterPickup.SelectedIndex = 0

        cboFilterPayment.Items.Clear()
        cboFilterPayment.Items.AddRange({"All payment statuses", "Unpaid", "Paid"})
        cboFilterPayment.SelectedIndex = 0

        cboFilterWeek.Items.Clear()
        cboFilterWeek.Items.AddRange({"All dates", "This Week", "This Month", "Last Year"})
        cboFilterWeek.SelectedIndex = 0

        btnUpdateStatus.Enabled = False
        btnDeleteOrder.Enabled = False
        btnDeleteOrder.Visible = (CurrentUserRole = "Owner")

        Label1.Font = New Font("Segoe UI", 20.0F, FontStyle.Regular)

        isLoading = False
        LoadOrderList()
    End Sub

    Private Sub SetupListView()
        lsvOrders.View = View.Details
        lsvOrders.FullRowSelect = True
        lsvOrders.GridLines = True
        lsvOrders.HideSelection = False

        lsvOrders.Columns.Clear()
        lsvOrders.Columns.Add("Order No.", 140)
        lsvOrders.Columns.Add("Order Date", 170)
        lsvOrders.Columns.Add("Customer", 270)
        lsvOrders.Columns.Add("Pickup Status", 170)
        lsvOrders.Columns.Add("Payment", 120)
        lsvOrders.Columns.Add("Total", 150, HorizontalAlignment.Right)
        lsvOrders.Columns.Add("Recorded By", 190)
        lsvOrders.Columns.Add("Last Updated By", 200)
    End Sub
    Private Function GetDateFilter(ByRef startDate As Date, ByRef endDate As Date) As Boolean
        Dim today As Date = Date.Today

        Select Case cboFilterWeek.Text
            Case "This Week"
                startDate = today.AddDays(-((CInt(today.DayOfWeek) + 6) Mod 7))   ' Monday
                endDate = today
                Return True
            Case "This Month"
                startDate = New Date(today.Year, today.Month, 1)
                endDate = today
                Return True
            Case "Last Year"
                startDate = New Date(today.Year - 1, 1, 1)
                endDate = New Date(today.Year - 1, 12, 31)
                Return True
            Case Else   ' "All dates"
                Return False
        End Select
    End Function

    Private Sub LoadOrderList()
        lsvOrders.Items.Clear()
        UpdateWeekSummary()

        sql = "SELECT o.orderId, o.orderDate, c.customerName, o.pickupStatus, " &
              "       o.paymentStatus, o.totalAmount, ru.fullName AS recordedByName, " &
              If(auditAvailable, "hu.fullName AS handledByName ", "NULL AS handledByName ") &
              "FROM tblSalesOrders o " &
              "INNER JOIN tblCustomers c ON o.customerId = c.customerId " &
              "LEFT JOIN tblUsers ru ON ru.userId = o.userId " &
              If(auditAvailable, "LEFT JOIN tblUsers hu ON hu.userId = o.handledBy ", "") &
              "WHERE (c.customerName LIKE @search " &
              "       OR CONCAT('ORD-', LPAD(o.orderId, 5, '0')) LIKE @search " &
              "       OR CAST(o.orderId AS CHAR) = @exact)"

        Dim filterPickup As Boolean = (cboFilterPickup.SelectedIndex > 0)
        Dim filterPayment As Boolean = (cboFilterPayment.SelectedIndex > 0)

        Dim startDate, endDate As Date
        Dim filterDate As Boolean = GetDateFilter(startDate, endDate)

        If filterPickup Then sql &= " AND o.pickupStatus = @pickupStatus"
        If filterPayment Then sql &= " AND o.paymentStatus = @paymentStatus"
        If filterDate Then sql &= " AND o.orderDate BETWEEN @startDate AND @endDate"
        sql &= " ORDER BY o.orderDate DESC, o.orderId DESC"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
            cmd.Parameters.AddWithValue("@exact", txtSearch.Text.Trim())
            If filterPickup Then cmd.Parameters.AddWithValue("@pickupStatus", cboFilterPickup.Text)
            If filterPayment Then cmd.Parameters.AddWithValue("@paymentStatus", cboFilterPayment.Text)
            If filterDate Then
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)
            End If
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(FormatOrderNo(CInt(dr("orderId"))))
                item.SubItems.Add(CDate(dr("orderDate")).ToString("MMM d, yyyy"))
                item.SubItems.Add(dr("customerName").ToString())
                item.SubItems.Add(dr("pickupStatus").ToString())
                item.SubItems.Add(dr("paymentStatus").ToString())
                item.SubItems.Add("₱" & CDec(dr("totalAmount")).ToString("N2"))
                item.SubItems.Add(If(IsDBNull(dr("recordedByName")), "—", dr("recordedByName").ToString()))
                item.SubItems.Add(If(IsDBNull(dr("handledByName")), "—", dr("handledByName").ToString()))
                item.Tag = dr("orderId")

                If dr("paymentStatus").ToString() = "Unpaid" Then
                    item.BackColor = Color.MistyRose
                End If

                lsvOrders.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading orders: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub UpdateWeekSummary()
        Dim monday As Date = Date.Today.AddDays(-((CInt(Date.Today.DayOfWeek) + 6) Mod 7))
        Dim thisWeek As Long = 0
        Dim stillActive As Long = 0

        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblSalesOrders WHERE orderDate >= @monday AND orderDate <= @today"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@monday", monday)
            cmd.Parameters.AddWithValue("@today", Date.Today)
            thisWeek = CLng(cmd.ExecuteScalar())

            sql = "SELECT COUNT(*) FROM tblSalesOrders WHERE pickupStatus IN ('Pending', 'Picked-up')"
            cmd = New MySqlCommand(sql, cn)
            stillActive = CLng(cmd.ExecuteScalar())
        Catch ex As Exception
            Label1.Text = "—"
            Return
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        Label1.Text = thisWeek.ToString() & If(thisWeek = 1, " order", " orders") & " this week  ·  " &
                      stillActive.ToString() & " still active"
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If isLoading Then Return
        LoadOrderList()
    End Sub

    Private Sub cboFilterPickup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterPickup.SelectedIndexChanged
        If isLoading Then Return
        LoadOrderList()
    End Sub

    Private Sub cboFilterPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterPayment.SelectedIndexChanged
        If isLoading Then Return
        LoadOrderList()
    End Sub

    Private Sub cboFilterWeek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterWeek.SelectedIndexChanged
        If isLoading Then Return
        LoadOrderList()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim addForm As New frmAddSalesOrder()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadOrderList()
        End If

        addForm.Dispose()
    End Sub


    Private Sub lsvOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvOrders.SelectedIndexChanged
        btnUpdateStatus.Enabled = (lsvOrders.SelectedItems.Count > 0)
        btnDeleteOrder.Enabled = (lsvOrders.SelectedItems.Count > 0)
    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        OpenUpdateStatusModal()
    End Sub

    ' Double-click shows what was ordered (item, quantity, price). Use the Update Status button to change statuses.
    Private Sub lsvOrders_DoubleClick(sender As Object, e As EventArgs) Handles lsvOrders.DoubleClick
        If lsvOrders.SelectedItems.Count = 0 Then Return

        Dim detailsForm As New frmOrderDetails()
        detailsForm.OrderId = CInt(lsvOrders.SelectedItems(0).Tag)
        detailsForm.ShowDialog()
        detailsForm.Dispose()
    End Sub

    Private Sub OpenUpdateStatusModal()
        If lsvOrders.SelectedItems.Count = 0 Then
            MsgBox("Select an order first.", MsgBoxStyle.Exclamation, "No selection")
            Return
        End If

        Dim statusForm As New frmUpdateOrderStatus()
        statusForm.OrderId = CInt(lsvOrders.SelectedItems(0).Tag)

        If statusForm.ShowDialog() = DialogResult.OK Then
            LoadOrderList()
        End If

        statusForm.Dispose()
    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        If lsvOrders.SelectedItems.Count = 0 Then
            MsgBox("Select an order first.", MsgBoxStyle.Exclamation, "No selection")
            Return
        End If

        Dim selected As ListViewItem = lsvOrders.SelectedItems(0)
        Dim orderId As Integer = CInt(selected.Tag)

        Dim msg As String = "Delete order " & selected.Text & " for " & selected.SubItems(2).Text &
                            " (" & selected.SubItems(5).Text & ")?" & vbCrLf & vbCrLf &
                            "The order and its items will be removed permanently."

        If MsgBox(msg, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2, "Confirm Delete") <> MsgBoxResult.Yes Then Return

        Dim txn As MySqlTransaction = Nothing
        Try
            connection()
            txn = cn.BeginTransaction()

            sql = "DELETE FROM tblSalesOrderDetails WHERE orderId = @id"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@id", orderId)
            cmd.ExecuteNonQuery()

            sql = "DELETE FROM tblSalesOrders WHERE orderId = @id"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@id", orderId)
            cmd.ExecuteNonQuery()

            txn.Commit()
        Catch ex As Exception
            If txn IsNot Nothing Then
                Try
                    txn.Rollback()
                Catch
                End Try
            End If
            MsgBox("Could not delete the order: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        LoadOrderList()
    End Sub

    Private Sub btnExportOrders_Click(sender As Object, e As EventArgs) Handles btnExportOrders.Click
        ExportListViewToCsv(lsvOrders, "sales_orders")
    End Sub

End Class