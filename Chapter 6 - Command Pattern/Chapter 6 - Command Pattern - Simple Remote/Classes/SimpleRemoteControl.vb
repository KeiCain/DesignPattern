'This is the invoker
Public Class SimpleRemoteControl
    Dim m_slot As ICommand

    Public Sub New()
    End Sub

    Public Sub SetCommand(ByVal command As ICommand)
        m_slot = command
    End Sub

    Public Sub ButtonWasPressed()
        m_slot.Execute()
    End Sub
End Class
