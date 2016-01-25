Imports System.Threading.Thread

Public Class DoubleCheckedSingleton
    Private Shared m_uniqueInstance As DoubleCheckedSingleton
    Private Shared m_lock As New Object

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As DoubleCheckedSingleton
        If m_uniqueInstance Is Nothing Then
            SyncLock m_lock
                If m_uniqueInstance Is Nothing Then
                    m_uniqueInstance = New DoubleCheckedSingleton
                End If
            End SyncLock
        End If
        Return m_uniqueInstance
    End Function
End Class
