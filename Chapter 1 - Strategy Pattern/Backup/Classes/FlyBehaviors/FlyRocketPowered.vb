Public Class FlyRocketPowered
    Implements IFlyBehavior

    Public Sub Fly() Implements IFlyBehavior.Fly
        Console.WriteLine("I'm flying with a rocket!")
    End Sub
End Class
