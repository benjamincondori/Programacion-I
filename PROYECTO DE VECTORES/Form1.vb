Public Class Form1

    Public v1 As Vector         ' v1: es un objeto de tipo Vector
    Public v2 As Vector         ' v2: es un objeto de tipo Vector
    Public v3 As Vector         ' v3: es un objeto de tipo Vector
    Public v4 As Vector         ' v4: es un objeto de tipo Vector

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector()       ' Inicializa el objeto
        v2 = New Vector()       ' Inicializa el objeto
        v3 = New Vector()       ' Inicializa el objeto
        v4 = New Vector()       ' Inicializa el objeto
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

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox6.Text = v3.Descargar()
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

    Private Sub CargarFibonacciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarFibonacciToolStripMenuItem.Click
        v1.Cargar_Fibonacci(TextBox1.Text)
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub InsertarElementoAlFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarElementoAlFinalToolStripMenuItem.Click
        v2.Insertar_Elemento_Final(TextBox1.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub ReemplazarElementoPorOtroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReemplazarElementoPorOtroToolStripMenuItem.Click
        v2.Reemplazar_Elemento(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub InsertarElementoEnUnaPosiciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarElementoEnUnaPosiciónToolStripMenuItem.Click
        v2.Insertar_Elemento_Posicion(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub Intercambiar2ElementosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Intercambiar2ElementosToolStripMenuItem.Click
        v2.Intercambiar(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub InsertarUnVectorEnOtroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarUnVectorEnOtroToolStripMenuItem.Click
        v2.Insertar_Vector_Posicion(v3, TextBox1.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub EliminarPosiciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPosiciónToolStripMenuItem.Click
        v2.Eliminar_Posicion(TextBox1.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub EliminarElementosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarElementosToolStripMenuItem.Click
        v2.Eliminar_Elementos(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub EliminarUnElementoDeTodoElVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUnElementoDeTodoElVectorToolStripMenuItem.Click
        v2.Eliminar_Elemento(TextBox1.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub OrdenarAscendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendentementeToolStripMenuItem.Click
        v2.Ordenar_Ascendentemente()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub OrdenarSegmentoAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarSegmentoAscendenteToolStripMenuItem.Click
        v2.Ordenar_Segmento_Descendente(TextBox1.Text, TextBox2.Text)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub OrdenarAscendenteYDescenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteYDescenteToolStripMenuItem.Click
        v2.Ordenar_Ascendente_Descendente()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub DispersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispersiónToolStripMenuItem.Click
        v2.Dispersion()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub PurgarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurgarToolStripMenuItem.Click
        v2.Purgar()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub BusquedaBinariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaBinariaToolStripMenuItem.Click
        TextBox5.Text = v2.Busqueda_Binaria(TextBox1.Text)
    End Sub

    Private Sub PromedioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromedioToolStripMenuItem.Click
        TextBox4.Text = v1.Promedio()
    End Sub

    Private Sub GenerarNúmerosPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarNúmerosPrimosToolStripMenuItem.Click
        v1.Mostrar_Primos(TextBox1.Text)
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub FrecuenciaDeUnElementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaDeUnElementoToolStripMenuItem.Click
        TextBox4.Text = v1.Frecuencia(TextBox1.Text)
    End Sub

    Private Sub ExisteElementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExisteElementoToolStripMenuItem.Click
        TextBox4.Text = v1.Existe_Elemento(TextBox1.Text)
    End Sub

    Private Sub InvertirVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirVectorToolStripMenuItem.Click
        v2.Invertir()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub VerificarSiExisteVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiExisteVectorToolStripMenuItem.Click
        TextBox4.Text = v1.Verificar_Existe_Vector(v2)
    End Sub

    Private Sub ContadorElementosDiferentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContadorElementosDiferentesToolStripMenuItem.Click
        TextBox4.Text = v1.Contar_Elementos_Diferentes()
    End Sub

    Private Sub SelecionarFibonacciDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarFibonacciDescendenteToolStripMenuItem.Click
        v1.Selecionar_Fibonacci_Descendente(v2)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub OrdenarMultiplosAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarMultiplosAscendenteToolStripMenuItem.Click
        v3.Ordenar_Multiplos_Ascendente(TextBox1.Text)
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub ElementoMásRepetidoEnSegmentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementoMásRepetidoEnSegmentoToolStripMenuItem.Click
        TextBox6.Text = v3.Elemento_Mas_Repetido_Seg(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub FrecuenciaDeDistribuciónDeRepetidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaDeDistribuciónDeRepetidosToolStripMenuItem.Click
        v3.Frecuencia_Distribucion_Repetidos(TextBox1.Text, TextBox2.Text, v1, v2)
        TextBox4.Text = v1.Descargar()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub CargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem3.Click
        v4.Cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem3.Click
        TextBox7.Text = v4.Descargar()
    End Sub

    Private Sub CargarManualToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem3.Click
        Dim i, n As Integer
        n = InputBox(" DIMENSIÓN: ")
        v4 = New Vector()
        For i = 1 To n
            v4.Cargar_Manual(InputBox(" ELEMENTOS: "))
        Next
    End Sub

    Private Sub FrecuenciaDistribuciónEnRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaDistribuciónEnRangoToolStripMenuItem.Click
        v4.Frecuencia_Distribucion_Rango(TextBox1.Text, TextBox2.Text, TextBox3.Text, v1, v2, v3)
        TextBox4.Text = v1.Descargar()
        TextBox5.Text = v2.Descargar()
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub SegmentarParEImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarParEImparToolStripMenuItem.Click
        v4.Segmentar_Par_Impar()
        TextBox7.Text = v4.Descargar()
    End Sub

    Private Sub SegmentarNoRepetidosYRepetidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarNoRepetidosYRepetidosToolStripMenuItem.Click
        v4.Segmentar_NoRepetido_Repetido(TextBox1.Text, TextBox2.Text)
        TextBox7.Text = v4.Descargar()
    End Sub

    Private Sub IntercalarPrimosYNoPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarPrimosYNoPrimosToolStripMenuItem.Click
        v4.Intercalar_Primos_NoPrimos_Desc()
        TextBox7.Text = v4.Descargar()
    End Sub

    Private Sub IntercalarMultiplosYNoMultiplosDeMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarMultiplosYNoMultiplosDeMToolStripMenuItem.Click
        v4.Intercalar_Multiplo_NoMultiplo(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox7.Text = v4.Descargar()
    End Sub

    Private Sub PurgarElementosEntreAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurgarElementosEntreAYBToolStripMenuItem.Click
        v4.Purgar_Con_Rango(TextBox1.Text, TextBox2.Text, v3)
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub DiferenciaSimétricaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiferenciaSimétricaToolStripMenuItem.Click
        v4.Diferencia_Simetrica(v3, v2)
        TextBox6.Text = v3.Descargar()
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub EliminarElementosRepetidosContinuosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarElementosRepetidosContinuosToolStripMenuItem.Click
        v3.Respuesta_1()
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub ElementoDeMayorFrecuenciaEntreAYBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementoDeMayorFrecuenciaEntreAYBToolStripMenuItem.Click
        TextBox6.Text = v3.Respuesta_2(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
