Public Class AlternatingDinerMenuIterator
    Implements IIterator(Of MenuItem)
    Private m_items As MenuItem()
    Private m_position As Integer

    Public Sub New(ByVal items As MenuItem())
        m_items = items
        Dim today As DateTime = DateTime.Now
        m_position = today.DayOfWeek Mod 2
    End Sub

    Public Function GetNext() As MenuItem Implements IIterator(Of MenuItem).GetNext
        Dim item As MenuItem = m_items(m_position)
        m_position += 2
        Return item
    End Function

    Public Function HasNext() As Boolean Implements IIterator(Of MenuItem).HasNext
        If m_position >= m_items.Count Or m_items(m_position) Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Overrides Function ToString() As String
        Return "Alternating Diner Menu Iterator"
    End Function
End Class
