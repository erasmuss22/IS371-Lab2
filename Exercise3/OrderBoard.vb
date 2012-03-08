' this class represents the status of orders
Public Class OrderBoard

    Private Sub OrderBoard_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub OrderBoard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler Admin.Restaurant1.OrderUpdate, AddressOf Me.Order_Update
    End Sub

    ' this method updates the board with each order. It also checks if the order status
    ' for that order is already in the board.
    Private Sub Order_Update(sender As Object, e As RestaurantEventArgs)
        Dim problems = False
        Admin.redundantLabel.Visible = False
        If e.eventOrderStat.Equals("Order Taken") Then
            For Each row As DataGridViewRow In orderUpdateBoard.Rows
                If row.Cells(0).Value = e.eventOrderNum Then
                    If row.Cells(1).Value.Equals("Order Taken") Then
                        Admin.redundantLabel.Text = "Order has already been taken!"
                        problems = True
                    End If
                    If row.Cells(1).Value.Equals("Order in Process") Then
                        Admin.redundantLabel.Text = "Order has already been taken and processed!"
                        problems = True
                    End If
                    If row.Cells(1).Value.Equals("Order Ready") Then
                        Admin.redundantLabel.Text = "Order is already ready!"
                        problems = True
                    End If
                    Admin.redundantLabel.Visible = True
                End If
            Next
        ElseIf e.eventOrderStat.Equals("Order in Process") Then
            For Each row As DataGridViewRow In orderUpdateBoard.Rows
                If row.Cells(0).Value = e.eventOrderNum Then
                    If row.Cells(1).Value.Equals("Order in Process") Then
                        Admin.redundantLabel.Text = "Order has already been processed!"
                        Admin.redundantLabel.Visible = True
                        problems = True
                    End If
                    If row.Cells(1).Value.Equals("Order Ready") Then
                        Admin.redundantLabel.Text = "Order is already ready!"
                        Admin.redundantLabel.Visible = True
                        problems = True
                    End If

                End If
            Next
        ElseIf e.eventOrderStat.Equals("Order Ready") Then
            For Each row As DataGridViewRow In orderUpdateBoard.Rows
                If row.Cells(0).Value = e.eventOrderNum Then
                    If row.Cells(1).Value.Equals("Order Ready") Then
                        Admin.redundantLabel.Text = "Order is already ready!"
                        problems = True
                        Admin.redundantLabel.Visible = True
                    End If
                End If
            Next
        End If

        If problems = False Then
            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = e.eventOrderNum
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = e.eventOrderStat
            dgvRow.Cells.Add(dgvCell)

            orderUpdateBoard.Rows.Add(dgvRow)
        End If
    End Sub
End Class