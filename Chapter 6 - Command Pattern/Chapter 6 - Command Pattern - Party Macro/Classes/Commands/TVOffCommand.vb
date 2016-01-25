Public Class TVOffCommand
    Implements ICommand
    Private m_tv As TV

    Public Sub New(ByVal tv As TV)
        m_tv = tv
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_tv.TurnOff()
    End Sub
End Class
