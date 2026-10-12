Imports MySql.Data.MySqlClient
Module dbConnect
    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String
    Public CurrentUserId As Integer
    Public CurrentUserRole As String
    Public CurrentUsername As String

    Public Sub connection()
        Try
            cn.Close()
            cn.ConnectionString = "server=localhost;user=root;password=;database=hurry_water_db"
            cn.Open()
        Catch ex As Exception
            MsgBox("Database connection error!", MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
