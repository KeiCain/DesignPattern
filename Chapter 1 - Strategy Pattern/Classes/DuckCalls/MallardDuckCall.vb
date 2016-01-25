Public Class MallardDuckCall
    Inherits DuckCall

    Public Sub New()
        m_quackBehavior = New Quack
    End Sub

    Public Overrides Sub Display()
        Console.WriteLine("This is a mallard duck call. Such a smooth finish it has!")
    End Sub
End Class
