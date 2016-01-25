Module PizzaTestDrive

    Sub Main()
        Dim nyStore As PizzaStore = New NYPizzaStore
        Dim chicagoStore As PizzaStore = New ChicagoPizzaStore

        Dim pizza As Pizza = nyStore.OrderPizza("cheese")
        Console.WriteLine("Ethan ordered a " + pizza.ToString + Environment.NewLine)

        pizza = chicagoStore.OrderPizza("cheese")
        Console.WriteLine("Joel ordered a " + pizza.ToString + Environment.NewLine)
        Console.ReadLine()

        pizza = nyStore.OrderPizza("clam")
        Console.WriteLine("Ethan ordered a " + pizza.ToString + Environment.NewLine)

        pizza = chicagoStore.OrderPizza("clam")
        Console.WriteLine("Joel ordered a " + pizza.ToString + Environment.NewLine)
        Console.ReadLine()

        pizza = nyStore.OrderPizza("pepperoni")
        Console.WriteLine("Ethan ordered a " + pizza.ToString + Environment.NewLine)

        pizza = chicagoStore.OrderPizza("pepperoni")
        Console.WriteLine("Joel ordered a " + pizza.ToString + Environment.NewLine)
        Console.ReadLine()

        pizza = nyStore.OrderPizza("veggie")
        Console.WriteLine("Ethan ordered a " + pizza.ToString + Environment.NewLine)

        pizza = chicagoStore.OrderPizza("veggie")
        Console.WriteLine("Joel ordered a " + pizza.ToString + Environment.NewLine)
        Console.ReadLine()

    End Sub

End Module
