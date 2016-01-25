Public MustInherit Class Duck

    Protected m_flyBehavior As IFlyBehavior

    Public Property FlyBehavior() As IFlyBehavior
        Get
            Return Me.m_flyBehavior
        End Get
        Set(ByVal value As IFlyBehavior)
            Me.m_flyBehavior = value
        End Set
    End Property
    Protected m_quackBehavior As IQuackBehavior

    Public Property QuackBehavior() As IQuackBehavior
        Get
            Return Me.m_quackBehavior
        End Get
        Set(ByVal value As IQuackBehavior)
            Me.m_quackBehavior = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public MustOverride Sub Display()

    Public Sub PerformFly()
        m_flyBehavior.Fly()
    End Sub

    Public Sub PerformQuack()
        m_quackBehavior.Quack()
    End Sub

    Public Sub Swim()
        Console.WriteLine("All ducks float, even decoys!")
    End Sub
End Class
