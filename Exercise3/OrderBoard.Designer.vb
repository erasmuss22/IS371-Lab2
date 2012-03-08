<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderBoard
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
        Me.orderUpdateBoard = New System.Windows.Forms.DataGridView()
        Me.OrderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.orderUpdateBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'orderUpdateBoard
        '
        Me.orderUpdateBoard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.orderUpdateBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderUpdateBoard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNum, Me.Status})
        Me.orderUpdateBoard.Location = New System.Drawing.Point(87, 26)
        Me.orderUpdateBoard.Name = "orderUpdateBoard"
        Me.orderUpdateBoard.RowTemplate.Height = 24
        Me.orderUpdateBoard.Size = New System.Drawing.Size(243, 282)
        Me.orderUpdateBoard.TabIndex = 0
        '
        'OrderNum
        '
        Me.OrderNum.HeaderText = "Order Number"
        Me.OrderNum.Name = "OrderNum"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'OrderBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 343)
        Me.Controls.Add(Me.orderUpdateBoard)
        Me.Name = "OrderBoard"
        Me.Text = "Order Board"
        CType(Me.orderUpdateBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents orderUpdateBoard As System.Windows.Forms.DataGridView
    Friend WithEvents OrderNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
