Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmEditCustomer
    Public Property CustomerID As Integer
    Private Sub frmEditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CustomerID > 0 Then
            LoadCustomerData()
        End If
    End Sub

    Private Sub LoadCustomerData()
        Try
            Call connection()
            sql = "SELECT * FROM tblCustomers WHERE CustomerID = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", CustomerID)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtName.Text = dr("customerName").ToString()
                txtContactNo.Text = dr("contactNo").ToString()
                txtAddress.Text = dr("address").ToString()
                cboCustomerType.SelectedItem = dr("customerType").ToString()
                txtDeliveryCycle.Text = dr("deliveryFrequencyDays").ToString()
                cboPaymentMode.SelectedItem = dr("preferredPaymentMode").ToString()
            End If
            dr.Close()
        Catch ex As MySqlException
            MsgBox("Error loading customer data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            If Not PassesDuplicateCheck() Then Return
            SaveCustomer()
            MsgBox("Customer updated successfully.", MsgBoxStyle.Information, "Success")
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

        Dim nameMessage As String = NameProblem(txtName.Text.Trim())
        If nameMessage <> "" Then
            errorProvider1.SetError(txtName, nameMessage)
            isValid = False
        End If

        Dim contactMessage As String = ContactProblem(txtContactNo.Text.Trim())
        If contactMessage <> "" Then
            errorProvider1.SetError(txtContactNo, contactMessage)
            isValid = False
        End If

        Dim address As String = txtAddress.Text.Trim()
        If String.IsNullOrEmpty(address) Then
            errorProvider1.SetError(txtAddress, "Address is required.")
            isValid = False
        End If

        If cboCustomerType.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCustomerType, "Select a customer type.")
            isValid = False
        End If

        Dim cycleText As String = txtDeliveryCycle.Text.Trim()
        Dim cycleValue As Integer
        If String.IsNullOrEmpty(cycleText) Then
            errorProvider1.SetError(txtDeliveryCycle, "Delivery cycle is required.")
            isValid = False
        ElseIf Not Integer.TryParse(cycleText, cycleValue) Then
            errorProvider1.SetError(txtDeliveryCycle, "Enter a whole number (e.g. 2).")
            isValid = False
        ElseIf cycleValue < 1 OrElse cycleValue > 30 Then
            errorProvider1.SetError(txtDeliveryCycle, "Cycle must be between 1 and 30 days.")
            isValid = False
        End If

        Return isValid
    End Function


    ''' <summary>
    ''' Hole 6: stops a second record for the same phone number, and asks before
    ''' adding someone with an identical name. The customer being edited is ignored, so saving without changes still works.
    ''' </summary>
    Private Function PassesDuplicateCheck() As Boolean
        Dim contact As String = NormalizeContact(txtContactNo.Text)

        Dim existingOwner As String = CustomerNameUsingContact(contact, CustomerID)
        If existingOwner <> "" Then
            errorProvider1.SetError(txtContactNo, "Already used by " & existingOwner & ".")
            MsgBox("This contact number is already registered to " & existingOwner & "." & vbCrLf &
                   "Use that customer's record instead of creating a second one.",
                   MsgBoxStyle.Exclamation, "Duplicate contact number")
            Return False
        End If

        Dim sameName As String = CustomerWithSameName(txtName.Text.Trim(), CustomerID)
        If sameName <> "" Then
            Return MsgBox("A customer with this name already exists:" & vbCrLf & vbCrLf & sameName & vbCrLf & vbCrLf &
                          "Save this one anyway?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2,
                          "Possible duplicate") = MsgBoxResult.Yes
        End If

        Return True
    End Function

    Private Sub SaveCustomer()
        Call connection()

        sql = "UPDATE tblCustomers SET " &
              "customerName = @name, " &
              "contactNo = @contact, " &
              "address = @address, " &
              "customerType = @type, " &
              "deliveryFrequencyDays = @cycle, " &
              "preferredPaymentMode = @payment " &
              "WHERE CustomerID = @id"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
        cmd.Parameters.AddWithValue("@contact", If(txtContactNo.Text.Trim() = "", DBNull.Value, CObj(NormalizeContact(txtContactNo.Text))))
        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim())
        cmd.Parameters.AddWithValue("@type", cboCustomerType.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@cycle", Integer.Parse(txtDeliveryCycle.Text.Trim()))
        cmd.Parameters.AddWithValue("@payment", If(cboPaymentMode.SelectedItem Is Nothing, "Cash", cboPaymentMode.SelectedItem.ToString()))

        cmd.Parameters.AddWithValue("@id", CustomerID)

        cmd.ExecuteNonQuery()
    End Sub
End Class