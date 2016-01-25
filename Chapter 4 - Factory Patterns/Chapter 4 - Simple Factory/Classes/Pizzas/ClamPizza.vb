Public Class ClamPizza
    Inherits Pizza

    Public Sub New()
        m_name = "Clam Pizza"
        m_dough = "Thin Crust"
        m_sauce = "White Garlic Sauce"
        m_toppings.Add("Clams")
        m_toppings.Add("Grated Parmesan Cheese")
    End Sub
End Class
