Public Class NEnt
    Private n As Integer

    Public Sub NEnt()
        n = 0
    End Sub

    Public Sub Cargar(dato As Integer)
        n = dato
    End Sub

    Public Function Descargar() As Integer
        Return n
    End Function

    Public Function VerificarPrimo() As Boolean
        Dim residuo, contador, i As Integer
        contador = 0
        For i = 1 To n
            residuo = n Mod i
            If residuo = 0 Then
                contador = contador + 1
            End If
        Next
        Return contador = 2
    End Function

    Public Function VerificarPerteneceFibonacci() As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1
        Do
            c = a + b
            a = b
            b = c
        Loop Until (n = c) Or (c > n)
        Return (n = c)
    End Function

    Public Function Invertir() As Integer
        Dim d, nu As Integer
        While n > 0
            d = n Mod 10
            n = n \ 10
            nu = nu * 10 + d
        End While
        Return nu
    End Function

    Public Function Factorial() As Double
        Dim i As Integer
        Dim f As Double
        If (n > 0) Then
            f = 1
            For i = n To 1 Step -1
                f = f * i
            Next
        Else
            f = 1
        End If
        Return f
    End Function

    Public Function SeRepite(n As Integer, d As Integer) As Boolean
        Dim c, da As Integer
        While n > 0
            da = n Mod 10
            n = n \ 10
            If (da = d) Then
                c = c + 1
            End If
        End While
        Return c > 1
    End Function

    Public Function Cantidad_SeRepiteDig(n As Integer, d As Integer) As Integer
        Dim c, da As Integer
        c = 0
        While n > 0
            da = n Mod 10
            n = n \ 10
            If (da = d) Then
                c = c + 1
            End If
        End While
        Return c
    End Function

    Public Function Ndigs() As Integer
        Dim nd As Integer
        nd = 0
        While n > 0
            n = n \ 10
            nd = nd + 1
        End While
        Return nd
    End Function

    Public Sub Unir2Numeros(nu As NEnt)
        n = n * 10 ^ nu.Ndigs() + nu.n
    End Sub

    Public Function Eliminar_Digito(nd As Integer, d As Integer) As Integer
        Dim r, da, m As Integer
        r = 0
        m = 0
        While n > 0
            da = n Mod 10 ^ nd
            If da <> d Then
                r = r + (da * 10 ^ m)
                m = m + nd
            End If
            n = n \ 10 ^ nd
        End While
        Return r
    End Function

    Public Sub EliminarDigito(nd As Integer, dig As Integer)
        Dim d, p As Integer
        Dim nu As NEnt
        Dim b As Boolean
        nu = New NEnt()
        b = True
        p = -1
        While n > 0 And b = True
            d = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If d <> dig Then
                p = p + 1
                nu.n = nu.n + d * 10 ^ p
            Else
                b = False
            End If
        End While
        Me.Unir2Numeros(nu)
    End Sub

    Public Function DigMenor(nd As Integer) As Integer
        Dim digito, menor, na As Integer
        na = n
        menor = na Mod 10 ^ nd : na = na \ 10 ^ nd
        While na > 0
            digito = na Mod 10 ^ nd
            If (digito < menor) Then
                menor = digito
            End If
            na = na \ 10 ^ nd
        End While
        Return menor
    End Function

    Public Function DigMayor(nd As Integer) As Integer
        Dim digito, mayor, na As Integer
        na = n
        mayor = na Mod 10 ^ nd : na = na \ 10 ^ nd
        While na > 0
            digito = na Mod 10 ^ nd
            If (digito > mayor) Then
                mayor = digito
            End If
            na = na \ 10 ^ nd
        End While
        Return mayor
    End Function

    Public Function VerificarPar() As Boolean
        Dim residuo As Integer
        residuo = n Mod 2
        Return residuo = 0
    End Function

    Public Function VerificarImpar() As Boolean
        Dim residuo As Integer
        residuo = n Mod 2
        Return residuo
    End Function

    Public Function Retornar_DigImpar(nd As Integer) As Integer
        Dim aux, result As Integer
        Dim b As Boolean
        Dim d As NEnt
        aux = n
        d = New NEnt()
        b = False
        While (n > 0) And (b = False)
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If Not d.VerificarPar() Then
                b = True
                result = d.n
            End If
        End While
        n = aux
        Return result
    End Function

    Public Function Retornar_DigPar(nd As Integer) As Integer
        Dim aux, result As Integer
        Dim b As Boolean
        Dim d As NEnt
        aux = n
        d = New NEnt()
        b = False
        While (n > 0) And (b = False)
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If d.VerificarPar() Then
                b = True
                result = d.n
            End If
        End While
        n = aux
        Return result
    End Function

    Public Function BuscarDigImpar(nd As Integer) As Boolean
        Dim b As Boolean
        Dim d As NEnt
        d = New NEnt()
        b = False
        While n > 0
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If Not d.VerificarPar() Then
                b = True
            End If
        End While
        Return b
    End Function

    Public Function BuscarDigPar(nd As Integer) As Boolean
        Dim b As Boolean
        Dim d As NEnt
        d = New NEnt()
        b = False
        While n > 0
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If d.VerificarPar() Then
                b = True
            End If
        End While
        Return b
    End Function

    Public Function Cant_Digs() As Integer
        Dim c, x As Integer
        c = 0 : x = n
        While x > 0
            c += 1
            x = x \ 10
        End While
        Return c
    End Function

    Public Function Frecuencia_dig(dig As Integer) As Integer
        Dim fd, d, na As Integer
        na = n
        While na > 0
            d = na Mod 10
            na = na \ 10
            If dig = d Then
                fd = fd + 1
            End If
        End While
        Return fd
    End Function

    Public Function Ejercicio_1() As String
        Dim digito As NEnt
        Dim a, b, c, aux As Integer
        Dim termino, result As String
        aux = n
        a = -1 : b = 1
        digito = New NEnt()
        result = " c = "
        While n > 0
            c = a + b
            a = b
            b = c
            digito.Cargar(c)
            If digito.VerificarPerteneceFibonacci() Then
                If Not digito.VerificarPar() Then
                    n -= 1
                    termino = Str(digito.n)
                    result = result + termino + ", "
                End If
            End If
        End While
        n = aux
        Return result
    End Function

    Public Function Ejercicio_2() As String
        Dim i, aux As Integer
        Dim termino, result As String
        Dim digito As NEnt
        aux = n
        digito = New NEnt()
        result = " c = "
        i = 1
        While n > 0
            digito.Cargar(i)
            If digito.VerificarPrimo() Then
                n -= 1
                termino = Str(digito.n)
                result = result + termino + ", "
            End If
            i += 1
        End While
        n = aux
        Return result
    End Function

    Public Function Ejercicio_3() As Integer
        Dim i, resultado, n2 As Integer
        Dim nentAux As NEnt
        nentAux = New NEnt()
        i = 1 : n2 = n
        While n2 > 0
            nentAux.Cargar(i)
            If Not nentAux.VerificarPrimo() Then
                n2 -= 1
            End If
            If n2 = 0 Then
                resultado = i
            End If
            i += 1
        End While
        Return resultado
    End Function

    Public Function Ejercicio_4(m As Integer) As String
        Dim resultado, termino, result As String
        Dim aux, termino1 As Integer
        Dim auxNent As NEnt
        termino1 = 0
        resultado = " S = "
        result = ""
        auxNent = New NEnt()
        aux = n
        While n > 0
            If m Mod n = 0 Then
                auxNent.Cargar(n)
                termino1 = termino1 + auxNent.Factorial()
                termino = Str(auxNent.n)
                resultado = resultado + termino + "! + "
                result = resultado + " = " + Str(termino1)
            End If
            n -= 1
        End While
        n = aux
        Return result
    End Function

    Public Function Ejercicio_5(vi As Integer, r As Integer) As Boolean
        Dim elemento, i, aux As Integer
        Dim resultado As Boolean
        aux = n
        resultado = False
        elemento = vi : i = 1
        While elemento <= n
            If elemento = n Then
                resultado = True
            End If
            i += 1
            elemento = vi + (i - 1) * r
        End While
        n = aux
        Return resultado
    End Function

    Public Function Ejercicio_6(nd As Integer) As String
        Dim result As String
        Dim auxNent As NEnt
        Dim invertido, digito As Integer
        result = " S = "
        auxNent = New NEnt()
        auxNent.Cargar(n)
        invertido = auxNent.Invertir()
        While invertido > 0
            digito = invertido Mod 10 ^ nd
            invertido = invertido \ 10 ^ nd
            auxNent.Cargar(digito)
            result = result + Str(auxNent.Invertir()) + ", "
        End While
        Return result
    End Function

    Public Function Ejercicio_7(n2 As NEnt) As Integer
        Dim mayor As Integer
        If (n < n2.n) Then
            mayor = n2.n
        Else
            mayor = n
        End If
        Return mayor
    End Function

    Public Function Ejercicio_8(n2 As NEnt, n3 As NEnt) As Integer
        Dim mayor As Integer
        If (n < n2.n) And (n < n3.n) Then
            If (n2.n < n3.n) Then
                mayor = n3.n
            Else
                mayor = n2.n
            End If
        Else
            If (n2.n < n) And (n2.n < n3.n) Then
                If (n < n3.n) Then
                    mayor = n3.n
                Else
                    mayor = n
                End If
            Else
                If (n3.n < n) And (n3.n < n2.n) Then
                    If (n < n2.n) Then
                        mayor = n2.n
                    Else
                        mayor = n
                    End If
                End If
            End If
        End If
        Return mayor
    End Function

    Public Function Ejercicio_9(n2 As NEnt, n3 As NEnt) As Integer
        Dim ordenMayor As Integer
        If (n < n2.n) And (n < n3.n) Then
            If (n2.n < n3.n) Then
                ordenMayor = 3
            Else
                ordenMayor = 2
            End If
        Else
            If (n2.n < n) And (n2.n < n3.n) Then
                If (n < n3.n) Then
                    ordenMayor = 3
                Else
                    ordenMayor = 1
                End If
            Else
                If (n3.n < n) And (n3.n < n2.n) Then
                    If (n < n2.n) Then
                        ordenMayor = 2
                    Else
                        ordenMayor = 1
                    End If
                End If
            End If
        End If
        Return ordenMayor
    End Function

    Public Function Ejercicio_10(base As Integer) As Integer
        Dim na, d, nn As Integer
        Dim resultado As Integer
        na = n
        While na > 0
            d = na Mod base
            na = na \ base
            nn = nn * 10 + d
        End While
        While nn > 0
            d = nn Mod 10
            nn = nn \ 10
            resultado = resultado * 10 + d
        End While
        Return resultado
    End Function

    Public Function Ejercicio_11() As Integer
        Dim digAnterior, ne, multiplicador, resultado As Integer
        resultado = 0 : multiplicador = 1
        ne = n
        While n > 0
            digAnterior = n Mod 10
            n = n \ 10
            If Not SeRepite(ne, digAnterior) Then
                resultado = resultado + (digAnterior * multiplicador)
                multiplicador = multiplicador * 10
            End If
        End While
        Return resultado
    End Function

    Private Sub construir_izquierda(num As Integer, ByRef p As Integer, nd As Integer)
        n = num * 10 ^ p + n
        p = p + nd
    End Sub

    Private Sub construir_derecha(num As Integer, nd As Integer)
        n = n * 10 ^ nd + num
    End Sub

    Private Function cant_digitos() As Integer
        If n > 0 Then
            Return Math.Truncate(Math.Log10(n) + 1)
        Else
            Return 0
        End If
    End Function

    Public Sub Ejercicio_12()
        Dim na, digito, p, q, nd As Integer
        Dim A As NEnt = New NEnt()
        Dim B As NEnt = New NEnt()
        na = n : p = 0 : q = 0
        While na > 0
            digito = na Mod 10
            If Frecuencia_dig(digito) = 1 Then
                B.construir_izquierda(digito, q, 1)
            Else
                A.construir_izquierda(digito, p, 1)
            End If
            na = na \ 10
        End While
        nd = B.cant_digitos
        A.construir_derecha(B.Descargar, nd)
        n = A.Descargar()
    End Sub

    'Public Sub Ejercicio_13(nd As Integer)
    '    Dim digito, resultado As Integer
    '    resultado = 0
    '    While n > 0
    '        digito = Me.DigMenor(nd)
    '        resultado = resultado * (10 ^ nd) + digito
    '        Me.Eliminar_Digito(nd, digito)
    '    End While
    '    n = resultado
    'End Sub

    Private Sub eliminarV2(digito As Integer, c As Integer, nd As Integer)
        Dim d, p As Integer
        Dim ayudin As NEnt = New NEnt()
        p = 0
        While n > 0
            d = n Mod 10 ^ nd
            If d = digito And c > 0 Then
                c = c - 1
            Else
                ayudin.construir_izquierda(d, p, nd)
            End If
            n = n \ 10 ^ nd
        End While
        n = ayudin.Descargar
    End Sub

    Public Sub Ejercicio_13(nd As Integer)
        Dim d As Integer
        Dim ayudin As NEnt = New NEnt()
        While n > 0
            d = DigMenor(nd)
            ayudin.construir_derecha(d, nd)
            eliminarV2(d, 1, nd)
        End While
        n = ayudin.Descargar
    End Sub

    Public Sub Ejercicio_14(n2 As NEnt, n3 As NEnt)
        Dim d, nu, m As Integer
        nu = 0 : m = 1
        While n > 0
            d = n Mod 10 ^ 2
            n = n \ 10 ^ 2
            If d = n2.n Then
                nu = nu + (n3.n * m)
                m = m * 10 ^ 2
            Else
                nu = nu + (d * m)
                m = m * 10 ^ 2
            End If
        End While
        n = nu
    End Sub

    'Public Sub Ejercicio_15(nd As Integer)
    '    Dim nu, par, impar As Integer
    '    Dim b As Boolean
    '    b = True
    '    nu = 0
    '    While n > 0
    '        If b = True Then
    '            If Me.BuscarDigPar(nd) Then
    '                par = Me.Retornar_DigPar(nd)
    '                nu = nu * 10 + par
    '                Me.EliminarDigito(nd, par)
    '            End If
    '        Else
    '            If Me.BuscarDigImpar(nd) Then
    '                impar = Me.Retornar_DigImpar(nd)
    '                nu = nu * 10 + impar
    '                Me.EliminarDigito(nd, impar)
    '            End If
    '        End If
    '        b = Not b
    '    End While
    '    n = nu
    'End Sub

    Public Sub ElimNumPares(nd As Integer)
        Dim d, p As Integer
        Dim ayudin As NEnt = New NEnt()
        p = 0
        While n > 0
            d = n Mod 10 ^ nd
            If d Mod 2 = 1 Then
                ayudin.construir_izquierda(d, p, nd)
            End If
            n = n \ 10 ^ nd
        End While
        n = ayudin.Descargar
    End Sub

    Public Sub ElimNumImpares(nd As Integer)
        Dim d, p As Integer
        Dim ayudin As NEnt = New NEnt()
        p = 0
        While n > 0
            d = n Mod 10 ^ nd
            If d Mod 2 = 0 Then
                ayudin.construir_izquierda(d, p, nd)
            End If
            n = n \ 10 ^ nd
        End While
        n = ayudin.Descargar
    End Sub

    Public Sub Ejercicio_15(nd As Integer)
        Dim da, db, p As Integer
        Dim A As NEnt = New NEnt()
        Dim B As NEnt = New NEnt()
        Dim ayudin As NEnt = New NEnt()
        Dim paco As Boolean = True
        p = 0
        A.Cargar(n)
        B.Cargar(n)
        A.ElimNumPares(nd)
        B.ElimNumImpares(nd)
        While A.n > 0 Or B.n > 0
            If paco Then
                If B.n > 0 Then
                    db = B.n Mod 10 ^ nd
                    ayudin.construir_derecha(db, nd)
                    B.Cargar(B.Descargar \ 10 ^ nd)
                End If
                paco = False
            Else
                If A.n > 0 Then
                    da = A.n Mod 10 ^ nd
                    ayudin.construir_derecha(da, nd)
                    A.Cargar(A.Descargar \ 10 ^ nd)
                End If
                paco = True
            End If
        End While
        n = ayudin.Descargar
    End Sub

    Public Function Ejercicio_16(n2 As NEnt, n3 As NEnt) As Integer
        Dim mayor, medio, menor, resultado As Integer
        Dim auxNent As NEnt
        auxNent = New NEnt()
        If (n < n2.n) And (n < n3.n) Then
            menor = n
            If (n2.n < n3.n) Then
                mayor = n3.n
                medio = n2.n
            Else
                mayor = n2.n
                medio = n3.n
            End If
        Else
            If (n2.n < n) And (n2.n < n3.n) Then
                menor = n2.n
                If (n < n3.n) Then
                    mayor = n3.n
                    medio = n
                Else
                    mayor = n
                    medio = n3.n
                End If

            Else
                If (n3.n < n) And (n3.n < n2.n) Then
                    menor = n3.n
                    If (n < n2.n) Then
                        mayor = n2.n
                        medio = n
                    Else
                        mayor = n
                        medio = n2.n
                    End If
                End If
            End If
        End If
        auxNent.Cargar(medio)
        resultado = menor * 10 ^ auxNent.Cant_Digs() + medio
        auxNent.Cargar(mayor)
        resultado = resultado * 10 ^ auxNent.Cant_Digs() + mayor
        Return resultado
    End Function

    Public Sub Ejercicio_17(n2 As NEnt, n3 As NEnt)
        Dim na, cola, cabeza, digito, digito2, cc As Integer
        Dim iguales As Boolean
        iguales = False
        na = n : cola = 0 : cabeza = 0 : cc = 0
        digito2 = na Mod 10
        na = na \ 10
        While (na > 0) And (Not iguales)
            digito = na Mod 10
            cola = cola + digito2 * (10 ^ cc)
            cc = cc + 1
            If (digito = digito2) Then
                iguales = True
            Else
                na = na \ 10
                digito2 = digito
            End If
        End While
        n2.Cargar(na)
        n3.Cargar(cola)
    End Sub

    Public Function Ejercicio_18() As Boolean
        Dim resultado As Boolean
        Dim na, digito As Integer
        resultado = False
        na = n
        If Not (Ejercicio_20()) Then
            While (na > 0) And (resultado = False)
                digito = na Mod 10
                na = na \ 10
                If Frecuencia_dig(digito) = 3 Then
                    resultado = True
                End If
            End While
        End If
        Return resultado
    End Function

    Public Function Ejercicio_19() As Boolean
        Dim na, fd, digito As Integer
        na = n
        While na > 0
            digito = na Mod 10
            If Frecuencia_dig(digito) = 2 Then
                fd = fd + 1
            End If
            na = na \ 10
        End While
        Return fd = 4
    End Function

    Public Function Ejercicio_20() As Boolean
        Return ((Frecuencia_dig(DigMayor(1)) = 3) And (Frecuencia_dig(DigMenor(1)) = 2)) Or
               ((Frecuencia_dig(DigMayor(1)) = 2) And (Frecuencia_dig(DigMenor(1)) = 3))
    End Function
End Class
