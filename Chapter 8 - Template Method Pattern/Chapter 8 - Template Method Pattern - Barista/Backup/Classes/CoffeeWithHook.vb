﻿Public Class CoffeeWithHook
    Inherits CaffeineBeverageWithHook

    Public Overrides Sub AddCondiments()
        Console.WriteLine("Add Sugar and Milk")
    End Sub

    Public Overrides Sub Brew()
        Console.WriteLine("Dripping Coffee through filter")
    End Sub

    Public Overrides Function CustomerWantsCondiments() As Boolean
        Dim answer As String = GetUserInput()

        If answer.ToLower.StartsWith("y") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetUserInput() As String
        Dim answer As String

        Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?")

        answer = Console.ReadLine
        If String.IsNullOrEmpty(answer) Then
            Return "no"
        Else
            Return answer
        End If
    End Function
End Class
