Module GumballMachineTestDrive

    Sub Main()
        Dim gumballMachine As New GumballMachine(5)

        Console.WriteLine(GumballMachine)

        GumballMachine.InsertQuarter()
        GumballMachine.TurnCrank()

        Console.WriteLine(gumballMachine)
        Console.ReadLine()

        GumballMachine.InsertQuarter()
        GumballMachine.EjectQuarter()
        GumballMachine.TurnCrank()

        Console.WriteLine(gumballMachine)
        Console.ReadLine()

        GumballMachine.InsertQuarter()
        GumballMachine.TurnCrank()
        GumballMachine.InsertQuarter()
        GumballMachine.TurnCrank()
        GumballMachine.EjectQuarter()

        Console.WriteLine(gumballMachine)
        Console.ReadLine()

        GumballMachine.InsertQuarter()
        GumballMachine.InsertQuarter()
        GumballMachine.TurnCrank()
        GumballMachine.InsertQuarter()
        GumballMachine.TurnCrank()
        GumballMachine.InsertQuarter()
        GumballMachine.TurnCrank()

        Console.WriteLine(gumballMachine)
        Console.ReadLine()
    End Sub

End Module
