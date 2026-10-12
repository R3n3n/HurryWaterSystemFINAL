Imports MySql.Data.MySqlClient

Public Class frmAddStaffAccount

    Private Sub frmAddStaffAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.Items.Clear()
        cboRole.Items.AddRange({"Staff", "Owner"})
        cboRole.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveUser()
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
        ElseIf UsernameAlreadyExists(username) Then
            errorProvider1.SetError(txtUsername, "That username is already taken.")
            isValid = False
        End If

        Dim password As String = txtPassword.Text
        If String.IsNullOrEmpty(password) Then
            errorProvider1.SetError(txtPassword, "Temporary password is required.")
            isValid = False
        ElseIf password.Length < 6 Then
            errorProvider1.SetError(txtPassword, "Password should be at least 6 characters.")
            isValid = False
        End If

        If cboRole.SelectedIndex = -1 Then
            errorProvider1.SetError(lblRole, "Select a role.")
            isValid = False
        End If

        Return isValid
    End Function

    ''' <summary>
    ''' Checks the database directly rather than relying on the INSERT
    ''' to fail on the UNIQUE constraint — this gives a clear, specific
    ''' error tied to the exact field, instead of a generic MySQL
    ''' "duplicate entry" exception the user won't understand.
    ''' </summary>
    Private Function UsernameAlreadyExists(username As String) As Boolean
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblUsers WHERE username = @username"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@username", username)
            Dim count As Long = CLng(cmd.ExecuteScalar())
            Return count > 0
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub SaveUser()
        connection()

        sql = "INSERT INTO tblUsers (fullName, username, passwordHash, role, status) " &
              "VALUES (@fullName, @username, @password, @role, 'Active')"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim())
        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)   ' plain text — see security note above
        cmd.Parameters.AddWithValue("@role", cboRole.Text)
        cmd.ExecuteNonQuery()

        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub

End Class