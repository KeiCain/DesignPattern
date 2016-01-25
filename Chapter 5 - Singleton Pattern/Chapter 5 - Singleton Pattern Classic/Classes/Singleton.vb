Public Class Singleton
    Private Shared m_uniqueInstance As Singleton

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As Singleton
        If m_uniqueInstance Is Nothing Then
            m_uniqueInstance = New Singleton
        End If
        Return m_uniqueInstance
    End Function

End Class
