Public Class Form1
    Dim totalBikes As Integer
    Dim totalHats As Integer
    Dim problems As Boolean
    Dim transactionsPerformed As New List(Of Transaction)
    Dim idNumber As New Random()
    Dim temp As Transaction
    Dim listCounter As Integer = 0
    Dim returningCustomers As New List(Of String)
    Dim returningCustObjects As New List(Of Customer)

    ' validates input for the amount of bikes and/or hats and gives a total and subtotal
    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click
        'First time only add a blank item to the box
        If Not returningCustomers.Contains("") Then
            returningCustomers.Add("")
        End If
        If calculateButton.Text = "Recalculate Total" Then
            problems = False
            If hatInputText.Text = String.Empty Then
                totalHats = 0
            End If
            If bikeTextInput.Text = String.Empty Then
                totalBikes = 0
            End If
            If bikeTextInput.Text = String.Empty And hatInputText.Text = String.Empty Then
                problems = True
                warningLabel.Enabled = True
            End If
            If problems = False Then
                totalBikes = Val(bikeTextInput.Text)
                totalHats = Val(hatInputText.Text)
                warningLabel.Enabled = False
                Dim itemsSold As New List(Of Item)
                If totalBikes > 0 Then
                    For count = 1 To totalBikes
                        itemsSold.Add(New Item(Item.trekBike))
                    Next
                End If
                If totalHats > 0 Then
                    For count = 1 To totalHats
                        itemsSold.Add(New Item(Item.brewersHat))
                    Next
                End If
                transactionsPerformed(listCounter - 1).calculateSubAndTotal(itemsSold)
                subtotalLabel.Text = String.Format("{0:C}", temp.transSubtotal)
                taxLabel.Text = String.Format("{0:C}", temp.transTax)
                totalLabel.Text = String.Format("{0:C}", temp.transTotal)
                subtotalLabel.Visible = True
                taxLabel.Visible = True
                totalLabel.Visible = True
                returningComboBox.DataSource = returningCustomers.ToArray
            End If
        Else
            problems = False
            If hatInputText.Text = String.Empty Then
                totalHats = 0
            End If
            If bikeTextInput.Text = String.Empty Then
                totalBikes = 0
            End If
            If bikeTextInput.Text = String.Empty And hatInputText.Text = String.Empty Then
                problems = True
                warningLabel.Enabled = True
            End If
            If problems = False Then
                totalBikes = Val(bikeTextInput.Text)
                totalHats = Val(hatInputText.Text)
                warningLabel.Enabled = False
                Dim itemsSold As New List(Of Item)
                If totalBikes > 0 Then
                    For count = 1 To totalBikes
                        itemsSold.Add(New Item(Item.trekBike))
                    Next
                End If
                If totalHats > 0 Then
                    For count = 1 To totalHats
                        itemsSold.Add(New Item(Item.brewersHat))
                    Next
                End If
                temp = New Transaction(Transaction.saleTransaction, itemsSold, idNumber.Next(1000, 10000))
                transactionsPerformed.Add(temp)
                listCounter += 1
                subtotalLabel.Text = String.Format("{0:C}", temp.transSubtotal)
                taxLabel.Text = String.Format("{0:C}", temp.transTax)
                totalLabel.Text = String.Format("{0:C}", temp.transTotal)
                subtotalLabel.Visible = True
                taxLabel.Visible = True
                totalLabel.Visible = True
                nameText.Enabled = True
                addressText.Enabled = True
                returningComboBox.Enabled = True
                cityText.Enabled = True
                stateCombo.Enabled = True
                zipText.Enabled = True
                areaCodeText.Enabled = True
                firstPhoneText.Enabled = True
                lastPhoneText.Enabled = True
                calculateButton.Text = "Recalculate Total"
                returningComboBox.DataSource = returningCustomers.ToArray
                amountPaidBox.Enabled = True
                shippingText.Enabled = True
                completeTransButton.Enabled = True
                cancelButton.Enabled = True
                returnButton.Enabled = False
            End If
        End If
    End Sub

    ' makes sure only a number is input
    Private Sub hatInputText_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles hatInputText.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' makes sure only a number is input
    Private Sub bikeTextInput_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles bikeTextInput.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' Makes sure all the customer data is entered properly and then finishes the transaction
    Private Sub completeTransButton_Click(sender As System.Object, e As System.EventArgs) Handles completeTransButton.Click
        problems = False
        If nameText.Text = String.Empty Then
            problems = True
        End If
        If addressText.Text = String.Empty Then
            problems = True
        End If
        If cityText.Text = String.Empty Then
            problems = True
        End If
        If stateCombo.SelectedItem = "" Then
            problems = True
        End If
        If zipText.Text.Length < 5 Then
            problems = True
        End If
        If areaCodeText.Text.Length < 3 Then
            problems = True
        End If
        If firstPhoneText.Text.Length < 3 Then
            problems = True
        End If
        If lastPhoneText.Text.Length < 4 Then
            problems = True
        End If
        If Not IsNumeric(amountPaidBox.Text) Then
            problems = True
        Else
            If Val(amountPaidBox.Text < 0) Then
                problems = True
            End If
        End If
        If Not IsNumeric(shippingText.Text) And shippingText.Text <> String.Empty Then
            problems = True
        Else
            If Val(shippingText.Text) < 0 Then
                problems = True
            End If
        End If
        If Val(amountPaidBox.Text) > temp.transTotal Then
            problems = True
        End If
        If problems = True And returningComboBox.SelectedItem = "" Then
            lowerWarningLabel.Visible = True
        ElseIf returningComboBox.SelectedItem <> "" And Not IsNumeric(amountPaidBox.Text) Then
            lowerWarningLabel.Visible = True
        ElseIf returningComboBox.SelectedItem <> "" And IsNumeric(amountPaidBox.Text) And Val(amountPaidBox.Text) < 0 Then
        ElseIf returningComboBox.SelectedItem <> "" And Not IsNumeric(shippingText.Text) Then
            lowerWarningLabel.Visible = True
        ElseIf returningComboBox.SelectedItem <> "" And IsNumeric(shippingText.Text) And Val(shippingText.Text) < 0 Then
            lowerWarningLabel.Visible = True
        Else
            lowerWarningLabel.Visible = False
            If returningComboBox.SelectedItem <> "" Then
                lowerWarningLabel.Visible = False
                Dim phone As String = "(" + areaCodeText.Text + ") " + firstPhoneText.Text + "-" + lastPhoneText.Text
                If Val(shippingText.Text) > 0 Then
                    Try
                        temp.addShipping(Val(shippingText.Text))
                        temp.completeSaleReturning(returningCustObjects(returningComboBox.SelectedIndex - 1), temp.transTotal, Val(amountPaidBox.Text))
                    Catch ex As Exception
                    End Try
                Else
                    Try
                        temp.completeSaleReturning(returningCustObjects(returningComboBox.SelectedIndex - 1), temp.transTotal, Val(amountPaidBox.Text))
                    Catch ex As Exception
                    End Try
                End If
            Else
                Dim phone As String = "(" + areaCodeText.Text + ") " + firstPhoneText.Text + "-" + lastPhoneText.Text
                If Val(shippingText.Text) > 0 Then
                    Try
                        temp.addShipping(Val(shippingText.Text))
                        temp.completeSale(nameText.Text, addressText.Text, cityText.Text,
                       stateCombo.SelectedItem.ToString, Val(zipText.Text), phone,
                       temp.transTotal, Val(amountPaidBox.Text))
                        If Not returningCustomers.Contains(temp.transCustomer.customerName) Then
                            returningCustomers.Add(temp.transCustomer.customerName)
                        End If
                        If Not returningCustObjects.Contains(temp.transCustomer) Then
                            returningCustObjects.Add(temp.transCustomer)
                        End If
                    Catch ex As Exception
                    End Try
                Else
                    temp.completeSale(nameText.Text, addressText.Text, cityText.Text,
                       stateCombo.SelectedItem.ToString, Val(zipText.Text), phone,
                       temp.transTotal, Val(amountPaidBox.Text))
                    If Not returningCustomers.Contains(temp.transCustomer.customerName) Then
                        returningCustomers.Add(temp.transCustomer.customerName)
                    End If
                    If Not returningCustObjects.Contains(temp.transCustomer) Then
                        returningCustObjects.Add(temp.transCustomer)
                    End If
                End If
            End If
            nameText.Clear()
            addressText.Clear()
            cityText.Clear()
            zipText.Clear()
            areaCodeText.Clear()
            firstPhoneText.Clear()
            lastPhoneText.Clear()
            amountPaidBox.Clear()
            shippingText.Clear()
            nameText.Enabled = False
            addressText.Enabled = False
            cityText.Enabled = False
            zipText.Enabled = False
            areaCodeText.Enabled = False
            firstPhoneText.Enabled = False
            lastPhoneText.Enabled = False
            amountPaidBox.Enabled = False
            shippingText.Enabled = False
            stateCombo.Enabled = False
            returningComboBox.SelectedItem = ""
            returningComboBox.Enabled = True
            calculateButton.Text = "Calculate Total"
            bikeTextInput.Clear()
            hatInputText.Clear()
            subtotalLabel.Visible = False
            taxLabel.Visible = False
            totalLabel.Visible = False
            completeTransButton.Enabled = False
            cancelButton.Enabled = False
            returnAddressLabel.Visible = False
            returnCityLabel.Visible = False
            returnPhoneLabel.Visible = False
            returnStateLabel.Visible = False
            returnZipLabel.Visible = False
            returnButton.Enabled = True
            returningComboBox.DataSource = returningCustomers.ToArray
        End If
    End Sub

    ' makes sure only a number is input
    Private Sub areaCodeText_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles areaCodeText.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' makes sure only a number is input
    Private Sub firstPhoneText_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles firstPhoneText.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' makes sure only a number is input
    Private Sub lastPhoneText_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lastPhoneText.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' makes sure only a number is input
    Private Sub zipText_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles zipText.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' displays the information for a returning customer
    Private Sub returningComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles returningComboBox.SelectedIndexChanged
        custInfoButton.Visible = True
        If returningComboBox.SelectedItem <> "" Then
            returnAddressLabel.Text = returningCustObjects(returningComboBox.SelectedIndex - 1).customerAddress
            returnCityLabel.Text = returningCustObjects(returningComboBox.SelectedIndex - 1).customerCity
            returnStateLabel.Text = returningCustObjects(returningComboBox.SelectedIndex - 1).customerState
            returnZipLabel.Text = returningCustObjects(returningComboBox.SelectedIndex - 1).customerZipCode
            returnPhoneLabel.Text = returningCustObjects(returningComboBox.SelectedIndex - 1).customerPhoneNumber
            returnAddressLabel.Visible = True
            returnCityLabel.Visible = True
            returnStateLabel.Visible = True
            returnZipLabel.Visible = True
            returnPhoneLabel.Visible = True
        Else
            returnAddressLabel.Visible = False
            returnCityLabel.Visible = False
            returnStateLabel.Visible = False
            returnZipLabel.Visible = False
            returnPhoneLabel.Visible = False
        End If
    End Sub

    ' cancels the transaction in any state
    Private Sub cancelButton_Click(sender As System.Object, e As System.EventArgs) Handles cancelButton.Click
        transactionsPerformed.Remove(temp)
        nameText.Clear()
        addressText.Clear()
        cityText.Clear()
        zipText.Clear()
        areaCodeText.Clear()
        firstPhoneText.Clear()
        lastPhoneText.Clear()
        amountPaidBox.Clear()
        shippingText.Clear()
        nameText.Enabled = False
        addressText.Enabled = False
        cityText.Enabled = False
        zipText.Enabled = False
        areaCodeText.Enabled = False
        firstPhoneText.Enabled = False
        lastPhoneText.Enabled = False
        amountPaidBox.Enabled = False
        shippingText.Enabled = False
        stateCombo.Enabled = False
        returningComboBox.SelectedItem = ""
        returningComboBox.Enabled = True
        calculateButton.Text = "Calculate Total"
        bikeTextInput.Clear()
        hatInputText.Clear()
        subtotalLabel.Visible = False
        taxLabel.Visible = False
        totalLabel.Visible = False
        completeTransButton.Enabled = False
        cancelButton.Enabled = False
        returnAddressLabel.Visible = False
        returnCityLabel.Visible = False
        returnPhoneLabel.Visible = False
        returnStateLabel.Visible = False
        returnZipLabel.Visible = False
    End Sub

    ' opens up a new form to complete a return transaction
    Private Sub returnButton_Click(sender As System.Object, e As System.EventArgs) Handles returnButton.Click
        Dim returnForm As New ReturnTransaction
        returnForm.getDataFromForm(transactionsPerformed)
        Me.Hide()
        returnForm.Show()
    End Sub

    ' opens up a form for displaying customer info including the amount they bought and owe
    Private Sub custInfoButton_Click(sender As System.Object, e As System.EventArgs) Handles custInfoButton.Click
        If returningComboBox.SelectedIndex <> 0 Then
            Dim tempCust = returningCustObjects(returningComboBox.SelectedIndex - 1)
            CustomerInfo.nameLabel.Text = tempCust.customerName
            CustomerInfo.addressLabel.Text = tempCust.customerAddress
            CustomerInfo.cityLabel.Text = tempCust.customerCity
            CustomerInfo.stateLabel.Text = tempCust.customerState
            CustomerInfo.zipLabel.Text = tempCust.customerZipCode
            CustomerInfo.phoneLabel.Text = tempCust.customerPhoneNumber
            CustomerInfo.totalLabel.Text = String.Format("{0:C}", tempCust.customerTotalPurchases)
            CustomerInfo.owedLabel.Text = String.Format("{0:C}", tempCust.customerOwed)
            Me.Hide()
            CustomerInfo.Show()
        End If
    End Sub
End Class
