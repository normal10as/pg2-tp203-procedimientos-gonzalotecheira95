Module EJ3_1

    Private fecha As Date = Now

    Sub Main()
        Fechaactual()
        Horaactual()

        Console.ReadLine()
    End Sub

    Private Sub Fechaactual()
        Console.WriteLine("Fecha Actual: " & fecha.Day & "/" & fecha.Month & "/" & fecha.Year)
    End Sub

    Private Function Horaactual()
        Console.WriteLine("Hora Actual: " & fecha.Hour & ":" & fecha.Minute)
    End Function

End Module
