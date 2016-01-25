Public Class HasQuarterState
    Implements IState
    Private m_machine As GumballMachine

    Public Sub New(ByVal gumballMachine As GumballMachine)
        m_machine = gumballMachine
    End Sub

    Public Sub Dispense() Implements IState.Dispense
        Console.WriteLine("No gumball dispensed")
    End Sub

    Public Sub EjectQuarter() Implements IState.EjectQuarter
        Console.WriteLine("Quarter returned")
        m_machine.State = m_machine.NoQuarterState
    End Sub

    Public Sub InsertQuarter() Implements IState.InsertQuarter
        Console.WriteLine("You can't insert another quarter")
    End Sub

    Public Sub TurnCrank() Implements IState.TurnCrank
        Console.WriteLine("You turned...")
        m_machine.State = m_machine.SoldState
    End Sub

    Public Overrides Function ToString() As String
        Return "waiting for turn of crank"
    End Function
End Class
