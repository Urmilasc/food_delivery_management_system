<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Report
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
        Me.lblSalesReport = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSearchSalesReport = New System.Windows.Forms.Button()
        Me.txtSalesReport = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSalesReport
        '
        Me.lblSalesReport.AutoSize = True
        Me.lblSalesReport.Font = New System.Drawing.Font("Yu Gothic UI", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblSalesReport.Location = New System.Drawing.Point(571, 37)
        Me.lblSalesReport.Name = "lblSalesReport"
        Me.lblSalesReport.Size = New System.Drawing.Size(231, 50)
        Me.lblSalesReport.TabIndex = 0
        Me.lblSalesReport.Text = "Sales Report"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1499, 691)
        Me.DataGridView1.TabIndex = 1
        '
        'btnSearchSalesReport
        '
        Me.btnSearchSalesReport.BackColor = System.Drawing.Color.Maroon
        Me.btnSearchSalesReport.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchSalesReport.ForeColor = System.Drawing.Color.White
        Me.btnSearchSalesReport.Location = New System.Drawing.Point(280, 97)
        Me.btnSearchSalesReport.Name = "btnSearchSalesReport"
        Me.btnSearchSalesReport.Size = New System.Drawing.Size(170, 47)
        Me.btnSearchSalesReport.TabIndex = 2
        Me.btnSearchSalesReport.Text = "Search"
        Me.btnSearchSalesReport.UseVisualStyleBackColor = False
        '
        'txtSalesReport
        '
        Me.txtSalesReport.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSalesReport.Location = New System.Drawing.Point(469, 101)
        Me.txtSalesReport.Name = "txtSalesReport"
        Me.txtSalesReport.Size = New System.Drawing.Size(876, 38)
        Me.txtSalesReport.TabIndex = 3
        '
        'Sales_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1566, 881)
        Me.Controls.Add(Me.txtSalesReport)
        Me.Controls.Add(Me.btnSearchSalesReport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblSalesReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Sales_Report"
        Me.Text = "Sales_Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalesReport As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearchSalesReport As Button
    Friend WithEvents txtSalesReport As TextBox
End Class
