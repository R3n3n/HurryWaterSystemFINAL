<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Me.lblSetupTitle = New System.Windows.Forms.Label()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnTabProducts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTabItems = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTabSuppliers = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lsvData = New System.Windows.Forms.ListView()
        Me.btnExportData = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'lblSetupTitle
        '
        Me.lblSetupTitle.AutoSize = True
        Me.lblSetupTitle.Font = New System.Drawing.Font("Segoe UI Black", 58.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetupTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSetupTitle.Location = New System.Drawing.Point(38, 45)
        Me.lblSetupTitle.Name = "lblSetupTitle"
        Me.lblSetupTitle.Size = New System.Drawing.Size(664, 104)
        Me.lblSetupTitle.TabIndex = 0
        Me.lblSetupTitle.Text = "Product Catalog"
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 20
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(849, 53)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(195, 96)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 20
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(1066, 53)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(195, 96)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.BorderRadius = 20
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(1286, 53)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(195, 96)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "+ Add"
        '
        'btnTabProducts
        '
        Me.btnTabProducts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnTabProducts.BorderRadius = 20
        Me.btnTabProducts.BorderThickness = 1
        Me.btnTabProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTabProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTabProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTabProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTabProducts.FillColor = System.Drawing.Color.White
        Me.btnTabProducts.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnTabProducts.Location = New System.Drawing.Point(56, 190)
        Me.btnTabProducts.Name = "btnTabProducts"
        Me.btnTabProducts.Size = New System.Drawing.Size(360, 70)
        Me.btnTabProducts.TabIndex = 4
        Me.btnTabProducts.Text = "Products"
        '
        'btnTabItems
        '
        Me.btnTabItems.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnTabItems.BorderRadius = 20
        Me.btnTabItems.BorderThickness = 1
        Me.btnTabItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTabItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTabItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTabItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTabItems.FillColor = System.Drawing.Color.White
        Me.btnTabItems.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnTabItems.Location = New System.Drawing.Point(436, 190)
        Me.btnTabItems.Name = "btnTabItems"
        Me.btnTabItems.Size = New System.Drawing.Size(360, 70)
        Me.btnTabItems.TabIndex = 5
        Me.btnTabItems.Text = "Inventory Items"
        '
        'btnTabSuppliers
        '
        Me.btnTabSuppliers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnTabSuppliers.BorderRadius = 20
        Me.btnTabSuppliers.BorderThickness = 1
        Me.btnTabSuppliers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTabSuppliers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTabSuppliers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTabSuppliers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTabSuppliers.FillColor = System.Drawing.Color.White
        Me.btnTabSuppliers.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabSuppliers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnTabSuppliers.Location = New System.Drawing.Point(816, 190)
        Me.btnTabSuppliers.Name = "btnTabSuppliers"
        Me.btnTabSuppliers.Size = New System.Drawing.Size(360, 70)
        Me.btnTabSuppliers.TabIndex = 6
        Me.btnTabSuppliers.Text = "Suppliers"
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.Gray
        Me.lblHint.Location = New System.Drawing.Point(60, 275)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(0, 25)
        Me.lblHint.TabIndex = 7
        '
        'lsvData
        '
        Me.lsvData.Font = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvData.HideSelection = False
        Me.lsvData.Location = New System.Drawing.Point(56, 320)
        Me.lsvData.Name = "lsvData"
        Me.lsvData.Size = New System.Drawing.Size(1425, 624)
        Me.lsvData.TabIndex = 8
        Me.lsvData.UseCompatibleStateImageBehavior = False
        '
        'btnExportData
        '
        Me.btnExportData.BorderRadius = 20
        Me.btnExportData.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExportData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExportData.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportData.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExportData.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnExportData.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnExportData.Font = New System.Drawing.Font("Segoe UI", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportData.ForeColor = System.Drawing.Color.White
        Me.btnExportData.Location = New System.Drawing.Point(1261, 969)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(220, 66)
        Me.btnExportData.TabIndex = 90
        Me.btnExportData.Text = "Export"
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1061)
        Me.Controls.Add(Me.lsvData)
        Me.Controls.Add(Me.btnExportData)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.btnTabSuppliers)
        Me.Controls.Add(Me.btnTabItems)
        Me.Controls.Add(Me.btnTabProducts)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblSetupTitle)
        Me.Name = "frmSetup"
        Me.Text = "frmSetup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSetupTitle As Label
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnTabProducts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTabItems As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTabSuppliers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblHint As Label
    Friend WithEvents lsvData As ListView
    Friend WithEvents btnExportData As Guna.UI2.WinForms.Guna2GradientButton
End Class
