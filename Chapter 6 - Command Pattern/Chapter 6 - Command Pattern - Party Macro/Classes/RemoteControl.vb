Imports System.Text

'This is the invoker
Public Class RemoteControl
    Dim m_onCommands As ICommand() = {}
    Dim m_offCommands As ICommand() = {}

    Public Sub New()
        ReDim m_onCommands(6), m_offCommands(6)

        For i As Integer = 0 To 6
            m_onCommands(i) = New NoCommand
            m_offCommands(i) = New NoCommand
        Next
    End Sub

    Public Sub SetCommand(ByVal slot As Integer, ByVal OnCommand As ICommand, ByVal OffCommand As ICommand)
        m_onCommands(slot) = OnCommand
        m_offCommands(slot) = OffCommand
    End Sub

    Public Sub OnButtonWasPushed(ByVal slot As Integer)
        m_onCommands(slot).Execute()
    End Sub

    Public Sub OffButtonWasPushed(ByVal slot As Integer)
        m_offCommands(slot).Execute()
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        sb.AppendLine(Environment.NewLine + "------ Remote Control ------")
        For i As Integer = 0 To m_onCommands.Count - 1
            sb.AppendLine("[slot " + i.ToString + "] " + m_onCommands(i).ToString + "     " + m_offCommands(i).ToString)
        Next
        Return sb.ToString
    End Function
End Class