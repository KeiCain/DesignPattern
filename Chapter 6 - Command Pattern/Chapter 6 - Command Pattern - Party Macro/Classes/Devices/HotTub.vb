Public Class HotTub
    Private m_isOn As Boolean
    Private m_temperature As Integer

    Public Property Temperature() As Integer
        Get
            Return m_temperature
        End Get
        Set(ByVal value As Integer)
            If value > m_temperature Then
                Console.WriteLine("Hottub is heating to a steaming " + value.ToString + " degrees")
            Else
                Console.WriteLine("Hottub is cooling to " + value.ToString + " degrees")
            End If
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

    Public Sub Circulate()
        If m_isOn Then
            Console.WriteLine("Hottub is bubbling!")
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
End Class