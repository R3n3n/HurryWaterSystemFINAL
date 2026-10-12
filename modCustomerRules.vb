Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Module modCustomerRules

    Public Function NameProblem(name As String) As String
        If String.IsNullOrWhiteSpace(name) Then Return "Customer name is required."
        If name.Length > 100 Then Return "Name is too long (max 100 characters)."

        If Not Regex.IsMatch(name, "^(?=.*\p{L})[\p{L}\p{N}.,'&()\-\s]+$") Then
            Return "Use letters, numbers and . , ' & ( ) - only."
        End If

        Return ""
    End Function

    Public Function ContactProblem(contact As String) As String
        If contact = "" Then Return ""
        If Not Regex.IsMatch(contact, "^(09\d{9}|\+639\d{9})$") Then
            Return "Enter a valid PH mobile number (e.g. 09171234567), or leave it blank."
        End If
        Return ""
    End Function

    Public Function NormalizeContact(contact As String) As String
        contact = contact.Trim()
        If contact.StartsWith("+63") Then Return "0" & contact.Substring(3)
        Return contact
    End Function

    Public Function CustomerNameUsingContact(contact As String, excludeCustomerId As Integer) As String
        If contact = "" Then Return ""

        Dim plusForm As String = "+63" & contact.Substring(1)
        Try
            connection()
            sql = "SELECT customerName FROM tblCustomers " &
                  "WHERE (contactNo = @c1 OR contactNo = @c2) AND customerId <> @id LIMIT 1"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@c1", contact)
            cmd.Parameters.AddWithValue("@c2", plusForm)
            cmd.Parameters.AddWithValue("@id", excludeCustomerId)
            Dim found As Object = cmd.ExecuteScalar()
            Return If(found Is Nothing, "", found.ToString())
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Public Function CustomerWithSameName(name As String, excludeCustomerId As Integer) As String
        Dim description As String = ""
        Try
            connection()
            sql = "SELECT customerName, contactNo, address FROM tblCustomers " &
                  "WHERE LOWER(TRIM(customerName)) = LOWER(@n) AND customerId <> @id LIMIT 1"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@n", name.Trim())
            cmd.Parameters.AddWithValue("@id", excludeCustomerId)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                description = dr("customerName").ToString() &
                              If(IsDBNull(dr("contactNo")), "", "  |  " & dr("contactNo").ToString()) &
                              If(IsDBNull(dr("address")), "", "  |  " & dr("address").ToString())
            End If
            dr.Close()
            Return description
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

End Module
