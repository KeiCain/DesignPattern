Public Class Tea
    Public Sub PrepareRecipe()
        BoilWater()
        SteepTeaBag()
        PourInCup()
        AddLemon()
    End Sub

    Public Sub BoilWater()
        Console.WriteLine("Boiling water")
    End Sub

    Public Sub SteepTeaBag()
        Console.WriteLine("Steeping the tea")
    End Sub

    Public Sub PourInCup()
        Console.WriteLine("Pouring into cup")
    End Sub

    Public Sub AddLemon()
        Console.WriteLine("Adding Lemon")
    End Sub
End Class
