Public Class Coffee
    Inherits CaffeineBeverage

    Public Overrides Sub AddCondiments()
        Console.WriteLine("Add Sugar and Milk")
    End Sub

    Public Overrides Sub Brew()
        Console.WriteLine("Dripping Coffee through filter")
    End Sub
End Class
