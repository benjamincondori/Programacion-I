Public Class Vector

    Const MAX = 100
    Private v(MAX) As Integer
    Private n As Integer

    Public Sub vector()
        n = 0
    End Sub

    Public Function Descargar() As String
        Dim result As String = " "
        Dim i As Integer
        For i = 1 To n
            result = result + Str(v(i)) + ";"
        Next
        Return result
    End Function

    Public Sub Insertar_Elemento_Final(elemento As Integer)
        n = n + 1
        v(n) = elemento
    End Sub

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


End Class
