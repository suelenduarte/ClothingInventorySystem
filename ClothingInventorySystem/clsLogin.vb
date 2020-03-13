'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: Manage login class

Option Strict On
Option Explicit On

'I am not using this class and the login database

Public Class clsLogin
    Private usernameLogin As String
    Private passwordLogin As String

    Public Property username As String
        Get
            Return usernameLogin
        End Get
        Set(value As String)
            usernameLogin = value
        End Set
    End Property

    Public Property password As String
        Get
            Return passwordLogin
        End Get
        Set(value As String)
            passwordLogin = value
        End Set
    End Property
End Class
