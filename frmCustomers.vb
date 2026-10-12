Imports MySql.Data.MySqlClient

Public Class frmCustomers

    ' Same idea as frmSalesDelivery: don't search while the form is still starting up
    Private isLoading As Boolean = True

    ' Right-click menu on the customer list: Deactivate / Reactivate
    Private ReadOnly rowMenu As New ContextMenuStrip()
    Private ReadOnly toggleItem As New ToolStripMenuItem()
    Private ReadOnly hint As New ToolTip()

    Private Const STATUS_COLUMN As Integer = 4

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        SetupRowMenu()
        isLoading = False
        LoadCustomerList()
    End Sub

    Private Sub SetupListView()
        lsvCustomers.View = View.Details              ' <-- your ListView's name
        lsvCustomers.FullRowSelect = True
        lsvCustomers.GridLines = True
        lsvCustomers.HideSelection = False

        lsvCustomers.Columns.Clear()
        lsvCustomers.Columns.Add("Customer", 400)     ' <-- your columns
        lsvCustomers.Columns.Add("Contact", 260)
        lsvCustomers.Columns.Add("Customer Type", 300)
        lsvCustomers.Columns.Add("Frequency", 260)
        lsvCustomers.Columns.Add("Status", 230)
    End Sub

    Private Sub SetupRowMenu()
        rowMenu.Items.Add(toggleItem)
        AddHandler rowMenu.Opening, AddressOf rowMenu_Opening
        AddHandler toggleItem.Click, AddressOf toggleItem_Click
        lsvCustomers.ContextMenuStrip = rowMenu
        hint.SetToolTip(lsvCustomers, "Right-click a customer to deactivate or reactivate the account.")
    End Sub

    Private Sub LoadCustomerList()
        lsvCustomers.Items.Clear()

        sql = "SELECT customerId, customerName, contactNo, customerType, deliveryFrequencyDays, status " &
              "FROM tblCustomers " &
              "WHERE (customerName LIKE @search OR contactNo LIKE @search OR customerType LIKE @search) " &
              "ORDER BY (status = 'Active') DESC, customerName"

        Try
            connection()

            ' The label counts ACTIVE accounts in the whole database, not the rows
            ' that happen to be on screen (a search or inactive rows must not change it).
            Dim countCmd As New MySqlCommand("SELECT COUNT(*) FROM tblCustomers WHERE status = 'Active'", cn)
            Dim activeCount As Long = CLng(countCmd.ExecuteScalar())

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("customerName").ToString())
                item.SubItems.Add(dr("contactNo").ToString())
                item.SubItems.Add(dr("customerType").ToString())
                item.SubItems.Add(dr("deliveryFrequencyDays").ToString())
                item.SubItems.Add(dr("status").ToString())
                item.Tag = dr("customerId")

                If dr("status").ToString() <> "Active" Then item.ForeColor = Color.Gray

                lsvCustomers.Items.Add(item)
            End While

            dr.Close()

            lblActiveAccounts.Text = activeCount & If(activeCount = 1, " active account", " active accounts")
        Catch ex As Exception
            MsgBox("Error loading customers: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If isLoading Then Return
        LoadCustomerList()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        LoadCustomerList()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim addForm As New frmAddCustomer()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadCustomerList()
        End If

        addForm.Dispose()
    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        If lsvCustomers.SelectedItems.Count = 0 Then
            MsgBox("Please select a customer from the list to edit.", MsgBoxStyle.Information, "No Selection")
            Return
        End If

        Dim selectedId As Integer = Convert.ToInt32(lsvCustomers.SelectedItems(0).Tag)

        Dim editForm As New frmEditCustomer()

        editForm.CustomerID = selectedId

        If editForm.ShowDialog() = DialogResult.OK Then
            LoadCustomerList()
        End If

        editForm.Dispose()
    End Sub

    ' --- Hole 7: deactivate / reactivate ------------------------------------

    Private Sub rowMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If lsvCustomers.SelectedItems.Count = 0 Then
            e.Cancel = True
            Return
        End If

        Dim isActive As Boolean = (lsvCustomers.SelectedItems(0).SubItems(STATUS_COLUMN).Text = "Active")
        toggleItem.Text = If(isActive, "Deactivate customer...", "Reactivate customer")
    End Sub

    Private Sub toggleItem_Click(sender As Object, e As EventArgs)
        If lsvCustomers.SelectedItems.Count = 0 Then Return

        Dim item As ListViewItem = lsvCustomers.SelectedItems(0)
        Dim customerId As Integer = Convert.ToInt32(item.Tag)

        If item.SubItems(STATUS_COLUMN).Text = "Active" Then
            If Not ConfirmDeactivate(customerId, item.Text) Then Return
            SetCustomerStatus(customerId, "Inactive")
        Else
            SetCustomerStatus(customerId, "Active")
        End If

        LoadCustomerList()
    End Sub

    ''' <summary>
    ''' Asks before deactivating, and says plainly if the customer still owes
    ''' money or still has a dispenser out, so the owner doesn't lose track of it.
    ''' </summary>
    Private Function ConfirmDeactivate(customerId As Integer, customerName As String) As Boolean
        Dim unpaid As Decimal = 0
        Dim dispensersOut As Long = 0

        Try
            connection()

            sql = "SELECT COALESCE(SUM(totalAmount), 0) FROM tblSalesOrders " &
                  "WHERE customerId = @id AND paymentStatus = 'Unpaid' AND " & CountedOrders
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", customerId)
            unpaid = CDec(cmd.ExecuteScalar())

            sql = "SELECT COUNT(*) FROM tblDispenserBorrowing WHERE customerId = @id AND status <> 'Returned'"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", customerId)
            dispensersOut = CLng(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox("Could not check this customer's balance: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        Dim msg As String = "Deactivate " & customerName & "?" & vbCrLf & vbCrLf &
                            "They will no longer appear in the pickup list or in the customer pickers for new orders and dispenser records. " &
                            "Their past orders and totals stay exactly as they are, and you can reactivate them any time."

        If unpaid > 0 Then
            msg &= vbCrLf & vbCrLf & "Note: they still owe " & ChrW(8369) & unpaid.ToString("N2") & "."
        End If
        If dispensersOut > 0 Then
            msg &= vbCrLf & "Note: " & dispensersOut & If(dispensersOut = 1, " dispenser is", " dispensers are") & " not returned yet."
        End If

        Return MsgBox(msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Deactivate customer") = MsgBoxResult.Yes
    End Function

    Private Sub SetCustomerStatus(customerId As Integer, newStatus As String)
        Try
            connection()
            sql = "UPDATE tblCustomers SET status = @status WHERE customerId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@status", newStatus)
            cmd.Parameters.AddWithValue("@id", customerId)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Could not change the customer's status: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
End Class
