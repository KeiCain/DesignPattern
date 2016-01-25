Public MustInherit Class CaffeineBeverageWithHook
    Public Sub PrepareRecipe()
        BoilWater()
        Brew()
        PourInCup()
        If CustomerWantsCondiments() Then
            AddCondiments()
        End If
    End Sub

    Public MustOverride Sub Brew()
    Public MustOverride Sub AddCondiments()

    Public Sub BoilWater()
        Console.WriteLine("Boiling water")
    End Sub

    Public Sub PourInCup()
        Console.WriteLine("Pouring into cup")
    End Sub

    Public Overridable Function CustomerWantsCondiments() As Boolean
        Return True
    End Function
End Class
