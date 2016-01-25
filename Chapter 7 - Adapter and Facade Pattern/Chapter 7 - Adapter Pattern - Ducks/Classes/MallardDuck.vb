Public Class MallardDuck
    Implements IDuck

    Public Sub Fly() Implements IDuck.Fly
        Console.WriteLine("I'm flying")
    End Sub

    Public Sub Quack() Implements IDuck.Quack
        Console.WriteLine("Quack")
    End Sub
End Class
