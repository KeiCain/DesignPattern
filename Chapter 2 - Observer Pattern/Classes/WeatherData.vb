Imports System.Collections.Generic

Public Class WeatherData
    Implements ISubject
    Private m_observers As List(Of IObserver)
    Private m_temperature As Double
    Private m_humidity As Double
    Private m_pressure As Double

    Public Sub New()
        m_observers = New List(Of IObserver)
    End Sub

    Private Sub NotifyObservers() Implements ISubject.NotifyObservers
        For Each observer As IObserver In m_observers
            observer.Update(m_temperature, m_humidity, m_pressure)
        Next
    End Sub

    Public Sub RegisterObserver(ByVal o As IObserver) Implements ISubject.RegisterObserver
        m_observers.Add(o)
    End Sub

    Public Sub RemoveObserver(ByVal o As IObserver) Implements ISubject.RemoveObserver
        Dim i As Integer = m_observers.IndexOf(o)
        If i >= 0 Then
            m_observers.RemoveAt(i)
        End If
    End Sub

    Private Sub MeasurementsChanged()
        NotifyObservers()
    End Sub

    Public Sub SetMeasurements(ByVal temperature As Double, ByVal humidity As Double, ByVal pressure As Double)
        Me.m_temperature = temperature
        Me.m_humidity = humidity
        Me.m_pressure = pressure
        Me.MeasurementsChanged()
    End Sub
End Class
