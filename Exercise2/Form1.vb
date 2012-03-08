' This class is the input form for all transactions
Public Class Form1
    Dim friendList As New List(Of Friends)
    Dim nameList As New List(Of String)
    Dim transList As New List(Of Transaction)
    Dim rnd As New Random()
    Dim idTemp As Integer = 0
    Dim place As Integer = 0


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        friendList.Add(New Friends("Valerie Ninneman"))
        friendList.Add(New Friends("Colin Rohm"))
        friendList.Add(New Friends("Paul Van Rens"))
        friendList.Add(New Friends("Patrick Mares"))
        friendList.Add(New Friends("Krista Rasmussen"))
        nameList.Add(("Valerie Ninneman"))
        nameList.Add(("Colin Rohm"))
        nameList.Add(("Paul Van Rens"))
        nameList.Add(("Patrick Mares"))
        nameList.Add(("Krista Rasmussen"))
        friendCombo.DataSource = nameList.ToArray
        dataCombo.DataSource = nameList.ToArray
        dataCombo.SelectedIndex = -1
        friendCombo.SelectedIndex = -1
        friendCombo.Enabled = False
        amountText.Enabled = False
        monthCombo.Enabled = False
        dayCombo.Enabled = False
        yearText.Enabled = False
        typeComboBox.Enabled = False
        previousButton.Enabled = False
        nextButton.Enabled = False
        outcomeLabel.Visible = False
        editButton.Enabled = False
        deleteButton.Enabled = False
    End Sub

    ' makes sure only a number is input
    Private Sub yearText_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles yearText.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' If the button reads "add" it adds the transaction with proper input, if it reads "add new" it
    ' allows for the creation of a new transaction
    Private Sub addButton_Click(sender As System.Object, e As System.EventArgs) Handles addButton.Click

        If addButton.Text = "Add" Then
            Dim problems = False
            If friendCombo.SelectedIndex = -1 Then
                problems = True
            End If
            Try
                If Not IsNumeric(amountText.Text) Then
                    problems = True
                Else
                    If Val(amountText.Text) < 0 Then
                        problems = True
                    End If
                End If
            Catch ex As Exception
                problems = True
            End Try
            If typeComboBox.SelectedIndex = -1 Then
                problems = True
            End If
            If monthCombo.SelectedIndex = -1 Then
                problems = True
            End If
            If dayCombo.SelectedIndex = -1 Then
                problems = True
            End If
            Try
                If Val(yearText.Text) > 12 Or yearText.Text.Length < 2 Then
                    problems = True
                End If
            Catch ex As Exception
            End Try
            If problems = True Then
                warningLabel.Visible = True
            Else
                warningLabel.Visible = False
                Try
                    Dim temp = New Transaction(idTemp, friendList(friendCombo.SelectedIndex), monthCombo.SelectedItem + " " + dayCombo.SelectedItem + ", 20" + yearText.Text,
                                               typeComboBox.SelectedItem, Val(amountText.Text), monthCombo.SelectedIndex, dayCombo.SelectedIndex, yearText.Text, friendCombo.SelectedIndex)
                    Dim amountOwed = Val(amountText.Text)
                    If typeComboBox.SelectedItem = Transaction.theyOwe Then
                        friendList(friendCombo.SelectedIndex).performTransaction(-1 * amountOwed, temp)
                    ElseIf typeComboBox.SelectedItem = Transaction.iOwe Then
                        friendList(friendCombo.SelectedIndex).performTransaction(amountOwed, temp)
                    Else
                        friendList(friendCombo.SelectedIndex).performTransaction(0, temp)
                    End If
                    transList.Add(temp)
                Catch ex As Exception
                End Try
                addButton.Text = "Add New"
                friendCombo.Enabled = False
                amountText.Enabled = False
                monthCombo.Enabled = False
                dayCombo.Enabled = False
                yearText.Enabled = False
                typeComboBox.Enabled = False
                editButton.Enabled = True
                deleteButton.Enabled = True
                If (transList.Count > 1) Then
                    place = transList.Count - 1
                    previousButton.Enabled = True
                    nextButton.Enabled = False
                    showTrans(place)
                End If
            End If
        Else
            warningLabel.Visible = False
            addButton.Text = "Add"
            friendCombo.SelectedIndex = -1
            friendCombo.Enabled = True
            amountText.Enabled = True
            monthCombo.Enabled = True
            dayCombo.Enabled = True
            yearText.Enabled = True
            typeComboBox.Enabled = True
            yearText.Clear()
            amountText.Clear()
            monthCombo.SelectedIndex = -1
            dayCombo.SelectedIndex = -1
            typeComboBox.SelectedIndex = -1
            idTemp = rnd.Next(10000, 100000)
            idText.Text = idTemp
            editButton.Enabled = False
            deleteButton.Enabled = False
        End If
    End Sub

    ' Used for the navigation for displaying transaction
    Public Sub showTrans(ByVal count As Integer)
        Dim temp = transList(count)
        idText.Text = temp.transID
        friendCombo.SelectedIndex = temp.friendNum
        amountText.Text = temp.transAmount
        monthCombo.SelectedIndex = temp.theMonth
        dayCombo.SelectedIndex = temp.theDay
        yearText.Text = temp.theYear
        typeComboBox.SelectedIndex = temp.transType
    End Sub

    ' advances to the next transaction if there is one
    Private Sub nextButton_Click(sender As System.Object, e As System.EventArgs) Handles nextButton.Click
        addButton.Text = "Add New"
        editButton.Text = "Edit"
        place += 1
        previousButton.Enabled = True
        If place + 1 = transList.Count Then
            nextButton.Enabled = False
        End If
        showTrans(place)
    End Sub

    ' goes to the previous transaction if there is one
    Private Sub previousButton_Click(sender As System.Object, e As System.EventArgs) Handles previousButton.Click
        addButton.Text = "Add New"
        editButton.Text = "Edit"
        place -= 1
        nextButton.Enabled = True
        If place = 0 Then
            previousButton.Enabled = False
        End If
        showTrans(place)
    End Sub

    ' allows a user to edit a transaction and then submit it through an update button
    Private Sub editButton_Click(sender As System.Object, e As System.EventArgs) Handles editButton.Click
        If editButton.Text = "Update" Then
            Dim problems = False
            If friendCombo.SelectedIndex = -1 Then
                problems = True
            End If
            Try
                If Not IsNumeric(amountText.Text) Then
                    problems = True
                Else
                    If Val(amountText.Text) < 0 Then
                        problems = True
                    End If
                End If
            Catch ex As Exception
                problems = True
            End Try
            If typeComboBox.SelectedIndex = -1 Then
                problems = True
            End If
            If monthCombo.SelectedIndex = -1 Then
                problems = True
            End If
            If dayCombo.SelectedIndex = -1 Then
                problems = True
            End If
            Try
                If Val(yearText.Text) > 12 Or yearText.Text.Length < 2 Then
                    problems = True
                End If
            Catch ex As Exception
            End Try
            If problems = True Then
                warningLabel.Visible = True
            Else
                warningLabel.Visible = False
                Try
                    Dim initialOwed = transList(place).transAmount
                    transList(place).updateTransaction(transList(place).transID, friendList(friendCombo.SelectedIndex), monthCombo.SelectedItem + " " + dayCombo.SelectedItem + ", 20" + yearText.Text,
                                               typeComboBox.SelectedItem, Val(amountText.Text), monthCombo.SelectedIndex, dayCombo.SelectedIndex, yearText.Text, friendCombo.SelectedIndex)
                    Dim amountOwed = Val(amountText.Text)
                    If typeComboBox.SelectedItem = Transaction.iOwe Then
                        'they owe is negative
                        friendList(friendCombo.SelectedIndex).updateTheTrans(amountOwed, initialOwed)
                    ElseIf typeComboBox.SelectedItem = Transaction.theyOwe Then
                        friendList(friendCombo.SelectedIndex).updateTheTrans(-1 * amountOwed, -1 * initialOwed)
                    Else

                    End If
                Catch ex As Exception
                End Try
                addButton.Text = "Add New"
                friendCombo.Enabled = False
                amountText.Enabled = False
                monthCombo.Enabled = False
                dayCombo.Enabled = False
                yearText.Enabled = False
                typeComboBox.Enabled = False
                editButton.Text = "Edit"
                addButton.Enabled = True
                deleteButton.Enabled = True
                outcomeLabel.Visible = False
            End If
        Else
            editButton.Text = "Update"
            amountText.Enabled = True
            monthCombo.Enabled = True
            dayCombo.Enabled = True
            yearText.Enabled = True
            typeComboBox.Enabled = False
            addButton.Enabled = False
            deleteButton.Enabled = False
            outcomeLabel.Visible = False
        End If

    End Sub

    ' displays what a friend owes or is owed
    Private Sub dataCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles dataCombo.SelectedIndexChanged
        If dataCombo.SelectedIndex <> -1 Then
            Dim selFriend = friendList(dataCombo.SelectedIndex)
            Dim outstandingBalance = selFriend.friendBalance
            If outstandingBalance < 0 Then
                outcomeLabel.Text = "They owe " + String.Format("{0:C}", -1 * outstandingBalance)
                outcomeLabel.Visible = True
            ElseIf outstandingBalance > 0 Then
                outcomeLabel.Text = "They owe " + String.Format("{0:C}", outstandingBalance)
                outcomeLabel.Visible = True
            Else
                outcomeLabel.Text = "We are even"
                outcomeLabel.Visible = True
            End If
        End If
    End Sub

    ' delete a transaction and update the friend amount owed
    Private Sub deleteButton_Click(sender As System.Object, e As System.EventArgs) Handles deleteButton.Click
        Dim amount As Decimal
        amount = transList(place).transAmount
        Dim typeOfTran = transList(place).transType
        Dim selFriend = transList(place).transFriend
        transList.RemoveAt(place)
        If (typeOfTran = 0) Then
            'IOwe
            selFriend.removeBalance(amount)
        ElseIf (typeOfTran = 1) Then
            'theyOwe
            selFriend.removeBalance(-1 * amount)
        End If
        yearText.Clear()
        amountText.Clear()
        monthCombo.SelectedIndex = -1
        dayCombo.SelectedIndex = -1
        typeComboBox.SelectedIndex = -1
        friendCombo.SelectedIndex = -1
        idText.Clear()
        If transList.Count > 1 Then
            place = 0
            showTrans(0)
            previousButton.Enabled = False
            nextButton.Enabled = True
        Else
            place = 0
            previousButton.Enabled = False
            nextButton.Enabled = False
        End If
    End Sub
End Class
