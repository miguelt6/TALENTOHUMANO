<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUGruposNomina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUGruposNomina))
        Me.GbxNomina = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.CmbFrecuencia = New System.Windows.Forms.ComboBox()
        Me.LblFormaPago = New System.Windows.Forms.Label()
        Me.LblFrecuencia = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.BarraOpciones = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separador = New System.Windows.Forms.ToolStripSeparator()
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
        Me.LabelEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerPanel = New System.Windows.Forms.Timer(Me.components)
        Me.GbxNomina.SuspendLayout()
        Me.BarraOpciones.SuspendLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraNavegacion.SuspendLayout()
        Me.BarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbxNomina
        '
        Me.GbxNomina.Controls.Add(Me.TxtDescripcion)
        Me.GbxNomina.Controls.Add(Me.CmbFormaPago)
        Me.GbxNomina.Controls.Add(Me.CmbFrecuencia)
        Me.GbxNomina.Controls.Add(Me.LblFormaPago)
        Me.GbxNomina.Controls.Add(Me.LblFrecuencia)
        Me.GbxNomina.Controls.Add(Me.LblDescripcion)
        Me.GbxNomina.Enabled = False
        Me.GbxNomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxNomina.ForeColor = System.Drawing.Color.Green
        Me.GbxNomina.Location = New System.Drawing.Point(12, 59)
        Me.GbxNomina.Name = "GbxNomina"
        Me.GbxNomina.Size = New System.Drawing.Size(367, 140)
        Me.GbxNomina.TabIndex = 0
        Me.GbxNomina.TabStop = False
        Me.GbxNomina.Text = "Nómina"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(143, 32)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(206, 22)
        Me.TxtDescripcion.TabIndex = 5
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Items.AddRange(New Object() {"Por Día", "Por Semana", "Por Mes"})
        Me.CmbFormaPago.Location = New System.Drawing.Point(143, 91)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(206, 24)
        Me.CmbFormaPago.TabIndex = 4
        '
        'CmbFrecuencia
        '
        Me.CmbFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFrecuencia.FormattingEnabled = True
        Me.CmbFrecuencia.Items.AddRange(New Object() {"Quincenal", "Mensual", "Trimestral", "Semestral"})
        Me.CmbFrecuencia.Location = New System.Drawing.Point(143, 61)
        Me.CmbFrecuencia.Name = "CmbFrecuencia"
        Me.CmbFrecuencia.Size = New System.Drawing.Size(206, 24)
        Me.CmbFrecuencia.TabIndex = 3
        '
        'LblFormaPago
        '
        Me.LblFormaPago.ForeColor = System.Drawing.Color.Black
        Me.LblFormaPago.Location = New System.Drawing.Point(33, 94)
        Me.LblFormaPago.Name = "LblFormaPago"
        Me.LblFormaPago.Size = New System.Drawing.Size(113, 16)
        Me.LblFormaPago.TabIndex = 2
        Me.LblFormaPago.Text = "Forma de Pago:"
        '
        'LblFrecuencia
        '
        Me.LblFrecuencia.ForeColor = System.Drawing.Color.Black
        Me.LblFrecuencia.Location = New System.Drawing.Point(6, 64)
        Me.LblFrecuencia.Name = "LblFrecuencia"
        Me.LblFrecuencia.Size = New System.Drawing.Size(141, 16)
        Me.LblFrecuencia.TabIndex = 1
        Me.LblFrecuencia.Text = "Frecuencia de Pago:"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.LblDescripcion.Location = New System.Drawing.Point(54, 35)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(83, 18)
        Me.LblDescripcion.TabIndex = 0
        Me.LblDescripcion.Text = "Descripción:"
        '
        'BarraOpciones
        '
        Me.BarraOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BarraOpciones.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BarraOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.BtnModificar, Me.BtnGuardar, Me.BtnCancelar, Me.Separador})
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 0)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Size = New System.Drawing.Size(391, 47)
        Me.BarraOpciones.TabIndex = 2
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
        Me.BarraNavegacion.Size = New System.Drawing.Size(391, 25)
        Me.BarraNavegacion.TabIndex = 19
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
        Me.BarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelEstado})
        Me.BarraEstado.Location = New System.Drawing.Point(0, 238)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(391, 22)
        Me.BarraEstado.TabIndex = 18
        Me.BarraEstado.Text = "StatusStrip1"
        '
        'LabelEstado
        '
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(0, 17)
        '
        'TimerPanel
        '
        Me.TimerPanel.Interval = 1
        '
        'IUGruposNomina
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(391, 260)
        Me.Controls.Add(Me.BarraNavegacion)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.GbxNomina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUGruposNomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos De Nomina"
        Me.GbxNomina.ResumeLayout(False)
        Me.GbxNomina.PerformLayout()
        Me.BarraOpciones.ResumeLayout(False)
        Me.BarraOpciones.PerformLayout()
        CType(Me.BarraNavegacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraNavegacion.ResumeLayout(False)
        Me.BarraNavegacion.PerformLayout()
        Me.BarraEstado.ResumeLayout(False)
        Me.BarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbxNomina As System.Windows.Forms.GroupBox
    Friend WithEvents LblFormaPago As System.Windows.Forms.Label
    Friend WithEvents LblFrecuencia As System.Windows.Forms.Label
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents CmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents CmbFrecuencia As System.Windows.Forms.ComboBox
    Friend WithEvents BarraOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents LabelEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimerPanel As System.Windows.Forms.Timer
End Class
