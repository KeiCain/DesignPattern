Module ChocolateController

    Sub Main()
        Dim boiler As ChocolateBoiler = ChocolateBoiler.GetInstance
        boiler.Fill()
        boiler.Boil()
        boiler.Drain()
        Console.ReadLine()

        Dim boiler2 As ChocolateBoiler = ChocolateBoiler.GetInstance
        Console.ReadLine()
    End Sub

End Module
