Public Class RubberDuck
    Inherits Duck

    Public Sub New()
        m_flyBehavior = New FlyNoWay
        m_quackBehavior = New Squeak
    End Sub

    Public Overrides Sub Display()
        Console.WriteLine("I'm made of rubber whoooopee!")
    End Sub
End Class
