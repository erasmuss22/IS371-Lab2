<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.topItemLabel = New System.Windows.Forms.Label()
        Me.bottomItemLabel = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.addressText = New System.Windows.Forms.TextBox()
        Me.cityText = New System.Windows.Forms.TextBox()
        Me.stateCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.completeTransButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.returningComboBox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.amountPaidBox = New System.Windows.Forms.TextBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.shippingText = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.returnButton = New System.Windows.Forms.Button()
        Me.hatInputText = New System.Windows.Forms.TextBox()
        Me.bikeTextInput = New System.Windows.Forms.TextBox()
        Me.warningLabel = New System.Windows.Forms.Label()
        Me.lowerWarningLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.firstPhoneText = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.areaCodeText = New System.Windows.Forms.TextBox()
        Me.lastPhoneText = New System.Windows.Forms.TextBox()
        Me.zipText = New System.Windows.Forms.TextBox()
        Me.returnAddressLabel = New System.Windows.Forms.Label()
        Me.returnCityLabel = New System.Windows.Forms.Label()
        Me.returnStateLabel = New System.Windows.Forms.Label()
        Me.returnZipLabel = New System.Windows.Forms.Label()
        Me.returnPhoneLabel = New System.Windows.Forms.Label()
        Me.custInfoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'topItemLabel
        '
        Me.topItemLabel.AutoSize = True
        Me.topItemLabel.Location = New System.Drawing.Point(62, 26)
        Me.topItemLabel.Name = "topItemLabel"
        Me.topItemLabel.Size = New System.Drawing.Size(149, 17)
        Me.topItemLabel.TabIndex = 6
        Me.topItemLabel.Text = "Trek Bike(s) $2799.99"
        '
        'bottomItemLabel
        '
        Me.bottomItemLabel.AutoSize = True
        Me.bottomItemLabel.Location = New System.Drawing.Point(62, 54)
        Me.bottomItemLabel.Name = "bottomItemLabel"
        Me.bottomItemLabel.Size = New System.Drawing.Size(153, 17)
        Me.bottomItemLabel.TabIndex = 7
        Me.bottomItemLabel.Text = "Brewer's Hat(s) $12.99"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(248, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 17)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Subtotal:"
        '
        'subtotalLabel
        '
        Me.subtotalLabel.AutoSize = True
        Me.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.subtotalLabel.Location = New System.Drawing.Point(327, 28)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(2, 19)
        Me.subtotalLabel.TabIndex = 11
        Me.subtotalLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Taxes:"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(327, 87)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(2, 19)
        Me.totalLabel.TabIndex = 13
        Me.totalLabel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total:"
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.taxLabel.Location = New System.Drawing.Point(327, 56)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(2, 19)
        Me.taxLabel.TabIndex = 15
        Me.taxLabel.Visible = False
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(12, 101)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(98, 47)
        Me.calculateButton.TabIndex = 3
        Me.calculateButton.Text = "Calculate Total"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'nameText
        '
        Me.nameText.Enabled = False
        Me.nameText.Location = New System.Drawing.Point(87, 186)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(147, 22)
        Me.nameText.TabIndex = 20
        '
        'addressText
        '
        Me.addressText.Enabled = False
        Me.addressText.Location = New System.Drawing.Point(87, 218)
        Me.addressText.Name = "addressText"
        Me.addressText.Size = New System.Drawing.Size(147, 22)
        Me.addressText.TabIndex = 21
        '
        'cityText
        '
        Me.cityText.Enabled = False
        Me.cityText.Location = New System.Drawing.Point(87, 246)
        Me.cityText.Name = "cityText"
        Me.cityText.Size = New System.Drawing.Size(147, 22)
        Me.cityText.TabIndex = 22
        '
        'stateCombo
        '
        Me.stateCombo.Enabled = False
        Me.stateCombo.FormattingEnabled = True
        Me.stateCombo.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.stateCombo.Location = New System.Drawing.Point(87, 274)
        Me.stateCombo.Name = "stateCombo"
        Me.stateCombo.Size = New System.Drawing.Size(60, 24)
        Me.stateCombo.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Zip Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "State:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "City:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Address:"
        '
        'completeTransButton
        '
        Me.completeTransButton.Enabled = False
        Me.completeTransButton.Location = New System.Drawing.Point(15, 448)
        Me.completeTransButton.Name = "completeTransButton"
        Me.completeTransButton.Size = New System.Drawing.Size(97, 47)
        Me.completeTransButton.TabIndex = 32
        Me.completeTransButton.Text = "Complete Transaction"
        Me.completeTransButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "ReturningCustomer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "New Customer"
        '
        'returningComboBox
        '
        Me.returningComboBox.Enabled = False
        Me.returningComboBox.FormattingEnabled = True
        Me.returningComboBox.Location = New System.Drawing.Point(277, 184)
        Me.returningComboBox.Name = "returningComboBox"
        Me.returningComboBox.Size = New System.Drawing.Size(146, 24)
        Me.returningComboBox.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 17)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Down Payment:"
        '
        'amountPaidBox
        '
        Me.amountPaidBox.Enabled = False
        Me.amountPaidBox.Location = New System.Drawing.Point(134, 390)
        Me.amountPaidBox.Name = "amountPaidBox"
        Me.amountPaidBox.Size = New System.Drawing.Size(100, 22)
        Me.amountPaidBox.TabIndex = 28
        '
        'cancelButton
        '
        Me.cancelButton.Enabled = False
        Me.cancelButton.Location = New System.Drawing.Point(134, 448)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(98, 47)
        Me.cancelButton.TabIndex = 38
        Me.cancelButton.Text = "Cancel Transaction"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'shippingText
        '
        Me.shippingText.Enabled = False
        Me.shippingText.Location = New System.Drawing.Point(134, 420)
        Me.shippingText.Name = "shippingText"
        Me.shippingText.Size = New System.Drawing.Size(100, 22)
        Me.shippingText.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 423)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 17)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Shipping Amount:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(240, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "(if shipped)"
        '
        'returnButton
        '
        Me.returnButton.Location = New System.Drawing.Point(258, 448)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(85, 47)
        Me.returnButton.TabIndex = 42
        Me.returnButton.Text = "Make a Return"
        Me.returnButton.UseVisualStyleBackColor = True
        '
        'hatInputText
        '
        Me.hatInputText.Location = New System.Drawing.Point(12, 51)
        Me.hatInputText.MaxLength = 5
        Me.hatInputText.Name = "hatInputText"
        Me.hatInputText.Size = New System.Drawing.Size(49, 22)
        Me.hatInputText.TabIndex = 2
        '
        'bikeTextInput
        '
        Me.bikeTextInput.Location = New System.Drawing.Point(12, 23)
        Me.bikeTextInput.MaxLength = 5
        Me.bikeTextInput.Name = "bikeTextInput"
        Me.bikeTextInput.Size = New System.Drawing.Size(49, 22)
        Me.bikeTextInput.TabIndex = 1
        '
        'warningLabel
        '
        Me.warningLabel.AutoSize = True
        Me.warningLabel.ForeColor = System.Drawing.Color.Red
        Me.warningLabel.Location = New System.Drawing.Point(12, 76)
        Me.warningLabel.Name = "warningLabel"
        Me.warningLabel.Size = New System.Drawing.Size(215, 17)
        Me.warningLabel.TabIndex = 45
        Me.warningLabel.Text = "Enter a value in one of the fields!"
        Me.warningLabel.Visible = False
        '
        'lowerWarningLabel
        '
        Me.lowerWarningLabel.AutoSize = True
        Me.lowerWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.lowerWarningLabel.Location = New System.Drawing.Point(12, 362)
        Me.lowerWarningLabel.Name = "lowerWarningLabel"
        Me.lowerWarningLabel.Size = New System.Drawing.Size(102, 17)
        Me.lowerWarningLabel.TabIndex = 46
        Me.lowerWarningLabel.Text = "Improper input!"
        Me.lowerWarningLabel.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(142, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 17)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = ")"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(84, 342)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 17)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "("
        '
        'firstPhoneText
        '
        Me.firstPhoneText.Enabled = False
        Me.firstPhoneText.Location = New System.Drawing.Point(161, 342)
        Me.firstPhoneText.MaxLength = 3
        Me.firstPhoneText.Name = "firstPhoneText"
        Me.firstPhoneText.Size = New System.Drawing.Size(30, 22)
        Me.firstPhoneText.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(197, 345)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 17)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "-"
        '
        'areaCodeText
        '
        Me.areaCodeText.Enabled = False
        Me.areaCodeText.Location = New System.Drawing.Point(102, 342)
        Me.areaCodeText.MaxLength = 3
        Me.areaCodeText.Name = "areaCodeText"
        Me.areaCodeText.Size = New System.Drawing.Size(34, 22)
        Me.areaCodeText.TabIndex = 25
        '
        'lastPhoneText
        '
        Me.lastPhoneText.Enabled = False
        Me.lastPhoneText.Location = New System.Drawing.Point(216, 342)
        Me.lastPhoneText.MaxLength = 4
        Me.lastPhoneText.Name = "lastPhoneText"
        Me.lastPhoneText.Size = New System.Drawing.Size(57, 22)
        Me.lastPhoneText.TabIndex = 27
        '
        'zipText
        '
        Me.zipText.Enabled = False
        Me.zipText.Location = New System.Drawing.Point(87, 309)
        Me.zipText.MaxLength = 5
        Me.zipText.Name = "zipText"
        Me.zipText.Size = New System.Drawing.Size(60, 22)
        Me.zipText.TabIndex = 24
        '
        'returnAddressLabel
        '
        Me.returnAddressLabel.AutoSize = True
        Me.returnAddressLabel.Location = New System.Drawing.Point(274, 218)
        Me.returnAddressLabel.Name = "returnAddressLabel"
        Me.returnAddressLabel.Size = New System.Drawing.Size(59, 17)
        Me.returnAddressLabel.TabIndex = 54
        Me.returnAddressLabel.Text = "Label18"
        Me.returnAddressLabel.Visible = False
        '
        'returnCityLabel
        '
        Me.returnCityLabel.AutoSize = True
        Me.returnCityLabel.Location = New System.Drawing.Point(274, 249)
        Me.returnCityLabel.Name = "returnCityLabel"
        Me.returnCityLabel.Size = New System.Drawing.Size(59, 17)
        Me.returnCityLabel.TabIndex = 55
        Me.returnCityLabel.Text = "Label18"
        Me.returnCityLabel.Visible = False
        '
        'returnStateLabel
        '
        Me.returnStateLabel.AutoSize = True
        Me.returnStateLabel.Location = New System.Drawing.Point(274, 281)
        Me.returnStateLabel.Name = "returnStateLabel"
        Me.returnStateLabel.Size = New System.Drawing.Size(59, 17)
        Me.returnStateLabel.TabIndex = 56
        Me.returnStateLabel.Text = "Label18"
        Me.returnStateLabel.Visible = False
        '
        'returnZipLabel
        '
        Me.returnZipLabel.AutoSize = True
        Me.returnZipLabel.Location = New System.Drawing.Point(274, 312)
        Me.returnZipLabel.Name = "returnZipLabel"
        Me.returnZipLabel.Size = New System.Drawing.Size(59, 17)
        Me.returnZipLabel.TabIndex = 57
        Me.returnZipLabel.Text = "Label18"
        Me.returnZipLabel.Visible = False
        '
        'returnPhoneLabel
        '
        Me.returnPhoneLabel.AutoSize = True
        Me.returnPhoneLabel.Location = New System.Drawing.Point(284, 345)
        Me.returnPhoneLabel.Name = "returnPhoneLabel"
        Me.returnPhoneLabel.Size = New System.Drawing.Size(59, 17)
        Me.returnPhoneLabel.TabIndex = 58
        Me.returnPhoneLabel.Text = "Label18"
        Me.returnPhoneLabel.Visible = False
        '
        'custInfoButton
        '
        Me.custInfoButton.Location = New System.Drawing.Point(358, 448)
        Me.custInfoButton.Name = "custInfoButton"
        Me.custInfoButton.Size = New System.Drawing.Size(84, 47)
        Me.custInfoButton.TabIndex = 59
        Me.custInfoButton.Text = "Customer Info"
        Me.custInfoButton.UseVisualStyleBackColor = True
        Me.custInfoButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 507)
        Me.Controls.Add(Me.custInfoButton)
        Me.Controls.Add(Me.returnPhoneLabel)
        Me.Controls.Add(Me.returnZipLabel)
        Me.Controls.Add(Me.returnStateLabel)
        Me.Controls.Add(Me.returnCityLabel)
        Me.Controls.Add(Me.returnAddressLabel)
        Me.Controls.Add(Me.zipText)
        Me.Controls.Add(Me.lastPhoneText)
        Me.Controls.Add(Me.areaCodeText)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.firstPhoneText)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lowerWarningLabel)
        Me.Controls.Add(Me.warningLabel)
        Me.Controls.Add(Me.bikeTextInput)
        Me.Controls.Add(Me.hatInputText)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.shippingText)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.amountPaidBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.returningComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.completeTransButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.stateCombo)
        Me.Controls.Add(Me.cityText)
        Me.Controls.Add(Me.addressText)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.subtotalLabel)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.bottomItemLabel)
        Me.Controls.Add(Me.topItemLabel)
        Me.Name = "Form1"
        Me.Text = "Point of Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents topItemLabel As System.Windows.Forms.Label
    Friend WithEvents bottomItemLabel As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents subtotalLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents nameText As System.Windows.Forms.TextBox
    Friend WithEvents addressText As System.Windows.Forms.TextBox
    Friend WithEvents cityText As System.Windows.Forms.TextBox
    Friend WithEvents stateCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents completeTransButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents returningComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents amountPaidBox As System.Windows.Forms.TextBox
    Friend WithEvents cancelButton As System.Windows.Forms.Button
    Friend WithEvents shippingText As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents returnButton As System.Windows.Forms.Button
    Friend WithEvents hatInputText As System.Windows.Forms.TextBox
    Friend WithEvents bikeTextInput As System.Windows.Forms.TextBox
    Friend WithEvents warningLabel As System.Windows.Forms.Label
    Friend WithEvents lowerWarningLabel As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents firstPhoneText As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents areaCodeText As System.Windows.Forms.TextBox
    Friend WithEvents lastPhoneText As System.Windows.Forms.TextBox
    Friend WithEvents zipText As System.Windows.Forms.TextBox
    Friend WithEvents returnAddressLabel As System.Windows.Forms.Label
    Friend WithEvents returnCityLabel As System.Windows.Forms.Label
    Friend WithEvents returnStateLabel As System.Windows.Forms.Label
    Friend WithEvents returnZipLabel As System.Windows.Forms.Label
    Friend WithEvents returnPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents custInfoButton As System.Windows.Forms.Button

End Class
