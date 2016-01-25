Public Class PizzaStore
    Private m_factory As SimplePizzaFactory

    Public Sub New(ByVal factory As SimplePizzaFactory)
        m_factory = factory
    End Sub

    Public Function OrderPizza(ByVal type As String) As Pizza
        Dim pizza As Pizza

        pizza = m_factory.CreatePizza(type)

        pizza.Prepare()
        pizza.Bake()
        pizza.Cut()
        pizza.Box()

        Return pizza
    End Function
End Class
