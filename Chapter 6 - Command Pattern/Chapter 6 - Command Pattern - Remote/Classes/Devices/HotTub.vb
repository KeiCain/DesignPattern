Public Class HotTub
    Private m_isOn As Boolean
    Private m_temperature As Integer

    Public Property Temperature() As Integer
        Get
            Return m_temperature
        End Get
        Set(ByVal value As Integer)
            m_temperature = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub TurnOn()
        m_isOn = True
    End Sub

    Public Sub TurnOff()
        m_isOn = False
    End Sub

    Public Sub BubblesOn()
        If m_isOn Then
            Console.WriteLine("Hottub is bubbling!")
        End If
    End Sub

    Public Sub BubblesOff()
        If m_isOn Then
            Console.WriteLine("Hottub is not bubbling")
        End If
    End Sub

    Public Sub JetsOn()
        If m_isOn Then
            Console.WriteLine("Hottub jets are on")
        End If
    End Sub

    Public Sub JetsOff()
        If m_isOn Then
            Console.WriteLine("Hottub jets are off")
        End If
    End Sub

    Public Sub Heat()
        m_temperature = 105
        Console.WriteLine("Hottub is heating to a steaming 105 degrees")
    End Sub

    Public Sub Cool()
        m_temperature = 98
        Console.WriteLine("Hottub is cooling to 98 degrees")
    End Sub
End Class
