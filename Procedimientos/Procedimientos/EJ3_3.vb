Module EJ3_3
    Sub Main()
        Dim a As Integer

        Console.WriteLine("Ingrese un numero para ver sus 5 potencias: ")
        a = Console.ReadLine()

        poten(a)

        Console.ReadKey()
    End Sub

    Private Function poten(ByRef a As Integer) As Integer
        Dim b, c As Integer
        b = 1
        Do
            b = b + 1
            c = a ^ b

            Console.WriteLine("la potencia por es" & c)
        Loop While (b <= 6)

        Return a
    End Function


End Module
