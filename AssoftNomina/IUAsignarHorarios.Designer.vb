<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUAsignarHorarios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.LblDpto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbQuincena = New System.Windows.Forms.ComboBox()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.CmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.BtnIr = New System.Windows.Forms.Button()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblHorDiur = New System.Windows.Forms.Label()
        Me.LblHorNoc = New System.Windows.Forms.Label()
        Me.CmbDiurno = New System.Windows.Forms.ComboBox()
        Me.CmbNocturno = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Dgvhnoct = New System.Windows.Forms.DataGridView()
        Me.indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.htrabajadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hdescanso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bononocturno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgvhdiur = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_bd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgvhorario2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Dgvhorario3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvhnoct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvhdiur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvhorario2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvhorario3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(127, 57)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(147, 21)
        Me.CmbDepartamento.TabIndex = 0
        '
        'LblDpto
        '
        Me.LblDpto.AutoSize = True
        Me.LblDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDpto.Location = New System.Drawing.Point(12, 58)
        Me.LblDpto.Name = "LblDpto"
        Me.LblDpto.Size = New System.Drawing.Size(94, 16)
        Me.LblDpto.TabIndex = 68
        Me.LblDpto.Text = "Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Quincena"
        '
        'CmbQuincena
        '
        Me.CmbQuincena.FormattingEnabled = True
        Me.CmbQuincena.Location = New System.Drawing.Point(127, 30)
        Me.CmbQuincena.Name = "CmbQuincena"
        Me.CmbQuincena.Size = New System.Drawing.Size(147, 21)
        Me.CmbQuincena.TabIndex = 70
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocalidad.Location = New System.Drawing.Point(12, 4)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(68, 16)
        Me.LblLocalidad.TabIndex = 71
        Me.LblLocalidad.Text = "Localidad"
        '
        'CmbLocalidad
        '
        Me.CmbLocalidad.FormattingEnabled = True
        Me.CmbLocalidad.Items.AddRange(New Object() {"", "GUAYANA", "LAS VEGAS", "CORPORATIVA"})
        Me.CmbLocalidad.Location = New System.Drawing.Point(127, 3)
        Me.CmbLocalidad.Name = "CmbLocalidad"
        Me.CmbLocalidad.Size = New System.Drawing.Size(147, 21)
        Me.CmbLocalidad.TabIndex = 72
        '
        'BtnIr
        '
        Me.BtnIr.Image = Global.WindowsApplication1.My.Resources.Resources.verificar16
        Me.BtnIr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIr.Location = New System.Drawing.Point(203, 84)
        Me.BtnIr.Name = "BtnIr"
        Me.BtnIr.Size = New System.Drawing.Size(71, 23)
        Me.BtnIr.TabIndex = 73
        Me.BtnIr.Text = "Generar"
        Me.BtnIr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIr.UseVisualStyleBackColor = True
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
        Me.DgvHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.DIA1, Me.DIA2, Me.DIA3, Me.DIA4, Me.DIA5, Me.DIA6, Me.DIA7, Me.DIA8, Me.DIA9, Me.DIA10, Me.DIA11, Me.DIA12, Me.DIA13, Me.DIA14, Me.DIA15})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHorario.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvHorario.Location = New System.Drawing.Point(11, 113)
        Me.DgvHorario.Name = "DgvHorario"
        Me.DgvHorario.ReadOnly = True
        Me.DgvHorario.RowHeadersVisible = False
        Me.DgvHorario.Size = New System.Drawing.Size(862, 281)
        Me.DgvHorario.TabIndex = 74
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'LblHorDiur
        '
        Me.LblHorDiur.AutoSize = True
        Me.LblHorDiur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHorDiur.Location = New System.Drawing.Point(321, 5)
        Me.LblHorDiur.Name = "LblHorDiur"
        Me.LblHorDiur.Size = New System.Drawing.Size(109, 16)
        Me.LblHorDiur.TabIndex = 76
        Me.LblHorDiur.Text = "Horarios Diurnos"
        '
        'LblHorNoc
        '
        Me.LblHorNoc.AutoSize = True
        Me.LblHorNoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHorNoc.Location = New System.Drawing.Point(321, 30)
        Me.LblHorNoc.Name = "LblHorNoc"
        Me.LblHorNoc.Size = New System.Drawing.Size(124, 16)
        Me.LblHorNoc.TabIndex = 77
        Me.LblHorNoc.Text = "Horarios Nocturnos"
        '
        'CmbDiurno
        '
        Me.CmbDiurno.FormattingEnabled = True
        Me.CmbDiurno.Location = New System.Drawing.Point(443, 4)
        Me.CmbDiurno.Name = "CmbDiurno"
        Me.CmbDiurno.Size = New System.Drawing.Size(240, 21)
        Me.CmbDiurno.TabIndex = 78
        '
        'CmbNocturno
        '
        Me.CmbNocturno.FormattingEnabled = True
        Me.CmbNocturno.Location = New System.Drawing.Point(442, 30)
        Me.CmbNocturno.Name = "CmbNocturno"
        Me.CmbNocturno.Size = New System.Drawing.Size(240, 21)
        Me.CmbNocturno.TabIndex = 79
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.verificar16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(611, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Asignar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dgvhnoct
        '
        Me.Dgvhnoct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvhnoct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.indice, Me.htrabajadas, Me.hdescanso, Me.bononocturno, Me.DataGridViewTextBoxColumn6})
        Me.Dgvhnoct.Location = New System.Drawing.Point(879, 299)
        Me.Dgvhnoct.Name = "Dgvhnoct"
        Me.Dgvhnoct.RowHeadersVisible = False
        Me.Dgvhnoct.Size = New System.Drawing.Size(508, 150)
        Me.Dgvhnoct.TabIndex = 81
        '
        'indice
        '
        Me.indice.HeaderText = "indice"
        Me.indice.Name = "indice"
        Me.indice.ReadOnly = True
        '
        'htrabajadas
        '
        Me.htrabajadas.HeaderText = "htrabajadas"
        Me.htrabajadas.Name = "htrabajadas"
        Me.htrabajadas.ReadOnly = True
        '
        'hdescanso
        '
        Me.hdescanso.HeaderText = "hdescanso"
        Me.hdescanso.Name = "hdescanso"
        Me.hdescanso.ReadOnly = True
        '
        'bononocturno
        '
        Me.bononocturno.HeaderText = "bononocturno"
        Me.bononocturno.Name = "bononocturno"
        Me.bononocturno.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_bd"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Dgvhdiur
        '
        Me.Dgvhdiur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvhdiur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.id_bd})
        Me.Dgvhdiur.Location = New System.Drawing.Point(879, 143)
        Me.Dgvhdiur.Name = "Dgvhdiur"
        Me.Dgvhdiur.RowHeadersVisible = False
        Me.Dgvhdiur.Size = New System.Drawing.Size(508, 150)
        Me.Dgvhdiur.TabIndex = 82
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "indice"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "htrabajadas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "hdescanso"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "bononocturno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'id_bd
        '
        Me.id_bd.HeaderText = "id_bd"
        Me.id_bd.Name = "id_bd"
        Me.id_bd.ReadOnly = True
        '
        'Dgvhorario2
        '
        Me.Dgvhorario2.AllowUserToAddRows = False
        Me.Dgvhorario2.AllowUserToDeleteRows = False
        Me.Dgvhorario2.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvhorario2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgvhorario2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvhorario2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvhorario2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Dgvhorario2.Location = New System.Drawing.Point(879, 3)
        Me.Dgvhorario2.Name = "Dgvhorario2"
        Me.Dgvhorario2.ReadOnly = True
        Me.Dgvhorario2.RowHeadersVisible = False
        Me.Dgvhorario2.Size = New System.Drawing.Size(236, 133)
        Me.Dgvhorario2.TabIndex = 83
        Me.Dgvhorario2.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1141, -13)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(150, 150)
        Me.CrystalReportViewer1.TabIndex = 84
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(798, 400)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Dgvhorario3
        '
        Me.Dgvhorario3.AllowUserToAddRows = False
        Me.Dgvhorario3.AllowUserToDeleteRows = False
        Me.Dgvhorario3.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvhorario3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgvhorario3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvhorario3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvhorario3.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgvhorario3.Location = New System.Drawing.Point(1122, 3)
        Me.Dgvhorario3.Name = "Dgvhorario3"
        Me.Dgvhorario3.ReadOnly = True
        Me.Dgvhorario3.RowHeadersVisible = False
        Me.Dgvhorario3.Size = New System.Drawing.Size(236, 133)
        Me.Dgvhorario3.TabIndex = 87
        Me.Dgvhorario3.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'IUAsignarHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 439)
        Me.Controls.Add(Me.Dgvhorario3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Dgvhorario2)
        Me.Controls.Add(Me.Dgvhdiur)
        Me.Controls.Add(Me.Dgvhnoct)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbNocturno)
        Me.Controls.Add(Me.LblHorNoc)
        Me.Controls.Add(Me.LblHorDiur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgvHorario)
        Me.Controls.Add(Me.BtnIr)
        Me.Controls.Add(Me.CmbLocalidad)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.CmbQuincena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDpto)
        Me.Controls.Add(Me.CmbDepartamento)
        Me.Controls.Add(Me.CmbDiurno)
        Me.Name = "IUAsignarHorarios"
        Me.Text = "Asignar Horarios"
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvhnoct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvhdiur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvhorario2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvhorario3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents LblDpto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbQuincena As System.Windows.Forms.ComboBox
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents CmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents BtnIr As System.Windows.Forms.Button
    Friend WithEvents DgvHorario As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblHorDiur As System.Windows.Forms.Label
    Friend WithEvents LblHorNoc As System.Windows.Forms.Label
    Friend WithEvents CmbDiurno As System.Windows.Forms.ComboBox
    Friend WithEvents CmbNocturno As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Dgvhnoct As System.Windows.Forms.DataGridView
    Friend WithEvents Dgvhdiur As System.Windows.Forms.DataGridView
    Friend WithEvents Dgvhorario2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents indice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents htrabajadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hdescanso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bononocturno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_bd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Dgvhorario3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
