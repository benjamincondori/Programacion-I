Public Class NEnt

    Private n As Integer        ' Atributos

    Public Sub NEnt()           ' Constructor
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

    ' Verifica si todos los digitos son Pares e Impares
    Public Function Verificar_Pares() As Boolean
        Dim na As Integer
        Dim digito As NEnt
        Dim b As Boolean
        digito = New NEnt
        na = n : b = True
        While (na > 0) And (b = True)
            digito.n = na Mod 10
            na = na \ 10
            If Not digito.Verificar_Par() Then
                b = False
            End If
        End While
        Return b
    End Function

    ' Verifica si todos los digitos son Impares
    Public Function Verificar_Impares() As Boolean
        Dim na As Integer
        Dim digito As NEnt
        Dim b As Boolean
        digito = New NEnt
        na = n : b = True
        While (na > 0) And (b = True)
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Par() Then
                b = False
            End If
        End While
        Return b
    End Function

    ' Verificar si es Primo 
    Public Function Verificar_Primo() As Boolean
        Dim contador, i, residuo, na As Integer
        contador = 0 : na = n
        For i = 1 To na
            residuo = na Mod i
            If residuo = 0 Then
                contador = contador + 1
            End If
        Next
        Return contador = 2
    End Function

    ' Verificar si es No Primo
    Public Function Verificar_NoPrimo() As Boolean
        Dim contador, i, residuo, na As Integer
        contador = 0 : na = n
        For i = 1 To na
            residuo = na Mod i
            If residuo = 0 Then
                contador = contador + 1
            End If
        Next
        Return contador <> 2
    End Function

    ' Verificar si dentro de un número existe un digito Primo
    Public Function Verificar_Existe_Primo() As Boolean
        Dim digito As NEnt
        Dim b As Boolean
        Dim na As Integer
        digito = New NEnt()
        b = False : na = n
        While (na > 0) And (b = False)
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Primo() Then
                b = True
            End If
        End While
        Return b
    End Function

    ' Verificar si dentro de un número existe un digito No Primo
    Public Function Verificar_Existe_NoPrimo() As Boolean
        Dim digito As NEnt
        Dim b As Boolean
        Dim na As Integer
        digito = New NEnt()
        b = False : na = n
        While (na > 0) And (b = False)
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_NoPrimo() Then
                b = True
            End If
        End While
        Return b
    End Function

    ' Verificar si el digito pertence a Fibonacci
    Public Function Verificar_Pertenece_Fibonacci() As Boolean
        Dim a, b, c, na As Integer
        a = -1 : b = 1 : na = n
        Do
            c = a + b
            a = b
            b = c
        Loop Until (c = na) Or (c > na)
        Return (c = na)
    End Function

    ' Verificar si un número esta en orden Ascendente (menor a mayor)
    Public Function Verificar_Orden_Ascendente() As Boolean
        Dim digito, digito2, na As Integer
        Dim b As Boolean = True
        na = n
        digito2 = na Mod 10 : na = na \ 10
        While (na > 0) And (b = True)
            digito = na Mod 10
            na = na \ 10
            If digito <= digito2 Then
                digito2 = digito
            Else
                b = False
            End If
        End While
        Return b
    End Function

    ' Verificar si un número esta en orden Descendente (mayor a menor)
    Public Function Verificar_Orden_Descendente() As Boolean
        Dim digito, digito2, na As Integer
        Dim b As Boolean = True
        na = n
        digito2 = na Mod 10 : na = na \ 10
        While (na > 0) And (b = True)
            digito = na Mod 10
            na = na \ 10
            If digito >= digito2 Then
                digito2 = digito
            Else
                b = False
            End If
        End While
        Return b
    End Function

    ' Verificar ai todos los digitos son iguales
    Public Function Verificar_Digitos_Iguales() As Boolean
        Dim digito, digito2, na As Integer
        Dim b As Boolean = True
        na = n
        digito2 = na Mod 10 : na = na \ 10
        While (na > 0) And (b = True)
            digito = na Mod 10
            na = na \ 10
            If digito <> digito2 Then
                b = False
            End If
        End While
        Return b
    End Function

    ' Verificar si existe el digito en un numero
    Public Function Verificar_Existe_Digito(digito2 As Integer) As Boolean
        Dim digito, na As Integer
        Dim b As Boolean = False
        na = n
        While (na > 0) And (b = False)
            digito = na Mod 10
            na = na \ 10
            If (digito = digito2) Then
                b = True
            End If
        End While
        Return b
    End Function

    ' Verificar si existe digito Par
    Public Function Verificar_Existe_Par() As Boolean
        Dim digito As NEnt
        Dim b As Boolean = False
        Dim na As Integer = n
        digito = New NEnt()
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Par() Then
                b = True
            End If
        End While
        Return b
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

    ' Verificar si existe digito Impar
    Public Function Verificar_Existe_Impar() As Boolean
        Dim digito As NEnt
        Dim b As Boolean = False
        Dim na As Integer = n
        digito = New NEnt()
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If Not digito.Verificar_Par() Then
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

    ' Verificar si un numero pertenece a su base entre 2-9
    Public Function Verificar_Base(base As Integer) As Boolean
        Dim digito, na As Integer
        Dim b As Boolean = True
        na = n
        While (na > 0) And (b = True)
            digito = na Mod 10
            na = na \ 10
            If digito >= base Then
                b = False
            End If
        End While
        Return b
    End Function

    ' Verificar si un numero es multiplo de otro numero
    Public Function Verificar_Multiplo(numero As Integer) As Boolean
        Dim na As Integer = n
        Return (na Mod numero = 0)
    End Function

    ' Verificar si un numero es submultiplo de otro numero
    Public Function Verificar_Submultiplo(numero As Integer) As Boolean
        Dim na As Integer = n
        Return (numero Mod na = 0)
    End Function

    ' Verificar si se repite un digito
    Public Function Verificar_SeRepite(num As Integer) As Boolean
        Dim digito, na, contador As Integer
        na = n : contador = 0
        While na > 0
            digito = na Mod 10
            na = na \ 10
            If (digito = num) Then
                contador = contador + 1
            End If
        End While
        Return contador > 1
    End Function

    ' Verificar si un numero es capicua
    Public Function Verificar_Capicua() As Boolean
        Dim na As Integer = n
        Me.Invertir()
        Return n = na
    End Function

    ' Verificar si es Póker
    Public Function Verificar_Poker() As Boolean
        Return ((Frecuencia_Digito(Digito_Mayor()) = 1) And (Frecuencia_Digito(Digito_Menor()) = 4)) Or
               ((Frecuencia_Digito(Digito_Mayor()) = 4) And (Frecuencia_Digito(Digito_Menor()) = 1))
    End Function

    ' Verificar si es Full
    Public Function Verificar_Full() As Boolean
        Return ((Frecuencia_Digito(Digito_Mayor()) = 3) And (Frecuencia_Digito(Digito_Menor()) = 2)) Or
               ((Frecuencia_Digito(Digito_Mayor()) = 2) And (Frecuencia_Digito(Digito_Menor()) = 3))
    End Function

    ' Verificar si hay un solo Par
    Public Function Verificar_1_Par() As Boolean
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
        Return frec = 2
    End Function

    ' Verificar si hay 2 Pares
    Public Function Verificar_2_Pares() As Boolean
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

    ' Verificar si es Trica
    Public Function Verificar_Trica() As Boolean
        Dim na As Integer = n
        Dim digito As Integer
        Dim b As Boolean = False
        If Not (Verificar_Full()) Then
            While (na > 0) And (b = False)
                digito = na Mod 10
                na = na \ 10
                If Frecuencia_Digito(digito) = 3 Then
                    b = True
                End If
            End While
        End If
        Return b
    End Function

    ' Verificar si es Escalera
    Public Function Verificar_Escalera() As Boolean
        Orden_Ascendente()
        Dim digito As Integer
        Dim na As Integer = n
        Dim b As Boolean = True
        Dim digRef As Integer
        digRef = na Mod 10 : na = na \ 10
        While (na > 0) And (b = True)
            digito = na Mod 10
            na = na \ 10
            digRef = digRef - 1
            If digito <> digRef Then
                b = False
            End If
        End While
        Return b
    End Function

    ' Invertir un numero
    Public Sub Invertir()
        Dim digito, resultado As Integer
        resultado = 0
        While n > 0
            digito = n Mod 10
            n = n \ 10
            resultado = resultado * 10 + digito
        End While
        n = resultado
    End Sub

    ' Mantener orden de un numero
    Public Sub Mantener_Orden()
        Dim digito, resultado, exp As Integer
        resultado = 0 : exp = 0
        While n > 0
            digito = n Mod 10
            n = n \ 10
            resultado = resultado + digito * 10 ^ exp
            exp = exp + 1
        End While
        n = resultado
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

    ' Digito menor de un numero entero
    Public Function Digito_Menor() As Integer
        Dim digito, menor, na As Integer
        na = n
        menor = na Mod 10 : na = na \ 10
        While na > 0
            digito = na Mod 10
            na = na \ 10
            If (digito < menor) Then
                menor = digito
            End If
        End While
        Return menor
    End Function

    Public Function Digito_Menor_Nd(nd As Integer) As Integer
        Dim digito, menor, na As Integer
        na = n
        menor = na Mod 10 ^ nd : na = na \ 10 ^ nd      ' 7 654 321
        While na > 0
            digito = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If (digito < menor) Then
                menor = digito
            End If
        End While
        Return menor
    End Function

    ' Digito mayor de un numero entero
    Public Function Digito_Mayor() As Integer
        Dim digito, mayor, na As Integer
        na = n
        mayor = na Mod 10 : na = na \ 10
        While na > 0
            digito = na Mod 10
            na = na \ 10
            If (digito > mayor) Then
                mayor = digito
            End If
        End While
        Return mayor
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

    ' Frecuencia de un numero
    Public Function Frecuencia_Numero(dig As NEnt) As Integer
        Dim digito, na, frec As Integer
        Dim nd As Integer = dig.Cantidad_Digitos()
        na = n : frec = 0
        While na > 0
            digito = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If (digito = dig.n) Then
                frec = frec + 1
            End If
        End While
        Return frec
    End Function

    ' Eliminar todos los digitos de un NE ingresando un digito
    Public Sub Eliminar_Todos_Digitos(dig As Integer)
        Dim digito, resultado, exp As Integer
        resultado = 0 : exp = 0
        While n > 0
            digito = n Mod 10
            n = n \ 10
            If (digito <> dig) Then
                resultado = resultado + digito * 10 ^ exp
                exp = exp + 1
            End If
        End While
        n = resultado
    End Sub

    ' Eliminar todos los digitos de un NE ingresando un numero
    Public Sub Eliminar_Todos_Numeros(dig As NEnt)
        Dim digito, resultado, exp As Integer
        Dim nd As Integer = dig.Cantidad_Digitos()
        resultado = 0 : exp = 0
        While n > 0
            digito = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (digito <> dig.n) Then
                resultado = resultado + digito * 10 ^ exp
                exp = exp + nd
            End If
        End While
        n = resultado
    End Sub

    ' Eliminar el primer digito de un NE ingresando un digito
    Public Sub Eliminar_Digito(dig As Integer)
        Dim digito, exp As Integer
        Dim resultado As NEnt = New NEnt()
        Dim b As Boolean = False
        exp = 0
        While (n > 0) And (b = False)
            digito = n Mod 10
            n = n \ 10
            If (digito = dig) Then
                b = True
            Else
                resultado.n = resultado.n + digito * 10 ^ exp
                exp = exp + 1
            End If
        End While
        Unir_2Nent(resultado)
    End Sub

    'Ordenar un NE de forma ascendente (menor a mayor)
    Public Sub Orden_Ascendente()
        Dim digito As Integer
        Dim resultado As Integer = 0
        While n > 0
            digito = Digito_Menor()
            resultado = resultado * 10 + digito
            Eliminar_Digito(digito)
        End While
        n = resultado
    End Sub

    ' Ordenar un NE de forma descendente (mayor a menor)
    Public Sub Orden_Descendente()
        Dim digito As Integer
        Dim resultado As Integer = 0
        While n > 0
            digito = Digito_Mayor()
            resultado = resultado * 10 + digito
            Eliminar_Digito(digito)
        End While
        n = resultado
    End Sub

    ' Ordenar un NE de forma ascendente a Nd digitos (menor a mayor)
    Public Sub Orden_Ascendente_Nd(nd As Integer)
        Dim digito As NEnt = New NEnt()
        Dim resultado As NEnt = New NEnt()
        While n > 0
            digito.n = Digito_Menor_Nd(nd)
            resultado.n = resultado.n * 10 ^ digito.Cantidad_Digitos() + digito.n
            Eliminar_Digito_Nd(digito.n, nd)
        End While
        n = resultado.n
    End Sub

    ' Ordenar un NE de forma Descendente a Nd digitos (mayor a menor)
    Public Sub Orden_Descendente_Nd(nd As Integer)
        Dim digito As NEnt = New NEnt()
        Dim resultado As NEnt = New NEnt()
        While n > 0
            digito.n = Digito_Mayor_Nd(nd)
            resultado.n = resultado.n * 10 ^ digito.Cantidad_Digitos() + digito.n
            Eliminar_Digito_Nd(digito.n, nd)
        End While
        n = resultado.n
    End Sub

    Public Function Digito_Mayor_Nd(nd As Integer) As Integer
        Dim digito, mayor, na As Integer
        na = n
        mayor = na Mod 10 ^ nd : na = na \ 10 ^ nd
        While na > 0
            digito = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If (digito > mayor) Then
                mayor = digito
            End If
        End While
        Return mayor
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

    ' Purgar digitos repetidos
    Public Sub Purgar_Digitos()
        Dim digito As Integer
        Dim resultado As Integer = 0
        Dim exp As Integer = 0
        While n > 0
            digito = n Mod 10
            resultado = resultado + digito * 10 ^ exp
            exp = exp + 1
            Eliminar_Todos_Digitos(digito)
        End While
        n = resultado
    End Sub

    ' Eliminar todos los digitos repetidos (formar numero con digitos no repetidos)
    Public Sub Eliminar_Digitos_Repetidos()
        Dim digito As Integer
        Dim resultado As Integer = 0
        Dim exp As Integer = 0
        While n > 0
            digito = n Mod 10
            If Frecuencia_Digito(digito) = 1 Then
                resultado = resultado + digito * 10 ^ exp
                exp = exp + 1
            End If
            Eliminar_Todos_Digitos(digito)
        End While
        n = resultado
    End Sub

    Public Sub Eliminar_Digitos_Repetidos_Nd(nd As Integer)
        Dim digito As NEnt = New NEnt()
        Dim resultado As Integer = 0
        Dim exp As Integer = 0
        While n > 0
            digito.n = n Mod 10 ^ nd
            If Frecuencia_Numero(digito) = 1 Then
                resultado = resultado + digito.n * 10 ^ exp
                exp = exp + nd
            End If
            Eliminar_Todos_Numeros(digito)
        End While
        n = resultado
    End Sub

    ' Formar numero con digitos repetidos
    Public Sub Eliminar_Digitos_NoRepetidos()
        Dim digito As Integer
        Dim resultado As Integer = 0
        Dim exp As Integer = 0
        While n > 0
            digito = n Mod 10
            If Frecuencia_Digito(digito) > 1 Then           ' 1213445 --> 14
                resultado = resultado + digito * 10 ^ exp
                exp = exp + 1
            End If
            Eliminar_Todos_Digitos(digito)
        End While
        n = resultado
    End Sub

    ' Cantidad de digitos que se repiten
    Public Function Cantidad_Digitos_Repetidos() As Integer
        Dim digito As Integer
        Dim contador As Integer = 0
        Dim na As Integer = n
        While n > 0
            digito = n Mod 10          '124215
            If Frecuencia_Digito(digito) > 1 Then
                contador = contador + 1
            End If
            Eliminar_Todos_Digitos(digito)
        End While
        n = na
        Return contador
    End Function

    ' Transformar de base 10 a base 2-9 de un NE
    Public Function Transformar_Base(base As Integer) As Integer
        Dim digito As Integer
        Dim nn As Integer = 0
        Dim resultado As Integer = 0
        Dim na As Integer = n
        While na > 0
            digito = na Mod base   ' 25    base=2
            na = na \ base
            nn = nn * 10 + digito
        End While
        While nn > 0
            digito = nn Mod 10
            nn = nn \ 10
            resultado = resultado * 10 + digito
        End While
        Return resultado
    End Function

    ' Factorial de un numero
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

    ' Retornar digito par
    Public Function Retornar_1erDigito_Par() As Integer
        Dim digito As NEnt = New NEnt()
        Dim digPar As Integer = 0
        Dim na As Integer = n
        Dim b As Boolean = False
        While (na > 0) And (b = False)
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Par() Then
                digPar = digito.n
                b = True
            End If
        End While
        Return digPar
    End Function

    ' Retornar todos los digitos pares
    Public Function Retornar_Digitos_Pares() As Integer
        Dim digito As NEnt = New NEnt()
        Dim digPar As Integer = 0
        Dim na As Integer = n
        Dim exp As Integer = 0
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Par() Then
                digPar = digPar + digito.n * 10 ^ exp
                exp = exp + 1
            End If
        End While
        Return digPar
    End Function

    Public Function Retornar_Digitos_Pares_Nd(nd As Integer) As Integer
        Dim digito As NEnt = New NEnt()
        Dim digPar As Integer = 0
        Dim na As Integer = n
        Dim exp As Integer = 0
        While na > 0
            digito.n = na Mod 10 ^ nd
            na = na \ 10 ^ nd
            If digito.Verificar_Par() Then
                digPar = digPar + digito.n * 10 ^ exp
                exp = exp + 1
            End If
        End While
        Return digPar
    End Function
    ' Retornar digito Impar
    Public Function Retornar_1erDigito_Impar() As Integer
        Dim digito As NEnt = New NEnt()
        Dim digImpar As Integer = 0
        Dim na As Integer = n
        Dim b As Boolean = False
        While (na > 0) And (b = False)
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Impar() Then
                digImpar = digito.n
                b = True
            End If
        End While
        Return digImpar
    End Function

    ' Retornar todos los digitos impares
    Public Function Retornar_Digitos_Impares() As Integer
        Dim digito As NEnt = New NEnt()
        Dim digImpar As Integer = 0
        Dim na As Integer = n
        Dim exp As Integer = 0
        While na > 0
            digito.n = na Mod 10        '1224135
            na = na \ 10
            If digito.Verificar_Impar() Then
                digImpar = digImpar + digito.n * 10 ^ exp
                exp = exp + 1
            End If
        End While
        Return digImpar
    End Function

    ' Retornar digito Primo
    Public Function Retornar_1erDigito_Primo() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim resultado As Integer = 0
        Dim b As Boolean = False
        While (na > 0) And (b = False)
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Primo() Then
                resultado = digito.n
                b = True
            End If
        End While
        Return resultado
    End Function

    ' Retornar digito No Primo
    Public Function Retornar_1erDigito_NoPrimo() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim resultado As Integer = 0
        Dim b As Boolean = False
        While (na > 0) And (b = False)
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_NoPrimo() Then
                resultado = digito.n
                b = True
            End If
        End While
        Return resultado
    End Function

    ' Retornar todos los digitos Primos
    Public Function Retornar_Digitos_Primos() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim resultado As Integer = 0
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Primo() Then
                resultado = resultado * 10 + digito.n
            End If
        End While
        Return resultado
    End Function

    ' Retornar todos los digitos No Primos
    Public Function Retornar_Digitos_NoPrimos() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim resultado As Integer = 0
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_NoPrimo() Then
                resultado = resultado * 10 + digito.n
            End If
        End While
        Return resultado
    End Function

    'Segmentar digitos pares  y digitos impares
    Public Sub Segmentar_Par_Impar()
        Dim digito As NEnt = New NEnt()
        Dim par As NEnt = New NEnt()
        Dim impar As NEnt = New NEnt()
        Dim expPar As Integer = 0
        Dim expImpar As Integer = 0
        While n > 0
            digito.n = n Mod 10
            n = n \ 10
            If digito.Verificar_Par() Then
                par.n = par.n + digito.n * 10 ^ expPar
                expPar = expPar + 1
            Else
                impar.n = impar.n + digito.n * 10 ^ expImpar
                expImpar = expImpar + 1
            End If
        End While
        par.Unir_2Nent(impar)
        n = par.n
    End Sub

    ' Segmentar digitos primos y no primos
    Public Sub Segmentar_Primos_NoPrimos()
        Dim digito As NEnt = New NEnt()
        Dim primo As NEnt = New NEnt()
        Dim noPrimo As NEnt = New NEnt()
        Dim expPrimo As Integer = 0
        Dim expNoPrimo As Integer = 0
        While n > 0
            digito.n = n Mod 10
            n = n \ 10
            If digito.Verificar_Primo() Then
                primo.n = primo.n + digito.n * 10 ^ expPrimo
                expPrimo = expPrimo + 1
            Else
                noPrimo.n = noPrimo.n + digito.n * 10 ^ expNoPrimo
                expNoPrimo = expNoPrimo + 1
            End If
        End While
        primo.Unir_2Nent(noPrimo)
        n = primo.n
    End Sub

    ' Segmentar digitos unicos y digitos no repetidos (ordenados descendentemente)
    Public Sub Segmentar_NoRepetidos_Repetidos()
        Dim digito As Integer
        Dim aux As NEnt = New NEnt()
        Dim repetido As NEnt = New NEnt()
        Dim noRepetido As NEnt = New NEnt()
        aux.n = n
        While n > 0
            digito = n Mod 10
            n = n \ 10
            If aux.Frecuencia_Digito(digito) > 1 Then
                repetido.n = repetido.n * 10 + digito
            Else
                noRepetido.n = noRepetido.n * 10 + digito
            End If
        End While
        repetido.Orden_Descendente()
        noRepetido.Orden_Descendente()
        noRepetido.Unir_2Nent(repetido)
        n = noRepetido.n
    End Sub

    ' Segmentar en digitos repetidos y digitos unicos (mantener orden)
    Public Sub Segmentar_Repetidos_NoRepetidos()
        Dim digito As Integer
        Dim exp1 As Integer = 0
        Dim exp2 As Integer = 0
        Dim repetido As NEnt = New NEnt()
        Dim noRepetido As NEnt = New NEnt()
        Dim aux As NEnt = New NEnt()
        aux.n = n
        While n > 0
            digito = n Mod 10
            n = n \ 10
            If aux.Frecuencia_Digito(digito) = 1 Then
                noRepetido.n = noRepetido.n + digito * 10 ^ exp1
                exp1 = exp1 + 1
            Else
                repetido.n = repetido.n + digito * 10 ^ exp2
                exp2 = exp2 + 1
            End If
        End While
        repetido.Unir_2Nent(noRepetido)
        n = repetido.n
    End Sub

    ' Retornar digito menor par
    Public Function Retornar_Digito_Menor_Par() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim pares As NEnt = New NEnt()
        Dim menor As Integer
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Par() Then
                pares.n = pares.n * 10 + digito.n
            End If
        End While
        menor = pares.Digito_Menor()
        Return menor
    End Function

    ' Retornar digito menor impar
    Public Function Retornar_Digito_Menor_Impar() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim impares As NEnt = New NEnt()
        Dim menor As Integer
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Impar() Then
                impares.n = impares.n * 10 + digito.n
            End If
        End While
        menor = impares.Digito_Menor()
        Return menor
    End Function

    ' Retornar digito mayor par
    Public Function Retornar_Digito_Mayor_Par() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim pares As NEnt = New NEnt()
        Dim mayor As Integer
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Par() Then
                pares.n = pares.n * 10 + digito.n
            End If
        End While
        mayor = pares.Digito_Mayor()
        Return mayor
    End Function

    ' Retornar digito mayor impar
    Public Function Retornar_Digito_Mayor_Impar() As Integer
        Dim digito As NEnt = New NEnt()
        Dim na As Integer = n
        Dim impares As NEnt = New NEnt()
        Dim mayor As Integer
        While na > 0
            digito.n = na Mod 10
            na = na \ 10
            If digito.Verificar_Impar() Then
                impares.n = impares.n * 10 + digito.n
            End If
        End While
        mayor = impares.Digito_Mayor()
        Return mayor
    End Function

    ' Intercalar digitos par y digitos impar
    Public Sub Intercalar_Par_Impar()
        Dim digito As Integer
        Dim resultado As Integer = 0
        Dim b As Boolean = True
        While n > 0
            If b = True Then
                If Verificar_Existe_Par() Then
                    digito = Retornar_Digito_Menor_Par()
                    resultado = resultado * 10 + digito
                    Eliminar_Digito(digito)
                End If
            Else
                If Verificar_Existe_Impar() Then
                    digito = Retornar_Digito_Menor_Impar()
                    resultado = resultado * 10 + digito
                    Eliminar_Digito(digito)
                End If
            End If
            b = Not b
        End While
        n = resultado
    End Sub

    ' Intercalar digitos par y digitos impar Nd
    Public Sub Intercalar_Par_Impar_Nd(nd As Integer)
        Dim par As NEnt = New NEnt()
        Dim impar As NEnt = New NEnt()
        Dim resultado As NEnt = New NEnt()
        Dim b As Boolean = True
        While n > 0
            If b = True Then
                If Verificar_Existe_Par_Nd(nd) Then
                    par.n = Retornar_1erDigito_Par_Nd(nd)
                    resultado.n = resultado.n * 10 ^ par.Cantidad_Digitos() + par.n
                    Eliminar_Digito_Nd(par.n, nd)
                End If
            Else
                If Verificar_Existe_Impar_Nd(nd) Then
                    impar.n = Retornar_1erDigito_Impar_Nd(nd)
                    resultado.n = resultado.n * 10 ^ impar.Cantidad_Digitos() + impar.n
                    Eliminar_Digito_Nd(impar.n, nd)
                End If
            End If
            b = Not b
        End While
        n = resultado.n
    End Sub

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

    ' Intercalar Digito Mayor y Digito Menor
    Public Sub Intercalar_Mayor_Menor()
        Dim digito As Integer
        Dim b As Boolean = True
        Dim resultado As Integer = 0
        While n > 0
            If b = True Then
                digito = Digito_Mayor()
                resultado = resultado * 10 + digito
                Eliminar_Digito(digito)
            Else
                digito = Digito_Menor()
                resultado = resultado * 10 + digito
                Eliminar_Digito(digito)
            End If
            b = Not b
        End While
        n = resultado
    End Sub

    ' Intercalar Digitos Primos y Digitos No Primos
    Public Sub Intercalar_Primo_NoPrimo()
        Dim b As Boolean = True
        Dim primo As Integer
        Dim noPrimo As Integer
        Dim resultado As NEnt = New NEnt()
        While n > 0
            If b = True Then
                If Verificar_Existe_Primo() Then
                    primo = Retornar_1erDigito_Primo()         '223415 -->  n = 513422
                    resultado.n = resultado.n * 10 + primo
                    Eliminar_Digito(primo)
                End If
            Else
                If Verificar_Existe_NoPrimo() Then
                    noPrimo = Retornar_1erDigito_NoPrimo()
                    resultado.n = resultado.n * 10 + noPrimo
                    Eliminar_Digito(noPrimo)
                End If
            End If
                b = Not b
        End While
        n = resultado.n
    End Sub

    ' Encontra el numero de digitos diferentes que tienen frecuencia
    Public Function Numero_Digitos_Frecuencia() As Integer
        Dim digito As Integer
        Dim na As NEnt = New NEnt()
        Dim contador As Integer = 0
        na.n = n
        While na.n > 0
            digito = na.n Mod 10
            If Frecuencia_Digito(digito) > 1 Then
                contador = contador + 1
            End If
            na.Eliminar_Todos_Digitos(digito)
        End While
        Return contador
    End Function

    ' Ordenar los digitos en forma de espiral (de mayor a menor)
    Public Sub Orden_Espiral()
        Dim b As Boolean = True
        Dim digito As Integer
        Dim numIzq As NEnt = New NEnt()
        Dim numDer As NEnt = New NEnt()
        Dim exp As Integer = 0
        While n > 0
            digito = Digito_Mayor()
            Eliminar_Digito(digito)
            If b = True Then
                numIzq.n = numIzq.n * 10 + digito
            Else
                numDer.n = numDer.n + digito * 10 ^ exp
                exp = exp + 1
            End If
            b = Not b
        End While
        numIzq.Unir_2Nent(numDer)
        n = numIzq.n
    End Sub

    ' Unir 3 NE en orden ascendente         N=34   N2{N=123  N3{N=7
    Public Function Unir_3NEnt_Ascendente(n2 As NEnt, n3 As NEnt) As Integer
        Dim mayor, menor, medio As Integer
        Dim resultado As Integer
        Dim auxNent As NEnt = New NEnt()
        Dim na As Integer = n
        If (n > n2.n) And (n > n3.n) Then
            mayor = n
            If (n2.n > n3.n) Then
                medio = n2.n
                menor = n3.n
            Else
                medio = n3.n
                menor = n2.n
            End If
        Else
            If (n2.n > n) And (n2.n > n3.n) Then
                mayor = n2.n
                If (n > n3.n) Then
                    medio = n
                    menor = n3.n
                Else
                    medio = n3.n
                    menor = n
                End If
            Else
                If (n3.n > n) And (n3.n > n2.n) Then
                    mayor = n3.n
                    If (n > n2.n) Then
                        medio = n
                        menor = n2.n
                    Else
                        medio = n2.n
                        menor = n
                    End If
                End If
            End If
        End If
        auxNent.Cargar(medio)
        resultado = menor * 10 ^ auxNent.Cantidad_Digitos() + medio
        auxNent.Cargar(mayor)
        resultado = resultado * 10 ^ auxNent.Cantidad_Digitos() + mayor
        Return resultado
    End Function



End Class
