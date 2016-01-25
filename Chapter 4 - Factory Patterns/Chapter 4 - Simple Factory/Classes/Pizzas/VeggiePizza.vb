Public Class VeggiePizza
    Inherits Pizza

    Public Sub New()
        m_name = "Veggie Pizza"
        m_dough = "Crust"
        m_sauce = "Marinara Sauce"

        m_toppings.Add("Shredded Mozzarella")
        m_toppings.Add("Grated Parmesan")
        m_toppings.Add("Diced onion")
        m_toppings.Add("Sliced mushrooms")
        m_toppings.Add("Sliced red pepper")
        m_toppings.Add("Sliced black olives")
    End Sub
End Class
