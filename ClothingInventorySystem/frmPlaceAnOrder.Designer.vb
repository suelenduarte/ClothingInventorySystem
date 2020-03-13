<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlaceAnOrderToCart
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
        Me.dvgCustomers = New System.Windows.Forms.DataGridView()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.lblOderId = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.txtOrderId = New System.Windows.Forms.TextBox()
        Me.lblCustomersInOrder = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dvgProducts = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dvgCustomersOrder = New System.Windows.Forms.DataGridView()
        Me.btnQuantityOrder = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnDeleteSelectedOrder = New System.Windows.Forms.Button()
        Me.btnPrintOrder = New System.Windows.Forms.Button()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dvgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgCustomersOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgCustomers
        '
        Me.dvgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCustomers.Location = New System.Drawing.Point(22, 41)
        Me.dvgCustomers.Name = "dvgCustomers"
        Me.dvgCustomers.Size = New System.Drawing.Size(445, 224)
        Me.dvgCustomers.TabIndex = 18
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(598, 41)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(63, 13)
        Me.lblCustomerId.TabIndex = 19
        Me.lblCustomerId.Text = "Customer Id"
        '
        'lblOderId
        '
        Me.lblOderId.AutoSize = True
        Me.lblOderId.Location = New System.Drawing.Point(595, 83)
        Me.lblOderId.Name = "lblOderId"
        Me.lblOderId.Size = New System.Drawing.Size(45, 13)
        Me.lblOderId.TabIndex = 20
        Me.lblOderId.Text = "Order Id"
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(598, 120)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(59, 13)
        Me.lblOrderDate.TabIndex = 21
        Me.lblOrderDate.Text = "Order Date"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(679, 33)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerId.TabIndex = 22
        '
        'txtOrderId
        '
        Me.txtOrderId.Location = New System.Drawing.Point(679, 75)
        Me.txtOrderId.Name = "txtOrderId"
        Me.txtOrderId.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderId.TabIndex = 23
        '
        'lblCustomersInOrder
        '
        Me.lblCustomersInOrder.AutoSize = True
        Me.lblCustomersInOrder.Location = New System.Drawing.Point(19, 9)
        Me.lblCustomersInOrder.Name = "lblCustomersInOrder"
        Me.lblCustomersInOrder.Size = New System.Drawing.Size(92, 13)
        Me.lblCustomersInOrder.TabIndex = 25
        Me.lblCustomersInOrder.Text = "List Of Customers:"
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(204, 288)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(254, 21)
        Me.cboCategory.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Choose Products By Category:"
        '
        'dvgProducts
        '
        Me.dvgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgProducts.Location = New System.Drawing.Point(22, 395)
        Me.dvgProducts.Name = "dvgProducts"
        Me.dvgProducts.Size = New System.Drawing.Size(445, 225)
        Me.dvgProducts.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "List Of Products:"
        '
        'dvgCustomersOrder
        '
        Me.dvgCustomersOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgCustomersOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCustomersOrder.Location = New System.Drawing.Point(565, 226)
        Me.dvgCustomersOrder.Name = "dvgCustomersOrder"
        Me.dvgCustomersOrder.Size = New System.Drawing.Size(445, 225)
        Me.dvgCustomersOrder.TabIndex = 30
        '
        'btnQuantityOrder
        '
        Me.btnQuantityOrder.Location = New System.Drawing.Point(121, 355)
        Me.btnQuantityOrder.Name = "btnQuantityOrder"
        Me.btnQuantityOrder.Size = New System.Drawing.Size(111, 23)
        Me.btnQuantityOrder.TabIndex = 31
        Me.btnQuantityOrder.Text = "Update Quantity"
        Me.btnQuantityOrder.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(247, 355)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 32
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnDeleteSelectedOrder
        '
        Me.btnDeleteSelectedOrder.Location = New System.Drawing.Point(328, 355)
        Me.btnDeleteSelectedOrder.Name = "btnDeleteSelectedOrder"
        Me.btnDeleteSelectedOrder.Size = New System.Drawing.Size(139, 23)
        Me.btnDeleteSelectedOrder.TabIndex = 33
        Me.btnDeleteSelectedOrder.Text = "Delete Selected Order"
        Me.btnDeleteSelectedOrder.UseVisualStyleBackColor = True
        '
        'btnPrintOrder
        '
        Me.btnPrintOrder.Location = New System.Drawing.Point(523, 487)
        Me.btnPrintOrder.Name = "btnPrintOrder"
        Me.btnPrintOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintOrder.TabIndex = 34
        Me.btnPrintOrder.Text = "Print Order"
        Me.btnPrintOrder.UseVisualStyleBackColor = True
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(806, 487)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalAmount.TabIndex = 35
        Me.lblTotalAmount.Text = "Total Amount:"
        '
        'txTotalAmount
        '
        Me.txTotalAmount.Location = New System.Drawing.Point(910, 480)
        Me.txTotalAmount.Name = "txTotalAmount"
        Me.txTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txTotalAmount.TabIndex = 36
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(679, 117)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(598, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(595, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(519, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Quantity"
        '
        'frmPlaceAnOrderToCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 791)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txTotalAmount)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.btnPrintOrder)
        Me.Controls.Add(Me.btnDeleteSelectedOrder)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnQuantityOrder)
        Me.Controls.Add(Me.dvgCustomersOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dvgProducts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.lblCustomersInOrder)
        Me.Controls.Add(Me.txtOrderId)
        Me.Controls.Add(Me.txtCustomerId)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblOderId)
        Me.Controls.Add(Me.lblCustomerId)
        Me.Controls.Add(Me.dvgCustomers)
        Me.Name = "frmPlaceAnOrderToCart"
        Me.Text = "frmPlaceAnOrder"
        CType(Me.dvgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgCustomersOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgCustomers As DataGridView
    Friend WithEvents lblCustomerId As Label
    Friend WithEvents lblOderId As Label
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents txtOrderId As TextBox
    Friend WithEvents lblCustomersInOrder As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dvgProducts As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dvgCustomersOrder As DataGridView
    Friend WithEvents btnQuantityOrder As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnDeleteSelectedOrder As Button
    Friend WithEvents btnPrintOrder As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txTotalAmount As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
