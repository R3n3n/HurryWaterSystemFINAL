<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditProduct
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
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblFormHint = New System.Windows.Forms.Label()
        Me.lblCategory = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblContainer = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboContainer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblContainerOther = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtContainerOther = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblWater = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboWaterType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblWaterOther = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtWaterOther = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(31, 26)
        Me.lblFormTitle.Text = "Add Product"
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.TabIndex = 0
        '
        'lblFormHint
        '
        Me.lblFormHint.AutoSize = True
        Me.lblFormHint.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblFormHint.Location = New System.Drawing.Point(35, 80)
        Me.lblFormHint.Text = "Set what you sell and its price"
        Me.lblFormHint.Name = "lblFormHint"
        Me.lblFormHint.TabIndex = 1
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(37, 150)
        Me.lblCategory.Size = New System.Drawing.Size(560, 34)
        Me.lblCategory.Text = "CATEGORY"
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.TabIndex = 2
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.Transparent
        Me.cboCategory.BorderRadius = 18
        Me.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboCategory.ItemHeight = 44
        Me.cboCategory.Location = New System.Drawing.Point(37, 192)
        Me.cboCategory.Size = New System.Drawing.Size(537, 53)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.TabIndex = 3
        '
        'lblContainer
        '
        Me.lblContainer.BackColor = System.Drawing.Color.Transparent
        Me.lblContainer.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblContainer.Location = New System.Drawing.Point(37, 270)
        Me.lblContainer.Size = New System.Drawing.Size(560, 34)
        Me.lblContainer.Text = "CONTAINER"
        Me.lblContainer.Name = "lblContainer"
        Me.lblContainer.TabIndex = 4
        '
        'cboContainer
        '
        Me.cboContainer.BackColor = System.Drawing.Color.Transparent
        Me.cboContainer.BorderRadius = 18
        Me.cboContainer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContainer.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboContainer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboContainer.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboContainer.ItemHeight = 44
        Me.cboContainer.Location = New System.Drawing.Point(37, 312)
        Me.cboContainer.Size = New System.Drawing.Size(537, 53)
        Me.cboContainer.Name = "cboContainer"
        Me.cboContainer.TabIndex = 5
        '
        'lblContainerOther
        '
        Me.lblContainerOther.BackColor = System.Drawing.Color.Transparent
        Me.lblContainerOther.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainerOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblContainerOther.Location = New System.Drawing.Point(600, 270)
        Me.lblContainerOther.Size = New System.Drawing.Size(560, 34)
        Me.lblContainerOther.Text = "SPECIFY NEW CONTAINER"
        Me.lblContainerOther.Name = "lblContainerOther"
        Me.lblContainerOther.TabIndex = 6
        '
        'txtContainerOther
        '
        Me.txtContainerOther.BorderRadius = 18
        Me.txtContainerOther.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContainerOther.DefaultText = ""
        Me.txtContainerOther.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContainerOther.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContainerOther.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContainerOther.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContainerOther.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContainerOther.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContainerOther.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContainerOther.Location = New System.Drawing.Point(600, 312)
        Me.txtContainerOther.PlaceholderText = ""
        Me.txtContainerOther.SelectedText = ""
        Me.txtContainerOther.Size = New System.Drawing.Size(420, 53)
        Me.txtContainerOther.Name = "txtContainerOther"
        Me.txtContainerOther.TabIndex = 7
        '
        'lblWater
        '
        Me.lblWater.BackColor = System.Drawing.Color.Transparent
        Me.lblWater.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWater.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblWater.Location = New System.Drawing.Point(37, 390)
        Me.lblWater.Size = New System.Drawing.Size(560, 34)
        Me.lblWater.Text = "WATER TYPE"
        Me.lblWater.Name = "lblWater"
        Me.lblWater.TabIndex = 8
        '
        'cboWaterType
        '
        Me.cboWaterType.BackColor = System.Drawing.Color.Transparent
        Me.cboWaterType.BorderRadius = 18
        Me.cboWaterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboWaterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWaterType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboWaterType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboWaterType.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboWaterType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboWaterType.ItemHeight = 44
        Me.cboWaterType.Location = New System.Drawing.Point(37, 432)
        Me.cboWaterType.Size = New System.Drawing.Size(537, 53)
        Me.cboWaterType.Name = "cboWaterType"
        Me.cboWaterType.TabIndex = 9
        '
        'lblWaterOther
        '
        Me.lblWaterOther.BackColor = System.Drawing.Color.Transparent
        Me.lblWaterOther.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaterOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblWaterOther.Location = New System.Drawing.Point(600, 390)
        Me.lblWaterOther.Size = New System.Drawing.Size(560, 34)
        Me.lblWaterOther.Text = "SPECIFY NEW WATER TYPE"
        Me.lblWaterOther.Name = "lblWaterOther"
        Me.lblWaterOther.TabIndex = 10
        '
        'txtWaterOther
        '
        Me.txtWaterOther.BorderRadius = 18
        Me.txtWaterOther.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWaterOther.DefaultText = ""
        Me.txtWaterOther.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtWaterOther.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtWaterOther.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWaterOther.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWaterOther.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWaterOther.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterOther.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWaterOther.Location = New System.Drawing.Point(600, 432)
        Me.txtWaterOther.PlaceholderText = ""
        Me.txtWaterOther.SelectedText = ""
        Me.txtWaterOther.Size = New System.Drawing.Size(420, 53)
        Me.txtWaterOther.Name = "txtWaterOther"
        Me.txtWaterOther.TabIndex = 11
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(37, 510)
        Me.lblPrice.Size = New System.Drawing.Size(560, 34)
        Me.lblPrice.Text = "UNIT PRICE (₱)"
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.TabIndex = 12
        '
        'txtPrice
        '
        Me.txtPrice.BorderRadius = 18
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(37, 552)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(537, 53)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.TabIndex = 13
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(37, 630)
        Me.lblStatus.Size = New System.Drawing.Size(560, 34)
        Me.lblStatus.Text = "STATUS"
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TabIndex = 14
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboStatus.BorderRadius = 18
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboStatus.ItemHeight = 44
        Me.cboStatus.Location = New System.Drawing.Point(37, 672)
        Me.cboStatus.Size = New System.Drawing.Size(537, 53)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TabIndex = 15
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
        Me.btnCancel.Location = New System.Drawing.Point(645, 780)
        Me.btnCancel.Size = New System.Drawing.Size(177, 54)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 16
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
        Me.btnSave.Location = New System.Drawing.Point(840, 780)
        Me.btnSave.Size = New System.Drawing.Size(177, 54)
        Me.btnSave.Text = "Save Product"
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 17
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmEditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1060, 880)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtWaterOther)
        Me.Controls.Add(Me.lblWaterOther)
        Me.Controls.Add(Me.cboWaterType)
        Me.Controls.Add(Me.lblWater)
        Me.Controls.Add(Me.txtContainerOther)
        Me.Controls.Add(Me.lblContainerOther)
        Me.Controls.Add(Me.cboContainer)
        Me.Controls.Add(Me.lblContainer)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblFormHint)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmEditProduct"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblFormHint As Label
    Friend WithEvents lblCategory As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblContainer As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboContainer As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblContainerOther As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtContainerOther As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblWater As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboWaterType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblWaterOther As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtWaterOther As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents errorProvider1 As ErrorProvider
End Class
