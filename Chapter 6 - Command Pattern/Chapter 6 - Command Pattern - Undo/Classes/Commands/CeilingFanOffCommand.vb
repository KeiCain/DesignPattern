Public Class CeilingFanOffCommand
    Implements ICommand
    Private m_prevLevel As CeilingFan.FanSpeed
    Private m_ceilingFan As CeilingFan

    Public Sub New(ByVal ceilingFan As CeilingFan)
        m_ceilingFan = ceilingFan
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_prevLevel = m_ceilingFan.Level
        m_ceilingFan.Level = CeilingFan.FanSpeed.Off
    End Sub

    Public Sub Undo() Implements ICommand.Undo
        m_ceilingFan.Level = m_prevLevel
    End Sub
End Class
