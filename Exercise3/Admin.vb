' This is the form for creating and updating orders
Public Class Admin
    Friend WithEvents Restaurant1 As New Restaurant
    Dim numberList As New List(Of Integer)
    Dim orderNumber As Integer = 1000

    Private Sub Admin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim newOrderBoard As New OrderBoard
        newOrderBoard.Show()
        warningLabel.Visible = False
    End Sub

    ' Creates a new order and adds it to the order list
    Private Sub scanNewButton_Click(sender As System.Object, e As System.EventArgs) Handles scanNewButton.Click
        numberList.Add(orderNumber)
        orderNumber += 1
        numberCombo.DataSource = numberList.ToArray
        numberCombo.SelectedIndex = -1
        warningLabel.Visible = False
        redundantLabel.Visible = False
    End Sub

    ' When an order status gets changed, it starts a new event
    Private Sub statusCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles statusCombo.SelectedIndexChanged
        If numberCombo.SelectedIndex = -1 Then
            warningLabel.Visible = True
        Else
            warningLabel.Visible = False
            Restaurant1.OnUpdate(New RestaurantEventArgs(numberCombo.SelectedItem, statusCombo.SelectedItem))
        End If
    End Sub
End Class
