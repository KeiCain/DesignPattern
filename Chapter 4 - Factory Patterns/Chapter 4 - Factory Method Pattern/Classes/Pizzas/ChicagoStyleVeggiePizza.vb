Public Class ChicagoStyleVeggiePizza
    Inherits Pizza

    Public Sub New()
        m_name = "Chicago Style Veggie Pizza"
        m_dough = "Extra Thick Crust Dough"
        m_sauce = "Plum Tomato Sauce"

        m_toppings.Add("Shredded Mozzarella Cheese")
        m_toppings.Add("Black Olives")
        m_toppings.Add("Spinach")
        m_toppings.Add("Eggplant")
    End Sub

    Public Overrides Sub Cut()
        Console.WriteLine("Cutting the pizza into square slices")
    End Sub
End Class
