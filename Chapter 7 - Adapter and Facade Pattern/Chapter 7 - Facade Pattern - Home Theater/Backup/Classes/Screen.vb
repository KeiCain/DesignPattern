Public Class Screen
    Private m_description As String

    Public Sub New(ByVal description As String)
        m_description = description
    End Sub

    Public Sub Up()
        Console.WriteLine(m_description + " going up")
    End Sub

    Public Sub Down()
        Console.WriteLine(m_description + " going down")
    End Sub

    Public Overrides Function ToString() As String
        Return m_description
    End Function
End Class
