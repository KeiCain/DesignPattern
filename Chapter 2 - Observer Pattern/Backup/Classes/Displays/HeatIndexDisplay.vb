Public Class HeatIndexDisplay
    Implements IObserver, IDisplayElement
    Private m_heatIndex As Double = 0.0
    Private m_weatherData As WeatherData

    Public Sub New(ByVal weatherData As WeatherData)
        Me.m_weatherData = weatherData
        weatherData.RegisterObserver(Me)
    End Sub

    Public Sub Display() Implements IDisplayElement.Display
        Console.WriteLine("The heat index is: " + m_heatIndex.ToString)
    End Sub

    Public Sub Update(ByVal temperature As Double, ByVal humidity As Double, ByVal pressure As Double) Implements IObserver.Update
        m_heatIndex = ComputeHeatIndex(temperature, humidity)
        Display()
    End Sub

    Private Function ComputeHeatIndex(ByVal temperature As Double, ByVal humidity As Double) As Double
        Dim t As Double = temperature
        Dim rh As Double = humidity

        'heat index formula from java source!
        Dim index As Double = ((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) _
               + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) _
               + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) + _
               (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 * _
               (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) + _
               (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) + _
               0.000000000843296 * (t * t * rh * rh * rh)) - _
               (0.0000000000481975 * (t * t * t * rh * rh * rh)))
        Return index
    End Function
End Class
