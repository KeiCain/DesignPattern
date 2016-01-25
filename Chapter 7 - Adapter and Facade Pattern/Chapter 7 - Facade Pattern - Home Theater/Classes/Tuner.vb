Public Class Tuner
    Private m_description As String
    Private m_amplifier As Amplifier
    Private m_frequency As Double

    Public WriteOnly Property frequency() As Double
        Set(ByVal value As Double)
            Console.WriteLine(m_description + " setting frequency to " + value.ToString)
            m_frequency = value
        End Set
    End Property

    Public Sub New(ByVal description As String, ByVal amplifier As Amplifier)
        m_description = description
        m_amplifier = amplifier
    End Sub

    Public Sub TurnOn()
        Console.WriteLine(m_description + " on")
    End Sub

    Public Sub TurnOff()
        Console.WriteLine(m_description + " off")
    End Sub

    Public Sub SetAm()
        Console.WriteLine(m_description + " setting AM mode")
    End Sub

    Public Sub SetFm()
        Console.WriteLine(m_description + " setting FM mode")
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
