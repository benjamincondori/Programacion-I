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

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        Dim i, n As Integer
        n = InputBox(" DIMENSIÓN: ")
        v1 = New Vector()
        For i = 1 To n
            v1.Cargar_Manual(InputBox(" ELEMENTOS: "))
        Next
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub CargarManualToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim i, n As Integer
        n = InputBox(" DIMENSIÓN: ")
        v2 = New Vector()
        For i = 1 To n
            v2.Cargar_Manual(InputBox(" ELEMENTOS: "))
        Next
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        v3.Cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub CargarManualToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim i, n As Integer
        n = InputBox(" DIMENSIÓN: ")
        v3 = New Vector()
        For i = 1 To n
            v3.Cargar_Manual(InputBox(" ELEMENTOS: "))
        Next
    End Sub

    Private Sub Respuesta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Respuesta1ToolStripMenuItem.Click
        v1.Respuesta_1()
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub Respuesta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Respuesta2ToolStripMenuItem.Click
        TextBox5.Text = v1.Respuesta_2(TextBox1.Text, TextBox2.Text)
    End Sub

End Class
