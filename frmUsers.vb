Imports MySql.Data.MySqlClient

Public Class frmUsers

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadUserList()
    End Sub

    Private Sub SetupListView()
        lsvUsers.View = View.Details
        lsvUsers.FullRowSelect = True
        lsvUsers.GridLines = True

        lsvUsers.Columns.Clear()
        lsvUsers.Columns.Add("Name", 380)
        lsvUsers.Columns.Add("Username", 380)
        lsvUsers.Columns.Add("Role", 220)
        lsvUsers.Columns.Add("Status", 512)
    End Sub

    Private Sub LoadUserList()
        lsvUsers.Items.Clear()

        sql = "SELECT userId, fullName, username, role, status FROM tblUsers ORDER BY fullName"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("fullName").ToString())
                item.SubItems.Add(dr("username").ToString())
                item.SubItems.Add(dr("role").ToString())
                item.SubItems.Add(dr("status").ToString())
                item.Tag = dr("userId")

                If dr("status").ToString() = "Deactivated" Then
                    item.ForeColor = Color.Gray   ' visually de-emphasize disabled accounts
                End If

                lsvUsers.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading users: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim addForm As New frmAddStaffAccount()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadUserList()
        End If

        addForm.Dispose()
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        If lsvUsers.SelectedItems.Count = 0 Then
            MsgBox("Select a user first.", MsgBoxStyle.Exclamation, "No selection")
            Return
        End If

        Dim selectedItem As ListViewItem = lsvUsers.SelectedItems(0)
        Dim selectedUserId As Integer = CInt(selectedItem.Tag)
        Dim currentStatus As String = selectedItem.SubItems(3).Text

        If selectedUserId = CurrentUserId Then
            MsgBox("You cannot deactivate your own account while logged in.", MsgBoxStyle.Exclamation, "Not allowed")
            Return
        End If

        Dim newStatus As String = If(currentStatus = "Active", "Deactivated", "Active")
        Dim actionWord As String = If(newStatus = "Deactivated", "deactivate", "reactivate")

        Dim confirm As MsgBoxResult = MsgBox(
            "Are you sure you want to " & actionWord & " " & selectedItem.Text & "'s account?",
            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm")

        If confirm <> MsgBoxResult.Yes Then Return

        Try
            connection()
            sql = "UPDATE tblUsers SET status = @status WHERE userId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@status", newStatus)
            cmd.Parameters.AddWithValue("@id", selectedUserId)
            cmd.ExecuteNonQuery()

            LoadUserList()
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lsvUsers.SelectedItems.Count = 0 Then
            MsgBox("Please select a user from the list to edit.", MsgBoxStyle.Information, "No Selection")
            Return
        End If

        Dim selectedId As Integer = Convert.ToInt32(lsvUsers.SelectedItems(0).Tag)
        Dim editForm As New frmEditStaffAccount()
        editForm.UserID = selectedId

        If editForm.ShowDialog() = DialogResult.OK Then
            LoadUserList()
        End If

        editForm.Dispose()
    End Sub
End Class