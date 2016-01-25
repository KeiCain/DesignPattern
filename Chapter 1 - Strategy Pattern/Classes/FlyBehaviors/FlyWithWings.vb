Public Class FlyWithWings
    Implements IFlyBehavior

    Public Sub Fly() Implements IFlyBehavior.Fly
        Console.WriteLine("I'm flying!")
    End Sub
End Class
