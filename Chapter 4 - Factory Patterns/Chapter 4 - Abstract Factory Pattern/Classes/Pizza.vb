Imports System.Text

Public MustInherit Class Pizza
    Protected m_dough As IDough
    Protected m_sauce As ISauce
    Protected m_veggies As List(Of IVeggies)
    Protected m_cheese As ICheese
    Protected m_pepperoni As IPepperoni
    Protected m_clams As IClams
    Protected m_name As String

    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            m_name = value
        End Set
    End Property

    Public MustOverride Sub Prepare()

    Public Overridable Sub Bake()
        Console.WriteLine("Bake for 25 minutes at 350")
    End Sub

    Public Overridable Sub Cut()
        Console.WriteLine("Cutting the pizza into diagonal slices")
    End Sub

    Public Overridable Sub Box()
        Console.WriteLine("Place pizza in official PizzaStore box")
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        sb.AppendLine("---- " + m_name + " ----")
        If m_dough IsNot Nothing Then
            sb.AppendLine(m_dough.ToString)
        End If
        If m_sauce IsNot Nothing Then
            sb.AppendLine(m_sauce.ToString)
        End If
        If m_cheese IsNot Nothing Then
            sb.AppendLine(m_cheese.ToString)
        End If
        If m_veggies IsNot Nothing Then
            For Each veggie As IVeggies In m_veggies
                sb.Append(veggie.ToString + " ")
            Next
            sb.AppendLine()
        End If
        If m_clams IsNot Nothing Then
            sb.AppendLine(m_clams.ToString)
        End If
        If m_pepperoni IsNot Nothing Then
            sb.AppendLine(m_pepperoni.ToString)
        End If
        Return sb.ToString
    End Function
End Class
