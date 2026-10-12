Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmEditProduct

    Private Const MAX_PRICE As Decimal = 100000D
    Private Const OTHER_ITEM As String = "Other (specify)"

    ''' <summary>0 = add a new product, otherwise the product being edited.</summary>
    Public Property ProductID As Integer

    Private Sub frmEditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.Items.Clear()
        cboCategory.Items.AddRange({"Gallon", "Bottled"})

        cboStatus.Items.Clear()
        cboStatus.Items.AddRange({"Active", "Discontinued"})

        ' Pick from what is already in use; "Other (specify)" opens a box for a genuinely new value
        LoadChoices(cboContainer, "containerType", {"Round", "Slim", "350mL", "500mL"})
        LoadChoices(cboWaterType, "waterType", {"Alkaline", "Mineral"})
        UpdateOtherBoxes()

        If ProductID > 0 Then
            lblFormTitle.Text = "Edit Product"
            Me.Text = "Edit Product"
            LoadProductData()
        Else
            cboCategory.SelectedIndex = -1
            cboStatus.SelectedIndex = 0
        End If
    End Sub

    ''' <summary>Fills a drop-down with the distinct values already used in tblproducts (plus the defaults).</summary>
    Private Sub LoadChoices(cbo As Guna.UI2.WinForms.Guna2ComboBox, columnName As String, defaults As String())
        Dim values As New List(Of String)(defaults)

        Try
            connection()
            ' columnName only ever comes from the two literals above, never from user input
            sql = "SELECT DISTINCT " & columnName & " FROM tblproducts ORDER BY " & columnName
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim v As String = dr(0).ToString().Trim()
                If v <> "" AndAlso Not values.Exists(Function(x) x.Equals(v, StringComparison.OrdinalIgnoreCase)) Then values.Add(v)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading choices: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        cbo.Items.Clear()
        For Each choice As String In values
            cbo.Items.Add(choice)
        Next
        cbo.Items.Add(OTHER_ITEM)
    End Sub

    Private Sub cboContainer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContainer.SelectedIndexChanged, cboWaterType.SelectedIndexChanged
        UpdateOtherBoxes()
    End Sub

    ' Show the "specify" box only when "Other (specify)" is chosen
    Private Sub UpdateOtherBoxes()
        Dim containerOther As Boolean = (cboContainer.Text = OTHER_ITEM)
        lblContainerOther.Visible = containerOther
        txtContainerOther.Visible = containerOther

        Dim waterOther As Boolean = (cboWaterType.Text = OTHER_ITEM)
        lblWaterOther.Visible = waterOther
        txtWaterOther.Visible = waterOther
    End Sub

    Private Sub LoadProductData()
        Try
            connection()
            sql = "SELECT category, containerType, waterType, unitPrice, status FROM tblproducts WHERE productId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", ProductID)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                SelectOrAdd(cboCategory, dr("category").ToString())
                SelectOrAdd(cboContainer, dr("containerType").ToString())
                SelectOrAdd(cboWaterType, dr("waterType").ToString())
                txtPrice.Text = CDec(dr("unitPrice")).ToString("0.00")
                SelectOrAdd(cboStatus, dr("status").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading product data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub SelectOrAdd(cbo As Guna.UI2.WinForms.Guna2ComboBox, value As String)
        If Not cbo.Items.Contains(value) Then
            Dim otherIndex As Integer = cbo.Items.IndexOf(OTHER_ITEM)
            If otherIndex >= 0 Then cbo.Items.Insert(otherIndex, value) Else cbo.Items.Add(value)
        End If
        cbo.SelectedItem = value
    End Sub

    Private Function TryGetPrice(ByRef price As Decimal) As Boolean
        Return Decimal.TryParse(txtPrice.Text.Trim(), System.Globalization.NumberStyles.Number,
                                 System.Globalization.CultureInfo.CurrentCulture, price)
    End Function

    ' --- The container / water type that will actually be saved ---------------

    Private Function Clean(text As String) As String
        Return Regex.Replace(text.Trim(), "\s+", " ")
    End Function

    ''' <summary>
    ''' The chosen value. A typed "Other" value that matches an existing one ignoring upper/lower case
    ''' ("round" vs "Round") uses the existing spelling, so near-duplicates can't creep in.
    ''' </summary>
    Private Function ChosenValue(cbo As Guna.UI2.WinForms.Guna2ComboBox, txtOther As Guna.UI2.WinForms.Guna2TextBox) As String
        If cbo.Text <> OTHER_ITEM Then Return cbo.Text

        Dim typed As String = Clean(txtOther.Text)
        For Each existing As Object In cbo.Items
            If existing.ToString() <> OTHER_ITEM AndAlso existing.ToString().Equals(typed, StringComparison.OrdinalIgnoreCase) Then
                Return existing.ToString()
            End If
        Next
        Return typed
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        ' Make sure the table accepts values beyond the original eight products
        If Not EnsureProductColumnsFlexible() Then Return

        Try
            If ProductExists() Then
                errorProvider1.SetError(cboWaterType, "This product already exists.")
                MsgBox("A product with the same category, container and water type already exists.",
                       MsgBoxStyle.Exclamation, "Duplicate product")
                Return
            End If

            If SaveProduct() Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("Nothing was updated. The product may have been deleted or changed.", MsgBoxStyle.Exclamation, "Not saved")
            End If
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    ''' <summary>Checks one drop-down (and its "specify" box). Returns True when it is fine.</summary>
    Private Function ValidateChoice(cbo As Guna.UI2.WinForms.Guna2ComboBox, txtOther As Guna.UI2.WinForms.Guna2TextBox, label As String) As Boolean
        If cbo.SelectedIndex = -1 Then
            errorProvider1.SetError(cbo, "Select the " & label & ".")
            Return False
        End If

        If cbo.Text <> OTHER_ITEM Then Return True

        Dim v As String = Clean(txtOther.Text)
        If v = "" Then
            errorProvider1.SetError(txtOther, "Type the new " & label & ".")
            Return False
        End If
        If v.Length < 2 OrElse v.Length > 30 Then
            errorProvider1.SetError(txtOther, "Use 2 to 30 characters.")
            Return False
        End If
        If Not Regex.IsMatch(v, "^[A-Za-z0-9][A-Za-z0-9 .\-/]*$") Then
            errorProvider1.SetError(txtOther, "Use letters, numbers, spaces, '.', '-' or '/' only.")
            Return False
        End If
        If Not Regex.IsMatch(v, "[A-Za-z]") Then
            errorProvider1.SetError(txtOther, "That doesn't look like a " & label & " (add a name, e.g. 1L).")
            Return False
        End If
        Return True
    End Function

    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        If cboCategory.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCategory, "Select a category.")
            isValid = False
        End If

        If Not ValidateChoice(cboContainer, txtContainerOther, "container") Then isValid = False
        If Not ValidateChoice(cboWaterType, txtWaterOther, "water type") Then isValid = False

        If cboStatus.SelectedIndex = -1 Then
            errorProvider1.SetError(cboStatus, "Select a status.")
            isValid = False
        End If

        Dim price As Decimal
        If Not TryGetPrice(price) OrElse price < 0 Then
            errorProvider1.SetError(txtPrice, "Enter a valid price (0 or more).")
            isValid = False
        ElseIf price > MAX_PRICE Then
            errorProvider1.SetError(txtPrice, "That price looks too large — please check it.")
            isValid = False
        ElseIf price = 0 AndAlso cboStatus.Text = "Active" Then
            errorProvider1.SetError(txtPrice, "An active product needs a price greater than 0.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Function ProductExists() As Boolean
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblproducts " &
                  "WHERE category = @category AND containerType = @container AND waterType = @water " &
                  "AND productId <> @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@category", cboCategory.Text)
            cmd.Parameters.AddWithValue("@container", ChosenValue(cboContainer, txtContainerOther))
            cmd.Parameters.AddWithValue("@water", ChosenValue(cboWaterType, txtWaterOther))
            cmd.Parameters.AddWithValue("@id", ProductID)
            Return CLng(cmd.ExecuteScalar()) > 0
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Function SaveProduct() As Boolean
        Dim price As Decimal
        TryGetPrice(price)
        price = Math.Round(price, 2)

        Dim rowsAffected As Integer = 0

        Try
            connection()

            If ProductID > 0 Then
                sql = "UPDATE tblproducts SET category = @category, containerType = @container, " &
                      "waterType = @water, unitPrice = @price, status = @status WHERE productId = @id"
            Else
                sql = "INSERT INTO tblproducts (category, containerType, waterType, unitPrice, status) " &
                      "VALUES (@category, @container, @water, @price, @status)"
            End If

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@category", cboCategory.Text)
            cmd.Parameters.AddWithValue("@container", ChosenValue(cboContainer, txtContainerOther))
            cmd.Parameters.AddWithValue("@water", ChosenValue(cboWaterType, txtWaterOther))
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@status", cboStatus.Text)
            If ProductID > 0 Then cmd.Parameters.AddWithValue("@id", ProductID)

            rowsAffected = cmd.ExecuteNonQuery()
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        Return rowsAffected > 0
    End Function
End Class
