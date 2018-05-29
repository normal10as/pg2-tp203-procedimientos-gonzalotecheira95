Module EJ3_4
    Private a, b, c As Double
    Friend k As Double
    Sub Main()
        Console.WriteLine("Ingrese el tamaño del lado A:")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el tamaño del lado B:")
        b = Console.ReadLine()

        Console.WriteLine("El valor de la hipotenusa es : " & hip(a, b))
        Console.ReadKey()
    End Sub

    Private Function hip(ByRef a As Double, ByRef b As Double) As Double

        k = Math.Sqrt((a * a + b * b))

        Return k
    End Function
End Module
