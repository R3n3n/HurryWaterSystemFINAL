<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductionHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblSalesDelivery = New System.Windows.Forms.Label()
        Me.lblLogCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cboFilterTank = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalLiters = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalGallons = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotal350 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotal500 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lsvLogs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSalesDelivery
        '
        Me.lblSalesDelivery.AutoSize = True
        Me.lblSalesDelivery.Font = New System.Drawing.Font("Segoe UI Black", 58.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSalesDelivery.Location = New System.Drawing.Point(18, 50)
        Me.lblSalesDelivery.Name = "lblSalesDelivery"
        Me.lblSalesDelivery.Size = New System.Drawing.Size(774, 118)
        Me.lblSalesDelivery.TabIndex = 15
        Me.lblSalesDelivery.Text = "Production History"
        '
        'lblLogCount
        '
        Me.lblLogCount.AutoSize = True
        Me.lblLogCount.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblLogCount.Location = New System.Drawing.Point(32, 168)
        Me.lblLogCount.Name = "lblLogCount"
        Me.lblLogCount.Size = New System.Drawing.Size(426, 53)
        Me.lblLogCount.TabIndex = 17
        Me.lblLogCount.Text = "Enter today's tank output "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(34, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 46)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "FROM"
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderRadius = 18
        Me.dtpFrom.Checked = True
        Me.dtpFrom.FillColor = System.Drawing.Color.White
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFrom.Location = New System.Drawing.Point(41, 320)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(467, 60)
        Me.dtpFrom.TabIndex = 19
        Me.dtpFrom.Value = New Date(2026, 9, 27, 15, 5, 9, 282)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(550, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 46)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "TO"
        '
        'dtpTo
        '
        Me.dtpTo.BorderRadius = 18
        Me.dtpTo.Checked = True
        Me.dtpTo.FillColor = System.Drawing.Color.White
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTo.Location = New System.Drawing.Point(558, 320)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(467, 60)
        Me.dtpTo.TabIndex = 21
        Me.dtpTo.Value = New Date(2026, 9, 27, 15, 5, 9, 282)
        '
        'cboFilterTank
        '
        Me.cboFilterTank.BackColor = System.Drawing.Color.Transparent
        Me.cboFilterTank.BorderRadius = 18
        Me.cboFilterTank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilterTank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterTank.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterTank.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterTank.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilterTank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboFilterTank.ItemHeight = 50
        Me.cboFilterTank.Location = New System.Drawing.Point(1071, 320)
        Me.cboFilterTank.Name = "cboFilterTank"
        Me.cboFilterTank.Size = New System.Drawing.Size(427, 60)
        Me.cboFilterTank.TabIndex = 25
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(1071, 265)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(79, 50)
        Me.Guna2HtmlLabel1.TabIndex = 24
        Me.Guna2HtmlLabel1.Text = "TANK"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 18
        Me.Guna2Panel2.Controls.Add(Me.lblTotalLiters)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(41, 428)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel2.TabIndex = 42
        '
        'lblTotalLiters
        '
        Me.lblTotalLiters.AutoSize = True
        Me.lblTotalLiters.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLiters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblTotalLiters.Location = New System.Drawing.Point(20, 81)
        Me.lblTotalLiters.Name = "lblTotalLiters"
        Me.lblTotalLiters.Size = New System.Drawing.Size(48, 61)
        Me.lblTotalLiters.TabIndex = 36
        Me.lblTotalLiters.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(25, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 35)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "TOTAL LITERS"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 18
        Me.Guna2Panel1.Controls.Add(Me.lblTotalGallons)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(420, 428)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel1.TabIndex = 42
        '
        'lblTotalGallons
        '
        Me.lblTotalGallons.AutoSize = True
        Me.lblTotalGallons.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGallons.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblTotalGallons.Location = New System.Drawing.Point(20, 81)
        Me.lblTotalGallons.Name = "lblTotalGallons"
        Me.lblTotalGallons.Size = New System.Drawing.Size(48, 61)
        Me.lblTotalGallons.TabIndex = 36
        Me.lblTotalGallons.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(25, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 35)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "GALLONS"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 18
        Me.Guna2Panel3.Controls.Add(Me.lblTotal350)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(802, 428)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel3.TabIndex = 42
        '
        'lblTotal350
        '
        Me.lblTotal350.AutoSize = True
        Me.lblTotal350.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal350.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblTotal350.Location = New System.Drawing.Point(20, 81)
        Me.lblTotal350.Name = "lblTotal350"
        Me.lblTotal350.Size = New System.Drawing.Size(48, 61)
        Me.lblTotal350.TabIndex = 36
        Me.lblTotal350.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(25, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 35)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "350ML BOTTLES"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 18
        Me.Guna2Panel4.Controls.Add(Me.lblTotal500)
        Me.Guna2Panel4.Controls.Add(Me.Label10)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(1178, 428)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel4.TabIndex = 42
        '
        'lblTotal500
        '
        Me.lblTotal500.AutoSize = True
        Me.lblTotal500.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblTotal500.Location = New System.Drawing.Point(20, 81)
        Me.lblTotal500.Name = "lblTotal500"
        Me.lblTotal500.Size = New System.Drawing.Size(48, 61)
        Me.lblTotal500.TabIndex = 36
        Me.lblTotal500.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(25, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 35)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "500ML BOTTLES"
        '
        'lsvLogs
        '
        Me.lsvLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvLogs.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLogs.HideSelection = False
        Me.lsvLogs.Location = New System.Drawing.Point(41, 659)
        Me.lsvLogs.Name = "lsvLogs"
        Me.lsvLogs.Size = New System.Drawing.Size(1458, 355)
        Me.lsvLogs.TabIndex = 59
        Me.lsvLogs.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'frmProductionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1082)
        Me.Controls.Add(Me.lsvLogs)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.cboFilterTank)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.lblLogCount)
        Me.Controls.Add(Me.lblSalesDelivery)
        Me.Name = "frmProductionHistory"
        Me.Text = "frmProductionHistory"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalesDelivery As Label
    Friend WithEvents lblLogCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cboFilterTank As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalLiters As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalGallons As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotal350 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotal500 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lsvLogs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
