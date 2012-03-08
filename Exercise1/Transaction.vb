' This class represents a transaction including the type of sale, who the customer was
' how much it was for, and what items were sold.

Public Class Transaction
    Private customer As Customer
    Private saleType As String
    Private transactionAmount As Decimal
    Public Const tax As Decimal = 0.055
    Private depositAmount As Decimal
    Private subtotal As Decimal
    Private total As Decimal
    Private totalTax As Decimal
    Private itemSold As New List(Of Item)
    Private transactionID As Integer
    Public Const saleTransaction As String = "Sale"
    Public Const returnTransaction As String = "Return"


    ' Create a new transaction
    Public Sub New(ByVal saleType As String, ByVal itemSold As List(Of Item), ByVal transactionID As Integer)
        Me.saleType = saleType
        Me.itemSold = itemSold
        Me.transactionID = transactionID
        calculateSubAndTotal(itemSold)
    End Sub

    ' calculate and store the subtotal and total
    Public Sub calculateSubAndTotal(ByVal itemsSold As List(Of Item))
        Dim runningTotal As Decimal = 0
        For Each thing In itemsSold
            runningTotal += thing.priceOfItem()
        Next
        Me.subtotal = runningTotal
        Me.totalTax = tax * subtotal
        Me.total = subtotal + totalTax
    End Sub

    Public Sub addShipping(ByVal shipping As Decimal)
        total += shipping
    End Sub

    ' When the customer information is entered, the sale gets completed and added to the customer
    ' as well
    Public Sub completeSale(ByVal name As String, ByVal address As String, ByVal city As String,
                   ByVal state As String, ByVal zipCode As Integer, ByVal phoneNumber As String,
                   ByVal total As Decimal, ByVal amountPaid As Decimal)
        customer = New Customer(name, address, city, state, zipCode, phoneNumber)
        customer.addToPurchaseTotal(total)
        customer.addToAmountOwed(total)
        customer.paidSomeDebt(amountPaid)
        customer.addTransaction(Me)
    End Sub

    Public Sub completeSaleReturning(ByVal customer As Customer, ByVal total As Decimal, ByVal amountPaid As Decimal)
        Me.customer = customer
        Me.customer.addToPurchaseTotal(total)
        Me.customer.addToAmountOwed(total)
        Me.customer.paidSomeDebt(amountPaid)
        Me.customer.addTransaction(Me)
    End Sub

    Public ReadOnly Property transCustomer As Customer
        Get
            Return customer
        End Get
    End Property

    Public ReadOnly Property transSubtotal As Decimal
        Get
            Return subtotal
        End Get
    End Property

    Public ReadOnly Property transTotal As Decimal
        Get
            Return total
        End Get
    End Property

    Public ReadOnly Property transTax As Decimal
        Get
            Return totalTax
        End Get
    End Property

    Public ReadOnly Property transID As Integer
        Get
            Return transactionID
        End Get
    End Property

    Public ReadOnly Property transItems As List(Of Item)
        Get
            Return itemSold
        End Get
    End Property

End Class
