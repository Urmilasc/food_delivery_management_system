<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Food_Menu
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
        Me.lblManageFood = New System.Windows.Forms.Label()
        Me.dgvFoodMenu = New System.Windows.Forms.DataGridView()
        Me.btnSerachFood = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnlFoodMenuImg = New System.Windows.Forms.Panel()
        Me.btnAddFood = New System.Windows.Forms.Button()
        Me.btnDeleteFood = New System.Windows.Forms.Button()
        Me.BtnUpdateFood = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblFoodPrice = New System.Windows.Forms.Label()
        Me.lblFoodCategory = New System.Windows.Forms.Label()
        Me.lblFoodName = New System.Windows.Forms.Label()
        CType(Me.dgvFoodMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblManageFood
        '
        Me.lblManageFood.AutoSize = True
        Me.lblManageFood.Font = New System.Drawing.Font("Yu Gothic UI", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblManageFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblManageFood.Location = New System.Drawing.Point(551, 35)
        Me.lblManageFood.Name = "lblManageFood"
        Me.lblManageFood.Size = New System.Drawing.Size(252, 50)
        Me.lblManageFood.TabIndex = 0
        Me.lblManageFood.Text = "Manage Food"
        '
        'dgvFoodMenu
        '
        Me.dgvFoodMenu.AllowUserToOrderColumns = True
        Me.dgvFoodMenu.BackgroundColor = System.Drawing.Color.White
        Me.dgvFoodMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFoodMenu.GridColor = System.Drawing.Color.Black
        Me.dgvFoodMenu.Location = New System.Drawing.Point(64, 440)
        Me.dgvFoodMenu.Name = "dgvFoodMenu"
        Me.dgvFoodMenu.RowHeadersWidth = 51
        Me.dgvFoodMenu.RowTemplate.Height = 29
        Me.dgvFoodMenu.Size = New System.Drawing.Size(634, 393)
        Me.dgvFoodMenu.TabIndex = 1
        Me.dgvFoodMenu.Tag = ""
        '
        'btnSerachFood
        '
        Me.btnSerachFood.BackColor = System.Drawing.Color.Maroon
        Me.btnSerachFood.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSerachFood.ForeColor = System.Drawing.Color.White
        Me.btnSerachFood.Location = New System.Drawing.Point(64, 389)
        Me.btnSerachFood.Name = "btnSerachFood"
        Me.btnSerachFood.Size = New System.Drawing.Size(113, 45)
        Me.btnSerachFood.TabIndex = 2
        Me.btnSerachFood.Text = "Search"
        Me.btnSerachFood.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(192, 389)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(505, 38)
        Me.TextBox1.TabIndex = 3
        '
        'pnlFoodMenuImg
        '
        Me.pnlFoodMenuImg.BackColor = System.Drawing.Color.Gray
        Me.pnlFoodMenuImg.BackgroundImage = Global.Food_Delivery_Management_System.My.Resources.Resources.supervisor
        Me.pnlFoodMenuImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlFoodMenuImg.ForeColor = System.Drawing.Color.White
        Me.pnlFoodMenuImg.Location = New System.Drawing.Point(745, 121)
        Me.pnlFoodMenuImg.Name = "pnlFoodMenuImg"
        Me.pnlFoodMenuImg.Size = New System.Drawing.Size(671, 712)
        Me.pnlFoodMenuImg.TabIndex = 4
        '
        'btnAddFood
        '
        Me.btnAddFood.BackColor = System.Drawing.Color.Maroon
        Me.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFood.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddFood.Location = New System.Drawing.Point(64, 315)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(159, 49)
        Me.btnAddFood.TabIndex = 5
        Me.btnAddFood.Text = "Add "
        Me.btnAddFood.UseVisualStyleBackColor = False
        '
        'btnDeleteFood
        '
        Me.btnDeleteFood.BackColor = System.Drawing.Color.Maroon
        Me.btnDeleteFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeleteFood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteFood.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteFood.Location = New System.Drawing.Point(538, 317)
        Me.btnDeleteFood.Name = "btnDeleteFood"
        Me.btnDeleteFood.Size = New System.Drawing.Size(159, 49)
        Me.btnDeleteFood.TabIndex = 6
        Me.btnDeleteFood.Text = "Delete"
        Me.btnDeleteFood.UseVisualStyleBackColor = False
        '
        'BtnUpdateFood
        '
        Me.BtnUpdateFood.BackColor = System.Drawing.Color.Maroon
        Me.BtnUpdateFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdateFood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateFood.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdateFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdateFood.Location = New System.Drawing.Point(291, 317)
        Me.BtnUpdateFood.Name = "BtnUpdateFood"
        Me.BtnUpdateFood.Size = New System.Drawing.Size(159, 49)
        Me.BtnUpdateFood.TabIndex = 7
        Me.BtnUpdateFood.Text = "Update"
        Me.BtnUpdateFood.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(255, 257)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(442, 38)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(255, 189)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(442, 38)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.Location = New System.Drawing.Point(258, 121)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(438, 38)
        Me.TextBox4.TabIndex = 17
        '
        'lblFoodPrice
        '
        Me.lblFoodPrice.AutoSize = True
        Me.lblFoodPrice.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFoodPrice.ForeColor = System.Drawing.Color.White
        Me.lblFoodPrice.Location = New System.Drawing.Point(64, 256)
        Me.lblFoodPrice.Name = "lblFoodPrice"
        Me.lblFoodPrice.Size = New System.Drawing.Size(91, 37)
        Me.lblFoodPrice.TabIndex = 16
        Me.lblFoodPrice.Text = "Price :"
        '
        'lblFoodCategory
        '
        Me.lblFoodCategory.AutoSize = True
        Me.lblFoodCategory.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFoodCategory.ForeColor = System.Drawing.Color.White
        Me.lblFoodCategory.Location = New System.Drawing.Point(61, 192)
        Me.lblFoodCategory.Name = "lblFoodCategory"
        Me.lblFoodCategory.Size = New System.Drawing.Size(206, 37)
        Me.lblFoodCategory.TabIndex = 15
        Me.lblFoodCategory.Text = "Food Catergory"
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFoodName.ForeColor = System.Drawing.Color.White
        Me.lblFoodName.Location = New System.Drawing.Point(61, 124)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(179, 37)
        Me.lblFoodName.TabIndex = 14
        Me.lblFoodName.Text = " Food Name :"
        '
        'Food_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1566, 881)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblFoodPrice)
        Me.Controls.Add(Me.lblFoodCategory)
        Me.Controls.Add(Me.lblFoodName)
        Me.Controls.Add(Me.BtnUpdateFood)
        Me.Controls.Add(Me.btnDeleteFood)
        Me.Controls.Add(Me.btnAddFood)
        Me.Controls.Add(Me.pnlFoodMenuImg)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnSerachFood)
        Me.Controls.Add(Me.dgvFoodMenu)
        Me.Controls.Add(Me.lblManageFood)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Food_Menu"
        Me.Text = "Food_Menu"
        CType(Me.dgvFoodMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblManageFood As Label
    Friend WithEvents dgvFoodMenu As DataGridView
    Friend WithEvents btnSerachFood As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddFood As Button
    Friend WithEvents btnDeleteFood As Button
    Friend WithEvents BtnUpdateFood As Button
    Friend WithEvents pnlFoodMenuImg As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblFoodPrice As Label
    Friend WithEvents lblFoodCategory As Label
    Friend WithEvents lblFoodName As Label
End Class
