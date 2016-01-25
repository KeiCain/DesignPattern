Public Class WinnerState
    Implements IState
    Private m_machine As GumballMachine

    Public Sub New(ByVal gumballMachine As GumballMachine)
        m_machine = gumballMachine
    End Sub

    Public Sub Dispense() Implements IState.Dispense
        Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter")
        m_machine.ReleaseBall()
        If m_machine.Count = 0 Then
            m_machine.State = m_machine.SoldOutState
        Else
            m_machine.ReleaseBall()
            If m_machine.Count > 0 Then
                m_machine.State = m_machine.NoQuarterState
            Else
                Console.WriteLine("Oops, out of gumballs!")
                m_machine.State = m_machine.SoldOutState
            End If
        End If
    End Sub

    Public Sub EjectQuarter() Implements IState.EjectQuarter
        Console.WriteLine("Please wait, we're already giving you a Gumball")
    End Sub

    Public Sub InsertQuarter() Implements IState.InsertQuarter
        Console.WriteLine("Please wait, we're already giving you a Gumball")
    End Sub

    Public Sub TurnCrank() Implements IState.TurnCrank
        Console.WriteLine("Turning again doesn't get you another gumball!")
    End Sub

    Public Overrides Function ToString() As String
        Return "dispensing two gumballs for your quarter, because YOU'RE A WINNER!"
    End Function
End Class
