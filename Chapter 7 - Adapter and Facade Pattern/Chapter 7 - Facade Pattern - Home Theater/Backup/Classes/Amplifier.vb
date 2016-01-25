Public Class Amplifier
    Private m_description As String
    Private m_tuner As Tuner
    Private m_dvdPlayer As DVDPlayer
    Private m_cdPlayer As CDPlayer

    Public WriteOnly Property dvdPlayer() As DVDPlayer
        Set(ByVal value As DVDPlayer)
            m_dvdPlayer = value
        End Set
    End Property

    Public WriteOnly Property cdPlayer() As CDPlayer
        Set(ByVal value As CDPlayer)
            m_cdPlayer = value
        End Set
    End Property

    Public WriteOnly Property tuner() As Tuner
        Set(ByVal value As Tuner)
            m_tuner = value
        End Set
    End Property

    Public Sub New(ByVal description As String)
        m_description = description
    End Sub

    Public Sub TurnOn()
        Console.WriteLine(m_description + " on")
    End Sub

    Public Sub TurnOff()
        Console.WriteLine(m_description + " off")
    End Sub

    Public Sub SetStereoSound()
        Console.WriteLine(m_description + " stereo mode on")
    End Sub

    Public Sub SetSurroundSound()
        Console.WriteLine(m_description + " surround sound on (5 speakers, 1 subwoofer)")
    End Sub

    Public Sub SetVolume(ByVal level As Integer)
        Console.WriteLine(m_description + " setting volume to " + level.ToString)
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
