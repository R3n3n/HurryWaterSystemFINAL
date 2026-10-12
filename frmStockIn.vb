Imports MySql.Data.MySqlClient

Public Class frmStockIn

    Private Const MAX_QTY As Decimal = 2000D

    Private itemsTable As DataTable
    Private isLoading As Boolean = True

    Private Sub frmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.MaxDate = Date.Today   ' no stock-ins dated in the future
        dtpDate.Value = Date.Today

        LoadItems()
        LoadRecentReferences()
        isLoading = False
    End Sub

    Private Sub LoadItems()
        Try
            connection()
            ' unitCost is a generated column (packCost / packSize); IFNULL guards packSize = 0
            sql = "SELECT itemId, itemName, unit, IFNULL(unitCost, 0) AS unitCost FROM tblinventoryitems ORDER BY itemId"
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

    Private Function TryGetQuantity(ByRef qty As Decimal) As Boolean
        Return Decimal.TryParse(txtQuantity.Text.Trim(), System.Globalization.NumberStyles.Number,
                                System.Globalization.CultureInfo.CurrentCulture, qty)
    End Function

    ' ---------- Reference / invoice number helpers ----------

    ' The last few references used, so a delivery that comes with several items can reuse its invoice number
    Private Sub LoadRecentReferences()
        cboRecentRef.Items.Clear()
        cboRecentRef.Items.Add("Pick a previous reference...")

        Try
            connection()
            sql = "SELECT referenceNote, MAX(transactionDate) AS lastUsed FROM tblstocktransactions " &
                  "WHERE transactionType = 'Stock-in' AND referenceNote IS NOT NULL AND referenceNote <> '' " &
                  "GROUP BY referenceNote ORDER BY lastUsed DESC, referenceNote DESC LIMIT 20"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()
            While dr.Read()
                cboRecentRef.Items.Add(dr("referenceNote").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading previous references: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        cboRecentRef.SelectedIndex = 0
    End Sub

    Private Sub cboRecentRef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRecentRef.SelectedIndexChanged
        If cboRecentRef.SelectedIndex > 0 Then txtReference.Text = cboRecentRef.Text
    End Sub

    ' SI-20261011-001, SI-20261011-002, ... one running number per day
    Private Sub btnAutoRef_Click(sender As Object, e As EventArgs) Handles btnAutoRef.Click
        Dim prefix As String = "SI-" & dtpDate.Value.Date.ToString("yyyyMMdd") & "-"
        Dim n As Integer = 1

        Try
            connection()
            sql = "SELECT COUNT(DISTINCT referenceNote) FROM tblstocktransactions " &
                  "WHERE transactionType = 'Stock-in' AND referenceNote LIKE @prefix"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@prefix", prefix & "%")
            n = CInt(CLng(cmd.ExecuteScalar())) + 1

            ' skip any number that is somehow already taken
            While ReferenceExists(prefix & n.ToString("000"), 0)
                n += 1
            End While
        Catch ex As Exception
            MsgBox("Could not generate a reference: " & ex.Message, MsgBoxStyle.Critical)
            Return
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        txtReference.Text = prefix & n.ToString("000")
    End Sub

    ''' <summary>True if this reference was already used (for this item, or for any item when itemId = 0). Uses the open connection.</summary>
    Private Function ReferenceExists(reference As String, itemId As Integer) As Boolean
        Dim checkSql As String = "SELECT COUNT(*) FROM tblstocktransactions " &
                                 "WHERE transactionType = 'Stock-in' AND referenceNote = @ref" &
                                 If(itemId > 0, " AND itemId = @item", "")
        Dim check As New MySqlCommand(checkSql, cn)
        check.Parameters.AddWithValue("@ref", reference)
        If itemId > 0 Then check.Parameters.AddWithValue("@item", itemId)
        Return CLng(check.ExecuteScalar()) > 0
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
        Dim total As Decimal = Math.Round(qty * CDec(row("unitCost")), 2)   ' automatic: quantity x unit cost
        Dim reference As String = txtReference.Text.Trim()
        If reference.Length > 100 Then
            MsgBox("The reference is too long (max 100 characters).", MsgBoxStyle.Exclamation, "Validation error")
            txtReference.Focus()
            Return
        End If

        ' Same invoice already recorded for this same item is probably a double entry
        If reference <> "" Then
            Dim alreadyUsed As Boolean = False
            Try
                connection()
                alreadyUsed = ReferenceExists(reference, itemId)
            Catch ex As Exception
                MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()
            End Try

            If alreadyUsed Then
                If MsgBox("Reference """ & reference & """ was already recorded for this item." & vbCrLf & vbCrLf &
                          "Save it again anyway?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2,
                          "Possible duplicate") <> MsgBoxResult.Yes Then Return
            End If
        End If

        ' No price prompt: the cost is simply quantity x the Catalog unit cost (calculated above).

        If Not EnsureExpenseStockLink() Then Return

        Dim txn As MySqlTransaction = Nothing
        Try
            connection()
            txn = cn.BeginTransaction()

            ' Needs the totalCost column (see inventory_update.sql)
            sql = "INSERT INTO tblstocktransactions " &
                  "(itemId, transactionType, quantity, totalCost, transactionDate, referenceNote, recordedBy) " &
                  "VALUES (@itemId, 'Stock-in', @qty, @cost, @date, @note, @user)"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@itemId", itemId)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@cost", total)
            cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("@note", If(reference = "", DBNull.Value, CObj(reference)))
            cmd.Parameters.AddWithValue("@user", CurrentUserId)
            cmd.ExecuteNonQuery()
            Dim stockTransactionId As Long = cmd.LastInsertedId

            sql = "UPDATE tblinventoryitems SET currentStock = currentStock + @qty WHERE itemId = @itemId"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@itemId", itemId)
            cmd.ExecuteNonQuery()

            ' Same transaction: the stock-in and its expense are saved together or not at all.
            ' Nothing is recorded as an expense when the amount paid is 0 (e.g. a donation).
            If total > 0 Then
                Dim expenseNote As String = "Stock-in: " & row("itemName").ToString() & " x " & qty.ToString("0.##") & " " & unit &
                                            If(reference = "", "", " (" & reference & ")")
                If expenseNote.Length > 255 Then expenseNote = expenseNote.Substring(0, 255)

                sql = "INSERT INTO tblExpenses (expenseDate, category, amount, description, recordedBy, stockTransactionId) " &
                      "VALUES (@date, 'Supplies', @amount, @note, @user, @tid)"
                cmd = New MySqlCommand(sql, cn, txn)
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date)
                cmd.Parameters.AddWithValue("@amount", total)
                cmd.Parameters.AddWithValue("@note", expenseNote)
                cmd.Parameters.AddWithValue("@user", CurrentUserId)
                cmd.Parameters.AddWithValue("@tid", stockTransactionId)
                cmd.ExecuteNonQuery()
            End If

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