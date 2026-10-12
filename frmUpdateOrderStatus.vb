Imports MySql.Data.MySqlClient

Public Class frmUpdateOrderStatus

    ' Set by the caller BEFORE ShowDialog(). A property (not a constructor
    ' parameter) so the Designer can still open this form normally.
    Public Property OrderId As Integer

    Private Sub frmUpdateOrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPickupStatus.Items.Clear()
        cboPickupStatus.Items.AddRange({"Pending", "Picked-up", "Delivered", "Missed"})

        cboPaymentStatus.Items.Clear()
        cboPaymentStatus.Items.AddRange({"Unpaid", "Paid"})

        cboPaymentMode.Items.Clear()
        cboPaymentMode.Items.AddRange({"Cash", "Card"})

        LoadCurrentValues()
    End Sub

    ''' <summary>
    ''' Shows who/when/how much at the top, and pre-selects the order's
    ''' CURRENT statuses so you only change what actually changed.
    ''' </summary>
    Private Sub LoadCurrentValues()
        Try
            connection()
            sql = "SELECT c.customerName, o.orderDate, o.totalAmount, " &
                  "       o.pickupStatus, o.paymentStatus, o.paymentMode " &
                  "FROM tblSalesOrders o " &
                  "INNER JOIN tblCustomers c ON o.customerId = c.customerId " &
                  "WHERE o.orderId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", OrderId)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                lblOrderInfo.Text = dr("customerName").ToString() & "  |  " &
                                    CDate(dr("orderDate")).ToString("MMM d, yyyy") & "  |  ₱" &
                                    CDec(dr("totalAmount")).ToString("N2")

                ' IndexOf returns -1 if the stored value isn't in the list
                ' (e.g. an old row saved with a blank status), which simply
                ' leaves the dropdown empty so you're forced to pick one
                cboPickupStatus.SelectedIndex = cboPickupStatus.Items.IndexOf(dr("pickupStatus").ToString())
                cboPaymentStatus.SelectedIndex = cboPaymentStatus.Items.IndexOf(dr("paymentStatus").ToString())
                cboPaymentMode.SelectedIndex = cboPaymentMode.Items.IndexOf(dr("paymentMode").ToString())
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading order: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboPickupStatus.SelectedIndex = -1 OrElse
           cboPaymentStatus.SelectedIndex = -1 OrElse
           cboPaymentMode.SelectedIndex = -1 Then
            MsgBox("Please select a Pickup Status, Payment Status, and Payment Mode.",
                   MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Dim problem As String = PaymentRuleProblem(cboPickupStatus.Text, cboPaymentStatus.Text)
        If problem <> "" Then
            MsgBox(problem, MsgBoxStyle.Exclamation, "Payment not allowed")
            Return
        End If

        ' make sure the "handled by" columns exist, then record who made this change
        Dim hasAudit As Boolean = EnsureOrderAuditColumns()

        Try
            connection()
            sql = "UPDATE tblSalesOrders " &
                  "SET pickupStatus = @pickup, paymentStatus = @payStatus, paymentMode = @payMode" &
                  If(hasAudit, ", handledBy = @user, handledAt = NOW() ", " ") &
                  "WHERE orderId = @id"
            cmd = New MySqlCommand(sql, cn)
            If hasAudit Then cmd.Parameters.AddWithValue("@user", CurrentUserId)
            cmd.Parameters.AddWithValue("@pickup", cboPickupStatus.Text)
            cmd.Parameters.AddWithValue("@payStatus", cboPaymentStatus.Text)
            cmd.Parameters.AddWithValue("@payMode", cboPaymentMode.Text)
            cmd.Parameters.AddWithValue("@id", OrderId)
            cmd.ExecuteNonQuery()

            MsgBox("Order status updated.", MsgBoxStyle.Information, "Success")
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox("Could not update the order: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class