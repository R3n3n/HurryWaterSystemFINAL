<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblTodaySales = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUnpaidBalance = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblAwaitingDelivery = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblOverdueDispensers = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lsvDueToday = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lsvLowStock = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 40.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(48, 46)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(294, 86)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Dashboard"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(50, 138)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(241, 41)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "# orders this week"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 18
        Me.Guna2GradientPanel1.Controls.Add(Me.lblTodaySales)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(48, 239)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(320, 178)
        Me.Guna2GradientPanel1.TabIndex = 42
        '
        'lblTodaySales
        '
        Me.lblTodaySales.AutoSize = True
        Me.lblTodaySales.BackColor = System.Drawing.Color.Transparent
        Me.lblTodaySales.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaySales.ForeColor = System.Drawing.Color.White
        Me.lblTodaySales.Location = New System.Drawing.Point(29, 81)
        Me.lblTodaySales.Name = "lblTodaySales"
        Me.lblTodaySales.Size = New System.Drawing.Size(48, 61)
        Me.lblTodaySales.TabIndex = 38
        Me.lblTodaySales.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 35)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "TODAY'S SALES"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 18
        Me.Guna2Panel3.Controls.Add(Me.lblUnpaidBalance)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(789, 239)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel3.TabIndex = 40
        '
        'lblUnpaidBalance
        '
        Me.lblUnpaidBalance.AutoSize = True
        Me.lblUnpaidBalance.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnpaidBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblUnpaidBalance.Location = New System.Drawing.Point(25, 81)
        Me.lblUnpaidBalance.Name = "lblUnpaidBalance"
        Me.lblUnpaidBalance.Size = New System.Drawing.Size(48, 61)
        Me.lblUnpaidBalance.TabIndex = 37
        Me.lblUnpaidBalance.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(29, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 35)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "UNPAID BALANCE"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 18
        Me.Guna2Panel2.Controls.Add(Me.lblAwaitingDelivery)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(419, 239)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel2.TabIndex = 41
        '
        'lblAwaitingDelivery
        '
        Me.lblAwaitingDelivery.AutoSize = True
        Me.lblAwaitingDelivery.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwaitingDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblAwaitingDelivery.Location = New System.Drawing.Point(20, 81)
        Me.lblAwaitingDelivery.Name = "lblAwaitingDelivery"
        Me.lblAwaitingDelivery.Size = New System.Drawing.Size(48, 61)
        Me.lblAwaitingDelivery.TabIndex = 36
        Me.lblAwaitingDelivery.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 35)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "AWAITING DELIVERY"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 18
        Me.Guna2Panel1.Controls.Add(Me.lblOverdueDispensers)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(1156, 239)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel1.TabIndex = 39
        '
        'lblOverdueDispensers
        '
        Me.lblOverdueDispensers.AutoSize = True
        Me.lblOverdueDispensers.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdueDispensers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblOverdueDispensers.Location = New System.Drawing.Point(20, 81)
        Me.lblOverdueDispensers.Name = "lblOverdueDispensers"
        Me.lblOverdueDispensers.Size = New System.Drawing.Size(48, 61)
        Me.lblOverdueDispensers.TabIndex = 35
        Me.lblOverdueDispensers.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(25, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 35)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "OVERDUE DISPENSERS"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderRadius = 18
        Me.Guna2Panel5.Controls.Add(Me.lsvDueToday)
        Me.Guna2Panel5.Controls.Add(Me.Label5)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(48, 479)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(799, 549)
        Me.Guna2Panel5.TabIndex = 43
        '
        'lsvDueToday
        '
        Me.lsvDueToday.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lsvDueToday.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvDueToday.HideSelection = False
        Me.lsvDueToday.Location = New System.Drawing.Point(35, 86)
        Me.lsvDueToday.Name = "lsvDueToday"
        Me.lsvDueToday.Size = New System.Drawing.Size(723, 418)
        Me.lsvDueToday.TabIndex = 61
        Me.lsvDueToday.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(297, 35)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Due for Pickup / Delivery"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 18
        Me.Guna2Panel4.Controls.Add(Me.lsvLowStock)
        Me.Guna2Panel4.Controls.Add(Me.Label6)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(899, 479)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(578, 549)
        Me.Guna2Panel4.TabIndex = 62
        '
        'lsvLowStock
        '
        Me.lsvLowStock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvLowStock.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLowStock.HideSelection = False
        Me.lsvLowStock.Location = New System.Drawing.Point(35, 86)
        Me.lsvLowStock.Name = "lsvLowStock"
        Me.lsvLowStock.Size = New System.Drawing.Size(502, 418)
        Me.lsvLowStock.TabIndex = 61
        Me.lsvLowStock.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(29, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 35)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Low-Stock Items"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1082)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDate As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblTodaySales As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblUnpaidBalance As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAwaitingDelivery As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblOverdueDispensers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lsvDueToday As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lsvLowStock As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label6 As Label
End Class
