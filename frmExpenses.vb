Imports MySql.Data.MySqlClient

Public Class frmExpenses

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        RefreshAll()
    End Sub

    Private Sub RefreshAll()
        LoadExpenseSummary()
        LoadExpenseList()
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

    Private Sub LoadExpenseSummary()
        lblGasTotal.Text = "₱0.00"
        lblSalaryTotal.Text = "₱0.00"
        lblSuppliesTotal.Text = "₱0.00"
        lblGrandTotal.Text = "₱0.00"

        Dim grandTotal As Decimal = 0

        sql = "SELECT category, SUM(amount) AS total FROM tblExpenses " &
              "WHERE MONTH(expenseDate) = MONTH(CURDATE()) AND YEAR(expenseDate) = YEAR(CURDATE()) " &
              "GROUP BY category"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim category As String = dr("category").ToString()
                Dim total As Decimal = CDec(dr("total"))
                grandTotal += total

                Select Case category
                    Case "Gas" : lblGasTotal.Text = "₱" & total.ToString("N2")
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

    Private Sub LoadExpenseList()
        lsvExpenses.Items.Clear()

        sql = "SELECT expenseId, expenseDate, category, amount, description " &
              "FROM tblExpenses ORDER BY expenseDate DESC, expenseId DESC"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
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