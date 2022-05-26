<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Menu
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
        Me.lblManageEmployees = New System.Windows.Forms.Label()
        Me.dgvFoodMenuView = New System.Windows.Forms.DataGridView()
        Me.btnSearchFoodMenu = New System.Windows.Forms.Button()
        Me.txtSearchFoodMenu = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvFoodMenuView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblManageEmployees
        '
        Me.lblManageEmployees.AutoSize = True
        Me.lblManageEmployees.Font = New System.Drawing.Font("Yu Gothic UI", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblManageEmployees.ForeColor = System.Drawing.Color.Black
        Me.lblManageEmployees.Location = New System.Drawing.Point(562, 19)
        Me.lblManageEmployees.Name = "lblManageEmployees"
        Me.lblManageEmployees.Size = New System.Drawing.Size(214, 50)
        Me.lblManageEmployees.TabIndex = 0
        Me.lblManageEmployees.Text = "Food Menu"
        '
        'dgvFoodMenuView
        '
        Me.dgvFoodMenuView.AllowUserToOrderColumns = True
        Me.dgvFoodMenuView.BackgroundColor = System.Drawing.Color.White
        Me.dgvFoodMenuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFoodMenuView.Location = New System.Drawing.Point(35, 147)
        Me.dgvFoodMenuView.Name = "dgvFoodMenuView"
        Me.dgvFoodMenuView.RowHeadersWidth = 51
        Me.dgvFoodMenuView.RowTemplate.Height = 29
        Me.dgvFoodMenuView.Size = New System.Drawing.Size(605, 683)
        Me.dgvFoodMenuView.TabIndex = 1
        '
        'btnSearchFoodMenu
        '
        Me.btnSearchFoodMenu.BackColor = System.Drawing.Color.Maroon
        Me.btnSearchFoodMenu.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchFoodMenu.ForeColor = System.Drawing.Color.White
        Me.btnSearchFoodMenu.Location = New System.Drawing.Point(35, 91)
        Me.btnSearchFoodMenu.Name = "btnSearchFoodMenu"
        Me.btnSearchFoodMenu.Size = New System.Drawing.Size(133, 40)
        Me.btnSearchFoodMenu.TabIndex = 2
        Me.btnSearchFoodMenu.Text = "search"
        Me.btnSearchFoodMenu.UseVisualStyleBackColor = False
        '
        'txtSearchFoodMenu
        '
        Me.txtSearchFoodMenu.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearchFoodMenu.Location = New System.Drawing.Point(185, 93)
        Me.txtSearchFoodMenu.Name = "txtSearchFoodMenu"
        Me.txtSearchFoodMenu.Size = New System.Drawing.Size(455, 38)
        Me.txtSearchFoodMenu.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BackgroundImage = Global.Food_Delivery_Management_System.My.Resources.Resources.menu
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(673, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 736)
        Me.Panel1.TabIndex = 4
        '
        'View_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1566, 881)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSearchFoodMenu)
        Me.Controls.Add(Me.btnSearchFoodMenu)
        Me.Controls.Add(Me.dgvFoodMenuView)
        Me.Controls.Add(Me.lblManageEmployees)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "View_Menu"
        Me.Text = "View_Menu"
        CType(Me.dgvFoodMenuView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblManageEmployees As Label
    Friend WithEvents dgvFoodMenuView As DataGridView
    Friend WithEvents btnSearchFoodMenu As Button
    Friend WithEvents txtSearchFoodMenu As TextBox
    Friend WithEvents Panel1 As Panel
End Class
