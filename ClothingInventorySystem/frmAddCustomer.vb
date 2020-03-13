'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Add new customers 

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmAddCustomer

    'Module level Object for class Customer
    Dim lstCustomer As New BindingList(Of clsCustomer)

    'Instantiate a new Customer
    Dim objCustomer As New clsCustomer()

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

    Private Sub Reload_Customer()
        'Clear ListBox
        lstCustomer.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("Select * from Customers;", dbConnection)

        'Execute command into a database
        Dim rdrCostumer As SqlDataReader = cmdSelect.ExecuteReader

        If rdrCostumer.HasRows Then
            While rdrCostumer.Read
                Dim objStoredCustomer As New clsCustomer()
                objStoredCustomer.customerId = rdrCostumer.Item("customerId").ToString
                objStoredCustomer.firstName = rdrCostumer.Item("firstName").ToString
                objStoredCustomer.lastName = rdrCostumer.Item("lastName").ToString
                objStoredCustomer.phone = rdrCostumer.Item("phone").ToString
                objStoredCustomer.email = rdrCostumer.Item("email").ToString

                lstCustomer.Add(objStoredCustomer)

            End While
        End If

        'Select the first customer when loads the application
        SelectedCustomerRecord()

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Public Sub InsertCustomer()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Insert into Customers (firstName,lastName,phone,email) values (@firstName,@lastName,@phone,@email)"

        'Create command
        Dim cmdInsert As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the insert
        cmdInsert.Parameters.AddWithValue("firstName", lstCustomer.Last.firstName)
        cmdInsert.Parameters.AddWithValue("lastName", lstCustomer.Last.lastName)
        cmdInsert.Parameters.AddWithValue("phone", lstCustomer.Last.phone)
        cmdInsert.Parameters.AddWithValue("email", lstCustomer.Last.email)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstCustomer.Last.lastName & " was inserted")

            Else
                MessageBox.Show("The insert failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Please insert all fields!")

        End Try

        Reload_Customer()

        If lbxCustomer.SelectedIndex >= 0 Then
            'This selects and highlights the last item in the list box
            [lbxCustomer].SetSelected([lbxCustomer].Items.Count - 1, True)

        End If

    End Sub

    Public Sub UpdateCustomer()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Update Customers set firstName='" & txtFirstName.Text & "',lastName='" & txtLastName.Text & "',phone='" & txtPhone.Text & "',email='" & txtEmail.Text & "' WHERE customerId = '" & txtCustomerId.Text & "'"

        'Create command
        Dim cmdUpdate As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the update
        cmdUpdate.Parameters.AddWithValue("firstName", lstCustomer.Last.firstName)
        cmdUpdate.Parameters.AddWithValue("lastName", lstCustomer.Last.lastName)
        cmdUpdate.Parameters.AddWithValue("phone", lstCustomer.Last.phone)
        cmdUpdate.Parameters.AddWithValue("email", lstCustomer.Last.email)

        Try
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstCustomer.Last.customerId & " was updated")
            Else
                MessageBox.Show("The Update failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Update failed" & ex.Message)

        End Try

        Reload_Customer()

    End Sub

    Public Sub DeleteCustomer()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Delete from Customers Where customerId = '" & txtCustomerId.Text & "'"
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

        Reload_Customer()

    End Sub

    Private Sub SelectedCustomerRecord()

        If lbxCustomer.SelectedIndex >= 0 Then
            Dim objSelectedCustomer As clsCustomer = CType(lbxCustomer.SelectedItem, clsCustomer)
            txtCustomerId.Text = objSelectedCustomer.customerId.ToString
            txtFirstName.Text = objSelectedCustomer.firstName
            txtLastName.Text = objSelectedCustomer.lastName
            txtEmail.Text = objSelectedCustomer.email
            txtPhone.Text = objSelectedCustomer.phone

        End If
    End Sub

    'Delete Customer
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteCustomer()
    End Sub

    'Update Customer
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateCustomer()
    End Sub

    Private Sub lbxCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCustomer.SelectedIndexChanged
        SelectedCustomerRecord()
    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        'Assign Customer information from Form
        objCustomer.customerId = txtCustomerId.Text
        objCustomer.firstName = txtFirstName.Text
        objCustomer.lastName = txtLastName.Text
        objCustomer.email = txtEmail.Text
        objCustomer.phone = txtPhone.Text

        'Add Customer object to list of Customers'
        lstCustomer.Add(objCustomer)

        SelectedCustomerRecord()

        InsertCustomer()
    End Sub

    Private Sub AddCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate List box of Customer
        lbxCustomer.DataSource = lstCustomer
        lbxCustomer.DisplayMember = "lastName"

        Reload_Customer()
    End Sub

End Class