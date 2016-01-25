Module Barista

    Sub Main()
        Dim tea As New Tea
        Dim coffee As New Coffee

        Console.WriteLine("Making tea...")
        tea.PrepareRecipe()
        Console.WriteLine(Environment.NewLine + "Making coffee...")
        coffee.PrepareRecipe()

        Console.ReadLine()
    End Sub

End Module
