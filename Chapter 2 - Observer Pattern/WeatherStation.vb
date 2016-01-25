Module WeatherStation

    Sub Main()
        Dim weatherData As New WeatherData
        Dim currentConditionsDisplay As New CurrentConditionsDisplay(weatherData)
        Dim statisticsDisplay As New StatisticsDisplay(weatherData)
        Dim forecastDisplay As New ForecastDisplay(weatherData)
        Dim heatIndexDisplay As New HeatIndexDisplay(weatherData)

        weatherData.SetMeasurements(80, 65, 30.4)
        Console.ReadLine()
        weatherData.SetMeasurements(82, 70, 29.2)
        Console.ReadLine()
        weatherData.SetMeasurements(78, 90, 29.2)
        Console.ReadLine()
    End Sub

End Module
