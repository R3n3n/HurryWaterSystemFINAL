Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class frmStockOut

    Private Const MAX_QTY As Decimal = 1000000D

    Private itemsTable As DataTable
    Private isLoading As Boolean = True

    Private Sub frmStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboReason.Items.Clear()
        cboReason.Items.AddRange({"Used in production", "Damaged / spoiled", "Sample / giveaway", "Other"})
        cboReason.SelectedIndex = 0

        dtpDate.MaxDate = Date.Today   ' no stock-outs dated in the future
        dtpDate.Value = Date.Today

        LoadItems()
        isLoading = False
        RefreshItemInfo()
    End Sub

    ' 1500 -> "1,500"   12.5 -> "12.5"   0 -> "0"
    Private Function FormatQty(q As Decimal) As String
        Return q.ToString("#,0.##")
    End Function

    Private Sub LoadItems()
        Try
            connection()
            sql = "SELECT itemId, itemName, unit, currentStock FROM tblinventoryitems ORDER BY itemId"
            cmd = New MySqlCommand(sql, cn)
            itemsTable = New DataTable()
            itemsTable.Load(cmd.ExecuteReader())

            cboItem.DataSource = itemsTable
            cboItem.DisplayMember = "itemName"
            cboItem.ValueMember = "itemId"
            cboItem.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error loading items: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub cboReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReason.SelectedIndexChanged
        ' "Other" must be explained in the details box
        Dim isOther As Boolean = (cboReason.Text = "Other")
        Guna2HtmlLabel4.Text = If(isOther, "ADDITIONAL DETAILS (required)", "ADDITIONAL DETAILS")
        txtAdditional.PlaceholderText = If(isOther, "Why was it taken out?", "")
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        If isLoading Then Return
        RefreshItemInfo()
    End Sub

    Private Sub RefreshItemInfo()
        Dim row As DataRowView = TryCast(cboItem.SelectedItem, DataRowView)
        If row Is Nothing Then
            lblAvailable.Text = "-"
            Return
        End If

        Dim unit As String = row("unit").ToString()
        lblAvailable.Text = "" & FormatQty(CDec(row("currentStock"))) & " " & unit
    End Sub

    Private Function TryGetQuantity(ByRef qty As Decimal) As Boolean
        Return Decimal.TryParse(txtQuantity.Text.Trim(), System.Globalization.NumberStyles.Number,
                                System.Globalization.CultureInfo.CurrentCulture, qty)
    End Function

    ' ---------- Save ----------

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CurrentUserId <= 0 Then
            MsgBox("No logged-in user. Please log in again.", MsgBoxStyle.Exclamation, "Not logged in")
            Return
        End If

        Dim row As DataRowView = TryCast(cboItem.SelectedItem, DataRowView)
        If row Is Nothing Then
            MsgBox("Select an item.", MsgBoxStyle.Exclamation, "Validation error")
            cboItem.Focus()
            Return
        End If

        Dim qty As Decimal
        If Not TryGetQuantity(qty) OrElse qty <= 0 Then
            MsgBox("Enter a valid quantity greater than 0.", MsgBoxStyle.Exclamation, "Validation error")
            txtQuantity.Focus()
            Return
        End If
        If qty > MAX_QTY Then
            MsgBox("That quantity is too large. Please check it.", MsgBoxStyle.Exclamation, "Validation error")
            txtQuantity.Focus()
            Return
        End If

        Dim unit As String = row("unit").ToString()
        If unit.Equals("pcs", StringComparison.OrdinalIgnoreCase) AndAlso qty <> Math.Floor(qty) Then
            MsgBox("Pieces must be a whole number.", MsgBoxStyle.Exclamation, "Validation error")
            txtQuantity.Focus()
            Return
        End If
        qty = Math.Round(qty, 2)

        Dim itemId As Integer = CInt(row("itemId"))
        Dim available As Decimal = CDec(row("currentStock"))
        If qty > available Then
            MsgBox("Not enough stock. Only " & FormatQty(available) & " " & unit & " available.",
                   MsgBoxStyle.Exclamation, "Not enough stock")
            txtQuantity.Focus()
            Return
        End If

        If cboReason.Text = "Other" AndAlso txtAdditional.Text.Trim().Length < 3 Then
            MsgBox("Please say what the reason is when you choose Other.", MsgBoxStyle.Exclamation, "Validation error")
            txtAdditional.Focus()
            Return
        End If

        Dim reference As String = cboReason.Text
        If txtAdditional.Text.Trim() <> "" Then reference &= ": " & txtAdditional.Text.Trim()
        If reference.Length > 255 Then reference = reference.Substring(0, 255)

        Dim txn As MySqlTransaction = Nothing
        Try
            connection()
            txn = cn.BeginTransaction()

            ' Deduct only if enough stock is still there (guards against stale numbers on screen)
            sql = "UPDATE tblinventoryitems SET currentStock = currentStock - @qty " &
                  "WHERE itemId = @itemId AND currentStock >= @qty"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@itemId", itemId)
            If cmd.ExecuteNonQuery() = 0 Then
                txn.Rollback()
                MsgBox("Not enough stock any more. Close this window and check the inventory list.",
                       MsgBoxStyle.Exclamation, "Not enough stock")
                Return
            End If

            sql = "INSERT INTO tblstocktransactions " &
                  "(itemId, transactionType, quantity, transactionDate, referenceNote, recordedBy) " &
                  "VALUES (@itemId, 'Stock-out', @qty, @date, @note, @user)"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@itemId", itemId)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("@note", reference)
            cmd.Parameters.AddWithValue("@user", CurrentUserId)
            cmd.ExecuteNonQuery()

            txn.Commit()
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            If txn IsNot Nothing Then
                Try
                    txn.Rollback()
                Catch
                End Try
            End If
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class