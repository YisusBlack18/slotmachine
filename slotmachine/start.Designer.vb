<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class start
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1_Experimento = New System.Windows.Forms.TextBox()
        Me.TextBox3_Participante = New System.Windows.Forms.TextBox()
        Me.TextBox4_Ruta = New System.Windows.Forms.TextBox()
        Me.Boton_iniciar = New System.Windows.Forms.Button()
        Me.ComboBox1_condicion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Condición:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Participante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Experimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ruta de guardado:"
        '
        'TextBox1_Experimento
        '
        Me.TextBox1_Experimento.Location = New System.Drawing.Point(170, 22)
        Me.TextBox1_Experimento.Name = "TextBox1_Experimento"
        Me.TextBox1_Experimento.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1_Experimento.TabIndex = 4
        '
        'TextBox3_Participante
        '
        Me.TextBox3_Participante.Location = New System.Drawing.Point(170, 55)
        Me.TextBox3_Participante.Name = "TextBox3_Participante"
        Me.TextBox3_Participante.Size = New System.Drawing.Size(180, 20)
        Me.TextBox3_Participante.TabIndex = 6
        '
        'TextBox4_Ruta
        '
        Me.TextBox4_Ruta.Location = New System.Drawing.Point(170, 126)
        Me.TextBox4_Ruta.Name = "TextBox4_Ruta"
        Me.TextBox4_Ruta.Size = New System.Drawing.Size(180, 20)
        Me.TextBox4_Ruta.TabIndex = 7
        Me.TextBox4_Ruta.Text = "C:\Users\gonza\source\repos\slotmachineExp_2023_11_14"
        '
        'Boton_iniciar
        '
        Me.Boton_iniciar.Location = New System.Drawing.Point(170, 175)
        Me.Boton_iniciar.Name = "Boton_iniciar"
        Me.Boton_iniciar.Size = New System.Drawing.Size(82, 31)
        Me.Boton_iniciar.TabIndex = 8
        Me.Boton_iniciar.Text = "Iniciar"
        Me.Boton_iniciar.UseVisualStyleBackColor = True
        '
        'ComboBox1_condicion
        '
        Me.ComboBox1_condicion.FormattingEnabled = True
        Me.ComboBox1_condicion.Items.AddRange(New Object() {"A1_For_VA_MM", "A2_For_vb_MM", "A1_Con_VA_MM", "A2_Con_vb_MM", "A4_For_VA_mm", "A5_For_vb_mm", "A4_Con_VA_mm", "A5_Con_vb_mm", "B1_For_vb_MM", "B2_For_VA_MM", "B1_Con_vb_MM", "B2_Con_VA_MM", "B4_For_vb_mm", "B5_For_VA_mm", "B4_Con_vb_mm", "B5_Con_VA_mm", "C1_For_VA_MM", "C2_For_vb_MM", "C1_Con_VA_MM", "C2_Con_vb_MM", "C4_For_VA_mm", "C5_For_vb_mm", "C4_Con_VA_mm", "C5_Con_vb_mm", "D1_For_vb_MM", "D2_For_VA_MM", "D1_Con_vb_MM", "D2_Con_VA_MM", "D4_For_vb_mm", "D5_For_VA_mm", "D4_Con_vb_mm", "D5_Con_VA_mm", "Magnitud Grande-Extincion", "Magnitud Pequeña-Extincion"})
        Me.ComboBox1_condicion.Location = New System.Drawing.Point(170, 90)
        Me.ComboBox1_condicion.Name = "ComboBox1_condicion"
        Me.ComboBox1_condicion.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1_condicion.TabIndex = 11
        '
        'start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 223)
        Me.Controls.Add(Me.ComboBox1_condicion)
        Me.Controls.Add(Me.Boton_iniciar)
        Me.Controls.Add(Me.TextBox4_Ruta)
        Me.Controls.Add(Me.TextBox3_Participante)
        Me.Controls.Add(Me.TextBox1_Experimento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1_Experimento As TextBox
    Friend WithEvents TextBox3_Participante As TextBox
    Friend WithEvents TextBox4_Ruta As TextBox
    Friend WithEvents Boton_iniciar As Button
    Friend WithEvents ComboBox1_condicion As ComboBox
End Class
