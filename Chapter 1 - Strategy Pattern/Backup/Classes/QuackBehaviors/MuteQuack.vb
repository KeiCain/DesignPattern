Public Class MuteQuack
    Implements IQuackBehavior

    Public Sub Quack() Implements IQuackBehavior.Quack
        Console.WriteLine("<< Silence >>")
    End Sub
End Class
