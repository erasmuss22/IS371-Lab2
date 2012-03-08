' This class represents the variables passed when an event is raised
Public Class RestaurantEventArgs
    Inherits EventArgs

    Private orderNum As Integer

    Private orderStatus As String

    Sub New(ByVal num As Integer, ByVal stat As String)
        eventOrderNum = num
        eventOrderStat = stat
    End Sub

    Public Property eventOrderNum As Integer
        Get
            Return orderNum
        End Get
        Set(value As Integer)
            orderNum = value
        End Set
    End Property

    Public Property eventOrderStat As String
        Get
            Return orderStatus
        End Get
        Set(value As String)
            orderStatus = value
        End Set
    End Property

End Class
