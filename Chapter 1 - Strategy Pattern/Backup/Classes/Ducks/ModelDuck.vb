Public Class ModelDuck
    Inherits Duck

    Public Sub New()
        m_flyBehavior = New FlyNoWay
        m_quackBehavior = New Quack
    End Sub

    Public Overrides Sub Display()
        Console.WriteLine("I'm a model duck")
    End Sub
End Class
