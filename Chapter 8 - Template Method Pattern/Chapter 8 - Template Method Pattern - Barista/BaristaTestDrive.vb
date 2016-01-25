Module BaristaTestDrive

    Sub Main()
        Dim tea As New Tea
        Dim coffee As New Coffee

        Console.WriteLine("Making tea...")
        tea.PrepareRecipe()

        Console.WriteLine(Environment.NewLine + "Making coffee...")
        coffee.PrepareRecipe()
        Console.ReadLine()

        Dim teaHook As New TeaWithHook
        Dim coffeeHook As New CoffeeWithHook

        Console.WriteLine("Making tea...")
        teaHook.PrepareRecipe()

        Console.WriteLine(Environment.NewLine + "Making coffee...")
        coffeeHook.PrepareRecipe()
        Console.ReadLine()
    End Sub

End Module
