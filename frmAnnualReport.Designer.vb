<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnualReport
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
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblFormHint = New System.Windows.Forms.Label()
        Me.lblYear = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cboYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lsvMonths = New System.Windows.Forms.ListView()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(31, 26)
        Me.lblFormTitle.Text = "Monthly / Annual Report"
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.TabIndex = 0
        '
        'lblFormHint
        '
        Me.lblFormHint.AutoSize = True
        Me.lblFormHint.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblFormHint.Location = New System.Drawing.Point(35, 80)
        Me.lblFormHint.Text = "Compare each month with the previous month and with the same month last year"
        Me.lblFormHint.Name = "lblFormHint"
        Me.lblFormHint.TabIndex = 1
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblYear.Location = New System.Drawing.Point(1050, 56)
        Me.lblYear.Size = New System.Drawing.Size(560, 34)
        Me.lblYear.Text = "YEAR"
        Me.lblYear.Name = "lblYear"
        Me.lblYear.TabIndex = 2
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.Color.Transparent
        Me.cboYear.BorderRadius = 18
        Me.cboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboYear.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboYear.ItemHeight = 44
        Me.cboYear.Location = New System.Drawing.Point(1130, 45)
        Me.cboYear.Size = New System.Drawing.Size(250, 53)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.TabIndex = 3
        '
        'lsvMonths
        '
        Me.lsvMonths.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvMonths.HideSelection = False
        Me.lsvMonths.Location = New System.Drawing.Point(37, 150)
        Me.lsvMonths.Size = New System.Drawing.Size(1346, 640)
        Me.lsvMonths.UseCompatibleStateImageBehavior = False
        Me.lsvMonths.Name = "lsvMonths"
        Me.lsvMonths.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 20
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.White
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(1206, 810)
        Me.btnClose.Size = New System.Drawing.Size(177, 54)
        Me.btnClose.Text = "Close"
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 5
        '
        'frmAnnualReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1420, 900)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lsvMonths)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblFormHint)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Name = "frmAnnualReport"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monthly / Annual Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblFormHint As Label
    Friend WithEvents lblYear As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lsvMonths As ListView
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
End Class
