Public Class PlumTomatoSauce
    Implements ISauce

    Public Overrides Function ToString() As String Implements ISauce.ToString
        Return "Tomato sauce with plum tomatoes"
    End Function
End Class
