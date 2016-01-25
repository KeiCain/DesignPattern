Public MustInherit Class Beverage
    Protected m_description As String = "Unknown Beverage"

    Public Overridable ReadOnly Property Description() As String
        Get
            Return m_description
        End Get
    End Property

    Public MustOverride ReadOnly Property Cost() As Double
End Class
