Imports System.Text

Public MustInherit Class Pizza
    Protected m_dough As String
    Protected m_sauce As String
    Protected m_name As String
    Protected m_toppings As New List(Of String)

    Public ReadOnly Property Name() As String
        Get
            Return m_name
        End Get
    End Property

    Public Sub Prepare()
        Console.WriteLine("Preparing " + m_name)
    End Sub

    Public Sub Bake()
        Console.WriteLine("Baking " + m_name)
    End Sub

    Public Sub Cut()
        Console.WriteLine("Cutting " + m_name)
    End Sub

    Public Sub Box()
        Console.WriteLine("Boxing " + m_name)
    End Sub

    Public Overrides Function ToString() As String
        Dim display As New StringBuilder()
        display.AppendLine("---- " + m_name + " ----")
        display.AppendLine(m_dough)
        display.AppendLine(m_sauce)
        For Each topping As String In m_toppings
            display.AppendLine(topping)
        Next
        Return display.ToString
    End Function
End Class
