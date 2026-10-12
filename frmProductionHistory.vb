Imports MySql.Data.MySqlClient

Public Class frmProductionHistory

    Private isLoading As Boolean = True

    Private Sub frmProductionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsvLogs.View = View.Details                       ' <-- your ListView name
        lsvLogs.FullRowSelect = True
        lsvLogs.GridLines = True
        lsvLogs.Columns.Clear()
        lsvLogs.Columns.Add("Date", 263)
        lsvLogs.Columns.Add("Tank", 176)
        lsvLogs.Columns.Add("Liters", 205, HorizontalAlignment.Right)
        lsvLogs.Columns.Add("Gallons", 205, HorizontalAlignment.Right)
        lsvLogs.Columns.Add("350mL", 190, HorizontalAlignment.Right)
        lsvLogs.Columns.Add("500mL", 190, HorizontalAlignment.Right)
        lsvLogs.Columns.Add("Recorded By", 366)

        cboFilterTank.Items.Clear()
        cboFilterTank.Items.AddRange({"All tanks", "Tank-1", "Tank-2"})
        cboFilterTank.SelectedIndex = 0

        dtpFrom.Value = New Date(Date.Today.Year, Date.Today.Month, 1)   ' first day of this month
        dtpTo.Value = Date.Today

        isLoading = False
        LoadLogs()
    End Sub

    Private Sub LoadLogs()
        If dtpFrom.Value.Date > dtpTo.Value.Date Then
            MsgBox("'From' cannot be later than 'To'.", MsgBoxStyle.Exclamation)
            Return
        End If

        lsvLogs.Items.Clear()
        Dim totLiters As Decimal = 0D, totGallons As Decimal = 0D
        Dim tot350 As Integer = 0, tot500 As Integer = 0

        sql = "SELECT p.logDate, p.tankId, p.litersProduced, p.gallonEquivalent, " &
              "       p.bottle350mlEquivalent, p.bottle500mlEquivalent, u.username " &
              "FROM tblproductionlog p " &
              "LEFT JOIN tblusers u ON p.recordedBy = u.userId " &       ' <-- your users table (or remove the join)
              "WHERE p.logDate BETWEEN @from AND @to"
        If cboFilterTank.SelectedIndex > 0 Then sql &= " AND p.tankId = @tank"
        sql &= " ORDER BY p.logDate DESC, p.logId DESC"                  ' <-- logId = the table's ID column

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date)
            cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date)
            If cboFilterTank.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@tank", cboFilterTank.Text)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(CDate(dr("logDate")).ToString("MMM d, yyyy"))
                item.SubItems.Add(dr("tankId").ToString())
                item.SubItems.Add(CDec(dr("litersProduced")).ToString("N2"))
                item.SubItems.Add(CDec(dr("gallonEquivalent")).ToString("N2"))
                item.SubItems.Add(CInt(dr("bottle350mlEquivalent")).ToString("N0"))
                item.SubItems.Add(CInt(dr("bottle500mlEquivalent")).ToString("N0"))
                item.SubItems.Add(dr("username").ToString())
                lsvLogs.Items.Add(item)

                totLiters += CDec(dr("litersProduced"))
                totGallons += CDec(dr("gallonEquivalent"))
                tot350 += CInt(dr("bottle350mlEquivalent"))
                tot500 += CInt(dr("bottle500mlEquivalent"))
            End While
            dr.Close()

            lblTotalLiters.Text = totLiters.ToString("N2")
            lblTotalGallons.Text = totGallons.ToString("N2")
            lblTotal350.Text = tot350.ToString("N0")
            lblTotal500.Text = tot500.ToString("N0")
            lblLogCount.Text = lsvLogs.Items.Count & " logs in the selected dates"
        Catch ex As Exception
            MsgBox("Error loading production logs: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        If Not isLoading Then LoadLogs()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        If Not isLoading Then LoadLogs()
    End Sub

    Private Sub cboFilterTank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterTank.SelectedIndexChanged
        If Not isLoading Then LoadLogs()
    End Sub
End Class