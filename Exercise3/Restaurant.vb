' this class raises an event for orders
Public Class Restaurant
    Public Event OrderUpdate(ByVal sender As Object, ByVal e As RestaurantEventArgs)

    Public Overridable Sub OnUpdate(ByVal e As RestaurantEventArgs)
        RaiseEvent OrderUpdate(Me, e)
    End Sub
End Class
