' this class represents everything for a transaction including the ID number, friend, and
' date.
Public Class Transaction
    Private idNumber As Integer
    Private person As Friends
    Private dateOfTrans As String
    Private type As String
    Private transMonth As Integer
    Private transDay As Integer
    Private transYear As String
    Private friendIndex As Integer
    Private amount As Decimal
    Public Const iOwe As String = "I owe him/her"
    Public Const theyOwe As String = "He/She owes me"
    Public Const sharedExpense As String = "Shared Expense"

    ' create a new transaction
    Public Sub New(ByVal idNumber As Integer, ByVal person As Friends, ByVal dateOfTrans As String,
                   ByVal type As String, ByVal amount As Decimal, ByVal transMonth As Integer, ByVal transDay As Integer,
                   ByVal transYear As String, ByVal friendIndex As Integer)
        Me.idNumber = idNumber
        Me.person = person
        Me.dateOfTrans = dateOfTrans
        Me.type = type
        Me.amount = amount
        Me.transMonth = transMonth
        Me.transDay = transDay
        Me.transYear = transYear
        Me.friendIndex = friendIndex
    End Sub

    ' change information on a transaction
    Public Sub updateTransaction(ByVal idNumber As Integer, ByVal person As Friends, ByVal dateOfTrans As String,
                   ByVal type As String, ByVal amount As Decimal, ByVal transMonth As Integer, ByVal transDay As Integer,
                   ByVal transYear As String, ByVal friendIndex As Integer)
        Me.idNumber = idNumber
        Me.person = person
        Me.dateOfTrans = dateOfTrans
        Me.type = type
        Me.amount = amount
        Me.transMonth = transMonth
        Me.transDay = transDay
        Me.transYear = transYear
        Me.friendIndex = friendIndex
    End Sub

    ' gives a new balance on a transaction
    Public Sub updateBalance(ByVal newBalance As Decimal)
        amount = newBalance
    End Sub

    Public ReadOnly Property theMonth As Integer
        Get
            Return transMonth
        End Get
    End Property

    Public ReadOnly Property theDay As Integer
        Get
            Return transDay
        End Get
    End Property

    Public ReadOnly Property friendNum As Integer
        Get
            Return friendIndex
        End Get
    End Property

    Public ReadOnly Property theYear As String
        Get
            Return transYear
        End Get
    End Property

    Public ReadOnly Property transID As Integer
        Get
            Return idNumber
        End Get
    End Property

    Public ReadOnly Property transFriend As Friends
        Get
            Return person
        End Get
    End Property

    Public ReadOnly Property transDate As String
        Get
            Return dateOfTrans
        End Get
    End Property

    Public ReadOnly Property transAmount As Decimal
        Get
            Return amount
        End Get
    End Property

    Public ReadOnly Property transType As Decimal
        Get
            If type = iOwe Then
                Return 0
            ElseIf type = theyOwe Then
                Return 1
            Else
                Return 2
            End If
        End Get
    End Property

End Class
