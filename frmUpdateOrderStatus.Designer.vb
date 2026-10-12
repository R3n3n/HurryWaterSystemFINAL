<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateOrderStatus
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lblOrderInfo = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboPickupStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboPaymentStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboPaymentMode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Change pickup or payment details for this order"
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblCustomers.Location = New System.Drawing.Point(18, 28)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(424, 54)
        Me.lblCustomers.TabIndex = 13
        Me.lblCustomers.Text = "Update Order Status"
        '
        'lblOrderInfo
        '
        Me.lblOrderInfo.AutoSize = True
        Me.lblOrderInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderInfo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderInfo.ForeColor = System.Drawing.Color.White
        Me.lblOrderInfo.Location = New System.Drawing.Point(37, 11)
        Me.lblOrderInfo.Name = "lblOrderInfo"
        Me.lblOrderInfo.Size = New System.Drawing.Size(423, 30)
        Me.lblOrderInfo.TabIndex = 15
        Me.lblOrderInfo.Text = "Puregold Taytay  |  Sep 15, 2026  |  ₱4,500.00"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 20
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.White
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(200, 625)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(177, 54)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
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
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(400, 625)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(177, 54)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save Changes"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 18
        Me.Guna2Panel1.Controls.Add(Me.lblOrderInfo)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(48, 158)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(511, 53)
        Me.Guna2Panel1.TabIndex = 42
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(48, 247)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(175, 33)
        Me.Guna2HtmlLabel6.TabIndex = 44
        Me.Guna2HtmlLabel6.Text = "PICKUP STATUS"
        '
        'cboPickupStatus
        '
        Me.cboPickupStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboPickupStatus.BorderRadius = 18
        Me.cboPickupStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPickupStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPickupStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPickupStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPickupStatus.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboPickupStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPickupStatus.ItemHeight = 44
        Me.cboPickupStatus.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboPickupStatus.Location = New System.Drawing.Point(48, 287)
        Me.cboPickupStatus.Name = "cboPickupStatus"
        Me.cboPickupStatus.Size = New System.Drawing.Size(528, 50)
        Me.cboPickupStatus.TabIndex = 43
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(48, 364)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(203, 33)
        Me.Guna2HtmlLabel1.TabIndex = 46
        Me.Guna2HtmlLabel1.Text = "PAYMENT STATUS"
        '
        'cboPaymentStatus
        '
        Me.cboPaymentStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboPaymentStatus.BorderRadius = 18
        Me.cboPaymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPaymentStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPaymentStatus.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPaymentStatus.ItemHeight = 44
        Me.cboPaymentStatus.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboPaymentStatus.Location = New System.Drawing.Point(48, 404)
        Me.cboPaymentStatus.Name = "cboPaymentStatus"
        Me.cboPaymentStatus.Size = New System.Drawing.Size(528, 50)
        Me.cboPaymentStatus.TabIndex = 45
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(48, 486)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(186, 33)
        Me.Guna2HtmlLabel2.TabIndex = 48
        Me.Guna2HtmlLabel2.Text = "PAYMENT MODE"
        '
        'cboPaymentMode
        '
        Me.cboPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.cboPaymentMode.BorderRadius = 18
        Me.cboPaymentMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentMode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPaymentMode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPaymentMode.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboPaymentMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPaymentMode.ItemHeight = 44
        Me.cboPaymentMode.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboPaymentMode.Location = New System.Drawing.Point(48, 525)
        Me.cboPaymentMode.Name = "cboPaymentMode"
        Me.cboPaymentMode.Size = New System.Drawing.Size(528, 50)
        Me.cboPaymentMode.TabIndex = 47
        '
        'frmUpdateOrderStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(615, 724)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.cboPaymentMode)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.cboPaymentStatus)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.cboPickupStatus)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmUpdateOrderStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmUpdateOrderStatus"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents lblOrderInfo As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboPickupStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboPaymentStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboPaymentMode As Guna.UI2.WinForms.Guna2ComboBox
End Class
