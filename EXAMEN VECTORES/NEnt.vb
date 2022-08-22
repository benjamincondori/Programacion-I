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

    Public Function Verificar_Submultiplo(numero As Integer) As Boolean
        Dim na As Integer = n
        Return (numero Mod na = 0)
    End Function

    Public Function Verificar_Multiplo(numero As Integer) As Boolean
        Dim na As Integer = n
        Return (na Mod numero = 0)
    End Function

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

    Public Function Verificar_Capicua() As Boolean
        Dim na As Integer = n
        Me.Invertir()
        Return n = na
    End Function

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

    Public Function Verificar_Par() As Boolean
        Return n Mod 2 = 0
    End Function

    Public Function Verificar_Impar() As Boolean
        Return Not (n Mod 2 = 0)
    End Function

End Class
