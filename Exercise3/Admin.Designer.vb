<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.scanNewButton = New System.Windows.Forms.Button()
        Me.numberCombo = New System.Windows.Forms.ComboBox()
        Me.statusCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.warningLabel = New System.Windows.Forms.Label()
        Me.redundantLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'scanNewButton
        '
        Me.scanNewButton.Location = New System.Drawing.Point(28, 51)
        Me.scanNewButton.Name = "scanNewButton"
        Me.scanNewButton.Size = New System.Drawing.Size(94, 23)
        Me.scanNewButton.TabIndex = 0
        Me.scanNewButton.Text = "Scan New"
        Me.scanNewButton.UseVisualStyleBackColor = True
        '
        'numberCombo
        '
        Me.numberCombo.FormattingEnabled = True
        Me.numberCombo.Location = New System.Drawing.Point(149, 50)
        Me.numberCombo.Name = "numberCombo"
        Me.numberCombo.Size = New System.Drawing.Size(128, 24)
        Me.numberCombo.TabIndex = 1
        '
        'statusCombo
        '
        Me.statusCombo.FormattingEnabled = True
        Me.statusCombo.Items.AddRange(New Object() {"Order Taken", "Order in Process", "Order Ready"})
        Me.statusCombo.Location = New System.Drawing.Point(300, 50)
        Me.statusCombo.Name = "statusCombo"
        Me.statusCombo.Size = New System.Drawing.Size(144, 24)
        Me.statusCombo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Order Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Order Status"
        '
        'warningLabel
        '
        Me.warningLabel.AutoSize = True
        Me.warningLabel.ForeColor = System.Drawing.Color.Red
        Me.warningLabel.Location = New System.Drawing.Point(161, 88)
        Me.warningLabel.Name = "warningLabel"
        Me.warningLabel.Size = New System.Drawing.Size(108, 17)
        Me.warningLabel.TabIndex = 5
        Me.warningLabel.Text = "Select an order!"
        '
        'redundantLabel
        '
        Me.redundantLabel.AutoSize = True
        Me.redundantLabel.ForeColor = System.Drawing.Color.Red
        Me.redundantLabel.Location = New System.Drawing.Point(262, 88)
        Me.redundantLabel.Name = "redundantLabel"
        Me.redundantLabel.Size = New System.Drawing.Size(51, 17)
        Me.redundantLabel.TabIndex = 6
        Me.redundantLabel.Text = "Label3"
        Me.redundantLabel.Visible = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 128)
        Me.Controls.Add(Me.redundantLabel)
        Me.Controls.Add(Me.warningLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.statusCombo)
        Me.Controls.Add(Me.numberCombo)
        Me.Controls.Add(Me.scanNewButton)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scanNewButton As System.Windows.Forms.Button
    Friend WithEvents numberCombo As System.Windows.Forms.ComboBox
    Friend WithEvents statusCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents warningLabel As System.Windows.Forms.Label
    Friend WithEvents redundantLabel As System.Windows.Forms.Label

End Class
