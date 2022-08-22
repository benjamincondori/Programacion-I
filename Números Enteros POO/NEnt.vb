Public Class NEnt
    Private n As Integer

    Public Sub NEnt()       ' Constructor
        n = 0
    End Sub

    Public Sub Cargar(dato As Integer)
        n = dato
    End Sub

    Public Function Descagar() As Integer
        Return n
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

    Public Function VerificarPrimo() As Boolean
        Dim i, residuo, contador As Integer
        contador = 0
        For i = 1 To n
            residuo = n Mod i
            If residuo = 0 Then
                contador = contador + 1
            End If
        Next
        Return contador = 2
    End Function

    Public Function VerificarPrimo1() As Boolean
        Dim i, residuo As Integer
        Dim b As Boolean
        i = 1
        If n > 1 Then
            Do
                i = i + 1
                residuo = n Mod i
            Loop Until residuo = 0
            b = n = i
        Else
            b = False
        End If
        Return b
    End Function

    Public Function VerificarMultiplo(numero As NEnt) As Boolean
        Dim residuo As Integer
        Dim b As Boolean
        residuo = n Mod numero.n
        If residuo = 0 Then
            b = True
        Else
            b = False
        End If
        Return b
    End Function

    Public Function VerificarMultiplo1(numero As NEnt) As Boolean
        Return n Mod numero.n = 0
    End Function

    Public Function VerificarPerteneceSerieExp(b As NEnt) As Boolean
        Dim i, termino As Integer
        i = -1
        Do
            i = i + 1
            termino = b.n ^ i
        Loop Until (termino = n) Or (termino > n)
        Return termino = n
    End Function

    Public Function VerificarPerteneceFibonacci() As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1
        Do
            c = a + b
            a = b
            b = c
        Loop Until (n = c) Or (c > n)
        Return n = c
    End Function

    Public Function SumarDigitos(nd As Integer) As Integer
        Dim d, aux, f As Integer
        aux = n
        f = 0
        While n > 0
            d = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            f = f + d
        End While
        n = aux
        Return f
    End Function

    Public Function SumarDigitosPrimos(nd As Integer) As Integer
        Dim aux, f As Integer
        Dim d As NEnt
        d = New NEnt
        aux = n
        f = 0
        While n > 0
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If d.VerificarPrimo() Then
                f = f + d.n
            End If
        End While
        n = aux
        Return f
    End Function

    Public Function ConvertirADecimal(base As Integer) As Integer
        Dim aux, posicion, resultado, digito As Integer
        aux = n : posicion = -1 : resultado = 0
        While n > 0
            digito = n Mod 10
            n = n \ 10
            posicion = posicion + 1
            resultado = resultado + digito * base ^ posicion
        End While
        n = aux
        Return resultado
    End Function

    Public Function BuscarDigito(digito1 As Integer) As Boolean
        Dim digito, aux As Integer
        Dim b As Boolean
        b = False
        aux = n
        While (n > 0) And (b = False)
            digito = n Mod 10
            n = n \ 10
            If digito = digito1 Then
                b = True
            End If
        End While
        n = aux
        Return b
    End Function

    Public Function BuscarDigitoPrimo() As Boolean
        Dim aux As Integer
        Dim b As Boolean
        Dim digito As NEnt
        digito = New NEnt
        b = False
        aux = n
        While (n > 0) And (b = False)
            digito.n = n Mod 10
            n = n \ 10
            If digito.VerificarPrimo1() Then
                b = True
            End If
        End While
        n = aux
        Return b
    End Function

    Public Function VerificarDigitosIguales() As Boolean
        Dim digito, aux, referencia As Integer
        Dim b As Boolean
        aux = n
        b = True
        referencia = n Mod 10
        n = n \ 10
        While (n > 0) And (b = True)
            digito = n Mod 10
            n = n \ 10
            If Not (digito = referencia) Then
                b = False
            End If
        End While
        n = aux
        Return b
    End Function

    Public Function VerificarDigitosPares() As Boolean
        Dim digito As NEnt
        Dim aux As Integer
        Dim b As Boolean
        digito = New NEnt()
        aux = n
        b = True
        While (n > 0) And (b = True)
            digito.n = n Mod 10
            n = n \ 10
            If Not (digito.VerificarPar) Then
                b = False
            End If
        End While
        n = aux
        Return b
    End Function

    Public Sub LanzarDados()
        Dim digito, i As Integer
        n = 0
        For i = 1 To 5
            digito = 1 + Rnd() * (6 - 1)
            n = n * 10 + digito
        Next
    End Sub

    'Public Sub InvertirDigitos()
    '    Dim digito, nu As Integer              n=1234 -->  nu=4321
    '    nu = 0
    '    While n > 0
    '        digito = n Mod 10
    '        n = n \ 10
    '        nu = nu * 10 + digito
    '    End While
    '    n = nu
    'End Sub

    'Public Sub Invertir_Digitos()
    '    Dim digito, nu, p As Integer           n=1234 -->  nu=1234
    '    nu = 0 : p = -1
    '    While n > 0
    '        digito = n Mod 10
    '        n = n \ 10
    '        p = p + 1
    '        nu = nu + digito * 10 ^ p
    '    End While
    '    n = nu
    'End Sub

    Public Sub EliminarPares()  'Selccionar digitos impares
        Dim digito As NEnt
        Dim nu, p As Integer
        digito = New NEnt()
        nu = 0 : p = -1
        While n > 0
            digito.n = n Mod 10
            n = n \ 10
            If Not digito.VerificarDigitosPares() Then
                p = p + 1
                nu = nu + digito.n * 10 ^ p
            End If
        End While
        n = nu
    End Sub

    Public Function Eliminar_Digito(nd As Integer, d As Integer) As Integer
        Dim r, da, m, aux As Integer
        aux = n
        r = 0
        m = 1
        While n > 0
            da = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If d <> da Then
                r = r + (da * m)
                m = m * 10 ^ nd
            End If
        End While
        n = aux
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

    Public Function DigMenor(nd As Integer) As Integer
        Dim d, men, aux As Integer
        aux = n
        men = n Mod 10 ^ nd : n = n \ 10 ^ nd
        While n > 0
            d = n Mod 10 ^ nd
            If (d < men) Then
                men = d
            End If
            n = n \ 10 ^ nd
        End While
        n = aux
        Return men
    End Function

    Public Sub SegmentarParImpar()
        Dim pp, pi As Integer
        Dim digito, par, impar As NEnt
        digito = New NEnt
        par = New NEnt
        impar = New NEnt
        pp = -1 : pi = -1
        While n > 0
            digito.n = n Mod 10
            n = n \ 10
            If digito.VerificarPar() Then
                pp = pp + 1
                par.n = par.n + digito.n * 10 ^ pp
            Else
                pi = pi + 1
                impar.n = impar.n + digito.n * 10 ^ pi
            End If
        End While
        par.Unir2Numeros(impar)
        n = par.n
    End Sub

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

    Public Function Buscar_DigImpar(nd As Integer) As Integer
        Dim nu, m As Integer
        Dim d As NEnt
        d = New NEnt()
        nu = 0 : m = 1
        While n > 0
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If Not d.VerificarPar() Then
                nu = nu + (d.n * m)
                m = m * 10
            End If
        End While
        Return nu
    End Function

    Public Function Buscar_DigPar(nd As Integer) As Integer
        Dim nu, m As Integer
        Dim d As NEnt
        Dim na As Integer = n
        d = New NEnt()
        nu = 0 : m = 1
        While na > 0
            d.n = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If d.VerificarPar() Then
                nu = nu + (d.n * m)
                m = m * 10
            End If
        End While
        Return nu
    End Function

    Public Function DigMenorPar(nd As Integer) As Integer
        Return DigMenor(Buscar_DigPar(nd))
    End Function

    Public Function DigMenorImpar(nd As Integer) As Integer
        Return DigMenor(Buscar_DigImpar(nd))
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

    Public Function VerificarPares(nd As Integer) As Boolean
        Dim b As Boolean
        Dim d As NEnt
        d = New NEnt()
        b = True
        While n > 0 And b = True
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If Not d.VerificarPar() Then
                b = False
            End If
        End While
        Return b
    End Function

    Public Function VerificarImpares(nd As Integer) As Boolean
        Dim b As Boolean
        Dim d As NEnt
        d = New NEnt()
        b = True
        While n > 0 And b = True
            d.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If d.VerificarPar() Then
                b = False
            End If
        End While
        Return b
    End Function
End Class
