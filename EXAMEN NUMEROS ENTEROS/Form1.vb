Public Class Form1

    Public n1 As NEnt

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub Respuesta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Respuesta1ToolStripMenuItem.Click
        n1.Respuesta_1(TextBox1.Text)
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub Respuesta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Respuesta2ToolStripMenuItem.Click
        TextBox2.Text = n1.Respuesta_2()
    End Sub
End Class
