Enum Operaciones2
    suma = 1
    resta
    multiplicacion
    division
End Enum
Module EJ3_8
    Sub Main()
        Dim calculo = New Operaciones2

        Resultado(calculo, 50, 50) 'con 2 valores
        Resultado(calculo, 50, 5, 25) 'con 3 valores
        Resultado(calculo, 50, 2, 2, 5) ' con 5 valores

        'suma
        Console.WriteLine("Suma " & Calcular(2, 4))
        Console.ReadKey()

    End Sub
    Friend Sub Resultado(operaciones2 As Operaciones2, ByRef a As Integer, ByRef b As Integer)
        'Operacion con 2 valores
        Console.WriteLine("Suma con 2 valores " & Calcular(Operaciones2.suma, a, b))
        Console.WriteLine("Resta con 2 valores " & Calcular(Operaciones2.resta, a, b))
        Console.WriteLine("Multiplicacion con 2 valores " & Calcular(Operaciones2.multiplicacion, a, b))
        Console.WriteLine("Division con 2 valores " & Calcular(Operaciones2.division, a, b) & vbCrLf & vbCrLf)
    End Sub
    Friend Sub Resultado(operaciones2 As Operaciones2, ByRef a As Integer, ByRef b As Integer, ByRef c As Integer)
        'Operacion con 3 valores
        Console.WriteLine("Suma con 3 valores " & Calcular(Operaciones2.suma, a, b, c))
        Console.WriteLine("Resta con 3 valores " & Calcular(Operaciones2.resta, a, b, c))
        Console.WriteLine("Multiplicacion con 3 valores " & Calcular(Operaciones2.multiplicacion, a, b, c))
        Console.WriteLine("Division con 3 valores " & Calcular(Operaciones2.division, a, b, c) & vbCrLf & vbCrLf)
    End Sub
    Friend Sub Resultado(operaciones2 As Operaciones2, ByRef a As Integer, ByRef b As Integer, ByRef c As Integer, ByRef d As Integer)
        'Operacion con 4 valores
        Console.WriteLine("Suma con 4 valores " & Calcular(Operaciones2.suma, a, b, c, d))
        Console.WriteLine("Resta con 4 valores " & Calcular(Operaciones2.resta, a, b, c, d))
        Console.WriteLine("Multiplicacion con 4 valores " & Calcular(Operaciones2.multiplicacion, a, b, c, d))
        Console.WriteLine("Division con 4 valores " & Calcular(Operaciones2.division, a, b, c, d) & vbCrLf)
    End Sub
    Function Calcular(operaciones2 As Operaciones2, ByRef a As Integer, ByRef b As Integer) As Double

        Select Case operaciones2
            Case Operaciones.suma
                Return a + b
            Case Operaciones.resta
                Return a - b
            Case Operaciones.multiplicacion
                Return a * b
            Case Operaciones.division
                Return a / b
        End Select
        Return operaciones2
    End Function
    Function Calcular(operaciones2 As Operaciones, ByRef a As Integer, ByRef b As Integer, ByRef c As Integer) As Double

        Select Case operaciones2
            Case Operaciones.suma
                Return a + b + c
            Case Operaciones.resta
                Return a - b - c
            Case Operaciones.multiplicacion
                Return a * b * c
            Case Operaciones.division
                Return a / b / c
        End Select
        Return operaciones2
    End Function
    Function Calcular(operaciones2 As Operaciones, ByRef a As Integer, ByRef b As Integer, ByRef c As Integer, ByRef d As Integer) As Double

        Select Case operaciones2
            Case Operaciones.suma
                Return a + b + c + d
            Case Operaciones.resta
                Return a - b - c - d
            Case Operaciones.multiplicacion
                Return a * b * c * d
            Case Operaciones.division
                Return a / b / c / d
        End Select
        Return Operaciones2
    End Function
    Function Calcular(ByRef a As Integer, ByRef b As Integer) As Integer
        Return a + b
    End Function
End Module
