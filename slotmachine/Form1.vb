Public Class Form1
    Dim tiempo, tiempo2, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, ensayo As Integer
    Dim creditos As Integer = 10000 ' Numero de creditos asignados
    Dim numero_ensayos As Integer
    Dim apuesta_cr As Integer
    Dim premio1, premio2, premio3, premio4, premio5, premio6 As Integer
    Dim startTEC As DateTime
    Dim stopTEC As DateTime
    Dim IEC As TimeSpan
    Dim ensayoGoP As String = ""
    ' Ruta a imagen de cada símbolo y fondo
    Dim cherries As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\cherries.png"
    Dim corona As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\corona.png"
    Dim diamante As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\diamante.png"
    Dim fresa As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\fresa.png"
    Dim lima As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\lima.png"
    Dim manzana As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\manzana.png"
    Dim naranja As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\naranja.png"
    Dim platanos As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\platanos.png"
    Dim sandia As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\sandia.png"
    Dim siete As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\siete.png"
    Dim trebol As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\trebol.png"
    Dim uva As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\uva.png"
    Dim fondoMP As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\fondoSlot_FruitFrenzy_1cr.png"
    Dim fondoMG As String = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14\Imagenes\fondoSlot_FruitFrenzy_500cr.png"
    'Ruta a sonidos
    Dim intSound As Integer = 0
    Dim snd As New sonido
    'Lista de ensayos ganadores y lista de premio asociado a cada ensayo
    Dim ensayos_ganadores As List(Of Integer)
    Dim ensayos_premios As List(Of Integer)
    'Detectar presiones del mouse o de la barra de espacio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ruta As String = System.IO.Directory.GetCurrentDirectory()
        cherries = ruta & "\Imagenes\cherries.png"
        corona = ruta & "\Imagenes\corona.png"
        diamante = ruta & "\Imagenes\diamante.png"
        fresa = ruta & "\Imagenes\fresa.png"
        lima = ruta & "\Imagenes\lima.png"
        manzana = ruta & "\Imagenes\manzana.png"
        naranja = ruta & "\Imagenes\naranja.png"
        platanos = ruta & "\Imagenes\platanos.png"
        sandia = ruta & "\Imagenes\sandia.png"
        siete = ruta & "\Imagenes\siete.png"
        trebol = ruta & "\Imagenes\trebol.png"
        uva = ruta & "\Imagenes\uva.png"
        fondoMP = ruta & "\Imagenes\fondoSlot_FruitFrenzy_1cr.png"
        fondoMG = ruta & "\Imagenes\fondoSlot_FruitFrenzy_500cr.png"

        Me.WindowState = FormWindowState.Normal
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        'Muestra forma de llenado de datos antes de iniciar
        start.ShowDialog()
        'Se definen variables segun la condición seleccionada
        Select Case start.condicion
            Case "A2_Con_vb_MM", "B1_Con_vb_MM", "C2_Con_vb_MM", "D1_Con_vb_MM"
                Me.BackgroundImage = Image.FromFile(fondoMG) 'Fondo Magnitud Grande
                apuesta_cr = 500 ' Numero de creditos apostados por tirada
                numero_ensayos = 50 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 10, 12, 19, 20, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50})
                ensayos_premios = New List(Of Integer)({1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 2000, 1000, 500, 1000, 1000, 1000, 1000, 1000, 2000, 1000, 500, 500, 1000, 1000})
                premio1 = 500
                premio2 = 1000
                premio3 = 4000
                premio4 = 6000
                premio5 = 12000
                premio6 = 50000
            Case "A1_Con_VA_MM", "B2_Con_VA_MM", "C1_Con_VA_MM", "D2_Con_VA_MM"
                Me.BackgroundImage = Image.FromFile(fondoMG) 'Fondo Magnitud Grande
                apuesta_cr = 500 ' Numero de creditos apostados por tirada
                numero_ensayos = 50 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 12, 19, 20, 24, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50})
                ensayos_premios = New List(Of Integer)({500, 500, 500, 500, 500, 1000, 500, 500, 6000, 500, 500, 500, 500, 500, 500, 500, 500, 500, 6000, 500, 500, 500, 1000})
                premio1 = 500
                premio2 = 1000
                premio3 = 4000
                premio4 = 6000
                premio5 = 12000
                premio6 = 50000
            Case "A5_Con_vb_mm", "B4_Con_vb_mm", "C5_Con_vb_mm", "D4_Con_vb_mm"
                Me.BackgroundImage = Image.FromFile(fondoMP) 'Fondo Magnitud Pequeña
                apuesta_cr = 1 ' Numero de creditos apostados por tirada
                numero_ensayos = 50 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 10, 12, 19, 20, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50})
                ensayos_premios = New List(Of Integer)({2, 2, 2, 2, 2, 2, 2, 2, 2, 4, 2, 1, 2, 2, 2, 2, 2, 4, 2, 1, 1, 2, 2})
                premio1 = 1
                premio2 = 2
                premio3 = 8
                premio4 = 12
                premio5 = 24
                premio6 = 100
            Case "A4_Con_VA_mm", "B5_Con_VA_mm", "C4_Con_VA_mm", "D5_Con_VA_mm"
                Me.BackgroundImage = Image.FromFile(fondoMP) 'Fondo Magnitud Pequeña
                apuesta_cr = 1 ' Numero de creditos apostados por tirada
                numero_ensayos = 50 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 12, 19, 20, 24, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50})
                ensayos_premios = New List(Of Integer)({1, 1, 1, 1, 1, 2, 1, 1, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 12, 1, 1, 1, 2})
                premio1 = 1
                premio2 = 2
                premio3 = 8
                premio4 = 12
                premio5 = 24
                premio6 = 100
            Case "A2_For_vb_MM", "B1_For_vb_MM", "C2_For_vb_MM", "D1_For_vb_MM"
                Me.BackgroundImage = Image.FromFile(fondoMG) 'Fondo Magnitud Grande
                apuesta_cr = 500 ' Numero de creditos apostados por tirada
                numero_ensayos = 100 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 10, 12, 19, 20, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50, 53, 55, 56, 57, 59, 60, 62, 69, 70, 76, 80, 81, 82, 83, 84, 85, 88, 89, 93, 94, 95, 99, 100})
                ensayos_premios = New List(Of Integer)({1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 2000, 1000, 500, 1000, 1000, 1000, 1000, 1000, 2000, 1000, 500, 500, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 2000, 1000, 500, 1000, 1000, 1000, 1000, 1000, 2000, 1000, 500, 500, 1000, 1000})
                premio1 = 500
                premio2 = 1000
                premio3 = 4000
                premio4 = 6000
                premio5 = 12000
                premio6 = 50000
            Case "A1_For_VA_MM", "B2_For_VA_MM", "C1_For_VA_MM", "D2_For_VA_MM"
                Me.BackgroundImage = Image.FromFile(fondoMG) 'Fondo Magnitud Grande
                apuesta_cr = 500 ' Numero de creditos apostados por tirada
                numero_ensayos = 100 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 12, 19, 20, 24, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50, 53, 55, 56, 57, 59, 62, 69, 70, 74, 76, 80, 81, 82, 83, 84, 85, 88, 89, 93, 94, 95, 99, 100})
                ensayos_premios = New List(Of Integer)({500, 500, 500, 500, 500, 1000, 500, 500, 6000, 500, 500, 500, 500, 500, 500, 500, 500, 500, 6000, 500, 500, 500, 1000, 500, 500, 500, 500, 500, 1000, 500, 500, 6000, 500, 500, 500, 500, 500, 500, 500, 500, 500, 6000, 500, 500, 500, 1000})
                premio1 = 500
                premio2 = 1000
                premio3 = 4000
                premio4 = 6000
                premio5 = 12000
                premio6 = 50000
            Case "A5_For_vb_mm", "B4_For_vb_mm", "C5_For_vb_mm", "D4_For_vb_mm"
                Me.BackgroundImage = Image.FromFile(fondoMP) 'Fondo Magnitud Pequeña
                apuesta_cr = 1 ' Numero de creditos apostados por tirada
                numero_ensayos = 100 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 10, 12, 19, 20, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50, 53, 55, 56, 57, 59, 60, 62, 69, 70, 76, 80, 81, 82, 83, 84, 85, 88, 89, 93, 94, 95, 99, 100})
                ensayos_premios = New List(Of Integer)({2, 2, 2, 2, 2, 2, 2, 2, 2, 4, 2, 1, 2, 2, 2, 2, 2, 4, 2, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4, 2, 1, 2, 2, 2, 2, 2, 4, 2, 1, 1, 2, 2})
                premio1 = 1
                premio2 = 2
                premio3 = 8
                premio4 = 12
                premio5 = 24
                premio6 = 100
            Case "A4_For_VA_mm", "B5_For_VA_mm", "C4_For_VA_mm", "D5_For_VA_mm"
                Me.BackgroundImage = Image.FromFile(fondoMP) 'Fondo Magnitud Pequeña
                apuesta_cr = 1 ' Numero de creditos apostados por tirada
                numero_ensayos = 100 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({3, 5, 6, 7, 9, 12, 19, 20, 24, 26, 30, 31, 32, 33, 34, 35, 38, 39, 43, 44, 45, 49, 50, 53, 55, 56, 57, 59, 62, 69, 70, 74, 76, 80, 81, 82, 83, 84, 85, 88, 89, 93, 94, 95, 99, 100})
                ensayos_premios = New List(Of Integer)({1, 1, 1, 1, 1, 2, 1, 1, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 12, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 12, 1, 1, 1, 1, 1, 1, 1, 1, 1, 12, 1, 1, 1, 2})
                premio1 = 1
                premio2 = 2
                premio3 = 8
                premio4 = 12
                premio5 = 24
                premio6 = 100
            Case "Magnitud Grande-Extincion"
                Me.BackgroundImage = Image.FromFile(fondoMP) 'Fondo Magnitud Pequeña
                apuesta_cr = 500 ' Numero de creditos apostados por tirada
                numero_ensayos = 100 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({0})
                ensayos_premios = New List(Of Integer)({0})
                premio1 = 0
                premio2 = 0
                premio3 = 0
                premio4 = 0
                premio5 = 0
                premio6 = 0
            Case "Magnitud Pequeña-Extincion"
                Me.BackgroundImage = Image.FromFile(fondoMP) 'Fondo Magnitud Pequeña
                apuesta_cr = 1 ' Numero de creditos apostados por tirada
                numero_ensayos = 100 'Numero de ensayos programados
                ensayos_ganadores = New List(Of Integer)({0})
                ensayos_premios = New List(Of Integer)({0})
                premio1 = 0
                premio2 = 0
                premio3 = 0
                premio4 = 0
                premio5 = 0
                premio6 = 0
        End Select
        ' Escribe primera línea de registro, encabezados
        Dim file_datos As System.IO.StreamWriter
        file_datos = My.Computer.FileSystem.OpenTextFileWriter(start.ruta & start.experimento & start.condicion & start.participante & ".csv", True)
        file_datos.WriteLine("Hora de Click" & "," & "Intervalo Ensayo-Click" & "," & "Suma Clicks" & "," & "Total Creditos Apostados" & "," & "Saldo Creditos" & "," & "Gano/Perdio" & "," & "Condicion" & "," & "Participante")
        file_datos.Close()
        ' Display del tamaño de la apuesta en el cuadro "Apuesta"
        apuesta_txt.Text = apuesta_cr
        ' Display del numero total de creditos en el cuadro "Creditos"
        creditos_txt.Text = creditos
        ' Display del letrero de ganada en 0
        ganaste_txt.Text = 0
        ' Ocultar mensaje "Ganaste"
        ganaste_msj.Visible = False
        ' Inicia conteo para latencia ensayo 1
        startTEC = Now
        'Musica de fondo
        intSound += 1
        With snd
            .Name = "sonido" & intSound
            .Play(1, True)
        End With
        'Esconde el cursor
        Cursor.Hide()
    End Sub
    ' Animacion de letrero de "¡Ganaste!"
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tiempo2 = tiempo2 + 100
        If tiempo2 < 2200 Then
            Button1.Enabled = False
            Select Case tiempo2
                Case 100
                    ganaste_msj.Visible = True
                Case 500
                    ganaste_msj.Visible = False
                Case 900
                    ganaste_msj.Visible = True
                Case 1300
                    ganaste_msj.Visible = False
                Case 1700
                    ganaste_msj.Visible = True
                Case 2100
                    ganaste_msj.Visible = False
            End Select
        Else
            Timer2.Enabled = False
            tiempo2 = 0
            Button1.Enabled = True
            Button1.Focus()
            startTEC = Now
        End If
    End Sub
    ' Animación del giro/selección aleatoria de los símbolos
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo = tiempo + 100 ' Tasa de refresco de cada imágen (carga un símbolo nuevo cada 0.1 seg)
        If tiempo < 2500 Then
            s1 = Int(12 * Rnd() + 1) 'Fórmula: Int((upperbound - lowerbound + 1) * Rnd + lowerbound) para sacar numero aleatorio entre 1 y 12
            s2 = Int(12 * Rnd() + 1)
            s3 = Int(12 * Rnd() + 1)
            s4 = Int(12 * Rnd() + 1)
            s5 = Int(12 * Rnd() + 1)
            s6 = Int(12 * Rnd() + 1)
            s7 = Int(12 * Rnd() + 1)
            s8 = Int(12 * Rnd() + 1)
            s9 = Int(12 * Rnd() + 1)
            s10 = Int(12 * Rnd() + 1)
            s11 = Int(12 * Rnd() + 1)
            s12 = Int(12 * Rnd() + 1)
            s13 = Int(12 * Rnd() + 1)
            s14 = Int(12 * Rnd() + 1)
            s15 = Int(12 * Rnd() + 1)
            Select Case s1
                Case 1
                    Simbolo1.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo1.Image = Image.FromFile(corona)
                Case 3
                    Simbolo1.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo1.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo1.Image = Image.FromFile(lima)
                Case 6
                    Simbolo1.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo1.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo1.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo1.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo1.Image = Image.FromFile(siete)
                Case 11
                    Simbolo1.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo1.Image = Image.FromFile(uva)

            End Select
            Select Case s2
                Case 1
                    Simbolo2.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo2.Image = Image.FromFile(corona)
                Case 3
                    Simbolo2.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo2.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo2.Image = Image.FromFile(lima)
                Case 6
                    Simbolo2.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo2.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo2.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo2.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo2.Image = Image.FromFile(siete)
                Case 11
                    Simbolo2.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo2.Image = Image.FromFile(uva)

            End Select
            Select Case s3
                Case 1
                    Simbolo3.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo3.Image = Image.FromFile(corona)
                Case 3
                    Simbolo3.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo3.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo3.Image = Image.FromFile(lima)
                Case 6
                    Simbolo3.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo3.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo3.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo3.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo3.Image = Image.FromFile(siete)
                Case 11
                    Simbolo3.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo3.Image = Image.FromFile(uva)

            End Select
            Select Case s4
                Case 1
                    Simbolo4.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo4.Image = Image.FromFile(corona)
                Case 3
                    Simbolo4.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo4.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo4.Image = Image.FromFile(lima)
                Case 6
                    Simbolo4.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo4.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo4.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo4.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo4.Image = Image.FromFile(siete)
                Case 11
                    Simbolo4.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo4.Image = Image.FromFile(uva)

            End Select
            Select Case s5
                Case 1
                    Simbolo5.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo5.Image = Image.FromFile(corona)
                Case 3
                    Simbolo5.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo5.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo5.Image = Image.FromFile(lima)
                Case 6
                    Simbolo5.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo5.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo5.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo5.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo5.Image = Image.FromFile(siete)
                Case 11
                    Simbolo5.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo5.Image = Image.FromFile(uva)

            End Select
            ' Para s6 no hay "trebol", para evitar pagos azarosos de $1. Se cambia por un simbolo que no paga nunca
            Select Case s6
                Case 1
                    Simbolo6.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo6.Image = Image.FromFile(corona)
                Case 3
                    Simbolo6.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo6.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo6.Image = Image.FromFile(lima)
                Case 6
                    Simbolo6.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo6.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo6.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo6.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo6.Image = Image.FromFile(siete)
                Case 11
                    Simbolo6.Image = Image.FromFile(naranja)
                Case 12
                    Simbolo6.Image = Image.FromFile(uva)

            End Select
            ' Para s7 no hay "uva" ni "lima", para evitar pagos azarosos de $2. Se cambia por un simbolo que no paga nunca
            Select Case s7
                Case 1
                    Simbolo7.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo7.Image = Image.FromFile(corona)
                Case 3
                    Simbolo7.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo7.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo7.Image = Image.FromFile(corona)
                Case 6
                    Simbolo7.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo7.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo7.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo7.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo7.Image = Image.FromFile(siete)
                Case 11
                    Simbolo7.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo7.Image = Image.FromFile(diamante)

            End Select
            ' Para s8 no hay "sandia" ni "cherries", para evitar pagos azarosos de $4 y de $8. Se cambia por un simbolo que no paga nunca
            Select Case s8
                Case 1
                    Simbolo8.Image = Image.FromFile(fresa)
                Case 2
                    Simbolo8.Image = Image.FromFile(corona)
                Case 3
                    Simbolo8.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo8.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo8.Image = Image.FromFile(lima)
                Case 6
                    Simbolo8.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo8.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo8.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo8.Image = Image.FromFile(corona)
                Case 10
                    Simbolo8.Image = Image.FromFile(siete)
                Case 11
                    Simbolo8.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo8.Image = Image.FromFile(uva)

            End Select
            ' Para s9 no hay "siete", para evitar pagos azarosos de $10. Se cambia por un simbolo que no paga nunca
            Select Case s9
                Case 1
                    Simbolo9.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo9.Image = Image.FromFile(corona)
                Case 3
                    Simbolo9.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo9.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo9.Image = Image.FromFile(lima)
                Case 6
                    Simbolo9.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo9.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo9.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo9.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo9.Image = Image.FromFile(platanos)
                Case 11
                    Simbolo9.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo9.Image = Image.FromFile(uva)

            End Select
            ' Para s10 no hay "siete", para evitar pagos azarosos de $10. Se cambia por un simbolo que no paga nunca
            Select Case s10
                Case 1
                    Simbolo10.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo10.Image = Image.FromFile(corona)
                Case 3
                    Simbolo10.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo10.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo10.Image = Image.FromFile(lima)
                Case 6
                    Simbolo10.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo10.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo10.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo10.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo10.Image = Image.FromFile(naranja)
                Case 11
                    Simbolo10.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo10.Image = Image.FromFile(uva)
            End Select
            Select Case s11
                Case 1
                    Simbolo11.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo11.Image = Image.FromFile(corona)
                Case 3
                    Simbolo11.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo11.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo11.Image = Image.FromFile(lima)
                Case 6
                    Simbolo11.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo11.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo11.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo11.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo11.Image = Image.FromFile(siete)
                Case 11
                    Simbolo11.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo11.Image = Image.FromFile(uva)

            End Select
            Select Case s12
                Case 1
                    Simbolo12.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo12.Image = Image.FromFile(corona)
                Case 3
                    Simbolo12.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo12.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo12.Image = Image.FromFile(lima)
                Case 6
                    Simbolo12.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo12.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo12.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo12.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo12.Image = Image.FromFile(siete)
                Case 11
                    Simbolo12.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo12.Image = Image.FromFile(uva)

            End Select
            Select Case s13
                Case 1
                    Simbolo13.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo13.Image = Image.FromFile(corona)
                Case 3
                    Simbolo13.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo13.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo13.Image = Image.FromFile(lima)
                Case 6
                    Simbolo13.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo13.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo13.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo13.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo13.Image = Image.FromFile(siete)
                Case 11
                    Simbolo13.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo13.Image = Image.FromFile(uva)

            End Select
            Select Case s14
                Case 1
                    Simbolo14.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo14.Image = Image.FromFile(corona)
                Case 3
                    Simbolo14.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo14.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo14.Image = Image.FromFile(lima)
                Case 6
                    Simbolo14.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo14.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo14.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo14.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo14.Image = Image.FromFile(siete)
                Case 11
                    Simbolo14.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo14.Image = Image.FromFile(uva)

            End Select
            Select Case s15
                Case 1
                    Simbolo15.Image = Image.FromFile(cherries)
                Case 2
                    Simbolo15.Image = Image.FromFile(corona)
                Case 3
                    Simbolo15.Image = Image.FromFile(diamante)
                Case 4
                    Simbolo15.Image = Image.FromFile(fresa)
                Case 5
                    Simbolo15.Image = Image.FromFile(lima)
                Case 6
                    Simbolo15.Image = Image.FromFile(manzana)
                Case 7
                    Simbolo15.Image = Image.FromFile(naranja)
                Case 8
                    Simbolo15.Image = Image.FromFile(platanos)
                Case 9
                    Simbolo15.Image = Image.FromFile(sandia)
                Case 10
                    Simbolo15.Image = Image.FromFile(siete)
                Case 11
                    Simbolo15.Image = Image.FromFile(trebol)
                Case 12
                    Simbolo15.Image = Image.FromFile(uva)

            End Select
        Else
            Timer1.Enabled = False
            ' Elegir las imágenes para símbolos 6 al 10, que me van a dar combinaciones ganadoras con un Select Case que va buscando el tamaño del premio
            If ensayos_ganadores.Contains(ensayo) = True Then
                Select Case ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                    Case premio1
                        Simbolo6.Image = Image.FromFile(trebol)
                        ganaste_txt.Text = ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos = creditos + ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos_txt.Text = creditos
                        Timer2.Enabled = True
                        ensayoGoP = "Gana" & ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        'Sonido de win
                        intSound += 1
                        With snd
                            .Name = "sonido" & intSound
                            .Play(3, False)
                        End With
                    Case premio2
                        Simbolo6.Image = Image.FromFile(uva)
                        Simbolo7.Image = Image.FromFile(uva)
                        Simbolo8.Image = Image.FromFile(uva)
                        ganaste_txt.Text = ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos = creditos + ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos_txt.Text = creditos
                        Timer2.Enabled = True
                        ensayoGoP = "Gana" & ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        'Sonido de win
                        intSound += 1
                        With snd
                            .Name = "sonido" & intSound
                            .Play(3, False)
                        End With
                    Case premio3
                        Simbolo6.Image = Image.FromFile(sandia)
                        Simbolo7.Image = Image.FromFile(sandia)
                        Simbolo8.Image = Image.FromFile(sandia)
                        ganaste_txt.Text = ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos = creditos + ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos_txt.Text = creditos
                        Timer2.Enabled = True
                        ensayoGoP = "Gana" & ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        'Sonido de win
                        intSound += 1
                        With snd
                            .Name = "sonido" & intSound
                            .Play(3, False)
                        End With
                    Case premio4
                        Simbolo6.Image = Image.FromFile(lima)
                        Simbolo7.Image = Image.FromFile(lima)
                        Simbolo8.Image = Image.FromFile(lima)
                        ganaste_txt.Text = ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos = creditos + ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos_txt.Text = creditos
                        Timer2.Enabled = True
                        ensayoGoP = "Gana" & ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        'Sonido de win
                        intSound += 1
                        With snd
                            .Name = "sonido" & intSound
                            .Play(3, False)
                        End With
                    Case premio5
                        Simbolo6.Image = Image.FromFile(cherries)
                        Simbolo7.Image = Image.FromFile(cherries)
                        Simbolo8.Image = Image.FromFile(cherries)
                        Simbolo9.Image = Image.FromFile(cherries)
                        ganaste_txt.Text = ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos = creditos + ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos_txt.Text = creditos
                        Timer2.Enabled = True
                        ensayoGoP = "Gana" & ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        'Sonido de win
                        intSound += 1
                        With snd
                            .Name = "sonido" & intSound
                            .Play(3, False)
                        End With
                    Case premio6
                        Simbolo6.Image = Image.FromFile(siete)
                        Simbolo7.Image = Image.FromFile(siete)
                        Simbolo8.Image = Image.FromFile(siete)
                        Simbolo9.Image = Image.FromFile(siete)
                        Simbolo10.Image = Image.FromFile(siete)
                        ganaste_txt.Text = ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos = creditos + ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        creditos_txt.Text = creditos
                        Timer2.Enabled = True
                        ensayoGoP = "Gana" & ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                        'Sonido de win
                        intSound += 1
                        With snd
                            .Name = "sonido" & intSound
                            .Play(3, False)
                        End With
                End Select
            Else
                ganaste_txt.Text = 0
                ensayoGoP = "Pierde"
                stopTEC = Now
                Button1.Enabled = True
                Button1.Focus()
            End If
            startTEC = Now
            tiempo = 0
        End If
    End Sub
    'Presiones al boton "Tirar"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ensayo >= numero_ensayos Then
            Button1.Enabled = False
            'Envio de mensaje o instrucción al participante
            MessageBox.Show("¡Gracias! Esta parte del experimento ha terminado. Por favor, llama al investigador.", "Fin de la partida", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Toma tiempo de fin de la sesion
            Close()
        Else
            'Toma de tiempo de fin para intervalos Ensayo-Click
            stopTEC = Now
            'Print de Fecha y Hora de respuesta
            Dim fechaHora = DateTime.Now.ToString("HH:mm:ss")
            'Iniciar timer
            Timer1.Enabled = True
            'Inhabilitar boton de tiro
            Button1.Enabled = False
            'Contar ensayo
            ensayo = ensayo + 1
            'Sonido de giro de rieles
            intSound += 1
            With snd
                .Name = "sonido" & intSound
                .Play(2, False)
            End With
            ' Revisar si el primer ensayo es ganador o perdedor y asigna valor a enayoGoP
            If ensayo = 1 Then
                If ensayos_ganadores.Contains(ensayo) = True Then
                    ensayoGoP = "Gana" & ensayos_premios.Item(ensayos_ganadores.IndexOf(ensayo))
                Else
                    ensayoGoP = "Pierde"
                End If
            End If
            'Calculo de Intervalos Click-FinEnsayo; Total creditos apostados
            IEC = stopTEC.Subtract(startTEC)
            Dim IECTenths = IEC.TotalSeconds.ToString("0.000000")
            Dim cr_apostados = ensayo * apuesta_cr
            'Registro en .csv de datos
            writeToFile(fechaHora, IECTenths, ensayo, cr_apostados, creditos_txt.Text, ensayoGoP, start.condicion, start.participante, ",")
            ' Descuento de creditos apostados
            If creditos < apuesta_cr Then
                'Envio de mensaje o instrucción al participante
                MessageBox.Show("Te has quedado sin créditos para seguir jugando. Por favor, llama al investigador.", "Fin de la partida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            End If
            creditos = creditos - apuesta_cr
            creditos_txt.Text = creditos
        End If
    End Sub

    'Registrar datos
    Function writeToFile(FechayHora As String, IntervaloEnsayoClick As String, ClicksAcum As String, TotalCreditosApostados As String, TotalCreditos As String, EnsayoGanador As String, Condicion As String, Participante As String, delimitador As String) As Boolean
        Dim file_datos As System.IO.StreamWriter
        file_datos = My.Computer.FileSystem.OpenTextFileWriter(start.ruta & start.experimento & start.condicion & start.participante & ".csv", True)
        Dim registro As String = FechayHora + delimitador + IntervaloEnsayoClick + delimitador + ClicksAcum + delimitador + TotalCreditosApostados + delimitador + TotalCreditos + delimitador + EnsayoGanador + delimitador + Condicion + delimitador + Participante
        file_datos.WriteLine(registro)
        file_datos.Close()
        Return True
    End Function

End Class
