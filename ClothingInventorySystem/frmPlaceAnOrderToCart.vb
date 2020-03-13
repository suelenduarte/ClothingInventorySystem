'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: Place order form

Option Strict On
Option Explicit On

Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmPlaceAnOrderToCart
    Dim table As New DataTable("OrderDetail")
    Dim index As Integer
    'Module level Object for class Category

    Dim lstCustomer As New BindingList(Of clsCustomer)
    Dim lstProduct As New BindingList(Of clsProduct)
    Dim lstOrderDetail As New BindingList(Of clsOrderDetail)
    'Instantiate a new User
    Dim objSelectedUser As clsOrderDetail


    Dim objOrderDetail As New clsOrderDetail()



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

    Private Sub CalculatePrice(ByVal decPrice As Decimal, ByVal decQuantity As Decimal, ByRef totalPrice As Decimal)
        totalPrice = (decPrice * decQuantity)
    End Sub

    Public Sub InsertOrder()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Insert into OrderDetail (productId,orderQuantity,orderPrice,totalPrice,orderDate,customerId) values (@productId,@orderQuantity,@orderPrice,@totalPrice,@orderDate,@customerId)"

        'Create command
        Dim cmdInsert As New SqlCommand(strSql, dbConnection)

        'Dim memoryStream As New MemoryStream
        'picProduct.Image.Save(memoryStream, picProduct.Image.RawFormat)

        'Populate parameters of the insert
        cmdInsert.Parameters.AddWithValue("productId", lstOrderDetail.Last.ProductId)
        cmdInsert.Parameters.AddWithValue("orderQuantity", lstOrderDetail.Last.Order_Quantity)
        cmdInsert.Parameters.AddWithValue("orderPrice", lstOrderDetail.Last.Order_Price)
        cmdInsert.Parameters.AddWithValue("totalPrice", lstOrderDetail.Last.Total_Price)
        cmdInsert.Parameters.AddWithValue("orderDate", lstOrderDetail.Last.Order_Date)
        cmdInsert.Parameters.AddWithValue("customerId", lstOrderDetail.Last.CustomerId)

        'Dim a As Image = picProduct.Image
        'a.Save(pathString)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                ' Reload_Product()
                MessageBox.Show(lstOrderDetail.Last.ProductId & " was inserted")

            Else
                MessageBox.Show("The insert failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Please insert all fields!")

        End Try

        'Reload_Product()

    End Sub

    Private Sub DisplayCustomer()
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object to read from Category Database
        Dim cmdSelects As New SqlCommand("Select * from Customers;", dbConnection)

        'Execute command into a database
        Dim rdrUsers As SqlDataReader = cmdSelects.ExecuteReader

        If rdrUsers.HasRows Then
            While rdrUsers.Read
                Dim objStoredProductt As New clsCustomer()
                objStoredProductt.customerId = rdrUsers.Item("customerId").ToString

                cboCustomerId.DataSource = lstCustomer
                cboCustomerId.DisplayMember = "customerId"
                lstCustomer.Add(objStoredProductt)

            End While
        End If

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub DisplayProduct()

        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object to read from Category Database
        Dim cmdSelects As New SqlCommand("Select * from Product;", dbConnection)

        'Execute command into a database
        Dim rdrUsers As SqlDataReader = cmdSelects.ExecuteReader

        If rdrUsers.HasRows Then
            While rdrUsers.Read
                Dim objStoredProductt As New clsProduct()
                objStoredProductt.productId = rdrUsers.Item("productId").ToString

                cboProductId.DataSource = lstProduct
                cboProductId.DisplayMember = "productId"
                lstProduct.Add(objStoredProductt)

            End While
        End If

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub



    Private Sub DisplayCustomers()
        'Populate List box of User
        'Clear ListBox
        ' lstCategory.Clear()

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
        dgvCustomers.DataSource = table


        'Select the first category name when loads the application

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub DisplayProducts()
        'Populate List box of User
        'Clear ListBox
        'lstCategory.Clear()

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
        dgvProducts.DataSource = table


        'Select the first category name when loads the application

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub DisplayCategories()
        'Populate List box of User
        'Clear ListBox
        'lstCategory.Clear()

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
        cboCategories.DataSource = table
        cboCategories.DisplayMember = "categoryName"



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
        dgvProducts.DataSource = table

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub







    'Dim table As New DataTable("OrderDetail")



    Private Sub frmPlaceAnOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate List box of User
        'lbxOrder.DataSource = lstOrderDetail
        'lbxOrder.DisplayMember = "customerId"
        'table.Columns.Add("orderDetailId", Type.GetType("System.Int32"))
        table.Columns.Add("costumerId", Type.GetType("System.Int32"))
        table.Columns.Add("orderDate", Type.GetType("System.String"))
        table.Columns.Add("productId", Type.GetType("System.Int32"))
        table.Columns.Add("orderQuantity", Type.GetType("System.Int32"))
        table.Columns.Add("orderPrice", Type.GetType("System.String"))



        table.Columns.Add("totalPrice", Type.GetType("System.String"))



        'table.Rows.Add(1, 1, "1", 1, 1, 1)

        DisplayCustomer()
        DisplayProduct()
        'picProduct.ToString()
        'Select the first category name when loads the application
        'SelectedCategoryRecord()


        '  Reload_Product()
        DisplayCategories()
        DisplayCustomers()
        DisplayProducts()

        'Reload_Product()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategories.SelectedIndexChanged
        SearchByCategory(cboCategories.Text)
    End Sub

    Private Sub Calculate()

        'Make the new User the Selected User

        objSelectedUser = objOrderDetail
        'Select the current User in the listbox
        '   lbxOrder.SelectedItem = objOrderDetail
        'Reload_Product()

    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        'Add user object to list of Products'

        Dim blnPrice As Boolean
        Dim blnQuantity As Boolean
        ' Dim blnTotal As Boolean
        ' Dim blnDate As Boolean
        Dim price As Decimal
        Dim quantity As Decimal
        ' Dim total As Decimal
        'Dim strDate As Date

        If txtDate.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please, fill out all required fields!")


            ' blnTotal = Decimal.TryParse(txtTotal.Text, total)
            'blnTotal = Date.TryParse(txtTotal.Text, strDate)
            blnPrice = Decimal.TryParse(txtPrice.Text, price)
            blnQuantity = Decimal.TryParse(txtQuantity.Text, quantity)

            If blnPrice = False And txtPrice.Text IsNot "" Or blnQuantity = False And txtQuantity.Text IsNot "" Then
                MessageBox.Show("Quantity and price must be numbers!")



            Else
                'Assign Category information from Form

                Calculate()

                table.Rows.Add(cboCustomerId.Text, txtDate.Text, cboProductId.Text, txtQuantity.Text, txtPrice.Text, txtTotal.Text)
                dgvOrders.DataSource = table




                InsertOrder()
                dgvOrders.DataSource = table
                'dgvOrders.Rows.Add(cboCustomerId.Text, txtDate.Text, cboProductId.Text, txtQuantity.Text, txtPrice.Text, txtTotal.Text)
                Dim sum As Decimal = 0
                For i = 0 To dgvOrders.Rows.Count - 1
                    sum += CType(dgvOrders.Rows(i).Cells(5).Value, Decimal)

                Next

                lblTotalAmount.Text = CType(sum, String)

            End If

        End If


        'UpdateProduct()
    End Sub


    Private Sub dgvOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellContentClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvOrders.Rows(index)

        'If lbxOrder.SelectedIndex >= 0 Then
        'Dim objSelectedProduct As clsOrderDetail = CType(lbxOrder.SelectedItem, clsOrderDetail)
        'Dim objSelectedCategory As clsCategory = CType(lbxCategory.SelectedItem, clsCategory)
        'change

        If e.RowIndex >= 0 Then
            '   txtOrderId.Text = selectedRow.Cells(0).Value.ToString()
            cboProductId.Text = selectedRow.Cells(0).Value.ToString()
            txtQuantity.Text = selectedRow.Cells(1).Value.ToString()
            txtPrice.Text = selectedRow.Cells(2).Value.ToString()
            txtTotal.Text = selectedRow.Cells(3).Value.ToString()

            txtDate.Text = selectedRow.Cells(4).Value.ToString()
            cboCustomerId.Text = selectedRow.Cells(5).Value.ToString()
        End If



        '  End If
    End Sub

    Private Sub btnFinishOrder_Click(sender As Object, e As EventArgs) Handles btnFinishOrder.Click
        ' get the user Desktop Path
        Dim DesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        ' Printed_Order.pdf is the name of the generated file
        Dim fs As FileStream = New FileStream(DesktopPath & "\Order7Printed.pdf", FileMode.Create)

        Dim document As Document = New Document(PageSize.A4, 25, 25, 30, 30)
        Dim writer As PdfWriter = PdfWriter.GetInstance(document, fs)
        document.AddAuthor("Suelen Duarte")
        document.AddCreator("Clothing Inventory Management System")
        document.AddKeywords("Order")
        document.AddSubject("Customer Order")
        document.AddTitle("Order Details")
        ' Open the document to enable you to write to the document
        document.Open()
        Dim table As PdfPTable = New PdfPTable(6)
        Dim SelectedOrderDetails As DataTable = New DataTable
        Dim totalOrderAmount As String = lblTotalAmount.Text
        ' Dim orderId As String = dgvOrders.CurrentRow.Cells(0).Value.ToString
        Dim customerId As String = dgvOrders.CurrentRow.Cells(0).Value.ToString
        Dim productId As String = dgvOrders.CurrentRow.Cells(2).Value.ToString
        Dim quantity As String = dgvOrders.CurrentRow.Cells(3).Value.ToString
        Dim price As String = dgvOrders.CurrentRow.Cells(4).Value.ToString
        Dim orderDate As Date = CType(dgvOrders.CurrentRow.Cells(1).Value.ToString(), Date)
        Dim orderDateString As String = orderDate.Date.ToString("MM/dd/yyyy")
        '  SelectedOrderDetails = dgvOrders.CurrentRow.Cells(0).Value.ToString

        Dim cellHeader As PdfPCell = New PdfPCell(New Phrase(("Order " _
                            + (" Details"))))
        cellHeader.Colspan = 6
        cellHeader.HorizontalAlignment = Element.ALIGN_CENTER
        cellHeader.ExtraParagraphSpace = 20
        cellHeader.BorderColor = BaseColor.BLUE
        table.AddCell(cellHeader)


        table.AddCell("Costumer Id")
        table.AddCell("Order Date")
        table.AddCell("Product Id")
        table.AddCell("Quantity")
        table.AddCell("Price")
        table.AddCell("Total Price")

        Dim i As Integer = 0
        Do While (i < dgvOrders.Rows.Count - 1)
            table.AddCell(dgvOrders.Rows(i).Cells(0).Value.ToString)
            table.AddCell(dgvOrders.Rows(i).Cells(1).Value.ToString)
            table.AddCell(dgvOrders.Rows(i).Cells(2).Value.ToString)
            table.AddCell(dgvOrders.Rows(i).Cells(3).Value.ToString)
            table.AddCell(dgvOrders.Rows(i).Cells(4).Value.ToString)
            table.AddCell(dgvOrders.Rows(i).Cells(5).Value.ToString)

            i = (i + 1)
        Loop


        '  Dim custFullName As String = (DGV_ALL_ORDERS.CurrentRow.Cells(1).Value.ToString + (" " + DGV_ALL_ORDERS.CurrentRow.Cells(2).Value.ToString))

        Dim prg As New Paragraph("Order Date: " + orderDateString + vbNewLine + "Customer : " + customerId + vbNewLine + vbNewLine)

        Dim cellAmount As PdfPCell = New PdfPCell(New Phrase(("Total Amount : " + totalOrderAmount)))
        cellAmount.HorizontalAlignment = 2
        cellAmount.Colspan = 6
        document.Add(prg)
        table.AddCell(cellAmount)
        document.Add(table)
        'document.Add(prg);
        ' Close the document
        document.Close()
        ' Close the writer instance
        writer.Close()
        ' Always close open filehandles explicity
        fs.Close()
        MessageBox.Show("Report Generated Successfully")
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim blnPrice As Boolean
        Dim blnQuantity As Boolean
        Dim blnTotal As Boolean
        ' Dim blnDate As Boolean
        Dim price As Decimal
        Dim quantity As Decimal
        Dim total As Decimal
        'Dim strDate As Date


        'blnTotal = Decimal.TryParse(txtTotal.Text, total)
        'blnTotal = Date.TryParse(txtTotal.Text, strDate)

        If txtDate.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please, fill out all required fields!")
        Else

            blnPrice = Decimal.TryParse(txtPrice.Text, price)
            blnQuantity = Decimal.TryParse(txtQuantity.Text, quantity)

            If blnPrice = False And txtPrice.Text IsNot "" Or blnQuantity = False And txtQuantity.Text IsNot "" Then
                MessageBox.Show("Quantity and price must be numbers!")

            Else
                'Assign Category information from Form
                objOrderDetail.ProductId = CInt(cboProductId.Text)
                objOrderDetail.Order_Quantity = quantity
                objOrderDetail.Order_Price = price
                objOrderDetail.Total_Price = total
                objOrderDetail.Order_Date = txtDate.Text
                objOrderDetail.CustomerId = CInt(cboCustomerId.Text)


                Call CalculatePrice(price, quantity, objOrderDetail.Total_Price)
                lblTotalAmount.Text = objOrderDetail.Total_Price.ToString
                txtTotal.Text = lblTotalAmount.Text
            End If

        End If
    End Sub


End Class

