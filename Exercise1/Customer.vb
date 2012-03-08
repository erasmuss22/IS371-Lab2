' This class represents all the information for a customer including items purchased
Public Class Customer
    Private name As String
    Private address As String
    Private city As String
    Private state As String
    Private zipCode As Integer
    Private phoneNumber As String
    Private totalPurchases As Decimal
    Private itemsPurchased As New List(Of Item)
    Private transactions As New List(Of Transaction)
    Private amountOwed As Decimal

    ' creates a new customer
    Public Sub New(ByVal name As String, ByVal address As String, ByVal city As String,
                   ByVal state As String, ByVal zipCode As Integer, ByVal phoneNumber As String)

        If zipCode <= 0 Then
            Throw New ArgumentOutOfRangeException()
        End If

        Me.name = name
        Me.address = address
        Me.city = city
        Me.state = state
        Me.zipCode = zipCode
        Me.phoneNumber = phoneNumber
        totalPurchases = 0
        amountOwed = 0
    End Sub

    ' finds the index number of a transaction
    Public Function findIDNumber(ByVal idNum As Integer)
        Dim count = 0
        For Each thing In transactions
            If thing.transID = idNum Then
                Return count
            End If
            count += 1
        Next
        Return 0
    End Function

    ' adds a new transaction
    Public Sub addTransaction(ByVal trans As Transaction)
        transactions.Add(trans)
    End Sub

    ' adds the amount owed on a transaction
    Public Sub addToAmountOwed(ByVal purchaseAmount As Decimal)
        If purchaseAmount < 0 Then
            Throw New ArgumentOutOfRangeException()
        End If
        amountOwed += purchaseAmount
    End Sub

    ' allows the customer to pay off some of the amount
    Public Sub paidSomeDebt(ByVal purchaseAmount As Decimal)
        If purchaseAmount < 0 Then
            Throw New ArgumentOutOfRangeException()
        End If
        amountOwed -= purchaseAmount
    End Sub

    ' adds more to a purchase total
    Public Sub addToPurchaseTotal(ByVal purchaseAmount As Decimal)
        If purchaseAmount < 0 Then
            Throw New ArgumentOutOfRangeException()
        End If
        totalPurchases += purchaseAmount
    End Sub

    ' adds an item to the items a customer has bought
    Public Sub addPurchasedItem(ByVal purchasedItem As Item)
        itemsPurchased.Add(purchasedItem)
    End Sub

    ' removes a purchase
    Public Sub removePurchaseTotal(ByVal purchaseAmount As Decimal)
        If purchaseAmount < 0 Then
            Throw New ArgumentOutOfRangeException()
        End If
        totalPurchases -= purchaseAmount
    End Sub

    ' removes a returned item
    Public Sub removePurchasedItem(ByVal purchasedItem As Item)
        itemsPurchased.Remove(purchasedItem)
    End Sub

    Public ReadOnly Property customerName() As String
        Get
            Return name
        End Get
    End Property

    Public ReadOnly Property customerAddress() As String
        Get
            Return address
        End Get
    End Property

    Public ReadOnly Property customerCity() As String
        Get
            Return city
        End Get
    End Property

    Public ReadOnly Property customerZipCode() As Integer
        Get
            Return zipCode
        End Get
    End Property

    Public ReadOnly Property customerPhoneNumber() As String
        Get
            Return phoneNumber
        End Get
    End Property

    Public ReadOnly Property customerTotalPurchases As Decimal
        Get
            Return totalPurchases
        End Get
    End Property

    Public ReadOnly Property customerItemPurchases() As List(Of Item)
        Get
            Return itemsPurchased
        End Get
    End Property

    Public ReadOnly Property customerTransactions() As List(Of Transaction)
        Get
            Return transactions
        End Get
    End Property

    Public ReadOnly Property customerState() As String
        Get
            Return state
        End Get
    End Property

    Public ReadOnly Property customerOwed() As Decimal
        Get
            Return amountOwed
        End Get
    End Property


End Class
