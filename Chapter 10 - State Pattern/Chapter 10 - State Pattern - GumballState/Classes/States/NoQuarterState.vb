Public Class NoQuarterState
    Implements IState
    Private m_machine As GumballMachine

    Public Sub New(ByVal gumballMachine As GumballMachine)
        m_machine = gumballMachine
    End Sub

    Public Sub Dispense() Implements IState.Dispense
        Console.WriteLine("You need to pay first")
    End Sub

    Public Sub EjectQuarter() Implements IState.EjectQuarter
        Console.WriteLine("You haven't inserted a quarter")
    End Sub

    Public Sub InsertQuarter() Implements IState.InsertQuarter
        Console.WriteLine("You inserted a quarter")
        m_machine.State = m_machine.HasQuarterState
    End Sub

    Public Sub TurnCrank() Implements IState.TurnCrank
        Console.WriteLine("You turned, but there's no quarter")
    End Sub

    Public Overrides Function ToString() As String
        Return "waiting for quarter"
    End Function
End Class
