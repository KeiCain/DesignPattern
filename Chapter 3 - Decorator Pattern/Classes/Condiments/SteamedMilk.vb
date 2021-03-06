﻿Public Class SteamedMilk
    Inherits CondimentDecorator
    Private m_beverage As Beverage

    Public Sub New(ByVal beverage As Beverage)
        m_beverage = beverage
    End Sub

    Public Overrides ReadOnly Property Cost() As Double
        Get
            Return 0.1 + m_beverage.Cost
        End Get
    End Property

    Public Overrides ReadOnly Property Description() As String
        Get
            Return m_beverage.Description + ", Steamed Milk"
        End Get
    End Property
End Class
