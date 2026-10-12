<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditInventoryItem
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
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUnit = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtUnit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPackSize = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPackSize = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPackCost = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPackCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblReorder = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtReorder = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSafety = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSafety = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSupplier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboSupplier = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblUnitCostPreview = New System.Windows.Forms.Label()
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
        Me.lblFormTitle.Text = "Add Inventory Item"
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.TabIndex = 0
        '
        'lblFormHint
        '
        Me.lblFormHint.AutoSize = True
        Me.lblFormHint.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblFormHint.Location = New System.Drawing.Point(35, 80)
        Me.lblFormHint.Text = "Stock on hand is changed with Stock In / Stock Out, not here"
        Me.lblFormHint.Name = "lblFormHint"
        Me.lblFormHint.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(37, 150)
        Me.lblName.Size = New System.Drawing.Size(560, 34)
        Me.lblName.Text = "ITEM NAME"
        Me.lblName.Name = "lblName"
        Me.lblName.TabIndex = 2
        '
        'txtItemName
        '
        Me.txtItemName.BorderRadius = 18
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.Location = New System.Drawing.Point(37, 192)
        Me.txtItemName.PlaceholderText = ""
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.Size = New System.Drawing.Size(537, 53)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.TabIndex = 3
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblUnit.Location = New System.Drawing.Point(37, 270)
        Me.lblUnit.Size = New System.Drawing.Size(560, 34)
        Me.lblUnit.Text = "UNIT (pcs, kg, gallon...)"
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.TabIndex = 4
        '
        'txtUnit
        '
        Me.txtUnit.BorderRadius = 18
        Me.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnit.DefaultText = ""
        Me.txtUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnit.Location = New System.Drawing.Point(37, 312)
        Me.txtUnit.PlaceholderText = ""
        Me.txtUnit.SelectedText = ""
        Me.txtUnit.Size = New System.Drawing.Size(537, 53)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.TabIndex = 5
        '
        'lblPackSize
        '
        Me.lblPackSize.BackColor = System.Drawing.Color.Transparent
        Me.lblPackSize.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblPackSize.Location = New System.Drawing.Point(37, 390)
        Me.lblPackSize.Size = New System.Drawing.Size(560, 34)
        Me.lblPackSize.Text = "PACK SIZE (units per pack)"
        Me.lblPackSize.Name = "lblPackSize"
        Me.lblPackSize.TabIndex = 6
        '
        'txtPackSize
        '
        Me.txtPackSize.BorderRadius = 18
        Me.txtPackSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPackSize.DefaultText = ""
        Me.txtPackSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPackSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPackSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPackSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPackSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPackSize.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPackSize.Location = New System.Drawing.Point(37, 432)
        Me.txtPackSize.PlaceholderText = ""
        Me.txtPackSize.SelectedText = ""
        Me.txtPackSize.Size = New System.Drawing.Size(537, 53)
        Me.txtPackSize.Name = "txtPackSize"
        Me.txtPackSize.TabIndex = 7
        '
        'lblPackCost
        '
        Me.lblPackCost.BackColor = System.Drawing.Color.Transparent
        Me.lblPackCost.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblPackCost.Location = New System.Drawing.Point(37, 510)
        Me.lblPackCost.Size = New System.Drawing.Size(560, 34)
        Me.lblPackCost.Text = "PACK COST (₱)"
        Me.lblPackCost.Name = "lblPackCost"
        Me.lblPackCost.TabIndex = 8
        '
        'txtPackCost
        '
        Me.txtPackCost.BorderRadius = 18
        Me.txtPackCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPackCost.DefaultText = ""
        Me.txtPackCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPackCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPackCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPackCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPackCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPackCost.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPackCost.Location = New System.Drawing.Point(37, 552)
        Me.txtPackCost.PlaceholderText = ""
        Me.txtPackCost.SelectedText = ""
        Me.txtPackCost.Size = New System.Drawing.Size(537, 53)
        Me.txtPackCost.Name = "txtPackCost"
        Me.txtPackCost.TabIndex = 9
        '
        'lblReorder
        '
        Me.lblReorder.BackColor = System.Drawing.Color.Transparent
        Me.lblReorder.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblReorder.Location = New System.Drawing.Point(640, 150)
        Me.lblReorder.Size = New System.Drawing.Size(560, 34)
        Me.lblReorder.Text = "REORDER POINT"
        Me.lblReorder.Name = "lblReorder"
        Me.lblReorder.TabIndex = 10
        '
        'txtReorder
        '
        Me.txtReorder.BorderRadius = 18
        Me.txtReorder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReorder.DefaultText = ""
        Me.txtReorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReorder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReorder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReorder.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReorder.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReorder.Location = New System.Drawing.Point(640, 192)
        Me.txtReorder.PlaceholderText = ""
        Me.txtReorder.SelectedText = ""
        Me.txtReorder.Size = New System.Drawing.Size(537, 53)
        Me.txtReorder.Name = "txtReorder"
        Me.txtReorder.TabIndex = 11
        '
        'lblSafety
        '
        Me.lblSafety.BackColor = System.Drawing.Color.Transparent
        Me.lblSafety.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSafety.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSafety.Location = New System.Drawing.Point(640, 270)
        Me.lblSafety.Size = New System.Drawing.Size(560, 34)
        Me.lblSafety.Text = "SAFETY STOCK"
        Me.lblSafety.Name = "lblSafety"
        Me.lblSafety.TabIndex = 12
        '
        'txtSafety
        '
        Me.txtSafety.BorderRadius = 18
        Me.txtSafety.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSafety.DefaultText = ""
        Me.txtSafety.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSafety.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSafety.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSafety.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSafety.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSafety.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSafety.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSafety.Location = New System.Drawing.Point(640, 312)
        Me.txtSafety.PlaceholderText = ""
        Me.txtSafety.SelectedText = ""
        Me.txtSafety.Size = New System.Drawing.Size(537, 53)
        Me.txtSafety.Name = "txtSafety"
        Me.txtSafety.TabIndex = 13
        '
        'lblSupplier
        '
        Me.lblSupplier.BackColor = System.Drawing.Color.Transparent
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSupplier.Location = New System.Drawing.Point(640, 390)
        Me.lblSupplier.Size = New System.Drawing.Size(560, 34)
        Me.lblSupplier.Text = "SUPPLIER"
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.TabIndex = 14
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Transparent
        Me.cboSupplier.BorderRadius = 18
        Me.cboSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplier.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSupplier.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboSupplier.ItemHeight = 44
        Me.cboSupplier.Location = New System.Drawing.Point(640, 432)
        Me.cboSupplier.Size = New System.Drawing.Size(537, 53)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.TabIndex = 15
        '
        'lblUnitCostPreview
        '
        Me.lblUnitCostPreview.AutoSize = True
        Me.lblUnitCostPreview.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitCostPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblUnitCostPreview.Location = New System.Drawing.Point(644, 520)
        Me.lblUnitCostPreview.Text = "Cost per unit: ₱0.00"
        Me.lblUnitCostPreview.Name = "lblUnitCostPreview"
        Me.lblUnitCostPreview.TabIndex = 16
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
        Me.btnCancel.Location = New System.Drawing.Point(826, 700)
        Me.btnCancel.Size = New System.Drawing.Size(177, 54)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 17
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
        Me.btnSave.Location = New System.Drawing.Point(1021, 700)
        Me.btnSave.Size = New System.Drawing.Size(177, 54)
        Me.btnSave.Text = "Save Item"
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 18
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmEditInventoryItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1215, 800)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblUnitCostPreview)
        Me.Controls.Add(Me.cboSupplier)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.txtSafety)
        Me.Controls.Add(Me.lblSafety)
        Me.Controls.Add(Me.txtReorder)
        Me.Controls.Add(Me.lblReorder)
        Me.Controls.Add(Me.txtPackCost)
        Me.Controls.Add(Me.lblPackCost)
        Me.Controls.Add(Me.txtPackSize)
        Me.Controls.Add(Me.lblPackSize)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblFormHint)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmEditInventoryItem"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory Item"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblFormHint As Label
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUnit As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtUnit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPackSize As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPackSize As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPackCost As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPackCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblReorder As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtReorder As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSafety As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSafety As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSupplier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboSupplier As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblUnitCostPreview As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents errorProvider1 As ErrorProvider
End Class
