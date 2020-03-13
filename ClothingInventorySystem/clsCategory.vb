'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Manage customer class

Option Strict On
Option Explicit On

Public Class clsCategory
    Private name As String
    Private description As String
    Private category_id As String

    Public Property categoryName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property categoryDescription As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property

    Public Property categoryId As String
        Get
            Return category_id
        End Get
        Set(value As String)
            category_id = value
        End Set
    End Property
End Class
