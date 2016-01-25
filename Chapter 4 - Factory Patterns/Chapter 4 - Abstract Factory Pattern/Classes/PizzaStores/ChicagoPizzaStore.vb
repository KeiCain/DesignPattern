Public Class ChicagoPizzaStore
    Inherits PizzaStore

    Protected Overrides Function CreatePizza(ByVal type As String) As Pizza
        Dim pizza As Pizza = Nothing
        Dim ingredientFactory As IPizzaIngredientFactory = New ChicagoPizzaIngredientFactory

        Select Case type
            Case "cheese"
                pizza = New CheesePizza(ingredientFactory)
                pizza.Name = "Chicago Style Cheese Pizza"
            Case "veggie"
                pizza = New VeggiePizza(ingredientFactory)
                pizza.Name = "Chicago Style Veggie Pizza"
            Case "pepperoni"
                pizza = New PepperoniPizza(ingredientFactory)
                pizza.Name = "Chicago Style Pepperoni Pizza"
            Case "clam"
                pizza = New ClamPizza(ingredientFactory)
                pizza.Name = "Chicago Style Clam Pizza"
        End Select

        Return pizza
    End Function
End Class
