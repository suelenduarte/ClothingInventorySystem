'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: Manage user class

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmPlaceAnOrderToCart
    'Module level Object for class Category
    Dim lstCategory As New BindingList(Of clsCategory)

    Dim lstProduct As New BindingList(Of clsProduct)

    'Instantiate a new User
    Dim objCategory As New clsCategory()

    Dim objProduct As New clsProduct()

    Dim openDatabase As New clsDatabaseConnection()

    Private Function OpenDBConnection() As SqlConnection
        'Create a connection string
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)

        'Create a connection string
        Dim strConnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "InventorySystemDatabase.mdf"
        Dim dbConnection As New SqlConnection(strConnection)

        Try
            'Open Database
            dbConnection.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Return dbConnection
    End Function


    Private Sub DisplayCustomers()
        'Populate List box of User
        'Clear ListBox
        lstCategory.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As String = "Select * from Customers INNER JOIN Orders on Customers.customerId = Orders.customerId"

        'Create a command object
        'pass the string and database connection
        Dim command As New SqlCommand(cmdSelect, dbConnection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        dvgCustomers.DataSource = table


        'Select the first category name when loads the application

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub DisplayProducts()
        'Populate List box of User
        'Clear ListBox
        lstCategory.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As String = "Select * from Product"

        'Create a command object
        'pass the string and database connection
        Dim command As New SqlCommand(cmdSelect, dbConnection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        dvgProducts.DataSource = table


        'Select the first category name when loads the application

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub DisplayCategories()
        'Populate List box of User
        'Clear ListBox
        lstCategory.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As String = "Select * from Category"

        'Create a command object
        'pass the string and database connection
        Dim command As New SqlCommand(cmdSelect, dbConnection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        cboCategory.DataSource = table
        cboCategory.DisplayMember = "categoryName"



        'Select the first category name when loads the application

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub


    Private Sub SearchByCategory(valueToSearch As String)
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a string to search by last name
        Dim searchQuery As String = "Select * from Product WHERE categoryName like '%" & valueToSearch & "%'"

        'Create a command object
        'pass the string and database connection
        Dim command As New SqlCommand(searchQuery, dbConnection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        dvgProducts.DataSource = table

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub frmPlaceAnOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        DisplayCategories()
        DisplayCustomers()
        DisplayProducts()
    End Sub

    Private Sub btnQuantityOrder_Click(sender As Object, e As EventArgs) Handles btnQuantityOrder.Click
        Dim frmChooseQuantityOfProduct As New frmChooseQuantityOfProduct
        frmChooseQuantityOfProduct.ShowDialog()
    End Sub
    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        SearchByCategory(cboCategory.Text)
    End Sub

    Public Sub InsertOrder()

        'Populate List box of User
        'Clear ListBox
        lstCategory.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As String = "Select * from OrderDetail"

        'Create a command object
        'pass the string and database connection
        Dim command As New SqlCommand(cmdSelect, dbConnection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        dvgCustomersOrder.DataSource = table

        'Select the first category name when loads the application

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        InsertOrder()
    End Sub

    Private Sub dvgCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgCustomers.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow = dvgCustomers.Rows(index)
        selectedRow = dvgCustomers.Rows(index)
        txtCustomerId.Text = selectedRow.Cells(0).Value.ToString()
        txtOrderId.Text = selectedRow.Cells(5).Value.ToString()
        txtDate.Text = selectedRow.Cells(6).Value.ToString()

    End Sub
End Class