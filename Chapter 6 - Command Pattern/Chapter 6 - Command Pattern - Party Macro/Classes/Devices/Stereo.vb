Public Class Stereo
    Private m_location As String

    Public Sub New(ByVal location As String)
        m_location = location
    End Sub

    Public Sub TurnOn()
        Console.WriteLine(m_location + " stereo is on")
    End Sub

    Public Sub TurnOff()
        Console.WriteLine(m_location + " stereo is off")
    End Sub

    Public Sub SetCD()
        Console.WriteLine(m_location + " stereo is set for CD input")
    End Sub

    Public Sub SetDVD()
        Console.WriteLine(m_location + " stereo is set for DVD input")
    End Sub

    Public Sub SetRadio()
        Console.WriteLine(m_location + " stereo is set for Radio")
    End Sub

    Public Sub SetVolume(ByVal volume As Integer)
        'Code to set the volume
        'Valid range: 1-11 (after all 11 is better than 10, right?)
        Console.WriteLine(m_location + "stereo volume set to " + volume.ToString)
    End Sub
End Class
