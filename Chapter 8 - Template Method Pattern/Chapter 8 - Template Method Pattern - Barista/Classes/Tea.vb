Public Class Tea
    Inherits CaffeineBeverage

    Public Overrides Sub AddCondiments()
        Console.WriteLine("Add Lemon")
    End Sub

    Public Overrides Sub Brew()
        Console.WriteLine("Steeping the tea")
    End Sub
End Class
