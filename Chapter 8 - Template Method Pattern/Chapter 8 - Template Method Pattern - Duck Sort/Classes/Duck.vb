Public Class Duck
    Implements IComparable(Of Duck)
    Private m_name As String
    Private m_weight As Integer

    Public Sub New(ByVal name As String, ByVal weight As Integer)
        m_name = name
        m_weight = weight
    End Sub

    Public Overrides Function ToString() As String
        Return m_name + " weighs " + m_weight.ToString
    End Function
    Public Function CompareTo(ByVal other As Duck) As Integer Implements System.IComparable(Of Duck).CompareTo
        If Me.m_weight < other.m_weight Then
            Return -1
        ElseIf Me.m_weight = other.m_weight Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class
