<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUCalculoNomina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUCalculoNomina))
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TlsBtnNueva = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.GbxNomina = New System.Windows.Forms.GroupBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.DteFechaNomina = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaNomina = New System.Windows.Forms.Label()
        Me.GbxDetalleNomina = New System.Windows.Forms.GroupBox()
        Me.DgridDetalleNomina = New System.Windows.Forms.DataGridView()
        Me.Concepto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MontoAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDeduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblPosicion = New System.Windows.Forms.Label()
        Me.LblDatoNombre = New System.Windows.Forms.Label()
        Me.LblDatoCedula = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GbxNomina.SuspendLayout()
        Me.GbxDetalleNomina.SuspendLayout()
        CType(Me.DgridDetalleNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarraNavegacion.Location = New System.Drawing.Point(0, 442)
        Me.BarraNavegacion.MoveFirstItem = Nothing
        Me.BarraNavegacion.MoveLastItem = Nothing
        Me.BarraNavegacion.MoveNextItem = Nothing
        Me.BarraNavegacion.MovePreviousItem = Nothing
        Me.BarraNavegacion.Name = "BarraNavegacion"
        Me.BarraNavegacion.PositionItem = Nothing
        Me.BarraNavegacion.Size = New System.Drawing.Size(481, 25)
        Me.BarraNavegacion.TabIndex = 37
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
        Me.BarraEstado.Location = New System.Drawing.Point(0, 467)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(481, 22)
        Me.BarraEstado.TabIndex = 36
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'TlsLblEstado
        '
        Me.TlsLblEstado.Name = "TlsLblEstado"
        Me.TlsLblEstado.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsBtnNueva, Me.TlsBtnModificar, Me.TlsBtnGuardar, Me.TlsBtnCancelar, Me.ToolStripSeparator1, Me.TlsBtnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(481, 48)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TlsBtnNueva
        '
        Me.TlsBtnNueva.AutoSize = False
        Me.TlsBtnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnNueva.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnNueva.Image = Global.WindowsApplication1.My.Resources.Resources.document_add241
        Me.TlsBtnNueva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlsBtnNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlsBtnNueva.Name = "TlsBtnNueva"
        Me.TlsBtnNueva.Size = New System.Drawing.Size(65, 45)
        Me.TlsBtnNueva.Text = "&Nueva"
        Me.TlsBtnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TlsBtnNueva.ToolTipText = "Agregar Persona"
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
        'GbxNomina
        '
        Me.GbxNomina.Controls.Add(Me.BtnGenerar)
        Me.GbxNomina.Controls.Add(Me.DteFechaNomina)
        Me.GbxNomina.Controls.Add(Me.LblFechaNomina)
        Me.GbxNomina.Enabled = False
        Me.GbxNomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxNomina.ForeColor = System.Drawing.Color.Green
        Me.GbxNomina.Location = New System.Drawing.Point(12, 60)
        Me.GbxNomina.Name = "GbxNomina"
        Me.GbxNomina.Size = New System.Drawing.Size(457, 79)
        Me.GbxNomina.TabIndex = 40
        Me.GbxNomina.TabStop = False
        Me.GbxNomina.Text = "Nómina"
        '
        'BtnGenerar
        '
        Me.BtnGenerar.ForeColor = System.Drawing.Color.Black
        Me.BtnGenerar.Image = Global.WindowsApplication1.My.Resources.Resources.package_view2
        Me.BtnGenerar.Location = New System.Drawing.Point(338, 26)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(96, 31)
        Me.BtnGenerar.TabIndex = 45
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'DteFechaNomina
        '
        Me.DteFechaNomina.Enabled = False
        Me.DteFechaNomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFechaNomina.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DteFechaNomina.Location = New System.Drawing.Point(122, 30)
        Me.DteFechaNomina.Name = "DteFechaNomina"
        Me.DteFechaNomina.Size = New System.Drawing.Size(88, 22)
        Me.DteFechaNomina.TabIndex = 5
        '
        'LblFechaNomina
        '
        Me.LblFechaNomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaNomina.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFechaNomina.Location = New System.Drawing.Point(6, 33)
        Me.LblFechaNomina.Name = "LblFechaNomina"
        Me.LblFechaNomina.Size = New System.Drawing.Size(110, 16)
        Me.LblFechaNomina.TabIndex = 44
        Me.LblFechaNomina.Text = "Fecha Nómina"
        Me.LblFechaNomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GbxDetalleNomina
        '
        Me.GbxDetalleNomina.Controls.Add(Me.DgridDetalleNomina)
        Me.GbxDetalleNomina.Controls.Add(Me.LblPosicion)
        Me.GbxDetalleNomina.Controls.Add(Me.LblDatoNombre)
        Me.GbxDetalleNomina.Controls.Add(Me.LblDatoCedula)
        Me.GbxDetalleNomina.Controls.Add(Me.LblNombre)
        Me.GbxDetalleNomina.Controls.Add(Me.LblCedula)
        Me.GbxDetalleNomina.Enabled = False
        Me.GbxDetalleNomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxDetalleNomina.ForeColor = System.Drawing.Color.Green
        Me.GbxDetalleNomina.Location = New System.Drawing.Point(11, 145)
        Me.GbxDetalleNomina.Name = "GbxDetalleNomina"
        Me.GbxDetalleNomina.Size = New System.Drawing.Size(458, 287)
        Me.GbxDetalleNomina.TabIndex = 42
        Me.GbxDetalleNomina.TabStop = False
        Me.GbxDetalleNomina.Text = "Detalle Nómina"
        '
        'DgridDetalleNomina
        '
        Me.DgridDetalleNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridDetalleNomina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Concepto, Me.MontoAsignacion, Me.MontoDeduccion})
        Me.DgridDetalleNomina.Location = New System.Drawing.Point(12, 92)
        Me.DgridDetalleNomina.Name = "DgridDetalleNomina"
        Me.DgridDetalleNomina.Size = New System.Drawing.Size(440, 189)
        Me.DgridDetalleNomina.TabIndex = 48
        '
        'Concepto
        '
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Concepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MontoAsignacion
        '
        Me.MontoAsignacion.HeaderText = "Asignacion"
        Me.MontoAsignacion.Name = "MontoAsignacion"
        '
        'MontoDeduccion
        '
        Me.MontoDeduccion.HeaderText = "Deduccion"
        Me.MontoDeduccion.Name = "MontoDeduccion"
        '
        'LblPosicion
        '
        Me.LblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPosicion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPosicion.Location = New System.Drawing.Point(17, 32)
        Me.LblPosicion.Name = "LblPosicion"
        Me.LblPosicion.Size = New System.Drawing.Size(31, 16)
        Me.LblPosicion.TabIndex = 47
        Me.LblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblPosicion.Visible = False
        '
        'LblDatoNombre
        '
        Me.LblDatoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatoNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDatoNombre.Location = New System.Drawing.Point(141, 60)
        Me.LblDatoNombre.Name = "LblDatoNombre"
        Me.LblDatoNombre.Size = New System.Drawing.Size(298, 16)
        Me.LblDatoNombre.TabIndex = 46
        Me.LblDatoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDatoCedula
        '
        Me.LblDatoCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatoCedula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDatoCedula.Location = New System.Drawing.Point(141, 32)
        Me.LblDatoCedula.Name = "LblDatoCedula"
        Me.LblDatoCedula.Size = New System.Drawing.Size(298, 16)
        Me.LblDatoCedula.TabIndex = 45
        Me.LblDatoCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNombre.Location = New System.Drawing.Point(9, 60)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(126, 16)
        Me.LblNombre.TabIndex = 44
        Me.LblNombre.Text = "Nombre y Apellido:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCedula
        '
        Me.LblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCedula.Location = New System.Drawing.Point(58, 32)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(77, 16)
        Me.LblCedula.TabIndex = 43
        Me.LblCedula.Text = "Cédula:"
        Me.LblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IUCalculoNomina
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(481, 489)
        Me.Controls.Add(Me.GbxDetalleNomina)
        Me.Controls.Add(Me.GbxNomina)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IUCalculoNomina"
        Me.Text = "Calculo de Nomina"
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GbxNomina.ResumeLayout(False)
        Me.GbxDetalleNomina.ResumeLayout(False)
        CType(Me.DgridDetalleNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsBtnNueva As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsBtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GbxNomina As System.Windows.Forms.GroupBox
    Friend WithEvents DteFechaNomina As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaNomina As System.Windows.Forms.Label
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents GbxDetalleNomina As System.Windows.Forms.GroupBox
    Friend WithEvents LblPosicion As System.Windows.Forms.Label
    Friend WithEvents LblDatoNombre As System.Windows.Forms.Label
    Friend WithEvents LblDatoCedula As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCedula As System.Windows.Forms.Label
    Friend WithEvents DgridDetalleNomina As System.Windows.Forms.DataGridView
    Friend WithEvents Concepto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents MontoAsignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDeduccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
