Public Class Espresso
    Inherits Beverage

    Public Sub New()
        m_description = "Espresso"
    End Sub
    Public Overrides ReadOnly Property Cost() As Double
        Get
            Return 1.99
        End Get
    End Property
End Class
