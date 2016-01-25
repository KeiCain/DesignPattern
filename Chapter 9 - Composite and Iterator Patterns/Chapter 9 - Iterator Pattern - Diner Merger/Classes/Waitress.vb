Public Class Waitress
    Private m_dinerMenu As DinerMenu
    Private m_pancakeHouseMenu As PancakeHouseMenu

    Public Sub New(ByVal pancakeHouseMenu As PancakeHouseMenu, ByVal dinerMenu As DinerMenu)
        m_dinerMenu = dinerMenu
        m_pancakeHouseMenu = pancakeHouseMenu
    End Sub

    Public Sub PrintMenu()
        Dim pancakeIterator As PancakeHouseMenuIterator = m_pancakeHouseMenu.createIterator
        Dim dinerIterator As DinerMenuIterator = m_dinerMenu.createIterator

        Console.WriteLine("MENU")
        Console.WriteLine("----")
        Console.WriteLine("BREAKFAST")
        PrintMenu(pancakeIterator)
        Console.WriteLine(Environment.NewLine + "LUNCH")
        PrintMenu(dinerIterator)
    End Sub

    Private Sub PrintMenu(ByVal iterator As IIterator(Of MenuItem))
        While iterator.HasNext
            Dim item As MenuItem = iterator.GetNext
            Console.WriteLine(item.ToString)
        End While
    End Sub

    Public Sub PrintVegetarianMenu()
        PrintVegetarianMenu(m_pancakeHouseMenu.createIterator)
        PrintVegetarianMenu(m_dinerMenu.createIterator)
    End Sub

    Private Sub PrintVegetarianMenu(ByVal iterator As IIterator(Of MenuItem))
        While iterator.HasNext
            Dim item As MenuItem = iterator.GetNext
            If item.IsVegetarian Then
                Console.WriteLine(item.ToString)
            End If
        End While
    End Sub

    Public Function IsItemVegetarian(ByVal name As String) As Boolean
        If IsVegetarian(name, m_pancakeHouseMenu.createIterator) Then
            Return True
        End If
        If IsVegetarian(name, m_dinerMenu.createIterator) Then
            Return True
        End If
        Return False
    End Function

    Private Function IsVegetarian(ByVal name As String, ByVal iterator As IIterator(Of MenuItem)) As Boolean
        While iterator.HasNext
            Dim item As MenuItem = iterator.GetNext
            If item.Name = name Then
                If item.IsVegetarian Then
                    Return True
                End If
            End If
        End While
        Return False
    End Function
End Class
