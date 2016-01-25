Module StarbuzzCoffee

    Sub Main()
        Dim beverage As Beverage = New Espresso
        PrintBeverageInfo(beverage)

        Dim beverage2 As Beverage = New DarkRoast
        beverage2 = New Mocha(beverage2)
        beverage2 = New Mocha(beverage2)
        beverage2 = New Whip(beverage2)
        PrintBeverageInfo(beverage2)

        Dim beverage3 As Beverage = New HouseBlend
        beverage3 = New Soy(beverage3)
        beverage3 = New Mocha(beverage3)
        beverage3 = New Whip(beverage3)
        PrintBeverageInfo(beverage3)

        Console.ReadLine()
    End Sub

    Private Sub PrintBeverageInfo(ByVal beverage As Beverage)
        Console.WriteLine(beverage.Description + " $" + beverage.Cost.ToString)
    End Sub
End Module
