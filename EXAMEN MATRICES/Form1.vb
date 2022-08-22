Public Class Form1

    Public m1 As Matriz
    Public m2 As Matriz

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz()
        m2 = New Matriz()
    End Sub

    Private Sub CargarSecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarSecuenciaToolStripMenuItem.Click
        m1.Cargar_Secuencia(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox5.Text = m1.Descargar()
        TextBox6.Text = ""
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        m1.Cargar_Manual()
        TextBox5.Text = m1.Descargar()
        TextBox6.Text = ""
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        m1.Cargar_Random(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox5.Text = m1.Descargar()
        TextBox6.Text = ""
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox5.Text = m1.Descargar()
    End Sub

    Private Sub Respuesta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Respuesta1ToolStripMenuItem.Click
        m1.Respuesta_1()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub Respuesta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Respuesta2ToolStripMenuItem.Click
        m1.Respuesta_2(TextBox7.Text)
        TextBox6.Text = m1.Descargar()
    End Sub
End Class
