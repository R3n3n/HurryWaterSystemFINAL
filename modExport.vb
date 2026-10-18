Imports System.IO
Imports System.Text

''' <summary>
''' One export routine for every list in the system. Saves what the list is CURRENTLY showing (search and
''' filters included) as a .csv that opens in Excel.
'''   - peso amounts are saved as plain numbers ("₱1,250.00" -> 1250.00) so Excel can add them up
'''   - "—" (the app's "no value" mark) is saved as an empty cell
'''   - rows that only hold a message ("Nobody is due right now") are left out
''' </summary>
Module modExport

    Public Sub ExportListViewToCsv(lv As ListView, title As String)
        Dim rows As List(Of String) = BuildRows(lv)

        If rows.Count = 0 Then
            MsgBox("There is nothing to export yet.", MsgBoxStyle.Information, "Export")
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV files (*.csv)|*.csv"
            sfd.FileName = SafeFileName(title) & "_" & Date.Today.ToString("yyyy-MM-dd") & ".csv"

            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                ' UTF-8 with a BOM so Excel shows the peso sign and accented names correctly
                Using writer As New StreamWriter(sfd.FileName, False, New UTF8Encoding(True))
                    writer.WriteLine(HeaderLine(lv))
                    For Each line As String In rows
                        writer.WriteLine(line)
                    Next
                End Using

                MsgBox("Exported " & rows.Count.ToString() & If(rows.Count = 1, " row", " rows") & " to:" & vbCrLf & sfd.FileName,
                       MsgBoxStyle.Information, "Export complete")
            Catch ex As Exception
                MsgBox("Export failed: " & ex.Message & vbCrLf & vbCrLf &
                       "If the file is open in Excel, close it and try again.", MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    ' Columns the user can actually see (a width of 0 means hidden)
    Private Function VisibleColumns(lv As ListView) As List(Of Integer)
        Dim result As New List(Of Integer)
        For i As Integer = 0 To lv.Columns.Count - 1
            If lv.Columns(i).Width > 0 Then result.Add(i)
        Next
        Return result
    End Function

    Private Function HeaderLine(lv As ListView) As String
        Dim cells As New List(Of String)
        For Each i As Integer In VisibleColumns(lv)
            cells.Add(Csv(lv.Columns(i).Text))
        Next
        Return String.Join(",", cells)
    End Function

    Private Function BuildRows(lv As ListView) As List(Of String)
        Dim columns As List(Of Integer) = VisibleColumns(lv)
        Dim lines As New List(Of String)

        For Each item As ListViewItem In lv.Items
            If IsMessageRow(item, columns.Count) Then Continue For

            Dim cells As New List(Of String)
            For Each i As Integer In columns
                Dim text As String = If(i < item.SubItems.Count, item.SubItems(i).Text, "")
                cells.Add(Csv(CleanCell(text)))
            Next
            lines.Add(String.Join(",", cells))
        Next

        Return lines
    End Function

    ' "Nobody is due right now": text in the first column only, on a list with several columns
    Private Function IsMessageRow(item As ListViewItem, columnCount As Integer) As Boolean
        If columnCount < 2 Then Return False
        For i As Integer = 1 To item.SubItems.Count - 1
            If item.SubItems(i).Text.Trim() <> "" Then Return False
        Next
        Return True
    End Function

    Private Function CleanCell(text As String) As String
        Dim t As String = text.Trim()
        If t = "—" Then Return ""
        If t.StartsWith("₱") Then Return t.Substring(1).Replace(",", "")
        Return t
    End Function

    ' Quote cells that contain commas, quotes or line breaks; stop Excel running text that starts with = or @
    Private Function Csv(value As String) As String
        If value.StartsWith("=") OrElse value.StartsWith("@") Then value = "'" & value
        If value.IndexOfAny(New Char() {","c, """"c, ControlChars.Cr, ControlChars.Lf}) >= 0 Then
            Return """" & value.Replace("""", """""") & """"
        End If
        Return value
    End Function

    Private Function SafeFileName(name As String) As String
        Dim result As String = name
        For Each c As Char In Path.GetInvalidFileNameChars()
            result = result.Replace(c, "_"c)
        Next
        Return result.Replace(" ", "_")
    End Function

End Module
