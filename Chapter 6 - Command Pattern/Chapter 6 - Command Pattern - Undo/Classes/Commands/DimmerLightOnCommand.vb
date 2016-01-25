﻿Public Class DimmerLightOnCommand
    Implements ICommand
    Private m_level As Integer
    Private m_light As Light
    Public Sub New(ByVal light As Light)
        m_light = light
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_level = m_light.Level
        m_light.Level = 75
    End Sub

    Public Sub Undo() Implements ICommand.Undo
        m_light.Level = m_level
    End Sub
End Class
