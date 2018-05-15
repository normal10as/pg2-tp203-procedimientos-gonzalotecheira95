Module EJ3_2
    Sub Main()
        Dim sum As Integer
        Dim fecha As New DateTime(Now.Year, Now.Month, Now.Day)
        fecha.ToString("yyyyMMdd")

        Console.WriteLine("Fecha Actual: " & fecha)
        Console.WriteLine("Ingrese los dias para sumar: ")
        sum = Console.ReadLine()

        Console.WriteLine("dias sumados con funcion: " & sumar(fecha, sum))

        Console.ReadKey()
    End Sub
    Private Function sumar(ByRef a As Date, ByRef b As Int16) As Date
        a = a.AddDays(b)
        Return a
    End Function
End Module
