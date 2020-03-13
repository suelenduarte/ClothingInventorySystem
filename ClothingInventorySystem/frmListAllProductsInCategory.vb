'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: List all products in data grid view by searching by category

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmListAllProductsInCategory

    'Module level Object for class Category
    Dim lstCategory As New BindingList(Of clsCategory)

    Private Sub SearchByCategory(valueToSearch As String)
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a string to search products by category
        Dim searchQuery As String = "Select productId, name, description, price, quantity from Product WHERE categoryName like '%" & valueToSearch & "%'"

        'Create a command object
        'pass the string and database connection
        Dim command As New SqlCommand(searchQuery, dbConnection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        dgvCategory.DataSource = table

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub DisplayCategories()
        'Populate List box of Category
        'Clear ListBox
        lstCategory.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Select categories
        Dim cmdSelect As String = "Select * from Category"

        'Create a command object
        'pass the string and database connection
        Dim command As New SqlCommand(cmdSelect, dbConnection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        cboCategories.DataSource = table
        cboCategories.DisplayMember = "categoryName"

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub


    Private Sub frmListAllProductsInCategory_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayCategories()
    End Sub

    Private Sub cboCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategories.SelectedIndexChanged
        SearchByCategory(cboCategories.Text)
    End Sub

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
End Class