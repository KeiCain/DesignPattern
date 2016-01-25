Public Class DVDPlayer
    Private m_description As String
    Private m_currentTrack As Integer
    Private m_amplifier As Amplifier
    Private m_movie As String

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

    Public Sub Eject()
        m_movie = Nothing
        Console.WriteLine(m_description + " eject")
    End Sub

    Public Sub Play(ByVal movie As String)
        m_movie = movie
        m_currentTrack = 0
        Console.WriteLine(m_description + " playing """ + movie + """")
    End Sub

    Public Sub Play(ByVal track As Integer)
        If m_movie Is Nothing Then
            Console.WriteLine(m_description + " can't play track " + track.ToString + ", no dvd inserted.")
        Else
            m_currentTrack = track
            Console.WriteLine(m_description + " playing track " + m_currentTrack.ToString)
        End If
    End Sub

    Public Sub StopPlay()
        m_currentTrack = 0
        Console.WriteLine(m_description + " stopped """ + m_movie + """")
    End Sub

    Public Sub Pause()
        Console.WriteLine(m_description + " paused """ + m_movie + """")
    End Sub

    Public Sub SetTwoChannelAudio()
        Console.WriteLine(m_description + " set two channel audio")
    End Sub

    Public Sub SetSurroundAudio()
        Console.WriteLine(m_description + " set surround audio")
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
