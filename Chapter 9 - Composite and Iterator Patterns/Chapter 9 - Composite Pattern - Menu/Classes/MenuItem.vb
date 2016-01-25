Public Class MenuItem
    Inherits MenuComponent

    Private m_name As String
    Private m_description As String
    Private m_vegetarian As Boolean
    Private m_price As Double

    Public Overrides ReadOnly Property Name() As String
        Get
            Return m_name
        End Get
    End Property

    Public Overrides ReadOnly Property Description() As String
        Get
            Return m_description
        End Get
    End Property

    Public Overrides ReadOnly Property IsVegetarian() As Boolean
        Get
            Return m_vegetarian
        End Get
    End Property

    Public Overrides ReadOnly Property Price() As Double
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

    Public Overrides Sub Print()
        Console.Write("   " + m_name)
        If m_vegetarian Then
            Console.Write(" (v)")
        End If
        Console.WriteLine(", " + m_price.ToString)
        Console.WriteLine("     -- " + m_description)
    End Sub
End Class
