Public Class Light
    Private m_location As String

    Public Sub New(ByVal location As String)
        m_location = location
    End Sub

    Public Sub TurnOn()
        Console.WriteLine(m_location + "light is on")
    End Sub

    Public Sub TurnOff()
        Console.WriteLine(m_location + "light is off")
    End Sub
End Class
