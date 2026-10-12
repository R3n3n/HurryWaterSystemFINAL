<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBorrowRecord
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
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDispenserRef = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboCustomer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtpDateBorrowed = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtpExpectedReturn = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(40, 281)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(181, 34)
        Me.Guna2HtmlLabel3.TabIndex = 54
        Me.Guna2HtmlLabel3.Text = "DISPENSER REF."
        '
        'txtDispenserRef
        '
        Me.txtDispenserRef.BorderRadius = 18
        Me.txtDispenserRef.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDispenserRef.DefaultText = ""
        Me.txtDispenserRef.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDispenserRef.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDispenserRef.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDispenserRef.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDispenserRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDispenserRef.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispenserRef.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDispenserRef.Location = New System.Drawing.Point(40, 323)
        Me.txtDispenserRef.Name = "txtDispenserRef"
        Me.txtDispenserRef.PlaceholderText = "e.g. DSP-015"
        Me.txtDispenserRef.SelectedText = ""
        Me.txtDispenserRef.Size = New System.Drawing.Size(537, 53)
        Me.txtDispenserRef.TabIndex = 53
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(40, 149)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(130, 34)
        Me.Guna2HtmlLabel6.TabIndex = 52
        Me.Guna2HtmlLabel6.Text = "CUSTOMER"
        '
        'cboCustomer
        '
        Me.cboCustomer.BackColor = System.Drawing.Color.Transparent
        Me.cboCustomer.BorderRadius = 18
        Me.cboCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomer.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCustomer.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboCustomer.ItemHeight = 44
        Me.cboCustomer.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboCustomer.Location = New System.Drawing.Point(40, 192)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(537, 53)
        Me.cboCustomer.TabIndex = 51
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
        Me.btnCancel.Location = New System.Drawing.Point(202, 569)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(177, 54)
        Me.btnCancel.TabIndex = 48
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
        Me.btnSave.Location = New System.Drawing.Point(400, 569)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(177, 54)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "Save Expense"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 31)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Log a dispenser being lent to a customer"
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblCustomers.Location = New System.Drawing.Point(29, 29)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(417, 54)
        Me.lblCustomers.TabIndex = 45
        Me.lblCustomers.Text = "New Borrow Record"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(40, 423)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(203, 34)
        Me.Guna2HtmlLabel1.TabIndex = 56
        Me.Guna2HtmlLabel1.Text = "DATE BORROWED"
        '
        'dtpDateBorrowed
        '
        Me.dtpDateBorrowed.BorderRadius = 18
        Me.dtpDateBorrowed.Checked = True
        Me.dtpDateBorrowed.FillColor = System.Drawing.Color.White
        Me.dtpDateBorrowed.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.dtpDateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateBorrowed.Location = New System.Drawing.Point(40, 465)
        Me.dtpDateBorrowed.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateBorrowed.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateBorrowed.Name = "dtpDateBorrowed"
        Me.dtpDateBorrowed.Size = New System.Drawing.Size(244, 53)
        Me.dtpDateBorrowed.TabIndex = 55
        Me.dtpDateBorrowed.Value = New Date(2026, 9, 27, 15, 5, 9, 282)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(332, 423)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(217, 34)
        Me.Guna2HtmlLabel2.TabIndex = 58
        Me.Guna2HtmlLabel2.Text = "EXPECTED RETURN"
        '
        'dtpExpectedReturn
        '
        Me.dtpExpectedReturn.BorderRadius = 18
        Me.dtpExpectedReturn.Checked = True
        Me.dtpExpectedReturn.FillColor = System.Drawing.Color.White
        Me.dtpExpectedReturn.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.dtpExpectedReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpectedReturn.Location = New System.Drawing.Point(332, 465)
        Me.dtpExpectedReturn.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpExpectedReturn.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpExpectedReturn.Name = "dtpExpectedReturn"
        Me.dtpExpectedReturn.Size = New System.Drawing.Size(244, 53)
        Me.dtpExpectedReturn.TabIndex = 57
        Me.dtpExpectedReturn.Value = New Date(2026, 9, 27, 15, 5, 9, 282)
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmAddBorrowRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(615, 669)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.dtpExpectedReturn)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.dtpDateBorrowed)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.txtDispenserRef)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmAddBorrowRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddBorrowRecord"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDispenserRef As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboCustomer As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtpDateBorrowed As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtpExpectedReturn As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents errorProvider1 As ErrorProvider
End Class
