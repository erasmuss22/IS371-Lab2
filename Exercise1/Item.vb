' This class represents an item such including the type and price. It also keeps track of the
' total number of each item sold 
Public Class Item
    Public Const brewersHat As String = "Brewer's Hat"
    Public Const trekBike As String = "Trek X02 Bicycle"
    Public Const brewersPrice As Decimal = 12.99
    Public Const trekPrice As Decimal = 2799.99
    Private itemName As String
    Private itemPrice As Decimal
    Private Shared hatsSold As Integer = 0
    Private Shared bikesSold As Integer = 0
    Private Shared hatsReturned As Integer = 0
    Private Shared bikesReturned As Integer = 0

    ' create a new item for sale
    Public Sub New(ByVal itemName As String)
        If itemName = brewersHat Then
            Me.itemName = brewersHat
            Me.itemPrice = brewersPrice
            soldHat()
        ElseIf itemName = trekBike Then
            Me.itemName = trekBike
            Me.itemPrice = trekPrice
            soldBike()
        Else
            Throw New ArgumentOutOfRangeException()
        End If

    End Sub

    Public Sub soldHat()
        hatsSold = hatsSold + 1
    End Sub

    Public Sub soldBike()
        bikesSold = bikesSold + 1
    End Sub

    Public Sub returnHat()
        hatsReturned = hatsReturned + 1
    End Sub

    Public Sub returnBike()
        bikesReturned = bikesReturned + 1
    End Sub

    Public ReadOnly Property itemType As String
        Get
            Return itemName
        End Get
    End Property

    Public ReadOnly Property priceOfItem As Decimal
        Get
            Return itemPrice
        End Get
    End Property

    Public Shared ReadOnly Property totalHatsSold As Integer
        Get
            Return hatsSold
        End Get
    End Property

    Public Shared ReadOnly Property totalBikesSold As Integer
        Get
            Return bikesSold
        End Get
    End Property

    Public Shared ReadOnly Property totalHatsReturned As Integer
        Get
            Return hatsReturned
        End Get
    End Property

    Public Shared ReadOnly Property totalBikesReturned As Integer
        Get
            Return bikesReturned
        End Get
    End Property

End Class
