'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Add new products

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class frmAddProduct

    'Module level Object for class Product
    Dim lstProduct As New BindingList(Of clsProduct)

    'Module level Object for class Category
    Dim lstCategory As New BindingList(Of clsCategory)

    'Instantiate a new Product
    Dim objProduct As New clsProduct()

    Private Sub Reload_Product()
        'Clear ListBox
        lstProduct.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        'Where categoryName from Product and categoryName from Category databases are set to equal
        Dim cmdSelect As New SqlCommand("Select Product.productId,Product.name,Category.categoryName,Product.description,Product.price,Product.quantity,Category.categoryId,Category.categoryName from Product LEFT JOIN Category On Product.categoryName = Category.categoryName;", dbConnection)

        'Execute command into a database
        Dim rdrProduct As SqlDataReader = cmdSelect.ExecuteReader

        If rdrProduct.HasRows Then
            While rdrProduct.Read
                Dim objStoredProduct As New clsProduct()
                objStoredProduct.productId = rdrProduct.Item("productId").ToString
                objStoredProduct.name = rdrProduct.Item("name").ToString
                objStoredProduct.description = rdrProduct.Item("description").ToString
                objStoredProduct.price = CDec(rdrProduct.Item("price").ToString)
                objStoredProduct.quantity = CInt(rdrProduct.Item("quantity").ToString)
                objStoredProduct.CategoryName = rdrProduct.Item("categoryName").ToString
                lstProduct.Add(objStoredProduct)

            End While
        End If

        'Select the first category name when loads the application
        SelectedProductRecord()

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub


    Public Sub InsertProduct()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String to insert fields to database
        Dim strSql = "Insert into Product (categoryName,name,description,price,quantity) values (@categoryName,@name,@description,@price,@quantity)"

        'Create command
        Dim cmdInsert As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the insert
        cmdInsert.Parameters.AddWithValue("categoryName", lstProduct.Last.CategoryName)
        cmdInsert.Parameters.AddWithValue("name", lstProduct.Last.name)
        cmdInsert.Parameters.AddWithValue("description", lstProduct.Last.description)
        cmdInsert.Parameters.AddWithValue("price", lstProduct.Last.price)
        cmdInsert.Parameters.AddWithValue("quantity", lstProduct.Last.quantity)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then

                MessageBox.Show(lstProduct.Last.name & " was inserted")

            Else
                MessageBox.Show("The insert failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Please insert all fields!")

        End Try

        Reload_Product()
        If lbxProduct.SelectedIndex >= 0 Then
            'This selects and highlights the last item in the list box
            [lbxProduct].SetSelected([lbxProduct].Items.Count - 1, True)

        End If
    End Sub

    Public Sub UpdateProduct()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String to update fields
        Dim strSql = "Update Product set categoryName='" & cboCategoryInProduct.Text & "',name='" & txtNameProduct.Text & "',description='" & txtDescriptionProduct.Text & "',price='" & txtPriceProduct.Text & "',quantity='" & txtQuantityProduct.Text & "' WHERE productId = '" & txtProductId.Text & "'"

        MessageBox.Show(strSql)

        'Create command
        Dim cmdUpdate As New SqlCommand(strSql, dbConnection)
        Dim memoryStreams As New MemoryStream

        cmdUpdate.Parameters.AddWithValue("categoryName", lstCategory.Last.categoryName)
        cmdUpdate.Parameters.AddWithValue("name", lstProduct.Last.name)
        cmdUpdate.Parameters.AddWithValue("description", lstProduct.Last.description)
        cmdUpdate.Parameters.AddWithValue("price", lstProduct.Last.price)
        cmdUpdate.Parameters.AddWithValue("quantity", lstProduct.Last.quantity)

        Try
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstProduct.Last.categoryId & " was updated")
            Else
                MessageBox.Show("The Update failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Update failed" & ex.Message)

        End Try

        Reload_Product()

    End Sub

    Public Sub DeleteProduct()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Delete selected row
        Dim strSql = "Delete from Product Where productId = '" & txtProductId.Text & "'"

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

        Reload_Product()

    End Sub

    Private Sub SelectedProductRecord()

        If lbxProduct.SelectedIndex >= 0 Then
            Dim objSelectedProduct As clsProduct = CType(lbxProduct.SelectedItem, clsProduct)
            cboCategoryInProduct.Text = objSelectedProduct.CategoryName.ToString
            txtNameProduct.Text = objSelectedProduct.name
            txtDescriptionProduct.Text = objSelectedProduct.description
            txtPriceProduct.Text = CType(objSelectedProduct.price, String)
            txtQuantityProduct.Text = CType(objSelectedProduct.quantity, String)
            txtProductId.Text = CType(objSelectedProduct.productId, String)

        End If

    End Sub

    'Delete Product information
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteProduct()
    End Sub

    'Update Product information
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateProduct()
    End Sub

    Private Sub lbxProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxProduct.SelectedIndexChanged
        SelectedProductRecord()
    End Sub

    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate List box of Products
        lbxProduct.DataSource = lstProduct
        lbxProduct.DisplayMember = "name"

        'Clear ListBox
        lstCategory.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object to read from Category Database
        Dim cmdSelect As New SqlCommand("Select * from Category;", dbConnection)

        'Execute command into a database
        Dim rdrUser As SqlDataReader = cmdSelect.ExecuteReader

        'Populate the combobox with the category name from Category table
        If rdrUser.HasRows Then
            While rdrUser.Read
                Dim objStoredProduct As New clsCategory()
                objStoredProduct.categoryId = rdrUser.Item("categoryId").ToString
                objStoredProduct.categoryName = rdrUser.Item("categoryName").ToString
                objStoredProduct.categoryDescription = rdrUser.Item("categoryDescription").ToString
                cboCategoryInProduct.DataSource = lstCategory
                cboCategoryInProduct.DisplayMember = "categoryName"
                lstCategory.Add(objStoredProduct)

            End While
        End If


        SelectedProductRecord()

        Reload_Product()

    End Sub

    Private Sub ProductInformation()

        Dim blnPrice As Boolean
        Dim blnQuantity As Boolean
        Dim intPrice As Decimal
        Dim intQuantity As Decimal

        If txtNameProduct.Text = "" Or txtDescriptionProduct.Text = "" Or txtQuantityProduct.Text = "" Or txtPriceProduct.Text = "" Then
            MessageBox.Show("Please, fill out all required fields!")
        Else

            blnPrice = Decimal.TryParse(txtPriceProduct.Text, intPrice)
            blnQuantity = Decimal.TryParse(txtQuantityProduct.Text, intQuantity)

            If blnPrice = False And txtPriceProduct.Text IsNot "" Or blnQuantity = False And txtQuantityProduct.Text IsNot "" Then
                MessageBox.Show("Please, enter integer numbers for price and quantity!")

            Else


                'Assign Product information from Form
                objProduct.CategoryName = cboCategoryInProduct.Text
                objProduct.name = txtNameProduct.Text
                objProduct.description = txtDescriptionProduct.Text
                objProduct.productId = txtProductId.Text
                objProduct.price = CInt(txtPriceProduct.Text)
                objProduct.quantity = CInt(txtQuantityProduct.Text)
            End If
        End If

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

        'Add product object to list of Products'
        lstProduct.Add(objProduct)

        ProductInformation()

        InsertProduct()

        ' SelectedProductRecord()

    End Sub

    'Show add new category form
    Private Sub btnAddNewCategory_Click(sender As Object, e As EventArgs) Handles btnAddNewCategory.Click
        Dim form As New frmAddCategory
        form.ShowDialog()
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