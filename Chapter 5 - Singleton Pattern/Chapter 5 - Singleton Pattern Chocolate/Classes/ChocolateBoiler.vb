Public Class ChocolateBoiler
    Private m_empty As Boolean
    Private m_boiled As Boolean
    Private Shared m_uniqueInstance As ChocolateBoiler

    Private Sub New()
        m_empty = True
        m_boiled = False
    End Sub

    Public ReadOnly Property IsEmpty() As Boolean
        Get
            Return m_empty
        End Get
    End Property

    Public ReadOnly Property IsBoiled() As Boolean
        Get
            Return m_boiled
        End Get
    End Property

    Public Shared Function GetInstance() As ChocolateBoiler
        If m_uniqueInstance Is Nothing Then
            Console.WriteLine("Creating unique instance of Chocolate Boiler")
            m_uniqueInstance = New ChocolateBoiler
        End If

        Console.WriteLine("Returning instance of Chocolate Boiler")
        Return m_uniqueInstance
    End Function

    Public Sub Fill()
        If m_empty Then
            m_empty = False
            m_boiled = False
            'Fill the boiler with a milk/chocolate mixture
        End If
    End Sub

    Public Sub Drain()
        If Not m_empty And m_boiled Then
            'Drain the boiled milk and chocolate
            m_empty = True
        End If
    End Sub

    Public Sub Boil()
        If Not m_empty And Not m_boiled Then
            'Bring the contents to a boil
            m_boiled = True
        End If
    End Sub
End Class
