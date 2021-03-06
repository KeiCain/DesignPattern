﻿Public Class ClamPizza
    Inherits Pizza
    Private m_ingredientFactory As IPizzaIngredientFactory

    Public Sub New(ByVal ingredientFactory As IPizzaIngredientFactory)
        m_ingredientFactory = ingredientFactory
    End Sub

    Public Overrides Sub Prepare()
        Console.WriteLine("Preparing " + m_name)
        m_dough = m_ingredientFactory.CreateDough
        m_sauce = m_ingredientFactory.CreateSauce
        m_cheese = m_ingredientFactory.CreateCheese
        m_clams = m_ingredientFactory.CreateClams
    End Sub
End Class
