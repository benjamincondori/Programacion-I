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

    ' Verifica si es Par e Impar
    Public Function Verificar_Par() As Boolean
        Return n Mod 2 = 0
    End Function

    Public Function Verificar_Impar() As Boolean
        Return Not (n Mod 2 = 0)
    End Function

    ' Verificar si existe digito Par a Nd
    Public Function Verificar_Existe_Par_Nd(nd As Integer) As Boolean
        Dim digito As NEnt
        Dim b As Boolean = False
        Dim na As Integer = n
        digito = New NEnt()
        While na > 0
            digito.n = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If digito.Verificar_Par() Then
                b = True
            End If
        End While
        Return b
    End Function

    ' Verificar si existe digito Impar a Nd
    Public Function Verificar_Existe_Impar_Nd(nd As Integer) As Boolean
        Dim digito As NEnt
        Dim b As Boolean = False
        Dim na As Integer = n
        digito = New NEnt()
        While na > 0
            digito.n = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If Not digito.Verificar_Par() Then
                b = True
            End If
        End While
        Return b
    End Function

    Public Function Retornar_1erDigito_Impar_Nd(nd As Integer) As Integer
        Dim digito As NEnt = New NEnt()
        Dim digImpar As Integer = 0
        Dim na As Integer = n
        Dim b As Boolean = False
        While (na > 0) And (b = False)
            digito.n = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If digito.Verificar_Impar() Then
                digImpar = digito.n
                b = True
            End If
        End While
        Return digImpar
    End Function

    Public Function Retornar_1erDigito_Par_Nd(nd As Integer) As Integer
        Dim digito As NEnt = New NEnt()
        Dim digPar As Integer = 0
        Dim na As Integer = n
        Dim b As Boolean = False
        While (na > 0) And (b = False)
            digito.n = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If digito.Verificar_Par() Then
                digPar = digito.n
                b = True
            End If
        End While
        Return digPar
    End Function

    Public Sub Eliminar_Digito_Nd(dig As Integer, nd As Integer)
        Dim digito, exp As Integer
        Dim resultado As NEnt = New NEnt()
        Dim b As Boolean = False
        exp = 0
        While (n > 0) And (b = False)
            digito = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (digito = dig) Then
                b = True
            Else
                resultado.n = resultado.n + digito * 10 ^ exp
                exp = exp + nd
            End If
        End While
        Unir_2Nent(resultado)
    End Sub

    ' Unir dos numeros enteros
    Public Sub Unir_2Nent(nu As NEnt)
        n = n * 10 ^ nu.Cantidad_Digitos() + nu.n
    End Sub

    Public Function Cantidad_Digitos() As Integer
        Dim contador, na As Integer
        contador = 0 : na = n
        While na > 0
            na = na \ 10
            contador = contador + 1
        End While
        Return contador
    End Function

    ' Frecuencia de un digito
    Public Function Frecuencia_Digito(dig As Integer) As Integer
        Dim digito, na, frec As Integer
        na = n : frec = 0
        While na > 0
            digito = na Mod 10
            na = na \ 10
            If (digito = dig) Then
                frec = frec + 1
            End If
        End While
        Return frec
    End Function

    ' Intercalar digitos par y digitos impar Nd
    Public Sub Respuesta_1(nd As Integer)
        Dim par, impar As Integer
        Dim resultado As Integer = 0
        Dim b As Boolean = True
        While n > 0
            If b = True Then
                If Verificar_Existe_Par_Nd(nd) Then
                    par = Retornar_1erDigito_Par_Nd(nd)
                    resultado = resultado * 10 ^ nd + par
                    Eliminar_Digito_Nd(par, nd)
                End If
            Else
                If Verificar_Existe_Impar_Nd(nd) Then
                    impar = Retornar_1erDigito_Impar_Nd(nd)
                    resultado = resultado * 10 ^ nd + impar
                    Eliminar_Digito_Nd(impar, nd)
                End If
            End If
            b = Not b
        End While
        n = resultado
    End Sub

    ' Verificar si hay 2 Pares
    Public Function Respuesta_2() As Boolean
        Dim digito As Integer
        Dim frec As Integer = 0
        Dim na As Integer = n
        While na > 0
            digito = na Mod 10
            na = na \ 10
            If Frecuencia_Digito(digito) = 2 Then
                frec = frec + 1
            End If
        End While
        Return frec = 4
    End Function

End Class
