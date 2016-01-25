Public MustInherit Class PizzaStore
    Public Function OrderPizza(ByVal type As String) As Pizza
        Dim pizza As Pizza
        pizza = CreatePizza(type)

        pizza.Prepare()
        pizza.Bake()
        pizza.Cut()
        pizza.Box()

        Return pizza
    End Function

    Protected MustOverride Function CreatePizza(ByVal type As String) As Pizza

    'other methods here
End Class
