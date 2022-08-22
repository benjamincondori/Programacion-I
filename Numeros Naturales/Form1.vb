Public Class Form1
    Dim n1 As NEntero


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEntero
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n1.Cargar(txtEntradaN1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSalida.Text = n1.Descargar
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        txtSalida.Text = n1.pra1_ejercicio1()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        txtSalida.Text = n1.pra1_ejercicio2()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        txtSalida.Text = n1.pra1_ejercicio3()
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        Dim m As Integer = InputBox("Ingrese m", "")

        txtSalida.Text = n1.pra1_ejercicio4(m)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        Dim vi As Integer = InputBox("Ingrese valor inicial", "")
        Dim r As Integer = InputBox("Ingrese la razon", "")
        txtSalida.Text = n1.pra1_ejercicio5(vi, r)
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        Dim nd As Integer = InputBox("cantidad de digitos", "")
        txtSalida.Text = n1.pra1_ejercicio6(nd)
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        Dim n2 As NEntero = New NEntero
        n2.Cargar(txtEntradaN2.Text)
        txtSalida.Text = n1.pra1_ejercicio7(n2)
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        Dim n2 As NEntero = New NEntero
        Dim n3 As NEntero = New NEntero
        n2.Cargar(txtEntradaN2.Text)
        n3.Cargar(txtEntradaN3.Text)
        txtSalida.Text = n1.pra1_ejercicio8(n2, n3)
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        Dim n2 As NEntero = New NEntero
        Dim n3 As NEntero = New NEntero
        n2.Cargar(txtEntradaN2.Text)
        n3.Cargar(txtEntradaN3.Text)
        txtSalida.Text = n1.pra1_ejercicio9(n2, n3)
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        Dim b As Integer = InputBox("Ingrese base", "")
        txtSalida.Text = n1.pra1_ejercicio10(b)
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem1.Click
        n1.pra2_ejercicio1()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem1.Click
        n1.pra2_ejercicio2()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem1.Click
        Dim nd As Integer = InputBox("cantidad de digitos", "")
        n1.pra2_ejercicio3(nd)
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem1.Click
        Dim n2 As NEntero = New NEntero
        Dim n3 As NEntero = New NEntero
        n2.Cargar(txtEntradaN2.Text)
        n3.Cargar(txtEntradaN3.Text)
        n1.pra2_ejercicio4(n2, n3)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem1.Click
        Dim nd As Integer = InputBox("cantidad de digitos", "")
        n1.pra2_ejercicio5(nd)
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem1.Click

        Dim n2 As NEntero = New NEntero
        Dim n3 As NEntero = New NEntero

        n2.Cargar(txtEntradaN2.Text)
        n3.Cargar(txtEntradaN3.Text)
        n1.pra2_ejercicio6(n2, n3)

    End Sub

    Private Sub Ejercicio7ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem1.Click
        Dim n2 As NEntero = New NEntero
        Dim n3 As NEntero = New NEntero
        n1.pra2_ejercicio7(n2, n3)
        txtEntradaN2.Text = n2.Descargar
        txtEntradaN3.Text = n3.Descargar
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem1.Click
        If n1.pra2_ejercicio8() Then
            txtSalida.Text = "ES TRICA"
        Else
            txtSalida.Text = "NO ES TRICA"
        End If
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem2.Click
        If n1.pra2_ejercicio9() Then
            txtSalida.Text = "HAY 2 PARES"
        Else
            txtSalida.Text = "NO HAY 2 PARES"
        End If
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem1.Click
        If n1.pra2_ejercicio10() Then
            txtSalida.Text = "ES FULL"
        Else
            txtSalida.Text = "NO ES FULL"
        End If
    End Sub
End Class
