'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: Manage user class

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmAddUser

    'Module level Object for class User
    Dim lstUser As New BindingList(Of clsUser)

    'Instantiate a new User
    Dim objUser As New clsUser()

    Private Sub Reload_Users()
        'Clear ListBox
        lstUser.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("Select * from Users;", dbConnection)

        'Execute command into a database
        Dim rdrUser As SqlDataReader = cmdSelect.ExecuteReader

        If rdrUser.HasRows Then
            While rdrUser.Read
                Dim objStoredUser As New clsUser()
                objStoredUser.userId = rdrUser.Item("userId").ToString
                objStoredUser.username = rdrUser.Item("username").ToString
                objStoredUser.userFirstName = rdrUser.Item("userFirstName").ToString
                objStoredUser.userPassword = rdrUser.Item("userPassword").ToString
                objStoredUser.userPhone = rdrUser.Item("userPhone").ToString
                objStoredUser.userEmail = rdrUser.Item("userEmail").ToString
                objStoredUser.userLastName = rdrUser.Item("userLastName").ToString

                lstUser.Add(objStoredUser)

            End While
        End If

        'Select the first user when loads the application
        SelectedUserRecord()

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        'Assign User information from Form
        objUser.userId = txtId.Text
        objUser.username = txtUsername.Text
        objUser.userFirstName = txtUsername.Text
        objUser.userLastName = txtUsername.Text
        objUser.userPassword = CType(Integer.Parse(txtPassword.Text), String)
        objUser.userPhone = CType(Integer.Parse(txtPhone.Text), String)
        objUser.userEmail = txtEmail.Text


        'Add user object to list of Users'
        lstUser.Add(objUser)

        InsertUser()


    End Sub

    Public Sub InsertUser()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Insert into Users (username,userFirstName,userPassword,userPhone,userEmail,userLastName) values (@username,@userFirstName,@userPassword,@userPhone,@userEmail,@userLastName)"

        'Create command
        Dim cmdInsert As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the insert
        cmdInsert.Parameters.AddWithValue("username", lstUser.Last.username)
        cmdInsert.Parameters.AddWithValue("userFirstName", lstUser.Last.userFirstName)
        cmdInsert.Parameters.AddWithValue("userPassword", lstUser.Last.userPassword)
        cmdInsert.Parameters.AddWithValue("userPhone", lstUser.Last.userPhone)
        cmdInsert.Parameters.AddWithValue("userEmail", lstUser.Last.userEmail)
        cmdInsert.Parameters.AddWithValue("userLastName", lstUser.Last.userLastName)


        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstUser.Last.username & " was inserted")

            Else
                MessageBox.Show("The insert failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Please insert all fields!")

        End Try

        Reload_Users()

        'This selects and highlights the last item in the list box
        [lbxUser].SetSelected([lbxUser].Items.Count - 1, True)

    End Sub

    Public Sub UpdateUser()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Update Users set username='" & txtUsername.Text & "',userFirstName='" & txtFirstName.Text & "',userPassword='" & txtPassword.Text & "',userPhone='" & txtPhone.Text & "',userLastName='" & txtLastName.Text & "' WHERE userId = '" & txtId.Text & "'"

        MessageBox.Show(strSql)
        'Create command
        Dim cmdUpdate As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the insert
        cmdUpdate.Parameters.AddWithValue("username", lstUser.Last.username)
        cmdUpdate.Parameters.AddWithValue("userFirstName", lstUser.Last.userFirstName)
        cmdUpdate.Parameters.AddWithValue("userPassword", lstUser.Last.userPassword)
        cmdUpdate.Parameters.AddWithValue("userPhone", lstUser.Last.userPhone)
        cmdUpdate.Parameters.AddWithValue("userEmail", lstUser.Last.userEmail)
        cmdUpdate.Parameters.AddWithValue("userLastName", lstUser.Last.userLastName)

        Try
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstUser.Last.userId & " was updated")
            Else
                MessageBox.Show("The Update failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Update failed" & ex.Message)

        End Try

        Reload_Users()

    End Sub

    Public Sub DeleteUser()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Delete from Users Where userId = '" & txtId.Text & "'"
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

        Reload_Users()

    End Sub

    Private Sub SelectedUserRecord()

        If lbxUser.SelectedIndex >= 0 Then
            Dim objSelectedUser As clsUser = CType(lbxUser.SelectedItem, clsUser)
            txtId.Text = objSelectedUser.userId.ToString

            txtFirstName.Text = objSelectedUser.userFirstName

            txtLastName.Text = objSelectedUser.userLastName

            txtUsername.Text = objSelectedUser.username
            txtEmail.Text = objSelectedUser.userEmail
            txtPhone.Text = objSelectedUser.userPhone


            txtPassword.Text = objSelectedUser.userPassword

        End If
    End Sub

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Populate List box of User
        lbxUser.DataSource = lstUser
        lbxUser.DisplayMember = "username"

        Reload_Users()

    End Sub

    'Delete User
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        DeleteUser()
    End Sub

    'Update User
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        UpdateUser()
    End Sub

    Private Sub lbxUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxUser.SelectedIndexChanged
        SelectedUserRecord()
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