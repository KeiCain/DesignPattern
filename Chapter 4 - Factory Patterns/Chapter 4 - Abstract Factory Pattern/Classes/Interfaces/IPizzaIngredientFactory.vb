Public Interface IPizzaIngredientFactory
    Function CreateDough() As IDough
    Function CreateSauce() As ISauce
    Function CreateCheese() As ICheese
    Function CreateVeggies() As List(Of IVeggies)
    Function CreatePepperoni() As IPepperoni
    Function CreateClams() As IClams

End Interface
