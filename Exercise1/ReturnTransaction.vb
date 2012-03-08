' This class represents the form for a return transaction. A previous customer
' gets selected and a list of their transactions is displayed for return
Public Class ReturnTransaction
    Dim returnTransactionsToPerform As New List(Of Transaction)
    Dim transactionNumbers As New List(Of Integer)
    Dim temp As Transaction
    Dim consumer As Customer
    Dim removalIndex As Integer
    Dim totalSale As Integer

    ' Gets the data for customer transactions from the input form
    Public Sub getDataFromForm(ByRef orders As List(Of Transaction))
        returnTransactionsToPerform = orders
        For Each thing In returnTransactionsToPerform
            transactionNumbers.Add(thing.transID)
        Next
        transactionCombo.DataSource = transactionNumbers.ToArray
        If transactionNumbers.Count = 0 Then
            performReturnButton.Text = "Exit (no transactions)"
        End If
    End Sub

    ' Either exits because no transactions are available to return, or performs a return
    ' on the selected transaction
    Private Sub performReturnButton_Click(sender As System.Object, e As System.EventArgs) Handles performReturnButton.Click
        If performReturnButton.Text = "Exit (no transactions)" Then
            performReturnButton.Text = "Perform Return"
            Me.Hide()
            Form1.Show()
        Else
            temp = returnTransactionsToPerform(transactionCombo.SelectedIndex)
            consumer = temp.transCustomer
            For Each thing In temp.transItems
                consumer.removePurchasedItem(thing)
            Next
            removalIndex = consumer.findIDNumber(temp.transID)
            totalSale = temp.transTotal
            consumer.removePurchaseTotal(totalSale)
            returnTransactionsToPerform.RemoveAt(transactionCombo.SelectedIndex)
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    ' Closes out the form
    Private Sub stopButton_Click(sender As System.Object, e As System.EventArgs) Handles stopButton.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class