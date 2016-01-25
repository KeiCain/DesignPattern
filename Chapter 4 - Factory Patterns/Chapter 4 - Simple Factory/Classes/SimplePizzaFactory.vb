Public Class SimplePizzaFactory
    Public Function CreatePizza(ByVal type As String) As Pizza
        Select Case type
            Case "cheese"
                Return New CheesePizza
            Case "pepperoni"
                Return New PepperoniPizza
            Case "clam"
                Return New ClamPizza
            Case "veggie"
                Return New VeggiePizza
            Case Else
                Return Nothing
        End Select
    End Function
End Class
