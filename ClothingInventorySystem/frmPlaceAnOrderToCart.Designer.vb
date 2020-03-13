<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlaceAnOrderToCart
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
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.lblNameProduct = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnFinishOrder = New System.Windows.Forms.Button()
        Me.cboCustomerId = New System.Windows.Forms.ComboBox()
        Me.cboProductId = New System.Windows.Forms.ComboBox()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lblProducs = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(498, 315)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 47
        Me.lblPrice.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Quantity"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(631, 146)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(236, 26)
        Me.txtDate.TabIndex = 45
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(497, 152)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(88, 20)
        Me.lblOrderDate.TabIndex = 42
        Me.lblOrderDate.Text = "Order Date"
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(497, 99)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(96, 20)
        Me.lblCustomerId.TabIndex = 40
        Me.lblCustomerId.Text = "Customer Id"
        '
        'lblNameProduct
        '
        Me.lblNameProduct.AutoSize = True
        Me.lblNameProduct.Location = New System.Drawing.Point(497, 210)
        Me.lblNameProduct.Name = "lblNameProduct"
        Me.lblNameProduct.Size = New System.Drawing.Size(82, 20)
        Me.lblNameProduct.TabIndex = 49
        Me.lblNameProduct.Text = "Product Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(498, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Total"
        '
        'dgvProducts
        '
        Me.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(12, 335)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(416, 287)
        Me.dgvProducts.TabIndex = 54
        '
        'cboCategories
        '
        Me.cboCategories.BackColor = System.Drawing.Color.LavenderBlush
        Me.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategories.ForeColor = System.Drawing.Color.Black
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Location = New System.Drawing.Point(125, 264)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(171, 21)
        Me.cboCategories.TabIndex = 53
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.GridColor = System.Drawing.Color.CadetBlue
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 48)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(416, 176)
        Me.dgvCustomers.TabIndex = 52
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnPlaceOrder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPlaceOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.ForeColor = System.Drawing.Color.White
        Me.btnPlaceOrder.Location = New System.Drawing.Point(631, 498)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(118, 29)
        Me.btnPlaceOrder.TabIndex = 57
        Me.btnPlaceOrder.Text = "Insert Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(631, 259)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(118, 26)
        Me.txtQuantity.TabIndex = 59
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(631, 309)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(118, 26)
        Me.txtPrice.TabIndex = 60
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(631, 435)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtTotal.TabIndex = 61
        '
        'btnFinishOrder
        '
        Me.btnFinishOrder.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnFinishOrder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFinishOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnFinishOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnFinishOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinishOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishOrder.ForeColor = System.Drawing.Color.White
        Me.btnFinishOrder.Location = New System.Drawing.Point(924, 498)
        Me.btnFinishOrder.Name = "btnFinishOrder"
        Me.btnFinishOrder.Size = New System.Drawing.Size(118, 29)
        Me.btnFinishOrder.TabIndex = 63
        Me.btnFinishOrder.Text = "Finish Order"
        Me.btnFinishOrder.UseVisualStyleBackColor = False
        '
        'cboCustomerId
        '
        Me.cboCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerId.FormattingEnabled = True
        Me.cboCustomerId.Location = New System.Drawing.Point(631, 96)
        Me.cboCustomerId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCustomerId.Name = "cboCustomerId"
        Me.cboCustomerId.Size = New System.Drawing.Size(236, 28)
        Me.cboCustomerId.TabIndex = 65
        '
        'cboProductId
        '
        Me.cboProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductId.FormattingEnabled = True
        Me.cboProductId.Location = New System.Drawing.Point(631, 202)
        Me.cboProductId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProductId.Name = "cboProductId"
        Me.cboProductId.Size = New System.Drawing.Size(236, 28)
        Me.cboProductId.TabIndex = 66
        '
        'dgvOrders
        '
        Me.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Location = New System.Drawing.Point(924, 41)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrders.Size = New System.Drawing.Size(527, 353)
        Me.dgvOrders.TabIndex = 68
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnCalculateTotal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCalculateTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnCalculateTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnCalculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateTotal.ForeColor = System.Drawing.Color.White
        Me.btnCalculateTotal.Location = New System.Drawing.Point(631, 350)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(118, 29)
        Me.btnCalculateTotal.TabIndex = 91
        Me.btnCalculateTotal.Text = "Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = False
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalAmount.Location = New System.Drawing.Point(1294, 417)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(15, 20)
        Me.lblTotalAmount.TabIndex = 94
        Me.lblTotalAmount.Text = "*"
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.BackColor = System.Drawing.SystemColors.Info
        Me.lblCustomers.Location = New System.Drawing.Point(12, 9)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(137, 20)
        Me.lblCustomers.TabIndex = 95
        Me.lblCustomers.Text = "List of Customers:"
        '
        'lblProducs
        '
        Me.lblProducs.AutoSize = True
        Me.lblProducs.BackColor = System.Drawing.SystemColors.Info
        Me.lblProducs.Location = New System.Drawing.Point(12, 309)
        Me.lblProducs.Name = "lblProducs"
        Me.lblProducs.Size = New System.Drawing.Size(123, 20)
        Me.lblProducs.TabIndex = 96
        Me.lblProducs.Text = "List of Products:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.SystemColors.Info
        Me.lblAmount.Location = New System.Drawing.Point(1205, 417)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(48, 20)
        Me.lblAmount.TabIndex = 97
        Me.lblAmount.Text = "Total:"
        '
        'frmPlaceAnOrderToCart
        '
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1502, 647)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblProducs)
        Me.Controls.Add(Me.lblCustomers)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.cboProductId)
        Me.Controls.Add(Me.cboCustomerId)
        Me.Controls.Add(Me.btnFinishOrder)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.cboCategories)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNameProduct)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblCustomerId)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmPlaceAnOrderToCart"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents lblCustomerId As Label
    Friend WithEvents lblNameProduct As Label
    Friend WithEvents Label2 As Label
    Private WithEvents dgvProducts As DataGridView
    Private WithEvents cboCategories As ComboBox
    Public WithEvents dgvCustomers As DataGridView
    Private WithEvents btnPlaceOrder As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtTotal As TextBox
    Private WithEvents btnFinishOrder As Button
    Friend WithEvents cboCustomerId As ComboBox
    Friend WithEvents cboProductId As ComboBox
    Private WithEvents dgvOrders As DataGridView
    Private WithEvents btnCalculateTotal As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents lblProducs As Label
    Friend WithEvents lblAmount As Label
End Class
