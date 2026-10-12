Imports MySql.Data.MySqlClient

Public Class frmAddExpense

    Private Const MAX_AMOUNT As Decimal = 1000000D

    Private Sub frmAddExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpExpenseDate.MaxDate = Date.Today
        dtpExpenseDate.Value = Date.Today

        cboCategory.Items.Clear()
        cboCategory.Items.AddRange({"Utilities", "Salary", "Supplies", "Other"})
        cboCategory.SelectedIndex = -1
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        Dim isOther As Boolean = (cboCategory.Text = "Other")
        Guna2HtmlLabel2.Text = If(isOther, "DESCRIPTION (required)", "DESCRIPTION")
        txtDescription.PlaceholderText = If(isOther, "What is this expense for?", "")
    End Sub

    Private Function TryGetAmount(ByRef amount As Decimal) As Boolean
        Return Decimal.TryParse(txtAmount.Text.Trim(), System.Globalization.NumberStyles.Number,
                                 System.Globalization.CultureInfo.CurrentCulture, amount)
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If CurrentUserId <= 0 Then
            MsgBox("No logged-in user. Please log in again.", MsgBoxStyle.Exclamation, "Not logged in")
            Return
        End If

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveExpense()
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

        If cboCategory.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCategory, "Select a category.")
            isValid = False
        End If

        Dim amount As Decimal
        If Not TryGetAmount(amount) OrElse amount <= 0 Then
            errorProvider1.SetError(txtAmount, "Enter a valid amount greater than 0.")
            isValid = False
        ElseIf amount > MAX_AMOUNT Then
            errorProvider1.SetError(txtAmount, "That amount looks too large — please check it.")
            isValid = False
        End If

        If cboCategory.Text = "Other" AndAlso txtDescription.Text.Trim().Length < 3 Then
            errorProvider1.SetError(txtDescription, "Please describe what this 'Other' expense is for.")
            isValid = False
        End If

        If txtDescription.Text.Trim().Length > 255 Then
            errorProvider1.SetError(txtDescription, "Description is too long (max 255 characters).")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub SaveExpense()
        Dim amount As Decimal
        TryGetAmount(amount)
        amount = Math.Round(amount, 2)

        connection()

        sql = "INSERT INTO tblExpenses (expenseDate, category, amount, description, recordedBy) " &
              "VALUES (@date, @category, @amount, @description, @user)"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@date", dtpExpenseDate.Value.Date)
        cmd.Parameters.AddWithValue("@category", cboCategory.Text)
        cmd.Parameters.AddWithValue("@amount", amount)
        cmd.Parameters.AddWithValue("@description",
            If(txtDescription.Text.Trim() = "", DBNull.Value, CObj(txtDescription.Text.Trim())))
        cmd.Parameters.AddWithValue("@user", CurrentUserId)
        cmd.ExecuteNonQuery()

        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub
End Class