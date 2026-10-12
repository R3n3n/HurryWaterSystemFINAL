Imports MySql.Data.MySqlClient

Public Class frmEditStaffAccount
    Public Property UserID As Integer

    Private originalRole As String = ""

    Private Sub frmEditStaffAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.Items.Clear()
        cboRole.Items.AddRange({"Staff", "Owner"})

        ' Load existing data if an ID was passed
        If UserID > 0 Then
            LoadUserData()
            LockOwnRole()
        End If
    End Sub

    Private Sub LockOwnRole()
        If UserID <> CurrentUserId Then Return

        cboRole.Enabled = False

        Dim note As New Label()
        note.AutoSize = True
        note.BackColor = Color.Transparent
        note.ForeColor = Color.Gray
        note.Font = New Font("Segoe UI", 11.0F)
        note.Text = "You can't change your own role."
        note.Location = New Point(cboRole.Left + 4, cboRole.Bottom + 4)
        Controls.Add(note)
    End Sub

    Private Sub LoadUserData()
        Try
            connection()
            sql = "SELECT * FROM tblUsers WHERE userId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", UserID)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtFullName.Text = dr("fullName").ToString()
                txtUsername.Text = dr("username").ToString()
                cboRole.SelectedItem = dr("role").ToString()
                originalRole = dr("role").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading user data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveUser()
            MsgBox("User updated successfully.", MsgBoxStyle.Information, "Success")
            Me.DialogResult = DialogResult.OK
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        Dim fullName As String = txtFullName.Text.Trim()
        If String.IsNullOrEmpty(fullName) Then
            errorProvider1.SetError(txtFullName, "Full name is required.")
            isValid = False
        End If

        Dim username As String = txtUsername.Text.Trim()
        If String.IsNullOrEmpty(username) Then
            errorProvider1.SetError(txtUsername, "Username is required.")
            isValid = False
        ElseIf username.Contains(" ") Then
            errorProvider1.SetError(txtUsername, "Username cannot contain spaces.")
            isValid = False
        ElseIf UsernameAlreadyExists(username, UserID) Then
            errorProvider1.SetError(txtUsername, "That username is already taken by someone else.")
            isValid = False
        End If

        Dim password As String = txtPassword.Text
        If Not String.IsNullOrEmpty(password) AndAlso password.Length < 6 Then
            errorProvider1.SetError(txtPassword, "New password should be at least 6 characters.")
            isValid = False
        End If

        If cboRole.SelectedIndex = -1 Then
            errorProvider1.SetError(cboRole, "Select a role.")
            isValid = False
        End If

        If UserID = CurrentUserId AndAlso cboRole.Text <> originalRole Then
            errorProvider1.SetError(cboRole, "You can't change your own role.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Function UsernameAlreadyExists(username As String, currentUserId As Integer) As Boolean
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblUsers WHERE username = @username AND userId <> @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@id", currentUserId)
            Dim count As Long = CLng(cmd.ExecuteScalar())
            Return count > 0
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub SaveUser()
        connection()

        Dim isSelf As Boolean = (UserID = CurrentUserId)
        Dim roleClause As String = If(isSelf, "", ", role = @role")

        If String.IsNullOrEmpty(txtPassword.Text) Then
            sql = "UPDATE tblUsers SET fullName = @fullName, username = @username" & roleClause & " WHERE userId = @id"
        Else
            sql = "UPDATE tblUsers SET fullName = @fullName, username = @username, passwordHash = @password" & roleClause & " WHERE userId = @id"
        End If

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim())
        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
        If Not isSelf Then cmd.Parameters.AddWithValue("@role", cboRole.Text)
        cmd.Parameters.AddWithValue("@id", UserID)

        If Not String.IsNullOrEmpty(txtPassword.Text) Then
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        End If

        cmd.ExecuteNonQuery()

        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub

End Class