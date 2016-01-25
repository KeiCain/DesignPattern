Public Class Squeak
    Implements IQuackBehavior

    Public Sub Quack() Implements IQuackBehavior.Quack
        Console.WriteLine("Squeak")
    End Sub
End Class
