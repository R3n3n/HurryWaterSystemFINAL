Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

''' <summary>
''' Customer checks shared by the Add and Edit customer screens.
''' </summary>
Module modCustomerRules

    ''' <summary>Returns a message if the name isn't acceptable, or "" if it is.</summary>
    Public Function NameProblem(name As String) As String
        If String.IsNullOrWhiteSpace(name) Then Return "Customer name is required."
        If name.Length > 100 Then Return "Name is too long (max 100 characters)."

        ' Letters, numbers and . , ' & ( ) - are fine, so "Store 2" or "Ana & Ben Water" works.
        ' At least one letter is still required, so a name can't be only digits or symbols.
        If Not Regex.IsMatch(name, "^(?=.*\p{L})[\p{L}\p{N}.,'&()\-\s]+$") Then
            Return "Use letters, numbers and . , ' & ( ) - only."
        End If

        Return ""
    End Function

    ''' <summary>
    ''' Contact is optional (some households have no phone), but if one is typed
    ''' it must be a PH mobile number.
    ''' </summary>
    Public Function ContactProblem(contact As String) As String
        If contact = "" Then Return ""
        If Not Regex.IsMatch(contact, "^(09\d{9}|\+639\d{9})$") Then
            Return "Enter a valid PH mobile number (e.g. 09171234567), or leave it blank."
        End If
        Return ""
    End Function

    ''' <summary>Stores +639... and 09... the same way so duplicates can be found.</summary>
    Public Function NormalizeContact(contact As String) As String
        contact = contact.Trim()
        If contact.StartsWith("+63") Then Return "0" & contact.Substring(3)
        Return contact
    End Function

    ''' <summary>
    ''' Name of ANOTHER customer who already has this contact number, or "" if nobody does.
    ''' excludeCustomerId is the customer being edited (0 when adding a new one).
    ''' </summary>
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

    ''' <summary>
    ''' Describes ANOTHER customer with the same name (ignoring capitals), or "" if there is none.
    ''' </summary>
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
