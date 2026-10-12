<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.btnStockIn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStockOut = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lsvInventory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblSalesDelivery
        '
        Me.lblSalesDelivery.AutoSize = True
        Me.lblSalesDelivery.Font = New System.Drawing.Font("Segoe UI Black", 58.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSalesDelivery.Location = New System.Drawing.Point(35, 41)
        Me.lblSalesDelivery.Name = "lblSalesDelivery"
        Me.lblSalesDelivery.Size = New System.Drawing.Size(416, 118)
        Me.lblSalesDelivery.TabIndex = 15
        Me.lblSalesDelivery.Text = "Inventory"
        '
        'btnStockIn
        '
        Me.btnStockIn.BorderRadius = 20
        Me.btnStockIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStockIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStockIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStockIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStockIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStockIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnStockIn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnStockIn.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockIn.ForeColor = System.Drawing.Color.White
        Me.btnStockIn.Location = New System.Drawing.Point(956, 63)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(231, 96)
        Me.btnStockIn.TabIndex = 30
        Me.btnStockIn.Text = "↓ Stock In"
        '
        'btnStockOut
        '
        Me.btnStockOut.BorderRadius = 20
        Me.btnStockOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStockOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStockOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStockOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStockOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStockOut.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnStockOut.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnStockOut.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOut.ForeColor = System.Drawing.Color.White
        Me.btnStockOut.Location = New System.Drawing.Point(1228, 63)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(231, 96)
        Me.btnStockOut.TabIndex = 31
        Me.btnStockOut.Text = "↑ Stock Out"
        '
        'lsvInventory
        '
        Me.lsvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvInventory.HideSelection = False
        Me.lsvInventory.Location = New System.Drawing.Point(53, 196)
        Me.lsvInventory.Name = "lsvInventory"
        Me.lsvInventory.Size = New System.Drawing.Size(1406, 836)
        Me.lsvInventory.TabIndex = 32
        Me.lsvInventory.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1082)
        Me.Controls.Add(Me.lsvInventory)
        Me.Controls.Add(Me.btnStockOut)
        Me.Controls.Add(Me.btnStockIn)
        Me.Controls.Add(Me.lblSalesDelivery)
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalesDelivery As Label
    Friend WithEvents btnStockIn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStockOut As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lsvInventory As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
