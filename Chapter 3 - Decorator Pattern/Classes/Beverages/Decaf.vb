Public Class Decaf
    Inherits Beverage

    Public Sub New()
        m_description = "Decaf Coffee"
    End Sub

    Public Overrides ReadOnly Property Cost() As Double
        Get
            Return 1.05
        End Get
    End Property
End Class
