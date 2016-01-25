Public Class TVOnCommand
    Implements ICommand
    Private m_tv As TV

    Public Sub New(ByVal tv As TV)
        m_tv = tv
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_tv.TurnOn()
        m_tv.SetInputChannel()
    End Sub
End Class
