Module EJ3_5

    Sub Main()
        Dim radio, altura As Double
        Console.WriteLine("Ingrese Radio")
        radio = Console.ReadLine()
        Console.WriteLine("Ingrese Altura")
        altura = Console.ReadLine()

        Console.WriteLine("El Volumen del cilindro es de " & CALCUVOL(radio, altura))

        Console.ReadKey()

    End Sub
    Friend Function CALCUVOL(ByRef R As Double, ByRef A As Double) As Double
        Dim RESULT As Double

        RESULT = Math.PI * R * R * A

        Return RESULT
    End Function
End Module
