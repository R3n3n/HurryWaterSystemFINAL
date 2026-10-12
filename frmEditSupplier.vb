Imports MySql.Data.MySqlClient

Public Class frmEditSupplier

    ''' <summary>0 = add a new supplier, otherwise the supplier being edited.</summary>
    Public Property SupplierID As Integer

    Private Sub frmEditSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SupplierID > 0 Then
            lblFormTitle.Text = "Edit Supplier"
            Me.Text = "Edit Supplier"
            LoadSupplierData()
        End If
    End Sub

    Private Sub LoadSupplierData()
        Try
            connection()
            sql = "SELECT supplierName, contactInfo, itemsSupplied FROM tblsuppliers WHERE supplierId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", SupplierID)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtSupplierName.Text = dr("supplierName").ToString()
                txtContact.Text = dr("contactInfo").ToString()
                txtItemsSupplied.Text = dr("itemsSupplied").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading supplier data: " & ex.Message, MsgBoxStyle.Critical)
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
            If NameInUse() Then
                errorProvider1.SetError(txtSupplierName, "A supplier with this name already exists.")
                MsgBox("A supplier with this name already exists.", MsgBoxStyle.Exclamation, "Duplicate supplier")
                Return
            End If

            If SaveSupplier() Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("Nothing was updated. The supplier may have been deleted or changed.", MsgBoxStyle.Exclamation, "Not saved")
            End If
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        Dim name As String = txtSupplierName.Text.Trim()
        If name = "" Then
            errorProvider1.SetError(txtSupplierName, "Enter the supplier's name.")
            isValid = False
        ElseIf name.Length > 100 Then
            errorProvider1.SetError(txtSupplierName, "Name is too long (max 100 characters).")
            isValid = False
        End If

        ' Contact and items supplied are optional, but capped to the column sizes
        If txtContact.Text.Trim().Length > 150 Then
            errorProvider1.SetError(txtContact, "Too long (max 150 characters).")
            isValid = False
        End If

        If txtItemsSupplied.Text.Trim().Length > 255 Then
            errorProvider1.SetError(txtItemsSupplied, "Too long (max 255 characters).")
            isValid = False
        End If

        Return isValid
    End Function

    Private Function NameInUse() As Boolean
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblsuppliers WHERE supplierName = @name AND supplierId <> @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@name", txtSupplierName.Text.Trim())
            cmd.Parameters.AddWithValue("@id", SupplierID)
            Return CLng(cmd.ExecuteScalar()) > 0
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Function OptionalValue(text As String) As Object
        Return If(text.Trim() = "", DBNull.Value, CObj(text.Trim()))
    End Function

    Private Function SaveSupplier() As Boolean
        Dim rowsAffected As Integer = 0

        Try
            connection()

            If SupplierID > 0 Then
                sql = "UPDATE tblsuppliers SET supplierName = @name, contactInfo = @contact, " &
                      "itemsSupplied = @items WHERE supplierId = @id"
            Else
                sql = "INSERT INTO tblsuppliers (supplierName, contactInfo, itemsSupplied) " &
                      "VALUES (@name, @contact, @items)"
            End If

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@name", txtSupplierName.Text.Trim())
            cmd.Parameters.AddWithValue("@contact", OptionalValue(txtContact.Text))
            cmd.Parameters.AddWithValue("@items", OptionalValue(txtItemsSupplied.Text))
            If SupplierID > 0 Then cmd.Parameters.AddWithValue("@id", SupplierID)

            rowsAffected = cmd.ExecuteNonQuery()
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        Return rowsAffected > 0
    End Function
End Class
