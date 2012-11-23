<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUGestionarVacantes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUGestionarVacantes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TlsBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.TlsbtnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.BarraNavegacion = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BotonPrimero = New System.Windows.Forms.ToolStripButton()
        Me.BotonAnterior = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.TxtPosicion = New System.Windows.Forms.ToolStripTextBox()
        Me.LabelElementos = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.BotonUltimo = New System.Windows.Forms.ToolStripButton()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.TlsLblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GbxContrato = New System.Windows.Forms.GroupBox()
        Me.DteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DteFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaFinal = New System.Windows.Forms.Label()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.CmbCargo = New System.Windows.Forms.ComboBox()
        Me.LblCargo = New System.Windows.Forms.Label()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.LblDepartamento = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripción = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.GbxContrato.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsBtnNuevo, Me.TlsBtnModificar, Me.TlsBtnGuardar, Me.TlsBtnCancelar, Me.TlsbtnImprimir, Me.ToolStripSeparator1, Me.TlsBtnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(495, 48)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TlsBtnNuevo
        '
        Me.TlsBtnNuevo.AutoSize = False
        Me.TlsBtnNuevo.Enabled = False
        Me.TlsBtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnNuevo.Image = Global.WindowsApplication1.My.Resources.Resources.document_add241
        Me.TlsBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnNuevo.Name = "TlsBtnNuevo"
        Me.TlsBtnNuevo.Size = New System.Drawing.Size(65, 45)
        Me.TlsBtnNuevo.Text = "&Nuevo"
        Me.TlsBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnNuevo.ToolTipText = "Agregar Persona"
        '
        'TlsBtnModificar
        '
        Me.TlsBtnModificar.AutoSize = False
        Me.TlsBtnModificar.Enabled = False
        Me.TlsBtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnModificar.Image = Global.WindowsApplication1.My.Resources.Resources.document_exchange241
        Me.TlsBtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnModificar.Name = "TlsBtnModificar"
        Me.TlsBtnModificar.Size = New System.Drawing.Size(65, 45)
        Me.TlsBtnModificar.Text = "&Modificar"
        Me.TlsBtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnModificar.ToolTipText = "Agregar Persona"
        '
        'TlsBtnGuardar
        '
        Me.TlsBtnGuardar.AutoSize = False
        Me.TlsBtnGuardar.Enabled = False
        Me.TlsBtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.disk_green24
        Me.TlsBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnGuardar.Name = "TlsBtnGuardar"
        Me.TlsBtnGuardar.Size = New System.Drawing.Size(65, 45)
        Me.TlsBtnGuardar.Text = "&Guardar"
        Me.TlsBtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnGuardar.ToolTipText = "Agregar Persona"
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
        Me.TlsBtnCancelar.Text = "&Cancelar"
        Me.TlsBtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnCancelar.ToolTipText = "Agregar Persona"
        '
        'TlsbtnImprimir
        '
        Me.TlsbtnImprimir.AutoSize = False
        Me.TlsbtnImprimir.Enabled = False
        Me.TlsbtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsbtnImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsbtnImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.printer1
        Me.TlsbtnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsbtnImprimir.Name = "TlsbtnImprimir"
        Me.TlsbtnImprimir.Size = New System.Drawing.Size(65, 45)
        Me.TlsbtnImprimir.Text = "&Imprimir"
        Me.TlsbtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsbtnImprimir.ToolTipText = "Agregar Persona"
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
        'BarraNavegacion
        '
        Me.BarraNavegacion.AddNewItem = Nothing
        Me.BarraNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BarraNavegacion.CountItem = Nothing
        Me.BarraNavegacion.DeleteItem = Nothing
        Me.BarraNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarraNavegacion.Enabled = False
        Me.BarraNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonPrimero, Me.BotonAnterior, Me.BindingNavigatorSeparator, Me.TxtPosicion, Me.LabelElementos, Me.BindingNavigatorSeparator1, Me.BotonSiguiente, Me.BotonUltimo})
        Me.BarraNavegacion.Location = New System.Drawing.Point(0, 275)
        Me.BarraNavegacion.MoveFirstItem = Nothing
        Me.BarraNavegacion.MoveLastItem = Nothing
        Me.BarraNavegacion.MoveNextItem = Nothing
        Me.BarraNavegacion.MovePreviousItem = Nothing
        Me.BarraNavegacion.Name = "BarraNavegacion"
        Me.BarraNavegacion.PositionItem = Nothing
        Me.BarraNavegacion.Size = New System.Drawing.Size(495, 25)
        Me.BarraNavegacion.TabIndex = 34
        Me.BarraNavegacion.Text = "Navegación"
        '
        'BotonPrimero
        '
        Me.BotonPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BotonPrimero.Image = CType(resources.GetObject("BotonPrimero.Image"), System.Drawing.Image)
        Me.BotonPrimero.Name = "BotonPrimero"
        Me.BotonPrimero.RightToLeftAutoMirrorImage = True
        Me.BotonPrimero.Size = New System.Drawing.Size(23, 22)
        Me.BotonPrimero.Text = "Primero"
        '
        'BotonAnterior
        '
        Me.BotonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BotonAnterior.Image = CType(resources.GetObject("BotonAnterior.Image"), System.Drawing.Image)
        Me.BotonAnterior.Name = "BotonAnterior"
        Me.BotonAnterior.RightToLeftAutoMirrorImage = True
        Me.BotonAnterior.Size = New System.Drawing.Size(23, 22)
        Me.BotonAnterior.Text = "Anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'TxtPosicion
        '
        Me.TxtPosicion.AccessibleName = "Posición"
        Me.TxtPosicion.AutoSize = False
        Me.TxtPosicion.Name = "TxtPosicion"
        Me.TxtPosicion.Size = New System.Drawing.Size(50, 21)
        Me.TxtPosicion.Text = "0"
        Me.TxtPosicion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPosicion.ToolTipText = "Posición actual"
        '
        'LabelElementos
        '
        Me.LabelElementos.Name = "LabelElementos"
        Me.LabelElementos.Size = New System.Drawing.Size(38, 22)
        Me.LabelElementos.Text = "de {0}"
        Me.LabelElementos.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BotonSiguiente
        '
        Me.BotonSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BotonSiguiente.Image = CType(resources.GetObject("BotonSiguiente.Image"), System.Drawing.Image)
        Me.BotonSiguiente.Name = "BotonSiguiente"
        Me.BotonSiguiente.RightToLeftAutoMirrorImage = True
        Me.BotonSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.BotonSiguiente.Text = "Siguiente"
        '
        'BotonUltimo
        '
        Me.BotonUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BotonUltimo.Image = CType(resources.GetObject("BotonUltimo.Image"), System.Drawing.Image)
        Me.BotonUltimo.Name = "BotonUltimo"
        Me.BotonUltimo.RightToLeftAutoMirrorImage = True
        Me.BotonUltimo.Size = New System.Drawing.Size(23, 22)
        Me.BotonUltimo.Text = "Último"
        '
        'BarraEstado
        '
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsLblEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 300)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(495, 22)
        Me.BarraEstado.TabIndex = 33
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'TlsLblEstado
        '
        Me.TlsLblEstado.Name = "TlsLblEstado"
        Me.TlsLblEstado.Size = New System.Drawing.Size(0, 17)
        '
        'GbxContrato
        '
        Me.GbxContrato.Controls.Add(Me.DteFechaFinal)
        Me.GbxContrato.Controls.Add(Me.DteFechaInicio)
        Me.GbxContrato.Controls.Add(Me.LblFechaFinal)
        Me.GbxContrato.Controls.Add(Me.LblFechaInicio)
        Me.GbxContrato.Controls.Add(Me.CmbCargo)
        Me.GbxContrato.Controls.Add(Me.LblCargo)
        Me.GbxContrato.Controls.Add(Me.CmbDepartamento)
        Me.GbxContrato.Controls.Add(Me.LblDepartamento)
        Me.GbxContrato.Controls.Add(Me.TxtDescripcion)
        Me.GbxContrato.Controls.Add(Me.LblDescripción)
        Me.GbxContrato.Enabled = False
        Me.GbxContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxContrato.ForeColor = System.Drawing.Color.Green
        Me.GbxContrato.Location = New System.Drawing.Point(8, 60)
        Me.GbxContrato.Name = "GbxContrato"
        Me.GbxContrato.Size = New System.Drawing.Size(475, 205)
        Me.GbxContrato.TabIndex = 39
        Me.GbxContrato.TabStop = False
        Me.GbxContrato.Text = "Vacante"
        '
        'DteFechaFinal
        '
        Me.DteFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DteFechaFinal.Location = New System.Drawing.Point(323, 149)
        Me.DteFechaFinal.Name = "DteFechaFinal"
        Me.DteFechaFinal.Size = New System.Drawing.Size(88, 22)
        Me.DteFechaFinal.TabIndex = 39
        '
        'DteFechaInicio
        '
        Me.DteFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DteFechaInicio.Location = New System.Drawing.Point(124, 149)
        Me.DteFechaInicio.Name = "DteFechaInicio"
        Me.DteFechaInicio.Size = New System.Drawing.Size(88, 22)
        Me.DteFechaInicio.TabIndex = 47
        '
        'LblFechaFinal
        '
        Me.LblFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaFinal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFechaFinal.Location = New System.Drawing.Point(212, 152)
        Me.LblFechaFinal.Name = "LblFechaFinal"
        Me.LblFechaFinal.Size = New System.Drawing.Size(110, 16)
        Me.LblFechaFinal.TabIndex = 46
        Me.LblFechaFinal.Text = "Fecha Final:"
        Me.LblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFechaInicio.Location = New System.Drawing.Point(11, 152)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(110, 16)
        Me.LblFechaInicio.TabIndex = 44
        Me.LblFechaInicio.Text = "Fecha Inicio:"
        Me.LblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbCargo
        '
        Me.CmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCargo.FormattingEnabled = True
        Me.CmbCargo.Location = New System.Drawing.Point(124, 117)
        Me.CmbCargo.Name = "CmbCargo"
        Me.CmbCargo.Size = New System.Drawing.Size(147, 24)
        Me.CmbCargo.TabIndex = 36
        '
        'LblCargo
        '
        Me.LblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCargo.Location = New System.Drawing.Point(35, 120)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(86, 16)
        Me.LblCargo.TabIndex = 38
        Me.LblCargo.Text = "Cargo"
        Me.LblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(124, 87)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(147, 24)
        Me.CmbDepartamento.TabIndex = 35
        '
        'LblDepartamento
        '
        Me.LblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepartamento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDepartamento.Location = New System.Drawing.Point(14, 90)
        Me.LblDepartamento.Name = "LblDepartamento"
        Me.LblDepartamento.Size = New System.Drawing.Size(107, 16)
        Me.LblDepartamento.TabIndex = 37
        Me.LblDepartamento.Text = "Departamento"
        Me.LblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(124, 32)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(348, 49)
        Me.TxtDescripcion.TabIndex = 17
        '
        'LblDescripción
        '
        Me.LblDescripción.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripción.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDescripción.Location = New System.Drawing.Point(27, 35)
        Me.LblDescripción.Name = "LblDescripción"
        Me.LblDescripción.Size = New System.Drawing.Size(94, 16)
        Me.LblDescripción.TabIndex = 18
        Me.LblDescripción.Text = "Descripción:"
        Me.LblDescripción.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IUGestionarVacantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 322)
        Me.Controls.Add(Me.GbxContrato)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUGestionarVacantes"
        Me.Text = "Gestionar Vacantes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.GbxContrato.ResumeLayout(False)
        Me.GbxContrato.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsBtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsbtnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsBtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarraNavegacion As System.Windows.Forms.BindingNavigator
    Friend WithEvents BotonPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents BotonAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtPosicion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LabelElementos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BotonSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents BotonUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents TlsLblEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GbxContrato As System.Windows.Forms.GroupBox
    Friend WithEvents DteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DteFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents LblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents CmbCargo As System.Windows.Forms.ComboBox
    Friend WithEvents LblCargo As System.Windows.Forms.Label
    Friend WithEvents CmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents LblDepartamento As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripción As System.Windows.Forms.Label
End Class
