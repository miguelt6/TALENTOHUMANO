<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUVariables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUVariables))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TlsBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.TlsBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlsBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblNombreCorto = New System.Windows.Forms.Label()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.BtnCancelarPanel = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnBuscarPanel = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CmbFiltro = New System.Windows.Forms.ComboBox()
        Me.LabelFiltro = New System.Windows.Forms.Label()
        Me.DgridVariables = New System.Windows.Forms.DataGridView()
        Me.ColumnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerPanel = New System.Windows.Forms.Timer(Me.components)
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtNombreCorto = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.PanelBuscar.SuspendLayout()
        CType(Me.DgridVariables, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarraNavegacion.Location = New System.Drawing.Point(0, 166)
        Me.BarraNavegacion.MoveFirstItem = Nothing
        Me.BarraNavegacion.MoveLastItem = Nothing
        Me.BarraNavegacion.MoveNextItem = Nothing
        Me.BarraNavegacion.MovePreviousItem = Nothing
        Me.BarraNavegacion.Name = "BarraNavegacion"
        Me.BarraNavegacion.PositionItem = Nothing
        Me.BarraNavegacion.Size = New System.Drawing.Size(409, 25)
        Me.BarraNavegacion.TabIndex = 43
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
        Me.BarraEstado.Location = New System.Drawing.Point(0, 191)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(409, 22)
        Me.BarraEstado.TabIndex = 42
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsBtnNuevo, Me.TlsBtnModificar, Me.TlsBtnGuardar, Me.TlsBtnCancelar, Me.ToolStripSeparator1, Me.TlsBtnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(409, 48)
        Me.ToolStrip1.TabIndex = 41
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TlsBtnNuevo
        '
        Me.TlsBtnNuevo.AutoSize = False
        Me.TlsBtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlsBtnNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TlsBtnNuevo.Image = Global.WindowsApplication1.My.Resources.Resources.add
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
        Me.TlsBtnModificar.Image = Global.WindowsApplication1.My.Resources.Resources.edit
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
        'LblDescripcion
        '
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(12, 67)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(97, 16)
        Me.LblDescripcion.TabIndex = 37
        Me.LblDescripcion.Text = "Descripción"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNombreCorto
        '
        Me.LblNombreCorto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreCorto.Location = New System.Drawing.Point(12, 96)
        Me.LblNombreCorto.Name = "LblNombreCorto"
        Me.LblNombreCorto.Size = New System.Drawing.Size(97, 16)
        Me.LblNombreCorto.TabIndex = 44
        Me.LblNombreCorto.Text = "Nombre Corto"
        Me.LblNombreCorto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor
        '
        Me.LblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValor.Location = New System.Drawing.Point(12, 128)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(97, 16)
        Me.LblValor.TabIndex = 46
        Me.LblValor.Text = "Valor"
        Me.LblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelBuscar
        '
        Me.PanelBuscar.Controls.Add(Me.BtnCancelarPanel)
        Me.PanelBuscar.Controls.Add(Me.BtnSeleccionar)
        Me.PanelBuscar.Controls.Add(Me.BtnBuscarPanel)
        Me.PanelBuscar.Controls.Add(Me.TxtBusqueda)
        Me.PanelBuscar.Controls.Add(Me.CmbFiltro)
        Me.PanelBuscar.Controls.Add(Me.LabelFiltro)
        Me.PanelBuscar.Controls.Add(Me.DgridVariables)
        Me.PanelBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBuscar.Location = New System.Drawing.Point(0, -220)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(409, 209)
        Me.PanelBuscar.TabIndex = 50
        '
        'BtnCancelarPanel
        '
        Me.BtnCancelarPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarPanel.Image = CType(resources.GetObject("BtnCancelarPanel.Image"), System.Drawing.Image)
        Me.BtnCancelarPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarPanel.Location = New System.Drawing.Point(205, 181)
        Me.BtnCancelarPanel.Name = "BtnCancelarPanel"
        Me.BtnCancelarPanel.Size = New System.Drawing.Size(78, 25)
        Me.BtnCancelarPanel.TabIndex = 7
        Me.BtnCancelarPanel.Text = "Cancelar"
        Me.BtnCancelarPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelarPanel.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.Image = CType(resources.GetObject("BtnSeleccionar.Image"), System.Drawing.Image)
        Me.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionar.Location = New System.Drawing.Point(113, 181)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(86, 25)
        Me.BtnSeleccionar.TabIndex = 6
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscarPanel
        '
        Me.BtnBuscarPanel.Image = CType(resources.GetObject("BtnBuscarPanel.Image"), System.Drawing.Image)
        Me.BtnBuscarPanel.Location = New System.Drawing.Point(354, 11)
        Me.BtnBuscarPanel.Name = "BtnBuscarPanel"
        Me.BtnBuscarPanel.Size = New System.Drawing.Size(45, 23)
        Me.BtnBuscarPanel.TabIndex = 5
        Me.BtnBuscarPanel.UseVisualStyleBackColor = True
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(187, 11)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(161, 22)
        Me.TxtBusqueda.TabIndex = 4
        '
        'CmbFiltro
        '
        Me.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFiltro.FormattingEnabled = True
        Me.CmbFiltro.Items.AddRange(New Object() {"Nombre Corto", "Descripcion"})
        Me.CmbFiltro.Location = New System.Drawing.Point(77, 12)
        Me.CmbFiltro.Name = "CmbFiltro"
        Me.CmbFiltro.Size = New System.Drawing.Size(104, 24)
        Me.CmbFiltro.TabIndex = 3
        '
        'LabelFiltro
        '
        Me.LabelFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro.Location = New System.Drawing.Point(3, 15)
        Me.LabelFiltro.Name = "LabelFiltro"
        Me.LabelFiltro.Size = New System.Drawing.Size(77, 16)
        Me.LabelFiltro.TabIndex = 2
        Me.LabelFiltro.Text = "Buscar Por:"
        Me.LabelFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgridVariables
        '
        Me.DgridVariables.AllowUserToAddRows = False
        Me.DgridVariables.AllowUserToDeleteRows = False
        Me.DgridVariables.AllowUserToResizeColumns = False
        Me.DgridVariables.AllowUserToResizeRows = False
        Me.DgridVariables.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridVariables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgridVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaNombre, Me.ColumnaDescripcion, Me.Posicion})
        Me.DgridVariables.Location = New System.Drawing.Point(26, 42)
        Me.DgridVariables.Name = "DgridVariables"
        Me.DgridVariables.ReadOnly = True
        Me.DgridVariables.RowHeadersVisible = False
        Me.DgridVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridVariables.Size = New System.Drawing.Size(357, 133)
        Me.DgridVariables.TabIndex = 0
        '
        'ColumnaNombre
        '
        Me.ColumnaNombre.HeaderText = "Nombre Corto"
        Me.ColumnaNombre.Name = "ColumnaNombre"
        Me.ColumnaNombre.ReadOnly = True
        Me.ColumnaNombre.Width = 200
        '
        'ColumnaDescripcion
        '
        Me.ColumnaDescripcion.HeaderText = "Descripción"
        Me.ColumnaDescripcion.Name = "ColumnaDescripcion"
        Me.ColumnaDescripcion.ReadOnly = True
        Me.ColumnaDescripcion.Width = 150
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posicion"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.ReadOnly = True
        Me.Posicion.Visible = False
        '
        'TimerPanel
        '
        Me.TimerPanel.Interval = 1
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(115, 66)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(249, 20)
        Me.TxtDescripcion.TabIndex = 51
        '
        'TxtNombreCorto
        '
        Me.TxtNombreCorto.Enabled = False
        Me.TxtNombreCorto.Location = New System.Drawing.Point(115, 95)
        Me.TxtNombreCorto.Name = "TxtNombreCorto"
        Me.TxtNombreCorto.Size = New System.Drawing.Size(249, 20)
        Me.TxtNombreCorto.TabIndex = 52
        '
        'TxtValor
        '
        Me.TxtValor.Enabled = False
        Me.TxtValor.Location = New System.Drawing.Point(115, 127)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(249, 20)
        Me.TxtValor.TabIndex = 53
        '
        'IUVariables
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(409, 213)
        Me.Controls.Add(Me.PanelBuscar)
        Me.Controls.Add(Me.LblValor)
        Me.Controls.Add(Me.LblNombreCorto)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.TxtNombreCorto)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUVariables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variables"
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanelBuscar.ResumeLayout(False)
        Me.PanelBuscar.PerformLayout()
        CType(Me.DgridVariables, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TlsBtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlsBtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TlsBtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents LblNombreCorto As System.Windows.Forms.Label
    Friend WithEvents LblValor As System.Windows.Forms.Label
    Friend WithEvents PanelBuscar As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelarPanel As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarPanel As System.Windows.Forms.Button
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents CmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents LabelFiltro As System.Windows.Forms.Label
    Friend WithEvents DgridVariables As System.Windows.Forms.DataGridView
    Friend WithEvents TimerPanel As System.Windows.Forms.Timer
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreCorto As System.Windows.Forms.TextBox
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents ColumnaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Posicion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
