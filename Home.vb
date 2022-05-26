Public Class Home
    Private Sub FoodMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FoodMenuToolStripMenuItem.Click
        SwitchPanel(Food_Menu)
    End Sub

    Sub SwitchPanel(ByVal Panel As Form)
        pnlHome.Controls.Clear()
        Panel.TopLevel = False
        pnlHome.Controls.Add(Panel)
        Panel.Show()
    End Sub

    Private Sub EmployeeManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeManagementToolStripMenuItem.Click
        SwitchPanel(Employee_Management)
    End Sub

    Private Sub ViewMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMenuToolStripMenuItem.Click
        SwitchPanel(View_Menu)
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        SwitchPanel(Sales_Report)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        SwitchPanel(About)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub PladeOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PladeOrdersToolStripMenuItem.Click
        SwitchPanel(Place_Orders)
    End Sub
End Class