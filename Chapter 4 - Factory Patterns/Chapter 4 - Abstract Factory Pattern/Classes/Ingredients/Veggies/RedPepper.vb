Public Class RedPepper
    Implements IVeggies

    Public Overrides Function ToString() As String Implements IVeggies.ToString
        Return "Red Pepper"
    End Function
End Class
