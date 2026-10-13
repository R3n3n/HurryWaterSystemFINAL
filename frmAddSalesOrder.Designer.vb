<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSalesOrder
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
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPickupStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpOrderDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLineTotal3 = New System.Windows.Forms.Label()
        Me.lblLineTotal2 = New System.Windows.Forms.Label()
        Me.nudUnitPrice3 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nudUnitPrice2 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nudQuantity3 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nudQuantity2 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.lblLineTotal1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudUnitPrice1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudQuantity1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboProduct3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboProduct2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboProduct1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPaymentMode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboPaymentStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.nudUnitPrice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnitPrice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnitPrice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblCustomers.Location = New System.Drawing.Point(18, 26)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(516, 54)
        Me.lblCustomers.TabIndex = 12
        Me.lblCustomers.Text = "Add New Sales / Delivery"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Record a pickup or delivery transaction"
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
        Me.cboPickupStatus.Items.AddRange(New Object() {"Pending", "Picked-up", "Delivered"})
        Me.cboPickupStatus.Location = New System.Drawing.Point(585, 173)
        Me.cboPickupStatus.Name = "cboPickupStatus"
        Me.cboPickupStatus.Size = New System.Drawing.Size(195, 50)
        Me.cboPickupStatus.TabIndex = 15
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.BorderRadius = 18
        Me.dtpOrderDate.Checked = True
        Me.dtpOrderDate.FillColor = System.Drawing.Color.White
        Me.dtpOrderDate.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(369, 173)
        Me.dtpOrderDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpOrderDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(195, 53)
        Me.dtpOrderDate.TabIndex = 16
        Me.dtpOrderDate.Value = New Date(2026, 9, 27, 15, 5, 9, 282)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 32)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(363, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 32)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Order Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(580, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 32)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Pickup Status"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 18
        Me.Guna2Panel1.Controls.Add(Me.lblLineTotal3)
        Me.Guna2Panel1.Controls.Add(Me.lblLineTotal2)
        Me.Guna2Panel1.Controls.Add(Me.nudUnitPrice3)
        Me.Guna2Panel1.Controls.Add(Me.nudUnitPrice2)
        Me.Guna2Panel1.Controls.Add(Me.nudQuantity3)
        Me.Guna2Panel1.Controls.Add(Me.nudQuantity2)
        Me.Guna2Panel1.Controls.Add(Me.lblLineTotal1)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.nudUnitPrice1)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.nudQuantity1)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.cboProduct3)
        Me.Guna2Panel1.Controls.Add(Me.cboProduct2)
        Me.Guna2Panel1.Controls.Add(Me.cboProduct1)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(28, 263)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(752, 275)
        Me.Guna2Panel1.TabIndex = 20
        '
        'lblLineTotal3
        '
        Me.lblLineTotal3.AutoSize = True
        Me.lblLineTotal3.BackColor = System.Drawing.Color.Transparent
        Me.lblLineTotal3.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineTotal3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblLineTotal3.Location = New System.Drawing.Point(578, 202)
        Me.lblLineTotal3.Name = "lblLineTotal3"
        Me.lblLineTotal3.Size = New System.Drawing.Size(41, 32)
        Me.lblLineTotal3.TabIndex = 34
        Me.lblLineTotal3.Text = "₱0"
        '
        'lblLineTotal2
        '
        Me.lblLineTotal2.AutoSize = True
        Me.lblLineTotal2.BackColor = System.Drawing.Color.Transparent
        Me.lblLineTotal2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineTotal2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblLineTotal2.Location = New System.Drawing.Point(578, 139)
        Me.lblLineTotal2.Name = "lblLineTotal2"
        Me.lblLineTotal2.Size = New System.Drawing.Size(41, 32)
        Me.lblLineTotal2.TabIndex = 33
        Me.lblLineTotal2.Text = "₱0"
        '
        'nudUnitPrice3
        '
        Me.nudUnitPrice3.BackColor = System.Drawing.Color.Transparent
        Me.nudUnitPrice3.BorderRadius = 18
        Me.nudUnitPrice3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudUnitPrice3.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.nudUnitPrice3.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.nudUnitPrice3.Location = New System.Drawing.Point(417, 192)
        Me.nudUnitPrice3.Name = "nudUnitPrice3"
        Me.nudUnitPrice3.Size = New System.Drawing.Size(123, 53)
        Me.nudUnitPrice3.TabIndex = 32
        Me.nudUnitPrice3.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudUnitPrice3.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'nudUnitPrice2
        '
        Me.nudUnitPrice2.BackColor = System.Drawing.Color.Transparent
        Me.nudUnitPrice2.BorderRadius = 18
        Me.nudUnitPrice2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudUnitPrice2.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.nudUnitPrice2.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.nudUnitPrice2.Location = New System.Drawing.Point(417, 130)
        Me.nudUnitPrice2.Name = "nudUnitPrice2"
        Me.nudUnitPrice2.Size = New System.Drawing.Size(123, 53)
        Me.nudUnitPrice2.TabIndex = 31
        Me.nudUnitPrice2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudUnitPrice2.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'nudQuantity3
        '
        Me.nudQuantity3.BackColor = System.Drawing.Color.Transparent
        Me.nudQuantity3.BorderRadius = 18
        Me.nudQuantity3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudQuantity3.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.nudQuantity3.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.nudQuantity3.Location = New System.Drawing.Point(282, 192)
        Me.nudQuantity3.Name = "nudQuantity3"
        Me.nudQuantity3.Size = New System.Drawing.Size(107, 53)
        Me.nudQuantity3.TabIndex = 30
        Me.nudQuantity3.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudQuantity3.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'nudQuantity2
        '
        Me.nudQuantity2.BackColor = System.Drawing.Color.Transparent
        Me.nudQuantity2.BorderRadius = 18
        Me.nudQuantity2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudQuantity2.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.nudQuantity2.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.nudQuantity2.Location = New System.Drawing.Point(282, 130)
        Me.nudQuantity2.Name = "nudQuantity2"
        Me.nudQuantity2.Size = New System.Drawing.Size(107, 53)
        Me.nudQuantity2.TabIndex = 29
        Me.nudQuantity2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudQuantity2.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'lblLineTotal1
        '
        Me.lblLineTotal1.AutoSize = True
        Me.lblLineTotal1.BackColor = System.Drawing.Color.Transparent
        Me.lblLineTotal1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineTotal1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblLineTotal1.Location = New System.Drawing.Point(578, 76)
        Me.lblLineTotal1.Name = "lblLineTotal1"
        Me.lblLineTotal1.Size = New System.Drawing.Size(41, 32)
        Me.lblLineTotal1.TabIndex = 21
        Me.lblLineTotal1.Text = "₱0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(578, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 32)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "LINE TOTAL"
        '
        'nudUnitPrice1
        '
        Me.nudUnitPrice1.BackColor = System.Drawing.Color.Transparent
        Me.nudUnitPrice1.BorderRadius = 18
        Me.nudUnitPrice1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudUnitPrice1.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.nudUnitPrice1.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.nudUnitPrice1.Location = New System.Drawing.Point(417, 69)
        Me.nudUnitPrice1.Name = "nudUnitPrice1"
        Me.nudUnitPrice1.Size = New System.Drawing.Size(123, 53)
        Me.nudUnitPrice1.TabIndex = 27
        Me.nudUnitPrice1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudUnitPrice1.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(411, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 32)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "UNIT PRICE"
        '
        'nudQuantity1
        '
        Me.nudQuantity1.BackColor = System.Drawing.Color.Transparent
        Me.nudQuantity1.BorderRadius = 18
        Me.nudQuantity1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudQuantity1.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.nudQuantity1.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.nudQuantity1.Location = New System.Drawing.Point(282, 69)
        Me.nudQuantity1.Name = "nudQuantity1"
        Me.nudQuantity1.Size = New System.Drawing.Size(107, 53)
        Me.nudQuantity1.TabIndex = 25
        Me.nudQuantity1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.nudQuantity1.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(303, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 32)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "QTY"
        '
        'cboProduct3
        '
        Me.cboProduct3.BackColor = System.Drawing.Color.Transparent
        Me.cboProduct3.BorderRadius = 18
        Me.cboProduct3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProduct3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct3.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cboProduct3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProduct3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProduct3.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboProduct3.ForeColor = System.Drawing.Color.Black
        Me.cboProduct3.ItemHeight = 44
        Me.cboProduct3.Items.AddRange(New Object() {"Household", "Company"})
        Me.cboProduct3.Location = New System.Drawing.Point(26, 192)
        Me.cboProduct3.Name = "cboProduct3"
        Me.cboProduct3.Size = New System.Drawing.Size(230, 50)
        Me.cboProduct3.TabIndex = 23
        '
        'cboProduct2
        '
        Me.cboProduct2.BackColor = System.Drawing.Color.Transparent
        Me.cboProduct2.BorderRadius = 18
        Me.cboProduct2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct2.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cboProduct2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProduct2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProduct2.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboProduct2.ForeColor = System.Drawing.Color.Black
        Me.cboProduct2.ItemHeight = 44
        Me.cboProduct2.Items.AddRange(New Object() {"Household", "Company"})
        Me.cboProduct2.Location = New System.Drawing.Point(26, 130)
        Me.cboProduct2.Name = "cboProduct2"
        Me.cboProduct2.Size = New System.Drawing.Size(230, 50)
        Me.cboProduct2.TabIndex = 22
        '
        'cboProduct1
        '
        Me.cboProduct1.BackColor = System.Drawing.Color.Transparent
        Me.cboProduct1.BorderRadius = 18
        Me.cboProduct1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct1.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cboProduct1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProduct1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProduct1.Font = New System.Drawing.Font("Segoe UI", 14.75!)
        Me.cboProduct1.ForeColor = System.Drawing.Color.Black
        Me.cboProduct1.ItemHeight = 44
        Me.cboProduct1.Items.AddRange(New Object() {"Household", "Company"})
        Me.cboProduct1.Location = New System.Drawing.Point(26, 69)
        Me.cboProduct1.Name = "cboProduct1"
        Me.cboProduct1.Size = New System.Drawing.Size(230, 50)
        Me.cboProduct1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(59, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 32)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "PRODUCT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(22, 572)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 32)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Payment Mode"
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
        Me.cboPaymentMode.Location = New System.Drawing.Point(28, 607)
        Me.cboPaymentMode.Name = "cboPaymentMode"
        Me.cboPaymentMode.Size = New System.Drawing.Size(195, 50)
        Me.cboPaymentMode.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(247, 572)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 32)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Payment Status"
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
        Me.cboPaymentStatus.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.cboPaymentStatus.Location = New System.Drawing.Point(253, 607)
        Me.cboPaymentStatus.Name = "cboPaymentStatus"
        Me.cboPaymentStatus.Size = New System.Drawing.Size(195, 50)
        Me.cboPaymentStatus.TabIndex = 23
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
        Me.btnCancel.Location = New System.Drawing.Point(417, 695)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(177, 54)
        Me.btnCancel.TabIndex = 26
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
        Me.btnSave.Location = New System.Drawing.Point(603, 695)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(177, 54)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save Order"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 18
        Me.Guna2Panel2.Controls.Add(Me.lblTotal)
        Me.Guna2Panel2.Controls.Add(Me.Label14)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(486, 558)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(294, 102)
        Me.Guna2Panel2.TabIndex = 27
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(199, 54)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(41, 32)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "₱0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(199, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 32)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "TOTAL"
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'txtCustomer
        '
        Me.txtCustomer.BorderRadius = 18
        Me.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomer.DefaultText = ""
        Me.txtCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomer.Location = New System.Drawing.Point(27, 175)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.PlaceholderText = ""
        Me.txtCustomer.SelectedText = ""
        Me.txtCustomer.Size = New System.Drawing.Size(315, 53)
        Me.txtCustomer.TabIndex = 68
        '
        'frmAddSalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(817, 790)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboPaymentStatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboPaymentMode)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpOrderDate)
        Me.Controls.Add(Me.cboPickupStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmAddSalesOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddSalesOrder"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.nudUnitPrice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnitPrice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnitPrice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomers As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPickupStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpOrderDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cboProduct3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboProduct2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboProduct1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblLineTotal1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudUnitPrice1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudQuantity1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudQuantity2 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents lblLineTotal3 As Label
    Friend WithEvents lblLineTotal2 As Label
    Friend WithEvents nudUnitPrice3 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudUnitPrice2 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nudQuantity3 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents cboPaymentMode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboPaymentStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents errorProvider1 As ErrorProvider
    Friend WithEvents txtCustomer As Guna.UI2.WinForms.Guna2TextBox
End Class
