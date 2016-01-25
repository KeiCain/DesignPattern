Public Class HouseBlend
    Inherits Beverage

    Public Sub New()
        m_description = "House Blend Coffee"
    End Sub

    Public Overrides ReadOnly Property Cost() As Double
        Get
            Return 0.89
        End Get
    End Property
End Class
