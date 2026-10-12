Imports MySql.Data.MySqlClient

Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToString("dddd, MMMM d, yyyy")

        SetupListViews()
        LoadStats()
        LoadDueToday()
        LoadLowStock()
    End Sub

    Private Sub SetupListViews()
        lsvDueToday.View = View.Details
        lsvDueToday.FullRowSelect = True
        lsvDueToday.GridLines = True
        lsvDueToday.Columns.Clear()
        lsvDueToday.Columns.Add("Customer", 220)
        lsvDueToday.Columns.Add("Contact", 161)
        lsvDueToday.Columns.Add("Type", 146)
        lsvDueToday.Columns.Add("Status", 190)

        lsvLowStock.View = View.Details
        lsvLowStock.FullRowSelect = True
        lsvLowStock.GridLines = True
        lsvLowStock.Columns.Clear()
        lsvLowStock.Columns.Add("Item", 278)
        lsvLowStock.Columns.Add("Stock", 102)
        lsvLowStock.Columns.Add("Reorder", 146)
    End Sub

    Private Sub LoadStats()
        Try
            connection()

            ' 1. Sales recorded today (Missed orders are not sales)
            sql = "SELECT COALESCE(SUM(totalAmount), 0) FROM tblSalesOrders " &
                  "WHERE orderDate = CURDATE() AND " & CountedOrders
            cmd = New MySqlCommand(sql, cn)
            Dim todaySales As Decimal = CDec(cmd.ExecuteScalar())

            ' 2. Orders not delivered yet. "Picked-up" counts too, since the
            '    containers are still with you until they're delivered back.
            sql = "SELECT COUNT(*) FROM tblSalesOrders WHERE pickupStatus IN ('Pending', 'Picked-up')"
            cmd = New MySqlCommand(sql, cn)
            Dim awaiting As Long = CLng(cmd.ExecuteScalar())

            ' 3. Everything still owed, regardless of date. A Missed order was never
            '    delivered, so the customer doesn't owe for it.
            sql = "SELECT COALESCE(SUM(totalAmount), 0) FROM tblSalesOrders " &
                  "WHERE paymentStatus = 'Unpaid' AND " & CountedOrders
            cmd = New MySqlCommand(sql, cn)
            Dim unpaid As Decimal = CDec(cmd.ExecuteScalar())

            ' 4. Dispensers past their expected return date and not yet returned
            sql = "SELECT COUNT(*) FROM tblDispenserBorrowing " &
                  "WHERE status <> 'Returned' AND expectedReturnDate < CURDATE()"
            cmd = New MySqlCommand(sql, cn)
            Dim overdue As Long = CLng(cmd.ExecuteScalar())

            lblTodaySales.Text = "₱" & todaySales.ToString("N2")
            lblAwaitingDelivery.Text = awaiting.ToString() & If(awaiting = 1, " order", " orders")
            lblUnpaidBalance.Text = "₱" & unpaid.ToString("N2")
            lblOverdueDispensers.Text = overdue.ToString()

            ' Red only when something actually needs attention
            lblUnpaidBalance.ForeColor = If(unpaid > 0, Color.Firebrick, Color.FromArgb(28, 43, 74))
            lblOverdueDispensers.ForeColor = If(overdue > 0, Color.Firebrick, Color.FromArgb(28, 43, 74))
        Catch ex As Exception
            MsgBox("Error loading dashboard summary: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- Who is due for pickup/delivery ----------------------------------

    ''' <summary>
    ''' A customer is "due" when (their last REAL order date + their delivery
    ''' cycle in days) is today or earlier. This is the digital version of the
    ''' list the owner currently types into the group chat each night.
    '''
    ''' A Missed order does NOT restart the clock: nothing was delivered, so the
    ''' customer is still waiting. If their latest order was Missed (or all of
    ''' their orders were) they are listed right away as "Missed - reschedule".
    ''' Recording a new order for a customer today makes them drop off this list,
    ''' because their last real order date becomes today.
    ''' Customers who have never ordered are left out on purpose.
    ''' </summary>
    Private Sub LoadDueToday()
        lsvDueToday.Items.Clear()

        sql = "SELECT c.customerName, c.contactNo, c.customerType, " &
              "       MAX(CASE WHEN o.pickupStatus <> 'Missed' THEN o.orderDate END) AS lastOrder, " &
              "       MAX(CASE WHEN o.pickupStatus = 'Missed' THEN o.orderDate END) AS lastMissed, " &
              "       DATE_ADD(MAX(CASE WHEN o.pickupStatus <> 'Missed' THEN o.orderDate END), " &
              "                INTERVAL COALESCE(c.deliveryFrequencyDays, 2) DAY) AS dueDate " &
              "FROM tblCustomers c " &
              "INNER JOIN tblSalesOrders o ON o.customerId = c.customerId " &
              "WHERE c.status = 'Active' " &
              "GROUP BY c.customerId, c.customerName, c.contactNo, c.customerType, c.deliveryFrequencyDays " &
              "HAVING lastOrder IS NULL OR lastMissed > lastOrder OR dueDate <= CURDATE() " &
              "ORDER BY dueDate, c.customerName"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("customerName").ToString())
                item.SubItems.Add(If(IsDBNull(dr("contactNo")), "", dr("contactNo").ToString()))
                item.SubItems.Add(dr("customerType").ToString())

                Dim missedAfterLastDelivery As Boolean =
                    IsDBNull(dr("lastOrder")) OrElse
                    (Not IsDBNull(dr("lastMissed")) AndAlso CDate(dr("lastMissed")) > CDate(dr("lastOrder")))

                If missedAfterLastDelivery Then
                    item.SubItems.Add("Missed - reschedule")
                    item.BackColor = Color.MistyRose
                Else
                    Dim daysLate As Integer = CInt((Date.Today - CDate(dr("dueDate")).Date).TotalDays)

                    If daysLate > 0 Then
                        item.SubItems.Add(daysLate.ToString() & If(daysLate = 1, " day overdue", " days overdue"))
                        item.BackColor = Color.MistyRose
                    Else
                        item.SubItems.Add("Due today")
                    End If
                End If

                lsvDueToday.Items.Add(item)
            End While

            dr.Close()

            If lsvDueToday.Items.Count = 0 Then
                Dim noneItem As New ListViewItem("Nobody is due right now")
                noneItem.SubItems.Add("")
                noneItem.SubItems.Add("")
                noneItem.SubItems.Add("")
                noneItem.ForeColor = Color.Gray
                lsvDueToday.Items.Add(noneItem)
            End If
        Catch ex As Exception
            MsgBox("Error loading pickup list: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- Low stock ----------------------------------------------------------

    Private Sub LoadLowStock()
        lsvLowStock.Items.Clear()

        sql = "SELECT itemName, currentStock, reorderPoint FROM tblInventoryItems " &
              "WHERE currentStock <= reorderPoint ORDER BY itemName"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("itemName").ToString())
                item.SubItems.Add(dr("currentStock").ToString())
                item.SubItems.Add(dr("reorderPoint").ToString())
                item.BackColor = Color.MistyRose
                lsvLowStock.Items.Add(item)
            End While

            dr.Close()

            If lsvLowStock.Items.Count = 0 Then
                Dim noneItem As New ListViewItem("All stock levels are fine")
                noneItem.SubItems.Add("")
                noneItem.SubItems.Add("")
                noneItem.ForeColor = Color.Gray
                lsvLowStock.Items.Add(noneItem)
            End If
        Catch ex As Exception
            MsgBox("Error loading low-stock items: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

End Class