Public Class Form1

    Public m1 As Matriz         ' m1: es un objeto de tipo matriz
    Public m2 As Matriz         ' m2: es un objeto de tipo matriz
    Public m3 As Matriz         ' m3: es un objeto de tipo matriz

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz()       ' Inicializa el objeto
        m2 = New Matriz()       ' Inicializa el objeto
        m3 = New Matriz()       ' Inicializa el objeto
    End Sub

    Private Sub CargarSecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarSecuenciaToolStripMenuItem.Click
        m1.Cargar_Secuencia(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarSecuenciaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarSecuenciaToolStripMenuItem1.Click
        m2.Cargar_Secuencia(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarSecuenciaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarSecuenciaToolStripMenuItem2.Click
        m3.Cargar_Secuencia(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        m1.Cargar_Random(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarRandomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem1.Click
        m2.Cargar_Random(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarRandomToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem2.Click
        m3.Cargar_Random(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        m1.Cargar_Manual()
    End Sub

    Private Sub CargarManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem1.Click
        m2.Cargar_Manual()
    End Sub

    Private Sub CargarManualToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem2.Click
        m3.Cargar_Manual()
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox5.Text = m1.Descargar()
    End Sub

    Private Sub DesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesToolStripMenuItem.Click
        TextBox6.Text = m2.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox7.Text = m3.Descargar()
    End Sub

    Private Sub BuscarUnElementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarUnElementoToolStripMenuItem.Click
        TextBox5.Text = m1.Existe_Elemento(TextBox1.Text)
    End Sub

    Private Sub Intercambiar2PosicionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Intercambiar2PosicionesToolStripMenuItem.Click
        m1.Intercambiar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub InsertarFilaAlFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarFilaAlFinalToolStripMenuItem.Click
        m1.Insertar_Fila()
    End Sub

    Private Sub InsertarColumnaDeterminadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarColumnaDeterminadaToolStripMenuItem.Click
        m1.Insertar_Columna_Determinada(TextBox1.Text)
    End Sub

    Private Sub InsertarColumnaAlFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarColumnaAlFinalToolStripMenuItem.Click
        m1.Insertar_Columna()
    End Sub

    Private Sub InsertarFilaDeterminadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarFilaDeterminadaToolStripMenuItem.Click
        m1.Insertar_Fila_Determinada(TextBox1.Text)
    End Sub

    Private Sub EliminarFilaDeterminadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarFilaDeterminadaToolStripMenuItem.Click
        m1.Eliminar_Fila_Determinada(TextBox1.Text)
    End Sub

    Private Sub EliminarColumnaDeterminadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarColumnaDeterminadaToolStripMenuItem.Click
        m1.Eliminar_Columna_Determinada(TextBox1.Text)
    End Sub

    Private Sub CopiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarMatrizToolStripMenuItem.Click
        m1.Copiar_Matriz(m2)
    End Sub

    Private Sub OrdenarDiagonalPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDiagonalPrincipalToolStripMenuItem.Click
        m1.Ordenar_Diagonal_Principal()
    End Sub

    Private Sub OrdenarDiagonalSecundariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDiagonalSecundariaToolStripMenuItem.Click
        m1.Ordenar_Diagonal_Secundaria()
    End Sub

    Private Sub OrdenarColumnasDescendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarColumnasDescendentementeToolStripMenuItem.Click
        m1.Ordenar_Columnas_Desc()
    End Sub

    Private Sub OrdenarFilasAscendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarFilasAscendentementeToolStripMenuItem.Click
        m1.Ordenar_Filas_Asc()
    End Sub

    Private Sub OrdenarMatrizAscendentementeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarMatrizAscendentementeToolStripMenuItem.Click
        m1.Ordenar_Asc()
    End Sub

    Private Sub DispersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispersiónToolStripMenuItem.Click
        m1.Dispersion()
    End Sub

    Private Sub FrecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaToolStripMenuItem.Click
        TextBox5.Text = m1.Frecuencia(TextBox1.Text)
    End Sub

    Private Sub SumatoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumatoriaToolStripMenuItem.Click
        TextBox6.Text = m2.Suma_Primo_Const(TextBox1.Text)
    End Sub

    Private Sub PosiciónDelElementoMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PosiciónDelElementoMayorToolStripMenuItem.Click
        TextBox5.Text = m1.Posicion_Elemento_Mayor()
    End Sub

    Private Sub ElementoMásRepetidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementoMásRepetidoToolStripMenuItem.Click
        TextBox5.Text = m1.Elemento_Mas_Repetido()
    End Sub

    Private Sub VerificarOrdenDescendenteSinRigorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarOrdenDescendenteSinRigorToolStripMenuItem.Click
        TextBox7.Text = m3.Verificar_Orden_Desc_Sr()
    End Sub

    Private Sub CantidadDeElementosDiferentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeElementosDiferentesToolStripMenuItem.Click
        TextBox7.Text = m3.Cantidad_Elementos_Diferentes()
    End Sub

    Private Sub VerificarSiExisteUnaMatrizEnOtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSiExisteUnaMatrizEnOtraToolStripMenuItem.Click
        TextBox7.Text = m3.Verificar_Existe_Matriz(m2)
    End Sub

    Private Sub FrecuenciaEnUnSegmentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaEnUnSegmentoToolStripMenuItem.Click
        TextBox7.Text = m3.Frecuencia_Segmento(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox8.Text)
    End Sub

    Private Sub ElementoMásRepetidoEnUnSegmentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementoMásRepetidoEnUnSegmentoToolStripMenuItem.Click
        TextBox7.Text = m3.Elemento_Mas_Repetdio_Segmento(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub FrecuenciaDeLaTriangularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrecuenciaDeLaTriangularToolStripMenuItem.Click
        TextBox7.Text = m3.Frecuencia_Triangular_Superior(TextBox1.Text)
    End Sub

    Private Sub OrdenarTriangularSuperiorPorSuFrecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarTriangularSuperiorPorSuFrecuenciaToolStripMenuItem.Click
        m3.Ordenar_Triangular_Inf_Frec()
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click
        m3.Ordenar_Triangular_Sup_Columnas()
    End Sub

    Private Sub CantidadDeElementosDiferentesEnUnaFilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeElementosDiferentesEnUnaFilaToolStripMenuItem.Click
        TextBox7.Text = m3.Elementos_Diferentes_Fila(TextBox1.Text)
    End Sub

    Private Sub CantidadDeElementosDiferentesEnUnaFilaAumentandoUnaColumnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeElementosDiferentesEnUnaFilaAumentandoUnaColumnaToolStripMenuItem.Click
        m3.Elementos_Diferentes_Final_Col()
    End Sub

    Private Sub SegmentarEnParesEImparesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarEnParesEImparesToolStripMenuItem.Click
        m2.Segmentar_Filas_Par_Impar()
    End Sub

    Private Sub SegmentarColumnasEnPrimosYNoPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarColumnasEnPrimosYNoPrimosToolStripMenuItem.Click
        m2.Segmentar_Columnas_Primo_NoPrimo()
    End Sub

    Private Sub SegmentarPorFrecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarPorFrecuenciaToolStripMenuItem.Click
        m2.Segmentar_Por_Frecuencia()
    End Sub

    Private Sub IntercalarEnPrimosYNoPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarEnPrimosYNoPrimosToolStripMenuItem.Click
        m2.Intercalar_Columnas_Primo_NoPrimo()
    End Sub

    Private Sub IntercalarFilasEnFibonacciYNoFibonacciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarFilasEnFibonacciYNoFibonacciToolStripMenuItem.Click
        m2.Intercalar_Filas_Fibonacci_NoFibonacci()
    End Sub

    Private Sub IntercalarMúltiplosYNoMúltiplosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarMúltiplosYNoMúltiplosToolStripMenuItem.Click
        m2.Intercalar_Multiplos_NoMultiplos(TextBox1.Text)
    End Sub

    Private Sub TraspuestaDeUnaMatrizCuadradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraspuestaDeUnaMatrizCuadradaToolStripMenuItem.Click
        m2.Traspuesta_Matriz_Cuadrada()
    End Sub

    Private Sub TraspuestaDeUnaMatrizNoCuadradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraspuestaDeUnaMatrizNoCuadradaToolStripMenuItem.Click
        m2.Traspuesta_Matriz_No_Cuadrada(m3)
    End Sub

    Private Sub DeterminanteDeUnaMatriz2x2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeterminanteDeUnaMatriz2x2ToolStripMenuItem.Click
        TextBox6.Text = m2.Determinante_Matriz_2x2()
    End Sub

    Private Sub DeterminanteDeUnaMatriz3x3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeterminanteDeUnaMatriz3x3ToolStripMenuItem.Click
        TextBox6.Text = m2.Determinante_Matriz_3x3()
    End Sub

    Private Sub SumaDe2MatricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDe2MatricesToolStripMenuItem.Click
        m2.Suma_Matrices(m1, m3)
    End Sub

    Private Sub RestaDe2MatricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaDe2MatricesToolStripMenuItem.Click
        m2.Resta_Matrices(m1, m3)
    End Sub

    Private Sub MultiplicaciónDe2MatricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicaciónDe2MatricesToolStripMenuItem.Click
        m2.Multiplicacion_Matrices(m1, m3)
    End Sub

    Private Sub DivisiónDeUnaMatrizPorUnEscalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisiónDeUnaMatrizPorUnEscalarToolStripMenuItem.Click
        m2.Division_Escalar(TextBox1.Text)
    End Sub

    Private Sub Ejercicio12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio12ToolStripMenuItem.Click
        m3.ejer_12()
    End Sub

    Private Sub IntercalarColumnasEnFibonacciYNoFibonacciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarColumnasEnFibonacciYNoFibonacciToolStripMenuItem.Click
        m2.Intercalar_Columnas_Fibonacci_NoFibonacci()
    End Sub
End Class
