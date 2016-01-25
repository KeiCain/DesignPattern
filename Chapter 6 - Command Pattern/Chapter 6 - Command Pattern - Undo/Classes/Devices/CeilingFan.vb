Public Class CeilingFan
    Private m_location As String
    Private m_level As FanSpeed

    Public Enum FanSpeed
        High = 3
        Medium = 2
        Low = 1
        Off = 0
    End Enum

    Public Sub New(ByVal location As String)
        m_location = location
    End Sub

    Public Property Level() As FanSpeed
        Get
            Return m_level
        End Get
        Set(ByVal value As FanSpeed)
            m_level = value
            Console.WriteLine(m_location + " ceiling fan set to " + m_level.ToString)
        End Set
    End Property
End Class
