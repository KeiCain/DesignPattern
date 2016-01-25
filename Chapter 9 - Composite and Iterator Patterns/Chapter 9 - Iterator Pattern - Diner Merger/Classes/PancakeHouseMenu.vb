Public Class PancakeHouseMenu
    Implements IMenu
    Private m_items As List(Of MenuItem)
    Public ReadOnly Property MenuItems() As List(Of MenuItem)
        Get
            Return m_items
        End Get
    End Property

    Public Sub New()
        m_items = New List(Of MenuItem)

        AddItem("K&B's Pancake Breakfast", _
                 "Pancakes with scrambled eggs, and toast", _
                 True, _
                 2.99)

        AddItem("Regular Pancake Breakfast", _
                 "Pancakes with fried eggs, sausage", _
                 False, _
                 2.99)

        AddItem("Blueberry Pancakes", _
                 "Pancakes made with fresh blueberries", _
                 True, _
                 3.49)

        AddItem("Waffles", _
                 "Waffles, with your choice of blueberries or strawberries", _
                 True, _
                 3.59)
    End Sub

    Private Sub AddItem(ByVal name As String, ByVal description As String, ByVal isVegetarian As Boolean, ByVal price As Double)
        Dim item As New MenuItem(name, description, isVegetarian, price)
        m_items.Add(item)
    End Sub

    Public Function createIterator() As IIterator(Of MenuItem) Implements IMenu.createIterator
        Return New PancakeHouseMenuIterator(m_items)
    End Function

    Public Overrides Function ToString() As String
        Return "Objectville Pancake House Menu"
    End Function

    'Other menu methods here
End Class
