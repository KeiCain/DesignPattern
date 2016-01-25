Public Class ChicagoStyleCheesePizza
    Inherits Pizza

    Public Sub New()
        m_name = "Chicago Style Deep Dish Cheese Pizza"
        m_dough = "Extra Thick Crust Dough"
        m_sauce = "Plum Tomato Sauce"

        m_toppings.Add("Shredded Mozzarella Cheese")
    End Sub

    Public Overrides Sub Cut()
        Console.WriteLine("Cutting the pizza into square slices")
    End Sub
End Class
