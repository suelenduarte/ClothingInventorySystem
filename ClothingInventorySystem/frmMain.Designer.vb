<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMainForm = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListProductsJnCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceAnOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNameStore = New System.Windows.Forms.Label()
        Me.lblInventorySystem = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mnuMainForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMainForm
        '
        Me.mnuMainForm.BackColor = System.Drawing.SystemColors.HighlightText
        Me.mnuMainForm.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.mnuMainForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.CategoriesToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.mnuMainForm.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainForm.Name = "mnuMainForm"
        Me.mnuMainForm.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.mnuMainForm.Size = New System.Drawing.Size(514, 29)
        Me.mnuMainForm.TabIndex = 0
        Me.mnuMainForm.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCustomerToolStripMenuItem, Me.ListAllCustomerToolStripMenuItem, Me.FindCustomerToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(91, 23)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'AddNewCustomerToolStripMenuItem
        '
        Me.AddNewCustomerToolStripMenuItem.Name = "AddNewCustomerToolStripMenuItem"
        Me.AddNewCustomerToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.AddNewCustomerToolStripMenuItem.Text = "Add New Customer"
        '
        'ListAllCustomerToolStripMenuItem
        '
        Me.ListAllCustomerToolStripMenuItem.Name = "ListAllCustomerToolStripMenuItem"
        Me.ListAllCustomerToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.ListAllCustomerToolStripMenuItem.Text = "List All Customers"
        '
        'FindCustomerToolStripMenuItem
        '
        Me.FindCustomerToolStripMenuItem.Name = "FindCustomerToolStripMenuItem"
        Me.FindCustomerToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.FindCustomerToolStripMenuItem.Text = "Find Customer"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProductToolStripMenuItem, Me.ListAllProductsToolStripMenuItem, Me.FindProductToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(80, 23)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.AddNewProductToolStripMenuItem.Text = "Add New Product"
        '
        'ListAllProductsToolStripMenuItem
        '
        Me.ListAllProductsToolStripMenuItem.Name = "ListAllProductsToolStripMenuItem"
        Me.ListAllProductsToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ListAllProductsToolStripMenuItem.Text = "List All Products"
        '
        'FindProductToolStripMenuItem
        '
        Me.FindProductToolStripMenuItem.Name = "FindProductToolStripMenuItem"
        Me.FindProductToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.FindProductToolStripMenuItem.Text = "Find Product"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCategoryToolStripMenuItem, Me.ListProductsJnCategoryToolStripMenuItem})
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(93, 23)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'AddNewCategoryToolStripMenuItem
        '
        Me.AddNewCategoryToolStripMenuItem.Name = "AddNewCategoryToolStripMenuItem"
        Me.AddNewCategoryToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.AddNewCategoryToolStripMenuItem.Text = "Add New Category"
        '
        'ListProductsJnCategoryToolStripMenuItem
        '
        Me.ListProductsJnCategoryToolStripMenuItem.Name = "ListProductsJnCategoryToolStripMenuItem"
        Me.ListProductsJnCategoryToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.ListProductsJnCategoryToolStripMenuItem.Text = "List All Products in Category"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaceAnOrderToolStripMenuItem, Me.PlaceOrderToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'PlaceAnOrderToolStripMenuItem
        '
        Me.PlaceAnOrderToolStripMenuItem.Name = "PlaceAnOrderToolStripMenuItem"
        Me.PlaceAnOrderToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.PlaceAnOrderToolStripMenuItem.Text = "Place An Order"
        '
        'PlaceOrderToolStripMenuItem
        '
        Me.PlaceOrderToolStripMenuItem.Name = "PlaceOrderToolStripMenuItem"
        Me.PlaceOrderToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.PlaceOrderToolStripMenuItem.Text = "Place Order"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewUserToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(57, 23)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'AddNewUserToolStripMenuItem
        '
        Me.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem"
        Me.AddNewUserToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.AddNewUserToolStripMenuItem.Text = "Add New User"
        '
        'lblNameStore
        '
        Me.lblNameStore.AutoSize = True
        Me.lblNameStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameStore.Location = New System.Drawing.Point(100, 22)
        Me.lblNameStore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameStore.Name = "lblNameStore"
        Me.lblNameStore.Size = New System.Drawing.Size(188, 29)
        Me.lblNameStore.TabIndex = 1
        Me.lblNameStore.Text = "Sue's Boutique"
        '
        'lblInventorySystem
        '
        Me.lblInventorySystem.AutoSize = True
        Me.lblInventorySystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventorySystem.Location = New System.Drawing.Point(179, 238)
        Me.lblInventorySystem.Name = "lblInventorySystem"
        Me.lblInventorySystem.Size = New System.Drawing.Size(140, 17)
        Me.lblInventorySystem.TabIndex = 2
        Me.lblInventorySystem.Text = "Inventory System 1.0"
        Me.lblInventorySystem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(60, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 115)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblNameStore)
        Me.Panel2.Location = New System.Drawing.Point(13, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 80)
        Me.Panel2.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(514, 281)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblInventorySystem)
        Me.Controls.Add(Me.mnuMainForm)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuMainForm
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clothing Inventory System"
        Me.mnuMainForm.ResumeLayout(False)
        Me.mnuMainForm.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainForm As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListAllCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListAllProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListProductsJnCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNameStore As Label
    Friend WithEvents lblInventorySystem As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PlaceAnOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaceOrderToolStripMenuItem As ToolStripMenuItem
End Class
