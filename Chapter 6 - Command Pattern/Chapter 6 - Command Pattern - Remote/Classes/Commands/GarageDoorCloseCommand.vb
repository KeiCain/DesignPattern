Public Class GarageDoorCloseCommand
    Implements ICommand
    Private m_garageDoor As GarageDoor

    Public Sub New(ByVal garageDoor As GarageDoor)
        m_garageDoor = garageDoor
    End Sub

    Public Sub Execute() Implements ICommand.Execute
        m_garageDoor.Down()
    End Sub
End Class
