<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnTransaction
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
        Me.transactionCombo = New System.Windows.Forms.ComboBox()
        Me.performReturnButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction:"
        '
        'transactionCombo
        '
        Me.transactionCombo.FormattingEnabled = True
        Me.transactionCombo.Location = New System.Drawing.Point(135, 39)
        Me.transactionCombo.Name = "transactionCombo"
        Me.transactionCombo.Size = New System.Drawing.Size(121, 24)
        Me.transactionCombo.TabIndex = 1
        '
        'performReturnButton
        '
        Me.performReturnButton.Location = New System.Drawing.Point(65, 83)
        Me.performReturnButton.Name = "performReturnButton"
        Me.performReturnButton.Size = New System.Drawing.Size(132, 60)
        Me.performReturnButton.TabIndex = 2
        Me.performReturnButton.Text = "Perform Return"
        Me.performReturnButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(217, 83)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(112, 60)
        Me.stopButton.TabIndex = 3
        Me.stopButton.Text = "Cancel"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'ReturnTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 167)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.performReturnButton)
        Me.Controls.Add(Me.transactionCombo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReturnTransaction"
        Me.Text = "Return Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents transactionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents performReturnButton As System.Windows.Forms.Button
    Friend WithEvents stopButton As System.Windows.Forms.Button
End Class
