<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchEmployee = New System.Windows.Forms.Button()
        Me.txtManageEmployee = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btbdeleteEmployee = New System.Windows.Forms.Button()
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        Me.pnlEmployeeBikeImg = New System.Windows.Forms.Panel()
        Me.txtEmployeeAddress = New System.Windows.Forms.TextBox()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.lblEmployeeAge = New System.Windows.Forms.Label()
        Me.lblEmployeeNumber = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblEmployeeAddress = New System.Windows.Forms.Label()
        Me.txtEmployeeAge = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(486, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Employee"
        '
        'btnSearchEmployee
        '
        Me.btnSearchEmployee.BackColor = System.Drawing.Color.DarkRed
        Me.btnSearchEmployee.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchEmployee.ForeColor = System.Drawing.Color.White
        Me.btnSearchEmployee.Location = New System.Drawing.Point(24, 74)
        Me.btnSearchEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchEmployee.Name = "btnSearchEmployee"
        Me.btnSearchEmployee.Size = New System.Drawing.Size(106, 35)
        Me.btnSearchEmployee.TabIndex = 1
        Me.btnSearchEmployee.Text = "Button1"
        Me.btnSearchEmployee.UseVisualStyleBackColor = False
        '
        'txtManageEmployee
        '
        Me.txtManageEmployee.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtManageEmployee.Location = New System.Drawing.Point(136, 78)
        Me.txtManageEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtManageEmployee.Name = "txtManageEmployee"
        Me.txtManageEmployee.Size = New System.Drawing.Size(423, 32)
        Me.txtManageEmployee.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 114)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(534, 472)
        Me.DataGridView1.TabIndex = 3
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.DarkRed
        Me.btnAddEmployee.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.Location = New System.Drawing.Point(890, 583)
        Me.btnAddEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(147, 35)
        Me.btnAddEmployee.TabIndex = 4
        Me.btnAddEmployee.Text = "Add"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'btbdeleteEmployee
        '
        Me.btbdeleteEmployee.BackColor = System.Drawing.Color.DarkRed
        Me.btbdeleteEmployee.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btbdeleteEmployee.ForeColor = System.Drawing.Color.White
        Me.btbdeleteEmployee.Location = New System.Drawing.Point(203, 601)
        Me.btbdeleteEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btbdeleteEmployee.Name = "btbdeleteEmployee"
        Me.btbdeleteEmployee.Size = New System.Drawing.Size(133, 35)
        Me.btbdeleteEmployee.TabIndex = 5
        Me.btbdeleteEmployee.Text = "Delete"
        Me.btbdeleteEmployee.UseVisualStyleBackColor = False
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.BackColor = System.Drawing.Color.DarkRed
        Me.btnUpdateEmployee.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdateEmployee.ForeColor = System.Drawing.Color.White
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(1094, 583)
        Me.btnUpdateEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(140, 35)
        Me.btnUpdateEmployee.TabIndex = 6
        Me.btnUpdateEmployee.Text = "Update"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = False
        '
        'pnlEmployeeBikeImg
        '
        Me.pnlEmployeeBikeImg.BackColor = System.Drawing.SystemColors.GrayText
        Me.pnlEmployeeBikeImg.BackgroundImage = Global.Food_Delivery_Management_System.My.Resources.Resources.delivery_bike
        Me.pnlEmployeeBikeImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlEmployeeBikeImg.Location = New System.Drawing.Point(812, 74)
        Me.pnlEmployeeBikeImg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEmployeeBikeImg.Name = "pnlEmployeeBikeImg"
        Me.pnlEmployeeBikeImg.Size = New System.Drawing.Size(328, 266)
        Me.pnlEmployeeBikeImg.TabIndex = 7
        '
        'txtEmployeeAddress
        '
        Me.txtEmployeeAddress.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmployeeAddress.Location = New System.Drawing.Point(890, 467)
        Me.txtEmployeeAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmployeeAddress.Name = "txtEmployeeAddress"
        Me.txtEmployeeAddress.Size = New System.Drawing.Size(344, 32)
        Me.txtEmployeeAddress.TabIndex = 19
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(890, 416)
        Me.txtEmployeeNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(344, 32)
        Me.txtEmployeeNumber.TabIndex = 18
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmployeeName.Location = New System.Drawing.Point(890, 365)
        Me.txtEmployeeName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(344, 32)
        Me.txtEmployeeName.TabIndex = 17
        '
        'lblEmployeeAge
        '
        Me.lblEmployeeAge.AutoSize = True
        Me.lblEmployeeAge.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeAge.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeAge.Location = New System.Drawing.Point(696, 517)
        Me.lblEmployeeAge.Name = "lblEmployeeAge"
        Me.lblEmployeeAge.Size = New System.Drawing.Size(62, 30)
        Me.lblEmployeeAge.TabIndex = 16
        Me.lblEmployeeAge.Text = "Age :"
        '
        'lblEmployeeNumber
        '
        Me.lblEmployeeNumber.AutoSize = True
        Me.lblEmployeeNumber.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeNumber.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeNumber.Location = New System.Drawing.Point(694, 415)
        Me.lblEmployeeNumber.Name = "lblEmployeeNumber"
        Me.lblEmployeeNumber.Size = New System.Drawing.Size(103, 30)
        Me.lblEmployeeNumber.TabIndex = 15
        Me.lblEmployeeNumber.Text = "Number :"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeName.Location = New System.Drawing.Point(694, 364)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(181, 30)
        Me.lblEmployeeName.TabIndex = 14
        Me.lblEmployeeName.Text = "Employee Name :"
        '
        'lblEmployeeAddress
        '
        Me.lblEmployeeAddress.AutoSize = True
        Me.lblEmployeeAddress.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeAddress.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeAddress.Location = New System.Drawing.Point(696, 466)
        Me.lblEmployeeAddress.Name = "lblEmployeeAddress"
        Me.lblEmployeeAddress.Size = New System.Drawing.Size(101, 30)
        Me.lblEmployeeAddress.TabIndex = 20
        Me.lblEmployeeAddress.Text = "Address :"
        '
        'txtEmployeeAge
        '
        Me.txtEmployeeAge.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmployeeAge.Location = New System.Drawing.Point(890, 518)
        Me.txtEmployeeAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmployeeAge.Name = "txtEmployeeAge"
        Me.txtEmployeeAge.Size = New System.Drawing.Size(344, 32)
        Me.txtEmployeeAge.TabIndex = 21
        '
        'Employee_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1370, 661)
        Me.Controls.Add(Me.txtEmployeeAge)
        Me.Controls.Add(Me.lblEmployeeAddress)
        Me.Controls.Add(Me.txtEmployeeAddress)
        Me.Controls.Add(Me.txtEmployeeNumber)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.lblEmployeeAge)
        Me.Controls.Add(Me.lblEmployeeNumber)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.pnlEmployeeBikeImg)
        Me.Controls.Add(Me.btnUpdateEmployee)
        Me.Controls.Add(Me.btbdeleteEmployee)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtManageEmployee)
        Me.Controls.Add(Me.btnSearchEmployee)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee_Management"
        Me.Text = "Employee_Management"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchEmployee As Button
    Friend WithEvents txtManageEmployee As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btbdeleteEmployee As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents pnlEmployeeBikeImg As Panel
    Friend WithEvents txtEmployeeAddress As TextBox
    Friend WithEvents txtEmployeeNumber As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents lblEmployeeAge As Label
    Friend WithEvents lblEmployeeNumber As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblEmployeeAddress As Label
    Friend WithEvents txtEmployeeAge As TextBox
End Class
