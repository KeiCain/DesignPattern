Public Class Spinach
    Implements IVeggies

    Public Overrides Function ToString() As String Implements IVeggies.ToString
        Return "Spinach"
    End Function
End Class
