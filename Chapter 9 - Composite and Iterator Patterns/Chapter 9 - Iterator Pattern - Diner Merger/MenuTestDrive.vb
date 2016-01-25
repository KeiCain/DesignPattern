Module MenuTestDrive

    Sub Main()
        Dim pancakeHouseMenu As New PancakeHouseMenu
        Dim dinerMenu As New DinerMenu

        Dim waitress As New Waitress(pancakeHouseMenu, dinerMenu)

        waitress.PrintMenu()
        Console.ReadLine()
    End Sub

End Module
