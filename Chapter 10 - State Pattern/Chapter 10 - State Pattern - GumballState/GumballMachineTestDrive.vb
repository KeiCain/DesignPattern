Module GumballMachineTestDrive

    Sub Main()
        Dim gumballMachine As New GumballMachine(5)

        Console.WriteLine(gumballMachine)

        gumballMachine.InsertQuarter()
        gumballMachine.TurnCrank()

        Console.WriteLine(gumballMachine)
        Console.ReadLine()

        gumballMachine.InsertQuarter()
        gumballMachine.TurnCrank()
        gumballMachine.InsertQuarter()
        gumballMachine.TurnCrank()

        Console.WriteLine(gumballMachine)
        Console.ReadLine()
    End Sub

End Module
