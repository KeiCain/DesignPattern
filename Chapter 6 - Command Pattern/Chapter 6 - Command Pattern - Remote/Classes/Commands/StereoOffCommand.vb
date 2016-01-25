Public Class StereoOffCommand
    Implements ICommand
    Private m_stereo As Stereo

    Public Sub New(ByVal stereo As Stereo)
        m_stereo = stereo
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_stereo.TurnOff()
    End Sub
End Class
