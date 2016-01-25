Module RemoteControlTest

    Sub Main()
        Dim remote As New SimpleRemoteControl
        Dim light As New Light
        Dim garageDoor As New GarageDoor
        Dim lightOn As New LightOnCommand(light)
        Dim garageOpen As New GarageDoorOpenCommand(garageDoor)

        remote.SetCommand(lightOn)
        remote.ButtonWasPressed()
        remote.SetCommand(garageOpen)
        remote.ButtonWasPressed()
        Console.ReadLine()
    End Sub

End Module
