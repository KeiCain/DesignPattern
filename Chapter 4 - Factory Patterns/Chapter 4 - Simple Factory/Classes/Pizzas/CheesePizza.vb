Public Class CheesePizza
    Inherits Pizza

    Public Sub New()
        m_name = "Cheese Pizza"
        m_dough = "Regular Crust"
        m_sauce = "Marinara Pizza Sauce"
        m_toppings.Add("Fresh Mozzarella")
        m_toppings.Add("Parmesan")
    End Sub
End Class
