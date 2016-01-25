Public Class PancakeHouseMenuIterator
    Implements IIterator(Of MenuItem)
    Private m_items As List(Of MenuItem)
    Private m_position As Integer

    Public Sub New(ByVal items As List(Of MenuItem))
        m_items = items
    End Sub

    Public Function GetNext() As MenuItem Implements IIterator(Of MenuItem).GetNext
        Dim item As MenuItem = m_items.Item(m_position)
        m_position += 1
        Return item
    End Function

    Public Function HasNext() As Boolean Implements IIterator(Of MenuItem).HasNext
        If m_position >= m_items.Count Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
