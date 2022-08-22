Public Class Vector
    ' ESTRUCTURA INICIAL DE LA CLASE

    ' Atributos
    Const MAX = 100
    Private v(MAX) As Integer
    Private n As Integer

    ' Constructor
    Public Sub vector()
        n = 0
    End Sub

    ' Metodos de Escribir y Obtener
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

    Public Sub Cargar_Fibonacci(n1 As Integer)
        Dim i, a, b, c As Integer
        n = n1 : a = -1 : b = 1
        For i = 1 To n
            c = a + b
            a = b
            b = c
            v(i) = c
        Next
    End Sub

    ' Intercambiar dos elementos de un vector
    Public Sub Intercambiar(a As Integer, b As Integer)
        Dim aux As Integer
        aux = v(a)
        v(a) = v(b)
        v(b) = aux
    End Sub

    ' Ordenar vector - Metodo Burbuja
    Public Sub Orden_Burbuja()
        Dim t, i As Integer
        For t = n To 2 Step -1
            For i = 1 To t - 1
                If v(i) > v(i + 1) Then
                    Intercambiar(i, i + 1)
                End If
            Next
        Next
    End Sub

    ' Invertir vector entre un segmeto de a y b
    Public Sub Invertir_Segmento(a As Integer, b As Integer)
        Dim d As Integer = b
        Dim i As Integer
        For i = a To (b / 2)
            Intercambiar(i, d)
            d = d - 1
        Next
    End Sub

    ' Invertir vector
    Public Sub Invertir()
        Dim d As Integer = n
        Dim i As Integer
        For i = 1 To (n / 2)
            Intercambiar(i, d)
            d = d - 1
        Next
    End Sub

    ' Buscar elemento en un vector
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

    ' Intersección entre dos vectores
    Public Sub Interseccion(v1 As Vector, v2 As Vector)
        Dim i As Integer
        For i = 1 To n
            If v1.Buscar_Elemento(v(i)) And (Not v2.Buscar_Elemento(v(i))) Then
                v2.n = v2.n + 1
                v2.v((v2.n)) = v(i)
            End If
        Next
    End Sub

    ' Insertar un elemento al final de un vector
    Public Sub Insertar_Elemento_Final(elemento As Integer)
        n = n + 1
        v(n) = elemento
    End Sub

    ' Reemplazar un elemento de una posición por otro
    Public Sub Reemplazar_Elemento(elemento As Integer, posicion As Integer)
        v(posicion) = elemento
    End Sub

    ' Insertar un elemento con una posicion
    Public Sub Insertar_Elemento_Posicion(elemento As Integer, posicion As Integer)
        n = n + 1
        For i = n To posicion + 1 Step -1
            v(i) = v(i - 1)
        Next
        v(posicion) = elemento
    End Sub

    ' Insertar un vector dentro de otro a partir de una posicion
    Public Sub Insertar_Vector_Posicion(v2 As Vector, posicion As Integer)
        Dim i As Integer = posicion
        Dim j As Integer
        For j = 1 To v2.n
            Insertar_Elemento_Posicion(v2.v(j), i)
            i = i + 1
        Next
    End Sub

    'Eliminar una posicion de un vector
    Public Sub Eliminar_Posicion(posicion As Integer)
        For i = posicion To n
            v(i) = v(i + 1)
        Next
        n = n - 1
    End Sub

    ' Eliminar los elementos de un segmento de un vector
    Public Sub Eliminar_Elementos(a As Integer, b As Integer)
        Dim j As Integer = 0
        For i = b + 1 To n
            v(a + j) = v(i)
            j = j + 1
        Next
        n = n - (b - a + 1)
    End Sub

    ' Eliminar un elemento en todo el vector
    Public Sub Eliminar_Elemento(elemento As Integer)
        Dim aux As Integer = n
        n = 0
        For i = 1 To aux
            If Not elemento = v(i) Then
                Insertar_Elemento_Final(v(i))
            End If
        Next
    End Sub

    ' Ordenar todos los elementos de un vector ascendentemente
    Public Sub Ordenar_Ascendentemente()
        For i = 1 To n
            For j = i + 1 To n
                If v(i) > v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    ' Ordenar todos los elementos de un vector descendentemente
    Public Sub Ordenar_Descendentemente()
        For i = 1 To n
            For j = i + 1 To n
                If v(i) < v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    ' Ordenar los elementos de un vector en un segmento entre a y b descendentemente
    Public Sub Ordenar_Segmento_Descendente(a As Integer, b As Integer)
        For i = a To b
            For j = i + 1 To b
                If v(i) < v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    ' Ordenar los elementos de un vector en un segmento entre a y b ascendentemente
    Public Sub Ordenar_Segmento_Ascendente(a As Integer, b As Integer)
        For i = a To b
            For j = i + 1 To b
                If v(i) > v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    ' Ordenar los elementos de un vector mitad ascendente y la otra mitad descendente
    Public Sub Ordenar_Ascendente_Descendente()
        Ordenar_Segmento_Ascendente(1, n / 2)
        Ordenar_Segmento_Descendente((n / 2) + 1, n)
    End Sub

    ' Tecnica de dispersion
    Public Sub Dispersion()
        Dim p1, p2 As Integer
        For i = 1 To Math.Sqrt(n)
            p1 = 1 + Rnd() * (n - 1)
            p2 = 1 + Rnd() * (n - 1)
            Intercambiar(p1, p2)
        Next
    End Sub

    ' Tecnica de purga
    Public Sub Purgar()
        Ordenar_Ascendentemente()
        Dim i, d, elemento As Integer
        i = 0 : d = 1
        While d <= n
            elemento = v(d)
            While (d <= n) And (elemento = v(d))
                d = d + 1
            End While
            i = i + 1
            v(i) = elemento
        End While
        n = i
    End Sub

    ' Tecnica de busqueda binaria
    Public Function Busqueda_Binaria(elemento As Integer) As Boolean
        Ordenar_Ascendentemente()
        Dim b As Boolean = False
        Dim m, i, d As Integer
        i = 1 : d = n
        While (b = False) And (i <= d)
            m = (i + d) / 2
            If elemento = v(m) Then
                b = True
            Else
                If elemento > v(m) Then
                    i = m + 1
                Else
                    d = m - 1
                End If
            End If
        End While
        Return b
    End Function

    ' Sacar el promedio de los elementos del vector
    Public Function Promedio() As Double
        Dim s As Integer = 0
        Dim p As Double = 0
        For i = 1 To n
            s = s + v(i)
        Next
        p = s / n
        Return p
    End Function

    ' Generar los primeros n numeros primos en un vector
    Public Sub Mostrar_Primos(numero As Integer)
        Dim i As Integer = 0
        n = 0
        Dim num As NEnt = New NEnt()
        Do
            i = i + 1
            num.Cargar(i)
            If num.Verificar_Primo() Then
                Insertar_Elemento_Final(i)
            End If
        Loop Until (n = numero)
    End Sub

    ' Frecuencia de un elemento
    Public Function Frecuencia(elemento As Integer) As Integer
        Dim frec As Integer = 0
        For i = 1 To n
            If elemento = v(i) Then
                frec = frec + 1
            End If
        Next
        Return frec
    End Function

    ' Frecuencia de un elemento entre el rango a y b
    Public Function Frecuencia_Con_Rango(elemento As Integer, a As Integer, b As Integer) As Integer
        Dim frec As Integer = 0
        For i = a To b
            If elemento = v(i) Then
                frec = frec + 1
            End If
        Next
        Return frec
    End Function

    ' Busqueda de un elemento en un vector
    Public Function Existe_Elemento(elemento As Integer) As Boolean
        Dim b As Boolean = False
        Dim i As Integer = 1
        While (i <= n) And (b = False)
            If v(i) = elemento Then
                b = True
            End If
            i = i + 1
        End While
        Return b
    End Function

    ' Verificar si un vector esta incluido en otro
    Public Function Verificar_Existe_Vector(v2 As Vector) As Boolean
        Dim b As Boolean = True
        Dim i As Integer = 1
        While (i <= n) And (b = True)
            If Existe_Elemento(v2.v(i)) Then
                i = i + 1
            Else
                b = False
            End If
        End While
        Return b
    End Function

    ' Contar elementos diferentes en un vector
    Public Function Contar_Elementos_Diferentes() As Integer
        Dim contador As Integer = 0
        Dim elemento As Integer
        Dim i As Integer = 1
        Ordenar_Ascendentemente()
        While i <= n
            elemento = v(i)
            While (i <= n) And (elemento = v(i))
                i = i + 1
            End While
            contador = contador + 1
        End While
        Return contador
    End Function

    ' Seleciconar elementos que pertenezcan a la serie fibonacci y mostrarlo descendentemente en otro vector
    Public Sub Selecionar_Fibonacci_Descendente(v2 As Vector)
        v2.n = 0
        Dim num As NEnt = New NEnt()
        For i = 1 To n
            num.Cargar(v(i))
            If num.Verificar_Pertenece_Fibonacci() Then
                v2.Insertar_Elemento_Final(v(i))
            End If
        Next
        v2.Ordenar_Descendentemente()
    End Sub

    ' Solo con dos elementos multiplos de m, ordenar de forma ascendente
    Public Sub Ordenar_Multiplos_Ascendente(m As Integer)
        For i = 1 To (n / m) - 1
            For j = i + 1 To (n / m)
                If v(i * m) > v(j * m) Then
                    Intercambiar(i * m, j * m)
                End If
            Next
        Next
    End Sub

    ' Mostrar el elemento mas repetido en el segmento entre a y b
    Public Function Elemento_Mas_Repetido_Seg(a As Integer, b As Integer) As Integer
        Dim i As Integer = a
        Dim frec As Integer = Frecuencia(v(i))
        Dim elemento As Integer = v(i)
        For i = a To b
            If Frecuencia(v(i)) > frec Then
                frec = Frecuencia(v(i))
                elemento = v(i)
            End If
        Next
        Return elemento
    End Function

    ' Encontrar la frecuencia de distribucion de elementos repetidos del segmento entre a y b
    Public Sub Frecuencia_Distribucion_Repetidos(a As Integer, b As Integer, v1 As Vector, v2 As Vector)
        Ordenar_Segmento_Ascendente(a, b)
        v1.n = 0 : v2.n = 0
        Dim i As Integer = a
        Dim elemento, frec As Integer
        While i <= b
            elemento = v(i)
            frec = 0
            While (i <= b) And (elemento = v(i))
                frec = frec + 1
                i = i + 1
            End While
            v1.Insertar_Elemento_Final(elemento)
            v2.Insertar_Elemento_Final(frec)
        End While
    End Sub

    ' Encontrar la frecuencia de distribucion en rango r del segmento entre a y b
    Public Sub Frecuencia_Distribucion_Rango(r As Integer, a As Integer, b As Integer, v1 As Vector, v2 As Vector, v3 As Vector)
        Ordenar_Segmento_Ascendente(a, b)
        v1.n = 0 : v2.n = 0 : v3.n = 0
        Dim vi, vf, i, frec As Integer
        i = a
        While i <= b
            vi = (v(i) \ r) * r
            vf = vi + r - 1
            frec = 0
            While (i <= b) And (v(i) >= vi) And (v(i) <= vf)
                frec = frec + 1
                i = i + 1
            End While
            v1.Insertar_Elemento_Final(vi)
            v2.Insertar_Elemento_Final(vf)
            v3.Insertar_Elemento_Final(frec)
        End While
    End Sub

    ' Segmentar un vector en pares e impares ordenados
    Public Sub Segmentar_Par_Impar()
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        For p = 1 To n
            For d = p + 1 To n
                n1.Cargar(v(d))
                n2.Cargar(v(p))
                If n1.Verificar_Par() And n2.Verificar_Impar() Or
                        n1.Verificar_Par() And n2.Verificar_Par() And v(p) > v(d) Or
                        n1.Verificar_Impar() And n2.Verificar_Impar() And v(p) > v(d) Then
                    Intercambiar(p, d)
                End If
            Next
        Next
    End Sub

    ' Segmentar un vector en un segmento entre a y b en no repetidos y repetidos ordenados
    ' ascendentemente del menos repetido al mas repetido
    Public Sub Segmentar_NoRepetido_Repetido(a As Integer, b As Integer)
        Dim i, j As Integer
        For i = a To b
            For j = i + 1 To b
                If Frecuencia(v(i)) > Frecuencia(v(j)) Or
                   Frecuencia(v(i)) = Frecuencia(v(j)) And v(i) < v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    ' Intercalar un vector en primos y no primos ordenados descendentemente
    Public Sub Intercalar_Primos_NoPrimos_Desc()
        Dim i, j As Integer
        Dim bandera As Boolean = True
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        For i = 1 To n
            If bandera = True Then
                For j = i + 1 To n
                    n1.Cargar(v(j))
                    n2.Cargar(v(i))
                    If n1.Verificar_Primo() And Not n2.Verificar_Primo() Or
                            n1.Verificar_Primo() And n2.Verificar_Primo() And v(i) < v(j) Or
                            Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And v(i) < v(j) Then
                        Intercambiar(i, j)
                    End If
                Next
            Else
                For j = i + 1 To n
                    n1.Cargar(v(j))
                    n2.Cargar(v(i))
                    If Not n1.Verificar_Primo() And n2.Verificar_Primo() Or
                            Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And v(i) < v(j) Or
                             n1.Verificar_Primo() And n2.Verificar_Primo() And v(i) < v(j) Then
                        Intercambiar(i, j)
                    End If
                Next
            End If
            bandera = Not bandera
        Next
    End Sub

    ' Intercalar un vector en un segmento entre a y b en multiplos y no multiplos de m
    ' ordenados ascendentemente
    Public Sub Intercalar_Multiplo_NoMultiplo(m As Integer, a As Integer, b As Integer)
        Dim i, j As Integer
        Dim bandera As Boolean = True
        For i = a To b
            If bandera = True Then
                For j = i + 1 To b
                    If (v(j) Mod m = 0) And (v(i) Mod m <> 0) Or
                        (v(j) Mod m = 0) And (v(i) Mod m = 0) And (v(i) > v(j)) Or
                        (v(j) Mod m <> 0) And (v(i) Mod m <> 0) And (v(i) > v(j)) Then
                        Intercambiar(i, j)
                    End If
                Next
            Else
                For j = i + 1 To b
                    If (v(j) Mod m <> 0) And (v(i) Mod m = 0) Or
                        (v(j) Mod m <> 0) And (v(i) Mod m <> 0) And (v(i) > v(j)) Or
                        (v(j) Mod m = 0) And (v(i) Mod m = 0) And (v(i) > v(j)) Then
                        Intercambiar(i, j)
                    End If
                Next
            End If
            bandera = Not bandera
        Next
    End Sub

    ' EXAMEN DE VECTORES
    ' Encontrar la diferencia simetrica de elementos (1ra Preg. Exam. Vectores)
    Public Sub Diferencia_Simetrica(v1 As Vector, v2 As Vector)
        Dim i As Integer
        For i = 1 To n
            If Not v1.Buscar_Elemento(v(i)) And (Not v2.Buscar_Elemento(v(i))) Then
                v2.n = v2.n + 1
                v2.v(v2.n) = v(i)
            End If
        Next

        For i = 1 To v1.n
            If Not Buscar_Elemento(v1.v(i)) And (Not v2.Buscar_Elemento(v1.v(i))) Then
                v2.n = v2.n + 1
                v2.v(v2.n) = v1.v(i)
            End If
        Next
    End Sub

    ' Purgar elementos entre el rango a y b (2da Preg. Exam. Vectores)
    Public Sub Purgar_Con_Rango(a As Integer, b As Integer, r As Vector)
        Dim elemento As Integer
        Dim contador As Integer = 0
        Ordenar_Segmento_Descendente(a, b)
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

    ' Eliminar elementos repetidos continuos. (1er Preg. Exam. Rep. Vectores)
    Public Sub Respuesta_1()
        'Ordenar_Ascendentemente()
        Dim i, d, elemento As Integer
        i = 0 : d = 1
        While d <= n
            elemento = v(d)
            While (d <= n) And (elemento = v(d))
                d = d + 1
            End While
            i = i + 1
            v(i) = elemento
        End While
        n = i
    End Sub

    ' Encontrar el elemento de mayor frecuencia del rango a y b, elemento y frecuencia.
    Public Function Respuesta_2(a As Integer, b As Integer) As String
        Dim i As Integer = a
        Dim frec As Integer = Frecuencia_Con_Rango(v(i), a, b)
        Dim elemento As Integer = v(i)
        Dim resultado As String = " Resultado = "
        For i = a To b
            If Frecuencia_Con_Rango(v(i), a, b) > frec Then
                frec = Frecuencia_Con_Rango(v(i), a, b)
                elemento = v(i)
            End If
        Next
        resultado = resultado + Str(elemento) + "; " + Str(frec)
        Return resultado
    End Function

    ' PRACTICO 1 VECTORES
    ' 1. Cargar ne elementos el vector con la fórmula: b^0 ; b^1 ; b^2;…
    Public Sub Ejercicio_1(ne As Integer, b As Integer)
        Dim i, result, exp, vi, r As Integer
        n = ne : vi = 0 : r = 1
        For i = 1 To n
            exp = vi + (i - 1) * r
            result = b ^ exp
            v(i) = result
        Next
    End Sub

    ' 2. Contar elementos que se encuentren en posiciones que sean sus submúltiplos
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

    ' 3. Buscar el elemento mayor de las posiciones múltiplos de m
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

    ' 4. Separar los elementos primos y no primos.
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

    ' 5. Invertir los elementos del vector sin usar objeto vector auxiliar.
    Public Sub Ejercicio_5()
        Dim d As Integer = n
        Dim i As Integer
        For i = 1 To (n / 2)
            Intercambiar(i, d)
            d = d - 1
        Next
    End Sub

    ' 6. Verificar si todo los elementos son primos.
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

    ' 7. Encontrar la intersección de elementos (Teoría de conjuntos, donde cada vector es un conjunto)
    Public Sub Ejercicio_7(v1 As Vector, v2 As Vector)
        Dim i As Integer
        For i = 1 To n
            If v1.Buscar_Elemento(v(i)) And (Not v2.Buscar_Elemento(v(i))) Then
                v2.n = v2.n + 1
                v2.v(v2.n) = v(i)
            End If
        Next
    End Sub

    ' 8. Encontrar la unión de elementos (Teoría de conjuntos, donde cada vector es un conjunto)
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

    ' 9. Verificar si el segmento a y b esta ordenado
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

    ' 10. Verificar si TODOS LOS ELEMENTOS DEL segmento a y b son capicuas
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

    ' PRACTICO 2 VECTORES
    ' 1. Insertar un objeto Vector (Y) en otro a partir de una posición p.
    Public Sub Ejercicio_11(v2 As Vector, posicion As Integer)
        Dim i, j As Integer
        i = posicion
        For j = 1 To v2.n
            Insertar_Elemento_Posicion(v2.v(j), i)
            i = i + 1
        Next
    End Sub

    ' 2. Eliminar los elementos entre las posiciones a y b
    Public Sub Ejercicio_12(a As Integer, b As Integer)
        Dim j As Integer = 0
        For i = b + 1 To n
            v(a + j) = v(i)
            j = j + 1
        Next
        n = n - (b - a + 1)
    End Sub

    ' 3. Ordenar elementos de un segmento del vector (entre a y b) por la técnica burbuja.
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

    ' 4. Contar elementos diferentes entre el rango a y b
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

    ' 5. Purgar elementos entre el rango a y b
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

    ' 6. Encontrar la frecuencia de distribución de elementos del segmento entre a y b
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

    ' 7. Encontrar el elemento menos repetido en el segmento a y b
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

    ' 8. Segmentar el Vector primos y no primos ordenados ascendentemente en el segmento a y b.
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

    ' 9. Segmentar el Vector en repetidos y no repetidos ordenados
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

    ' 10. Intercalar primos y no primos ordenados y mientras sea posible en el rango a y b
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
