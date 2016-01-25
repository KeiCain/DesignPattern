Public Class MacroCommand
    Implements ICommand
    Private m_commands As ICommand()

    Public Sub New(ByVal commands As ICommand())
        m_commands = commands
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        For Each command As ICommand In m_commands
            command.Execute()
        Next
    End Sub
End Class
