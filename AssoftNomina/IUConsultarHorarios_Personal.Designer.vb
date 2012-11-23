<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUConsultarHorarios_Personal
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvHorario = New System.Windows.Forms.DataGridView()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvHorario
        '
        Me.DgvHorario.AllowUserToAddRows = False
        Me.DgvHorario.AllowUserToDeleteRows = False
        Me.DgvHorario.AllowUserToResizeRows = False
        Me.DgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHorario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.DIA1, Me.DIA2, Me.DIA3, Me.DIA4, Me.DIA5, Me.DIA6, Me.DIA7, Me.DIA8, Me.DIA9, Me.DIA10, Me.DIA11, Me.DIA12, Me.DIA13, Me.DIA14, Me.DIA15})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHorario.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgvHorario.Location = New System.Drawing.Point(12, 52)
        Me.DgvHorario.Name = "DgvHorario"
        Me.DgvHorario.ReadOnly = True
        Me.DgvHorario.RowHeadersVisible = False
        Me.DgvHorario.Size = New System.Drawing.Size(862, 281)
        Me.DgvHorario.TabIndex = 75
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "EMPLEADO"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        Me.Empleado.Width = 91
        '
        'DIA1
        '
        Me.DIA1.HeaderText = "DIA1"
        Me.DIA1.Name = "DIA1"
        Me.DIA1.ReadOnly = True
        Me.DIA1.Width = 56
        '
        'DIA2
        '
        Me.DIA2.HeaderText = "DIA2"
        Me.DIA2.Name = "DIA2"
        Me.DIA2.ReadOnly = True
        Me.DIA2.Width = 56
        '
        'DIA3
        '
        Me.DIA3.HeaderText = "DIA3"
        Me.DIA3.Name = "DIA3"
        Me.DIA3.ReadOnly = True
        Me.DIA3.Width = 56
        '
        'DIA4
        '
        Me.DIA4.HeaderText = "DIA4"
        Me.DIA4.Name = "DIA4"
        Me.DIA4.ReadOnly = True
        Me.DIA4.Width = 56
        '
        'DIA5
        '
        Me.DIA5.HeaderText = "DIA5"
        Me.DIA5.Name = "DIA5"
        Me.DIA5.ReadOnly = True
        Me.DIA5.Width = 56
        '
        'DIA6
        '
        Me.DIA6.HeaderText = "DIA6"
        Me.DIA6.Name = "DIA6"
        Me.DIA6.ReadOnly = True
        Me.DIA6.Width = 56
        '
        'DIA7
        '
        Me.DIA7.HeaderText = "DIA7"
        Me.DIA7.Name = "DIA7"
        Me.DIA7.ReadOnly = True
        Me.DIA7.Width = 56
        '
        'DIA8
        '
        Me.DIA8.HeaderText = "DIA8"
        Me.DIA8.Name = "DIA8"
        Me.DIA8.ReadOnly = True
        Me.DIA8.Width = 56
        '
        'DIA9
        '
        Me.DIA9.HeaderText = "DIA9"
        Me.DIA9.Name = "DIA9"
        Me.DIA9.ReadOnly = True
        Me.DIA9.Width = 56
        '
        'DIA10
        '
        Me.DIA10.HeaderText = "DIA10"
        Me.DIA10.Name = "DIA10"
        Me.DIA10.ReadOnly = True
        Me.DIA10.Width = 62
        '
        'DIA11
        '
        Me.DIA11.HeaderText = "DIA11"
        Me.DIA11.Name = "DIA11"
        Me.DIA11.ReadOnly = True
        Me.DIA11.Width = 62
        '
        'DIA12
        '
        Me.DIA12.HeaderText = "DIA12"
        Me.DIA12.Name = "DIA12"
        Me.DIA12.ReadOnly = True
        Me.DIA12.Width = 62
        '
        'DIA13
        '
        Me.DIA13.HeaderText = "DIA13"
        Me.DIA13.Name = "DIA13"
        Me.DIA13.ReadOnly = True
        Me.DIA13.Width = 62
        '
        'DIA14
        '
        Me.DIA14.HeaderText = "DIA14"
        Me.DIA14.Name = "DIA14"
        Me.DIA14.ReadOnly = True
        Me.DIA14.Width = 62
        '
        'DIA15
        '
        Me.DIA15.HeaderText = "DIA15"
        Me.DIA15.Name = "DIA15"
        Me.DIA15.ReadOnly = True
        Me.DIA15.Width = 62
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "GUAYANA", "LAS VEGAS", "CORPORATIVA"})
        Me.ComboBox1.Location = New System.Drawing.Point(27, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox1.TabIndex = 76
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(212, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox2.TabIndex = 77
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(396, 12)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox3.TabIndex = 78
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(580, 12)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox4.TabIndex = 79
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(782, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'IUConsultarHorarios_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 372)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DgvHorario)
        Me.Name = "IUConsultarHorarios_Personal"
        Me.Text = "IUConsultarHorarios_Personal"
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvHorario As System.Windows.Forms.DataGridView
    Friend WithEvents Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
