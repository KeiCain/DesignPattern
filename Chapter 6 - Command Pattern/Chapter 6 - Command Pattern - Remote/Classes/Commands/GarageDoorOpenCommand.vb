Public Class GarageDoorOpenCommand
    Implements ICommand
    Private m_garageDoor As GarageDoor

    Public Sub New(ByVal garageDoor As GarageDoor)
        m_garageDoor = garageDoor
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_garageDoor.Up()
    End Sub
End Class
