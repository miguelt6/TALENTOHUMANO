<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUMontarIncidencias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvHorario = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LblDesde = New System.Windows.Forms.Label()
        Me.CmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.BtnIr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIA7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvHorario
        '
        Me.DgvHorario.AllowUserToAddRows = False
        Me.DgvHorario.AllowUserToDeleteRows = False
        Me.DgvHorario.AllowUserToResizeRows = False
        Me.DgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHorario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.cedula, Me.DIA1, Me.DIA2, Me.DIA3, Me.DIA4, Me.DIA5, Me.DIA6, Me.DIA7})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHorario.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvHorario.Location = New System.Drawing.Point(10, 153)
        Me.DgvHorario.Name = "DgvHorario"
        Me.DgvHorario.ReadOnly = True
        Me.DgvHorario.RowHeadersVisible = False
        Me.DgvHorario.Size = New System.Drawing.Size(733, 192)
        Me.DgvHorario.TabIndex = 75
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(57, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 76
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.Location = New System.Drawing.Point(12, 23)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(38, 13)
        Me.LblDesde.TabIndex = 79
        Me.LblDesde.Text = "Desde"
        '
        'CmbLocalidad
        '
        Me.CmbLocalidad.FormattingEnabled = True
        Me.CmbLocalidad.Items.AddRange(New Object() {"", "GUAYANA", "LAS VEGAS", "CORPORATIVA"})
        Me.CmbLocalidad.Location = New System.Drawing.Point(334, 20)
        Me.CmbLocalidad.Name = "CmbLocalidad"
        Me.CmbLocalidad.Size = New System.Drawing.Size(147, 21)
        Me.CmbLocalidad.TabIndex = 84
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(577, 19)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(147, 21)
        Me.CmbDepartamento.TabIndex = 81
        '
        'BtnIr
        '
        Me.BtnIr.Image = Global.WindowsApplication1.My.Resources.Resources.verificar16
        Me.BtnIr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIr.Location = New System.Drawing.Point(653, 52)
        Me.BtnIr.Name = "BtnIr"
        Me.BtnIr.Size = New System.Drawing.Size(71, 23)
        Me.BtnIr.TabIndex = 85
        Me.BtnIr.Text = "Generar"
        Me.BtnIr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-39, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Departamento"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 22)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Reposo Laboral"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 22)
        Me.Button2.TabIndex = 90
        Me.Button2.Text = "Reposo No Laboral"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(464, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 22)
        Me.Button3.TabIndex = 91
        Me.Button3.Text = "Permiso Remunerado"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(586, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 22)
        Me.Button4.TabIndex = 92
        Me.Button4.Text = "Permiso No Remunerado"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.LblDesde)
        Me.GroupBox1.Controls.Add(Me.CmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnIr)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 86)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Plantilla"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(733, 48)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incidencias"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(124, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(118, 22)
        Me.Button8.TabIndex = 94
        Me.Button8.Text = "Ausencia Injustificada"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 22)
        Me.Button7.TabIndex = 93
        Me.Button7.Text = "Ausencia Justificada"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(668, 411)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 95
        Me.Button5.Text = "Imprimir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(587, 411)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 96
        Me.Button6.Text = "Guardar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(10, 343)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 23)
        Me.Button9.TabIndex = 97
        Me.Button9.Text = "Limpiar celda(s)"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 381)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(652, 20)
        Me.TextBox1.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Observaciones"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(506, 411)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 99
        Me.Button10.Text = "DataTable"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(57, 411)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(150, 150)
        Me.CrystalReportViewer1.TabIndex = 100
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "EMPLEADO"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        Me.Empleado.Width = 91
        '
        'cedula
        '
        Me.cedula.HeaderText = "CEDULA"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        Me.cedula.Width = 75
        '
        'DIA1
        '
        Me.DIA1.HeaderText = "Column1"
        Me.DIA1.Name = "DIA1"
        Me.DIA1.ReadOnly = True
        Me.DIA1.Width = 73
        '
        'DIA2
        '
        Me.DIA2.HeaderText = "Column1"
        Me.DIA2.Name = "DIA2"
        Me.DIA2.ReadOnly = True
        Me.DIA2.Width = 73
        '
        'DIA3
        '
        Me.DIA3.HeaderText = "Column1"
        Me.DIA3.Name = "DIA3"
        Me.DIA3.ReadOnly = True
        Me.DIA3.Width = 73
        '
        'DIA4
        '
        Me.DIA4.HeaderText = "Column1"
        Me.DIA4.Name = "DIA4"
        Me.DIA4.ReadOnly = True
        Me.DIA4.Width = 73
        '
        'DIA5
        '
        Me.DIA5.HeaderText = "Column1"
        Me.DIA5.Name = "DIA5"
        Me.DIA5.ReadOnly = True
        Me.DIA5.Width = 73
        '
        'DIA6
        '
        Me.DIA6.HeaderText = "Column1"
        Me.DIA6.Name = "DIA6"
        Me.DIA6.ReadOnly = True
        Me.DIA6.Width = 73
        '
        'DIA7
        '
        Me.DIA7.HeaderText = "Column1"
        Me.DIA7.Name = "DIA7"
        Me.DIA7.ReadOnly = True
        Me.DIA7.Width = 73
        '
        'IUMontarIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 446)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvHorario)
        Me.Controls.Add(Me.Button9)
        Me.Name = "IUMontarIncidencias"
        Me.Text = "Incidencias"
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvHorario As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDesde As System.Windows.Forms.Label
    Friend WithEvents CmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents BtnIr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIA7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
