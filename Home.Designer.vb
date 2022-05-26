<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PladeOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Maroon
        Me.MenuStrip1.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.FoodMenuToolStripMenuItem, Me.ViewMenuToolStripMenuItem, Me.PladeOrdersToolStripMenuItem, Me.SalesReportToolStripMenuItem, Me.EmployeeManagementToolStripMenuItem, Me.AboutToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 5, 5, 10)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1368, 51)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(94, 36)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'FoodMenuToolStripMenuItem
        '
        Me.FoodMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FoodMenuToolStripMenuItem.Name = "FoodMenuToolStripMenuItem"
        Me.FoodMenuToolStripMenuItem.Size = New System.Drawing.Size(151, 36)
        Me.FoodMenuToolStripMenuItem.Text = "Food Menu"
        '
        'ViewMenuToolStripMenuItem
        '
        Me.ViewMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewMenuToolStripMenuItem.Name = "ViewMenuToolStripMenuItem"
        Me.ViewMenuToolStripMenuItem.Size = New System.Drawing.Size(150, 36)
        Me.ViewMenuToolStripMenuItem.Text = "View Menu"
        '
        'PladeOrdersToolStripMenuItem
        '
        Me.PladeOrdersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PladeOrdersToolStripMenuItem.Name = "PladeOrdersToolStripMenuItem"
        Me.PladeOrdersToolStripMenuItem.Size = New System.Drawing.Size(168, 36)
        Me.PladeOrdersToolStripMenuItem.Text = "Plade Orders"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(164, 36)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'EmployeeManagementToolStripMenuItem
        '
        Me.EmployeeManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EmployeeManagementToolStripMenuItem.Name = "EmployeeManagementToolStripMenuItem"
        Me.EmployeeManagementToolStripMenuItem.Size = New System.Drawing.Size(286, 36)
        Me.EmployeeManagementToolStripMenuItem.Text = "Employee Management"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(95, 36)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(112, 36)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'pnlHome
        '
        Me.pnlHome.Location = New System.Drawing.Point(0, 47)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1370, 661)
        Me.pnlHome.TabIndex = 1
        '
        'Home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1368, 697)
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food Delivery Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FoodMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlHome As Panel
    Friend WithEvents PladeOrdersToolStripMenuItem As ToolStripMenuItem
End Class
