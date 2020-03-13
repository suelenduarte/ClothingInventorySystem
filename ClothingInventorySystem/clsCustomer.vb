'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Manage customer class

Option Strict On
Option Explicit On

Public Class clsCustomer
    Private firstNameCustomer As String
    Private lastNameCustomer As String
    Private customer_Id As String
    Private phoneCustomer As String
    Private emailCustomer As String


    Public Property firstName As String
        Get
            Return firstNameCustomer
        End Get
        Set(value As String)
            firstNameCustomer = value
        End Set
    End Property

    Public Property lastName As String
        Get
            Return lastNameCustomer
        End Get
        Set(value As String)
            lastNameCustomer = value
        End Set
    End Property

    Public Property customerId As String
        Get
            Return customer_Id
        End Get
        Set(value As String)
            customer_Id = value
        End Set
    End Property

    Public Property phone As String
        Get
            Return phoneCustomer
        End Get
        Set(value As String)
            phoneCustomer = value
        End Set
    End Property

    Public Property email As String
        Get
            Return emailCustomer
        End Get
        Set(value As String)
            emailCustomer = value
        End Set
    End Property

End Class
