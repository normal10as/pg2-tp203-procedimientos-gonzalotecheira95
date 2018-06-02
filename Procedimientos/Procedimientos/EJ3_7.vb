Enum Operaciones
    suma = 1
    resta
    multiplicacion
    division
End Enum
Module EJ3_7

    Sub Main()

        'Operacion con 2 valores
        Console.WriteLine("Suma con 2 valores " & Calcular(Operaciones.suma, 2, 2))
        Console.WriteLine("Resta con 2 valores " & Calcular(Operaciones.resta, 23, 10))
        Console.WriteLine("Multiplicacion con 2 valores " & Calcular(Operaciones.multiplicacion, 5, 2))
        Console.WriteLine("Division con 2 valores " & Calcular(Operaciones.division, 18, 2) & vbCrLf & vbCrLf)
        'Operacion con 3 valores
        Console.WriteLine("Suma con 3 valores " & Calcular(Operaciones.suma, 2, 2, 3))
        Console.WriteLine("Resta con 3 valores " & Calcular(Operaciones.resta, 23, 10, 2))
        Console.WriteLine("Multiplicacion con 3 valores " & Calcular(Operaciones.multiplicacion, 5, 2, 2))
        Console.WriteLine("Division con 3 valores " & Calcular(Operaciones.division, 18, 2, 3) & vbCrLf & vbCrLf)
        'Operacion con 4 valores
        Console.WriteLine("Suma con 4 valores " & Calcular(Operaciones.suma, 2, 2, 2, 2))
        Console.WriteLine("Resta con 4 valores " & Calcular(Operaciones.resta, 23, 10, 5, 20))
        Console.WriteLine("Multiplicacion con 4 valores " & Calcular(Operaciones.multiplicacion, 5, 2, 3, 2))
        Console.WriteLine("Division con 4 valores " & Calcular(Operaciones.division, 18, 2, 3, 2) & vbCrLf)
        'suma
        Console.WriteLine("Suma " & Calcular(2, 4))
        Console.ReadKey()

    End Sub

    Function Calcular(operaciones As Operaciones, ByRef a As Integer, ByRef b As Integer) As Double

        Select Case operaciones
            Case Operaciones.suma
                Return a + b
            Case Operaciones.resta
                Return a - b
            Case Operaciones.multiplicacion
                Return a * b
            Case Operaciones.division
                Return a / b
        End Select
        Return operaciones
    End Function
    Function Calcular(operaciones As Operaciones, ByRef a As Integer, ByRef b As Integer, ByRef c As Integer) As Double

        Select Case operaciones
            Case Operaciones.suma
                Return a + b + c
            Case Operaciones.resta
                Return a - b - c
            Case Operaciones.multiplicacion
                Return a * b * c
            Case Operaciones.division
                Return a / b / c
        End Select
        Return operaciones
    End Function
    Function Calcular(operaciones As Operaciones, ByRef a As Integer, ByRef b As Integer, ByRef c As Integer, ByRef d As Integer) As Double

        Select Case operaciones
            Case Operaciones.suma
                Return a + b + c + d
            Case Operaciones.resta
                Return a - b - c - d
            Case Operaciones.multiplicacion
                Return a * b * c * d
            Case Operaciones.division
                Return a / b / c / d
        End Select
        Return operaciones
    End Function
    Function Calcular(ByRef a As Integer, ByRef b As Integer) As Integer
        Return a + b
    End Function


End Module