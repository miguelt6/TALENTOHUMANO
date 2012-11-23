<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUCrearHorario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.CmbHoraDesde = New System.Windows.Forms.ComboBox()
        Me.CmbHoraHasta = New System.Windows.Forms.ComboBox()
        Me.CmbHorasDescanso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(116, 10)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.CmbDepartamento.TabIndex = 0
        '
        'CmbHoraDesde
        '
        Me.CmbHoraDesde.FormattingEnabled = True
        Me.CmbHoraDesde.Items.AddRange(New Object() {"06:00 am", "06:30 am", "07:00 am", "07:30 am", "08:00 am", "08:30 am", "09:00 am", "09:30 am", "10:00 am", "10:30 am", "11:00 am", "11:30 am", "12:00 m", "12:30 pm", "01:00 pm", "01:30 pm", "02:00 pm", "02:30 pm", "03:00 pm", "03:30 pm", "04:00 pm", "04:30 pm", "05:00 pm", "05:30 pm", "06:00 pm", "06:30 pm", "07:00 pm", "07:30 pm", "08:00 pm", "08:30 pm", "09:00 pm", "09:30 pm", "10:00 pm", "10:30 pm", "11:00 pm", "11:30 pm", "12:00 pm"})
        Me.CmbHoraDesde.Location = New System.Drawing.Point(116, 36)
        Me.CmbHoraDesde.Name = "CmbHoraDesde"
        Me.CmbHoraDesde.Size = New System.Drawing.Size(121, 21)
        Me.CmbHoraDesde.TabIndex = 1
        '
        'CmbHoraHasta
        '
        Me.CmbHoraHasta.FormattingEnabled = True
        Me.CmbHoraHasta.Items.AddRange(New Object() {"06:00 am", "06:30 am", "07:00 am", "07:30 am", "08:00 am", "08:30 am", "09:00 am", "09:30 am", "10:00 am", "10:30 am", "11:00 am", "11:30 am", "12:00 m", "12:30 pm", "01:00 pm", "01:30 pm", "02:00 pm", "02:30 pm", "03:00 pm", "03:30 pm", "04:00 pm", "04:30 pm", "05:00 pm", "05:30 pm", "06:00 pm", "06:30 pm", "07:00 pm", "07:30 pm", "08:00 pm", "08:30 pm", "09:00 pm", "09:30 pm", "10:00 pm", "10:30 pm", "11:00 pm", "11:30 pm", "12:00 pm"})
        Me.CmbHoraHasta.Location = New System.Drawing.Point(116, 63)
        Me.CmbHoraHasta.Name = "CmbHoraHasta"
        Me.CmbHoraHasta.Size = New System.Drawing.Size(121, 21)
        Me.CmbHoraHasta.TabIndex = 2
        '
        'CmbHorasDescanso
        '
        Me.CmbHorasDescanso.FormattingEnabled = True
        Me.CmbHorasDescanso.Items.AddRange(New Object() {"0", "30", "60", "90", "120", "150", "180"})
        Me.CmbHorasDescanso.Location = New System.Drawing.Point(116, 90)
        Me.CmbHorasDescanso.Name = "CmbHorasDescanso"
        Me.CmbHorasDescanso.Size = New System.Drawing.Size(121, 21)
        Me.CmbHorasDescanso.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hora de Entrada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hora de Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Minutos de Descanso"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5", "12", "12.5", "13", "13.5", "14", "14.5", "15", "15.5", "16", "16.5", "17", "17.5", "18", "18.5", "19", "19.5", "20", "20.5", "21", "21.5", "22", "22.5", "23", "23.5", "24"})
        Me.ComboBox2.Location = New System.Drawing.Point(249, 54)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 10
        Me.ComboBox2.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5", "12", "12.5", "13", "13.5", "14", "14.5", "15", "15.5", "16", "16.5", "17", "17.5", "18", "18.5", "19", "19.5", "20", "20.5", "21", "21.5", "22", "22.5", "23", "23.5", "24"})
        Me.ComboBox3.Location = New System.Drawing.Point(249, 81)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 11
        Me.ComboBox3.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0000-00-00 06:00:00", "0000-00-00 06:30:00", "0000-00-00 07:00:00", "0000-00-00 07:30:00", "0000-00-00 08:00:00", "0000-00-00 08:30:00", "0000-00-00 09:00:00", "0000-00-00 09:30:00", "0000-00-00 10:00:00", "0000-00-00 10:30:00", "0000-00-00 11:00:00", "0000-00-00 11:30:00", "0000-00-00 12:00:00", "0000-00-00 12:30:00", "0000-00-00 13:00:00", "0000-00-00 13:30:00", "0000-00-00 14:00:00", "0000-00-00 14:30:00", "0000-00-00 15:00:00", "0000-00-00 15:30:00", "0000-00-00 16:00:00", "0000-00-00 16:30:00", "0000-00-00 17:00:00", "0000-00-00 17:30:00", "0000-00-00 18:00:00", "0000-00-00 18:30:00", "0000-00-00 19:00:00", "0000-00-00 19:30:00", "0000-00-00 20:00:00", "0000-00-00 20:30:00", "0000-00-00 21:00:00", "0000-00-00 21:30:00", "0000-00-00 22:00:00", "0000-00-00 22:30:00", "0000-00-00 23:00:00", "0000-00-00 23:30:00", "0000-00-00 00:00:00"})
        Me.ComboBox1.Location = New System.Drawing.Point(376, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Visible = False
        '
        'IUCrearHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 148)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbHorasDescanso)
        Me.Controls.Add(Me.CmbHoraHasta)
        Me.Controls.Add(Me.CmbHoraDesde)
        Me.Controls.Add(Me.CmbDepartamento)
        Me.Name = "IUCrearHorario"
        Me.Text = "Crear Horarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents CmbHoraDesde As System.Windows.Forms.ComboBox
    Friend WithEvents CmbHoraHasta As System.Windows.Forms.ComboBox
    Friend WithEvents CmbHorasDescanso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
