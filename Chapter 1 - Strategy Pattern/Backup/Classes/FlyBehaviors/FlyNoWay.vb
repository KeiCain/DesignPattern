Public Class FlyNoWay
    Implements IFlyBehavior

    Public Sub Fly() Implements IFlyBehavior.Fly
        Console.WriteLine("I can't fly!")
    End Sub
End Class
