<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDispenserBorrowing
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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnAddBorrow = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnMarkReturned = New Guna.UI2.WinForms.Guna2Button()
        Me.lsvBorrowing = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 51.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(38, 40)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(714, 106)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Dispenser Borrowing"
        '
        'btnAddBorrow
        '
        Me.btnAddBorrow.BorderRadius = 20
        Me.btnAddBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddBorrow.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddBorrow.FillColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnAddBorrow.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnAddBorrow.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBorrow.ForeColor = System.Drawing.Color.White
        Me.btnAddBorrow.Location = New System.Drawing.Point(1150, 50)
        Me.btnAddBorrow.Name = "btnAddBorrow"
        Me.btnAddBorrow.Size = New System.Drawing.Size(351, 96)
        Me.btnAddBorrow.TabIndex = 32
        Me.btnAddBorrow.Text = "+ New Borrow Record"
        '
        'btnMarkReturned
        '
        Me.btnMarkReturned.BorderRadius = 20
        Me.btnMarkReturned.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMarkReturned.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMarkReturned.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMarkReturned.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMarkReturned.FillColor = System.Drawing.Color.White
        Me.btnMarkReturned.Font = New System.Drawing.Font("Segoe UI", 20.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkReturned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnMarkReturned.Location = New System.Drawing.Point(874, 50)
        Me.btnMarkReturned.Name = "btnMarkReturned"
        Me.btnMarkReturned.Size = New System.Drawing.Size(253, 96)
        Me.btnMarkReturned.TabIndex = 33
        Me.btnMarkReturned.Text = "Mark Returned"
        '
        'lsvBorrowing
        '
        Me.lsvBorrowing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvBorrowing.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvBorrowing.HideSelection = False
        Me.lsvBorrowing.Location = New System.Drawing.Point(38, 184)
        Me.lsvBorrowing.Name = "lsvBorrowing"
        Me.lsvBorrowing.Size = New System.Drawing.Size(1463, 849)
        Me.lsvBorrowing.TabIndex = 58
        Me.lsvBorrowing.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'frmDispenserBorrowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1535, 1082)
        Me.Controls.Add(Me.lsvBorrowing)
        Me.Controls.Add(Me.btnMarkReturned)
        Me.Controls.Add(Me.btnAddBorrow)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "frmDispenserBorrowing"
        Me.Text = "frmDispenserBorrowing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAddBorrow As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMarkReturned As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lsvBorrowing As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
