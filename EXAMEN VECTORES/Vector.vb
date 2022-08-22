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

    Public Sub Ordenar_Ascendentemente()
        For i = 1 To n
            For j = i + 1 To n
                If v(i) > v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    Public Sub Intercambiar(a As Integer, b As Integer)
        Dim aux As Integer
        aux = v(a)
        v(a) = v(b)
        v(b) = aux
    End Sub

    Public Sub Ordenar_Segmento_Descendente(a As Integer, b As Integer)
        For i = a To b
            For j = i + 1 To b
                If v(i) < v(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub

    Public Sub Respuesta_2(a As Integer, b As Integer, r As Vector)
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

    Public Sub Respuesta_1(v1 As Vector, v2 As Vector)
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

    Public Sub Respuesta_12()
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

    Public Sub Respuesta_1()
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

    Public Function Frecuencia_Con_Rango(elemento As Integer, a As Integer, b As Integer) As Integer
        Dim frec As Integer = 0
        For i = a To b
            If elemento = v(i) Then
                frec = frec + 1
            End If
        Next
        Return frec
    End Function




    ' Respuesta de otro compañero
    Public Function Existe_Continuo()
        For i = 1 To n
            If v(i) = v(i + 1) Then Return True
        Next
        Return False
    End Function

    Public Sub EliminarPos1(pos As Integer)
        For i = pos To n
            v(i) = v(i + 1)
        Next
        n -= 1
    End Sub

    Public Sub ElimCont()
        Dim i = 1
        While Existe_Continuo()
            If v(i) = v(i + 1) Then
                EliminarPos1(i)
                i = 1
            End If
            i += 1
        End While
    End Sub


    ' Respuesta de cristian miranda
    Public Sub eliminarPos(pos As Integer)
        Dim i As Integer
        For i = pos To n
            v(i) = v(i + 1)
        Next
        n = n - 1
    End Sub

    Public Sub ElimElemRep5()
        For i = 1 To n
            For j = i + 1 To n
                If v(i) = v(j) Then
                    eliminarPos(j)
                End If
            Next
        Next
    End Sub
End Class
