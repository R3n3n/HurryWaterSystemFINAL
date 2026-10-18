Imports MySql.Data.MySqlClient
Public Class frmAnnualReport

    Private isLoading As Boolean = True

    Private Sub frmAnnualReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadYears()
        isLoading = False
        LoadReport()
    End Sub

    Private Sub SetupListView()
        lsvMonths.View = View.Details
        lsvMonths.FullRowSelect = True
        lsvMonths.GridLines = True

        lsvMonths.Columns.Clear()
        lsvMonths.Columns.Add("Month", 130)
        lsvMonths.Columns.Add("Sales", 170, HorizontalAlignment.Right)
        lsvMonths.Columns.Add("vs Prev. Month", 150, HorizontalAlignment.Right)
        lsvMonths.Columns.Add("Same Month Last Year", 230, HorizontalAlignment.Right)
        lsvMonths.Columns.Add("vs Last Year", 140, HorizontalAlignment.Right)
        lsvMonths.Columns.Add("Paid", 170, HorizontalAlignment.Right)
        lsvMonths.Columns.Add("Expenses", 170, HorizontalAlignment.Right)
        lsvMonths.Columns.Add("Net (Paid - Exp.)", 170, HorizontalAlignment.Right)
    End Sub

    Private Sub LoadYears()
        Dim firstYear As Integer = Date.Today.Year

        Try
            connection()
            sql = "SELECT MIN(y) FROM (SELECT MIN(YEAR(orderDate)) AS y FROM tblSalesOrders " &
                  "UNION ALL SELECT MIN(YEAR(expenseDate)) FROM tblExpenses) t"
            cmd = New MySqlCommand(sql, cn)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then firstYear = Math.Min(firstYear, CInt(result))
        Catch ex As Exception
            MsgBox("Error loading years: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        cboYear.Items.Clear()
        For y As Integer = Date.Today.Year To firstYear Step -1
            cboYear.Items.Add(y.ToString())
        Next
        cboYear.SelectedIndex = 0
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        If isLoading Then Return
        LoadReport()
    End Sub

    Private Function MonthlyTotals(query As String, fromDate As Date, toDate As Date) As Dictionary(Of Integer, Decimal)
        Dim totals As New Dictionary(Of Integer, Decimal)

        connection()
        cmd = New MySqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@start", fromDate)
        cmd.Parameters.AddWithValue("@end", toDate)
        dr = cmd.ExecuteReader()
        While dr.Read()
            totals(CInt(dr("y")) * 100 + CInt(dr("m"))) = CDec(dr("total"))
        End While
        dr.Close()

        Return totals
    End Function

    Private Function ChangeText(current As Decimal, previous As Decimal) As String
        If previous = 0 Then Return If(current = 0, "—", "new")
        Return ((current - previous) / previous).ToString("+0.0%;-0.0%;0.0%")
    End Function

    Private Sub ColorChange(cell As ListViewItem.ListViewSubItem, current As Decimal, previous As Decimal)
        If previous = 0 Then Return
        cell.ForeColor = If(current >= previous, Color.SeaGreen, Color.Firebrick)
    End Sub

    Private Sub LoadReport()
        If cboYear.SelectedIndex = -1 Then Return

        Dim year As Integer = CInt(cboYear.Text)
        Dim sales As Dictionary(Of Integer, Decimal)
        Dim expenses As Dictionary(Of Integer, Decimal)
        Dim paid As Dictionary(Of Integer, Decimal)

        Try
            Dim fromDate As New Date(year - 1, 1, 1)
            Dim toDate As New Date(year, 12, 31)

            sales = MonthlyTotals("SELECT YEAR(orderDate) AS y, MONTH(orderDate) AS m, SUM(totalAmount) AS total " &
                                  "FROM tblSalesOrders WHERE orderDate BETWEEN @start AND @end AND " & CountedOrders & " " &
                                  "GROUP BY YEAR(orderDate), MONTH(orderDate)", fromDate, toDate)

            paid = MonthlyTotals("SELECT YEAR(orderDate) AS y, MONTH(orderDate) AS m, SUM(totalAmount) AS total " &
                                 "FROM tblSalesOrders WHERE paymentStatus = 'Paid' AND orderDate BETWEEN @start AND @end AND " & CountedOrders & " " &
                                 "GROUP BY YEAR(orderDate), MONTH(orderDate)", fromDate, toDate)

            expenses = MonthlyTotals("SELECT YEAR(expenseDate) AS y, MONTH(expenseDate) AS m, SUM(amount) AS total " &
                                     "FROM tblExpenses WHERE expenseDate BETWEEN @start AND @end " &
                                     "GROUP BY YEAR(expenseDate), MONTH(expenseDate)", fromDate, toDate)
        Catch ex As Exception
            MsgBox("Error loading report: " & ex.Message, MsgBoxStyle.Critical)
            Return
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        lsvMonths.Items.Clear()

        Dim lastMonth As Integer = If(year = Date.Today.Year, Date.Today.Month, 12)

        Dim totalSales, totalPaid, totalExpenses, totalLastYear As Decimal

        For m As Integer = 1 To 12
            Dim item As New ListViewItem(New Date(year, m, 1).ToString("MMMM"))
            item.UseItemStyleForSubItems = False

            If m > lastMonth Then
                For i As Integer = 1 To 7
                    item.SubItems.Add("—")
                Next
                item.ForeColor = Color.Gray
                For Each s As ListViewItem.ListViewSubItem In item.SubItems
                    s.ForeColor = Color.Gray
                Next
                lsvMonths.Items.Add(item)
                Continue For
            End If

            Dim cur As Decimal = If(sales.ContainsKey(year * 100 + m), sales(year * 100 + m), 0D)
            Dim prevKey As Integer = If(m = 1, (year - 1) * 100 + 12, year * 100 + m - 1)
            Dim prev As Decimal = If(sales.ContainsKey(prevKey), sales(prevKey), 0D)
            Dim lastYear As Decimal = If(sales.ContainsKey((year - 1) * 100 + m), sales((year - 1) * 100 + m), 0D)
            Dim exp As Decimal = If(expenses.ContainsKey(year * 100 + m), expenses(year * 100 + m), 0D)
            Dim paidAmt As Decimal = If(paid.ContainsKey(year * 100 + m), paid(year * 100 + m), 0D)
            Dim net As Decimal = paidAmt - exp   ' unpaid orders aren't income yet

            item.SubItems.Add("₱" & cur.ToString("N2"))
            Dim vsPrev = item.SubItems.Add(ChangeText(cur, prev))
            ColorChange(vsPrev, cur, prev)
            item.SubItems.Add("₱" & lastYear.ToString("N2"))
            Dim vsLast = item.SubItems.Add(ChangeText(cur, lastYear))
            ColorChange(vsLast, cur, lastYear)
            item.SubItems.Add("₱" & paidAmt.ToString("N2"))
            item.SubItems.Add("₱" & exp.ToString("N2"))
            Dim netCell = item.SubItems.Add("₱" & net.ToString("N2"))
            netCell.ForeColor = If(net < 0, Color.Firebrick, Color.DarkGreen)

            totalSales += cur
            totalPaid += paidAmt
            totalExpenses += exp
            totalLastYear += lastYear

            lsvMonths.Items.Add(item)
        Next

        Dim totalItem As New ListViewItem("TOTAL")
        totalItem.UseItemStyleForSubItems = False
        totalItem.Font = New Font(lsvMonths.Font, FontStyle.Bold)
        totalItem.SubItems.Add("₱" & totalSales.ToString("N2")).Font = totalItem.Font
        totalItem.SubItems.Add("")
        totalItem.SubItems.Add("₱" & totalLastYear.ToString("N2")).Font = totalItem.Font
        Dim totalVs = totalItem.SubItems.Add(ChangeText(totalSales, totalLastYear))
        totalVs.Font = totalItem.Font
        ColorChange(totalVs, totalSales, totalLastYear)
        totalItem.SubItems.Add("₱" & totalPaid.ToString("N2")).Font = totalItem.Font
        totalItem.SubItems.Add("₱" & totalExpenses.ToString("N2")).Font = totalItem.Font
        Dim totalNet As Decimal = totalPaid - totalExpenses
        Dim totalNetCell = totalItem.SubItems.Add("₱" & totalNet.ToString("N2"))
        totalNetCell.Font = totalItem.Font
        totalNetCell.ForeColor = If(totalNet < 0, Color.Firebrick, Color.DarkGreen)
        totalItem.BackColor = Color.FromArgb(232, 238, 248)
        lsvMonths.Items.Add(totalItem)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnExportMonths_Click(sender As Object, e As EventArgs) Handles btnExportMonths.Click
        ExportListViewToCsv(lsvMonths, "annual_report_" & cboYear.Text)
    End Sub

End Class
