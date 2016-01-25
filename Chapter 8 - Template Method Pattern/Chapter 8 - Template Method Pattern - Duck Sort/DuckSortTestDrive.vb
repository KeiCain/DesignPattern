Module DuckSortTestDrive

    Sub Main()
        Dim ducks As Duck() = { _
                New Duck("Daffy", 8), _
                New Duck("Dewey", 2), _
                New Duck("Howard", 7), _
                New Duck("Louie", 2), _
                New Duck("Donald", 10), _
                New Duck("Huey", 2)}

        Console.WriteLine("Before sorting:")
        Display(ducks)

        Array.Sort(ducks)

        Console.WriteLine(Environment.NewLine + "After sorting:")
        Display(ducks)
        Console.ReadLine()
    End Sub

    Private Sub Display(ByVal ducks As Duck())
        For Each duck As Duck In ducks
            Console.WriteLine(duck.ToString)
        Next
    End Sub
End Module
