Public Class Coffee
    Public Sub PrepareRecipe()
        BoilWater()
        BrewCoffeeGrinds()
        PourInCup()
        AddSugarAndMilk()
    End Sub

    Public Sub BoilWater()
        Console.WriteLine("Boiling water")
    End Sub

    Public Sub BrewCoffeeGrinds()
        Console.WriteLine("Dripping Coffee through filter")
    End Sub

    Public Sub PourInCup()
        Console.WriteLine("Pouring into cup")
    End Sub

    Public Sub AddSugarAndMilk()
        Console.WriteLine("Adding Sugar and Milk")
    End Sub
End Class
