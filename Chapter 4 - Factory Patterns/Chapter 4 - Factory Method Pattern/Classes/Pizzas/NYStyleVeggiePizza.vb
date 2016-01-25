Public Class NYStyleVeggiePizza
    Inherits Pizza

    Public Sub New()
        m_name = "NY Style Veggie Pizza"
        m_dough = "Thin Crust Dough"
        m_sauce = "Marinara Sauce"

        m_toppings.Add("Grated Reggiano Cheese")
        m_toppings.Add("Garlic")
        m_toppings.Add("Onion")
        m_toppings.Add("Mushrooms")
        m_toppings.Add("Red Pepper")
    End Sub
End Class
