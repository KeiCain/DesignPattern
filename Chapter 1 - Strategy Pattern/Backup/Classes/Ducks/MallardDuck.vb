Public Class MallardDuck
    Inherits Duck

    Public Sub New()
        flyBehavior = New FlyWithWings
        quackBehavior = New Quack
    End Sub

    Public Overrides Sub Display()
        Console.WriteLine("I'm a real Mallard duck")
    End Sub
End Class
