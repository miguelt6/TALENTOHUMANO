<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUConceptos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUConceptos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblProceso = New System.Windows.Forms.Label()
        Me.LblFormula = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.GbxEstado = New System.Windows.Forms.GroupBox()
        Me.RbtnNoActivo = New System.Windows.Forms.RadioButton()
        Me.RbtnActivo = New System.Windows.Forms.RadioButton()
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
        Me.GbxCalculadora = New System.Windows.Forms.GroupBox()
        Me.BtnSuprimir = New System.Windows.Forms.Button()
        Me.BtnParentesisCerrado = New System.Windows.Forms.Button()
        Me.BtnParentesisAbierto = New System.Windows.Forms.Button()
        Me.BtnPunto = New System.Windows.Forms.Button()
        Me.BtnDivision = New System.Windows.Forms.Button()
        Me.BtnMultiplicacion = New System.Windows.Forms.Button()
        Me.BtnCero = New System.Windows.Forms.Button()
        Me.BtnResta = New System.Windows.Forms.Button()
        Me.BtnSuma = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.BtnVariable = New System.Windows.Forms.Button()
        Me.BtnVerificar = New System.Windows.Forms.Button()
        Me.LblTipoConcepto = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtFormula = New System.Windows.Forms.TextBox()
        Me.TimerPanel = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBuscar = New System.Windows.Forms.Panel()
        Me.LblVariable = New System.Windows.Forms.Label()
        Me.BtnCancelarPanel = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.DgridVariables = New System.Windows.Forms.DataGridView()
        Me.ColumnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbProceso = New System.Windows.Forms.ComboBox()
        Me.CmbTipoConcepto = New System.Windows.Forms.ComboBox()
        Me.GbxEstado.SuspendLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GbxCalculadora.SuspendLayout()
        Me.PanelBuscar.SuspendLayout()
        CType(Me.DgridVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(46, 67)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(97, 16)
        Me.LblDescripcion.TabIndex = 21
        Me.LblDescripcion.Text = "Descripción"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblProceso
        '
        Me.LblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProceso.Location = New System.Drawing.Point(4, 93)
        Me.LblProceso.Name = "LblProceso"
        Me.LblProceso.Size = New System.Drawing.Size(139, 16)
        Me.LblProceso.TabIndex = 27
        Me.LblProceso.Text = "Para Qué Proceso Es"
        Me.LblProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFormula
        '
        Me.LblFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormula.Location = New System.Drawing.Point(33, 122)
        Me.LblFormula.Name = "LblFormula"
        Me.LblFormula.Size = New System.Drawing.Size(110, 16)
        Me.LblFormula.TabIndex = 28
        Me.LblFormula.Text = "Fórmula"
        Me.LblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEstado
        '
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(33, 213)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(110, 16)
        Me.LblEstado.TabIndex = 30
        Me.LblEstado.Text = "Estado"
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GbxEstado
        '
        Me.GbxEstado.Controls.Add(Me.RbtnNoActivo)
        Me.GbxEstado.Controls.Add(Me.RbtnActivo)
        Me.GbxEstado.Enabled = False
        Me.GbxEstado.Location = New System.Drawing.Point(149, 203)
        Me.GbxEstado.Name = "GbxEstado"
        Me.GbxEstado.Size = New System.Drawing.Size(163, 35)
        Me.GbxEstado.TabIndex = 31
        Me.GbxEstado.TabStop = False
        '
        'RbtnNoActivo
        '
        Me.RbtnNoActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnNoActivo.Location = New System.Drawing.Point(71, 8)
        Me.RbtnNoActivo.Name = "RbtnNoActivo"
        Me.RbtnNoActivo.Size = New System.Drawing.Size(85, 21)
        Me.RbtnNoActivo.TabIndex = 1
        Me.RbtnNoActivo.TabStop = True
        Me.RbtnNoActivo.Text = "No Activo"
        Me.RbtnNoActivo.UseVisualStyleBackColor = True
        '
        'RbtnActivo
        '
        Me.RbtnActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnActivo.Location = New System.Drawing.Point(6, 8)
        Me.RbtnActivo.Name = "RbtnActivo"
        Me.RbtnActivo.Size = New System.Drawing.Size(68, 21)
        Me.RbtnActivo.TabIndex = 0
        Me.RbtnActivo.TabStop = True
        Me.RbtnActivo.Text = "Activo"
        Me.RbtnActivo.UseVisualStyleBackColor = True
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
        Me.BarraNavegacion.Location = New System.Drawing.Point(0, 280)
        Me.BarraNavegacion.MoveFirstItem = Nothing
        Me.BarraNavegacion.MoveLastItem = Nothing
        Me.BarraNavegacion.MoveNextItem = Nothing
        Me.BarraNavegacion.MovePreviousItem = Nothing
        Me.BarraNavegacion.Name = "BarraNavegacion"
        Me.BarraNavegacion.PositionItem = Nothing
        Me.BarraNavegacion.Size = New System.Drawing.Size(587, 25)
        Me.BarraNavegacion.TabIndex = 36
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
        Me.BarraEstado.Location = New System.Drawing.Point(0, 305)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(587, 22)
        Me.BarraEstado.TabIndex = 35
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsBtnNuevo, Me.TlsBtnModificar, Me.TlsBtnGuardar, Me.TlsBtnCancelar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(587, 48)
        Me.ToolStrip1.TabIndex = 34
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
        'GbxCalculadora
        '
        Me.GbxCalculadora.Controls.Add(Me.BtnSuprimir)
        Me.GbxCalculadora.Controls.Add(Me.BtnParentesisCerrado)
        Me.GbxCalculadora.Controls.Add(Me.BtnParentesisAbierto)
        Me.GbxCalculadora.Controls.Add(Me.BtnPunto)
        Me.GbxCalculadora.Controls.Add(Me.BtnDivision)
        Me.GbxCalculadora.Controls.Add(Me.BtnMultiplicacion)
        Me.GbxCalculadora.Controls.Add(Me.BtnCero)
        Me.GbxCalculadora.Controls.Add(Me.BtnResta)
        Me.GbxCalculadora.Controls.Add(Me.BtnSuma)
        Me.GbxCalculadora.Controls.Add(Me.Btn9)
        Me.GbxCalculadora.Controls.Add(Me.Btn8)
        Me.GbxCalculadora.Controls.Add(Me.Btn7)
        Me.GbxCalculadora.Controls.Add(Me.Btn6)
        Me.GbxCalculadora.Controls.Add(Me.Btn5)
        Me.GbxCalculadora.Controls.Add(Me.Btn4)
        Me.GbxCalculadora.Controls.Add(Me.Btn3)
        Me.GbxCalculadora.Controls.Add(Me.Btn2)
        Me.GbxCalculadora.Controls.Add(Me.Btn1)
        Me.GbxCalculadora.Enabled = False
        Me.GbxCalculadora.Location = New System.Drawing.Point(441, 56)
        Me.GbxCalculadora.Name = "GbxCalculadora"
        Me.GbxCalculadora.Size = New System.Drawing.Size(134, 182)
        Me.GbxCalculadora.TabIndex = 37
        Me.GbxCalculadora.TabStop = False
        '
        'BtnSuprimir
        '
        Me.BtnSuprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSuprimir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuprimir.Location = New System.Drawing.Point(38, 148)
        Me.BtnSuprimir.Name = "BtnSuprimir"
        Me.BtnSuprimir.Size = New System.Drawing.Size(90, 27)
        Me.BtnSuprimir.TabIndex = 19
        Me.BtnSuprimir.Text = "<- Supr"
        Me.BtnSuprimir.UseVisualStyleBackColor = True
        '
        'BtnParentesisCerrado
        '
        Me.BtnParentesisCerrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnParentesisCerrado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnParentesisCerrado.Location = New System.Drawing.Point(6, 148)
        Me.BtnParentesisCerrado.Name = "BtnParentesisCerrado"
        Me.BtnParentesisCerrado.Size = New System.Drawing.Size(26, 27)
        Me.BtnParentesisCerrado.TabIndex = 18
        Me.BtnParentesisCerrado.Text = ")"
        Me.BtnParentesisCerrado.UseVisualStyleBackColor = True
        '
        'BtnParentesisAbierto
        '
        Me.BtnParentesisAbierto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnParentesisAbierto.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnParentesisAbierto.Location = New System.Drawing.Point(6, 115)
        Me.BtnParentesisAbierto.Name = "BtnParentesisAbierto"
        Me.BtnParentesisAbierto.Size = New System.Drawing.Size(26, 27)
        Me.BtnParentesisAbierto.TabIndex = 17
        Me.BtnParentesisAbierto.Text = "("
        Me.BtnParentesisAbierto.UseVisualStyleBackColor = True
        '
        'BtnPunto
        '
        Me.BtnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPunto.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPunto.Location = New System.Drawing.Point(70, 115)
        Me.BtnPunto.Name = "BtnPunto"
        Me.BtnPunto.Size = New System.Drawing.Size(26, 27)
        Me.BtnPunto.TabIndex = 16
        Me.BtnPunto.Text = "."
        Me.BtnPunto.UseVisualStyleBackColor = True
        '
        'BtnDivision
        '
        Me.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDivision.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDivision.Location = New System.Drawing.Point(102, 115)
        Me.BtnDivision.Name = "BtnDivision"
        Me.BtnDivision.Size = New System.Drawing.Size(26, 27)
        Me.BtnDivision.TabIndex = 15
        Me.BtnDivision.Text = "/"
        Me.BtnDivision.UseVisualStyleBackColor = True
        '
        'BtnMultiplicacion
        '
        Me.BtnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMultiplicacion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiplicacion.Location = New System.Drawing.Point(102, 82)
        Me.BtnMultiplicacion.Name = "BtnMultiplicacion"
        Me.BtnMultiplicacion.Size = New System.Drawing.Size(26, 27)
        Me.BtnMultiplicacion.TabIndex = 14
        Me.BtnMultiplicacion.Text = "*"
        Me.BtnMultiplicacion.UseVisualStyleBackColor = True
        '
        'BtnCero
        '
        Me.BtnCero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCero.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCero.Location = New System.Drawing.Point(38, 115)
        Me.BtnCero.Name = "BtnCero"
        Me.BtnCero.Size = New System.Drawing.Size(26, 27)
        Me.BtnCero.TabIndex = 13
        Me.BtnCero.Text = "&0"
        Me.BtnCero.UseVisualStyleBackColor = True
        '
        'BtnResta
        '
        Me.BtnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnResta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResta.Location = New System.Drawing.Point(102, 49)
        Me.BtnResta.Name = "BtnResta"
        Me.BtnResta.Size = New System.Drawing.Size(26, 27)
        Me.BtnResta.TabIndex = 12
        Me.BtnResta.Text = "-"
        Me.BtnResta.UseVisualStyleBackColor = True
        '
        'BtnSuma
        '
        Me.BtnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSuma.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuma.Location = New System.Drawing.Point(102, 16)
        Me.BtnSuma.Name = "BtnSuma"
        Me.BtnSuma.Size = New System.Drawing.Size(26, 27)
        Me.BtnSuma.TabIndex = 11
        Me.BtnSuma.Text = "+"
        Me.BtnSuma.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(70, 82)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(26, 27)
        Me.Btn9.TabIndex = 8
        Me.Btn9.Text = "&9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(38, 82)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(26, 27)
        Me.Btn8.TabIndex = 7
        Me.Btn8.Text = "&8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(6, 82)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(26, 27)
        Me.Btn7.TabIndex = 6
        Me.Btn7.Text = "&7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(70, 49)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(26, 27)
        Me.Btn6.TabIndex = 5
        Me.Btn6.Text = "&6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(38, 49)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(26, 27)
        Me.Btn5.TabIndex = 4
        Me.Btn5.Text = "&5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(6, 49)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(26, 27)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "&4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(70, 16)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(26, 27)
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "&3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(38, 16)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(26, 27)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "&2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(6, 16)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(26, 27)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "&1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'BtnVariable
        '
        Me.BtnVariable.Enabled = False
        Me.BtnVariable.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVariable.Image = Global.WindowsApplication1.My.Resources.Resources.add16
        Me.BtnVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVariable.Location = New System.Drawing.Point(343, 148)
        Me.BtnVariable.Name = "BtnVariable"
        Me.BtnVariable.Size = New System.Drawing.Size(79, 25)
        Me.BtnVariable.TabIndex = 19
        Me.BtnVariable.Text = "Variable"
        Me.BtnVariable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVariable.UseVisualStyleBackColor = True
        '
        'BtnVerificar
        '
        Me.BtnVerificar.Enabled = False
        Me.BtnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificar.ForeColor = System.Drawing.Color.Black
        Me.BtnVerificar.Image = Global.WindowsApplication1.My.Resources.Resources.verificar16
        Me.BtnVerificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerificar.Location = New System.Drawing.Point(343, 119)
        Me.BtnVerificar.Name = "BtnVerificar"
        Me.BtnVerificar.Size = New System.Drawing.Size(79, 23)
        Me.BtnVerificar.TabIndex = 39
        Me.BtnVerificar.Text = "Verificar"
        Me.BtnVerificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVerificar.UseVisualStyleBackColor = True
        '
        'LblTipoConcepto
        '
        Me.LblTipoConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoConcepto.Location = New System.Drawing.Point(32, 247)
        Me.LblTipoConcepto.Name = "LblTipoConcepto"
        Me.LblTipoConcepto.Size = New System.Drawing.Size(111, 16)
        Me.LblTipoConcepto.TabIndex = 42
        Me.LblTipoConcepto.Text = "Tipo Concepto"
        Me.LblTipoConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(149, 66)
        Me.TxtDescripcion.MaxLength = 30
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(188, 20)
        Me.TxtDescripcion.TabIndex = 43
        '
        'TxtFormula
        '
        Me.TxtFormula.Enabled = False
        Me.TxtFormula.ForeColor = System.Drawing.Color.Black
        Me.TxtFormula.Location = New System.Drawing.Point(149, 121)
        Me.TxtFormula.Multiline = True
        Me.TxtFormula.Name = "TxtFormula"
        Me.TxtFormula.Size = New System.Drawing.Size(188, 84)
        Me.TxtFormula.TabIndex = 44
        '
        'TimerPanel
        '
        Me.TimerPanel.Interval = 1
        '
        'PanelBuscar
        '
        Me.PanelBuscar.Controls.Add(Me.LblVariable)
        Me.PanelBuscar.Controls.Add(Me.BtnCancelarPanel)
        Me.PanelBuscar.Controls.Add(Me.BtnSeleccionar)
        Me.PanelBuscar.Controls.Add(Me.DgridVariables)
        Me.PanelBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBuscar.Location = New System.Drawing.Point(0, -320)
        Me.PanelBuscar.Name = "PanelBuscar"
        Me.PanelBuscar.Size = New System.Drawing.Size(587, 302)
        Me.PanelBuscar.TabIndex = 51
        '
        'LblVariable
        '
        Me.LblVariable.Location = New System.Drawing.Point(218, 11)
        Me.LblVariable.Name = "LblVariable"
        Me.LblVariable.Size = New System.Drawing.Size(179, 14)
        Me.LblVariable.TabIndex = 8
        Me.LblVariable.Text = "Seleccione La Variable"
        '
        'BtnCancelarPanel
        '
        Me.BtnCancelarPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarPanel.Image = CType(resources.GetObject("BtnCancelarPanel.Image"), System.Drawing.Image)
        Me.BtnCancelarPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarPanel.Location = New System.Drawing.Point(319, 262)
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
        Me.BtnSeleccionar.Location = New System.Drawing.Point(202, 262)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(86, 25)
        Me.BtnSeleccionar.TabIndex = 6
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
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
        Me.DgridVariables.Location = New System.Drawing.Point(115, 35)
        Me.DgridVariables.Name = "DgridVariables"
        Me.DgridVariables.ReadOnly = True
        Me.DgridVariables.RowHeadersVisible = False
        Me.DgridVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridVariables.Size = New System.Drawing.Size(369, 221)
        Me.DgridVariables.TabIndex = 0
        '
        'ColumnaNombre
        '
        Me.ColumnaNombre.HeaderText = "Nombre Corto"
        Me.ColumnaNombre.Name = "ColumnaNombre"
        Me.ColumnaNombre.ReadOnly = True
        Me.ColumnaNombre.Width = 120
        '
        'ColumnaDescripcion
        '
        Me.ColumnaDescripcion.HeaderText = "Descripción"
        Me.ColumnaDescripcion.Name = "ColumnaDescripcion"
        Me.ColumnaDescripcion.ReadOnly = True
        Me.ColumnaDescripcion.Width = 245
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posicion"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.ReadOnly = True
        Me.Posicion.Visible = False
        '
        'CmbProceso
        '
        Me.CmbProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProceso.Enabled = False
        Me.CmbProceso.FormattingEnabled = True
        Me.CmbProceso.Items.AddRange(New Object() {"Calculo de Nomina", "Fideicomiso", "Utilidades", "Vacaciones"})
        Me.CmbProceso.Location = New System.Drawing.Point(149, 92)
        Me.CmbProceso.Name = "CmbProceso"
        Me.CmbProceso.Size = New System.Drawing.Size(188, 21)
        Me.CmbProceso.TabIndex = 52
        '
        'CmbTipoConcepto
        '
        Me.CmbTipoConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoConcepto.Enabled = False
        Me.CmbTipoConcepto.FormattingEnabled = True
        Me.CmbTipoConcepto.Items.AddRange(New Object() {"Asignacion", "Deduccion", "Retencion"})
        Me.CmbTipoConcepto.Location = New System.Drawing.Point(149, 246)
        Me.CmbTipoConcepto.Name = "CmbTipoConcepto"
        Me.CmbTipoConcepto.Size = New System.Drawing.Size(188, 21)
        Me.CmbTipoConcepto.TabIndex = 53
        '
        'IUConceptos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(587, 327)
        Me.Controls.Add(Me.PanelBuscar)
        Me.Controls.Add(Me.TxtFormula)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.BtnVariable)
        Me.Controls.Add(Me.LblTipoConcepto)
        Me.Controls.Add(Me.BtnVerificar)
        Me.Controls.Add(Me.GbxCalculadora)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GbxEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblFormula)
        Me.Controls.Add(Me.LblProceso)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.CmbProceso)
        Me.Controls.Add(Me.CmbTipoConcepto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUConceptos"
        Me.Text = "Conceptos"
        Me.GbxEstado.ResumeLayout(False)
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GbxCalculadora.ResumeLayout(False)
        Me.PanelBuscar.ResumeLayout(False)
        CType(Me.DgridVariables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents LblProceso As System.Windows.Forms.Label
    Friend WithEvents LblFormula As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents GbxEstado As System.Windows.Forms.GroupBox
    Friend WithEvents RbtnNoActivo As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnActivo As System.Windows.Forms.RadioButton
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
    Friend WithEvents GbxCalculadora As System.Windows.Forms.GroupBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn9 As System.Windows.Forms.Button
    Friend WithEvents Btn8 As System.Windows.Forms.Button
    Friend WithEvents Btn7 As System.Windows.Forms.Button
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents BtnVariable As System.Windows.Forms.Button
    Friend WithEvents BtnParentesisCerrado As System.Windows.Forms.Button
    Friend WithEvents BtnParentesisAbierto As System.Windows.Forms.Button
    Friend WithEvents BtnPunto As System.Windows.Forms.Button
    Friend WithEvents BtnDivision As System.Windows.Forms.Button
    Friend WithEvents BtnMultiplicacion As System.Windows.Forms.Button
    Friend WithEvents BtnCero As System.Windows.Forms.Button
    Friend WithEvents BtnResta As System.Windows.Forms.Button
    Friend WithEvents BtnSuma As System.Windows.Forms.Button
    Friend WithEvents BtnVerificar As System.Windows.Forms.Button
    Friend WithEvents LblTipoConcepto As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtFormula As System.Windows.Forms.TextBox
    Friend WithEvents TimerPanel As System.Windows.Forms.Timer
    Friend WithEvents PanelBuscar As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelarPanel As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents DgridVariables As System.Windows.Forms.DataGridView
    Friend WithEvents CmbProceso As System.Windows.Forms.ComboBox
    Friend WithEvents CmbTipoConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSuprimir As System.Windows.Forms.Button
    Friend WithEvents LblVariable As System.Windows.Forms.Label
    Friend WithEvents ColumnaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Posicion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
