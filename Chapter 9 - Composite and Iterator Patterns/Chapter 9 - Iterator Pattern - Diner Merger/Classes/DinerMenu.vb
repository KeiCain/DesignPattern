Public Class DinerMenu
    Implements IMenu

    Private Const MAX_ITEMS As Integer = 6
    Private m_numberOfItems As Integer = 0
    Private m_items() As MenuItem

    Public ReadOnly Property MenuItems() As MenuItem()
        Get
            Return m_items
        End Get
    End Property

    Public Sub New()
        ReDim m_items(MAX_ITEMS)

        AddItem("Vegetarian BLT", _
                "(Fakin') Bacon with lettuce & tomato on whole wheat", True, 2.99)
        AddItem("BLT", _
                "Bacon with lettuce & tomato on whole wheat", False, 2.99)
        AddItem("Soup of the day", _
                "Soup of the day, with a side of potato salad", False, 3.29)
        AddItem("Hotdog", _
                "A hot dog, with saurkraut, relish, onions, topped with cheese", _
                False, 3.05)
        AddItem("Steamed Veggies and Brown Rice", _
                "Steamed vegetables over brown rice", True, 3.99)
        AddItem("Pasta", _
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread", _
                True, 3.89)
    End Sub

    Private Sub AddItem(ByVal name As String, ByVal description As String, ByVal isVegetarian As Boolean, ByVal price As Double)
        Dim item As New MenuItem(name, description, isVegetarian, price)
        If m_numberOfItems >= MAX_ITEMS Then
            Console.WriteLine("Sorry, menu is full! Can't add item to menu")
        Else
            m_items(m_numberOfItems) = item
            m_numberOfItems += 1
        End If
    End Sub

    Public Function createIterator() As IIterator(Of MenuItem) Implements IMenu.createIterator
        Return New DinerMenuIterator(m_items)
    End Function
End Class
