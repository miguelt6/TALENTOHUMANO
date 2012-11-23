<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUPrestamo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TlsBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnCancelar = New System.Windows.Forms.ToolStripButton()
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
        Me.TimerPanel = New System.Windows.Forms.Timer(Me.components)
        Me.GbxPersona = New System.Windows.Forms.GroupBox()
        Me.LblPosicion = New System.Windows.Forms.Label()
        Me.LblDatoNombre = New System.Windows.Forms.Label()
        Me.LblDatoCedula = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.GbxPrestamo = New System.Windows.Forms.GroupBox()
        Me.BtnCuota = New System.Windows.Forms.Button()
        Me.LblMontoCuotaValor = New System.Windows.Forms.Label()
        Me.CmbCobro = New System.Windows.Forms.ComboBox()
        Me.LblCobro = New System.Windows.Forms.Label()
        Me.TxtNumCuotas = New System.Windows.Forms.TextBox()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.CmbPago = New System.Windows.Forms.ComboBox()
        Me.LblPago = New System.Windows.Forms.Label()
        Me.LblNumCuotas = New System.Windows.Forms.Label()
        Me.DteFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.PanelBuscarPersonas = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCancelarPanel = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnBuscarPanel = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CmbFiltro = New System.Windows.Forms.ComboBox()
        Me.LblFiltro = New System.Windows.Forms.Label()
        Me.DgridPersonas = New System.Windows.Forms.DataGridView()
        Me.CeldaCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CeldaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.GbxPersona.SuspendLayout()
        Me.GbxPrestamo.SuspendLayout()
        Me.PanelBuscarPersonas.SuspendLayout()
        CType(Me.DgridPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsBtnNuevo, Me.TlsBtnModificar, Me.TlsBtnGuardar, Me.TlsBtnCancelar, Me.ToolStripSeparator1, Me.TlsBtnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(501, 48)
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
        Me.TlsBtnModificar.Visible = False
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
        'BarraNavegacion
        '
        Me.BarraNavegacion.AddNewItem = Nothing
        Me.BarraNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BarraNavegacion.CountItem = Nothing
        Me.BarraNavegacion.DeleteItem = Nothing
        Me.BarraNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarraNavegacion.Enabled = False
        Me.BarraNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonPrimero, Me.BotonAnterior, Me.BindingNavigatorSeparator, Me.TxtPosicion, Me.LabelElementos, Me.BindingNavigatorSeparator1, Me.BotonSiguiente, Me.BotonUltimo})
        Me.BarraNavegacion.Location = New System.Drawing.Point(0, 367)
        Me.BarraNavegacion.MoveFirstItem = Nothing
        Me.BarraNavegacion.MoveLastItem = Nothing
        Me.BarraNavegacion.MoveNextItem = Nothing
        Me.BarraNavegacion.MovePreviousItem = Nothing
        Me.BarraNavegacion.Name = "BarraNavegacion"
        Me.BarraNavegacion.PositionItem = Nothing
        Me.BarraNavegacion.Size = New System.Drawing.Size(501, 25)
        Me.BarraNavegacion.TabIndex = 34
        Me.BarraNavegacion.Text = "Navegación"
        Me.BarraNavegacion.Visible = False
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
        Me.BarraEstado.Location = New System.Drawing.Point(0, 392)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(501, 22)
        Me.BarraEstado.TabIndex = 33
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'TlsLblEstado
        '
        Me.TlsLblEstado.Name = "TlsLblEstado"
        Me.TlsLblEstado.Size = New System.Drawing.Size(0, 17)
        '
        'TimerPanel
        '
        Me.TimerPanel.Interval = 1
        '
        'GbxPersona
        '
        Me.GbxPersona.Controls.Add(Me.LblPosicion)
        Me.GbxPersona.Controls.Add(Me.LblDatoNombre)
        Me.GbxPersona.Controls.Add(Me.LblDatoCedula)
        Me.GbxPersona.Controls.Add(Me.LblNombre)
        Me.GbxPersona.Controls.Add(Me.LblCedula)
        Me.GbxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxPersona.ForeColor = System.Drawing.Color.Green
        Me.GbxPersona.Location = New System.Drawing.Point(12, 60)
        Me.GbxPersona.Name = "GbxPersona"
        Me.GbxPersona.Size = New System.Drawing.Size(478, 97)
        Me.GbxPersona.TabIndex = 38
        Me.GbxPersona.TabStop = False
        Me.GbxPersona.Text = "Datos de la Persona"
        '
        'LblPosicion
        '
        Me.LblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPosicion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPosicion.Location = New System.Drawing.Point(14, 33)
        Me.LblPosicion.Name = "LblPosicion"
        Me.LblPosicion.Size = New System.Drawing.Size(31, 16)
        Me.LblPosicion.TabIndex = 41
        Me.LblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblPosicion.Visible = False
        '
        'LblDatoNombre
        '
        Me.LblDatoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatoNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDatoNombre.Location = New System.Drawing.Point(138, 61)
        Me.LblDatoNombre.Name = "LblDatoNombre"
        Me.LblDatoNombre.Size = New System.Drawing.Size(316, 16)
        Me.LblDatoNombre.TabIndex = 40
        Me.LblDatoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDatoCedula
        '
        Me.LblDatoCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatoCedula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDatoCedula.Location = New System.Drawing.Point(138, 33)
        Me.LblDatoCedula.Name = "LblDatoCedula"
        Me.LblDatoCedula.Size = New System.Drawing.Size(316, 16)
        Me.LblDatoCedula.TabIndex = 39
        Me.LblDatoCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNombre.Location = New System.Drawing.Point(6, 61)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(126, 16)
        Me.LblNombre.TabIndex = 38
        Me.LblNombre.Text = "Nombre y Apellido:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCedula
        '
        Me.LblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCedula.Location = New System.Drawing.Point(55, 33)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(77, 16)
        Me.LblCedula.TabIndex = 37
        Me.LblCedula.Text = "Cédula:"
        Me.LblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GbxPrestamo
        '
        Me.GbxPrestamo.Controls.Add(Me.BtnCuota)
        Me.GbxPrestamo.Controls.Add(Me.LblMontoCuotaValor)
        Me.GbxPrestamo.Controls.Add(Me.CmbCobro)
        Me.GbxPrestamo.Controls.Add(Me.LblCobro)
        Me.GbxPrestamo.Controls.Add(Me.TxtNumCuotas)
        Me.GbxPrestamo.Controls.Add(Me.TxtMonto)
        Me.GbxPrestamo.Controls.Add(Me.LblMonto)
        Me.GbxPrestamo.Controls.Add(Me.CmbPago)
        Me.GbxPrestamo.Controls.Add(Me.LblPago)
        Me.GbxPrestamo.Controls.Add(Me.LblNumCuotas)
        Me.GbxPrestamo.Controls.Add(Me.DteFechaInicio)
        Me.GbxPrestamo.Controls.Add(Me.LblFechaInicio)
        Me.GbxPrestamo.Enabled = False
        Me.GbxPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxPrestamo.ForeColor = System.Drawing.Color.Green
        Me.GbxPrestamo.Location = New System.Drawing.Point(12, 163)
        Me.GbxPrestamo.Name = "GbxPrestamo"
        Me.GbxPrestamo.Size = New System.Drawing.Size(478, 192)
        Me.GbxPrestamo.TabIndex = 39
        Me.GbxPrestamo.TabStop = False
        Me.GbxPrestamo.Text = "Prestamo"
        '
        'BtnCuota
        '
        Me.BtnCuota.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCuota.Location = New System.Drawing.Point(337, 27)
        Me.BtnCuota.Name = "BtnCuota"
        Me.BtnCuota.Size = New System.Drawing.Size(106, 28)
        Me.BtnCuota.TabIndex = 58
        Me.BtnCuota.Text = "Calcular Cuota"
        Me.BtnCuota.UseVisualStyleBackColor = True
        '
        'LblMontoCuotaValor
        '
        Me.LblMontoCuotaValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoCuotaValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblMontoCuotaValor.Location = New System.Drawing.Point(333, 63)
        Me.LblMontoCuotaValor.Name = "LblMontoCuotaValor"
        Me.LblMontoCuotaValor.Size = New System.Drawing.Size(121, 32)
        Me.LblMontoCuotaValor.TabIndex = 57
        Me.LblMontoCuotaValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCobro
        '
        Me.CmbCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCobro.Enabled = False
        Me.CmbCobro.FormattingEnabled = True
        Me.CmbCobro.Items.AddRange(New Object() {"Los 15", "Los 30"})
        Me.CmbCobro.Location = New System.Drawing.Point(127, 120)
        Me.CmbCobro.Name = "CmbCobro"
        Me.CmbCobro.Size = New System.Drawing.Size(147, 24)
        Me.CmbCobro.TabIndex = 55
        '
        'LblCobro
        '
        Me.LblCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCobro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCobro.Location = New System.Drawing.Point(53, 123)
        Me.LblCobro.Name = "LblCobro"
        Me.LblCobro.Size = New System.Drawing.Size(73, 16)
        Me.LblCobro.TabIndex = 54
        Me.LblCobro.Text = "Cobro"
        Me.LblCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNumCuotas
        '
        Me.TxtNumCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumCuotas.Location = New System.Drawing.Point(127, 57)
        Me.TxtNumCuotas.MaxLength = 2
        Me.TxtNumCuotas.Name = "TxtNumCuotas"
        Me.TxtNumCuotas.Size = New System.Drawing.Size(41, 22)
        Me.TxtNumCuotas.TabIndex = 49
        '
        'TxtMonto
        '
        Me.TxtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMonto.Location = New System.Drawing.Point(127, 30)
        Me.TxtMonto.MaxLength = 15
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(147, 22)
        Me.TxtMonto.TabIndex = 48
        '
        'LblMonto
        '
        Me.LblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblMonto.Location = New System.Drawing.Point(17, 33)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(110, 16)
        Me.LblMonto.TabIndex = 42
        Me.LblMonto.Text = "Monto Prestamo"
        Me.LblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbPago
        '
        Me.CmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPago.FormattingEnabled = True
        Me.CmbPago.Items.AddRange(New Object() {"Quincenal", "Mensual"})
        Me.CmbPago.Location = New System.Drawing.Point(127, 90)
        Me.CmbPago.Name = "CmbPago"
        Me.CmbPago.Size = New System.Drawing.Size(147, 24)
        Me.CmbPago.TabIndex = 2
        '
        'LblPago
        '
        Me.LblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPago.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPago.Location = New System.Drawing.Point(11, 93)
        Me.LblPago.Name = "LblPago"
        Me.LblPago.Size = New System.Drawing.Size(115, 16)
        Me.LblPago.TabIndex = 38
        Me.LblPago.Text = "Forma de Pago"
        Me.LblPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNumCuotas
        '
        Me.LblNumCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumCuotas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNumCuotas.Location = New System.Drawing.Point(6, 60)
        Me.LblNumCuotas.Name = "LblNumCuotas"
        Me.LblNumCuotas.Size = New System.Drawing.Size(121, 16)
        Me.LblNumCuotas.TabIndex = 40
        Me.LblNumCuotas.Text = "Número de Cuotas"
        Me.LblNumCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DteFechaInicio
        '
        Me.DteFechaInicio.Enabled = False
        Me.DteFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DteFechaInicio.Location = New System.Drawing.Point(127, 152)
        Me.DteFechaInicio.Name = "DteFechaInicio"
        Me.DteFechaInicio.Size = New System.Drawing.Size(88, 22)
        Me.DteFechaInicio.TabIndex = 5
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblFechaInicio.Location = New System.Drawing.Point(17, 155)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(110, 16)
        Me.LblFechaInicio.TabIndex = 44
        Me.LblFechaInicio.Text = "Fecha Inicio"
        Me.LblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelBuscarPersonas
        '
        Me.PanelBuscarPersonas.BackColor = System.Drawing.SystemColors.Control
        Me.PanelBuscarPersonas.Controls.Add(Me.BtnBuscar)
        Me.PanelBuscarPersonas.Controls.Add(Me.BtnCancelarPanel)
        Me.PanelBuscarPersonas.Controls.Add(Me.BtnSeleccionar)
        Me.PanelBuscarPersonas.Controls.Add(Me.BtnBuscarPanel)
        Me.PanelBuscarPersonas.Controls.Add(Me.TxtBusqueda)
        Me.PanelBuscarPersonas.Controls.Add(Me.CmbFiltro)
        Me.PanelBuscarPersonas.Controls.Add(Me.LblFiltro)
        Me.PanelBuscarPersonas.Controls.Add(Me.DgridPersonas)
        Me.PanelBuscarPersonas.Location = New System.Drawing.Point(0, -425)
        Me.PanelBuscarPersonas.Name = "PanelBuscarPersonas"
        Me.PanelBuscarPersonas.Size = New System.Drawing.Size(501, 420)
        Me.PanelBuscarPersonas.TabIndex = 41
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(429, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(45, 23)
        Me.BtnBuscar.TabIndex = 15
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCancelarPanel
        '
        Me.BtnCancelarPanel.Image = CType(resources.GetObject("BtnCancelarPanel.Image"), System.Drawing.Image)
        Me.BtnCancelarPanel.Location = New System.Drawing.Point(267, 371)
        Me.BtnCancelarPanel.Name = "BtnCancelarPanel"
        Me.BtnCancelarPanel.Size = New System.Drawing.Size(122, 35)
        Me.BtnCancelarPanel.TabIndex = 14
        Me.BtnCancelarPanel.Text = "Cancelar"
        Me.BtnCancelarPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelarPanel.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Image = CType(resources.GetObject("BtnSeleccionar.Image"), System.Drawing.Image)
        Me.BtnSeleccionar.Location = New System.Drawing.Point(129, 371)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(122, 35)
        Me.BtnSeleccionar.TabIndex = 13
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscarPanel
        '
        Me.BtnBuscarPanel.Image = CType(resources.GetObject("BtnBuscarPanel.Image"), System.Drawing.Image)
        Me.BtnBuscarPanel.Location = New System.Drawing.Point(524, 14)
        Me.BtnBuscarPanel.Name = "BtnBuscarPanel"
        Me.BtnBuscarPanel.Size = New System.Drawing.Size(45, 23)
        Me.BtnBuscarPanel.TabIndex = 12
        Me.BtnBuscarPanel.UseVisualStyleBackColor = True
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(209, 14)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(214, 20)
        Me.TxtBusqueda.TabIndex = 11
        '
        'CmbFiltro
        '
        Me.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFiltro.FormattingEnabled = True
        Me.CmbFiltro.Items.AddRange(New Object() {"Cedula", "Nombre", "Apellido"})
        Me.CmbFiltro.Location = New System.Drawing.Point(82, 14)
        Me.CmbFiltro.Name = "CmbFiltro"
        Me.CmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.CmbFiltro.TabIndex = 10
        '
        'LblFiltro
        '
        Me.LblFiltro.AutoSize = True
        Me.LblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltro.Location = New System.Drawing.Point(5, 17)
        Me.LblFiltro.Name = "LblFiltro"
        Me.LblFiltro.Size = New System.Drawing.Size(71, 16)
        Me.LblFiltro.TabIndex = 9
        Me.LblFiltro.Text = "Buscar en:"
        '
        'DgridPersonas
        '
        Me.DgridPersonas.AllowUserToAddRows = False
        Me.DgridPersonas.AllowUserToDeleteRows = False
        Me.DgridPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridPersonas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CeldaCedula, Me.CeldaNombre, Me.Posicion})
        Me.DgridPersonas.Location = New System.Drawing.Point(54, 45)
        Me.DgridPersonas.Name = "DgridPersonas"
        Me.DgridPersonas.ReadOnly = True
        Me.DgridPersonas.RowHeadersVisible = False
        Me.DgridPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridPersonas.Size = New System.Drawing.Size(379, 304)
        Me.DgridPersonas.TabIndex = 8
        '
        'CeldaCedula
        '
        Me.CeldaCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CeldaCedula.HeaderText = "Cedula"
        Me.CeldaCedula.Name = "CeldaCedula"
        Me.CeldaCedula.ReadOnly = True
        '
        'CeldaNombre
        '
        Me.CeldaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CeldaNombre.HeaderText = "Nombre"
        Me.CeldaNombre.Name = "CeldaNombre"
        Me.CeldaNombre.ReadOnly = True
        Me.CeldaNombre.Width = 270
        '
        'Posicion
        '
        Me.Posicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Posicion.HeaderText = "Posicion"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.ReadOnly = True
        Me.Posicion.Visible = False
        Me.Posicion.Width = 22
        '
        'IUPrestamo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(501, 414)
        Me.Controls.Add(Me.PanelBuscarPersonas)
        Me.Controls.Add(Me.GbxPrestamo)
        Me.Controls.Add(Me.GbxPersona)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUPrestamo"
        Me.Text = "Procesar Prestamos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.GbxPersona.ResumeLayout(False)
        Me.GbxPrestamo.ResumeLayout(False)
        Me.GbxPrestamo.PerformLayout()
        Me.PanelBuscarPersonas.ResumeLayout(False)
        Me.PanelBuscarPersonas.PerformLayout()
        CType(Me.DgridPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TlsBtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnCancelar As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents TimerPanel As System.Windows.Forms.Timer
    Friend WithEvents GbxPersona As System.Windows.Forms.GroupBox
    Friend WithEvents LblPosicion As System.Windows.Forms.Label
    Friend WithEvents LblDatoNombre As System.Windows.Forms.Label
    Friend WithEvents LblDatoCedula As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCedula As System.Windows.Forms.Label
    Friend WithEvents GbxPrestamo As System.Windows.Forms.GroupBox
    Friend WithEvents CmbCobro As System.Windows.Forms.ComboBox
    Friend WithEvents LblCobro As System.Windows.Forms.Label
    Friend WithEvents TxtNumCuotas As System.Windows.Forms.TextBox
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents LblMonto As System.Windows.Forms.Label
    Friend WithEvents CmbPago As System.Windows.Forms.ComboBox
    Friend WithEvents LblPago As System.Windows.Forms.Label
    Friend WithEvents LblNumCuotas As System.Windows.Forms.Label
    Friend WithEvents DteFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents LblMontoCuotaValor As System.Windows.Forms.Label
    Friend WithEvents PanelBuscarPersonas As System.Windows.Forms.Panel
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelarPanel As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarPanel As System.Windows.Forms.Button
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents CmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents LblFiltro As System.Windows.Forms.Label
    Friend WithEvents DgridPersonas As System.Windows.Forms.DataGridView
    Friend WithEvents CeldaCedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CeldaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Posicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCuota As System.Windows.Forms.Button
End Class
