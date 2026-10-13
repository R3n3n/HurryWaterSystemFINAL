Imports MySql.Data.MySqlClient

Public Class frmExpenses

    Private isLoading As Boolean = True

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        SetupDateRangeCombo()
        isLoading = False
        RefreshAll()
    End Sub

    Private Sub SetupDateRangeCombo()
        With cboDateRange
            .Items.Clear()
            .Items.AddRange({"This Month", "Last Month", "Last 7 Days", "This Year", "Last Year", "All Time"})
            .SelectedIndex = 0
        End With

        Me.Controls.Add(cboDateRange)
        cboDateRange.BringToFront()
    End Sub

    Private Sub cboDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateRange.SelectedIndexChanged
        If isLoading Then Return
        RefreshAll()
    End Sub
    Private Function GetSelectedDateRange() As (StartDate As Date, EndDate As Date)
        Dim today As Date = Date.Today

        Select Case cboDateRange.Text
            Case "Last 7 Days"
                Return (today.AddDays(-6), today)
            Case "Last Month"
                Dim firstOfLast As Date = New Date(today.Year, today.Month, 1).AddMonths(-1)
                Return (firstOfLast, firstOfLast.AddMonths(1).AddDays(-1))
            Case "This Year"
                Return (New Date(today.Year, 1, 1), today)
            Case "Last Year"
                Return (New Date(today.Year - 1, 1, 1), New Date(today.Year - 1, 12, 31))
            Case "All Time"
                Return (New Date(2000, 1, 1), New Date(2999, 12, 31))
            Case Else ' "This Month"
                Return (New Date(today.Year, today.Month, 1), today)
        End Select
    End Function

    Private Sub RefreshAll()
        Dim range = GetSelectedDateRange()
        UpdateCardCaptions()
        LoadExpenseSummary(range.StartDate, range.EndDate)
        LoadExpenseList(range.StartDate, range.EndDate)
    End Sub

    Private Sub UpdateCardCaptions()
        Label5.Text = "UTILITIES"
        Label1.Text = "SUPPLIES"
        Label3.Text = "SALARY"
        Label4.Text = "TOTAL"
    End Sub

    Private Sub SetupListView()
        lsvExpenses.View = View.Details
        lsvExpenses.FullRowSelect = True
        lsvExpenses.GridLines = True

        lsvExpenses.Columns.Clear()
        lsvExpenses.Columns.Add("Date", 293)
        lsvExpenses.Columns.Add("Category", 263)
        lsvExpenses.Columns.Add("Amount", 263)
        lsvExpenses.Columns.Add("Description", 732)
    End Sub

    Private Sub LoadExpenseSummary(startDate As Date, endDate As Date)
        lblGasTotal.Text = "₱0.00"
        lblSalaryTotal.Text = "₱0.00"
        lblSuppliesTotal.Text = "₱0.00"
        lblGrandTotal.Text = "₱0.00"

        Dim grandTotal As Decimal = 0

        sql = "SELECT category, SUM(amount) AS total FROM tblExpenses " &
              "WHERE expenseDate BETWEEN @start AND @end " &
              "GROUP BY category"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim category As String = dr("category").ToString()
                Dim total As Decimal = CDec(dr("total"))
                grandTotal += total

                Select Case category
                    Case "Utilities" : lblGasTotal.Text = "₱" & total.ToString("N2")
                    Case "Salary" : lblSalaryTotal.Text = "₱" & total.ToString("N2")
                    Case "Supplies" : lblSuppliesTotal.Text = "₱" & total.ToString("N2")
                End Select
            End While

            dr.Close()
            lblGrandTotal.Text = "₱" & grandTotal.ToString("N2")
        Catch ex As Exception
            MsgBox("Error loading expense summary: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub LoadExpenseList(startDate As Date, endDate As Date)
        lsvExpenses.Items.Clear()

        sql = "SELECT expenseId, expenseDate, category, amount, description " &
              "FROM tblExpenses WHERE expenseDate BETWEEN @start AND @end " &
              "ORDER BY expenseDate DESC, expenseId DESC"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(CDate(dr("expenseDate")).ToString("MMM d, yyyy"))
                item.SubItems.Add(dr("category").ToString())
                item.SubItems.Add("₱" & CDec(dr("amount")).ToString("N2"))
                item.SubItems.Add(If(IsDBNull(dr("description")), "", dr("description").ToString()))
                item.Tag = dr("expenseId")

                lsvExpenses.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading expenses: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click
        Using addForm As New frmAddExpense()
            addForm.ShowDialog()
        End Using

        RefreshAll()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lsvExpenses.SelectedItems.Count = 0 Then
            MsgBox("Please select an expense from the list to edit.", MsgBoxStyle.Information, "No Selection")
            Return
        End If

        Dim selectedId As Integer = Convert.ToInt32(lsvExpenses.SelectedItems(0).Tag)

        Using editForm As New frmEditExpense()
            editForm.ExpenseID = selectedId
            editForm.ShowDialog()
        End Using

        RefreshAll()
    End Sub
End Class