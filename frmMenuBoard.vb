Public Class frmMenuBoard

    Private Sub frmMenuBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyRoleRestrictions()
        ShowLoggedInUser()
        LoadFormInPanel(New frmDashboard())
        SetActiveButton(btnDashboard)
    End Sub

    Private Sub ShowLoggedInUser()
        lblUsername.Text = CurrentUsername
        ' keep the name centered in the sidebar header, whatever its length
        lblUsername.Left = Math.Max(0, (Guna2Panel1.Width - lblUsername.Width) \ 2)
    End Sub

    Private Sub ApplyRoleRestrictions()
        Dim isOwner As Boolean = (CurrentUserRole = "Owner")
        btnUsers.Visible = isOwner
        btnReports.Visible = isOwner
        btnExpenses.Visible = isOwner ' System Reports: owner only
        btnSetup.Visible = isOwner    ' products/prices, inventory items, suppliers: owner only
    End Sub

    Private ReadOnly activeColor As Color = Color.FromArgb(70, 104, 178)

    Private Function SidebarButtons() As Guna.UI2.WinForms.Guna2Button()
        Return {btnDashboard, btnCustomers, btnSalesDelivery, btnProduction, btnProductionHistory,
                btnInventory, btnExpenses, btnDispenserBorrowing, btnReports, btnUsers, btnSetup}
    End Function

    Private Sub SetActiveButton(active As Guna.UI2.WinForms.Guna2Button)
        For Each b In SidebarButtons()
            b.FillColor = If(b Is active, activeColor, Color.Transparent)
        Next
    End Sub

    Private Sub LoadFormInPanel(ByVal childForm As Form)
        SplitContainer1.Panel2.SuspendLayout()

        SplitContainer1.Panel2.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(childForm)
        SplitContainer1.Panel2.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

        SplitContainer1.Panel2.ResumeLayout()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        LoadFormInPanel(New frmCustomers())
        SetActiveButton(btnCustomers)
    End Sub

    Private Sub btnSalesDelivery_Click(sender As Object, e As EventArgs) Handles btnSalesDelivery.Click
        LoadFormInPanel(New frmSalesDelivery())
        SetActiveButton(btnSalesDelivery)
    End Sub

    Private Sub btnProduction_Click(sender As Object, e As EventArgs) Handles btnProduction.Click
        LoadFormInPanel(New frmProduction())
        SetActiveButton(btnProduction)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        LoadFormInPanel(New frmInventory())
        SetActiveButton(btnInventory)
    End Sub

    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        LoadFormInPanel(New frmExpenses())
        SetActiveButton(btnExpenses)
    End Sub

    Private Sub btnDispenserBorrowing_Click(sender As Object, e As EventArgs) Handles btnDispenserBorrowing.Click
        LoadFormInPanel(New frmDispenserBorrowing())
        SetActiveButton(btnDispenserBorrowing)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        LoadFormInPanel(New frmReports())
        SetActiveButton(btnReports)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        LoadFormInPanel(New frmUsers())
        SetActiveButton(btnUsers)
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        LoadFormInPanel(New frmSetup())
        SetActiveButton(btnSetup)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As MsgBoxResult
        result = MsgBox("Do you want to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Logout")

        If result = MsgBoxResult.Yes Then
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()

            CurrentUserId = 0
            CurrentUserRole = ""
            CurrentUsername = ""
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadFormInPanel(New frmDashboard())
        SetActiveButton(btnDashboard)
    End Sub

    Private Sub btnProductionHistory_Click(sender As Object, e As EventArgs) Handles btnProductionHistory.Click
        LoadFormInPanel(New frmProductionHistory())
        SetActiveButton(btnProductionHistory)
    End Sub
End Class