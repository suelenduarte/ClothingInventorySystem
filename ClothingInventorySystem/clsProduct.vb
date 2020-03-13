'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Manage products class

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class clsProduct
    Private nameProduct As String
    Private descriptionProduct As String
    Private priceProduct As Decimal
    Private quantityProduct As Integer
    Private product_Id As String
    Private category_Id As String
    Private imageProduct As String
    Private category_Name As String


    Public Property name As String
        Get
            Return nameProduct
        End Get
        Set(value As String)
            nameProduct = value
        End Set
    End Property

    Public Property description As String
        Get
            Return descriptionProduct
        End Get
        Set(value As String)
            descriptionProduct = value
        End Set
    End Property

    Public Property price As Decimal
        Get
            Return priceProduct
        End Get
        Set(value As Decimal)
            priceProduct = value
        End Set
    End Property

    Public Property quantity As Integer
        Get
            Return quantityProduct
        End Get
        Set(value As Integer)
            quantityProduct = value
        End Set
    End Property

    Public Property categoryId As String
        Get
            Return category_Id
        End Get
        Set(value As String)
            category_Id = value
        End Set
    End Property

    Public Property image As String
        Get
            Return imageProduct
        End Get
        Set(value As String)
            imageProduct = value
        End Set
    End Property

    Public Property productId As String
        Get
            Return product_Id
        End Get
        Set(value As String)
            product_Id = value
        End Set
    End Property

    Public Property CategoryName As String
        Get
            Return Category_Name
        End Get
        Set(value As String)
            category_Name = value
        End Set
    End Property
End Class
