Imports System.Text

Public Class GumballMachine
    Public Enum MachineState
        SoldOut = 0
        NoQuarter = 1
        HasQuarter = 2
        Sold = 3
    End Enum

    Private m_state As MachineState = MachineState.SoldOut
    Private m_count As Integer = 0

    Public Sub New(ByVal count As Integer)
        m_count = count
        If count > 0 Then
            m_state = MachineState.NoQuarter
        End If
    End Sub

    Public Sub InsertQuarter()
        If (m_state = MachineState.HasQuarter) Then
            Console.WriteLine("You can't insert another quarter")
        ElseIf (m_state = MachineState.NoQuarter) Then
            m_state = MachineState.HasQuarter
            Console.WriteLine("You inserted a quarter")
        ElseIf (m_state = MachineState.SoldOut) Then
            Console.WriteLine("You can't insert a quarter, the machine is sold out")
        ElseIf (m_state = MachineState.Sold) Then
            Console.WriteLine("Please wait, we're already giving you a gumball")
        End If
    End Sub

    Public Sub EjectQuarter()
        If (m_state = MachineState.HasQuarter) Then
            Console.WriteLine("Quarter returned")
            m_state = MachineState.NoQuarter
        ElseIf (m_state = MachineState.NoQuarter) Then
            Console.WriteLine("You haven't inserted a quarter")
        ElseIf (m_state = MachineState.Sold) Then
            Console.WriteLine("Sorry, you already turned the crank")
        ElseIf (m_state = MachineState.SoldOut) Then
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet")
        End If
    End Sub

    Public Sub TurnCrank()
        If (m_state = MachineState.Sold) Then
            Console.WriteLine("Turning twice doesn't get you another gumball!")
        ElseIf (m_state = MachineState.NoQuarter) Then
            Console.WriteLine("You turned but there's no quarter")
        ElseIf (m_state = MachineState.SoldOut) Then
            Console.WriteLine("You turned, but there are no gumballs")
        ElseIf (m_state = MachineState.HasQuarter) Then
            Console.WriteLine("You turned...")
            m_state = MachineState.Sold
            Dispense()
        End If
    End Sub

    Public Sub Dispense()
        If (m_state = MachineState.Sold) Then
            Console.WriteLine("A gumball comes rolling out the slot")
            m_count = m_count - 1
            If (m_count = 0) Then
                Console.WriteLine("Oops, out of gumballs!")
                m_state = MachineState.SoldOut
            Else
                m_state = MachineState.NoQuarter
            End If
        ElseIf (m_state = MachineState.NoQuarter) Then
            Console.WriteLine("You need to pay first")
        ElseIf (m_state = MachineState.SoldOut) Then
            Console.WriteLine("No gumball dispensed")
        ElseIf (m_state = MachineState.HasQuarter) Then
            Console.WriteLine("No gumball dispensed")
        End If
    End Sub

    Public Sub Refill(ByVal numGumBalls As Integer)
        m_count = numGumBalls
        m_state = MachineState.NoQuarter
    End Sub

    Public Overrides Function ToString() As String
        Dim result As New stringbuilder
        result.AppendLine(Environment.NewLine + "Mighty Gumball, Inc.")
        result.AppendLine("VB-enabled Standing Gumball Model #2004")
        result.Append("Inventory: " + m_count.ToString + " gumball")
        If m_count <> 1 Then
            result.AppendLine("s")
        Else
            result.AppendLine()
        End If
        result.Append("Machine is ")
        If m_state = MachineState.SoldOut Then
            result.AppendLine("sold out")
        ElseIf m_state = MachineState.NoQuarter Then
            result.AppendLine("waiting for quarter")
        ElseIf m_state = MachineState.HasQuarter Then
            result.AppendLine("waiting for turn of crank")
        ElseIf m_state = MachineState.Sold Then
            result.AppendLine("delivering a gumball")
        End If

        Return result.ToString()
    End Function

End Class
