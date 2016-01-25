Public Class NYPizzaStore
    Inherits PizzaStore

    Protected Overrides Function CreatePizza(ByVal type As String) As Pizza
        Select Case type
            Case "cheese"
                Return New NYStyleCheesePizza()
            Case "veggie"
                Return New NYStyleVeggiePizza()
            Case "clam"
                Return New NYStyleClamPizza()
            Case "pepperoni"
                Return New NYStylePepperoniPizza()
            Case Else
                Return Nothing
        End Select
    End Function
End Class