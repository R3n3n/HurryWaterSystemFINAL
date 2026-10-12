Imports MySql.Data.MySqlClient

Public Class frmProduction

    Private Const LITERS_PER_GALLON As Decimal = 11D
    Private Const LITERS_PER_350ML As Decimal = 0.35D
    Private Const LITERS_PER_500ML As Decimal = 0.5D

    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Liters input
        nudLiters.DecimalPlaces = 2
        nudLiters.Minimum = 0
        nudLiters.Maximum = 1000000
        nudLiters.Increment = 10
        nudLiters.Value = 0

        ' Tank list (the Designer still has the old Pending/Picked-up items, so clear them)
        cboTank.DropDownStyle = ComboBoxStyle.DropDownList
        cboTank.Items.Clear()
        cboTank.Items.AddRange({"Tank-1", "Tank-2"})   ' edit to match your real tanks
        cboTank.SelectedIndex = 0

        dtpLogDate.MaxDate = Date.Today   ' no production logs dated in the future
        dtpLogDate.Value = Date.Today

        UpdateEquivalents()
    End Sub

    ' ---------- Live preview of equivalents ----------

    Private Sub nudLiters_ValueChanged(sender As Object, e As EventArgs) Handles nudLiters.ValueChanged
        UpdateEquivalents()
    End Sub

    Private Function GetGallons(liters As Decimal) As Decimal
        Return Math.Round(liters / LITERS_PER_GALLON, 2)
    End Function

    ' Whole bottles only (partial bottles can't be sold)
    Private Function GetBottles(liters As Decimal, litersPerBottle As Decimal) As Integer
        Return CInt(Math.Floor(liters / litersPerBottle))
    End Function

    Private Sub UpdateEquivalents()
        Dim liters As Decimal = nudLiters.Value
        lblGallons.Text = GetGallons(liters).ToString("N2")
        lblBottles350.Text = GetBottles(liters, LITERS_PER_350ML).ToString("N0")
        lblBottles500.Text = GetBottles(liters, LITERS_PER_500ML).ToString("N0")
    End Sub

    ' ---------- Save ----------

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CurrentUserId <= 0 Then
            MsgBox("No logged-in user. Please log in again.", MsgBoxStyle.Exclamation, "Not logged in")
            Return
        End If

        If cboTank.SelectedIndex = -1 Then
            MsgBox("Select a tank.", MsgBoxStyle.Exclamation, "Validation error")
            cboTank.Focus()
            Return
        End If

        If nudLiters.Value <= 0 Then
            MsgBox("Enter the liters produced (greater than 0).", MsgBoxStyle.Exclamation, "Validation error")
            nudLiters.Focus()
            Return
        End If

        Dim liters As Decimal = nudLiters.Value

        Try
            connection()
            sql = "INSERT INTO tblproductionlog " &
                  "(logDate, tankId, litersProduced, gallonEquivalent, bottle350mlEquivalent, bottle500mlEquivalent, recordedBy) " &
                  "VALUES (@logDate, @tankId, @liters, @gallons, @b350, @b500, @recordedBy)"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@logDate", dtpLogDate.Value.Date)
            cmd.Parameters.AddWithValue("@tankId", cboTank.Text)
            cmd.Parameters.AddWithValue("@liters", liters)
            cmd.Parameters.AddWithValue("@gallons", GetGallons(liters))
            cmd.Parameters.AddWithValue("@b350", GetBottles(liters, LITERS_PER_350ML))
            cmd.Parameters.AddWithValue("@b500", GetBottles(liters, LITERS_PER_500ML))
            cmd.Parameters.AddWithValue("@recordedBy", CurrentUserId)
            cmd.ExecuteNonQuery()

            MsgBox("Production log saved.", MsgBoxStyle.Information, "Saved")
            nudLiters.Value = 0          ' reset for the next entry; date and tank stay
            nudLiters.Focus()
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class