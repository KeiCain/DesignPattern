Public Class NYPizzaStore
    Inherits PizzaStore

    Protected Overrides Function CreatePizza(ByVal type As String) As Pizza
        Dim pizza As Pizza = Nothing
        Dim ingredientFactory As IPizzaIngredientFactory = New NYPizzaIngredientFactory

        Select Case type
            Case "cheese"
                pizza = New CheesePizza(ingredientFactory)
                pizza.Name = "New York Style Cheese Pizza"
            Case "veggie"
                pizza = New VeggiePizza(ingredientFactory)
                pizza.Name = "New York Style Veggie Pizza"
            Case "pepperoni"
                pizza = New PepperoniPizza(ingredientFactory)
                pizza.Name = "New York Style Pepperoni Pizza"
            Case "clam"
                pizza = New ClamPizza(ingredientFactory)
                pizza.Name = "New York Style Clam Pizza"
        End Select

        Return pizza
    End Function
End Class
