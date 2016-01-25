Public Class ChicagoPizzaIngredientFactory
    Implements IPizzaIngredientFactory

    Public Function CreateCheese() As ICheese Implements IPizzaIngredientFactory.CreateCheese
        Return New MozzarellaCheese
    End Function

    Public Function CreateClams() As IClams Implements IPizzaIngredientFactory.CreateClams
        Return New FrozenClams
    End Function

    Public Function CreateDough() As IDough Implements IPizzaIngredientFactory.CreateDough
        Return New ThickCrustDough
    End Function

    Public Function CreatePepperoni() As IPepperoni Implements IPizzaIngredientFactory.CreatePepperoni
        Return New SlicedPepperoni
    End Function

    Public Function CreateSauce() As ISauce Implements IPizzaIngredientFactory.CreateSauce
        Return New PlumTomatoSauce
    End Function

    Public Function CreateVeggies() As System.Collections.Generic.List(Of IVeggies) Implements IPizzaIngredientFactory.CreateVeggies
        Dim veggies As New List(Of IVeggies)
        veggies.Add(New Spinach)
        veggies.Add(New BlackOlives)
        veggies.Add(New Eggplant)

        Return veggies
    End Function
End Class
