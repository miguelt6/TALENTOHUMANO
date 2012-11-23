<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUFeriados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUFeriados))
        Me.CalFeriados = New System.Windows.Forms.MonthCalendar()
        Me.LblDiasFeriados = New System.Windows.Forms.Label()
        Me.DgridFeriados = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarraOpciones = New System.Windows.Forms.ToolStrip()
        Me.BtnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.BtnQuitar = New System.Windows.Forms.ToolStripButton()
        Me.Separador = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.DgridFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalFeriados
        '
        Me.CalFeriados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalFeriados.Location = New System.Drawing.Point(18, 94)
        Me.CalFeriados.MaxSelectionCount = 1
        Me.CalFeriados.Name = "CalFeriados"
        Me.CalFeriados.TabIndex = 1
        Me.CalFeriados.TitleBackColor = System.Drawing.Color.Green
        '
        'LblDiasFeriados
        '
        Me.LblDiasFeriados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasFeriados.ForeColor = System.Drawing.Color.Black
        Me.LblDiasFeriados.Location = New System.Drawing.Point(12, 62)
        Me.LblDiasFeriados.Name = "LblDiasFeriados"
        Me.LblDiasFeriados.Size = New System.Drawing.Size(200, 23)
        Me.LblDiasFeriados.TabIndex = 2
        Me.LblDiasFeriados.Text = "Seleccione Los Días Feriados"
        '
        'DgridFeriados
        '
        Me.DgridFeriados.AllowUserToAddRows = False
        Me.DgridFeriados.AllowUserToDeleteRows = False
        Me.DgridFeriados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgridFeriados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgridFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridFeriados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha})
        Me.DgridFeriados.Location = New System.Drawing.Point(250, 94)
        Me.DgridFeriados.Name = "DgridFeriados"
        Me.DgridFeriados.ReadOnly = True
        Me.DgridFeriados.RowHeadersVisible = False
        Me.DgridFeriados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridFeriados.Size = New System.Drawing.Size(79, 185)
        Me.DgridFeriados.TabIndex = 20
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 71
        '
        'BarraOpciones
        '
        Me.BarraOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BarraOpciones.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BarraOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAgregar, Me.BtnQuitar, Me.Separador})
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 0)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.Size = New System.Drawing.Size(338, 47)
        Me.BarraOpciones.TabIndex = 21
        Me.BarraOpciones.Text = "Opciones"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(61, 44)
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Enabled = False
        Me.BtnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitar.Image = CType(resources.GetObject("BtnQuitar.Image"), System.Drawing.Image)
        Me.BtnQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(47, 44)
        Me.BtnQuitar.Text = "Quitar"
        Me.BtnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Separador
        '
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 47)
        '
        'IUFeriados
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(338, 305)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.DgridFeriados)
        Me.Controls.Add(Me.LblDiasFeriados)
        Me.Controls.Add(Me.CalFeriados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IUFeriados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dias Feriados"
        CType(Me.DgridFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraOpciones.ResumeLayout(False)
        Me.BarraOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalFeriados As System.Windows.Forms.MonthCalendar
    Friend WithEvents LblDiasFeriados As System.Windows.Forms.Label
    Friend WithEvents DgridFeriados As System.Windows.Forms.DataGridView
    Friend WithEvents BarraOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnQuitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
