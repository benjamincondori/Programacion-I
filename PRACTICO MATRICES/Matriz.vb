Public Class Matriz

    Const MAXF = 100
    Const MAXC = 100
    Private m(MAXF, MAXC) As Integer
    Private f, c As Integer

    Public Sub Matriz()
        f = 0
        c = 0
    End Sub

    Public Sub Cargar_Secuencia(nf As Integer, nc As Integer, vi As Integer, r As Integer)
        Dim f1, c1, i As Integer
        i = 0
        f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                i = i + 1
                m(f1, c1) = vi + (i - 1) * r
            Next
        Next
    End Sub

    Public Sub Cargar_Random(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim fi, ci As Integer
        f = nf : c = nc
        For fi = 1 To f
            For ci = 1 To c
                m(fi, ci) = a + Rnd() * (b - a)
            Next
        Next
    End Sub

    Public Sub Cargar_Manual()
        Dim nf, nc As Integer
        nf = InputBox(" Número de Filas: ")
        nc = InputBox(" Número de Columnas: ")
        f = nf : c = nc
        For fi = 1 To f
            For ci = 1 To c
                m(fi, ci) = InputBox(" Insertar Elemento: ")
            Next
        Next
    End Sub

    Public Function Descargar() As String
        Dim f1, c1 As Integer
        Dim result As String = ""
        For f1 = 1 To f
            For c1 = 1 To c
                result = result + Str(m(f1, c1)) + ";"
            Next
            result = result + Chr(13) + Chr(10)
        Next
        Return result
    End Function

    ' 1. Con elementos primos de la matriz acumular F= - √1 + - √11 − √5 + √3 
    ' Ojo: Analizar la secuencia de los elementos de la matriz. Por filas del extremo inferior derecho.

    Public Function Ejercicio_1() As String
        Dim result As String = " F = "
        Dim n1 As NEnt = New NEnt()
        Dim b As Boolean = True
        For fi = f To 1 Step -1
            For ci = c To 1 Step -1
                n1.Cargar(m(fi, ci))
                If b = True Then
                    If n1.Verificar_Primo() Then
                        result = result + " - " + "√" + Str(m(fi, ci))
                        b = Not b
                    End If
                Else
                    If n1.Verificar_Primo() Then
                        result = result + " + " + "√" + Str(m(fi, ci))
                        b = Not b
                    End If
                End If
            Next
        Next
        Return result
    End Function

    ' 2. Contar elementos que no se repiten (únicos)

    Public Function Ejercicio_2() As Integer
        Dim contador As Integer = 0
        For fi = 1 To f
            For ci = 1 To c
                If Frecuencia(m(fi, ci)) = 1 Then
                    contador = contador + 1
                End If
            Next
        Next
        Return contador
    End Function

    Public Function Frecuencia(elemento As Integer) As Integer
        Dim frec As Integer = 0
        For fi = 1 To f
            For ci = 1 To c
                If elemento = m(fi, ci) Then
                    frec = frec + 1
                End If
            Next
        Next
        Return frec
    End Function

    ' 3. Contar elementos primos por cada fila y el resultado debe estar en la última columna.

    Public Sub Ejercicio_3()
        For fi = 1 To f
            m(fi, c + 1) = Contar_Elementos_Primos_Fila(fi)
        Next
        c = c + 1
    End Sub

    Public Function Contar_Elementos_Primos_Fila(nf As Integer) As Integer
        Dim contador As Integer = 0
        Dim n1 As NEnt = New NEnt()
        For ci = 1 To c
            n1.Cargar(m(nf, ci))
            If n1.Verificar_Primo() Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function

    ' 4. Para todas las filas, encontrar el elemento de mayor frecuencia y colocarlas en la última columna:

    Public Sub Ejercicio_4()
        For fi = 1 To f
            m(fi, c + 1) = Elemento_Mayor_Frecuencia_Filas(fi)
        Next
        c = c + 1
    End Sub

    Public Function Frecuencia_Fila(elemento As Integer, nf As Integer) As Integer
        Dim frec As Integer = 0
        For ci = 1 To c
            If elemento = m(nf, ci) Then
                frec = frec + 1
            End If
        Next
        Return frec
    End Function

    Public Function Elemento_Mayor_Frecuencia_Filas(nf As Integer) As Integer
        Dim elemento As Integer = m(nf, 1)
        Dim frec As Integer = 1
        For ci = 1 To c
            If Frecuencia_Fila(m(nf, ci), nf) > frec Then
                frec = Frecuencia_Fila(m(nf, ci), nf)
                elemento = m(nf, ci)
            End If
        Next
        Return elemento
    End Function

    Public Function Elemento_Mayor_Fila(nf As Integer) As Integer
        Dim mayor As Integer = m(nf, 1)
        For ci = 1 To c
            If m(nf, ci) > mayor Then
                mayor = m(nf, ci)
            End If
        Next
        Return mayor
    End Function

    ' 5. Segmentar las filas de la matriz en pares e impares ordenados
    Public Sub Ejercicio_5()
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        For fi = 1 To f
            For ci = 1 To c
                For c1 = ci + 1 To c
                    n1.Cargar(m(fi, c1))
                    n2.Cargar(m(fi, ci))
                    If n1.Verificar_Par() And n2.Verificar_Impar() Or
                        n1.Verificar_Par() And n2.Verificar_Par() And m(fi, ci) > m(fi, c1) Or
                        n1.Verificar_Impar() And n2.Verificar_Impar() And m(fi, ci) > m(fi, c1) Then
                        Intercambiar(fi, c1, fi, ci)
                    End If
                Next
            Next
        Next
    End Sub

    Public Sub Intercambiar(f1 As Integer, c1 As Integer, f2 As Integer, c2 As Integer)
        Dim aux As Integer
        aux = m(f1, c1)
        m(f1, c1) = m(f2, c2)
        m(f2, c2) = aux
    End Sub

    ' 6. Ordenar una fila de la matriz donde los elementos restantes de la columna 
    ' se muevan en función al elemento ordenado

    Public Sub Ejercicio_6(nf As Integer)
        For ci = 1 To c - 1
            For cj = ci + 1 To c
                If m(nf, ci) > m(nf, cj) Then
                    Intercambiar_Columnas(ci, cj)
                End If
            Next
        Next
    End Sub

    Public Sub Intercambiar_Columnas(c1 As Integer, c2 As Integer)
        For fi = 1 To f
            Intercambiar(fi, c1, fi, c2)
        Next
    End Sub

    ' 7. Verificar si todas las columnas están ordenadas. Según secuencia..(DE ABAJO - ARRIBA)

    Public Function Ejercicio_7() As Boolean
        Dim b As Boolean = True
        Dim fi, ci, elemento As Integer
        elemento = m(f, c) - 1 : fi = f
        While (fi >= 1) And (b = True)
            ci = c
            While (ci >= 1) And (b = True)
                If elemento <= m(fi, ci) Then
                    elemento = m(fi, ci)
                Else
                    b = False
                End If
                ci = ci - 1
            End While
            fi = fi - 1
        End While
        Return b
    End Function

    ' 8. Verificar si la matriz esta ordenada según el ejemplo por filas. (EXTREMO INFERIOR IZQUIERDO)

    Public Function Ejercicio_8() As Boolean
        Dim b As Boolean = True
        Dim fi, ci, elemento As Integer
        elemento = m(f, 1) : fi = f
        While (fi >= 1) And (b = True)
            ci = 1
            While (ci <= c) And (b = True)
                If elemento <= m(fi, ci) Then
                    elemento = m(fi, ci)
                Else
                    b = False
                End If
                ci = ci + 1
            End While
            fi = fi - 1
        End While
        Return b
    End Function

    ' 9. Verificar si una matriz está incluida en otro (Si todos los elementos de la 1ra matriz están en la 2da matriz)

    Public Function Ejercicio_9(m2 As Matriz) As Boolean
        Dim b As Boolean = True
        Dim fi, ci As Integer
        fi = 1
        While (fi <= f) And (b = True)
            ci = 1
            While (ci <= c) And (b = True)
                If Not m2.Existe_Elemento(m(fi, ci)) Then
                    b = False
                End If
                ci = ci + 1
            End While
            fi = fi + 1
        End While
        Return b
    End Function

    Public Function Existe_Elemento(elemento As Integer) As Boolean
        Dim fi, ci As Integer
        Dim b As Boolean = False
        fi = 1
        While (fi <= f) And (b = False)
            ci = 1
            While (ci <= c) And (b = False)
                If m(fi, ci) = elemento Then
                    b = True
                End If
                ci = ci + 1
            End While
            fi = fi + 1
        End While
        Return b
    End Function

    ' 10. Ordenar las filas por el número de elementos primos.

    Public Sub Ejercicio_10()
        For f1 = 1 To f - 1
            For f2 = f1 + 1 To f
                If Cantidad_Primos_Fila(f1) > Cantidad_Primos_Fila(f2) Then
                    Intercambiar_Filas(f1, f2)
                End If
            Next
        Next
    End Sub

    Public Function Cantidad_Primos_Fila(nf As Integer) As Integer
        Dim contador As Integer = 0
        Dim num As NEnt = New NEnt()
        For ci = 1 To c
            num.Cargar(m(nf, ci))
            If num.Verificar_Primo() Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function

    Public Sub Intercambiar_Filas(f1 As Integer, f2 As Integer)
        For ci = 1 To c
            Intercambiar(f1, ci, f2, ci)
        Next
    End Sub

    ' 11.- Ordenar la matriz por columnas (EXTREMO INFERIOR DERECHO)

    Public Sub Ejercicio_11()
        Dim i As Integer
        For cp = c To 1 Step -1
            For fp = f To 1 Step -1
                For cd = cp To 1 Step -1
                    If cd = cp Then
                        i = fp
                    Else
                        i = f
                    End If
                    For fd = i To 1 Step -1
                        If m(fp, cp) > m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    ' 12.- Segmentar la matriz en repetidos y no repetidos ordenados por filas (EXTREMO INFERIOR IZQUIERDO)

    Public Sub Ejercicio_12()
        Dim i As Integer
        For fp = f To 1 Step -1
            For cp = 1 To c
                For fd = fp To 1 Step -1
                    If fd = fp Then
                        i = cp
                    Else
                        i = 1
                    End If
                    For cd = i To c
                        If Frecuencia(m(fp, cp)) = 1 And Frecuencia(m(fd, cd)) > 1 Or
                            Frecuencia(m(fp, cp)) > 1 And Frecuencia(m(fd, cd)) > 1 And m(fp, cp) > m(fd, cd) Or
                            Frecuencia(m(fp, cp)) = 1 And Frecuencia(m(fd, cd)) = 1 And m(fp, cp) > m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    ' 13.- Intercalar elementos de la matriz en fibonacci y no Fibonacci ordenados por columnas (EXTREMO INFERIOR IZQUIERDO)

    Public Sub Ejercicio_13()
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        Dim i As Integer
        Dim b As Boolean = True
        For cp = 1 To c
            For fp = f To 1 Step -1
                If b = True Then
                    For cd = cp To f
                        If cd = cp Then
                            i = fp
                        Else
                            i = f
                        End If
                        For fd = i To 1 Step -1
                            n1.Cargar(m(fp, cp))
                            n2.Cargar(m(fd, cd))
                            If Not n1.Verificar_Pertenece_Fibonacci() And n2.Verificar_Pertenece_Fibonacci() Or
                            Not n1.Verificar_Pertenece_Fibonacci() And Not n2.Verificar_Pertenece_Fibonacci() And m(fp, cp) > m(fd, cd) Or
                            n1.Verificar_Pertenece_Fibonacci() And n2.Verificar_Pertenece_Fibonacci() And m(fp, cp) > m(fd, cd) Then
                                Intercambiar(fp, cp, fd, cd)
                            End If
                        Next
                    Next
                Else
                    For cd = cp To f
                        If cd = cp Then
                            i = fp
                        Else
                            i = f
                        End If
                        For fd = i To 1 Step -1
                            n1.Cargar(m(fp, cp))
                            n2.Cargar(m(fd, cd))
                            If n1.Verificar_Pertenece_Fibonacci() And Not n2.Verificar_Pertenece_Fibonacci() Or
                            n1.Verificar_Pertenece_Fibonacci() And n2.Verificar_Pertenece_Fibonacci() And m(fp, cp) > m(fd, cd) Or
                            Not n1.Verificar_Pertenece_Fibonacci() And Not n2.Verificar_Pertenece_Fibonacci() And m(fp, cp) > m(fd, cd) Then
                                Intercambiar(fp, cp, fd, cd)
                            End If
                        Next
                    Next
                End If
                b = Not b
            Next
        Next
    End Sub



    ' cristian miranda

    Public Function frecX(H As Integer) As Integer
        Dim frec As Integer = 0
        For i1 = 1 To f
            For j1 = 1 To c
                If m(i1, j1) = H Then
                    frec += 1
                End If
            Next
        Next
        Return frec
    End Function

    Public Sub ejer_1()
        Dim index, x1, pd As Integer
        pd = 0
        For i1 = 1 To c
            For j1 = f To 1 Step -1
                For i2 = i1 To c
                    If i1 = i2 Then
                        index = j1
                    Else
                        index = f
                    End If
                    For j2 = index To 1 Step -1
                        If (Frecuencia(m(j1, i1)) = 1 And Frecuencia(m(j2, i2)) > 1) Or
                            (Frecuencia(m(j1, i1)) > 1 And Frecuencia(m(j2, i2)) > 1 And m(j1, i1) > m(j2, i2)) Or
                            (Frecuencia(m(j1, i1)) = 1 And Frecuencia(m(j2, i2)) = 1 And m(j1, i1) > m(j2, i2)) Then
                            x1 = m(j1, i1)
                            m(j1, i1) = m(j2, i2)
                            m(j2, i2) = x1
                        End If
                    Next
                Next
            Next
        Next
    End Sub

End Class
