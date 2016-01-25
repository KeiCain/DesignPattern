Public Class StatisticsDisplay
    Implements IObserver, IDisplayElement
    Private m_maxTemp As Double = 0.0
    Private m_minTemp As Double = 200.0
    Private m_tempSum As Double = 0.0
    Private m_numReadings As Integer = 0
    Private m_weatherData As WeatherData

    Public Sub New(ByVal weatherData As WeatherData)
        Me.m_weatherData = weatherData
        weatherData.RegisterObserver(Me)
    End Sub

    Public Sub Display() Implements IDisplayElement.Display
        Console.WriteLine("Avg/Max/Min temperature = " + (m_tempSum / m_numReadings).ToString + "/" + m_maxTemp.ToString + "/" + m_minTemp.ToString)
    End Sub

    Public Sub Update(ByVal temperature As Double, ByVal humidity As Double, ByVal pressure As Double) Implements IObserver.Update
        m_tempSum += temperature
        m_numReadings += 1
        If (temperature > m_maxTemp) Then
            m_maxTemp = temperature
        End If
        If (temperature < m_minTemp) Then
            m_minTemp = temperature
        End If
        Display()
    End Sub
End Class
