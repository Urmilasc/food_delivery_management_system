<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Place_Orders
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPlaceOrderFoodManu = New System.Windows.Forms.DataGridView()
        Me.txtSearchPlaceOrder = New System.Windows.Forms.TextBox()
        Me.btnSearcPlaceOrder = New System.Windows.Forms.Button()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.txtCutomerAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerNumber = New System.Windows.Forms.Label()
        Me.lblCutomerName = New System.Windows.Forms.Label()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.lblFoodQuantity = New System.Windows.Forms.Label()
        Me.lblOrderFoodQuantity = New System.Windows.Forms.Label()
        Me.txtOrderFoodQuantity = New System.Windows.Forms.TextBox()
        Me.txtOrderFoodCategory = New System.Windows.Forms.TextBox()
        Me.txtOrderFoodName = New System.Windows.Forms.TextBox()
        Me.lblOrderFoodCategory = New System.Windows.Forms.Label()
        Me.lblOrderFoodName = New System.Windows.Forms.Label()
        Me.lblOrderPrice = New System.Windows.Forms.Label()
        Me.txtOrderPrice = New System.Windows.Forms.TextBox()
        Me.dgvTotalOrders = New System.Windows.Forms.DataGridView()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        CType(Me.dgvPlaceOrderFoodManu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTotalOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(554, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Place Orders"
        '
        'dgvPlaceOrderFoodManu
        '
        Me.dgvPlaceOrderFoodManu.AllowUserToOrderColumns = True
        Me.dgvPlaceOrderFoodManu.BackgroundColor = System.Drawing.Color.White
        Me.dgvPlaceOrderFoodManu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlaceOrderFoodManu.Location = New System.Drawing.Point(14, 145)
        Me.dgvPlaceOrderFoodManu.Name = "dgvPlaceOrderFoodManu"
        Me.dgvPlaceOrderFoodManu.RowHeadersWidth = 51
        Me.dgvPlaceOrderFoodManu.RowTemplate.Height = 29
        Me.dgvPlaceOrderFoodManu.Size = New System.Drawing.Size(568, 687)
        Me.dgvPlaceOrderFoodManu.TabIndex = 20
        '
        'txtSearchPlaceOrder
        '
        Me.txtSearchPlaceOrder.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearchPlaceOrder.Location = New System.Drawing.Point(142, 97)
        Me.txtSearchPlaceOrder.Name = "txtSearchPlaceOrder"
        Me.txtSearchPlaceOrder.Size = New System.Drawing.Size(439, 38)
        Me.txtSearchPlaceOrder.TabIndex = 19
        '
        'btnSearcPlaceOrder
        '
        Me.btnSearcPlaceOrder.BackColor = System.Drawing.Color.DarkRed
        Me.btnSearcPlaceOrder.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearcPlaceOrder.ForeColor = System.Drawing.Color.White
        Me.btnSearcPlaceOrder.Location = New System.Drawing.Point(14, 92)
        Me.btnSearcPlaceOrder.Name = "btnSearcPlaceOrder"
        Me.btnSearcPlaceOrder.Size = New System.Drawing.Size(121, 47)
        Me.btnSearcPlaceOrder.TabIndex = 18
        Me.btnSearcPlaceOrder.Text = "Search"
        Me.btnSearcPlaceOrder.UseVisualStyleBackColor = False
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerAddress.ForeColor = System.Drawing.Color.White
        Me.lblCustomerAddress.Location = New System.Drawing.Point(607, 263)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(129, 37)
        Me.lblCustomerAddress.TabIndex = 29
        Me.lblCustomerAddress.Text = "Address :"
        '
        'txtCutomerAddress
        '
        Me.txtCutomerAddress.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCutomerAddress.ForeColor = System.Drawing.Color.White
        Me.txtCutomerAddress.Location = New System.Drawing.Point(817, 263)
        Me.txtCutomerAddress.Name = "txtCutomerAddress"
        Me.txtCutomerAddress.Size = New System.Drawing.Size(231, 38)
        Me.txtCutomerAddress.TabIndex = 28
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCustomerNumber.Location = New System.Drawing.Point(817, 204)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.Size = New System.Drawing.Size(231, 38)
        Me.txtCustomerNumber.TabIndex = 27
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCustomerName.Location = New System.Drawing.Point(817, 147)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(231, 38)
        Me.txtCustomerName.TabIndex = 26
        '
        'lblCustomerNumber
        '
        Me.lblCustomerNumber.AutoSize = True
        Me.lblCustomerNumber.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerNumber.ForeColor = System.Drawing.Color.White
        Me.lblCustomerNumber.Location = New System.Drawing.Point(607, 203)
        Me.lblCustomerNumber.Name = "lblCustomerNumber"
        Me.lblCustomerNumber.Size = New System.Drawing.Size(132, 37)
        Me.lblCustomerNumber.TabIndex = 25
        Me.lblCustomerNumber.Text = "Number :"
        '
        'lblCutomerName
        '
        Me.lblCutomerName.AutoSize = True
        Me.lblCutomerName.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCutomerName.ForeColor = System.Drawing.Color.White
        Me.lblCutomerName.Location = New System.Drawing.Point(605, 145)
        Me.lblCutomerName.Name = "lblCutomerName"
        Me.lblCutomerName.Size = New System.Drawing.Size(230, 37)
        Me.lblCutomerName.TabIndex = 24
        Me.lblCutomerName.Text = "Customer Name :"
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerDetails.Location = New System.Drawing.Point(605, 92)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(240, 37)
        Me.lblCustomerDetails.TabIndex = 30
        Me.lblCustomerDetails.Text = "Customer Details :"
        '
        'lblFoodQuantity
        '
        Me.lblFoodQuantity.AutoSize = True
        Me.lblFoodQuantity.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblFoodQuantity.Location = New System.Drawing.Point(1193, 92)
        Me.lblFoodQuantity.Name = "lblFoodQuantity"
        Me.lblFoodQuantity.Size = New System.Drawing.Size(339, 37)
        Me.lblFoodQuantity.TabIndex = 31
        Me.lblFoodQuantity.Text = "Select Food and Quantity :"
        '
        'lblOrderFoodQuantity
        '
        Me.lblOrderFoodQuantity.AutoSize = True
        Me.lblOrderFoodQuantity.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrderFoodQuantity.ForeColor = System.Drawing.Color.White
        Me.lblOrderFoodQuantity.Location = New System.Drawing.Point(1087, 263)
        Me.lblOrderFoodQuantity.Name = "lblOrderFoodQuantity"
        Me.lblOrderFoodQuantity.Size = New System.Drawing.Size(138, 37)
        Me.lblOrderFoodQuantity.TabIndex = 37
        Me.lblOrderFoodQuantity.Text = "Quantity :"
        '
        'txtOrderFoodQuantity
        '
        Me.txtOrderFoodQuantity.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOrderFoodQuantity.ForeColor = System.Drawing.Color.White
        Me.txtOrderFoodQuantity.Location = New System.Drawing.Point(1259, 263)
        Me.txtOrderFoodQuantity.Name = "txtOrderFoodQuantity"
        Me.txtOrderFoodQuantity.Size = New System.Drawing.Size(267, 38)
        Me.txtOrderFoodQuantity.TabIndex = 36
        '
        'txtOrderFoodCategory
        '
        Me.txtOrderFoodCategory.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOrderFoodCategory.Location = New System.Drawing.Point(1259, 203)
        Me.txtOrderFoodCategory.Name = "txtOrderFoodCategory"
        Me.txtOrderFoodCategory.Size = New System.Drawing.Size(267, 38)
        Me.txtOrderFoodCategory.TabIndex = 35
        '
        'txtOrderFoodName
        '
        Me.txtOrderFoodName.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOrderFoodName.Location = New System.Drawing.Point(1259, 147)
        Me.txtOrderFoodName.Name = "txtOrderFoodName"
        Me.txtOrderFoodName.Size = New System.Drawing.Size(267, 38)
        Me.txtOrderFoodName.TabIndex = 34
        '
        'lblOrderFoodCategory
        '
        Me.lblOrderFoodCategory.AutoSize = True
        Me.lblOrderFoodCategory.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrderFoodCategory.ForeColor = System.Drawing.Color.White
        Me.lblOrderFoodCategory.Location = New System.Drawing.Point(1087, 203)
        Me.lblOrderFoodCategory.Name = "lblOrderFoodCategory"
        Me.lblOrderFoodCategory.Size = New System.Drawing.Size(142, 37)
        Me.lblOrderFoodCategory.TabIndex = 33
        Me.lblOrderFoodCategory.Text = "Category :"
        '
        'lblOrderFoodName
        '
        Me.lblOrderFoodName.AutoSize = True
        Me.lblOrderFoodName.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrderFoodName.ForeColor = System.Drawing.Color.White
        Me.lblOrderFoodName.Location = New System.Drawing.Point(1085, 145)
        Me.lblOrderFoodName.Name = "lblOrderFoodName"
        Me.lblOrderFoodName.Size = New System.Drawing.Size(172, 37)
        Me.lblOrderFoodName.TabIndex = 32
        Me.lblOrderFoodName.Text = "Food Name :"
        '
        'lblOrderPrice
        '
        Me.lblOrderPrice.AutoSize = True
        Me.lblOrderPrice.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrderPrice.ForeColor = System.Drawing.Color.White
        Me.lblOrderPrice.Location = New System.Drawing.Point(1087, 323)
        Me.lblOrderPrice.Name = "lblOrderPrice"
        Me.lblOrderPrice.Size = New System.Drawing.Size(91, 37)
        Me.lblOrderPrice.TabIndex = 39
        Me.lblOrderPrice.Text = "Price :"
        '
        'txtOrderPrice
        '
        Me.txtOrderPrice.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOrderPrice.ForeColor = System.Drawing.Color.White
        Me.txtOrderPrice.Location = New System.Drawing.Point(1259, 324)
        Me.txtOrderPrice.Name = "txtOrderPrice"
        Me.txtOrderPrice.Size = New System.Drawing.Size(267, 38)
        Me.txtOrderPrice.TabIndex = 38
        '
        'dgvTotalOrders
        '
        Me.dgvTotalOrders.AllowUserToOrderColumns = True
        Me.dgvTotalOrders.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotalOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalOrders.Location = New System.Drawing.Point(607, 384)
        Me.dgvTotalOrders.Name = "dgvTotalOrders"
        Me.dgvTotalOrders.RowHeadersWidth = 51
        Me.dgvTotalOrders.RowTemplate.Height = 29
        Me.dgvTotalOrders.Size = New System.Drawing.Size(920, 405)
        Me.dgvTotalOrders.TabIndex = 40
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.White
        Me.lblTotalPrice.Location = New System.Drawing.Point(607, 795)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(157, 37)
        Me.lblTotalPrice.TabIndex = 42
        Me.lblTotalPrice.Text = "Total Price :"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.White
        Me.txtTotalPrice.Location = New System.Drawing.Point(782, 795)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(267, 38)
        Me.txtTotalPrice.TabIndex = 41
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancel.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1193, 795)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 47)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.DarkRed
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPlaceOrder.ForeColor = System.Drawing.Color.White
        Me.btnPlaceOrder.Location = New System.Drawing.Point(1352, 795)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(181, 47)
        Me.btnPlaceOrder.TabIndex = 44
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'Place_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1566, 881)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.dgvTotalOrders)
        Me.Controls.Add(Me.lblOrderPrice)
        Me.Controls.Add(Me.txtOrderPrice)
        Me.Controls.Add(Me.lblOrderFoodQuantity)
        Me.Controls.Add(Me.txtOrderFoodQuantity)
        Me.Controls.Add(Me.txtOrderFoodCategory)
        Me.Controls.Add(Me.txtOrderFoodName)
        Me.Controls.Add(Me.lblOrderFoodCategory)
        Me.Controls.Add(Me.lblOrderFoodName)
        Me.Controls.Add(Me.lblFoodQuantity)
        Me.Controls.Add(Me.lblCustomerDetails)
        Me.Controls.Add(Me.lblCustomerAddress)
        Me.Controls.Add(Me.txtCutomerAddress)
        Me.Controls.Add(Me.txtCustomerNumber)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblCustomerNumber)
        Me.Controls.Add(Me.lblCutomerName)
        Me.Controls.Add(Me.dgvPlaceOrderFoodManu)
        Me.Controls.Add(Me.txtSearchPlaceOrder)
        Me.Controls.Add(Me.btnSearcPlaceOrder)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Place_Orders"
        Me.Text = "Place_Orders"
        CType(Me.dgvPlaceOrderFoodManu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTotalOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPlaceOrderFoodManu As DataGridView
    Friend WithEvents txtSearchPlaceOrder As TextBox
    Friend WithEvents btnSearcPlaceOrder As Button
    Friend WithEvents lblCustomerAddress As Label
    Friend WithEvents txtCutomerAddress As TextBox
    Friend WithEvents txtCustomerNumber As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblCustomerNumber As Label
    Friend WithEvents lblCutomerName As Label
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents lblFoodQuantity As Label
    Friend WithEvents lblOrderFoodQuantity As Label
    Friend WithEvents txtOrderFoodQuantity As TextBox
    Friend WithEvents txtOrderFoodCategory As TextBox
    Friend WithEvents txtOrderFoodName As TextBox
    Friend WithEvents lblOrderFoodCategory As Label
    Friend WithEvents lblOrderFoodName As Label
    Friend WithEvents lblOrderPrice As Label
    Friend WithEvents txtOrderPrice As TextBox
    Friend WithEvents dgvTotalOrders As DataGridView
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPlaceOrder As Button
End Class
