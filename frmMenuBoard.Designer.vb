<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuBoard
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnProductionHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSetup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDispenserBorrowing = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExpenses = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProduction = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalesDelivery = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCustomers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2GradientPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Size = New System.Drawing.Size(1920, 1080)
        Me.SplitContainer1.SplitterDistance = 369
        Me.SplitContainer1.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btnProductionHistory)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnLogout)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSetup)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnUsers)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnReports)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnDispenserBorrowing)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnExpenses)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnInventory)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnProduction)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSalesDelivery)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnCustomers)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnDashboard)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(378, 1093)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'btnProductionHistory
        '
        Me.btnProductionHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnProductionHistory.BorderRadius = 18
        Me.btnProductionHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProductionHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProductionHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProductionHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProductionHistory.FillColor = System.Drawing.Color.Transparent
        Me.btnProductionHistory.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductionHistory.ForeColor = System.Drawing.Color.White
        Me.btnProductionHistory.Location = New System.Drawing.Point(40, 528)
        Me.btnProductionHistory.Name = "btnProductionHistory"
        Me.btnProductionHistory.Size = New System.Drawing.Size(296, 58)
        Me.btnProductionHistory.TabIndex = 11
        Me.btnProductionHistory.Text = "Production History"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderRadius = 18
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(40, 997)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(296, 61)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        '
        'btnSetup
        '
        Me.btnSetup.BackColor = System.Drawing.Color.Transparent
        Me.btnSetup.BorderRadius = 18
        Me.btnSetup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSetup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSetup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSetup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSetup.FillColor = System.Drawing.Color.Transparent
        Me.btnSetup.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.ForeColor = System.Drawing.Color.White
        Me.btnSetup.Location = New System.Drawing.Point(40, 720)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(296, 58)
        Me.btnSetup.TabIndex = 12
        Me.btnSetup.Text = "Product Catalog"
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnUsers.BorderRadius = 18
        Me.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(40, 912)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(296, 58)
        Me.btnUsers.TabIndex = 9
        Me.btnUsers.Text = "Users"
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.BorderRadius = 18
        Me.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReports.FillColor = System.Drawing.Color.Transparent
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(40, 848)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(296, 58)
        Me.btnReports.TabIndex = 8
        Me.btnReports.Text = "Reports"
        '
        'btnDispenserBorrowing
        '
        Me.btnDispenserBorrowing.BackColor = System.Drawing.Color.Transparent
        Me.btnDispenserBorrowing.BorderRadius = 18
        Me.btnDispenserBorrowing.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDispenserBorrowing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDispenserBorrowing.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDispenserBorrowing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDispenserBorrowing.FillColor = System.Drawing.Color.Transparent
        Me.btnDispenserBorrowing.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispenserBorrowing.ForeColor = System.Drawing.Color.White
        Me.btnDispenserBorrowing.Location = New System.Drawing.Point(40, 656)
        Me.btnDispenserBorrowing.Name = "btnDispenserBorrowing"
        Me.btnDispenserBorrowing.Size = New System.Drawing.Size(296, 58)
        Me.btnDispenserBorrowing.TabIndex = 7
        Me.btnDispenserBorrowing.Text = "Dispenser Borrowing"
        '
        'btnExpenses
        '
        Me.btnExpenses.BackColor = System.Drawing.Color.Transparent
        Me.btnExpenses.BorderRadius = 18
        Me.btnExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExpenses.FillColor = System.Drawing.Color.Transparent
        Me.btnExpenses.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpenses.ForeColor = System.Drawing.Color.White
        Me.btnExpenses.Location = New System.Drawing.Point(40, 784)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(296, 58)
        Me.btnExpenses.TabIndex = 6
        Me.btnExpenses.Text = "Expenses"
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.BorderRadius = 18
        Me.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInventory.FillColor = System.Drawing.Color.Transparent
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Location = New System.Drawing.Point(40, 592)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(296, 58)
        Me.btnInventory.TabIndex = 5
        Me.btnInventory.Text = "Inventory"
        '
        'btnProduction
        '
        Me.btnProduction.BackColor = System.Drawing.Color.Transparent
        Me.btnProduction.BorderRadius = 18
        Me.btnProduction.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProduction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProduction.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProduction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProduction.FillColor = System.Drawing.Color.Transparent
        Me.btnProduction.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduction.ForeColor = System.Drawing.Color.White
        Me.btnProduction.Location = New System.Drawing.Point(40, 464)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(296, 58)
        Me.btnProduction.TabIndex = 4
        Me.btnProduction.Text = "Production"
        '
        'btnSalesDelivery
        '
        Me.btnSalesDelivery.BackColor = System.Drawing.Color.Transparent
        Me.btnSalesDelivery.BorderRadius = 18
        Me.btnSalesDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSalesDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSalesDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalesDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSalesDelivery.FillColor = System.Drawing.Color.Transparent
        Me.btnSalesDelivery.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesDelivery.ForeColor = System.Drawing.Color.White
        Me.btnSalesDelivery.Location = New System.Drawing.Point(40, 400)
        Me.btnSalesDelivery.Name = "btnSalesDelivery"
        Me.btnSalesDelivery.Size = New System.Drawing.Size(296, 58)
        Me.btnSalesDelivery.TabIndex = 3
        Me.btnSalesDelivery.Text = "Sales / Delivery"
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomers.BorderRadius = 18
        Me.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCustomers.FillColor = System.Drawing.Color.Transparent
        Me.btnCustomers.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Location = New System.Drawing.Point(40, 336)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(296, 58)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Customers"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BorderRadius = 18
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(40, 272)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(296, 58)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.lblUsername)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(369, 255)
        Me.Guna2Panel1.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(116, 192)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(134, 40)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.HurryWaterSystem.My.Resources.Resources.AccountLogo
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(123, 41)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(121, 119)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'frmMenuBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenuBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuBoard"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSetup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDispenserBorrowing As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExpenses As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProduction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSalesDelivery As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCustomers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnProductionHistory As Guna.UI2.WinForms.Guna2Button
End Class
