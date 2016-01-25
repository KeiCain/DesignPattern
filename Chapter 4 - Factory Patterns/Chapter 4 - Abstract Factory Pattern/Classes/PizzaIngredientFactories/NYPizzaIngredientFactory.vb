Public Class NYPizzaIngredientFactory
    Implements IPizzaIngredientFactory

    Public Function CreateCheese() As ICheese Implements IPizzaIngredientFactory.CreateCheese
        Return New ReggianoCheese
    End Function

    Public Function CreateClams() As IClams Implements IPizzaIngredientFactory.CreateClams
        Return New FreshClams
    End Function

    Public Function CreateDough() As IDough Implements IPizzaIngredientFactory.CreateDough
        Return New ThinCrustDough
    End Function

    Public Function CreatePepperoni() As IPepperoni Implements IPizzaIngredientFactory.CreatePepperoni
        Return New SlicedPepperoni
    End Function

    Public Function CreateSauce() As ISauce Implements IPizzaIngredientFactory.CreateSauce
        Return New MarinaraSauce
    End Function

    Public Function CreateVeggies() As System.Collections.Generic.List(Of IVeggies) Implements IPizzaIngredientFactory.CreateVeggies
        Dim veggies As New List(Of IVeggies)
        veggies.Add(New Garlic)
        veggies.Add(New Onion)
        veggies.Add(New RedPepper)
        veggies.Add(New Mushroom)

        Return veggies
    End Function
End Class
