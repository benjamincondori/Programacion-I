Public Class Matriz

    Const MAXF = 100
    Const MAXC = 100
    Private m(MAXF, MAXC) As Integer
    Private f, c As Integer

    Public Sub Matriz()
        f = 0
        c = 0
    End Sub

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

    Public Sub Respuesta_1()
        Dim i As Integer
        For cp = 1 To c
            For fp = f To 1 Step -1
                For cd = cp To f
                    If cd = cp Then
                        i = fp
                    Else
                        i = f
                    End If
                    For fd = i To 1 Step -1
                        If Frecuencia(m(fp, cp)) = 1 And Frecuencia(m(fd, cd)) > 1 Or
                            Frecuencia(m(fp, cp)) > 1 And Frecuencia(m(fd, cd)) > 1 And m(fp, cp) > m(fd, cd) Or
                            Frecuencia(m(fp, cp)) = 1 And Frecuencia(m(fd, cd)) = 1 And m(fp, cp) > m(fd, cd) Then
                            Intercambiar(fp, cp, fd, cd)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

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

    Public Sub Intercambiar(f1 As Integer, c1 As Integer, f2 As Integer, c2 As Integer)
        Dim aux As Integer
        aux = m(f1, c1)
        m(f1, c1) = m(f2, c2)
        m(f2, c2) = aux
    End Sub

    Public Sub Respuesta_2(nc As Integer)
        For fi = 1 To f - 1
            For fj = fi + 1 To f
                If m(fi, nc) > m(fj, nc) Then
                    Intercambiar_Filas(fi, fj)
                End If
            Next
        Next
    End Sub

    Public Sub Intercambiar_Filas(f1 As Integer, f2 As Integer)
        For ci = 1 To c
            Intercambiar(f1, ci, f2, ci)
        Next
    End Sub


End Class
