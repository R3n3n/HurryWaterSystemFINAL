Imports MySql.Data.MySqlClient
Public Class frmOrderDetails
    Inherits Form

    ''' <summary>Set by the caller BEFORE ShowDialog().</summary>
    Public Property OrderId As Integer

    Private ReadOnly lblTitle As New Label()
    Private ReadOnly lblCustomer As New Label()
    Private ReadOnly lblStatus As New Label()
    Private ReadOnly lsvItems As New ListView()
    Private ReadOnly lblTotal As New Label()
    Private ReadOnly btnExport As New Guna.UI2.WinForms.Guna2GradientButton()
    Private ReadOnly btnClose As New Guna.UI2.WinForms.Guna2GradientButton()

    Public Sub New()
        Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.ClientSize = New Size(780, 568)
        Me.Text = "Order Items"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False
        Me.KeyPreview = True
        Me.BackColor = Color.FromArgb(244, 246, 252)

        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(27, 42, 78)
        lblTitle.Location = New Point(24, 16)

        lblCustomer.AutoSize = True
        lblCustomer.Font = New Font("Segoe UI", 11.5F)
        lblCustomer.ForeColor = Color.FromArgb(68, 88, 112)
        lblCustomer.Location = New Point(26, 62)

        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 11.5F)
        lblStatus.ForeColor = Color.FromArgb(68, 88, 112)
        lblStatus.Location = New Point(26, 90)

        lsvItems.Location = New Point(24, 128)
        lsvItems.Size = New Size(732, 326)
        lsvItems.View = View.Details
        lsvItems.FullRowSelect = True
        lsvItems.GridLines = True
        lsvItems.HideSelection = False
        lsvItems.Font = New Font("Segoe UI", 11.0F)
        lsvItems.Columns.Add("Item", 330)
        lsvItems.Columns.Add("Qty", 90, HorizontalAlignment.Right)
        lsvItems.Columns.Add("Unit Price", 150, HorizontalAlignment.Right)
        lsvItems.Columns.Add("Line Total", 150, HorizontalAlignment.Right)

        lblTotal.AutoSize = False
        lblTotal.TextAlign = ContentAlignment.MiddleRight
        lblTotal.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(27, 42, 78)
        lblTotal.Location = New Point(356, 460)
        lblTotal.Size = New Size(400, 36)

        StyleButton(btnExport, "Export", New Point(24, 510))
        StyleButton(btnClose, "Close", New Point(586, 510))

        AddHandler btnExport.Click, AddressOf btnExport_Click
        AddHandler btnClose.Click, Sub(s, e) Me.Close()

        Me.Controls.AddRange(New Control() {lblTitle, lblCustomer, lblStatus, lsvItems, lblTotal, btnExport, btnClose})
    End Sub

    Private Sub StyleButton(btn As Guna.UI2.WinForms.Guna2GradientButton, caption As String, location As Point)
        btn.BorderRadius = 14
        btn.FillColor = Color.FromArgb(58, 110, 165)
        btn.FillColor2 = Color.FromArgb(90, 143, 214)
        btn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btn.ForeColor = Color.White
        btn.Location = location
        btn.Size = New Size(170, 44)
        btn.Text = caption
    End Sub

    Private Sub frmOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrder()
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then Me.Close()
        MyBase.OnKeyDown(e)
    End Sub

    Private Sub LoadOrder()
        lblTitle.Text = "Order " & FormatOrderNo(OrderId)

        Try
            ' This window uses its own connection (same database as the rest of the app) instead of the shared
            ' cn, so nothing else in the app can close it while the order is being read.
            If cn.ConnectionString = "" Then
                connection()
                If cn.State = ConnectionState.Open Then cn.Close()
            End If

            Using conn As New MySqlConnection(cn.ConnectionString)
                conn.Open()

                Using header As New MySqlCommand(
                        "SELECT c.customerName, o.orderDate, o.pickupStatus, o.paymentStatus, o.paymentMode, o.totalAmount " &
                        "FROM tblSalesOrders o " &
                        "INNER JOIN tblCustomers c ON o.customerId = c.customerId " &
                        "WHERE o.orderId = @id", conn)
                    header.Parameters.AddWithValue("@id", OrderId)

                    Using reader As MySqlDataReader = header.ExecuteReader()
                        If reader.Read() Then
                            lblCustomer.Text = reader("customerName").ToString() & "   |   " &
                                               CDate(reader("orderDate")).ToString("MMM d, yyyy")
                            lblStatus.Text = "Pickup: " & reader("pickupStatus").ToString() & "   |   Payment: " &
                                             reader("paymentStatus").ToString() & " (" & reader("paymentMode").ToString() & ")"
                            lblTotal.Text = "Order total:  ₱" & CDec(reader("totalAmount")).ToString("N2")
                        End If
                    End Using
                End Using

                ' Same "container - water type" names that the order form uses
                Using items As New MySqlCommand(
                        "SELECT CONCAT(p.containerType, ' - ', p.waterType) AS itemName, " &
                        "       d.quantity, d.unitPrice, d.lineTotal " &
                        "FROM tblSalesOrderDetails d " &
                        "INNER JOIN tblProducts p ON p.productId = d.productId " &
                        "WHERE d.orderId = @id ORDER BY d.orderDetailId", conn)
                    items.Parameters.AddWithValue("@id", OrderId)

                    Using reader As MySqlDataReader = items.ExecuteReader()
                        lsvItems.Items.Clear()
                        While reader.Read()
                            Dim item As New ListViewItem(reader("itemName").ToString())
                            item.SubItems.Add(reader("quantity").ToString())
                            item.SubItems.Add("₱" & CDec(reader("unitPrice")).ToString("N2"))
                            item.SubItems.Add("₱" & CDec(reader("lineTotal")).ToString("N2"))
                            lsvItems.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error loading order items: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        ExportListViewToCsv(lsvItems, "order_" & FormatOrderNo(OrderId))
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'frmOrderDetails
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "frmOrderDetails"
        Me.ResumeLayout(False)

    End Sub

    Private Sub frmOrderDetails_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
