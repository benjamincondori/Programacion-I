Public Class Form1

    Public n1 As NEnt       ' n1: Es un objeto de tipo NEnt
    Public n2 As NEnt
    Public n3 As NEnt

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt()     ' n1     Inicia el objeto
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

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox2.Text = n3.Descagar()
    End Sub
    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descagar()
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox2.Text = n2.Descagar()
    End Sub

    Private Sub FactorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FactorialToolStripMenuItem.Click
        TextBox2.Text = n1.Factorial()
    End Sub

    Private Sub VerificarParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarParToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarPar()
    End Sub

    Private Sub VerificarImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarImparToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarImpar()
    End Sub

    Private Sub VerificarPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarPrimoToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarPrimo()
    End Sub

    Private Sub VerificarPrimoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerificarPrimoToolStripMenuItem1.Click
        TextBox2.Text = n1.VerificarPrimo1()
    End Sub

    Private Sub VerificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarPerteneceSerieExp(n2)
    End Sub

    Private Sub VerificarMúltiploToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarMúltiploToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarMultiplo(n2)
    End Sub

    Private Sub VerificarMúltiploToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerificarMúltiploToolStripMenuItem1.Click
        TextBox2.Text = n1.VerificarMultiplo1(n2)
    End Sub

    Private Sub VerificarPerteceneFibonacciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarPerteceneFibonacciToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarPerteneceFibonacci()
    End Sub

    Private Sub SumarDigitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumarDigitosToolStripMenuItem.Click
        TextBox2.Text = n1.SumarDigitos(TextBox1.Text)
    End Sub

    Private Sub SumarDigitosPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumarDigitosPrimosToolStripMenuItem.Click
        TextBox2.Text = n1.SumarDigitosPrimos(TextBox1.Text)
    End Sub

    Private Sub ConvertirADecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertirADecimalToolStripMenuItem.Click
        TextBox2.Text = n1.ConvertirADecimal(TextBox1.Text)
    End Sub

    Private Sub BuscarDigitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDigitoToolStripMenuItem.Click
        TextBox2.Text = n2.BuscarDigito(TextBox1.Text)
    End Sub

    Private Sub BuscarDigitoPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDigitoPrimoToolStripMenuItem.Click
        TextBox2.Text = n2.BuscarDigitoPrimo()
    End Sub

    Private Sub VerificarDigitosIgualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarDigitosIgualesToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarDigitosIguales()
    End Sub

    Private Sub LanzarDadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanzarDadoToolStripMenuItem.Click
        n2.LanzarDados()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n2.LanzarDados()
        TextBox2.Text = n2.Descagar()
    End Sub

    Private Sub VerificarDigitosParesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarDigitosParesToolStripMenuItem.Click
        TextBox2.Text = n2.VerificarDigitosPares()
    End Sub

    Private Sub SegmentarParEImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarParEImparToolStripMenuItem.Click
        n2.SegmentarParImpar()
    End Sub

    Private Sub EliminarDigitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDigitosToolStripMenuItem.Click
        TextBox2.Text = n2.Eliminar_Digito(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub DigitoMenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitoMenorToolStripMenuItem.Click
        TextBox2.Text = n3.DigMenor(TextBox1.Text)
    End Sub

    Private Sub RetornarDigitoParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitoParToolStripMenuItem.Click
        TextBox2.Text = n3.Retornar_DigPar(TextBox1.Text)
    End Sub

    Private Sub RetornarDigitoImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitoImparToolStripMenuItem.Click
        TextBox2.Text = n3.Retornar_DigImpar(TextBox1.Text)
    End Sub

    Private Sub EliminarUnDigitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUnDigitoToolStripMenuItem.Click
        n3.EliminarDigito(TextBox1.Text, TextBox3.Text)
        TextBox2.Text = n3.Descagar()
    End Sub

    Private Sub BuscarDigitoParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDigitoParToolStripMenuItem.Click
        TextBox2.Text = n3.Buscar_DigPar(TextBox1.Text)
    End Sub

    Private Sub DigitoMenorParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitoMenorParToolStripMenuItem.Click
        TextBox2.Text = n3.DigMenorPar(TextBox1.Text)
    End Sub
End Class
