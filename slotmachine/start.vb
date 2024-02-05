
Public Class start
    Public experimento As String
    Public condicion As String
    Public participante As String
    Public ruta As String

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1_Experimento.Text = "slotmachineExp"
        ComboBox1_condicion.Text = "1"
        TextBox3_Participante.Text = "1"
        TextBox4_Ruta.Text = System.IO.Directory.GetCurrentDirectory()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton_iniciar.Click
        experimento = TextBox1_Experimento.Text
        condicion = ComboBox1_condicion.Text
        participante = TextBox3_Participante.Text
        ruta = TextBox4_Ruta.Text
        Me.Close()
    End Sub

End Class