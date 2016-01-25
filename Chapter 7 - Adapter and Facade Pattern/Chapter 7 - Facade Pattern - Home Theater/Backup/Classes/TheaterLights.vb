Public Class TheaterLights
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

    Public Sub SetLevel(ByVal level As Integer)
        Console.WriteLine(m_description + " changing level to " + level.ToString + "%")
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
