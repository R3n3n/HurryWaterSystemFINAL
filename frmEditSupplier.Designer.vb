<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditSupplier
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
        Me.txtSupplierName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblContact = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblItems = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtItemsSupplied = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.lblFormTitle.Text = "Add Supplier"
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.TabIndex = 0
        '
        'lblFormHint
        '
        Me.lblFormHint.AutoSize = True
        Me.lblFormHint.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblFormHint.Location = New System.Drawing.Point(35, 80)
        Me.lblFormHint.Text = "Who you buy supplies from"
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
        Me.lblName.Text = "SUPPLIER NAME"
        Me.lblName.Name = "lblName"
        Me.lblName.TabIndex = 2
        '
        'txtSupplierName
        '
        Me.txtSupplierName.BorderRadius = 18
        Me.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplierName.DefaultText = ""
        Me.txtSupplierName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSupplierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSupplierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplierName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplierName.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplierName.Location = New System.Drawing.Point(37, 192)
        Me.txtSupplierName.PlaceholderText = ""
        Me.txtSupplierName.SelectedText = ""
        Me.txtSupplierName.Size = New System.Drawing.Size(537, 53)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.TabIndex = 3
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(37, 270)
        Me.lblContact.Size = New System.Drawing.Size(560, 34)
        Me.lblContact.Text = "CONTACT INFO"
        Me.lblContact.Name = "lblContact"
        Me.lblContact.TabIndex = 4
        '
        'txtContact
        '
        Me.txtContact.BorderRadius = 18
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.DefaultText = ""
        Me.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(37, 312)
        Me.txtContact.PlaceholderText = ""
        Me.txtContact.SelectedText = ""
        Me.txtContact.Size = New System.Drawing.Size(537, 53)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.TabIndex = 5
        '
        'lblItems
        '
        Me.lblItems.BackColor = System.Drawing.Color.Transparent
        Me.lblItems.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblItems.Location = New System.Drawing.Point(37, 390)
        Me.lblItems.Size = New System.Drawing.Size(560, 34)
        Me.lblItems.Text = "ITEMS SUPPLIED"
        Me.lblItems.Name = "lblItems"
        Me.lblItems.TabIndex = 6
        '
        'txtItemsSupplied
        '
        Me.txtItemsSupplied.BorderRadius = 18
        Me.txtItemsSupplied.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemsSupplied.DefaultText = ""
        Me.txtItemsSupplied.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemsSupplied.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemsSupplied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemsSupplied.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemsSupplied.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemsSupplied.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemsSupplied.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemsSupplied.Location = New System.Drawing.Point(37, 432)
        Me.txtItemsSupplied.PlaceholderText = ""
        Me.txtItemsSupplied.SelectedText = ""
        Me.txtItemsSupplied.Size = New System.Drawing.Size(537, 53)
        Me.txtItemsSupplied.Name = "txtItemsSupplied"
        Me.txtItemsSupplied.TabIndex = 7
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
        Me.btnCancel.Location = New System.Drawing.Point(202, 600)
        Me.btnCancel.Size = New System.Drawing.Size(177, 54)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 8
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
        Me.btnSave.Location = New System.Drawing.Point(397, 600)
        Me.btnSave.Size = New System.Drawing.Size(177, 54)
        Me.btnSave.Text = "Save Supplier"
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 9
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmEditSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(615, 700)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtItemsSupplied)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblFormHint)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmEditSupplier"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Supplier"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblFormHint As Label
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSupplierName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblContact As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblItems As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtItemsSupplied As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents errorProvider1 As ErrorProvider
End Class
