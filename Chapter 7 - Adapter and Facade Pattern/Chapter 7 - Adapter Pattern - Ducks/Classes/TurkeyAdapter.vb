Public Class TurkeyAdapter
    Implements IDuck
    Private m_turkey As ITurkey

    Public Sub New(ByVal turkey As ITurkey)
        m_turkey = turkey
    End Sub

    Public Sub Fly() Implements IDuck.Fly
        For i As Integer = 1 To 5
            m_turkey.Fly()
        Next
    End Sub

    Public Sub Quack() Implements IDuck.Quack
        m_turkey.Gobble()
    End Sub
End Class
