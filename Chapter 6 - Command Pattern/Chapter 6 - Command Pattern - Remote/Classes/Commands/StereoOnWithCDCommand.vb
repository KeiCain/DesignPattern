Public Class StereoOnWithCDCommand
    Implements ICommand
    Private m_stereo As Stereo

    Public Sub New(ByVal stereo As Stereo)
        m_stereo = stereo
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_stereo.TurnOn()
        m_stereo.SetCD()
        m_stereo.SetVolume(11)
    End Sub
End Class
