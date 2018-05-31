Module EJ3_7

    Sub Main()

        parametros()

        Console.ReadKey()

    End Sub
    Private Sub parametros()
        Dim x As Integer
        Dim y As Integer
        Dim ops As Integer
        Dim r As Double

        Console.WriteLine("Ingrese dos numerosa para realizar la operacion: ")
        x = Console.ReadLine()
        y = Console.ReadLine()
        Console.WriteLine("1-Suma 2-Resta 3- Divison 4- Multiplicacion....: ")
        ops = Console.ReadLine()
        r = operaciones(x, y, ops)

        Console.WriteLine("El resultado de la operacion es: " & r)



    End Sub
    Public Function operaciones(ByRef a As Integer, ByRef b As Integer, ByRef op As Double) As Double
        Dim r As Double

        Select Case op
            Case 1
                r = a + b
            Case 2
                r = a - b
            Case 3
                r = a / b
            Case 4
                r = a * b
        End Select

        Return r
    End Function

End Module
