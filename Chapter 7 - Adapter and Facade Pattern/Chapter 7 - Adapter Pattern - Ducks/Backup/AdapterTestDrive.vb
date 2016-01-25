Module AdapterTestDrive

    Sub Main()
        Dim mallardDuck As New MallardDuck
        Dim wildTurkey As New WildTurkey
        Dim duckAdapter As ITurkey = New DuckAdapter(mallardDuck)
        Dim turkeyAdapter As IDuck = New TurkeyAdapter(wildTurkey)

        Console.WriteLine("The turkey says...")
        TestTurkey(wildTurkey)

        Console.WriteLine("The duck says...")
        TestDuck(mallardDuck)

        Console.WriteLine("The turkey adapter says...")
        TestDuck(turkeyAdapter)

        Console.WriteLine("The duck adapter says...")
        TestTurkey(duckAdapter)

        Console.ReadLine()
    End Sub

    Private Sub TestDuck(ByVal duck As IDuck)
        duck.Quack()
        duck.Fly()
    End Sub

    Private Sub TestTurkey(ByVal turkey As ITurkey)
        turkey.Gobble()
        turkey.Fly()
    End Sub
End Module
