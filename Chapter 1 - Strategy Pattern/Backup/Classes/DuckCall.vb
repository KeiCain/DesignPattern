Public MustInherit Class DuckCall
    Protected m_quackBehavior As IQuackBehavior

    Public Property QuackBehavior() As IQuackBehavior
        Get
            Return m_quackBehavior
        End Get
        Set(ByVal value As IQuackBehavior)
            m_quackBehavior = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public MustOverride Sub Display()

    Public Sub PerformCall()
        m_quackBehavior.Quack()
    End Sub
End Class
