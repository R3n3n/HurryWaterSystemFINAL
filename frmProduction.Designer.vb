<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduction
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
        Me.lblSalesDelivery = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtpLogDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboTank = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.nudLiters = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBottles500 = New System.Windows.Forms.Label()
        Me.lblBottles350 = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.nudLiters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSalesDelivery
        '
        Me.lblSalesDelivery.AutoSize = True
        Me.lblSalesDelivery.Font = New System.Drawing.Font("Segoe UI Black", 58.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSalesDelivery.Location = New System.Drawing.Point(38, 33)
        Me.lblSalesDelivery.Name = "lblSalesDelivery"
        Me.lblSalesDelivery.Size = New System.Drawing.Size(632, 118)
        Me.lblSalesDelivery.TabIndex = 14
        Me.lblSalesDelivery.Text = "Log Production"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 53)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Enter today's tank output "
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(56, 284)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(80, 50)
        Me.Guna2HtmlLabel3.TabIndex = 20
        Me.Guna2HtmlLabel3.Text = "DATE"
        '
        'dtpLogDate
        '
        Me.dtpLogDate.BorderRadius = 18
        Me.dtpLogDate.Checked = True
        Me.dtpLogDate.FillColor = System.Drawing.Color.White
        Me.dtpLogDate.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.dtpLogDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpLogDate.Location = New System.Drawing.Point(56, 343)
        Me.dtpLogDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpLogDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpLogDate.Name = "dtpLogDate"
        Me.dtpLogDate.Size = New System.Drawing.Size(376, 60)
        Me.dtpLogDate.TabIndex = 21
        Me.dtpLogDate.Value = New Date(2026, 9, 27, 15, 5, 9, 282)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(528, 284)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(85, 50)
        Me.Guna2HtmlLabel1.TabIndex = 22
        Me.Guna2HtmlLabel1.Text = "TANK"
        '
        'cboTank
        '
        Me.cboTank.BackColor = System.Drawing.Color.Transparent
        Me.cboTank.BorderRadius = 18
        Me.cboTank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTank.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTank.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTank.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboTank.ItemHeight = 50
        Me.cboTank.Location = New System.Drawing.Point(528, 343)
        Me.cboTank.Name = "cboTank"
        Me.cboTank.Size = New System.Drawing.Size(427, 60)
        Me.cboTank.TabIndex = 23
        '
        'nudLiters
        '
        Me.nudLiters.BackColor = System.Drawing.Color.Transparent
        Me.nudLiters.BorderRadius = 18
        Me.nudLiters.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudLiters.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLiters.Location = New System.Drawing.Point(56, 486)
        Me.nudLiters.Name = "nudLiters"
        Me.nudLiters.Size = New System.Drawing.Size(900, 60)
        Me.nudLiters.TabIndex = 26
        Me.nudLiters.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudLiters.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(56, 426)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(262, 50)
        Me.Guna2HtmlLabel2.TabIndex = 27
        Me.Guna2HtmlLabel2.Text = "LITERS PRODUCED"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 18
        Me.Guna2Panel1.Controls.Add(Me.lblBottles500)
        Me.Guna2Panel1.Controls.Add(Me.lblBottles350)
        Me.Guna2Panel1.Controls.Add(Me.lblGallons)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(56, 599)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(900, 251)
        Me.Guna2Panel1.TabIndex = 28
        '
        'lblBottles500
        '
        Me.lblBottles500.AutoSize = True
        Me.lblBottles500.BackColor = System.Drawing.Color.Transparent
        Me.lblBottles500.Font = New System.Drawing.Font("Segoe UI", 31.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottles500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblBottles500.Location = New System.Drawing.Point(638, 148)
        Me.lblBottles500.Name = "lblBottles500"
        Me.lblBottles500.Size = New System.Drawing.Size(50, 66)
        Me.lblBottles500.TabIndex = 27
        Me.lblBottles500.Text = "0"
        '
        'lblBottles350
        '
        Me.lblBottles350.AutoSize = True
        Me.lblBottles350.BackColor = System.Drawing.Color.Transparent
        Me.lblBottles350.Font = New System.Drawing.Font("Segoe UI", 31.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottles350.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblBottles350.Location = New System.Drawing.Point(326, 148)
        Me.lblBottles350.Name = "lblBottles350"
        Me.lblBottles350.Size = New System.Drawing.Size(50, 66)
        Me.lblBottles350.TabIndex = 26
        Me.lblBottles350.Text = "0"
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.BackColor = System.Drawing.Color.Transparent
        Me.lblGallons.Font = New System.Drawing.Font("Segoe UI", 31.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblGallons.Location = New System.Drawing.Point(35, 148)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(50, 66)
        Me.lblGallons.TabIndex = 25
        Me.lblGallons.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(642, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 35)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "500mL Bottles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(331, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 35)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "350mL Bottles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(40, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 35)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Gallons"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(40, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(394, 35)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "AUTO-CALCULATED EQUIVALENTS"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 20
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnSave.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(724, 904)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(231, 70)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save Log"
        '
        'frmProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1082)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.nudLiters)
        Me.Controls.Add(Me.cboTank)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.dtpLogDate)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSalesDelivery)
        Me.Name = "frmProduction"
        Me.Text = "frmProduction"
        CType(Me.nudLiters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalesDelivery As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtpLogDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboTank As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents nudLiters As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBottles500 As Label
    Friend WithEvents lblBottles350 As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
End Class
