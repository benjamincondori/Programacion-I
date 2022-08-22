Public Class Vector

    Const MAX = 100
    Private v(MAX) As Integer
    Private n As Integer

    Public Sub vector()
        n = 0
    End Sub

    Public Sub Cargar(n1 As Integer, a As Integer, b As Integer)
        Dim i As Integer
        n = n1
        For i = 1 To n
            v(i) = a + Rnd() * (b - a)
        Next
    End Sub

    Public Sub Cargar_Manual(elemento As Integer)
        n = n + 1
        v(n) = elemento
    End Sub

    Public Function Descargar() As String
        Dim result As String = " "
        Dim i As Integer
        For i = 1 To n
            result = result + Str(v(i)) + ";"
        Next
        Return result
    End Function

    Public Sub Ejercicio_1(ne As Integer, b As Integer)
        Dim i, result, exp, vi, r As Integer
        n = ne : vi = 0 : r = 1
        For i = 1 To n
            exp = vi + (i - 1) * r
            result = b ^ exp
            v(i) = result
        Next
    End Sub

    Public Function Ejercicio_2() As Integer
        Dim i As Integer
        Dim contador As Integer = 0
        Dim n1 As NEnt = New NEnt()
        For i = 1 To n
            n1.Cargar(i)
            If n1.Verificar_Submultiplo(v(i)) Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function

    Public Function Ejercicio_3(m As Integer) As Integer
        Dim i As Integer
        Dim mayor As Integer = 0
        Dim result As Integer = 0
        Dim n1 As NEnt = New NEnt()
        For i = 1 To n
            n1.Cargar(i)
            If n1.Verificar_Multiplo(m) Then
                If v(i) > mayor Then
                    mayor = v(i)
                End If
            End If
        Next
        Return mayor
    End Function

    Public Sub Ejercicio_4(r As Vector, r2 As Vector)
        Dim ir As Integer = 0
        Dim ip As Integer = 0
        Dim i As Integer
        Dim nu As NEnt = New NEnt
        For i = 1 To n
            nu.Cargar(v(i))
            If nu.Verificar_Primo() Then
                ir = ir + 1
                r.v(ir) = v(i)
            Else
                ip = ip + 1
                r2.v(ip) = v(i)
            End If
        Next
        r.n = ir
        r2.n = ip
    End Sub

    Public Sub Intercambiar(a As Integer, b As Integer)
        Dim aux As Integer
        aux = v(a)
        v(a) = v(b)
        v(b) = aux
    End Sub

    Public Sub Ejercicio_5()
        Dim d As Integer = n
        Dim i As Integer
        For i = 1 To (n / 2)
            Intercambiar(i, d)
            d = d - 1
        Next
    End Sub

    Public Function Ejercicio_6() As Boolean
        Dim i As Integer = 1
        Dim b As Boolean = True
        Dim n1 As NEnt = New NEnt()
        While (i <= n) And (b = True)
            n1.Cargar(v(i))
            If Not n1.Verificar_Primo() Then
                b = False
            Else
                i = i + 1
            End If
        End While
        Return b
    End Function

    Public Function Buscar_Elemento(x As Integer) As Boolean
        Dim i As Integer = 1
        Dim result As Boolean = False
        While (i <= n) And (result = False)
            If x = v(i) Then
                result = True
            End If
            i = i + 1
        End While
        Return result
    End Function

    Public Sub Ejercicio_7(v1 As Vector, v2 As Vector)
        Dim i As Integer
        For i = 1 To n
            If v1.Buscar_Elemento(v(i)) And (Not v2.Buscar_Elemento(v(i))) Then
                v2.n = v2.n + 1
                v2.v(v2.n) = v(i)
            End If
        Next
    End Sub

    Public Sub Ejercicio_8(v1 As Vector, v2 As Vector)
        Dim i As Integer
        For i = 1 To n
            If Not v2.Buscar_Elemento(v(i)) Then
                v2.n = v2.n + 1
                v2.v(v2.n) = v(i)
            End If
        Next

        For i = 1 To v1.n
            If Not v2.Buscar_Elemento(v1.v(i)) Then
                v2.n = v2.n + 1
                v2.v(v2.n) = v1.v(i)
            End If
        Next
    End Sub

    Public Function Ejercicio_9(a As Integer, b As Integer) As Boolean
        Dim i As Integer = a
        Dim result As Boolean = True
        For i = a To b
            For j = i + 1 To b
                If Not v(i) <= v(j) Then
                    result = False
                End If
            Next
        Next
        Return result
    End Function

    Public Function Ejercicio_10(a As Integer, b As Integer) As Boolean  
        Dim i As Integer = a
        Dim result As Boolean = True
        Dim aux As Integer = v(a)
        Dim n1 As NEnt = New NEnt()
        While (i <= b) And (result = True)
            n1.Cargar(v(i))
            If n1.Verificar_Capicua() Then
                aux = v(i)
            Else
                result = False
            End If
            i = i + 1
        End While
        Return result
    End Function

    Public Sub Insertar_Elemento_Posicion(elemento As Integer, posicion As Integer)
        n = n + 1
        For i = n To posicion + 1 Step -1
            v(i) = v(i - 1)
        Next
        v(posicion) = elemento
    End Sub

    Public Sub Ejercicio_11(v2 As Vector, posicion As Integer)
        Dim i, j As Integer
        i = posicion
        For j = 1 To v2.n
            Insertar_Elemento_Posicion(v2.v(j), i)
            i = i + 1
        Next
    End Sub

    Public Sub Ejercicio_12(a As Integer, b As Integer)
        Dim j As Integer = 0
        For i = b + 1 To n
            v(a + j) = v(i)
            j = j + 1
        Next
        n = n - (b - a + 1)
    End Sub

    Public Sub Ejercicio_13(a As Integer, b As Integer)
        Dim i, j As Integer
        For j = b To a + 1 Step -1
            For i = a To j - 1
                If v(i) > v(i + 1) Then
                    Intercambiar(i, i + 1)
                End If
            Next
        Next
    End Sub

    Public Function Ejercicio_14(a As Integer, b As Integer) As Integer
        Dim contador As Integer = 0
        Dim elemento As Integer
        Ejercicio_13(a, b)
        While a <= b
            elemento = v(a)
            While (a <= b) And (elemento = v(a))
                a = a + 1
            End While
            contador = contador + 1
        End While
        Return contador
    End Function

    Public Sub Ejercicio_15(a As Integer, b As Integer, r As Vector)
        Dim elemento As Integer
        Dim contador As Integer = 0
        Ejercicio_13(a, b)
        While a <= b
            elemento = v(a)
            While (a <= b) And (v(a) = elemento)
                a = a + 1
            End While
            contador = contador + 1
            r.v(contador) = elemento
        End While
        r.n = contador
    End Sub

    Public Sub Ejercicio_16(a As Integer, b As Integer, v1 As Vector, v2 As Vector)
        Dim elemento As Integer
        Dim contador As Integer = 0
        Dim frecuencia As Integer
        While a <= b
            elemento = v(a)
            frecuencia = 0
            While (a <= b) And (v(a) = elemento)
                a = a + 1
                frecuencia = frecuencia + 1
            End While
            contador = contador + 1
            v1.v(contador) = elemento
            v2.v(contador) = frecuencia
        End While
        v1.n = contador
        v2.n = contador
    End Sub

    Public Function Frecuencia(elemento As Integer) As Integer
        Dim frec As Integer = 0
        For i = 1 To n
            If elemento = v(i) Then
                frec = frec + 1
            End If
        Next
        Return frec
    End Function

    Public Function Ejercicio_17(a As Integer, b As Integer) As Integer
        Dim i As Integer = a
        Dim frec As Integer = Frecuencia(v(i))
        Dim elemento As Integer = v(i)
        For i = a To b
            If Frecuencia(v(i)) < frec Then
                frec = Frecuencia(v(i))
                elemento = v(i)
            End If
        Next
        Return elemento
    End Function

    Public Sub Invertir(a As Integer, b As Integer)
        Dim i As Integer
        For i = a To (b / 2)
            Intercambiar(i, b)
            b = b - 1
        Next
    End Sub

    Public Sub Ejercicio_18(a As Integer, b As Integer)
        Dim i, j As Integer
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        For i = a To b
            For j = i + 1 To b
                n1.Cargar(v(j))
                n2.Cargar(v(i))
                If n1.Verificar_Primo() And Not n2.Verificar_Primo() Or
                    n1.Verificar_Primo() And n2.Verificar_Primo() And v(i) > v(j) Or
                    Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And v(i) > v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    Public Sub Ejercicio_19()
        Dim i, j As Integer
        For i = 1 To n
            For j = i + 1 To n
                If Frecuencia(v(i)) < Frecuencia(v(j)) Or
                   Frecuencia(v(i)) = Frecuencia(v(j)) And v(i) > v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    Public Sub Ejercicio_20(a As Integer, b As Integer)
        Dim i, j As Integer
        Dim bandera As Boolean = True
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        For i = a To b
            If bandera = True Then
                For j = i + 1 To b
                    n1.Cargar(v(j))
                    n2.Cargar(v(i))
                    If n1.Verificar_Primo() And Not n2.Verificar_Primo() Or
                            n1.Verificar_Primo() And n2.Verificar_Primo() And v(i) > v(j) Or
                            Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And v(i) > v(j) Then
                        Intercambiar(i, j)
                    End If
                Next
            Else
                For j = i + 1 To b
                    n1.Cargar(v(j))
                    n2.Cargar(v(i))
                    If Not n1.Verificar_Primo() And n2.Verificar_Primo() Or
                            Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And v(i) > v(j) Or
                             n1.Verificar_Primo() And n2.Verificar_Primo() And v(i) > v(j) Then
                        Intercambiar(i, j)
                    End If
                Next
            End If
            bandera = Not bandera
        Next
    End Sub

End Class
