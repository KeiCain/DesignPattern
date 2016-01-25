Public Class Projector
    Private m_description As String
    Private m_dvdPlayer As DVDPlayer

    Public Sub New(ByVal description As String, ByVal dvdPlayer As DVDPlayer)
        m_description = description
        m_dvdPlayer = dvdPlayer
    End Sub

    Public Sub TurnOn()
        Console.WriteLine(m_description + " on")
    End Sub

    Public Sub TurnOff()
        Console.WriteLine(m_description + " off")
    End Sub

    Public Sub SetWidescreenMode()
        Console.WriteLine(m_description + " in widescreen mode (16x9 aspect ratio)")
    End Sub

    Public Sub SetTVMode()
        Console.WriteLine(m_description + " in tv mode (4x3 aspect ratio)")
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
