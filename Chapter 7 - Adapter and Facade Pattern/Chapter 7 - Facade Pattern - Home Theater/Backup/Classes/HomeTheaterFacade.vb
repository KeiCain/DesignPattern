Public Class HomeTheaterFacade
    Private m_amplifier As Amplifier
    Private m_tuner As Tuner
    Private m_dvdPlayer As DVDPlayer
    Private m_cdPlayer As CDPlayer
    Private m_projector As Projector
    Private m_screen As Screen
    Private m_theaterLights As TheaterLights
    Private m_popcornPopper As PopcornPopper

    Public Sub New(ByVal amplifier As Amplifier, ByVal tuner As Tuner, ByVal dvdPlayer As DVDPlayer, ByVal cdPlayer As CDPlayer, _
                   ByVal projector As Projector, ByVal screen As Screen, ByVal theaterLights As TheaterLights, ByVal popcornPopper As PopcornPopper)
        m_amplifier = amplifier
        m_tuner = tuner
        m_dvdPlayer = dvdPlayer
        m_cdPlayer = cdPlayer
        m_projector = projector
        m_screen = screen
        m_theaterLights = theaterLights
        m_popcornPopper = popcornPopper
    End Sub

    Public Sub WatchMovie(ByVal movie As String)
        Console.WriteLine("Get ready to watch a movie...")
        m_popcornPopper.TurnOn()
        m_popcornPopper.Pop()
        m_theaterLights.SetLevel(10)
        m_screen.Down()
        m_projector.TurnOn()
        m_projector.SetWidescreenMode()
        m_amplifier.TurnOn()
        m_amplifier.dvdPlayer = m_dvdPlayer
        m_amplifier.SetSurroundSound()
        m_amplifier.SetVolume(5)
        m_dvdPlayer.TurnOn()
        m_dvdPlayer.Play(movie)
    End Sub

    Public Sub EndMovie()
        Console.WriteLine("Shutting movie theater down...")
        m_popcornPopper.TurnOff()
        m_theaterLights.TurnOn()
        m_screen.Up()
        m_projector.TurnOff()
        m_amplifier.TurnOff()
        m_dvdPlayer.StopPlay()
        m_dvdPlayer.Eject()
        m_dvdPlayer.TurnOff()
    End Sub

    Public Sub ListenToCD(ByVal title As String)
        Console.WriteLine("Getting ready for an audiophile experience...")
        m_theaterLights.TurnOn()
        m_amplifier.TurnOn()
        m_amplifier.SetVolume(5)
        m_amplifier.cdPlayer = m_cdPlayer
        m_amplifier.SetStereoSound()
        m_cdPlayer.TurnOn()
        m_cdPlayer.Play(title)
    End Sub

    Public Sub EndCd()
        Console.WriteLine("Shutting down CD...")
        m_amplifier.TurnOff()
        m_amplifier.cdPlayer = m_cdPlayer
        m_cdPlayer.Eject()
        m_cdPlayer.TurnOff()
    End Sub

    Public Sub ListenToRadio(ByVal frequency As Double)
        Console.WriteLine("Tuning in the airwaves...")
        m_tuner.TurnOn()
        m_tuner.frequency = frequency
        m_amplifier.TurnOn()
        m_amplifier.SetVolume(5)
        m_amplifier.tuner = m_tuner
    End Sub

    Public Sub EndRadio()
        Console.WriteLine("Shutting down the tuner...")
        m_tuner.TurnOff()
        m_amplifier.TurnOff()
    End Sub
End Class
