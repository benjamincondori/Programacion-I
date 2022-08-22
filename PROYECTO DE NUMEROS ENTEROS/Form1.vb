Public Class Form1

    Public n1 As NEnt       ' n1: es un objeto de tipo NEnt
    Public n2 As NEnt       ' n2: es un objeto de tipo NEnt
    Public n3 As NEnt       ' n3: es un objeto de tipo NEnt
    Public n4 As NEnt       ' n4: es un objeto de tipo NEnt

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt()
        n2 = New NEnt()
        n3 = New NEnt()
        n4 = New NEnt()
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n2.Cargar(TextBox1.Text)
    End Sub

    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem2.Click
        n3.Cargar(TextBox1.Text)
    End Sub

    Private Sub CargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem3.Click
        n4.Cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox3.Text = n1.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem3.Click
        TextBox3.Text = n4.Descargar()
    End Sub

    Private Sub VerificarParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarParToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Par()
    End Sub

    Private Sub VerificarImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarImparToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Impar()
    End Sub

    Private Sub VerificarTodosSonParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarTodosSonParToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Pares()
    End Sub

    Private Sub VerificarTodosSonImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarTodosSonImparToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Impares()
    End Sub

    Private Sub VerificarPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarPrimoToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Primo()
    End Sub

    Private Sub VerificarNoPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarNoPrimoToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_NoPrimo()
    End Sub

    Private Sub VerificarExistePrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarExistePrimoToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Existe_Primo()
    End Sub

    Private Sub VerificarPerteneceFibonacciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarPerteneceFibonacciToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Pertenece_Fibonacci()
    End Sub

    Private Sub VerificarOrdenAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarOrdenAscendenteToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Orden_Ascendente()
    End Sub

    Private Sub VerificarOrdenDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarOrdenDescendenteToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Orden_Descendente()
    End Sub

    Private Sub VerificarTodosDigitosIgualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarTodosDigitosIgualesToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Digitos_Iguales()
    End Sub

    Private Sub VerificarBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarBaseToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Base(TextBox1.Text)
    End Sub

    Private Sub VerificarMultiploDeUnNumeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarMultiploDeUnNumeroToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Multiplo(TextBox1.Text)
    End Sub

    Private Sub VerificarExisteDigitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarExisteDigitoToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Existe_Digito(TextBox1.Text)
    End Sub

    Private Sub VerificarExisteParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarExisteParToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Existe_Par()
    End Sub

    Private Sub VerificarExisteImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarExisteImparToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Existe_Impar()
    End Sub

    Private Sub VerificarSeRepiteDigitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSeRepiteDigitoToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_SeRepite(TextBox1.Text)
    End Sub

    Private Sub VerificarCapicuaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarCapicuaToolStripMenuItem.Click
        TextBox3.Text = n1.Verificar_Capicua()
    End Sub

    Private Sub InvertirNumeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirNumeroToolStripMenuItem.Click
        n2.Invertir()
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub MantenerOrdenDelNumeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenerOrdenDelNumeroToolStripMenuItem.Click
        n2.Mantener_Orden()
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub Unir2NumerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Unir2NumerosToolStripMenuItem.Click
        n2.Unir_2Nent(n1)
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub DigitoMenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitoMenorToolStripMenuItem.Click
        TextBox3.Text = n2.Digito_Menor()
    End Sub

    Private Sub DigitoMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitoMayorToolStripMenuItem.Click
        TextBox3.Text = n2.Digito_Mayor()
    End Sub

    Private Sub FrecuenciaDeUnDigitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaDeUnDigitoToolStripMenuItem.Click
        TextBox3.Text = n2.Frecuencia_Digito(TextBox1.Text)
    End Sub

    Private Sub EliminarTodosLosDigitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTodosLosDigitosToolStripMenuItem.Click
        n2.Eliminar_Todos_Digitos(TextBox1.Text)
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub EliminarDigitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDigitoToolStripMenuItem.Click
        n2.Eliminar_Digito(TextBox1.Text)
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click
        n2.Orden_Ascendente()
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub OrdenDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDescendenteToolStripMenuItem.Click
        n2.Orden_Descendente()
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub OrdenDescendeteANdigsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDescendeteANdigsToolStripMenuItem.Click
        n2.Orden_Ascendente_Nd(TextBox1.Text)
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub PurgarDigitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurgarDigitosToolStripMenuItem.Click
        n2.Purgar_Digitos()
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub EliminarTodosLosDigitosRepetidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTodosLosDigitosRepetidosToolStripMenuItem.Click
        n2.Eliminar_Digitos_Repetidos()
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub EliminarDigitosNoRepetidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDigitosNoRepetidosToolStripMenuItem.Click
        n2.Eliminar_Digitos_NoRepetidos()
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        TextBox3.Text = n2.Cantidad_Digitos()
    End Sub

    Private Sub CantidadDeNumerosRepetidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeNumerosRepetidosToolStripMenuItem.Click
        TextBox3.Text = n2.Cantidad_Digitos_Repetidos()
    End Sub

    Private Sub TransformarBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransformarBaseToolStripMenuItem.Click
        TextBox3.Text = n3.Transformar_Base(TextBox1.Text)
    End Sub

    Private Sub FcatorialDeUnNumeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FcatorialDeUnNumeroToolStripMenuItem.Click
        TextBox3.Text = n2.Factorial()
    End Sub

    Private Sub Retornar1erDigitoParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Retornar1erDigitoParToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_1erDigito_Par()
    End Sub

    Private Sub RetornarDigitosParesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitosParesToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_Digitos_Pares()
    End Sub

    Private Sub Retornar1erDigitoImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Retornar1erDigitoImparToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_1erDigito_Impar()
    End Sub

    Private Sub RetornarDigitosImparesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitosImparesToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_Digitos_Impares()
    End Sub

    Private Sub RetornarDigitoMenorParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitoMenorParToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_Digito_Menor_Par()
    End Sub

    Private Sub SegmentarRepetidosYNoRepetidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarRepetidosYNoRepetidosToolStripMenuItem.Click
        n3.Segmentar_Repetidos_NoRepetidos()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub SegmentarParEImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarParEImparToolStripMenuItem.Click
        n3.Segmentar_Par_Impar()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub SegmentarPrimoYNoPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarPrimoYNoPrimoToolStripMenuItem.Click
        n3.Segmentar_Primos_NoPrimos()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub SegmentarNoRepetidosYRepetidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarNoRepetidosYRepetidosToolStripMenuItem.Click
        n3.Segmentar_NoRepetidos_Repetidos()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub RetornarDigitoMayorParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitoMayorParToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_Digito_Mayor_Par()
    End Sub

    Private Sub IntercalarParEImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarParEImparToolStripMenuItem.Click
        n3.Intercalar_Par_Impar()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub IntercalarMayorYMenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarMayorYMenorToolStripMenuItem.Click
        n3.Intercalar_Mayor_Menor()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub IntercalarParEImparANdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarParEImparANdToolStripMenuItem.Click
        n3.Intercalar_Par_Impar_Nd(TextBox1.Text)
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub NumeroDeDigitosConFrecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeroDeDigitosConFrecuenciaToolStripMenuItem.Click
        TextBox3.Text = n3.Numero_Digitos_Frecuencia()
    End Sub

    Private Sub OrdenarEnFormaDeEspiralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarEnFormaDeEspiralToolStripMenuItem.Click
        n3.Orden_Espiral()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub RetornarDigitoPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitoPrimoToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_1erDigito_Primo()
    End Sub

    Private Sub RetornarDigitosPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetornarDigitosPrimosToolStripMenuItem.Click
        TextBox3.Text = n3.Retornar_Digitos_Primos()
    End Sub

    Private Sub IntercalarPrimosYNoPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarPrimosYNoPrimosToolStripMenuItem.Click
        n3.Intercalar_Primo_NoPrimo()
        TextBox3.Text = n3.Descargar()
    End Sub

    Private Sub OrdenDescendenteANdigsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDescendenteANdigsToolStripMenuItem.Click
        n2.Orden_Descendente_Nd(TextBox1.Text)
        TextBox3.Text = n2.Descargar()
    End Sub

    Private Sub Unir3NumerosEnterosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Unir3NumerosEnterosToolStripMenuItem.Click
        TextBox3.Text = n3.Unir_3NEnt_Ascendente(n1, n2)
    End Sub

    Private Sub VerificarSiEsPokerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiEsPokerToolStripMenuItem.Click
        TextBox3.Text = n4.Verificar_Poker()
    End Sub

    Private Sub VerificarSiEsFullToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiEsFullToolStripMenuItem.Click
        TextBox3.Text = n4.Verificar_Full()
    End Sub

    Private Sub VerificarSiHay1ParToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiHay1ParToolStripMenuItem.Click
        TextBox3.Text = n4.Verificar_1_Par()
    End Sub

    Private Sub VerificarSiHay2ParesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiHay2ParesToolStripMenuItem.Click
        TextBox3.Text = n4.Verificar_2_Pares()
    End Sub

    Private Sub VerificarSiEsTricaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiEsTricaToolStripMenuItem.Click
        TextBox3.Text = n4.Verificar_Trica()
    End Sub

    Private Sub VerificarSiEsEscaleraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiEsEscaleraToolStripMenuItem.Click
        TextBox3.Text = n4.Verificar_Escalera()
    End Sub
End Class
