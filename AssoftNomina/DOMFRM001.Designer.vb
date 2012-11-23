<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOMFRM001
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DOMFRM001))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PanelBuscar = New System.Windows.Forms.Panel
        Me.BtnCancelarPanel = New System.Windows.Forms.Button
        Me.BtnSeleccionar = New System.Windows.Forms.Button
        Me.BtnBuscarPanel = New System.Windows.Forms.Button
        Me.TxtBusqueda = New System.Windows.Forms.TextBox
        Me.CmbFiltro = New System.Windows.Forms.ComboBox
        Me.LabelFiltro = New System.Windows.Forms.Label
        Me.DgridDepartamentos = New System.Windows.Forms.DataGridView
        Me.TimerPanel = New System.Windows.Forms.Timer(Me.components)
        Me.BarraEstado = New System.Windows.Forms.StatusStrip
        Me.LabelEstado = New System.Windows.Forms.ToolStripStatusLabel
        Me.LabelNombre = New System.Windows.Forms.Label
        Me.LabelDescripcion = New System.Windows.Forms.Label
        Me.TxtNombreDpto = New System.Windows.Forms.TextBox
        Me.TxtDescripcionDpto = New System.Windows.Forms.RichTextBox
        Me.BarraNavegacion = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BotonPrimero = New System.Windows.Forms.ToolStripButton
        Me.BotonAnterior = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.TxtPosicion = New System.Windows.Forms.ToolStripTextBox
        Me.LabelElementos = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BotonSiguiente = New System.Windows.Forms.ToolStripButton
        Me.BotonUltimo = New System.Windows.Forms.ToolStripButton
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton
        Me.BtnModificar = New System.Windows.Forms.ToolStripButton
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton
        Me.Separador = New System.Windows.Forms.ToolStripSeparator
        Me.BtnBuscar = New System.Windows.Forms.ToolStripButton
        Me.BarraOpciones = New System.Windows.Forms.ToolStrip
        Me.ColumnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelBuscar.SuspendLayout()
        CType(Me.DgridDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraEstado.SuspendLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.BarraOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBuscar
        '
        Me.PanelBuscar.Controls.Add(Me.BtnCancelarPanel)
        Me.PanelBuscar.Controls.Add(Me.BtnSeleccionar)
        Me.PanelBuscar.Controls.Add(Me.BtnBuscarPanel)
        Me.PanelBuscar.Controls.Add(Me.TxtBusqueda)
        Me.PanelBuscar.Controls.Add(Me.CmbFiltro)
        Me.PanelBuscar.Controls.Add(Me.LabelFiltro)
        Me.PanelBuscar.Controls.Add(Me.DgridDepartamentos)
        Me.PanelBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBuscar.Location = New System.Drawing.Point(0, -250)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(501, 244)
        Me.PanelBuscar.TabIndex = 1
        '
        'BtnCancelarPanel
        '
        Me.BtnCancelarPanel.Image = CType(resources.GetObject("BtnCancelarPanel.Image"), System.Drawing.Image)
        Me.BtnCancelarPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarPanel.Location = New System.Drawing.Point(255, 203)
        Me.BtnCancelarPanel.Name = "BtnCancelarPanel"
        Me.BtnCancelarPanel.Size = New System.Drawing.Size(95, 35)
        Me.BtnCancelarPanel.TabIndex = 7
        Me.BtnCancelarPanel.Text = "Cancelar"
        Me.BtnCancelarPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelarPanel.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Image = CType(resources.GetObject("BtnSeleccionar.Image"), System.Drawing.Image)
        Me.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeleccionar.Location = New System.Drawing.Point(135, 203)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(113, 35)
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
        Me.CmbFiltro.Items.AddRange(New Object() {"Nombre", "Descripcion"})
        Me.CmbFiltro.Location = New System.Drawing.Point(89, 12)
        Me.CmbFiltro.Name = "CmbFiltro"
        Me.CmbFiltro.Size = New System.Drawing.Size(121, 24)
        Me.CmbFiltro.TabIndex = 3
        '
        'LabelFiltro
        '
        Me.LabelFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro.Location = New System.Drawing.Point(12, 12)
        Me.LabelFiltro.Name = "LabelFiltro"
        Me.LabelFiltro.Size = New System.Drawing.Size(71, 24)
        Me.LabelFiltro.TabIndex = 2
        Me.LabelFiltro.Text = "Criterio:"
        Me.LabelFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgridDepartamentos
        '
        Me.DgridDepartamentos.AllowUserToAddRows = False
        Me.DgridDepartamentos.AllowUserToDeleteRows = False
        Me.DgridDepartamentos.AllowUserToResizeColumns = False
        Me.DgridDepartamentos.AllowUserToResizeRows = False
        Me.DgridDepartamentos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridDepartamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaNombre, Me.ColumnaDescripcion})
        Me.DgridDepartamentos.Location = New System.Drawing.Point(3, 42)
        Me.DgridDepartamentos.MultiSelect = False
        Me.DgridDepartamentos.Name = "DgridDepartamentos"
        Me.DgridDepartamentos.ReadOnly = True
        Me.DgridDepartamentos.RowHeadersVisible = False
        Me.DgridDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridDepartamentos.Size = New System.Drawing.Size(495, 158)
        Me.DgridDepartamentos.TabIndex = 0
        '
        'TimerPanel
        '
        Me.TimerPanel.Interval = 1
        '
        'BarraEstado
        '
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 219)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(501, 22)
        Me.BarraEstado.TabIndex = 2
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'LabelEstado
        '
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(0, 17)
        '
        'LabelNombre
        '
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(12, 60)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(97, 16)
        Me.LabelNombre.TabIndex = 3
        Me.LabelNombre.Text = "Nombre:"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.Location = New System.Drawing.Point(12, 125)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(97, 16)
        Me.LabelDescripcion.TabIndex = 4
        Me.LabelDescripcion.Text = "Descripción:"
        Me.LabelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNombreDpto
        '
        Me.TxtNombreDpto.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNombreDpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreDpto.Enabled = False
        Me.TxtNombreDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreDpto.Location = New System.Drawing.Point(115, 59)
        Me.TxtNombreDpto.MaxLength = 40
        Me.TxtNombreDpto.Name = "TxtNombreDpto"
        Me.TxtNombreDpto.Size = New System.Drawing.Size(363, 22)
        Me.TxtNombreDpto.TabIndex = 5
        '
        'TxtDescripcionDpto
        '
        Me.TxtDescripcionDpto.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDescripcionDpto.Enabled = False
        Me.TxtDescripcionDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionDpto.Location = New System.Drawing.Point(115, 85)
        Me.TxtDescripcionDpto.MaxLength = 250
        Me.TxtDescripcionDpto.Name = "TxtDescripcionDpto"
        Me.TxtDescripcionDpto.Size = New System.Drawing.Size(363, 96)
        Me.TxtDescripcionDpto.TabIndex = 7
        Me.TxtDescripcionDpto.Text = ""
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
        Me.BarraNavegacion.Location = New System.Drawing.Point(0, 194)
        Me.BarraNavegacion.MoveFirstItem = Nothing
        Me.BarraNavegacion.MoveLastItem = Nothing
        Me.BarraNavegacion.MoveNextItem = Nothing
        Me.BarraNavegacion.MovePreviousItem = Nothing
        Me.BarraNavegacion.Name = "BarraNavegacion"
        Me.BarraNavegacion.PositionItem = Nothing
        Me.BarraNavegacion.Size = New System.Drawing.Size(501, 25)
        Me.BarraNavegacion.TabIndex = 11
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
        'BarraOpciones
        '
        Me.BarraOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BarraOpciones.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BarraOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnModificar, Me.BtnGuardar, Me.BtnCancelar, Me.Separador, Me.BtnBuscar})
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 0)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Size = New System.Drawing.Size(501, 47)
        Me.BarraOpciones.TabIndex = 0
        Me.BarraOpciones.Text = "Opciones"
        '
        'ColumnaNombre
        '
        Me.ColumnaNombre.HeaderText = "Nombre"
        Me.ColumnaNombre.Name = "ColumnaNombre"
        Me.ColumnaNombre.ReadOnly = True
        Me.ColumnaNombre.Width = 175
        '
        'ColumnaDescripcion
        '
        Me.ColumnaDescripcion.HeaderText = "Descripción"
        Me.ColumnaDescripcion.Name = "ColumnaDescripcion"
        Me.ColumnaDescripcion.ReadOnly = True
        Me.ColumnaDescripcion.Width = 300
        '
        'DOMFRM001
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(501, 241)
        Me.Controls.Add(Me.PanelBuscar)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.TxtDescripcionDpto)
        Me.Controls.Add(Me.TxtNombreDpto)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.BarraOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DOMFRM001"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamentos"
        Me.PanelBuscar.ResumeLayout(False)
        Me.PanelBuscar.PerformLayout()
        CType(Me.DgridDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.BarraOpciones.ResumeLayout(False)
        Me.BarraOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelBuscar As System.Windows.Forms.Panel
    Friend WithEvents TimerPanel As System.Windows.Forms.Timer
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelDescripcion As System.Windows.Forms.Label
    Friend WithEvents TxtNombreDpto As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcionDpto As System.Windows.Forms.RichTextBox
    Friend WithEvents DgridDepartamentos As System.Windows.Forms.DataGridView
    Friend WithEvents CmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents LabelFiltro As System.Windows.Forms.Label
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscarPanel As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents LabelEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BarraNavegacion As System.Windows.Forms.BindingNavigator
    Friend WithEvents LabelElementos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BotonPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents BotonAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtPosicion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BotonSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents BotonUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarraOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents ColumnaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents BtnCancelarPanel As System.Windows.Forms.Button

End Class
