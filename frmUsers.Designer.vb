<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.btnAddUser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnToggleStatus = New Guna.UI2.WinForms.Guna2Button()
        Me.lsvUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblSalesDelivery
        '
        Me.lblSalesDelivery.AutoSize = True
        Me.lblSalesDelivery.Font = New System.Drawing.Font("Segoe UI Black", 58.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSalesDelivery.Location = New System.Drawing.Point(32, 43)
        Me.lblSalesDelivery.Name = "lblSalesDelivery"
        Me.lblSalesDelivery.Size = New System.Drawing.Size(256, 104)
        Me.lblSalesDelivery.TabIndex = 17
        Me.lblSalesDelivery.Text = "Users"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 32)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Owner-only screen"
        '
        'btnAddUser
        '
        Me.btnAddUser.BorderRadius = 20
        Me.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnAddUser.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(1169, 91)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(318, 96)
        Me.btnAddUser.TabIndex = 32
        Me.btnAddUser.Text = "+ Add Staff Account"
        '
        'btnToggleStatus
        '
        Me.btnToggleStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnToggleStatus.BorderRadius = 20
        Me.btnToggleStatus.BorderThickness = 1
        Me.btnToggleStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToggleStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToggleStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToggleStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToggleStatus.FillColor = System.Drawing.Color.White
        Me.btnToggleStatus.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnToggleStatus.Location = New System.Drawing.Point(793, 91)
        Me.btnToggleStatus.Name = "btnToggleStatus"
        Me.btnToggleStatus.Size = New System.Drawing.Size(348, 96)
        Me.btnToggleStatus.TabIndex = 34
        Me.btnToggleStatus.Text = "Deactivate / Reactivate"
        '
        'lsvUsers
        '
        Me.lsvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvUsers.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvUsers.HideSelection = False
        Me.lsvUsers.Location = New System.Drawing.Point(50, 246)
        Me.lsvUsers.Name = "lsvUsers"
        Me.lsvUsers.Size = New System.Drawing.Size(1437, 781)
        Me.lsvUsers.TabIndex = 59
        Me.lsvUsers.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'btnEdit
        '
        Me.btnEdit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnEdit.BorderRadius = 20
        Me.btnEdit.BorderThickness = 1
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.White
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(539, 91)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(233, 96)
        Me.btnEdit.TabIndex = 60
        Me.btnEdit.Text = "Edit Account"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1061)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lsvUsers)
        Me.Controls.Add(Me.btnToggleStatus)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSalesDelivery)
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalesDelivery As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddUser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnToggleStatus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lsvUsers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
End Class
