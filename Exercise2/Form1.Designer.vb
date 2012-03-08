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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idText = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.friendCombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.amountText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.typeComboBox = New System.Windows.Forms.ComboBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.monthCombo = New System.Windows.Forms.ComboBox()
        Me.dayCombo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.yearText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.warningLabel = New System.Windows.Forms.Label()
        Me.dataCombo = New System.Windows.Forms.ComboBox()
        Me.outcomeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transaction Date:"
        '
        'idText
        '
        Me.idText.Enabled = False
        Me.idText.Location = New System.Drawing.Point(122, 9)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(72, 22)
        Me.idText.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.outcomeLabel)
        Me.Panel1.Controls.Add(Me.dataCombo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(583, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 362)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Friend's Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Friend's Name:"
        '
        'friendCombo
        '
        Me.friendCombo.FormattingEnabled = True
        Me.friendCombo.Location = New System.Drawing.Point(122, 52)
        Me.friendCombo.Name = "friendCombo"
        Me.friendCombo.Size = New System.Drawing.Size(149, 24)
        Me.friendCombo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Amount:"
        '
        'amountText
        '
        Me.amountText.Location = New System.Drawing.Point(122, 99)
        Me.amountText.Name = "amountText"
        Me.amountText.Size = New System.Drawing.Size(100, 22)
        Me.amountText.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 37)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Transaction Type:"
        '
        'typeComboBox
        '
        Me.typeComboBox.FormattingEnabled = True
        Me.typeComboBox.Items.AddRange(New Object() {"I owe him/her", "He/She owes me", "Shared expense"})
        Me.typeComboBox.Location = New System.Drawing.Point(122, 146)
        Me.typeComboBox.Name = "typeComboBox"
        Me.typeComboBox.Size = New System.Drawing.Size(121, 24)
        Me.typeComboBox.TabIndex = 11
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(15, 237)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(74, 31)
        Me.addButton.TabIndex = 12
        Me.addButton.Text = "Add New"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(196, 237)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(75, 31)
        Me.deleteButton.TabIndex = 13
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(104, 237)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(74, 31)
        Me.editButton.TabIndex = 14
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(380, 237)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 31)
        Me.nextButton.TabIndex = 15
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(289, 237)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(75, 31)
        Me.previousButton.TabIndex = 16
        Me.previousButton.Text = "Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'monthCombo
        '
        Me.monthCombo.FormattingEnabled = True
        Me.monthCombo.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.monthCombo.Location = New System.Drawing.Point(353, 9)
        Me.monthCombo.Name = "monthCombo"
        Me.monthCombo.Size = New System.Drawing.Size(51, 24)
        Me.monthCombo.TabIndex = 17
        '
        'dayCombo
        '
        Me.dayCombo.FormattingEnabled = True
        Me.dayCombo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.dayCombo.Location = New System.Drawing.Point(410, 9)
        Me.dayCombo.Name = "dayCombo"
        Me.dayCombo.Size = New System.Drawing.Size(52, 24)
        Me.dayCombo.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(468, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "20"
        '
        'yearText
        '
        Me.yearText.Location = New System.Drawing.Point(487, 9)
        Me.yearText.MaxLength = 2
        Me.yearText.Name = "yearText"
        Me.yearText.Size = New System.Drawing.Size(26, 22)
        Me.yearText.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Month"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Year"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(422, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Day"
        '
        'warningLabel
        '
        Me.warningLabel.AutoSize = True
        Me.warningLabel.ForeColor = System.Drawing.Color.Red
        Me.warningLabel.Location = New System.Drawing.Point(12, 201)
        Me.warningLabel.Name = "warningLabel"
        Me.warningLabel.Size = New System.Drawing.Size(134, 17)
        Me.warningLabel.TabIndex = 25
        Me.warningLabel.Text = "Fix your information!"
        Me.warningLabel.Visible = False
        '
        'dataCombo
        '
        Me.dataCombo.FormattingEnabled = True
        Me.dataCombo.Location = New System.Drawing.Point(28, 42)
        Me.dataCombo.Name = "dataCombo"
        Me.dataCombo.Size = New System.Drawing.Size(164, 24)
        Me.dataCombo.TabIndex = 1
        '
        'outcomeLabel
        '
        Me.outcomeLabel.AutoSize = True
        Me.outcomeLabel.Location = New System.Drawing.Point(37, 107)
        Me.outcomeLabel.Name = "outcomeLabel"
        Me.outcomeLabel.Size = New System.Drawing.Size(59, 17)
        Me.outcomeLabel.TabIndex = 2
        Me.outcomeLabel.Text = "Label11"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 380)
        Me.Controls.Add(Me.warningLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.yearText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dayCombo)
        Me.Controls.Add(Me.monthCombo)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.typeComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.amountText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.friendCombo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idText As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents friendCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents amountText As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents typeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents monthCombo As System.Windows.Forms.ComboBox
    Friend WithEvents dayCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents yearText As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents warningLabel As System.Windows.Forms.Label
    Friend WithEvents dataCombo As System.Windows.Forms.ComboBox
    Friend WithEvents outcomeLabel As System.Windows.Forms.Label

End Class
