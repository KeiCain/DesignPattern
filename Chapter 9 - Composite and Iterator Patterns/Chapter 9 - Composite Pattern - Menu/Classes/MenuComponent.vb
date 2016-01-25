Public MustInherit Class MenuComponent
    Public Overridable ReadOnly Property Name() As String
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Public Overridable ReadOnly Property Description() As String
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Public Overridable ReadOnly Property Price() As Double
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Public Overridable ReadOnly Property IsVegetarian() As Boolean
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Public Overridable Sub Add(ByVal menuComponent As MenuComponent)
        Throw New NotImplementedException
    End Sub

    Public Overridable Sub Remove(ByVal menuComponent As MenuComponent)
        Throw New NotImplementedException
    End Sub

    Public Overridable Function GetChild(ByVal index As Integer) As MenuComponent
        Throw New NotImplementedException
    End Function

    Public Overridable Sub Print()
        Throw New NotImplementedException
    End Sub
End Class
