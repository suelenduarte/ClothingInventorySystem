'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Add new categories

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmAddCategory

    'Module level Object for class Category
    Dim lstCategory As New BindingList(Of clsCategory)

    'Instantiate a new Category
    Dim objCategory As New clsCategory()

    Private Sub Reload_Category()
        'Clear ListBox
        lstCategory.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("Select * from Category;", dbConnection)

        'Execute command into a database
        Dim rdrCategory As SqlDataReader = cmdSelect.ExecuteReader

        If rdrCategory.HasRows Then
            While rdrCategory.Read
                Dim objStoredCategory As New clsCategory()
                objStoredCategory.categoryId = rdrCategory.Item("categoryId").ToString
                objStoredCategory.categoryName = rdrCategory.Item("categoryName").ToString
                objStoredCategory.categoryDescription = rdrCategory.Item("categoryDescription").ToString

                lstCategory.Add(objStoredCategory)

            End While
        End If

        'Select the first category name when loads the application
        SelectedCategoryRecord()

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub


    Public Sub InsertCategory()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Insert into Category (categoryName,categoryDescription) values (@categoryName,@categoryDescription)"

        'Create command
        Dim cmdInsert As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the insert
        cmdInsert.Parameters.AddWithValue("categoryName", lstCategory.Last.categoryName)
        cmdInsert.Parameters.AddWithValue("categoryDescription", lstCategory.Last.categoryDescription)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstCategory.Last.categoryName & " was inserted")

            Else
                MessageBox.Show("The insert failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Please insert all fields!")

        End Try

        Reload_Category()

        If lbxCategory.SelectedIndex >= 0 Then
            'This selects and highlights the last item in the list box
            [lbxCategory].SetSelected([lbxCategory].Items.Count - 1, True)

        End If
    End Sub

    Public Sub UpdateCategory()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Update category rows
        Dim strSql = "Update Category set categoryName='" & txtCategoryName.Text & "',categoryDescription='" & txtCategoryDescription.Text & "' WHERE categoryId = '" & txtCategoryId.Text & "'"

        MessageBox.Show(strSql)
        'Create command
        Dim cmdUpdate As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the update
        cmdUpdate.Parameters.AddWithValue("categoryName", lstCategory.Last.categoryName)
        cmdUpdate.Parameters.AddWithValue("categoryDescription", lstCategory.Last.categoryDescription)

        Try
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstCategory.Last.categoryId & " was updated")
            Else
                MessageBox.Show("The Update failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Update failed" & ex.Message)

        End Try

        Reload_Category()

    End Sub

    Public Sub DeleteCustomer()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Delete row
        Dim strSql = "Delete from Category Where categoryId = '" & txtCategoryId.Text & "'"
        MessageBox.Show(strSql)

        'Create command
        Dim cmdDelete As New SqlCommand(strSql, dbConnection)

        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show("Record was Deleted")
            Else
                MessageBox.Show("The Delete failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Delete failed" & ex.Message)

        End Try

        Reload_Category()

    End Sub

    Private Sub SelectedCategoryRecord()

        If lbxCategory.SelectedIndex >= 0 Then
            Dim objSelectedCategory As clsCategory = CType(lbxCategory.SelectedItem, clsCategory)
            txtCategoryId.Text = objSelectedCategory.categoryId.ToString
            txtCategoryName.Text = objSelectedCategory.categoryName
            txtCategoryDescription.Text = objSelectedCategory.categoryDescription

        End If
    End Sub

    'Delete Category
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteCustomer()
    End Sub

    'Update Category
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateCategory()
    End Sub

    Private Sub lbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCategory.SelectedIndexChanged
        SelectedCategoryRecord()
    End Sub


    Private Sub AddCategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate List box of Category
        lbxCategory.DataSource = lstCategory
        lbxCategory.DisplayMember = "categoryName"

        Reload_Category()
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        'Assign Category information from Form
        objCategory.categoryId = txtCategoryId.Text
        objCategory.categoryName = txtCategoryName.Text
        objCategory.categoryDescription = txtCategoryDescription.Text

        'Add Category object to list of Category's
        lstCategory.Add(objCategory)

        InsertCategory()

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