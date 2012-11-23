<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUGestionAspirantes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUGestionAspirantes))
        Me.StsGestionAspirantes = New System.Windows.Forms.StatusStrip()
        Me.DgridAspirantes = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TlsBtnContrato = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnExamen = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.GbxBusqueda = New System.Windows.Forms.GroupBox()
        Me.ChkPre = New System.Windows.Forms.CheckBox()
        Me.CmbEdoCivil = New System.Windows.Forms.ComboBox()
        Me.ChkEdoCivil = New System.Windows.Forms.CheckBox()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.ChkSexo = New System.Windows.Forms.CheckBox()
        Me.ChkRif = New System.Windows.Forms.CheckBox()
        Me.ChkCertificado = New System.Windows.Forms.CheckBox()
        Me.CmbProfesion = New System.Windows.Forms.ComboBox()
        Me.ChkProfesion = New System.Windows.Forms.CheckBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.examenPreEmpleo1 = New WindowsApplication1.ExamenPreEmpleo()
        Me.examenLaboratorio1 = New WindowsApplication1.ExamenLaboratorio()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Profesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Certificado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Rif = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExLab = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DgridAspirantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GbxBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'StsGestionAspirantes
        '
        Me.StsGestionAspirantes.Location = New System.Drawing.Point(0, 374)
        Me.StsGestionAspirantes.Name = "StsGestionAspirantes"
        Me.StsGestionAspirantes.Size = New System.Drawing.Size(669, 22)
        Me.StsGestionAspirantes.TabIndex = 3
        Me.StsGestionAspirantes.Text = "StatusStrip1"
        '
        'DgridAspirantes
        '
        Me.DgridAspirantes.AllowUserToAddRows = False
        Me.DgridAspirantes.AllowUserToDeleteRows = False
        Me.DgridAspirantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridAspirantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgridAspirantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridAspirantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cedula, Me.ColumnaNombre, Me.ColumnaDescripcion, Me.Profesion, Me.Certificado, Me.Rif, Me.Sexo, Me.Posicion, Me.Estatus, Me.ExLab})
        Me.DgridAspirantes.Location = New System.Drawing.Point(12, 207)
        Me.DgridAspirantes.Name = "DgridAspirantes"
        Me.DgridAspirantes.ReadOnly = True
        Me.DgridAspirantes.RowHeadersVisible = False
        Me.DgridAspirantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridAspirantes.Size = New System.Drawing.Size(645, 158)
        Me.DgridAspirantes.TabIndex = 19
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsBtnContrato, Me.TlsBtnExamen, Me.TlsBtnCancelar, Me.ToolStripSeparator1, Me.TlsBtnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(669, 48)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TlsBtnContrato
        '
        Me.TlsBtnContrato.AutoSize = False
        Me.TlsBtnContrato.Enabled = False
        Me.TlsBtnContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnContrato.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnContrato.Image = Global.WindowsApplication1.My.Resources.Resources.contract24
        Me.TlsBtnContrato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnContrato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnContrato.Name = "TlsBtnContrato"
        Me.TlsBtnContrato.Size = New System.Drawing.Size(65, 45)
        Me.TlsBtnContrato.Text = "&Contrato"
        Me.TlsBtnContrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnContrato.ToolTipText = "Agregar Persona"
        '
        'TlsBtnExamen
        '
        Me.TlsBtnExamen.Enabled = False
        Me.TlsBtnExamen.Image = Global.WindowsApplication1.My.Resources.Resources.document_pulse
        Me.TlsBtnExamen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnExamen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnExamen.Name = "TlsBtnExamen"
        Me.TlsBtnExamen.Size = New System.Drawing.Size(133, 45)
        Me.TlsBtnExamen.Text = "&Examen Laboratorio"
        Me.TlsBtnExamen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnExamen.ToolTipText = "Generar orden para examen médico"
        '
        'TlsBtnCancelar
        '
        Me.TlsBtnCancelar.AutoSize = False
        Me.TlsBtnCancelar.Enabled = False
        Me.TlsBtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnCancelar.Image = Global.WindowsApplication1.My.Resources.Resources.delete
        Me.TlsBtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnCancelar.Name = "TlsBtnCancelar"
        Me.TlsBtnCancelar.Size = New System.Drawing.Size(65, 45)
        Me.TlsBtnCancelar.Text = "C&ancelar"
        Me.TlsBtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnCancelar.ToolTipText = "Agregar Persona"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'TlsBtnBuscar
        '
        Me.TlsBtnBuscar.AutoSize = False
        Me.TlsBtnBuscar.Enabled = False
        Me.TlsBtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnBuscar.Image = Global.WindowsApplication1.My.Resources.Resources.businessman_find1
        Me.TlsBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnBuscar.Name = "TlsBtnBuscar"
        Me.TlsBtnBuscar.Size = New System.Drawing.Size(65, 45)
        Me.TlsBtnBuscar.Text = "&Buscar"
        Me.TlsBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnBuscar.ToolTipText = "Agregar Persona"
        '
        'GbxBusqueda
        '
        Me.GbxBusqueda.Controls.Add(Me.ChkPre)
        Me.GbxBusqueda.Controls.Add(Me.CmbEdoCivil)
        Me.GbxBusqueda.Controls.Add(Me.ChkEdoCivil)
        Me.GbxBusqueda.Controls.Add(Me.CmbSexo)
        Me.GbxBusqueda.Controls.Add(Me.ChkSexo)
        Me.GbxBusqueda.Controls.Add(Me.ChkRif)
        Me.GbxBusqueda.Controls.Add(Me.ChkCertificado)
        Me.GbxBusqueda.Controls.Add(Me.CmbProfesion)
        Me.GbxBusqueda.Controls.Add(Me.ChkProfesion)
        Me.GbxBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxBusqueda.ForeColor = System.Drawing.Color.Green
        Me.GbxBusqueda.Location = New System.Drawing.Point(71, 60)
        Me.GbxBusqueda.Name = "GbxBusqueda"
        Me.GbxBusqueda.Size = New System.Drawing.Size(508, 141)
        Me.GbxBusqueda.TabIndex = 24
        Me.GbxBusqueda.TabStop = False
        Me.GbxBusqueda.Text = "Busqueda Por"
        '
        'ChkPre
        '
        Me.ChkPre.AutoSize = True
        Me.ChkPre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkPre.Location = New System.Drawing.Point(302, 101)
        Me.ChkPre.Name = "ChkPre"
        Me.ChkPre.Size = New System.Drawing.Size(188, 20)
        Me.ChkPre.TabIndex = 10
        Me.ChkPre.Text = "Buscar Pre-Seleccionados"
        Me.ChkPre.UseVisualStyleBackColor = True
        '
        'CmbEdoCivil
        '
        Me.CmbEdoCivil.Enabled = False
        Me.CmbEdoCivil.FormattingEnabled = True
        Me.CmbEdoCivil.Items.AddRange(New Object() {"Soltero (a)", "Concubino (a)", "Casado (a)", "Divorciado (a)", "Viudo (a)"})
        Me.CmbEdoCivil.Location = New System.Drawing.Point(133, 63)
        Me.CmbEdoCivil.Name = "CmbEdoCivil"
        Me.CmbEdoCivil.Size = New System.Drawing.Size(132, 24)
        Me.CmbEdoCivil.TabIndex = 9
        '
        'ChkEdoCivil
        '
        Me.ChkEdoCivil.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkEdoCivil.Location = New System.Drawing.Point(23, 63)
        Me.ChkEdoCivil.Name = "ChkEdoCivil"
        Me.ChkEdoCivil.Size = New System.Drawing.Size(101, 22)
        Me.ChkEdoCivil.TabIndex = 8
        Me.ChkEdoCivil.Text = "Estado Civil"
        Me.ChkEdoCivil.UseVisualStyleBackColor = True
        '
        'CmbSexo
        '
        Me.CmbSexo.Enabled = False
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CmbSexo.Location = New System.Drawing.Point(133, 101)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(132, 24)
        Me.CmbSexo.TabIndex = 7
        '
        'ChkSexo
        '
        Me.ChkSexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkSexo.Location = New System.Drawing.Point(23, 101)
        Me.ChkSexo.Name = "ChkSexo"
        Me.ChkSexo.Size = New System.Drawing.Size(88, 22)
        Me.ChkSexo.TabIndex = 6
        Me.ChkSexo.Text = "Sexo"
        Me.ChkSexo.UseVisualStyleBackColor = True
        '
        'ChkRif
        '
        Me.ChkRif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkRif.Location = New System.Drawing.Point(302, 63)
        Me.ChkRif.Name = "ChkRif"
        Me.ChkRif.Size = New System.Drawing.Size(50, 22)
        Me.ChkRif.TabIndex = 5
        Me.ChkRif.Text = "Rif"
        Me.ChkRif.UseVisualStyleBackColor = True
        Me.ChkRif.Visible = False
        '
        'ChkCertificado
        '
        Me.ChkCertificado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkCertificado.Location = New System.Drawing.Point(302, 26)
        Me.ChkCertificado.Name = "ChkCertificado"
        Me.ChkCertificado.Size = New System.Drawing.Size(151, 22)
        Me.ChkCertificado.TabIndex = 4
        Me.ChkCertificado.Text = "Certificado de Salud"
        Me.ChkCertificado.UseVisualStyleBackColor = True
        '
        'CmbProfesion
        '
        Me.CmbProfesion.Enabled = False
        Me.CmbProfesion.FormattingEnabled = True
        Me.CmbProfesion.Location = New System.Drawing.Point(133, 26)
        Me.CmbProfesion.Name = "CmbProfesion"
        Me.CmbProfesion.Size = New System.Drawing.Size(132, 24)
        Me.CmbProfesion.TabIndex = 1
        '
        'ChkProfesion
        '
        Me.ChkProfesion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkProfesion.Location = New System.Drawing.Point(23, 26)
        Me.ChkProfesion.Name = "ChkProfesion"
        Me.ChkProfesion.Size = New System.Drawing.Size(88, 22)
        Me.ChkProfesion.TabIndex = 0
        Me.ChkProfesion.Text = "Profesión"
        Me.ChkProfesion.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(663, 171)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(150, 150)
        Me.CrystalReportViewer1.TabIndex = 25
        Me.CrystalReportViewer1.Visible = False
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(662, 60)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(150, 150)
        Me.CrystalReportViewer2.TabIndex = 26
        Me.CrystalReportViewer2.Visible = False
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        Me.Cedula.Width = 76
        '
        'ColumnaNombre
        '
        Me.ColumnaNombre.HeaderText = "Nombre"
        Me.ColumnaNombre.Name = "ColumnaNombre"
        Me.ColumnaNombre.ReadOnly = True
        Me.ColumnaNombre.Width = 82
        '
        'ColumnaDescripcion
        '
        Me.ColumnaDescripcion.HeaderText = "Apellido"
        Me.ColumnaDescripcion.Name = "ColumnaDescripcion"
        Me.ColumnaDescripcion.ReadOnly = True
        Me.ColumnaDescripcion.Width = 83
        '
        'Profesion
        '
        Me.Profesion.HeaderText = "Profesión"
        Me.Profesion.Name = "Profesion"
        Me.Profesion.ReadOnly = True
        Me.Profesion.Width = 90
        '
        'Certificado
        '
        Me.Certificado.HeaderText = "Certificado"
        Me.Certificado.Name = "Certificado"
        Me.Certificado.ReadOnly = True
        Me.Certificado.Width = 78
        '
        'Rif
        '
        Me.Rif.HeaderText = "Rif"
        Me.Rif.Name = "Rif"
        Me.Rif.ReadOnly = True
        Me.Rif.Width = 30
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        Me.Sexo.Width = 64
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posicion"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.ReadOnly = True
        Me.Posicion.Visible = False
        Me.Posicion.Width = 85
        '
        'Estatus
        '
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Visible = False
        Me.Estatus.Width = 77
        '
        'ExLab
        '
        Me.ExLab.HeaderText = "Examen Pre-Empleo"
        Me.ExLab.Name = "ExLab"
        Me.ExLab.ReadOnly = True
        Me.ExLab.Width = 124
        '
        'IUGestionAspirantes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(669, 396)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GbxBusqueda)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DgridAspirantes)
        Me.Controls.Add(Me.StsGestionAspirantes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUGestionAspirantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Aspirantes"
        CType(Me.DgridAspirantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GbxBusqueda.ResumeLayout(False)
        Me.GbxBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StsGestionAspirantes As System.Windows.Forms.StatusStrip
    Friend WithEvents DgridAspirantes As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsBtnContrato As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsBtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GbxBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents ChkCertificado As System.Windows.Forms.CheckBox
    Friend WithEvents CmbProfesion As System.Windows.Forms.ComboBox
    Friend WithEvents ChkProfesion As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRif As System.Windows.Forms.CheckBox
    Friend WithEvents CmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents ChkSexo As System.Windows.Forms.CheckBox
    Friend WithEvents CmbEdoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents ChkEdoCivil As System.Windows.Forms.CheckBox
    Friend WithEvents TlsBtnExamen As System.Windows.Forms.ToolStripButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ChkPre As System.Windows.Forms.CheckBox
    Friend WithEvents examenPreEmpleo1 As WindowsApplication1.ExamenPreEmpleo
    Friend WithEvents examenLaboratorio1 As WindowsApplication1.ExamenLaboratorio
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Profesion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Certificado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Rif As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Posicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExLab As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
