Public Class WildTurkey
    Implements ITurkey

    Public Sub Fly() Implements ITurkey.Fly
        Console.WriteLine("I'm flying a short distance")
    End Sub

    Public Sub Gobble() Implements ITurkey.Gobble
        Console.WriteLine("Gobble gobble")
    End Sub
End Class
