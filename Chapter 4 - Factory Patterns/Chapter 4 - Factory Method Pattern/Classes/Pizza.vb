Imports System.Collections.Generic

Public MustInherit Class Pizza
    Protected m_name As String
    Public ReadOnly Property Name() As String
        Get
            Return m_name
        End Get
    End Property

    Protected m_dough As String
    Protected m_sauce As String
    Protected m_toppings As New List(Of String)

    Public Sub Prepare()
        Console.WriteLine("Preparing " + name)
        Console.WriteLine("Tossing dough...")
        Console.WriteLine("Adding sauce...")
        Console.WriteLine("Adding toppings: ")
        For Each topping As String In m_toppings
            Console.WriteLine("    " + topping)
        Next
    End Sub

    Public Overridable Sub Bake()
        Console.WriteLine("Bake for 25 minutes at 350")
    End Sub

    Public Overridable Sub Cut()
        Console.WriteLine("Cutting the pizza into diagonal slices")
    End Sub

    Public Overridable Sub Box()
        Console.WriteLine("Place pizza in official PizzaStore box")
    End Sub
End Class
