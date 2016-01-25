Public Class ChicagoPizzaStore
    Inherits PizzaStore

    Protected Overrides Function CreatePizza(ByVal type As String) As Pizza
        Select Case type
            Case "cheese"
                Return New ChicagoStyleCheesePizza()
            Case "veggie"
                Return New ChicagoStyleVeggiePizza()
            Case "clam"
                Return New ChicagoStyleClamPizza()
            Case "pepperoni"
                Return New ChicagoStylePepperoniPizza()
            Case Else
                Return Nothing
        End Select
    End Function
End Class