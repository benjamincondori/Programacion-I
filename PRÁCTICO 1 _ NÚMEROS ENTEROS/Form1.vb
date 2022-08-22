Public Class Form1

    Public n1 As NEnt
    Public n2 As NEnt
    Public n3 As NEnt

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt()
        n2 = New NEnt()
        n3 = New NEnt()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        n2.Cargar(TextBox1.Text)
    End Sub

    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem2.Click
        n3.Cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox2.Text = n3.Descargar()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_1()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_2()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_3()
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_4(TextBox1.Text)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_5(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_6(TextBox1.Text)
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_7(n2)
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_8(n2, n3)
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_9(n2, n3)
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        TextBox2.Text = n1.Ejercicio_10(TextBox1.Text)
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem1.Click
        TextBox2.Text = n2.Ejercicio_11()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem1.Click
        n2.Ejercicio_12()
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem1.Click
        n2.Ejercicio_13(TextBox1.Text)
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem1.Click
        n2.Ejercicio_14(n1, n3)
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem1.Click
        n2.Ejercicio_15(TextBox1.Text)
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem1.Click
        TextBox2.Text = n2.Ejercicio_16(n1, n3)
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem1.Click
        n2.Ejercicio_17(n1, n3)
        TextBox2.Text = n1.Descargar()
        TextBox4.Text = n3.Descargar()
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem1.Click
        TextBox2.Text = n2.Ejercicio_18()
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem1.Click
        TextBox2.Text = n2.Ejercicio_19()
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem1.Click
        TextBox2.Text = n2.Ejercicio_20()
    End Sub


End Class
