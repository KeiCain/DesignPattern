Imports System.Runtime.CompilerServices

Public Class SynchronizedMethodSingleton
    Private Shared m_uniqueInstance As SynchronizedMethodSingleton

    Private Sub New()
    End Sub

    'The following specifies the function itself is synchronized.
    'Note: this requires the System.Runtime.CompilerServices namespace
    <MethodImpl(MethodImplOptions.Synchronized)> _
    Public Shared Function GetInstance() As SynchronizedMethodSingleton
        Return m_uniqueInstance
    End Function
End Class
