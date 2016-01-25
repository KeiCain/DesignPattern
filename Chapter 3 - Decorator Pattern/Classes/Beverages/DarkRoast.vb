Public Class DarkRoast
    Inherits Beverage

    Public Sub New()
        m_description = "Dark Roast Coffee"
    End Sub
    Public Overrides ReadOnly Property Cost() As Double
        Get
            Return 0.99
        End Get
    End Property
End Class
