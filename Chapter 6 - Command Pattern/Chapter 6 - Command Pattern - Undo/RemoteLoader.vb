Module RemoteLoader

    Sub Main()
        Dim remote As New RemoteControlWithUndo()

        Dim livingRoomLight As New Light("Living Room")

        Dim livingRoomLightOnCommand As New LightOnCommand(livingRoomLight)
        Dim livingRoomLightOffCommand As New LightOffCommand(livingRoomLight)

        remote.SetCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand)

        remote.OnButtonWasPushed(0)
        remote.OffButtonWasPushed(0)

        Console.WriteLine(remote.ToString)
        Console.ReadLine()

        remote.undoButtonWasPushed()
        remote.OffButtonWasPushed(0)
        remote.OnButtonWasPushed(0)

        Console.WriteLine(remote.ToString)
        Console.ReadLine()

        remote.undoButtonWasPushed()
        Console.ReadLine()

        Dim ceilingFan As New CeilingFan("Living Room")

        Dim ceilingFanHighCommand As New CeilingFanHighCommand(ceilingFan)
        Dim ceilingFanMediumCommand As New CeilingFanMediumCommand(ceilingFan)
        Dim ceilingFanOffCommand As New CeilingFanOffCommand(ceilingFan)

        remote.SetCommand(0, ceilingFanMediumCommand, ceilingFanOffCommand)
        remote.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand)

        remote.OnButtonWasPushed(0)
        remote.OffButtonWasPushed(0)

        Console.WriteLine(remote.ToString)
        Console.ReadLine()

        remote.undoButtonWasPushed()
        remote.OnButtonWasPushed(1)

        Console.WriteLine(remote.ToString)
        Console.ReadLine()

        remote.undoButtonWasPushed()

        Console.WriteLine(remote.ToString)
        Console.ReadLine()
    End Sub

End Module
