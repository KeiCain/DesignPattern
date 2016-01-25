Public MustInherit Class PizzaStore
    Protected MustOverride Function CreatePizza(ByVal type As String) As Pizza

    Public Function OrderPizza(ByVal type As String) As Pizza
        Dim pizza As Pizza = CreatePizza(type)
        Console.WriteLine("--- Making a " + pizza.Name + " ---")

        pizza.Prepare()
        pizza.Bake()
        pizza.Cut()
        pizza.Box()

        Return pizza
    End Function
End Class
