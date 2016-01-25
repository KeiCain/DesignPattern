Public Class Quack
    Implements IQuackBehavior

    Public Sub Quack() Implements IQuackBehavior.Quack
        Console.WriteLine("Quack")
    End Sub
End Class
