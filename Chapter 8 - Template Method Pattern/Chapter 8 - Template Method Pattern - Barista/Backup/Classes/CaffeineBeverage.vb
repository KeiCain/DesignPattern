Public MustInherit Class CaffeineBeverage
    Public Sub PrepareRecipe()
        BoilWater()
        Brew()
        PourInCup()
        AddCondiments()
    End Sub

    Public MustOverride Sub Brew()
    Public MustOverride Sub AddCondiments()

    Public Sub BoilWater()
        Console.WriteLine("Boiling water")
    End Sub

    Public Sub PourInCup()
        Console.WriteLine("Pouring into cup")
    End Sub
End Class
