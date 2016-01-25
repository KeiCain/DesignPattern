Module PizzaTestDrive

    Sub Main()
        Dim factory As New SimplePizzaFactory
        Dim store As New PizzaStore(factory)

        Dim pizza As Pizza = store.OrderPizza("cheese")
        Console.WriteLine("We ordered a " + pizza.Name + Environment.NewLine)

        pizza = store.OrderPizza("veggie")
        Console.WriteLine("We ordered a " + pizza.Name + Environment.NewLine)

        Console.ReadLine()
    End Sub

End Module
