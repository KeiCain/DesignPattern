Public Class Light
    Private m_location As String
    Private m_level As Integer
    Public Property Level() As Integer
        Get
            Return m_level
        End Get
        Set(ByVal value As Integer)
            m_level = value
            If m_level = 0 Then
                TurnOff()
            Else
                Console.WriteLine(m_location + " light is set to " + m_level.ToString + "%")
            End If
        End Set
    End Property

    Public Sub New(ByVal location As String)
        m_location = location
    End Sub

    Public Sub TurnOn()
        m_level = 100
        Console.WriteLine(m_location + " light is on")
    End Sub

    Public Sub TurnOff()
        m_level = 0
        Console.WriteLine(m_location + " light is off")
    End Sub
End Class
