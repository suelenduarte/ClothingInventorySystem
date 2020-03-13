'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Manage Main form 

Option Strict On
Option Explicit On

Public Class frmMain
    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem.Click
        'Create an instance of the Add Product form
        Dim frmAddProduct As New frmAddProduct

        'Display the AddProduct Form
        frmAddProduct.ShowDialog()
    End Sub

    Private Sub AddNewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCustomerToolStripMenuItem.Click
        'Create an instance of the Add Customer form
        Dim frmAddCustomer As New frmAddCustomer

        'Display the Add Customer Form
        frmAddCustomer.ShowDialog()
    End Sub

    Private Sub AddNewCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCategoryToolStripMenuItem.Click
        'Create an instance of the Add Category form
        Dim frmAddCategory As New frmAddCategory

        'Display the Add Category Form
        frmAddCategory.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close form
        Me.Close()
    End Sub

    Private Sub ListAllCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllCustomerToolStripMenuItem.Click
        'Create an instance of the List All Customer form
        Dim frmListAllCustomers As New frmListAllCustomers

        'Display the List All Customer Form
        frmListAllCustomers.ShowDialog()
    End Sub

    Private Sub FindCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindCustomerToolStripMenuItem.Click
        'Create an instance of the Find Customer form
        Dim frmFindCustomer As New frmFindCustomer

        'Display the Find Customer Form
        frmFindCustomer.ShowDialog()
    End Sub

    Private Sub ListAllProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllProductsToolStripMenuItem.Click
        'Create an instance of the List All Products form
        Dim frmListProducts As New frmListAllProducts

        'Display the List All Products Form
        frmListAllProducts.ShowDialog()
    End Sub

    Private Sub FindProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindProductToolStripMenuItem.Click
        'Create an instance of the Find Product form
        Dim frmFindProduct As New frmFindProduct

        'Display the Find Product Form
        frmFindProduct.ShowDialog()
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem.Click
        'Create an instance of the Add New User form
        Dim frmAddUser As New frmAddUser

        'Display the Add New User Form
        frmAddUser.ShowDialog()
    End Sub

    Private Sub ListProductsJnCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListProductsJnCategoryToolStripMenuItem.Click
        'Create an instance of the List Products In Category form
        Dim frmListProductsInCategory As New frmListAllProductsInCategory

        'Display the List Products In Category Form
        frmListProductsInCategory.ShowDialog()
    End Sub

    Private Sub PlaceAnOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaceAnOrderToolStripMenuItem.Click
        'Create an instance of the Place An Order form
        Dim frmPlaceAnOrder As New frmPlaceAnOrderToCart

        'Display the Place An Order Form
        frmPlaceAnOrder.ShowDialog()
    End Sub

    Private Sub PlaceOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaceOrderToolStripMenuItem.Click
        'Create an instance of the Place An Order form
        Dim frmPlaceAnOrder As New frmPlaceOrder

        'Display the Place An Order Form
        frmPlaceAnOrder.ShowDialog()
    End Sub


End Class
