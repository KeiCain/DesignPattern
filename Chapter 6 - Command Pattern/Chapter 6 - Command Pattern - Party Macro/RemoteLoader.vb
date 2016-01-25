Module RemoteLoader

    Sub Main()
        Dim remoteControl As New RemoteControl()

        Dim light As New Light("Living Room")
        Dim tv As New TV("Living Room")
        Dim stereo As New Stereo("Living Room")
        Dim hottub As New HotTub()

        Dim lightOn As New LightOnCommand(light)
        Dim stereoOn As New StereoOnCommand(stereo)
        Dim tvOn As New TVOnCommand(tv)
        Dim hottubOn As New HotTubOnCommand(hottub)
        Dim lightOff As New LightOffCommand(light)
        Dim stereoOff As New StereoOffCommand(stereo)
        Dim tvOff As New TVOffCommand(tv)
        Dim hottubOff As New HotTubOffCommand(hottub)

        Dim partyOn As ICommand() = {lightOn, stereoOn, tvOn, hottubOn}
        Dim partyOff As ICommand() = {lightOff, stereoOff, tvOff, hottubOff}

        Dim partyOnMacro As New MacroCommand(partyOn)
        Dim partyOffMacro As New MacroCommand(partyOff)

        remoteControl.SetCommand(0, partyOnMacro, partyOffMacro)

        Console.WriteLine(remoteControl)
        Console.WriteLine("--- Pushing Macro On---")
        remoteControl.OnButtonWasPushed(0)
        Console.WriteLine("--- Pushing Macro Off---")
        remoteControl.OffButtonWasPushed(0)
        Console.ReadLine()
    End Sub

End Module
