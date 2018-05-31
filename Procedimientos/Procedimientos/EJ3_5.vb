Module EJ3_5

    Sub Main()
        Dim radio, altura As Double
        Console.WriteLine("Ingrese Radio")
        radio = FUNC(radio)
        Console.WriteLine("Ingrese Altura")
        altura = FUNC(altura)

        Console.WriteLine("El Volumen del cilindro es de " & CALCUVOL(radio, altura))

        Console.ReadKey()

    End Sub
    Friend Function CALCUVOL(ByRef R As Double, ByRef A As Double) As Double
        Dim RESULT As Double


        RESULT = Math.PI * R * R * A

        Return RESULT
    End Function

    Friend Function FUNC(ByRef X As Double)
        X = Console.ReadLine()
        Do While X < 1
            Console.WriteLine("Ingresaste mal, Ingrese numeros Enteros Positivos")
            X = Console.ReadLine()
        Loop
        Return X
    End Function
End Module
