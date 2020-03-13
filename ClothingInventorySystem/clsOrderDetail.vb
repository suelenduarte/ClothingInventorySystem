'Author: Suelen Duarte
'Date: 02/28/2020
'Purpose: Manage Order class

Option Strict On
Option Explicit On


Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class clsOrderDetail



    Private totalPrice As Decimal
    Private orderPrice As Decimal
    Private orderQuantity As Decimal
    Private product_Id As Integer
    Public customer_Id As Integer
    Private order_Id As Integer
    Private orderDate As String

    Public Property Total_Price As Decimal
        Get
            Return totalPrice
        End Get
        Set(value As Decimal)
            totalPrice = value
        End Set
    End Property

    Public Property Order_Price As Decimal
        Get
            Return orderPrice
        End Get
        Set(value As Decimal)
            orderPrice = value
        End Set
    End Property

    Public Property Order_Quantity As Decimal
        Get
            Return orderQuantity
        End Get
        Set(value As Decimal)
            orderQuantity = value
        End Set
    End Property

    Public Property ProductId As Integer
        Get
            Return product_Id
        End Get
        Set(value As Integer)
            product_Id = value
        End Set
    End Property

    Public Property CustomerId As Integer
        Get
            Return customer_Id
        End Get
        Set(value As Integer)
            customer_Id = value
        End Set
    End Property

    Public Property Order_Date As String
        Get
            Return orderDate
        End Get
        Set(value As String)
            orderDate = value
        End Set
    End Property

    Public Property OrderId As Integer
        Get
            Return order_Id
        End Get
        Set(value As Integer)
            order_Id = value
        End Set
    End Property


End Class
