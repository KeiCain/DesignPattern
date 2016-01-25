Public Class HotTubOnCommand
    Implements ICommand
    Private m_hotTub As HotTub

    Public Sub New(ByVal hotTub As HotTub)
        m_hotTub = hotTub
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_hotTub.TurnOn()
        m_hotTub.Temperature = 104
        m_hotTub.Circulate()
    End Sub
End Class
