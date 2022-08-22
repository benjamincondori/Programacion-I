Public Class NEntero
    Private n As Integer
    Public Sub Nentero()
        n = 0
    End Sub
    Public Sub Cargar(nu As Integer)
        n = nu
    End Sub
    Public Function Descargar() As Integer
        Return n
    End Function
    Private Function cant_digitos() As Integer
        If n > 0 Then
            Return Math.Truncate(Math.Log10(n) + 1)
        Else
            Return 0
        End If
    End Function


    Private Sub construir_izquierda(num As Integer, ByRef p As Integer, nd As Integer)
        n = num * 10 ^ p + n
        p = p + nd
    End Sub

    Private Sub construir_derecha(num As Integer, nd As Integer)

        n = n * 10 ^ nd + num
    End Sub

    Public Function pra1_ejercicio1() As String
        Dim i As Integer = 1
        Dim a, b, f As Integer
        Dim fibo As String = ""
        a = -1
        b = 1
        While (i <= n)
            f = a + b
            a = b
            b = f
            If f Mod 2 = 1 Then
                fibo = fibo + "," + CStr(f)
                i = i + 1
            End If
        End While
        Return fibo.Remove(0, 1)
    End Function

    Private Function EsPrimo() As Boolean
        Dim primo As Boolean = True
        Dim i As Integer
        For i = 2 To n - 1
            If n Mod i = 0 Then
                primo = False
            End If
        Next
        If n = 1 Then
            Return False
        Else
            Return primo
        End If
    End Function

    Public Function pra1_ejercicio2() As String
        Dim i As Integer = 1
        Dim t As NEntero = New NEntero
        Dim primos As String = ""
        While (i <= n)
            t.Cargar(t.Descargar + 1)
            If t.EsPrimo Then
                primos = primos + "," + CStr(t.Descargar)
                i = i + 1
            End If
        End While
        Return primos.Remove(0, 1)
    End Function

    Public Function pra1_ejercicio3() As String
        Dim i As Integer = 1
        Dim t As NEntero = New NEntero
        While (i <= n)
            t.Cargar(t.Descargar + 1)
            If Not (t.EsPrimo) Then
                i = i + 1
            End If
        End While
        Return t.Descargar
    End Function

    Private Function factorial() As Integer
        Dim mult As Integer = 1
        For i = 1 To n
            mult = mult * i
        Next
        Return mult
    End Function
    Public Function pra1_ejercicio4(m As Integer) As String
        Dim suma As Integer = 0
        Dim n_copy As NEntero = New NEntero
        n_copy.Cargar(n)
        While (n_copy.Descargar > 0)
            If m Mod n_copy.Descargar = 0 Then
                suma = suma + n_copy.factorial
            End If
            n_copy.Cargar(n_copy.Descargar - 1)
        End While
        Return suma
    End Function
    Public Function pra1_ejercicio5(vi As Integer, r As Integer) As Boolean
        Dim i As Integer = 1
        Dim t As Integer = 0
        Dim paco As Boolean = False
        While (t <= n)
            t = vi + (i - 1) * r
            If t = n Then
                paco = True
            End If
            i = i + 1
        End While
        Return paco
    End Function
    Public Sub invertir()
        Dim d As Integer
        Dim ayuco As NEntero = New NEntero

        While n > 0
            d = n Mod 10
            ayuco.construir_derecha(d, 1)
            n = n \ 10
        End While
        n = ayuco.Descargar
    End Sub
    Public Function pra1_ejercicio6(nd As Integer) As String
        Dim d As NEntero = New NEntero
        Dim s As String = ""
        Dim copy As Integer
        d.Cargar(n)
        d.invertir()
        copy = d.Descargar
        While copy > 0
            d.Cargar(copy Mod (10 ^ nd))
            d.invertir()
            s = s + "," + CStr(d.Descargar)
            copy = copy \ (10 ^ nd)
        End While
        Return s.Remove(0, 1)
    End Function

    Public Function pra1_ejercicio7(n2 As NEntero) As Integer
        If n > n2.Descargar Then
            Return n
        Else
            Return n2.Descargar
        End If
    End Function


    Public Function pra1_ejercicio8(n2 As NEntero, n3 As NEntero) As Integer
        Dim res As NEntero = New NEntero
        res.Cargar(pra1_ejercicio7(n2))
        Return res.pra1_ejercicio7(n3)
        'otra forma
        'n2.Cargar(n2.pra1_ejercicio7(n3))
        'Return pra1_ejercicio7(pra1_ejercicio7(n2))
    End Function

    Public Function pra1_ejercicio9(n2 As NEntero, n3 As NEntero) As Integer
        If n > n2.n Then
            If n > n3.n Then
                Return 1
            Else
                Return 3
            End If
        Else
            If n2.n > n3.n Then
                Return 2
            Else
                Return 3
            End If
        End If
    End Function
    Public Function pra1_ejercicio10(b As Integer) As Integer
        Dim copy As Integer = n
        Dim d As Integer
        Dim p As Integer = 0
        Dim ayudin As NEntero = New NEntero
        If b >= 2 And b <= 9 Then
            While copy > 0
                d = copy Mod b
                ayudin.construir_izquierda(d, p, 1)
                copy = copy \ b
            End While
            Return ayudin.Descargar
        Else
            MsgBox("ERROR, base no valida")
            Return 0
        End If
    End Function

    Private Function frecuencia(digito As Integer) As Integer
        Dim copy, d, c As Integer
        copy = n
        c = 0
        While copy > 0
            d = copy Mod 10
            If d = digito Then
                c = c + 1
            End If
            copy = copy \ 10
        End While
        Return c
    End Function

    Private Sub eliminarV1(digito As Integer)
        Dim d, p As Integer
        Dim ayudin As NEntero = New NEntero
        p = 0
        While n > 0
            d = n Mod 10
            If d <> digito Then
                ayudin.construir_izquierda(d, p, 1)
            End If
            n = n \ 10
        End While
        n = ayudin.Descargar
    End Sub

    Public Sub pra2_ejercicio1()
        Dim d, f, p As Integer
        Dim ayudin As NEntero = New NEntero
        p = 0
        While n > 0
            d = n Mod 10
            f = frecuencia(d)
            If f = 1 Then
                ayudin.construir_izquierda(d, p, 1)
            End If
            eliminarV1(d)
        End While
        n = ayudin.Descargar
    End Sub

    Public Sub pra2_ejercicio2()
        Dim copy As Integer = n
        Dim d, f, p, q, nd As Integer
        Dim A As NEntero = New NEntero
        Dim B As NEntero = New NEntero
        p = 0
        q = 0
        While copy > 0
            d = copy Mod 10
            f = frecuencia(d)
            If f = 1 Then
                B.construir_izquierda(d, q, 1)
            Else
                A.construir_izquierda(d, p, 1)
            End If
            copy = copy \ 10
        End While
        nd = B.cant_digitos
        A.construir_derecha(B.Descargar, nd)
        n = A.Descargar
    End Sub


    Private Function menorNum(nd As Integer) As Integer
        Dim copy As Integer = n
        Dim men As Integer = copy Mod 10 ^ nd
        Dim d As Integer
        copy = copy \ 10 ^ nd
        While copy > 0
            d = copy Mod 10 ^ nd
            If d < men Then
                men = d
            End If
            copy = copy \ 10 ^ nd
        End While
        Return men
    End Function

    Private Sub eliminarV2(digito As Integer, c As Integer, nd As Integer)
        Dim d, p As Integer
        Dim ayudin As NEntero = New NEntero
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

    Public Sub pra2_ejercicio3(nd As Integer)
        Dim d As Integer
        Dim ayudin As NEntero = New NEntero
        While n > 0
            d = menorNum(nd)
            ayudin.construir_derecha(d, nd)
            eliminarV2(d, 1, nd)
        End While
        n = ayudin.Descargar
    End Sub

    Public Sub pra2_ejercicio4(NA1 As NEntero, NA2 As NEntero)
        Dim d, p As Integer
        Dim ayudin As NEntero = New NEntero
        Dim nd_NA1 As Integer = NA1.cant_digitos
        Dim nd_NA2 As Integer = NA2.cant_digitos
        p = 0
        While n > 0
            d = n Mod 10 ^ nd_NA1
            If d <> NA1.n Then
                ayudin.construir_izquierda(d, p, nd_NA1)
            Else
                ayudin.construir_izquierda(NA2.n, p, nd_NA2)
            End If
            eliminarV2(d, 1, nd_NA1)
        End While
        n = ayudin.Descargar
    End Sub


    Public Sub ElimNumPares(nd As Integer)
        Dim d, p As Integer
        Dim ayudin As NEntero = New NEntero
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
        Dim ayudin As NEntero = New NEntero
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

    Public Sub pra2_ejercicio5(nd As Integer)
        Dim da, db, p As Integer
        Dim A As NEntero = New NEntero
        Dim B As NEntero = New NEntero
        Dim ayudin As NEntero = New NEntero
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



    Public Function menor(n2 As NEntero) As Integer
        If n < n2.Descargar Then
            Return n
        Else
            Return n2.Descargar
        End If
    End Function

    Public Sub pra2_ejercicio6(N2 As NEntero, N3 As NEntero)
        Dim p As NEntero = New NEntero 'guarda mayor entre N y B
        Dim q As NEntero = New NEntero 'guarda menor entre N y B
        Dim primer_mayor As NEntero = New NEntero 'guarda mayor entre P y C
        Dim y As NEntero = New NEntero 'guarda menor entre P y C
        Dim segundo_mayor As NEntero = New NEntero 'guarda mayor entre Q y Y
        Dim tercer_mayor As NEntero = New NEntero 'guarda menor entre Q y Y
        Dim cant_primero, cant_segundo, cant_tercero As Integer
        p.Cargar(pra1_ejercicio7(N2))
        q.Cargar(menor(N2))
        primer_mayor.Cargar(p.pra1_ejercicio7(N3))
        y.Cargar(p.menor(N3))
        segundo_mayor.Cargar(q.pra1_ejercicio7(y))
        tercer_mayor.Cargar(q.menor(y))

        cant_primero = primer_mayor.cant_digitos
        cant_segundo = segundo_mayor.cant_digitos
        cant_tercero = tercer_mayor.cant_digitos

        n = tercer_mayor.Descargar
        construir_derecha(segundo_mayor.Descargar, cant_segundo)
        construir_derecha(primer_mayor.Descargar, cant_primero)
    End Sub

    Public Sub pra2_ejercicio7(ByRef N1 As NEntero, ByRef N2 As NEntero)
        Dim d, p, q As Integer
        Dim paco As Boolean = False
        p = 0
        q = 0
        While n > 0
            d = n Mod 10
            If paco Then
                N1.construir_izquierda(d, p, 1)
            Else
                N2.construir_izquierda(d, q, 1)
            End If
            d = n Mod 100
            If d Mod 10 = d \ 10 Then
                paco = True
            End If
            n = n \ 10
        End While
    End Sub

    Private Function mayorNum(nd As Integer) As Integer
        Dim copy As Integer = n
        Dim may As Integer = copy Mod 10 ^ nd
        Dim d As Integer
        copy = copy \ 10 ^ nd
        While copy > 0
            d = copy Mod 10 ^ nd
            If d > may Then
                may = d
            End If
            copy = copy \ 10 ^ nd
        End While
        Return may
    End Function

    Public Function pra2_ejercicio8() As Boolean
        Dim copy As Integer = n
        Dim paco As Boolean = False
        Dim d As Integer
        If Not pra2_ejercicio10() Then
            While copy > 0 And paco = False
                d = copy Mod 10
                If frecuencia(d) = 3 Then
                    paco = True
                End If
                copy = copy \ 10
            End While
        End If
        Return paco
    End Function

    Public Function pra2_ejercicio9() As Boolean
        Dim copy As Integer = n
        Dim c As Integer = 0
        Dim d, f As Integer
        While n > 0
            d = n Mod 10
            f = frecuencia(d)
            If f = 2 Then
                c = c + 1
            End If
            n = n \ 10
        End While
        n = copy
        Return c = 2
    End Function

    Public Function pra2_ejercicio10() As Boolean
        Return frecuencia(mayorNum(1)) = 3 And frecuencia(menorNum(1)) = 2 Or frecuencia(mayorNum(1)) = 2 And frecuencia(menorNum(1)) = 3
    End Function

End Class
