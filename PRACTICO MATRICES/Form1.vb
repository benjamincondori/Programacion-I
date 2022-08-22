Public Class Form1

    Public m1 As Matriz
    Public m2 As Matriz

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz()
        m2 = New Matriz()
    End Sub

    Private Sub CargarSecuenciaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarSecuenciaToolStripMenuItem1.Click
        m1.Cargar_Secuencia(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox5.Text = m1.Descargar()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub CargarRandomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem1.Click
        m1.Cargar_Random(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox5.Text = m1.Descargar()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub CargarManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem1.Click
        m1.Cargar_Manual()
        TextBox5.Text = m1.Descargar()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox5.Text = m1.Descargar()
    End Sub

    Private Sub CargarSecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarSecuenciaToolStripMenuItem.Click
        m2.Cargar_Secuencia(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = m2.Descargar()
        TextBox7.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        m2.Cargar_Random(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = m2.Descargar()
        TextBox7.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        m2.Cargar_Manual()
        TextBox6.Text = m2.Descargar()
        TextBox7.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox6.Text = m2.Descargar()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        TextBox7.Text = m1.Ejercicio_1()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        TextBox7.Text = m1.Ejercicio_2()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        m1.Ejercicio_3()
        TextBox9.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        m1.Ejercicio_4()
        TextBox9.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        m1.Ejercicio_5()
        TextBox9.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        m1.Ejercicio_6(TextBox8.Text)
        TextBox9.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        TextBox7.Text = m1.Ejercicio_7()
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        TextBox7.Text = m1.Ejercicio_8()
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        TextBox7.Text = m1.Ejercicio_9(m2)
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        m1.Ejercicio_10()
        TextBox9.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio11ToolStripMenuItem.Click
        m1.Ejercicio_11()
        TextBox9.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio12ToolStripMenuItem.Click
        m1.Ejercicio_12()
        TextBox9.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio13ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio13ToolStripMenuItem.Click
        m1.Ejercicio_13()
        TextBox9.Text = m1.Descargar()
    End Sub
End Class
