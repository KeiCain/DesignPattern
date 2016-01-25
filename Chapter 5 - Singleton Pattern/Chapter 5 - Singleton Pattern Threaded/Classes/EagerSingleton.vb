Public Class EagerSingleton
    Private Shared m_uniqueInstance As New EagerSingleton

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As EagerSingleton
        Return m_uniqueInstance
    End Function
End Class
