Public Class TV
    Private m_location As String
    Private m_channel As Integer

    Public Sub New(ByVal location As String)
        m_location = location
    End Sub

    Public Sub TurnOn()
        Console.WriteLine(m_location + " TV is on")
    End Sub

    Public Sub TurnOff()
        Console.WriteLine(m_location + " TV is off")
    End Sub

    Public Sub SetInputChannel()
        m_channel = 3
        Console.WriteLine("Channel is set for DVD")
    End Sub
End Class
