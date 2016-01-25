Public Class CDPlayer
    Private m_description As String
    Private m_currentTrack As Integer
    Private m_amplifier As Amplifier
    Private m_title As String

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
        m_title = Nothing
        Console.WriteLine(m_description + " eject")
    End Sub

    Public Sub Play(ByVal title As String)
        m_title = title
        m_currentTrack = 0
        Console.WriteLine(m_description + " playing """ + title + """")
    End Sub

    Public Sub Play(ByVal track As Integer)
        If m_title Is Nothing Then
            Console.WriteLine(m_description + " can't play track " + track.ToString + ", no cd inserted.")
        Else
            m_currentTrack = track
            Console.WriteLine(m_description + " playing track " + m_currentTrack.ToString)
        End If
    End Sub

    Public Sub StopPlay()
        m_currentTrack = 0
        Console.WriteLine(m_description + " stopped")
    End Sub

    Public Sub Pause()
        Console.WriteLine(m_description + " paused """ + m_title + """")
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
