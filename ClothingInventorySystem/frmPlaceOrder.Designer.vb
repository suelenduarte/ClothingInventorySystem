<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlaceOrder
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboProductId = New System.Windows.Forms.ComboBox()
        Me.cboCustomerId = New System.Windows.Forms.ComboBox()
        Me.btnFinishOrder = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNameProduct = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtOrderId = New System.Windows.Forms.TextBox()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.lblOderId = New System.Windows.Forms.Label()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(390, 500)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(169, 29)
        Me.btnUpdate.TabIndex = 84
        Me.btnUpdate.Text = "Update Order"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cboProductId
        '
        Me.cboProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductId.FormattingEnabled = True
        Me.cboProductId.Location = New System.Drawing.Point(601, 333)
        Me.cboProductId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProductId.Name = "cboProductId"
        Me.cboProductId.Size = New System.Drawing.Size(180, 21)
        Me.cboProductId.TabIndex = 83
        '
        'cboCustomerId
        '
        Me.cboCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerId.FormattingEnabled = True
        Me.cboCustomerId.Location = New System.Drawing.Point(601, 238)
        Me.cboCustomerId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCustomerId.Name = "cboCustomerId"
        Me.cboCustomerId.Size = New System.Drawing.Size(180, 21)
        Me.cboCustomerId.TabIndex = 82
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
        Me.btnFinishOrder.Location = New System.Drawing.Point(816, 192)
        Me.btnFinishOrder.Name = "btnFinishOrder"
        Me.btnFinishOrder.Size = New System.Drawing.Size(118, 29)
        Me.btnFinishOrder.TabIndex = 81
        Me.btnFinishOrder.Text = "Finish Order"
        Me.btnFinishOrder.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(165, 333)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(223, 29)
        Me.btnDelete.TabIndex = 80
        Me.btnDelete.Text = "Delete Selected Order"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(601, 403)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 79
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(601, 369)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 78
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
        Me.btnPlaceOrder.Location = New System.Drawing.Point(583, 500)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(118, 29)
        Me.btnPlaceOrder.TabIndex = 77
        Me.btnPlaceOrder.Text = "Insert Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(477, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Total"
        '
        'lblNameProduct
        '
        Me.lblNameProduct.AutoSize = True
        Me.lblNameProduct.Location = New System.Drawing.Point(477, 331)
        Me.lblNameProduct.Name = "lblNameProduct"
        Me.lblNameProduct.Size = New System.Drawing.Size(56, 13)
        Me.lblNameProduct.TabIndex = 75
        Me.lblNameProduct.Text = "Product Id"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(477, 406)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 74
        Me.lblPrice.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(477, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Quantity"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(601, 292)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 72
        '
        'txtOrderId
        '
        Me.txtOrderId.Location = New System.Drawing.Point(601, 179)
        Me.txtOrderId.Name = "txtOrderId"
        Me.txtOrderId.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderId.TabIndex = 71
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(477, 292)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(59, 13)
        Me.lblOrderDate.TabIndex = 70
        Me.lblOrderDate.Text = "Order Date"
        '
        'lblOderId
        '
        Me.lblOderId.AutoSize = True
        Me.lblOderId.Location = New System.Drawing.Point(478, 179)
        Me.lblOderId.Name = "lblOderId"
        Me.lblOderId.Size = New System.Drawing.Size(45, 13)
        Me.lblOderId.TabIndex = 69
        Me.lblOderId.Text = "Order Id"
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(478, 246)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(63, 13)
        Me.lblCustomerId.TabIndex = 68
        Me.lblCustomerId.Text = "Customer Id"
        '
        'dgvOrders
        '
        Me.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Location = New System.Drawing.Point(841, 369)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrders.Size = New System.Drawing.Size(527, 183)
        Me.dgvOrders.TabIndex = 86
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(601, 441)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 87
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(731, 406)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(11, 13)
        Me.lblTotal.TabIndex = 89
        Me.lblTotal.Text = "*"
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
        Me.btnCalculateTotal.Location = New System.Drawing.Point(717, 374)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(118, 29)
        Me.btnCalculateTotal.TabIndex = 90
        Me.btnCalculateTotal.Text = "Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1162, 593)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Total"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(1242, 593)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(11, 13)
        Me.lblTotalAmount.TabIndex = 92
        Me.lblTotalAmount.Text = "*"
        '
        'frmPlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 709)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cboProductId)
        Me.Controls.Add(Me.cboCustomerId)
        Me.Controls.Add(Me.btnFinishOrder)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNameProduct)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtOrderId)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblOderId)
        Me.Controls.Add(Me.lblCustomerId)
        Me.Name = "frmPlaceOrder"
        Me.Text = "frmPlaceOrder"
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnUpdate As Button
    Friend WithEvents cboProductId As ComboBox
    Friend WithEvents cboCustomerId As ComboBox
    Private WithEvents btnFinishOrder As Button
    Private WithEvents btnDelete As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Private WithEvents btnPlaceOrder As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNameProduct As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtOrderId As TextBox
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents lblOderId As Label
    Friend WithEvents lblCustomerId As Label
    Private WithEvents dgvOrders As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Private WithEvents btnCalculateTotal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalAmount As Label
End Class
