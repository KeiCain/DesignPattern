Public Class MenuItem
    Private m_name As String
    Private m_description As String
    Private m_vegetarian As Boolean
    Private m_price As Double

    Public ReadOnly Property Name() As String
        Get
            Return m_name
        End Get
    End Property
    Public ReadOnly Property Description() As String
        Get
            Return m_description
        End Get
    End Property
    Public ReadOnly Property IsVegetarian() As Boolean
        Get
            Return m_vegetarian
        End Get
    End Property
    Public ReadOnly Property Price() As Double
        Get
            Return m_price
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal description As String, ByVal isVegetarian As Boolean, ByVal price As Double)
        m_name = name
        m_description = description
        m_vegetarian = isVegetarian
        m_price = price
    End Sub

    Public Overrides Function ToString() As String
        Return m_name + ", $" + m_price.ToString + Environment.NewLine + "   " + m_description
    End Function
End Class
