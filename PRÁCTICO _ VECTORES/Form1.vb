Public Class Form1

    Public v1 As Vector
    Public v2 As Vector
    Public v3 As Vector

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector()
        v2 = New Vector()
        v3 = New Vector()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        v1.Cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        v2.Cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem2.Click
        v3.Cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        Dim i, n As Integer
        n = InputBox(" DIMENSIÓN: ")
        v1 = New Vector()
        For i = 1 To n
            v1.Cargar_Manual(InputBox(" ELEMENTOS: "))
        Next
    End Sub

    Private Sub CargarManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem1.Click
        Dim i, n As Integer
        n = InputBox(" DIMENSIÓN: ")
        v2 = New Vector()
        For i = 1 To n
            v2.Cargar_Manual(InputBox(" ELEMENTOS: "))
        Next
    End Sub

    Private Sub CargarManualToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem2.Click
        Dim i, n As Integer
        n = InputBox(" DIMENSIÓN: ")
        v3 = New Vector()
        For i = 1 To n
            v3.Cargar_Manual(InputBox(" ELEMENTOS: "))
        Next
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        v1.Ejercicio_1(TextBox1.Text, TextBox2.Text)
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        TextBox4.Text = v1.Ejercicio_2()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        TextBox4.Text = v1.Ejercicio_3(TextBox1.Text)
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        v1.Ejercicio_4(v2, v3)
        TextBox5.Text = v2.Descargar()
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        v1.Ejercicio_7(v2, v3)
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        v1.Ejercicio_8(v2, v3)
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        TextBox4.Text = v1.Ejercicio_6()
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        v1.Ejercicio_5()
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        TextBox4.Text = v1.Ejercicio_9(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        TextBox4.Text = v1.Ejercicio_10(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem1.Click
        v2.Ejercicio_11(v3, TextBox1.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem1.Click
        v2.Ejercicio_12(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem1.Click
        v2.Ejercicio_13(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem1.Click
        TextBox5.Text = v2.Ejercicio_14(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem1.Click
        v2.Ejercicio_15(TextBox1.Text, TextBox2.Text, v3)
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem1.Click
        v2.Ejercicio_16(TextBox1.Text, TextBox2.Text, v1, v3)
        TextBox4.Text = v1.Descargar()
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem1.Click
        TextBox5.Text = v2.Ejercicio_17(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem1.Click
        v2.Ejercicio_18(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem1.Click
        v2.Ejercicio_19()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem1.Click
        v2.Ejercicio_20(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub
End Class
