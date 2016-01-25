Public Class PopcornPopper
    Private m_description As String

    Public Sub New(ByVal description As String)
        m_description = description
    End Sub

    Public Sub TurnOn()
        Console.WriteLine(m_description + " on")
    End Sub

    Public Sub TurnOff()
        Console.WriteLine(m_description + " off")
    End Sub

    Public Sub Pop()
        Console.WriteLine(m_description + " popping popcorn!")
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
