Public Class CeilingFanMediumCommand
    Implements ICommand
    Private m_ceilingFan As CeilingFan

    Public Sub New(ByVal ceilingFan As CeilingFan)
        m_ceilingFan = ceilingFan
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_ceilingFan.Level = CeilingFan.FanSpeed.Medium
    End Sub
End Class
