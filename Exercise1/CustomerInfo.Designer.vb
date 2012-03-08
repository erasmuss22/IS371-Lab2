<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInfo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.okayButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.zipLabel = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.owedLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Purchases:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount Owed:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Zip Code:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "State:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "City:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Address:"
        '
        'okayButton
        '
        Me.okayButton.Location = New System.Drawing.Point(117, 318)
        Me.okayButton.Name = "okayButton"
        Me.okayButton.Size = New System.Drawing.Size(75, 23)
        Me.okayButton.TabIndex = 10
        Me.okayButton.Text = "Okay"
        Me.okayButton.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nameLabel.Location = New System.Drawing.Point(131, 20)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(61, 19)
        Me.nameLabel.TabIndex = 11
        Me.nameLabel.Text = "Label11"
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.addressLabel.Location = New System.Drawing.Point(131, 47)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(61, 19)
        Me.addressLabel.TabIndex = 12
        Me.addressLabel.Text = "Label12"
        '
        'cityLabel
        '
        Me.cityLabel.AutoSize = True
        Me.cityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cityLabel.Location = New System.Drawing.Point(131, 79)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(61, 19)
        Me.cityLabel.TabIndex = 13
        Me.cityLabel.Text = "Label13"
        '
        'stateLabel
        '
        Me.stateLabel.AutoSize = True
        Me.stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.stateLabel.Location = New System.Drawing.Point(131, 107)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(61, 19)
        Me.stateLabel.TabIndex = 14
        Me.stateLabel.Text = "Label14"
        '
        'zipLabel
        '
        Me.zipLabel.AutoSize = True
        Me.zipLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.zipLabel.Location = New System.Drawing.Point(131, 139)
        Me.zipLabel.Name = "zipLabel"
        Me.zipLabel.Size = New System.Drawing.Size(61, 19)
        Me.zipLabel.TabIndex = 15
        Me.zipLabel.Text = "Label15"
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.phoneLabel.Location = New System.Drawing.Point(131, 168)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(61, 19)
        Me.phoneLabel.TabIndex = 16
        Me.phoneLabel.Text = "Label16"
        '
        'owedLabel
        '
        Me.owedLabel.AutoSize = True
        Me.owedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.owedLabel.Location = New System.Drawing.Point(131, 245)
        Me.owedLabel.Name = "owedLabel"
        Me.owedLabel.Size = New System.Drawing.Size(61, 19)
        Me.owedLabel.TabIndex = 17
        Me.owedLabel.Text = "Label17"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(131, 275)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(61, 19)
        Me.totalLabel.TabIndex = 18
        Me.totalLabel.Text = "Label18"
        '
        'CustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 413)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.owedLabel)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.zipLabel)
        Me.Controls.Add(Me.stateLabel)
        Me.Controls.Add(Me.cityLabel)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.okayButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomerInfo"
        Me.Text = "Customer Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents okayButton As System.Windows.Forms.Button
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents addressLabel As System.Windows.Forms.Label
    Friend WithEvents cityLabel As System.Windows.Forms.Label
    Friend WithEvents stateLabel As System.Windows.Forms.Label
    Friend WithEvents zipLabel As System.Windows.Forms.Label
    Friend WithEvents phoneLabel As System.Windows.Forms.Label
    Friend WithEvents owedLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
End Class
