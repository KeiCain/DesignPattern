Imports System.Text

'This is the invoker
Public Class RemoteControlWithUndo
    Private m_onCommands As ICommand() = {}
    Private m_offCommands As ICommand() = {}
    Private m_undoCommand As ICommand

    Public Sub New()
        ReDim m_onCommands(6), m_offCommands(6)

        For i As Integer = 0 To 6
            m_onCommands(i) = New NoCommand
            m_offCommands(i) = New NoCommand
        Next

        m_undoCommand = New NoCommand
    End Sub

    Public Sub SetCommand(ByVal slot As Integer, ByVal OnCommand As ICommand, ByVal OffCommand As ICommand)
        m_onCommands(slot) = OnCommand
        m_offCommands(slot) = OffCommand
    End Sub

    Public Sub OnButtonWasPushed(ByVal slot As Integer)
        m_onCommands(slot).Execute()
        m_undoCommand = m_onCommands(slot)
    End Sub

    Public Sub OffButtonWasPushed(ByVal slot As Integer)
        m_offCommands(slot).Execute()
        m_undoCommand = m_offCommands(slot)
    End Sub

    Public Sub undoButtonWasPushed()
        m_undoCommand.Undo()
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        sb.AppendLine(Environment.NewLine + "------ Remote Control ------")
        For i As Integer = 0 To m_onCommands.Count - 1
            sb.AppendLine("[slot " + i.ToString + "] " + m_onCommands(i).ToString + "     " + m_offCommands(i).ToString)
        Next
        sb.AppendLine("[undo] " + m_undoCommand.ToString)
        Return sb.ToString
    End Function
End Class
