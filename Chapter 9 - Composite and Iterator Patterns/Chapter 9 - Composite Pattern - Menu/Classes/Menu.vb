Public Class Menu
    Inherits MenuComponent
    Private m_components As List(Of MenuComponent)
    Private m_name As String
    Private m_description As String

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

    Public Sub New(ByVal name As String, ByVal description As String)
        m_components = New List(Of MenuComponent)
        m_name = name
        m_description = description
    End Sub

    Public Overrides Sub Add(ByVal menuComponent As MenuComponent)
        m_components.Add(menuComponent)
    End Sub

    Public Overrides Sub Remove(ByVal menuComponent As MenuComponent)
        m_components.Remove(menuComponent)
    End Sub

    Public Overrides Function GetChild(ByVal index As Integer) As MenuComponent
        Return m_components.Item(index)
    End Function

    Public Overrides Sub Print()
        Console.Write(Environment.NewLine + m_name)
        Console.WriteLine(",  " + m_description)
        Console.WriteLine("---------------------")

        For Each component As MenuComponent In m_components
            component.Print()
        Next
    End Sub
End Class
