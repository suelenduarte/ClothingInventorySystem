'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: Manage Login form

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmLogin

    'Module level Object for class User
    Dim lstLogin As New BindingList(Of clsUser)

    Private Sub Reload_Users()
        'Clear ListBox
        lstLogin.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("Select * from Users where username ='" & txtUsername.Text & "' AND userPassword ='" & txtPassword.Text & "'", dbConnection)

        'Execute command into a database
        Dim rdrUser As SqlDataReader = cmdSelect.ExecuteReader

        'Create an instance of the Main form
        Dim frmMain As New frmMain
        Try
            If rdrUser.Read Then
                'Make all functionalities visible 
                If txtUsername.Text = "admin" Then
                    frmMain.UsersToolStripMenuItem.Visible = True
                    MessageBox.Show("Login successfully.")

                    'Display the Main Form
                    frmMain.Show()
                    Me.Hide()

                Else
                    'Hide ability to create new users 
                    frmMain.UsersToolStripMenuItem.Visible = False
                    MessageBox.Show("Login successfully.")

                    'Display the Main Form
                    frmMain.Show()
                    Me.Hide()

                End If
            Else
                MessageBox.Show("Invalid login! Please try again.")

            End If

        Catch ex As Exception
            MessageBox.Show("SQL error")
        End Try

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Reload_Users()

    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        'Hide and show password text using checkbox
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
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