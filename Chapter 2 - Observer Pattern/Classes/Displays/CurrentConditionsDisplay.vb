Public Class CurrentConditionsDisplay
    Implements IObserver, IDisplayElement
    Private m_temperature As Double
    Private m_humidity As Double
    Private m_weatherData As WeatherData

    Public Sub New(ByVal weatherData As WeatherData)
        Me.m_weatherData = weatherData
        weatherData.RegisterObserver(Me)
    End Sub

    Public Sub Display() Implements IDisplayElement.Display
        Console.WriteLine("Current conditions: " + m_temperature.ToString + "F degrees and " + m_humidity.ToString + "% humidity")
    End Sub

    Public Sub Update(ByVal temperature As Double, ByVal humidity As Double, ByVal pressure As Double) Implements IObserver.Update
        Me.m_temperature = temperature
        Me.m_humidity = humidity
        Display()
    End Sub
End Class
