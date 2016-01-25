Public Class ChicagoStyleClamPizza
    Inherits Pizza

    Public Sub New()
        m_name = "Chicago Style Clam Pizza"
        m_dough = "Extra Thick Crust Dough"
        m_sauce = "Plum Tomato Sauce"

        m_toppings.Add("Shredded Mozzarella Cheese")
        m_toppings.Add("Frozen Clams from Chesapeake Bay")
    End Sub

    Public Overrides Sub Cut()
        Console.WriteLine("Cutting the pizza into square slices")
    End Sub
End Class
