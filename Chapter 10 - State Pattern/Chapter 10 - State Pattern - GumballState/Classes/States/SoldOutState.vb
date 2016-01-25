Public Class SoldOutState
    Implements IState
    Private m_machine As GumballMachine

    Public Sub New(ByVal gumballMachine As GumballMachine)
        m_machine = gumballMachine
    End Sub

    Public Sub Dispense() Implements IState.Dispense
        Console.WriteLine("No gumball dispensed")
    End Sub

    Public Sub EjectQuarter() Implements IState.EjectQuarter
        Console.WriteLine("You can't eject, you haven't inserted a quarter yet")
    End Sub

    Public Sub InsertQuarter() Implements IState.InsertQuarter
        Console.WriteLine("You can't insert a quarter, the machine is sold out")
    End Sub

    Public Sub TurnCrank() Implements IState.TurnCrank
        Console.WriteLine("You turned, but there are no gumballs")
    End Sub

    Public Overrides Function ToString() As String
        Return "sold out"
    End Function
End Class
