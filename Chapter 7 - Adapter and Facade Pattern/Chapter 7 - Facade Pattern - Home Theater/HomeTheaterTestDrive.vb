Module HomeTheaterTestDrive

    Sub Main()
        Dim amp As New Amplifier("Top-O-Line Amplifier")
        Dim tuner As New Tuner("Top-O-Line AM/FM Tuner", amp)
        Dim dvd As New DVDPlayer("Top-O-Line DVD Player", amp)
        Dim cd As New CDPlayer("Top-O-Line CD Player", amp)
        Dim projector As New Projector("Top-O-Line Projector", dvd)
        Dim theaterLights As New TheaterLights("Theater Ceiling Lights")
        Dim screen As New Screen("Theater Screen")
        Dim popper As New PopcornPopper("Popcorn popper")

        Dim homeTheater As New HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, theaterLights, popper)

        homeTheater.WatchMovie("Akira")
        Console.ReadLine()
        homeTheater.EndMovie()
        Console.ReadLine()
    End Sub

End Module
