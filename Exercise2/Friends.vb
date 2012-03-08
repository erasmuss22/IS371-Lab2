' This class represents a friend and the amount they owe/are due
Public Class Friends
    Private name As String
    Private outstandingBalance As Decimal
    Private transactions As New List(Of Transaction)

    Public Sub New(ByVal name As String)
        Me.name = name
        outstandingBalance = 0
    End Sub

    ' add a new transaction to their running total
    Public Sub performTransaction(ByVal amountOwed As Decimal, ByRef trans As Transaction)
        outstandingBalance += amountOwed
        transactions.Add(trans)
    End Sub

    ' updates an old transaction
    Public Sub updateTheTrans(ByVal amountOwed As Decimal, ByVal initialAmount As Decimal)
        outstandingBalance -= initialAmount
        outstandingBalance += amountOwed
    End Sub

    ' removes a balance owed
    Public Sub removeBalance(ByVal amountOwed As Decimal)
        outstandingBalance -= amountOwed
    End Sub

    Public ReadOnly Property friendName As String
        Get
            Return name
        End Get
    End Property

    Public ReadOnly Property friendBalance As Decimal
        Get
            Return outstandingBalance
        End Get
    End Property

    Public ReadOnly Property friendTrans As List(Of Transaction)
        Get
            Return transactions
        End Get
    End Property

End Class
