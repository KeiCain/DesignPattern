Public Class Mushroom
    Implements IVeggies

    Public Overrides Function ToString() As String Implements IVeggies.ToString
        Return "Mushroom"
    End Function
End Class
