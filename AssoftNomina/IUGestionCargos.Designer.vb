<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUGestionCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUGestionCargos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BarraOpciones = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separador = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.TxtDescripcionCargo = New System.Windows.Forms.RichTextBox()
        Me.TxtNombreCargo = New System.Windows.Forms.TextBox()
        Me.LblDescripcionCargo = New System.Windows.Forms.Label()
        Me.LblNombreCargo = New System.Windows.Forms.Label()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.LblDepartamento = New System.Windows.Forms.Label()
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.BtnCancelarPanel = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnBuscarPanel = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CmbFiltro = New System.Windows.Forms.ComboBox()
        Me.LabelFiltro = New System.Windows.Forms.Label()
        Me.DgridCargos = New System.Windows.Forms.DataGridView()
        Me.ColumnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerPanel = New System.Windows.Forms.Timer(Me.components)
        Me.LabelEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BarraEstado = New System.Windows.Forms.StatusStrip()
        Me.BotonPrimero = New System.Windows.Forms.ToolStripButton()
        Me.BotonAnterior = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.TxtPosicion = New System.Windows.Forms.ToolStripTextBox()
        Me.LabelElementos = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotonSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.BotonUltimo = New System.Windows.Forms.ToolStripButton()
        Me.BarraNavegacion = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BarraOpciones.SuspendLayout()
        Me.PanelBuscar.SuspendLayout()
        CType(Me.DgridCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraOpciones
        '
        Me.BarraOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BarraOpciones.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BarraOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnModificar, Me.BtnGuardar, Me.BtnCancelar, Me.Separador, Me.BtnBuscar})
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 0)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Size = New System.Drawing.Size(499, 47)
        Me.BarraOpciones.TabIndex = 1
        Me.BarraOpciones.Text = "Opciones"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(52, 44)
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnModificar
        '
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 44)
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(61, 44)
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 44)
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Separador
        '
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 47)
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Enabled = False
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(54, 44)
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TxtDescripcionCargo
        '
        Me.TxtDescripcionCargo.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDescripcionCargo.Enabled = False
        Me.TxtDescripcionCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionCargo.Location = New System.Drawing.Point(115, 82)
        Me.TxtDescripcionCargo.MaxLength = 250
        Me.TxtDescripcionCargo.Name = "TxtDescripcionCargo"
        Me.TxtDescripcionCargo.Size = New System.Drawing.Size(363, 96)
        Me.TxtDescripcionCargo.TabIndex = 16
        Me.TxtDescripcionCargo.Text = ""
        '
        'TxtNombreCargo
        '
        Me.TxtNombreCargo.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNombreCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreCargo.Enabled = False
        Me.TxtNombreCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCargo.Location = New System.Drawing.Point(115, 56)
        Me.TxtNombreCargo.MaxLength = 55
        Me.TxtNombreCargo.Name = "TxtNombreCargo"
        Me.TxtNombreCargo.Size = New System.Drawing.Size(363, 22)
        Me.TxtNombreCargo.TabIndex = 15
        '
        'LblDescripcionCargo
        '
        Me.LblDescripcionCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcionCargo.Location = New System.Drawing.Point(12, 122)
        Me.LblDescripcionCargo.Name = "LblDescripcionCargo"
        Me.LblDescripcionCargo.Size = New System.Drawing.Size(97, 16)
        Me.LblDescripcionCargo.TabIndex = 14
        Me.LblDescripcionCargo.Text = "Descripción:"
        Me.LblDescripcionCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNombreCargo
        '
        Me.LblNombreCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreCargo.Location = New System.Drawing.Point(12, 57)
        Me.LblNombreCargo.Name = "LblNombreCargo"
        Me.LblNombreCargo.Size = New System.Drawing.Size(97, 16)
        Me.LblNombreCargo.TabIndex = 13
        Me.LblNombreCargo.Text = "Nombre:"
        Me.LblNombreCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.BackColor = System.Drawing.SystemColors.Control
        Me.CmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDepartamento.Enabled = False
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(115, 184)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(363, 21)
        Me.CmbDepartamento.TabIndex = 18
        '
        'LblDepartamento
        '
        Me.LblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepartamento.Location = New System.Drawing.Point(12, 185)
        Me.LblDepartamento.Name = "LblDepartamento"
        Me.LblDepartamento.Size = New System.Drawing.Size(97, 16)
        Me.LblDepartamento.TabIndex = 19
        Me.LblDepartamento.Text = "Departamento:"
        Me.LblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelBuscar
        '
        Me.PanelBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelBuscar.Controls.Add(Me.BtnCancelarPanel)
        Me.PanelBuscar.Controls.Add(Me.BtnSeleccionar)
        Me.PanelBuscar.Controls.Add(Me.BtnBuscarPanel)
        Me.PanelBuscar.Controls.Add(Me.TxtBusqueda)
        Me.PanelBuscar.Controls.Add(Me.CmbFiltro)
        Me.PanelBuscar.Controls.Add(Me.LabelFiltro)
        Me.PanelBuscar.Controls.Add(Me.DgridCargos)
        Me.PanelBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBuscar.Location = New System.Drawing.Point(0, -250)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(501, 244)
        Me.PanelBuscar.TabIndex = 20
        '
        'BtnCancelarPanel
        '
        Me.BtnCancelarPanel.Image = CType(resources.GetObject("BtnCancelarPanel.Image"), System.Drawing.Image)
        Me.BtnCancelarPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarPanel.Location = New System.Drawing.Point(260, 204)
        Me.BtnCancelarPanel.Name = "BtnCancelarPanel"
        Me.BtnCancelarPanel.Size = New System.Drawing.Size(96, 35)
        Me.BtnCancelarPanel.TabIndex = 7
        Me.BtnCancelarPanel.Text = "Cancelar"
        Me.BtnCancelarPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelarPanel.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Image = CType(resources.GetObject("BtnSeleccionar.Image"), System.Drawing.Image)
        Me.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionar.Location = New System.Drawing.Point(139, 204)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(115, 35)
        Me.BtnSeleccionar.TabIndex = 6
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscarPanel
        '
        Me.BtnBuscarPanel.Image = CType(resources.GetObject("BtnBuscarPanel.Image"), System.Drawing.Image)
        Me.BtnBuscarPanel.Location = New System.Drawing.Point(444, 11)
        Me.BtnBuscarPanel.Name = "BtnBuscarPanel"
        Me.BtnBuscarPanel.Size = New System.Drawing.Size(45, 23)
        Me.BtnBuscarPanel.TabIndex = 5
        Me.BtnBuscarPanel.UseVisualStyleBackColor = True
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(216, 12)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(222, 22)
        Me.TxtBusqueda.TabIndex = 4
        '
        'CmbFiltro
        '
        Me.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFiltro.FormattingEnabled = True
        Me.CmbFiltro.Items.AddRange(New Object() {"Nombre", "Descripcion", "Departamento"})
        Me.CmbFiltro.Location = New System.Drawing.Point(89, 12)
        Me.CmbFiltro.Name = "CmbFiltro"
        Me.CmbFiltro.Size = New System.Drawing.Size(121, 24)
        Me.CmbFiltro.TabIndex = 3
        '
        'LabelFiltro
        '
        Me.LabelFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro.Location = New System.Drawing.Point(12, 15)
        Me.LabelFiltro.Name = "LabelFiltro"
        Me.LabelFiltro.Size = New System.Drawing.Size(71, 16)
        Me.LabelFiltro.TabIndex = 2
        Me.LabelFiltro.Text = "Criterio:"
        Me.LabelFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgridCargos
        '
        Me.DgridCargos.AllowUserToAddRows = False
        Me.DgridCargos.AllowUserToDeleteRows = False
        Me.DgridCargos.AllowUserToResizeColumns = False
        Me.DgridCargos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridCargos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgridCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridCargos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaNombre, Me.ColumnaDescripcion, Me.Departamento})
        Me.DgridCargos.Location = New System.Drawing.Point(3, 42)
        Me.DgridCargos.Name = "DgridCargos"
        Me.DgridCargos.ReadOnly = True
        Me.DgridCargos.RowHeadersVisible = False
        Me.DgridCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridCargos.Size = New System.Drawing.Size(486, 158)
        Me.DgridCargos.TabIndex = 0
        '
        'ColumnaNombre
        '
        Me.ColumnaNombre.HeaderText = "Nombre"
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
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.Width = 130
        '
        'TimerPanel
        '
        Me.TimerPanel.Interval = 1
        '
        'LabelEstado
        '
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(0, 17)
        '
        'BarraEstado
        '
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 238)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(499, 22)
        Me.BarraEstado.TabIndex = 12
        Me.BarraEstado.Text = "StatusStrip1"
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
        'BarraNavegacion
        '
        Me.BarraNavegacion.AddNewItem = Nothing
        Me.BarraNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BarraNavegacion.CountItem = Nothing
        Me.BarraNavegacion.DeleteItem = Nothing
        Me.BarraNavegacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarraNavegacion.Enabled = False
        Me.BarraNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonPrimero, Me.BotonAnterior, Me.BindingNavigatorSeparator, Me.TxtPosicion, Me.LabelElementos, Me.BindingNavigatorSeparator1, Me.BotonSiguiente, Me.BotonUltimo})
        Me.BarraNavegacion.Location = New System.Drawing.Point(0, 213)
        Me.BarraNavegacion.MoveFirstItem = Nothing
        Me.BarraNavegacion.MoveLastItem = Nothing
        Me.BarraNavegacion.MoveNextItem = Nothing
        Me.BarraNavegacion.MovePreviousItem = Nothing
        Me.BarraNavegacion.Name = "BarraNavegacion"
        Me.BarraNavegacion.PositionItem = Nothing
        Me.BarraNavegacion.Size = New System.Drawing.Size(499, 25)
        Me.BarraNavegacion.TabIndex = 17
        Me.BarraNavegacion.Text = "Navegación"
        '
        'IUGestionCargos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(499, 260)
        Me.Controls.Add(Me.PanelBuscar)
        Me.Controls.Add(Me.LblDepartamento)
        Me.Controls.Add(Me.CmbDepartamento)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.TxtDescripcionCargo)
        Me.Controls.Add(Me.TxtNombreCargo)
        Me.Controls.Add(Me.LblDescripcionCargo)
        Me.Controls.Add(Me.LblNombreCargo)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.BarraOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUGestionCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargos"
        Me.BarraOpciones.ResumeLayout(False)
        Me.BarraOpciones.PerformLayout()
        Me.PanelBuscar.ResumeLayout(False)
        Me.PanelBuscar.PerformLayout()
        CType(Me.DgridCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtDescripcionCargo As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtNombreCargo As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcionCargo As System.Windows.Forms.Label
    Friend WithEvents LblNombreCargo As System.Windows.Forms.Label
    Friend WithEvents CmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents LblDepartamento As System.Windows.Forms.Label
    Friend WithEvents PanelBuscar As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelarPanel As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarPanel As System.Windows.Forms.Button
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents CmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents LabelFiltro As System.Windows.Forms.Label
    Friend WithEvents DgridCargos As System.Windows.Forms.DataGridView
    Friend WithEvents TimerPanel As System.Windows.Forms.Timer
    Friend WithEvents ColumnaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents BotonPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents BotonAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtPosicion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LabelElementos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BotonSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents BotonUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarraNavegacion As System.Windows.Forms.BindingNavigator
End Class
