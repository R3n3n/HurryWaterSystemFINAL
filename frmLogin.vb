Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" OrElse txtPassword.Text = "" Then
            MsgBox("Please enter information for username and password.")
            Return
        End If

        Dim userId As Integer = 0
        Dim role As String = ""
        Dim loggedInName As String = ""

        Try
            connection()
            sql = "SELECT userId, username, role FROM tblusers " &
              "WHERE username = @username AND passwordHash = @password AND status = 'Active'"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then                     ' Read() BEFORE touching columns
                userId = CInt(dr("userId"))
                loggedInName = dr("username").ToString()
                role = dr("role").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Login error: " & ex.Message, MsgBoxStyle.Critical)
            Return
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        If userId = 0 Then
            MsgBox("Invalid username or password!", MsgBoxStyle.Critical)
            Return
        End If

        CurrentUserId = userId
        CurrentUserRole = role
        CurrentUsername = loggedInName
        MsgBox("Welcome " & role & "!", MsgBoxStyle.Information)

        txtUsername.Clear()
        txtPassword.Clear()

        Dim menu As New frmMenuBoard()
        menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class