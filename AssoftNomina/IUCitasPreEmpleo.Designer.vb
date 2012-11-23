<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUCitasPreEmpleo
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgridAspirantes = New System.Windows.Forms.DataGridView()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aspirante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cita = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PanAsignarCitas = New System.Windows.Forms.Panel()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DgridAspirantes2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PanNuevaCita = New System.Windows.Forms.Panel()
        Me.BtnCancelarNuevacita = New System.Windows.Forms.Button()
        Me.BtnGuardarNuevaCita = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DgridAspirantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PanAsignarCitas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgridAspirantes2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanNuevaCita.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgridAspirantes
        '
        Me.DgridAspirantes.AllowUserToAddRows = False
        Me.DgridAspirantes.AllowUserToDeleteRows = False
        Me.DgridAspirantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridAspirantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgridAspirantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridAspirantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cedula, Me.Aspirante, Me.Cita, Me.pos})
        Me.DgridAspirantes.Location = New System.Drawing.Point(6, 35)
        Me.DgridAspirantes.Name = "DgridAspirantes"
        Me.DgridAspirantes.RowHeadersVisible = False
        Me.DgridAspirantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridAspirantes.Size = New System.Drawing.Size(459, 266)
        Me.DgridAspirantes.TabIndex = 0
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        Me.Cedula.Width = 76
        '
        'Aspirante
        '
        Me.Aspirante.HeaderText = "Aspirante"
        Me.Aspirante.Name = "Aspirante"
        Me.Aspirante.ReadOnly = True
        Me.Aspirante.Width = 90
        '
        'Cita
        '
        Me.Cita.HeaderText = "Cita asignada"
        Me.Cita.Name = "Cita"
        Me.Cita.Width = 97
        '
        'pos
        '
        Me.pos.HeaderText = "pos"
        Me.pos.Name = "pos"
        Me.pos.Visible = False
        Me.pos.Width = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione fecha para la cita"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(253, 9)
        Me.DateTimePicker1.MinDate = New Date(2012, 3, 12, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(94, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(492, 44)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.calendar_preferences
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(72, 41)
        Me.ToolStripButton1.Text = "Asignar citas"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.WindowsApplication1.My.Resources.Resources.calendar
        Me.ToolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(82, 41)
        Me.ToolStripButton2.Text = "Consultar citas"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PanAsignarCitas
        '
        Me.PanAsignarCitas.Controls.Add(Me.Label1)
        Me.PanAsignarCitas.Controls.Add(Me.DgridAspirantes)
        Me.PanAsignarCitas.Controls.Add(Me.BtnProcesar)
        Me.PanAsignarCitas.Controls.Add(Me.DateTimePicker1)
        Me.PanAsignarCitas.Location = New System.Drawing.Point(11, 41)
        Me.PanAsignarCitas.Name = "PanAsignarCitas"
        Me.PanAsignarCitas.Size = New System.Drawing.Size(471, 336)
        Me.PanAsignarCitas.TabIndex = 5
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Image = Global.WindowsApplication1.My.Resources.Resources.verificar
        Me.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProcesar.Location = New System.Drawing.Point(376, 307)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(89, 23)
        Me.BtnProcesar.TabIndex = 3
        Me.BtnProcesar.Text = "Procesar"
        Me.BtnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DgridAspirantes2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Location = New System.Drawing.Point(11, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 358)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Si desea modificar la fecha de la cita, hacer doble clic en el aspirante"
        '
        'DgridAspirantes2
        '
        Me.DgridAspirantes2.AllowUserToAddRows = False
        Me.DgridAspirantes2.AllowUserToDeleteRows = False
        Me.DgridAspirantes2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridAspirantes2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgridAspirantes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridAspirantes2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DgridAspirantes2.Location = New System.Drawing.Point(54, 214)
        Me.DgridAspirantes2.MultiSelect = False
        Me.DgridAspirantes2.Name = "DgridAspirantes2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridAspirantes2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgridAspirantes2.RowHeadersVisible = False
        Me.DgridAspirantes2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridAspirantes2.Size = New System.Drawing.Size(376, 128)
        Me.DgridAspirantes2.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 76
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Aspirante"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "pos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seleccione la fecha a consultar"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(121, 25)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'PanNuevaCita
        '
        Me.PanNuevaCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanNuevaCita.Controls.Add(Me.BtnCancelarNuevacita)
        Me.PanNuevaCita.Controls.Add(Me.BtnGuardarNuevaCita)
        Me.PanNuevaCita.Controls.Add(Me.DateTimePicker2)
        Me.PanNuevaCita.Controls.Add(Me.Label3)
        Me.PanNuevaCita.Location = New System.Drawing.Point(494, 266)
        Me.PanNuevaCita.Name = "PanNuevaCita"
        Me.PanNuevaCita.Size = New System.Drawing.Size(441, 105)
        Me.PanNuevaCita.TabIndex = 7
        '
        'BtnCancelarNuevacita
        '
        Me.BtnCancelarNuevacita.Location = New System.Drawing.Point(215, 68)
        Me.BtnCancelarNuevacita.Name = "BtnCancelarNuevacita"
        Me.BtnCancelarNuevacita.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelarNuevacita.TabIndex = 3
        Me.BtnCancelarNuevacita.Text = "Cancelar"
        Me.BtnCancelarNuevacita.UseVisualStyleBackColor = True
        '
        'BtnGuardarNuevaCita
        '
        Me.BtnGuardarNuevaCita.Location = New System.Drawing.Point(114, 68)
        Me.BtnGuardarNuevaCita.Name = "BtnGuardarNuevaCita"
        Me.BtnGuardarNuevaCita.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarNuevaCita.TabIndex = 2
        Me.BtnGuardarNuevaCita.Text = "Guardar"
        Me.BtnGuardarNuevaCita.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(166, 42)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Seleccione nueva fecha para la cita"
        '
        'Timer1
        '
        '
        'IUCitasPreEmpleo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(492, 411)
        Me.Controls.Add(Me.PanNuevaCita)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanAsignarCitas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "IUCitasPreEmpleo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citas Pre-empleo"
        CType(Me.DgridAspirantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanAsignarCitas.ResumeLayout(False)
        Me.PanAsignarCitas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgridAspirantes2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanNuevaCita.ResumeLayout(False)
        Me.PanNuevaCita.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgridAspirantes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanAsignarCitas As System.Windows.Forms.Panel
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aspirante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cita As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DgridAspirantes2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents PanNuevaCita As System.Windows.Forms.Panel
    Friend WithEvents BtnGuardarNuevaCita As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelarNuevacita As System.Windows.Forms.Button
End Class
