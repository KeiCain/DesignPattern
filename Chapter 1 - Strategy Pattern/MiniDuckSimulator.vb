Module MiniDuckSimulator

    Sub Main()
        Dim mallard As Duck = New MallardDuck
        mallard.PerformQuack()
        mallard.PerformFly()
        Console.ReadLine()

        Dim model As Duck = New ModelDuck
        model.PerformFly()
        model.FlyBehavior = New FlyRocketPowered
        model.PerformFly()
        Console.ReadLine()

        Dim mallardCall As DuckCall = New MallardDuckCall
        mallardCall.PerformCall()

        'The mallard hears the call and is enticed!
        mallard.PerformQuack()
        Console.ReadLine()

        'Rubber duck!
        Dim rubberDuckie As Duck = New RubberDuck
        rubberDuckie.PerformFly()
        rubberDuckie.PerformQuack()
        Console.ReadLine()
    End Sub

End Module
