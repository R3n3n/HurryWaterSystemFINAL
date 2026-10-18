<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblSalesDelivery = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUnpaidBalance = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExportCsv = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cboDateRange = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.chtSalesTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lsvLowStock = New System.Windows.Forms.ListView()
        Me.btnExportLowStock = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lsvCustomerSummary = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAnnualReport = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.chtSalesTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSalesDelivery
        '
        Me.lblSalesDelivery.AutoSize = True
        Me.lblSalesDelivery.Font = New System.Drawing.Font("Segoe UI Black", 58.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblSalesDelivery.Location = New System.Drawing.Point(28, 51)
        Me.lblSalesDelivery.Name = "lblSalesDelivery"
        Me.lblSalesDelivery.Size = New System.Drawing.Size(345, 104)
        Me.lblSalesDelivery.TabIndex = 18
        Me.lblSalesDelivery.Text = "Reports"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 18
        Me.Guna2GradientPanel1.Controls.Add(Me.lblNet)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.LimeGreen
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(1158, 204)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(320, 178)
        Me.Guna2GradientPanel1.TabIndex = 38
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.BackColor = System.Drawing.Color.Transparent
        Me.lblNet.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.White
        Me.lblNet.Location = New System.Drawing.Point(29, 81)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(47, 54)
        Me.lblNet.TabIndex = 38
        Me.lblNet.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 32)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "NET (PAID)"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 18
        Me.Guna2Panel3.Controls.Add(Me.lblTotalExpenses)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(786, 204)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel3.TabIndex = 36
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblTotalExpenses.Location = New System.Drawing.Point(25, 81)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(47, 54)
        Me.lblTotalExpenses.TabIndex = 37
        Me.lblTotalExpenses.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(29, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 32)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "TOTAL EXPENSES"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 18
        Me.Guna2Panel2.Controls.Add(Me.lblUnpaidBalance)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(416, 204)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel2.TabIndex = 37
        '
        'lblUnpaidBalance
        '
        Me.lblUnpaidBalance.AutoSize = True
        Me.lblUnpaidBalance.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnpaidBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblUnpaidBalance.Location = New System.Drawing.Point(20, 81)
        Me.lblUnpaidBalance.Name = "lblUnpaidBalance"
        Me.lblUnpaidBalance.Size = New System.Drawing.Size(47, 54)
        Me.lblUnpaidBalance.TabIndex = 36
        Me.lblUnpaidBalance.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 32)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "UNPAID BALANCE"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 18
        Me.Guna2Panel1.Controls.Add(Me.lblTotalSales)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(53, 204)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(320, 178)
        Me.Guna2Panel1.TabIndex = 35
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Segoe UI Black", 29.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblTotalSales.Location = New System.Drawing.Point(20, 81)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(47, 54)
        Me.lblTotalSales.TabIndex = 35
        Me.lblTotalSales.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(25, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 32)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "TOTAL SALES"
        '
        'btnExportCsv
        '
        Me.btnExportCsv.BorderRadius = 20
        Me.btnExportCsv.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExportCsv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExportCsv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportCsv.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportCsv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExportCsv.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnExportCsv.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnExportCsv.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportCsv.ForeColor = System.Drawing.Color.White
        Me.btnExportCsv.Location = New System.Drawing.Point(1259, 70)
        Me.btnExportCsv.Name = "btnExportCsv"
        Me.btnExportCsv.Size = New System.Drawing.Size(220, 75)
        Me.btnExportCsv.TabIndex = 39
        Me.btnExportCsv.Text = "Export"
        '
        'cboDateRange
        '
        Me.cboDateRange.BackColor = System.Drawing.Color.Transparent
        Me.cboDateRange.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateRange.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDateRange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDateRange.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboDateRange.ItemHeight = 50
        Me.cboDateRange.Location = New System.Drawing.Point(585, 82)
        Me.cboDateRange.Name = "cboDateRange"
        Me.cboDateRange.Size = New System.Drawing.Size(287, 56)
        Me.cboDateRange.TabIndex = 40
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 18
        Me.Guna2Panel4.Controls.Add(Me.chtSalesTrend)
        Me.Guna2Panel4.Controls.Add(Me.Label6)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(53, 428)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(745, 304)
        Me.Guna2Panel4.TabIndex = 38
        '
        'chtSalesTrend
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtSalesTrend.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtSalesTrend.Legends.Add(Legend1)
        Me.chtSalesTrend.Location = New System.Drawing.Point(35, 68)
        Me.chtSalesTrend.Name = "chtSalesTrend"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Me.chtSalesTrend.Series.Add(Series1)
        Me.chtSalesTrend.Size = New System.Drawing.Size(669, 201)
        Me.chtSalesTrend.TabIndex = 36
        Me.chtSalesTrend.Text = "Chart1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(29, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 32)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "SALES TREND"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderRadius = 18
        Me.Guna2Panel5.Controls.Add(Me.lsvLowStock)
        Me.Guna2Panel5.Controls.Add(Me.btnExportLowStock)
        Me.Guna2Panel5.Controls.Add(Me.Label5)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(833, 428)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(645, 304)
        Me.Guna2Panel5.TabIndex = 39
        '
        'btnExportLowStock
        '
        Me.btnExportLowStock.BorderRadius = 16
        Me.btnExportLowStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExportLowStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExportLowStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportLowStock.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportLowStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExportLowStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnExportLowStock.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnExportLowStock.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportLowStock.ForeColor = System.Drawing.Color.White
        Me.btnExportLowStock.Location = New System.Drawing.Point(419, 14)
        Me.btnExportLowStock.Name = "btnExportLowStock"
        Me.btnExportLowStock.Size = New System.Drawing.Size(190, 50)
        Me.btnExportLowStock.TabIndex = 90
        Me.btnExportLowStock.Text = "Export"
        '
        'lsvLowStock
        '
        Me.lsvLowStock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lsvLowStock.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLowStock.HideSelection = False
        Me.lsvLowStock.Location = New System.Drawing.Point(35, 86)
        Me.lsvLowStock.Name = "lsvLowStock"
        Me.lsvLowStock.Size = New System.Drawing.Size(574, 182)
        Me.lsvLowStock.TabIndex = 61
        Me.lsvLowStock.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 32)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "LOW-STOCK ITEMS"
        '
        'lsvCustomerSummary
        '
        Me.lsvCustomerSummary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvCustomerSummary.Font = New System.Drawing.Font("Segoe UI Semibold", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvCustomerSummary.HideSelection = False
        Me.lsvCustomerSummary.Location = New System.Drawing.Point(53, 773)
        Me.lsvCustomerSummary.Name = "lsvCustomerSummary"
        Me.lsvCustomerSummary.Size = New System.Drawing.Size(1425, 254)
        Me.lsvCustomerSummary.TabIndex = 60
        Me.lsvCustomerSummary.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'btnAnnualReport
        '
        Me.btnAnnualReport.BorderRadius = 20
        Me.btnAnnualReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAnnualReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAnnualReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAnnualReport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAnnualReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAnnualReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnAnnualReport.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnAnnualReport.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnualReport.ForeColor = System.Drawing.Color.White
        Me.btnAnnualReport.Location = New System.Drawing.Point(897, 70)
        Me.btnAnnualReport.Name = "btnAnnualReport"
        Me.btnAnnualReport.Size = New System.Drawing.Size(340, 75)
        Me.btnAnnualReport.TabIndex = 60
        Me.btnAnnualReport.Text = "Monthly / Annual"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1061)
        Me.Controls.Add(Me.btnAnnualReport)
        Me.Controls.Add(Me.lsvCustomerSummary)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.cboDateRange)
        Me.Controls.Add(Me.btnExportCsv)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.lblSalesDelivery)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.chtSalesTrend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalesDelivery As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblNet As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblUnpaidBalance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExportCsv As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cboDateRange As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents chtSalesTrend As DataVisualization.Charting.Chart
    Friend WithEvents lsvCustomerSummary As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lsvLowStock As ListView
    Friend WithEvents btnExportLowStock As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnAnnualReport As Guna.UI2.WinForms.Guna2GradientButton
End Class
