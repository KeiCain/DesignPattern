Module PizzaTestDrive

    Sub Main()
        Dim nyStore As PizzaStore = New NYPizzaStore
        Dim chicagoStore As PizzaStore = New ChicagoPizzaStore

        Dim pizza As Pizza = nyStore.OrderPizza("cheese")
        Console.WriteLine("Ethan ordered a " + pizza.Name + Environment.NewLine)

        pizza = chicagoStore.OrderPizza("cheese")
        Console.WriteLine("Joel ordered a " + pizza.Name + Environment.NewLine)
        Console.ReadLine()
    End Sub

End Module
