Imports System.Runtime.CompilerServices
Imports System.Text

''' <summary>
''' Type-to-search for a ComboBox (including Guna2ComboBox) WITHOUT turning it into an editable combo.
''' The combo stays a normal drop-down list (DropDownList), so Guna draws it exactly as designed and no
''' extra edit box sits on top of it. While the box has focus, typing narrows the drop-down to the names that
''' CONTAIN what was typed (every word must match, so "cruz juan" finds "Juan dela Cruz"). What you have typed
''' is shown in a small tip above the box. Backspace edits it, Esc cancels, Enter picks the only match.
''' The combo keeps working with SelectedItem (DataRowView), SelectedValue and SelectedIndex = -1,
''' so the existing save/validate code does not need to change.
''' </summary>
Public NotInheritable Class SearchableCombo

    Private Shared ReadOnly Attached As New ConditionalWeakTable(Of ComboBox, SearchableCombo)()

    Private ReadOnly combo As ComboBox
    Private ReadOnly displayColumn As String
    Private ReadOnly valueColumn As String
    Private rows As DataView
    Private busy As Boolean = False          ' True while WE change the list/selection, so those changes are not treated as user actions
    Private buffer As String = ""            ' what has been typed so far
    Private previousValue As Object = Nothing ' what was selected before the search began (restored on cancel)
    Private ReadOnly tip As New ToolTip() With {.ShowAlways = True}

    ''' <summary>Makes the combo searchable and fills it from table. Safe to call again to reload the list.</summary>
    Public Shared Sub Attach(combo As ComboBox, table As DataTable, displayColumn As String, valueColumn As String)
        Dim helper As SearchableCombo = Nothing
        If Not Attached.TryGetValue(combo, helper) Then
            helper = New SearchableCombo(combo, displayColumn, valueColumn)
            Attached.Add(combo, helper)
        End If
        helper.Bind(table)
    End Sub

    ''' <summary>
    ''' Call at the start of Save/validation. Turns whatever is typed into a real selection (or restores the
    ''' previous one), in case the user clicks Save without leaving the box first.
    ''' </summary>
    Public Shared Sub Commit(combo As ComboBox)
        Dim helper As SearchableCombo = Nothing
        If Attached.TryGetValue(combo, helper) Then helper.FinishSearch()
    End Sub

    Private Sub New(combo As ComboBox, displayColumn As String, valueColumn As String)
        Me.combo = combo
        Me.displayColumn = displayColumn
        Me.valueColumn = valueColumn

        AddHandler combo.KeyPress, AddressOf Combo_KeyPress
        AddHandler combo.KeyDown, AddressOf Combo_KeyDown
        AddHandler combo.DropDownClosed, AddressOf Combo_DropDownClosed
        AddHandler combo.Leave, AddressOf Combo_Leave
    End Sub

    Private Sub Bind(table As DataTable)
        busy = True
        Try
            combo.DropDownStyle = ComboBoxStyle.DropDownList   ' no built-in edit box, so nothing overlaps Guna's drawing
            rows = New DataView(table)
            combo.DisplayMember = displayColumn
            combo.ValueMember = valueColumn
            combo.DataSource = rows
            combo.SelectedIndex = -1
            buffer = ""
            previousValue = Nothing
        Finally
            busy = False
        End Try
        HideHint()
    End Sub

    ' ---------- typing ----------

    Private Sub Combo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) Then Return                      ' Backspace/Enter/Esc are handled in KeyDown
        If e.KeyChar = " "c AndAlso buffer = "" Then Return           ' a lone space still opens the list as usual

        e.Handled = True                                              ' stop the default "jump to first letter"
        If buffer = "" Then previousValue = combo.SelectedValue
        buffer &= e.KeyChar
        ApplyFilter()
    End Sub

    Private Sub Combo_KeyDown(sender As Object, e As KeyEventArgs)
        If buffer = "" Then Return

        Select Case e.KeyCode
            Case Keys.Back
                e.Handled = True
                e.SuppressKeyPress = True
                buffer = buffer.Substring(0, buffer.Length - 1)
                If buffer = "" Then CancelSearch() Else ApplyFilter()

            Case Keys.Escape
                e.Handled = True
                e.SuppressKeyPress = True
                CancelSearch()

            Case Keys.Enter
                If combo.SelectedIndex = -1 AndAlso rows.Count = 1 Then
                    e.Handled = True
                    e.SuppressKeyPress = True
                    EndSearch(rows(0)(valueColumn))
                End If
        End Select
    End Sub

    Private Sub ApplyFilter()
        busy = True
        Try
            CloseList()                       ' close while the list still has items; closing an empty owner-drawn list throws
            rows.RowFilter = BuildFilter(buffer)
            combo.SelectedIndex = -1          ' nothing is chosen until the user picks one
        Finally
            busy = False
        End Try

        ShowHint()
        If rows.Count = 0 Then Return         ' nothing matches: leave the list closed

        busy = True
        Try
            OpenList()
            Cursor.Current = Cursors.Default  ' opening the list hides the mouse pointer otherwise
            combo.SelectedIndex = -1          ' opening the list may highlight the first row; keep it unchosen
        Finally
            busy = False
        End Try
    End Sub

    Private Sub CloseList()
        Try
            If combo.DroppedDown Then combo.DroppedDown = False
        Catch ex As ArgumentOutOfRangeException
            ' the list had nothing to draw; as far as the user can tell it is closed
        End Try
    End Sub

    Private Sub OpenList()
        Try
            combo.DroppedDown = True
        Catch ex As ArgumentOutOfRangeException
            ' cosmetic only: the user can still keep typing
        End Try
    End Sub

    ' "juan cruz" -> [name] LIKE '%juan%' AND [name] LIKE '%cruz%'
    Private Function BuildFilter(typed As String) As String
        Dim words As String() = typed.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        If words.Length = 0 Then Return ""

        Dim parts As New List(Of String)
        For Each w As String In words
            parts.Add("[" & displayColumn & "] LIKE '%" & EscapeLike(w) & "%'")
        Next
        Return String.Join(" AND ", parts)
    End Function

    Private Shared Function EscapeLike(s As String) As String
        Dim sb As New StringBuilder()
        For Each ch As Char In s
            Select Case ch
                Case "'"c
                    sb.Append("''")
                Case "["c, "]"c, "*"c, "%"c
                    sb.Append("[").Append(ch).Append("]")
                Case Else
                    sb.Append(ch)
            End Select
        Next
        Return sb.ToString()
    End Function

    ' ---------- hint above the box ----------

    Private Sub ShowHint()
        Dim text As String = "Search: " & buffer
        If rows.Count = 0 Then text &= "   (no match)"
        tip.Show(text, combo, 6, -34)
    End Sub

    Private Sub HideHint()
        tip.Hide(combo)
    End Sub

    ' ---------- choosing / finishing ----------

    ' The user picked from the list, or closed it without picking
    Private Sub Combo_DropDownClosed(sender As Object, e As EventArgs)
        If busy OrElse buffer = "" Then Return

        Dim item As DataRowView = TryCast(combo.SelectedItem, DataRowView)
        If item IsNot Nothing Then
            EndSearch(item(valueColumn))
        Else
            CancelSearch()
        End If
    End Sub

    Private Sub Combo_Leave(sender As Object, e As EventArgs)
        FinishSearch()
    End Sub

    ''' <summary>
    ''' Leaving the box / saving: keep a real choice; otherwise use the typed text if it is exactly one name,
    ''' or if only one name still matches; otherwise put back what was selected before.
    ''' </summary>
    Private Sub FinishSearch()
        If busy OrElse buffer = "" Then Return

        Dim item As DataRowView = TryCast(combo.SelectedItem, DataRowView)
        If item IsNot Nothing Then
            EndSearch(item(valueColumn))
            Return
        End If

        Dim match As Object = FindMatch(buffer.Trim())
        If match IsNot Nothing Then
            EndSearch(match)
        Else
            CancelSearch()
        End If
    End Sub

    Private Function FindMatch(typed As String) As Object
        If typed = "" Then Return Nothing

        Dim found As Object = Nothing
        Dim exactCount As Integer = 0

        For Each r As DataRow In rows.Table.Rows
            If String.Equals(Convert.ToString(r(displayColumn)), typed, StringComparison.OrdinalIgnoreCase) Then
                found = r(valueColumn)
                exactCount += 1
            End If
        Next
        If exactCount = 1 Then Return found

        If exactCount = 0 AndAlso rows.Count = 1 Then Return rows(0)(valueColumn)
        Return Nothing
    End Function

    ' Finish the search with a pick: bring the full list back and keep the pick selected
    Private Sub EndSearch(picked As Object)
        busy = True
        Try
            CloseList()
            rows.RowFilter = ""
            combo.SelectedValue = picked
            buffer = ""
            previousValue = Nothing
        Finally
            busy = False
        End Try
        HideHint()
    End Sub

    ' Abandon the search: full list again, and the earlier selection (if any) comes back
    Private Sub CancelSearch()
        busy = True
        Try
            CloseList()
            rows.RowFilter = ""
            If previousValue IsNot Nothing Then
                combo.SelectedValue = previousValue
            Else
                combo.SelectedIndex = -1
            End If
            buffer = ""
            previousValue = Nothing
        Finally
            busy = False
        End Try
        HideHint()
    End Sub

End Class