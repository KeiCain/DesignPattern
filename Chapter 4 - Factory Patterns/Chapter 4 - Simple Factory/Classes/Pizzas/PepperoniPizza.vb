Public Class PepperoniPizza
    Inherits Pizza

    Public Sub New()
        m_name = "Pepperoni Pizza"
        m_dough = "Crust"
        m_sauce = "Marinara Sauce"
        m_toppings.Add("Sliced Pepperoni")
        m_toppings.Add("Sliced Onion")
        m_toppings.Add("Grated Parmesan Cheese")
    End Sub
End Class
