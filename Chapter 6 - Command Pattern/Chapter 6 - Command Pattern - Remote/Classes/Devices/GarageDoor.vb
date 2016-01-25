Public Class GarageDoor
    Private m_location As String

    Public Sub New(ByVal location As String)
        m_location = location
    End Sub

    Public Sub Up()
        Console.WriteLine("Garage door is Open.")
    End Sub

    Public Sub Down()
        Console.WriteLine("Garage door is Closed.")
    End Sub

    Public Sub StopDoor()
        Console.WriteLine("Garage door is Stopped.")
    End Sub

    Public Sub LightOn()
        Console.WriteLine("Garage light is on")
    End Sub

    Public Sub LightOff()
        Console.WriteLine("Garage light is off")
    End Sub
End Class
