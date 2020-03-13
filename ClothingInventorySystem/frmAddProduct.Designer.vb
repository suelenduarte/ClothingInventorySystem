<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProduct
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
        Me.lblNameProduct = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtNameProduct = New System.Windows.Forms.TextBox()
        Me.txtDescriptionProduct = New System.Windows.Forms.TextBox()
        Me.txtQuantityProduct = New System.Windows.Forms.TextBox()
        Me.txtPriceProduct = New System.Windows.Forms.TextBox()
        Me.cboCategoryInProduct = New System.Windows.Forms.ComboBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnAddNewCategory = New System.Windows.Forms.Button()
        Me.lbxProduct = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.OpenFileDialogImage = New System.Windows.Forms.OpenFileDialog()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNameProduct
        '
        Me.lblNameProduct.AutoSize = True
        Me.lblNameProduct.Location = New System.Drawing.Point(54, 75)
        Me.lblNameProduct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameProduct.Name = "lblNameProduct"
        Me.lblNameProduct.Size = New System.Drawing.Size(51, 20)
        Me.lblNameProduct.TabIndex = 0
        Me.lblNameProduct.Text = "Name"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(54, 131)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(89, 20)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Description"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(54, 230)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(54, 295)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(49, 406)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(73, 20)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "Category"
        '
        'txtNameProduct
        '
        Me.txtNameProduct.Location = New System.Drawing.Point(195, 71)
        Me.txtNameProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNameProduct.Name = "txtNameProduct"
        Me.txtNameProduct.Size = New System.Drawing.Size(388, 26)
        Me.txtNameProduct.TabIndex = 6
        '
        'txtDescriptionProduct
        '
        Me.txtDescriptionProduct.Location = New System.Drawing.Point(195, 126)
        Me.txtDescriptionProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescriptionProduct.Multiline = True
        Me.txtDescriptionProduct.Name = "txtDescriptionProduct"
        Me.txtDescriptionProduct.Size = New System.Drawing.Size(388, 73)
        Me.txtDescriptionProduct.TabIndex = 7
        '
        'txtQuantityProduct
        '
        Me.txtQuantityProduct.Location = New System.Drawing.Point(195, 224)
        Me.txtQuantityProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQuantityProduct.Name = "txtQuantityProduct"
        Me.txtQuantityProduct.Size = New System.Drawing.Size(182, 26)
        Me.txtQuantityProduct.TabIndex = 8
        '
        'txtPriceProduct
        '
        Me.txtPriceProduct.Location = New System.Drawing.Point(195, 291)
        Me.txtPriceProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPriceProduct.Name = "txtPriceProduct"
        Me.txtPriceProduct.Size = New System.Drawing.Size(182, 26)
        Me.txtPriceProduct.TabIndex = 9
        '
        'cboCategoryInProduct
        '
        Me.cboCategoryInProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoryInProduct.FormattingEnabled = True
        Me.cboCategoryInProduct.Location = New System.Drawing.Point(195, 398)
        Me.cboCategoryInProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCategoryInProduct.Name = "cboCategoryInProduct"
        Me.cboCategoryInProduct.Size = New System.Drawing.Size(388, 28)
        Me.cboCategoryInProduct.TabIndex = 10
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Location = New System.Drawing.Point(195, 488)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(149, 35)
        Me.btnAddProduct.TabIndex = 13
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'btnAddNewCategory
        '
        Me.btnAddNewCategory.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAddNewCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewCategory.ForeColor = System.Drawing.Color.White
        Me.btnAddNewCategory.Location = New System.Drawing.Point(264, 342)
        Me.btnAddNewCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddNewCategory.Name = "btnAddNewCategory"
        Me.btnAddNewCategory.Size = New System.Drawing.Size(168, 35)
        Me.btnAddNewCategory.TabIndex = 15
        Me.btnAddNewCategory.Text = "Add Category"
        Me.btnAddNewCategory.UseVisualStyleBackColor = False
        '
        'lbxProduct
        '
        Me.lbxProduct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbxProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxProduct.ForeColor = System.Drawing.Color.White
        Me.lbxProduct.FormattingEnabled = True
        Me.lbxProduct.ItemHeight = 20
        Me.lbxProduct.Location = New System.Drawing.Point(660, 71)
        Me.lbxProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbxProduct.Name = "lbxProduct"
        Me.lbxProduct.Size = New System.Drawing.Size(264, 324)
        Me.lbxProduct.TabIndex = 16
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(660, 488)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(142, 35)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete Product"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(414, 488)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(169, 35)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update Product"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'OpenFileDialogImage
        '
        Me.OpenFileDialogImage.FileName = "OpenFileDialogImage"
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(660, 35)
        Me.txtProductId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(37, 26)
        Me.txtProductId.TabIndex = 19
        '
        'frmAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(950, 755)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbxProduct)
        Me.Controls.Add(Me.btnAddNewCategory)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.cboCategoryInProduct)
        Me.Controls.Add(Me.txtPriceProduct)
        Me.Controls.Add(Me.txtQuantityProduct)
        Me.Controls.Add(Me.txtDescriptionProduct)
        Me.Controls.Add(Me.txtNameProduct)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblNameProduct)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddProduct"
        Me.Text = "Add Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameProduct As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtNameProduct As TextBox
    Friend WithEvents txtDescriptionProduct As TextBox
    Friend WithEvents txtQuantityProduct As TextBox
    Friend WithEvents txtPriceProduct As TextBox
    Friend WithEvents cboCategoryInProduct As ComboBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnAddNewCategory As Button
    Friend WithEvents lbxProduct As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents OpenFileDialogImage As OpenFileDialog
    Friend WithEvents txtProductId As TextBox
End Class
