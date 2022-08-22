Public Class Matriz

    ' Atributos
    Const MAXF = 100
    Const MAXC = 100
    Private m(MAXF, MAXC) As Integer
    Private f, c As Integer

    ' Constructor
    Public Sub Matriz()
        f = 0
        c = 0
    End Sub

    ' Metodos de Escritura y Obtención de datos
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

    ' Busqueda de un elemento en una matriz
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

    Public Function Existe_Elemento_Columna(elemento As Integer) As Boolean
        Dim fi, ci As Integer
        Dim b As Boolean = False
        ci = 1
        While (ci <= c) And (b = False)
            fi = f
            While (fi >= 1) And (b = False)
                If m(fi, ci) = elemento Then
                    b = True
                End If
                fi = fi - 1
            End While
            ci = ci + 1
        End While
        Return b
    End Function

    ' Intercambiar 2 posiciones de la matriz
    Public Sub Intercambiar(f1 As Integer, c1 As Integer, f2 As Integer, c2 As Integer)
        Dim aux As Integer
        aux = m(f1, c1)
        m(f1, c1) = m(f2, c2)
        m(f2, c2) = aux
    End Sub

    ' Insertar Fila a la matriz al final
    Public Sub Insertar_Fila()
        For ci = 1 To c
            m(f + 1, ci) = InputBox(" Insertar Elemento: ")
        Next
        f = f + 1
    End Sub

    ' Insertar Columna a la matriz al final
    Public Sub Insertar_Columna()
        For fi = 1 To f
            m(fi, c + 1) = InputBox(" Insertar Elemento: ")
        Next
        c = c + 1
    End Sub

    ' Insertar Fila a la matriz en una determinada posición
    Public Sub Insertar_Fila_Determinada(nf As Integer)
        f = f + 1
        For fi = f To nf + 1
            For ci = 1 To c
                m(fi, ci) = m(fi - 1, ci)
            Next
        Next
        For ci = 1 To c
            m(nf, ci) = InputBox(" Insertar Elemento: ")
        Next
    End Sub

    ' Insertar Columna a la matriz en una determinada posición
    Public Sub Insertar_Columna_Determinada(nc As Integer)
        c = c + 1
        For ci = c To nc + 1
            For fi = 1 To f
                m(fi, ci) = m(fi, ci - 1)
            Next
        Next
        For fi = 1 To f
            m(fi, nc) = InputBox(" Insertar Elemento: ")
        Next
    End Sub

    ' Eliminar una determina fila
    Public Sub Eliminar_Fila_Determinada(nf As Integer)
        For fi = nf To f
            For ci = 1 To c
                m(fi, ci) = m(fi + 1, ci)
            Next
        Next
        f = f - 1
    End Sub

    ' Eliminar una determina Columna
    Public Sub Eliminar_Columna_Determinada(nc As Integer)
        For ci = nc To c
            For fi = 1 To f
                m(fi, ci) = m(fi, ci + 1)
            Next
        Next
        c = c - 1
    End Sub

    ' Copiar una Matriz
    Public Sub Copiar_Matriz(m2 As Matriz)
        For fi = 1 To f
            For ci = 1 To c
                m2.m(fi, ci) = m(fi, ci)
            Next
        Next
        m2.f = f
        m2.c = c
    End Sub

    ' TECNICAS

    ' Ordenar solo la diagonal principal
    Public Sub Ordenar_Diagonal_Principal()
        For d = 1 To f - 1
            For di = d + 1 To f
                If m(d, d) > m(di, di) Then
                    Intercambiar(d, d, di, di)
                End If
            Next
        Next
    End Sub

    ' Ordenar solo la diagonal Secundaria
    Public Sub Ordenar_Diagonal_Secundaria()
        Dim f1, f2 As Integer
        For c1 = 1 To c - 1
            For c2 = c1 + 1 To c
                f1 = f - c1 + 1
                f2 = f - c2 + 1
                If m(f1, c1) < m(f2, c2) Then
                    Intercambiar(f1, c1, f2, c2)
                End If
            Next
        Next
    End Sub

    ' Ordenar solo las columnas descendentemente
    Public Sub Ordenar_Columnas_Desc()
        For ci = 1 To c
            For f1 = 1 To f - 1
                For f2 = f1 + 1 To f
                    If m(f1, ci) < m(f2, ci) Then
                        Intercambiar(f1, ci, f2, ci)
                    End If
                Next
            Next
        Next
    End Sub

    ' Ordenar solo las columnas ascendentemente
    Public Sub Ordenar_Columnas_Asc()
        For ci = 1 To c
            For f1 = 1 To f - 1
                For f2 = f1 + 1 To f
                    If m(f1, ci) > m(f2, ci) Then
                        Intercambiar(f1, ci, f2, ci)
                    End If
                Next
            Next
        Next
    End Sub

    ' Ordenar solo las filas ascendentemente
    Public Sub Ordenar_Filas_Asc()
        For fi = 1 To f
            For c1 = 1 To c
                For c2 = c1 + 1 To c
                    If m(fi, c1) > m(fi, c2) Then
                        Intercambiar(fi, c1, fi, c2)
                    End If
                Next
            Next
        Next
    End Sub

    ' Ordenar solo las filas Descendentemente
    Public Sub Ordenar_Filas_Desc()
        For fi = 1 To f
            For c1 = 1 To c
                For c2 = c1 + 1 To c
                    If m(fi, c1) < m(fi, c2) Then
                        Intercambiar(fi, c1, fi, c2)
                    End If
                Next
            Next
        Next
    End Sub

    ' Ordenar toda la matriz ascendentemente
    Public Sub Ordenar_Asc()
        Dim i As Integer
        For fp = 1 To f
            For cp = 1 To c
                For fd = fp To f
                    If fd = fp Then
                        i = cp
                    Else
                        i = 1
                    End If
                    For cd = i To c
                        If m(fp, cp) > m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    ' Ordenar toda la matriz Descendentemente
    Public Sub Ordenar_Desc()
        Dim i As Integer
        For fp = 1 To f
            For cp = 1 To c
                For fd = fp To f
                    If fd = fp Then
                        i = cp
                    Else
                        i = 1
                    End If
                    For cd = i To c
                        If m(fp, cp) < m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    ' Tecnica de dispersión
    Public Sub Dispersion()
        Dim f1, c1, f2, c2 As Integer
        Dim fi, ci As Integer
        For fi = 1 To Math.Sqrt(f)
            For ci = 1 To Math.Sqrt(c)
                f1 = 1 + Rnd() * (f - 1)
                c1 = 1 + Rnd() * (c - 1)
                f2 = 1 + Rnd() * (f - 1)
                c2 = 1 + Rnd() * (c - 1)
                Intercambiar(f1, c1, f2, c2)
            Next
        Next
    End Sub

    ' Frecuencia de un elemento
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

    ' Calculos con elementos de la matriz

    ' Suma los elementos primos y multiplica por la constante ingresada
    Public Function Suma_Primo_Const(constante As Integer) As Double
        Dim num As NEnt = New NEnt()
        Dim result As Double = 0
        For fi = 1 To f
            For ci = 1 To c
                num.Cargar(m(fi, ci))
                If num.Verificar_Primo() Then
                    result = result + (m(fi, ci) * constante)
                End If
            Next
        Next
        Return result
    End Function

    ' Mostrar posición del elemento mayor de la matriz
    Public Function Posicion_Elemento_Mayor() As String
        Dim result As String = " "
        Dim elemento, fm, cm As Integer
        elemento = m(1, 1) : fm = 1 : cm = 1
        For fi = 1 To f
            For ci = 1 To c
                If m(fi, ci) > elemento Then
                    elemento = m(fi, ci)
                    fm = fi
                    cm = ci
                End If
            Next
        Next
        Return (" Fila = " + Str(fm) + Chr(13) + Chr(10) + " Columna = " + Str(cm))
    End Function

    ' Mostrar el elemento mas repetido de toda la matriz
    Public Function Elemento_Mas_Repetido() As Integer
        Dim elemento As Integer = m(1, 1)
        Dim frec As Integer = Frecuencia(m(1, 1))
        For fi = 1 To f
            For ci = 1 To c
                If Frecuencia(m(fi, ci)) > frec Then
                    frec = Frecuencia(m(fi, ci))
                    elemento = m(fi, ci)
                End If
            Next
        Next
        Return elemento
    End Function

    ' Mostrar el elemento menos repetido de toda la matriz
    Public Function Elemento_Menos_Repetido() As Integer
        Dim elemento As Integer = m(1, 1)
        Dim frec As Integer = Frecuencia(m(1, 1))
        For fi = 1 To f
            For ci = 1 To c
                If Frecuencia(m(fi, ci)) < frec Then
                    frec = Frecuencia(m(fi, ci))
                    elemento = m(fi, ci)
                End If
            Next
        Next
        Return elemento
    End Function

    ' Verificar si una matriz esta ordenada descendentemente (Sin rigor = con elementos repetidos)
    Public Function Verificar_Orden_Desc_Sr() As Boolean
        Dim b As Boolean = True
        Dim fi, ci, elemento As Integer
        elemento = m(1, 1) + 1 : fi = 1
        While (fi <= f) And (b = True)
            ci = 1
            While (ci <= c) And (b = True)
                If elemento >= m(fi, ci) Then
                    elemento = m(fi, ci)
                Else
                    b = False
                End If
                ci = ci + 1
            End While
            fi = fi + 1
        End While
        Return b
    End Function

    ' Contar elementos diferentes de toda la matriz
    Public Function Cantidad_Elementos_Diferentes() As Integer
        Dim vec As Vector = New Vector()
        For fi = 1 To f
            For ci = 1 To c
                vec.Insertar_Elemento_Final(m(fi, ci))
            Next
        Next
        Return vec.Contar_Elementos_Diferentes()
    End Function

    ' Verificar si una matriz esta dentro de otra matriz. 
    Public Function Verificar_Existe_Matriz(m2 As Matriz) As Boolean
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

    ' Frecuencia de un elemento en un segmento
    Public Function Frecuencia_Segmento(elemento As Integer, fi As Integer, ci As Integer, ff As Integer, cf As Integer) As Integer
        Dim frec As Integer = 0
        For i = fi To ff
            For ii = ci To cf
                If elemento = m(i, ii) Then
                    frec = frec + 1
                End If
            Next
        Next
        Return frec
    End Function

    ' Elemento mas repetido en un segmento
    Public Function Elemento_Mas_Repetdio_Segmento(fi As Integer, ci As Integer, ff As Integer, cf As Integer) As Integer
        Dim frec As Integer = Frecuencia_Segmento(m(f, c), fi, ci, ff, cf)
        Dim elemento As Integer = m(f, c)
        For i = fi To ff
            For ii = ci To cf
                If Frecuencia_Segmento(m(i, ii), fi, ci, ff, cf) > frec Then
                    frec = Frecuencia_Segmento(m(i, ii), fi, ci, ff, cf)
                    elemento = m(i, ii)
                End If
            Next
        Next
        Return elemento
    End Function

    ' Trabajando con triangulares

    ' Frecuencia de la triangular
    Public Function Frecuencia_Triangular_Superior(elemento As Integer) As Integer
        Dim frec As Integer = 0
        For fi = 1 To f
            For ci = fi To c
                If elemento = m(fi, ci) Then
                    frec = frec + 1
                End If
            Next
        Next
        Return frec
    End Function

    Public Function Frecuencia_Triangular_Inferior(elemento As Integer) As Integer
        Dim frec As Integer = 0
        For ci = 1 To c
            For fi = ci To f
                If elemento = m(fi, ci) Then
                    frec = frec + 1
                End If
            Next
        Next
        Return frec
    End Function

    ' Ordenar Ascendentemente la triangular de una matriz por su frecuencia
    Public Sub Ordenar_Triangular_Sup_Frec()
        Dim i As Integer
        For fp = 1 To f
            For cp = fp To c
                For fd = fp To f
                    If fd = fp Then
                        i = cp
                    Else
                        i = fd
                    End If
                    For cd = i To c
                        If Frecuencia_Triangular_Superior(m(fp, cp)) < Frecuencia_Triangular_Superior(m(fd, cd)) Or
                            Frecuencia_Triangular_Superior(m(fp, cp)) = Frecuencia_Triangular_Superior(m(fd, cd)) And m(fp, cp) > m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    Public Sub Ordenar_Triangular_Inf_Frec()        ' Observación
        Dim i As Integer
        For fp = 1 To f
            For cp = fp To c
                For fd = fp To f
                    If fd = fp Then
                        i = cp
                    Else
                        i = fd
                    End If
                    For cd = i To c
                        If Frecuencia_Triangular_Inferior(m(fp, cp)) < Frecuencia_Triangular_Inferior(m(fd, cd)) Or
                            Frecuencia_Triangular_Inferior(m(fp, cp)) = Frecuencia_Triangular_Inferior(m(fd, cd)) And m(fp, cp) > m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    ' Ordenar por columnas la triangular
    Public Sub Ordenar_Triangular_Sup_Columnas()
        Dim i As Integer
        For cp = 1 To c
            For fp = 1 To cp
                For cd = cp To c
                    If cd = cp Then
                        i = fp
                    Else
                        i = 1
                    End If
                    For fd = i To cd
                        If m(fp, cp) > m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    ' Cantidad de elementos diferentes de una fila
    Public Function Elementos_Diferentes_Fila(fila As Integer)
        Ordenar_Filas_Asc()
        Dim ce As Integer = 0
        Dim co As Integer = 1
        Dim elemento As Integer = m(fila, co)
        While co <= c
            elemento = m(fila, co)
            While (elemento = m(fila, co)) And (co <= c)
                co = co + 1
            End While
            ce = ce + 1
        End While
        Return ce
    End Function

    ' Cantidad de elementos diferentes de cada fila aumentando una columna al final de la matriz
    Public Sub Elementos_Diferentes_Final_Col()
        Dim copia As Matriz = New Matriz()
        Copiar_Matriz(copia)
        For fi = 1 To f
            m(fi, c + 1) = copia.Elementos_Diferentes_Fila(fi)
        Next
        c = c + 1
    End Sub

    ' Tecnicas de Segmentación

    ' Segmentar las filas de la matriz en pares e impares ambos ascendentemente
    Public Sub Segmentar_Filas_Par_Impar()
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

    ' Segmentar las columnas de la matriz en primos y no primos ambos ascendentemente
    Public Sub Segmentar_Columnas_Primo_NoPrimo()
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        For ci = 1 To c
            For fi = 1 To f
                For f1 = fi + 1 To f
                    n1.Cargar(m(f1, ci))
                    n2.Cargar(m(fi, ci))
                    If n1.Verificar_Primo() And Not n2.Verificar_Primo() Or
                        n1.Verificar_Primo() And n2.Verificar_Primo() And m(fi, ci) > m(f1, ci) Or
                        Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And m(fi, ci) > m(f1, ci) Then
                        Intercambiar(fi, ci, f1, ci)
                    End If
                Next
            Next
        Next
    End Sub

    ' Segmentar toda la matriz por su frecuencia descendentemente
    Public Sub Segmentar_Por_Frecuencia()
        Dim i As Integer
        For fp = 1 To f
            For cp = 1 To c
                For fd = fp To f
                    If fd = fp Then
                        i = cp
                    Else
                        i = 1
                    End If
                    For cd = i To c
                        If Frecuencia(m(fp, cp)) < Frecuencia(m(fd, cd)) Or
                            Frecuencia(m(fp, cp)) = Frecuencia(m(fd, cd)) And m(fp, cp) < m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    ' Tecnicas de intercalación

    ' Intercalar las columnas de la matriz en primos y no primos ambos ascendentemente
    Public Sub Intercalar_Columnas_Primo_NoPrimo()
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        Dim b As Boolean = True
        For ci = 1 To c
            For fi = 1 To f
                If b = True Then
                    For f1 = fi + 1 To f
                        n1.Cargar(m(f1, ci))
                        n2.Cargar(m(fi, ci))
                        If n1.Verificar_Primo() And Not n2.Verificar_Primo() Or
                            n1.Verificar_Primo() And n2.Verificar_Primo() And m(fi, ci) > m(f1, ci) Or
                            Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And m(fi, ci) > m(f1, ci) Then
                            Intercambiar(fi, ci, f1, ci)
                        End If
                    Next
                Else
                    For f1 = fi + 1 To f
                        n1.Cargar(m(f1, ci))
                        n2.Cargar(m(fi, ci))
                        If Not n1.Verificar_Primo() And n2.Verificar_Primo() Or
                            Not n1.Verificar_Primo() And Not n2.Verificar_Primo() And m(fi, ci) > m(f1, ci) Or
                            n1.Verificar_Primo() And n2.Verificar_Primo() And m(fi, ci) > m(f1, ci) Then
                            Intercambiar(fi, ci, f1, ci)
                        End If
                    Next
                End If
                b = Not b
            Next
        Next
    End Sub

    ' Intercalar las filas de una matriz en fibonacci y no fibonacci ascendentemente
    Public Sub Intercalar_Filas_Fibonacci_NoFibonacci()
        Dim n1 As NEnt = New NEnt()
        Dim n2 As NEnt = New NEnt()
        Dim b As Boolean = True
        For fi = 1 To f
            For ci = 1 To c
                If b = True Then
                    For c1 = ci + 1 To c
                        n1.Cargar(m(fi, c1))
                        n2.Cargar(m(fi, ci))
                        If n1.Verificar_Pertenece_Fibonacci() And Not n2.Verificar_Pertenece_Fibonacci() Or
                            n1.Verificar_Pertenece_Fibonacci() And n2.Verificar_Pertenece_Fibonacci() And m(fi, ci) > m(fi, c1) Or
                            Not n1.Verificar_Pertenece_Fibonacci() And Not n2.Verificar_Pertenece_Fibonacci() And m(fi, ci) > m(fi, c1) Then
                            Intercambiar(fi, c1, fi, ci)
                        End If
                    Next
                Else
                    For c1 = ci + 1 To c
                        n1.Cargar(m(fi, c1))
                        n2.Cargar(m(fi, ci))
                        If Not n1.Verificar_Pertenece_Fibonacci() And n2.Verificar_Pertenece_Fibonacci() Or
                            Not n1.Verificar_Pertenece_Fibonacci() And Not n2.Verificar_Pertenece_Fibonacci() And m(fi, ci) > m(fi, c1) Or
                            n1.Verificar_Pertenece_Fibonacci() And n2.Verificar_Pertenece_Fibonacci() And m(fi, ci) > m(fi, c1) Then
                            Intercambiar(fi, c1, fi, ci)
                        End If
                    Next
                End If
                b = Not b
            Next
        Next
    End Sub

    ' Intercalar toda la matriz en multiplos y no multiplos ingresando un número
    Public Sub Intercalar_Multiplos_NoMultiplos(mul As Integer)
        Dim i As Integer
        Dim b As Boolean = True
        For fp = 1 To f
            For cp = 1 To c
                If b = True Then
                    For fd = fp To f
                        If fd = fp Then
                            i = cp
                        Else
                            i = 1
                        End If
                        For cd = i To c
                            If (m(fd, cd) Mod mul = 0) And (m(fp, cp) Mod mul <> 0) Or
                            (m(fd, cd) Mod mul = 0) And (m(fp, cp) Mod mul = 0) And (m(fd, cd) < m(fp, cp)) Or
                            (m(fd, cd) Mod mul <> 0) And (m(fp, cp) Mod mul <> 0) And (m(fd, cd) < m(fp, cp)) Then
                                Intercambiar(fp, cp, fd, cd)
                            End If
                        Next
                    Next
                Else
                    For fd = fp To f
                        If fd = fp Then
                            i = cp
                        Else
                            i = 1
                        End If
                        For cd = i To c
                            If (m(fd, cd) Mod mul <> 0) And (m(fp, cp) Mod mul = 0) Or
                            (m(fd, cd) Mod mul <> 0) And (m(fp, cp) Mod mul <> 0) And (m(fd, cd) < m(fp, cp)) Or
                            (m(fd, cd) Mod mul = 0) And (m(fp, cp) Mod mul = 0) And (m(fd, cd) < m(fp, cp)) Then
                                Intercambiar(fp, cp, fd, cd)
                            End If
                        Next
                    Next
                End If
                b = Not b
            Next
        Next
    End Sub

    ' Aplicaciones aritmeticas con matrices

    ' Traspuesta de una matriz cuadrada
    Public Sub Traspuesta_Matriz_Cuadrada()
        For fi = 2 To f
            For ci = 1 To fi - 1
                Intercambiar(fi, ci, ci, fi)
            Next
        Next
    End Sub

    ' Traspuesta de una matriz no cuadrada
    Public Sub Traspuesta_Matriz_No_Cuadrada(m2 As Matriz)
        For fi = 1 To f
            For ci = 1 To c
                m2.m(ci, fi) = m(fi, ci)
            Next
        Next
        m2.f = c
        m2.c = f
    End Sub

    ' Determinante de una matriz 2x2
    Public Function Determinante_Matriz_2x2()
        Dim dp, ds, d1 As Integer
        dp = 1 : ds = 1 : d1 = c
        For di = 1 To f
            dp = dp * m(di, di)
            ds = ds * m(di, d1)
            d1 = d1 - 1
        Next
        Return (dp - ds)
    End Function

    ' Determinante de una matriz 3x3
    Public Function Determinante_Matriz_3x3()
        Dim dp, ds, dp1, ds1 As Integer
        dp = 0 : ds = 0
        For fi = 1 To 2
            Copiar_fila(fi, f + fi)
        Next
        For fi = 1 To f
            dp1 = 1 : ds1 = 1
            For ci = 1 To c
                ds1 = ds1 * m(f + fi - ci, ci)
                dp1 = dp1 * m(fi + ci - 1, ci)
            Next
            dp = dp + dp1
            ds = ds + ds1
        Next
        Return (dp - ds)
    End Function

    Public Sub Copiar_fila(f1 As Integer, f2 As Integer)
        For ci = 1 To c
            m(f2, ci) = m(f1, ci)
        Next
    End Sub

    ' Suma de 2 matrices
    Public Sub Suma_Matrices(m1 As Matriz, m2 As Matriz)
        Dim f1, c1 As Integer
        m2.f = 0 : m2.c = 0
        If (f = m1.f) And (c = m1.c) Then
            For f1 = 1 To f
                For c1 = 1 To c
                    m2.m(f1, c1) = m(f1, c1) + m1.m(f1, c1)
                Next
            Next
            m2.f = f
            m2.c = c
        Else
            MsgBox(" NO SE PUEDE REALIZAR ESTA OPERACIÓN. " + Chr(13) + Chr(10) +
                   " LAS MATRICES NO TIENEN LAS MISMAS DIMENSIONES. " + Chr(13) + Chr(10) + " LO SIENTO...!! ")
        End If
    End Sub

    ' Resta de 2 Matrices
    Public Sub Resta_Matrices(m1 As Matriz, m2 As Matriz)
        Dim f1, c1 As Integer
        m2.f = 0 : m2.c = 0
        If (f = m1.f) And (c = m1.c) Then
            For f1 = 1 To f
                For c1 = 1 To c
                    m2.m(f1, c1) = m(f1, c1) - m1.m(f1, c1)
                Next
            Next
            m2.f = f
            m2.c = c
        Else
            MsgBox(" NO SE PUEDE REALIZAR ESTA OPERACIÓN. " + Chr(13) + Chr(10) +
                   " LAS MATRICES NO TIENEN LAS MISMAS DIMENSIONES. " + Chr(13) + Chr(10) + " LO SIENTO...!! ")
        End If
    End Sub

    ' Multiplicación de 2 matrices
    Public Sub Multiplicacion_Matrices(m1 As Matriz, m2 As Matriz)
        Dim f1, c1 As Integer
        m2.f = 0 : m2.c = 0
        If (c = m1.f) Then
            For f1 = 1 To f
                For c1 = 1 To m1.c
                    m2.m(f1, c1) = 0
                    For i = 1 To c
                        m2.m(f1, c1) = m2.m(f1, c1) + m(f1, i) * m1.m(i, c1)
                    Next
                Next
            Next
            m2.f = f
            m2.c = m1.c
        Else
            MsgBox(" NO SE PUEDE REALIZAR ESTA OPERACIÓN. " + Chr(13) + Chr(10) +
                   " LAS MATRICES NO TIENEN LAS DIMENSIONES NECESARIAS. " + Chr(13) + Chr(10) + " LO SIENTO...!! ")
        End If
    End Sub

    ' División de una matriz por un escalar
    Public Sub Division_Escalar(num As Integer)
        For fi = 1 To f
            For ci = 1 To c
                m(fi, ci) = m(fi, ci) / num
            Next
        Next
    End Sub


    ' Ejercicio 12 del auxiliar

    Public Sub ejer_12()
        Dim index, x, pd As Integer
        pd = 0
        For i1 = f To 1 Step -1
            For j1 = 1 To c
                For i2 = i1 To 1 Step -1
                    If i1 = i2 Then
                        index = j1
                    Else
                        index = 1
                    End If
                    For j2 = index To c
                        If (Frecuencia(m(i1, j1)) = 1 And Frecuencia(m(i2, j2)) > 1) Or
                            (Frecuencia(m(i1, j1)) > 1 And Frecuencia(m(i2, j2)) > 1 And m(i1, j1) > m(i2, j2)) Or
                            (Frecuencia(m(i1, j1)) = 1 And Frecuencia(m(i2, j2)) = 1 And m(i1, j1) > m(i2, j2)) Then
                            x = m(i1, j1)
                            m(i1, j1) = m(i2, j2)
                            m(i2, j2) = x
                        End If
                    Next
                Next
            Next
        Next
    End Sub



End Class
