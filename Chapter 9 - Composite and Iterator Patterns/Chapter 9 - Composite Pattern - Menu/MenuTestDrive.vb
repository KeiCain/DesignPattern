Module MenuTestDrive

    Sub Main()
        Dim pancakeHouseMenu As MenuComponent = New Menu("PANCAKE HOUSE MENU", "Breakfast")
        Dim dinerMenu As MenuComponent = New Menu("DINER MENU", "Lunch")
        Dim cafeMenu As MenuComponent = New Menu("CAFE MENU", "Dinner")
        Dim dessertMenu As MenuComponent = New Menu("DESSERT MENU", "Dessert of course!")
        Dim coffeeMenu As MenuComponent = New Menu("COFFEE MENU", "Stuff to go with your afternoon coffee")

        Dim allMenus As MenuComponent = New Menu("ALL MENUS", "All menus combined")

        allMenus.Add(pancakeHouseMenu)
        allMenus.Add(dinerMenu)
        allMenus.Add(cafeMenu)

        pancakeHouseMenu.Add(New MenuItem( _
           "K&B's Pancake Breakfast", _
           "Pancakes with scrambled eggs, and toast", _
           True, _
           2.99))

        pancakeHouseMenu.Add(New MenuItem( _
           "Regular Pancake Breakfast", _
           "Pancakes with fried eggs, sausage", _
           False, _
           2.99))

        pancakeHouseMenu.Add(New MenuItem( _
           "Blueberry Pancakes", _
           "Pancakes made with fresh blueberries, and blueberry syrup", _
           True, _
           3.49))
        pancakeHouseMenu.Add(New MenuItem( _
           "Waffles", _
           "Waffles, with your choice of blueberries or strawberries", _
           True, _
           3.59))

        dinerMenu.Add(New MenuItem( _
           "Vegetarian BLT", _
           "(Fakin') Bacon with lettuce & tomato on whole wheat", _
           True, _
           2.99))
        dinerMenu.Add(New MenuItem( _
           "BLT", _
           "Bacon with lettuce & tomato on whole wheat", _
           False, _
           2.99))
        dinerMenu.Add(New MenuItem( _
           "Soup of the day", _
           "A bowl of the soup of the day, with a side of potato salad", _
           False, _
           3.29))
        dinerMenu.Add(New MenuItem( _
           "Hotdog", _
           "A hot dog, with saurkraut, relish, onions, topped with cheese", _
           False, _
           3.05))
        dinerMenu.Add(New MenuItem( _
           "Steamed Veggies and Brown Rice", _
           "Steamed vegetables over brown rice", _
           True, _
           3.99))

        dinerMenu.Add(New MenuItem( _
           "Pasta", _
           "Spaghetti with Marinara Sauce, and a slice of sourdough bread", _
           True, _
           3.89))

        dinerMenu.Add(dessertMenu)

        dessertMenu.Add(New MenuItem( _
           "Apple Pie", _
           "Apple pie with a flakey crust, topped with vanilla icecream", _
           True, _
           1.59))

        dessertMenu.Add(New MenuItem( _
           "Cheesecake", _
           "Creamy New York cheesecake, with a chocolate graham crust", _
           True, _
           1.99))
        dessertMenu.Add(New MenuItem( _
           "Sorbet", _
           "A scoop of raspberry and a scoop of lime", _
           True, _
           1.89))

        cafeMenu.Add(New MenuItem( _
           "Veggie Burger and Air Fries", _
           "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", _
           True, _
           3.99))
        cafeMenu.Add(New MenuItem( _
           "Soup of the day", _
           "A cup of the soup of the day, with a side salad", _
           False, _
           3.69))
        cafeMenu.Add(New MenuItem( _
           "Burrito", _
           "A large burrito, with whole pinto beans, salsa, guacamole", _
           True, _
           4.29))

        cafeMenu.Add(coffeeMenu)

        coffeeMenu.Add(New MenuItem( _
           "Coffee Cake", _
           "Crumbly cake topped with cinnamon and walnuts", _
           True, _
           1.59))
        coffeeMenu.Add(New MenuItem( _
           "Bagel", _
           "Flavors include sesame, poppyseed, cinnamon raisin, pumpkin", _
           False, _
           0.69))
        coffeeMenu.Add(New MenuItem( _
           "Biscotti", _
           "Three almond or hazelnut biscotti cookies", _
           True, _
           0.89))

        Dim waitress As New Waitress(allMenus)
        waitress.PrintMenu()
        Console.ReadLine()
    End Sub

End Module
