Public Class DuckAdapter
    Implements ITurkey
    Private m_duck As IDuck
    Private m_rand As Random

    Public Sub New(ByVal duck As IDuck)
        m_duck = duck
        m_rand = New Random
    End Sub

    Public Sub Fly() Implements ITurkey.Fly
        If m_rand.Next(5) = 0 Then
            m_duck.Fly()
        End If
    End Sub

    Public Sub Gobble() Implements ITurkey.Gobble
        m_duck.Quack()
    End Sub
End Class
