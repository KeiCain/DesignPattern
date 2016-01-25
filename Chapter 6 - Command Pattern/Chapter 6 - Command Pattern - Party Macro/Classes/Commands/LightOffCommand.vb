Public Class LightOffCommand
    Implements ICommand
    Private m_light As Light
    Public Sub New(ByVal light As Light)
        m_light = light
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_light.TurnOff()
    End Sub
End Class
