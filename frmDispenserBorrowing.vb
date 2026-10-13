Imports MySql.Data.MySqlClient

Public Class frmDispenserBorrowing

    Private Sub frmDispenserBorrowing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadBorrowList()
    End Sub

    Private Sub SetupListView()
        lsvBorrowing.View = View.Details
        lsvBorrowing.FullRowSelect = True
        lsvBorrowing.GridLines = True

        lsvBorrowing.Columns.Clear()
        lsvBorrowing.Columns.Add("Customer", 344)
        lsvBorrowing.Columns.Add("Dispenser Ref.", 322)
        lsvBorrowing.Columns.Add("Borrowed", 263)
        lsvBorrowing.Columns.Add("Expected Return", 351)
        lsvBorrowing.Columns.Add("Status", 263)
    End Sub
    Private Sub LoadBorrowList()
        lsvBorrowing.Items.Clear()

        sql = "SELECT b.borrowId, c.customerName, b.dispenserRef, " &
              "       b.dateBorrowed, b.expectedReturnDate, b.dateReturned, b.status " &
              "FROM tblDispenserBorrowing b " &
              "INNER JOIN tblCustomers c ON b.customerId = c.customerId " &
              "ORDER BY (b.status = 'Returned'), b.expectedReturnDate ASC"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim storedStatus As String = dr("status").ToString()
                Dim expectedReturn As Date = CDate(dr("expectedReturnDate"))

                Dim item As New ListViewItem(dr("customerName").ToString())
                item.SubItems.Add(dr("dispenserRef").ToString())
                item.SubItems.Add(CDate(dr("dateBorrowed")).ToString("MMM d, yyyy"))
                item.SubItems.Add(expectedReturn.ToString("MMM d, yyyy"))

                If storedStatus = "Returned" Then
                    item.SubItems.Add("Returned")
                    item.BackColor = Color.Honeydew
                ElseIf expectedReturn.Date < Date.Today Then
                    item.SubItems.Add("Overdue")
                    item.BackColor = Color.MistyRose
                Else
                    item.SubItems.Add("Borrowed")
                    ' default (no highlight) — still out, but not late
                End If

                item.Tag = dr("borrowId")
                lsvBorrowing.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading borrow records: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnAddBorrow_Click(sender As Object, e As EventArgs) Handles btnAddBorrow.Click
        Dim addForm As New frmAddBorrowRecord()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadBorrowList()
        End If

        addForm.Dispose()
    End Sub

    ''' <summary>
    ''' Marks the selected row's dispenser as returned. Guards against
    ''' no selection and against re-returning something already returned.
    ''' </summary>
    Private Sub btnMarkReturned_Click(sender As Object, e As EventArgs) Handles btnMarkReturned.Click
        If lsvBorrowing.SelectedItems.Count = 0 Then
            MsgBox("Select a record first.", MsgBoxStyle.Exclamation, "No selection")
            Return
        End If

        Dim selectedItem As ListViewItem = lsvBorrowing.SelectedItems(0)
        Dim currentStatusText As String = selectedItem.SubItems(4).Text

        If currentStatusText = "Returned" Then
            MsgBox("This dispenser is already marked as returned.", MsgBoxStyle.Information, "Already returned")
            Return
        End If

        Dim confirm As MsgBoxResult = MsgBox(
            "Mark this dispenser as returned by " & selectedItem.Text & "?",
            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm return")

        If confirm <> MsgBoxResult.Yes Then Return

        Dim borrowId As Integer = CInt(selectedItem.Tag)

        Try
            connection()
            sql = "UPDATE tblDispenserBorrowing SET dateReturned = @today, status = 'Returned' " &
                  "WHERE borrowId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@today", Date.Today)
            cmd.Parameters.AddWithValue("@id", borrowId)
            cmd.ExecuteNonQuery()

            LoadBorrowList()
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

End Class