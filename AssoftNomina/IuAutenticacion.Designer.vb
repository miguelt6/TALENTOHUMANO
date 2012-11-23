<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IuAutenticacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IuAutenticacion))
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPassword
        '
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.Green
        Me.LblPassword.Location = New System.Drawing.Point(20, 78)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(90, 23)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "Password"
        '
        'LblLogin
        '
        Me.LblLogin.BackColor = System.Drawing.Color.Transparent
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.ForeColor = System.Drawing.Color.Green
        Me.LblLogin.Location = New System.Drawing.Point(20, 44)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(68, 23)
        Me.LblLogin.TabIndex = 2
        Me.LblLogin.Text = "Usuario"
        '
        'TxtLogin
        '
        Me.TxtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLogin.Location = New System.Drawing.Point(116, 41)
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(140, 22)
        Me.TxtLogin.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(116, 75)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(140, 22)
        Me.TxtPassword.TabIndex = 4
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'BtnIniciar
        '
        Me.BtnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.Image = Global.WindowsApplication1.My.Resources.Resources.verificar161
        Me.BtnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIniciar.Location = New System.Drawing.Point(95, 112)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(75, 28)
        Me.BtnIniciar.TabIndex = 5
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'IuAutenticacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(270, 180)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.LblPassword)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IuAutenticacion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblLogin As System.Windows.Forms.Label
    Friend WithEvents TxtLogin As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnIniciar As System.Windows.Forms.Button
End Class
