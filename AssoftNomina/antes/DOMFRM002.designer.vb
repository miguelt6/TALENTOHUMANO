<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOMFRM002
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DOMFRM002))
        Me.CmbSucursal = New System.Windows.Forms.ComboBox
        Me.LblSucursal = New System.Windows.Forms.Label
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.v = New System.Windows.Forms.Button
        Me.CmbDependencia = New System.Windows.Forms.ComboBox
        Me.LblDependencia = New System.Windows.Forms.Label
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.LblDescripcion = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.LblNombre = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CmbSucursal
        '
        Me.CmbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(104, 33)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(301, 24)
        Me.CmbSucursal.TabIndex = 24
        '
        'LblSucursal
        '
        Me.LblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSucursal.Location = New System.Drawing.Point(2, 34)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(96, 21)
        Me.LblSucursal.TabIndex = 23
        Me.LblSucursal.Text = "Sucursal"
        Me.LblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 170)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(103, 43)
        Me.BtnAgregar.TabIndex = 22
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(121, 170)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(103, 43)
        Me.BtnModificar.TabIndex = 21
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(335, 170)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(81, 43)
        Me.BtnSalir.TabIndex = 20
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'v
        '
        Me.v.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v.Image = CType(resources.GetObject("v.Image"), System.Drawing.Image)
        Me.v.Location = New System.Drawing.Point(230, 170)
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(99, 43)
        Me.v.TabIndex = 19
        Me.v.Text = "Guardar"
        Me.v.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.v.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.v.UseVisualStyleBackColor = True
        '
        'CmbDependencia
        '
        Me.CmbDependencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDependencia.FormattingEnabled = True
        Me.CmbDependencia.Location = New System.Drawing.Point(104, 65)
        Me.CmbDependencia.Name = "CmbDependencia"
        Me.CmbDependencia.Size = New System.Drawing.Size(301, 24)
        Me.CmbDependencia.TabIndex = 18
        '
        'LblDependencia
        '
        Me.LblDependencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDependencia.Location = New System.Drawing.Point(2, 66)
        Me.LblDependencia.Name = "LblDependencia"
        Me.LblDependencia.Size = New System.Drawing.Size(96, 21)
        Me.LblDependencia.TabIndex = 17
        Me.LblDependencia.Text = "Departamento"
        Me.LblDependencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(104, 125)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(301, 22)
        Me.TxtDescripcion.TabIndex = 15
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(11, 126)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(87, 21)
        Me.LblDescripcion.TabIndex = 16
        Me.LblDescripcion.Text = "Descripción"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(104, 97)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(301, 22)
        Me.TxtNombre.TabIndex = 13
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(11, 98)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(87, 21)
        Me.LblNombre.TabIndex = 14
        Me.LblNombre.Text = "Nombre"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DOMFRM002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 225)
        Me.Controls.Add(Me.CmbSucursal)
        Me.Controls.Add(Me.LblSucursal)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.CmbDependencia)
        Me.Controls.Add(Me.LblDependencia)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "DOMFRM002"
        Me.Text = "Cargos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents LblSucursal As System.Windows.Forms.Label
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents v As System.Windows.Forms.Button
    Friend WithEvents CmbDependencia As System.Windows.Forms.ComboBox
    Friend WithEvents LblDependencia As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
End Class
