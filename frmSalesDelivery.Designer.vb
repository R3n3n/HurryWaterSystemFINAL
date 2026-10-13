<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesDelivery
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
        Me.btnAddOrder = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cboFilterPickup = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboFilterPayment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lsvOrders = New System.Windows.Forms.ListView()
        Me.btnUpdateStatus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteOrder = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cboFilterWeek = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'lblSalesDelivery
        '
        Me.lblSalesDelivery.AutoSize = True
        Me.lblSalesDelivery.Font = New System.Drawing.Font("Segoe UI Black", 58.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSalesDelivery.Location = New System.Drawing.Point(38, 32)
        Me.lblSalesDelivery.Name = "lblSalesDelivery"
        Me.lblSalesDelivery.Size = New System.Drawing.Size(641, 104)
        Me.lblSalesDelivery.TabIndex = 13
        Me.lblSalesDelivery.Text = "Sales / Delivery"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(56, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 47)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "# orders this week"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BorderRadius = 23
        Me.btnAddOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnAddOrder.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnAddOrder.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(1240, 70)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(234, 118)
        Me.btnAddOrder.TabIndex = 16
        Me.btnAddOrder.Text = "+ Add Order"
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(56, 251)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(487, 60)
        Me.txtSearch.TabIndex = 17
        '
        'cboFilterPickup
        '
        Me.cboFilterPickup.BackColor = System.Drawing.Color.Transparent
        Me.cboFilterPickup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilterPickup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterPickup.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterPickup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterPickup.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboFilterPickup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboFilterPickup.ItemHeight = 50
        Me.cboFilterPickup.Items.AddRange(New Object() {"Pending", "Picked-up", "Delivered"})
        Me.cboFilterPickup.Location = New System.Drawing.Point(892, 251)
        Me.cboFilterPickup.Name = "cboFilterPickup"
        Me.cboFilterPickup.Size = New System.Drawing.Size(274, 56)
        Me.cboFilterPickup.TabIndex = 18
        '
        'cboFilterPayment
        '
        Me.cboFilterPayment.BackColor = System.Drawing.Color.Transparent
        Me.cboFilterPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilterPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterPayment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterPayment.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboFilterPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboFilterPayment.ItemHeight = 50
        Me.cboFilterPayment.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cboFilterPayment.Location = New System.Drawing.Point(1202, 251)
        Me.cboFilterPayment.Name = "cboFilterPayment"
        Me.cboFilterPayment.Size = New System.Drawing.Size(273, 56)
        Me.cboFilterPayment.TabIndex = 19
        '
        'lsvOrders
        '
        Me.lsvOrders.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvOrders.HideSelection = False
        Me.lsvOrders.Location = New System.Drawing.Point(56, 342)
        Me.lsvOrders.Name = "lsvOrders"
        Me.lsvOrders.Size = New System.Drawing.Size(1420, 677)
        Me.lsvOrders.TabIndex = 20
        Me.lsvOrders.UseCompatibleStateImageBehavior = False
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnUpdateStatus.BorderRadius = 20
        Me.btnUpdateStatus.BorderThickness = 1
        Me.btnUpdateStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateStatus.FillColor = System.Drawing.Color.White
        Me.btnUpdateStatus.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnUpdateStatus.Location = New System.Drawing.Point(981, 70)
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(234, 118)
        Me.btnUpdateStatus.TabIndex = 34
        Me.btnUpdateStatus.Text = "Update Status"
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BorderRadius = 20
        Me.btnDeleteOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteOrder.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(722, 70)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(234, 118)
        Me.btnDeleteOrder.TabIndex = 20
        Me.btnDeleteOrder.Text = "Delete"
        '
        'cboFilterWeek
        '
        Me.cboFilterWeek.BackColor = System.Drawing.Color.Transparent
        Me.cboFilterWeek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilterWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterWeek.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterWeek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterWeek.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboFilterWeek.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboFilterWeek.ItemHeight = 50
        Me.cboFilterWeek.Items.AddRange(New Object() {"Pending", "Picked-up", "Delivered"})
        Me.cboFilterWeek.Location = New System.Drawing.Point(585, 251)
        Me.cboFilterWeek.Name = "cboFilterWeek"
        Me.cboFilterWeek.Size = New System.Drawing.Size(274, 56)
        Me.cboFilterWeek.TabIndex = 35
        '
        'frmSalesDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1061)
        Me.Controls.Add(Me.cboFilterWeek)
        Me.Controls.Add(Me.btnDeleteOrder)
        Me.Controls.Add(Me.btnUpdateStatus)
        Me.Controls.Add(Me.lsvOrders)
        Me.Controls.Add(Me.cboFilterPayment)
        Me.Controls.Add(Me.cboFilterPickup)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSalesDelivery)
        Me.Name = "frmSalesDelivery"
        Me.Text = "frmSalesDelivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalesDelivery As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddOrder As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cboFilterPickup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboFilterPayment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lsvOrders As ListView
    Friend WithEvents btnUpdateStatus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteOrder As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cboFilterWeek As Guna.UI2.WinForms.Guna2ComboBox
End Class
