Public Class HotTubOffCommand
    Implements ICommand
    Private m_hotTub As HotTub

    Public Sub New(ByVal hotTub As HotTub)
        m_hotTub = hotTub
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_hotTub.Cool()
        m_hotTub.TurnOff()
    End Sub
End Class
