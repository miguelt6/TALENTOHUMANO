Friend Class IUCapturaCamara
    Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'Para el formulario de inicio, la primera instancia creada es la instancia predeterminada.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
    End Sub
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Public WithEvents cmdOpciones As System.Windows.Forms.Button
    Public WithEvents cmdCapturar As System.Windows.Forms.Button
    Public WithEvents PictureBox As System.Windows.Forms.PictureBox
    'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdOpciones = New System.Windows.Forms.Button
        Me.cmdCapturar = New System.Windows.Forms.Button
        Me.PictureBox = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOpciones
        '
        Me.cmdOpciones.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOpciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOpciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOpciones.Location = New System.Drawing.Point(406, 278)
        Me.cmdOpciones.Name = "cmdOpciones"
        Me.cmdOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOpciones.Size = New System.Drawing.Size(108, 23)
        Me.cmdOpciones.TabIndex = 3
        Me.cmdOpciones.Text = "Opciones"
        Me.cmdOpciones.UseVisualStyleBackColor = False
        '
        'cmdCapturar
        '
        Me.cmdCapturar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCapturar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCapturar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCapturar.Location = New System.Drawing.Point(292, 278)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCapturar.Size = New System.Drawing.Size(108, 23)
        Me.cmdCapturar.TabIndex = 1
        Me.cmdCapturar.Text = "Capturar"
        Me.cmdCapturar.UseVisualStyleBackColor = False
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox.Location = New System.Drawing.Point(346, 27)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(320, 245)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IUCapturaCamara
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(678, 309)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdOpciones)
        Me.Controls.Add(Me.cmdCapturar)
        Me.Controls.Add(Me.PictureBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(10, 30)
        Me.MaximizeBox = False
        Me.Name = "IUCapturaCamara"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capturar Foto"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Soporte para la actualización "
    Private Shared m_vb6FormDefInstance As IUCapturaCamara
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As IUCapturaCamara
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New IUCapturaCamara
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As IUCapturaCamara)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Dim Acerca_De As New Form

    Private Sub cmdCapturar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCapturar.Click

        Dim data As IDataObject
        Dim bmap As Bitmap

        capEditCopy(lwndC)                  ' Llama a copiar la imagen al portapapeles
        data = Clipboard.GetDataObject()    ' Obtiene la imagen del portapapeles
        bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap) ' Lo comvierte a bmp
        PictureBox.Image = bmap             ' La copia
        IUGestionPersonas.PbxFoto.Image = bmap
    End Sub

    Private Sub cmdOpciones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOpciones.Click
        capDlgVideoSource(lwndC)
    End Sub

    Private Sub frmCamara_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim lpszName As New VB6.FixedLengthString(100)
        Dim lpszVer As New VB6.FixedLengthString(100)

        capGetDriverDescriptionA(0, lpszName.Value, 100, lpszVer.Value, 100)
        lwndC = capCreateCaptureWindowA(lpszName.Value, WS_VISIBLE Or WS_CHILD, 15, 28, 320, 242, Me.Handle.ToInt32, 0)

        If capDriverConnect(lwndC, 0) Then
            capPreviewScale(lwndC, True)
            capPreviewRate(lwndC, 50)
            capPreview(lwndC, True)
        End If

    End Sub

    Private Sub frmCamara_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed

        capSetCallbackOnError(lwndC, VariantType.Null)
        capSetCallbackOnStatus(lwndC, VariantType.Null)
        capSetCallbackOnYield(lwndC, VariantType.Null)
        capSetCallbackOnFrame(lwndC, VariantType.Null)
        capSetCallbackOnVideoStream(lwndC, VariantType.Null)
        capSetCallbackOnWaveStream(lwndC, VariantType.Null)
        capSetCallbackOnCapControl(lwndC, VariantType.Null)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox.Image.Save(My.Application.Info.DirectoryPath & "\Temporal.bmp")
    End Sub
End Class