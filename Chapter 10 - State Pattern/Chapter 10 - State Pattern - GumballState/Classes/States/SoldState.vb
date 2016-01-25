Public Class SoldState
    Implements IState
    Private m_machine As GumballMachine

    Public Sub New(ByVal gumballMachine As GumballMachine)
        m_machine = gumballMachine
    End Sub

    Public Sub Dispense() Implements IState.Dispense
        m_machine.ReleaseBall()
        If m_machine.Count > 0 Then
            m_machine.State = m_machine.NoQuarterState
        Else
            Console.WriteLine("Oops, out of gumballs!")
            m_machine.State = m_machine.SoldOutState
        End If
    End Sub

    Public Sub EjectQuarter() Implements IState.EjectQuarter
        Console.WriteLine("Sorry, you already turned the crank")
    End Sub

    Public Sub InsertQuarter() Implements IState.InsertQuarter
        Console.WriteLine("Please wait, we're already giving you a gumball")
    End Sub

    Public Sub TurnCrank() Implements IState.TurnCrank
        Console.WriteLine("Turning twice doesn't get you another gumball!")
    End Sub

    Public Overrides Function ToString() As String
        Return "dispensing a gumball"
    End Function
End Class
