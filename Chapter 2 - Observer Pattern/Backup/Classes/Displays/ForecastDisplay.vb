Public Class ForecastDisplay
    Implements IObserver, IDisplayElement
    Private m_currentPressure As Double = 29.92
    Private m_lastPressure As Double
    Private m_weatherData As WeatherData

    Public Sub New(ByVal weatherData As WeatherData)
        Me.m_weatherData = weatherData
        weatherData.RegisterObserver(Me)
    End Sub

    Public Sub Display() Implements IDisplayElement.Display
        Console.Write("Forecast: ")
        If m_currentPressure > m_lastPressure Then
            Console.WriteLine("Improving weather on the way!")
        ElseIf m_currentPressure = m_lastPressure Then
            Console.WriteLine("More of the same")
        ElseIf m_currentPressure < m_lastPressure Then
            Console.WriteLine("Watch out for cooler, rainy weather")
        End If
    End Sub

    Public Sub Update(ByVal temperature As Double, ByVal humidity As Double, ByVal pressure As Double) Implements IObserver.Update
        m_lastPressure = m_currentPressure
        m_currentPressure = pressure
        Display()
    End Sub
End Class
