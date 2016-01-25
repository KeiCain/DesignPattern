Public Class NYStyleClamPizza
    Inherits Pizza

    Public Sub New()
        m_name = "NY Style Clam Pizza"
        m_dough = "Thin Crust Dough"
        m_sauce = "Marinara Sauce"

        m_toppings.Add("Grated Reggiano Cheese")
        m_toppings.Add("Fresh Clams from Long Island Sound")
    End Sub
End Class
