Module RemoteLoader

    Sub Main()
        Dim remote As New RemoteControl

        Dim livingRoomLight As New Light("Living Room")
        Dim kitchenLight As New Light("Kitchen")
        Dim ceilingFan As New CeilingFan("Living Room")
        Dim garageDoor As New GarageDoor("")
        Dim stereo As New Stereo("Living Room")

        Dim livingRoomLightOn As New LightOnCommand(livingRoomLight)
        Dim livingRoomLightOff As New LightOffCommand(livingRoomLight)
        Dim kitchenLightOn As New LightOnCommand(kitchenLight)
        Dim kitchenLightOff As New LightOffCommand(kitchenLight)

        Dim ceilingFanOnCommand As New CeilingFanOnCommand(ceilingFan)
        Dim ceilingFanOffCommand As New CeilingFanOffCommand(ceilingFan)

        Dim garageDoorOpenCommand As New GarageDoorOpenCommand(garageDoor)
        Dim garageDoorCloseCommand As New GarageDoorCloseCommand(garageDoor)

        Dim stereoOnCommand As New StereoOnWithCDCommand(stereo)
        Dim stereoOffCommand As New StereoOffCommand(stereo)

        remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff)
        remote.SetCommand(1, kitchenLightOn, kitchenLightOff)
        remote.SetCommand(2, ceilingFanOnCommand, ceilingFanOffCommand)
        remote.SetCommand(3, stereoOnCommand, stereoOffCommand)

        Console.WriteLine(remote.ToString)

        remote.OnButtonWasPushed(0)
        remote.OffButtonWasPushed(0)
        remote.OnButtonWasPushed(1)
        remote.OffButtonWasPushed(1)
        remote.OnButtonWasPushed(2)
        remote.OffButtonWasPushed(2)
        remote.OnButtonWasPushed(3)
        remote.OffButtonWasPushed(3)

        Console.ReadLine()
    End Sub

End Module
