'Author: Suelen Duarte
'Date: 02/29/2020
'Purpose: Manage user class

Option Strict On
Option Explicit On

Public Class clsUser
    Private firstName As String
    Private lastName As String
    Private usernameLogin As String
    Private phone As String
    Private email As String
    Private password As String
    Private user_id As String


    Public Property userFirstName As String
        Get
            Return firstName
        End Get
        Set(value As String)
            firstName = value
        End Set
    End Property

    Public Property userLastName As String
        Get
            Return lastName
        End Get
        Set(value As String)
            lastName = value
        End Set
    End Property

    Public Property username As String
        Get
            Return usernameLogin
        End Get
        Set(value As String)
            usernameLogin = value
        End Set
    End Property

    Public Property userPhone As String
        Get
            Return phone
        End Get
        Set(value As String)
            phone = value
        End Set
    End Property

    Public Property userEmail As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property userPassword As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property userId As String
        Get
            Return user_id
        End Get
        Set(value As String)
            user_id = value
        End Set
    End Property
End Class
