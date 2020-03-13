'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: This form searches products by name 

Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class frmFindProduct

    Private Sub SearchByProductName(valueToSearch As String)
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a string to search by product name
        Dim searchQuery As String = "Select * from Product WHERE name like '%" & valueToSearch & "%'"

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
    Private Sub btnSearchProducts_Click(sender As Object, e As EventArgs) Handles btnSearchProducts.Click
        'Pass the text box as parameter
        SearchByProductName(txtSearchByProductName.Text)
    End Sub

    Private Sub frmFindProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the product data with all rows
        SearchByProductName("")
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