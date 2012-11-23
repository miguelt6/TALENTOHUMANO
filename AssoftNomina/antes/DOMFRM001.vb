Public Class DOMFRM001

    Dim PanelMostrado As Boolean = False
    Dim PosicionActual As Integer = 0
    Dim EstadoFormulario As String = "Leyendo"
    Dim EstadoModificado As Boolean = False

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        TimerPanel.Start()
        Buscar(2)
    End Sub

    Private Sub Buscar(ByVal Tipo As Integer)
        DgridDepartamentos.Rows.Clear()
        Dim i As Integer = 0
        If Tipo = 2 Then
            While i < PRIFRM001.Departamentos.Count
                DgridDepartamentos.Rows.Add()
                DgridDepartamentos.Item(0, DgridDepartamentos.RowCount - 1).Value = PRIFRM001.Departamentos.Item(i + 1).ProNombre
                DgridDepartamentos.Item(1, DgridDepartamentos.RowCount - 1).Value = PRIFRM001.Departamentos.Item(i + 1).ProDescripcion
                i = i + 1
            End While
        ElseIf Tipo = 0 Then
            i = 0
            While i < PRIFRM001.Departamentos.Count
                If PRIFRM001.Departamentos.Item(i + 1).ProNombre Like TxtBusqueda.Text + "*" Then
                    DgridDepartamentos.Rows.Add()
                    DgridDepartamentos.Item(0, DgridDepartamentos.RowCount - 1).Value = PRIFRM001.Departamentos.Item(i + 1).ProNombre
                    DgridDepartamentos.Item(1, DgridDepartamentos.RowCount - 1).Value = PRIFRM001.Departamentos.Item(i + 1).ProDescripcion
                End If
                i = i + 1
            End While
        ElseIf Tipo = 1 Then
            i = 0
            While i < PRIFRM001.Departamentos.Count
                If PRIFRM001.Departamentos.Item(i + 1).ProDescripcion Like TxtBusqueda.Text + "*" Then
                    DgridDepartamentos.Rows.Add()
                    DgridDepartamentos.Item(0, DgridDepartamentos.RowCount - 1).Value = PRIFRM001.Departamentos.Item(i + 1).ProNombre
                    DgridDepartamentos.Item(1, DgridDepartamentos.RowCount - 1).Value = PRIFRM001.Departamentos.Item(i + 1).ProDescripcion
                End If
                i = i + 1
            End While
        End If
    End Sub
    Private Sub TimerPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanel.Tick
        If PanelMostrado Then
            PanelBuscar.Top = PanelBuscar.Top - 28
        Else
            PanelBuscar.Top = PanelBuscar.Top + 28
        End If
        If PanelBuscar.Top >= 0 Then
            TimerPanel.Stop()
            PanelMostrado = True
        End If
        If PanelBuscar.Top <= -308 Then
            TimerPanel.Stop()
            PanelMostrado = False
        End If
    End Sub

    Private Sub BtnCancelarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarPanel.Click
        TimerPanel.Start()
    End Sub

    Private Sub DOMFRM001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PRIFRM001.Departamentos.Count > 0 Then
            MostrarDepartamento(1)
            BtnBuscar.Enabled = True
            BarraNavegacion.Enabled = True
            BtnModificar.Enabled = True
        End If
        CmbFiltro.SelectedIndex = 0
    End Sub

    Private Sub MostrarDepartamento(ByVal Posicion As Integer)
        TxtNombreDpto.Text = PRIFRM001.Departamentos.Item(Posicion).Pronombre
        TxtDescripcionDpto.Text = PRIFRM001.Departamentos.Item(Posicion).ProDescripcion
        PosicionActual = Posicion
        TxtPosicion.Text = Posicion
        LabelElementos.Text = "de {" & PRIFRM001.Departamentos.Count & "}"
        LabelEstado.Text = "Leyendo..."
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim Resultado As Integer
        Resultado = RevisarEstado()
        If Resultado = MsgBoxResult.Yes Then
            LabelEstado.Text = "Guardando..."
            Guardar()
            EstadoLeyendo()
            Exit Sub
        End If
        If Resultado = MsgBoxResult.No Or Resultado = 0 Then
            LabelEstado.Text = "Cancelando..."
            EstadoLeyendo()
            If PRIFRM001.Departamentos.Count > 0 Then
                MostrarDepartamento(1)
            End If
        End If
    End Sub

    Private Sub BotonModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnBuscar.Enabled = False
        BarraNavegacion.Enabled = False
        TxtNombreDpto.Enabled = True
        TxtNombreDpto.BackColor = Color.White
        TxtDescripcionDpto.Enabled = True
        TxtDescripcionDpto.BackColor = Color.White
        EstadoFormulario = "Modificando"
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnBuscar.Enabled = False
        BarraNavegacion.Enabled = False
        TxtNombreDpto.Text = ""
        TxtNombreDpto.Enabled = True
        TxtNombreDpto.BackColor = Color.White
        TxtDescripcionDpto.Text = ""
        TxtDescripcionDpto.Enabled = True
        TxtDescripcionDpto.BackColor = Color.White
        EstadoFormulario = "Agregando"
    End Sub

    Private Sub CambiarEstado()
        If EstadoFormulario = "Modificando" Or EstadoFormulario = "Agregando" Then
            EstadoModificado = True
        End If
    End Sub

    Private Sub Nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombreDpto.TextChanged
        CambiarEstado()
    End Sub

    Private Sub Descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescripcionDpto.TextChanged
        CambiarEstado()
    End Sub

    Private Sub Departamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CambiarEstado()
    End Sub

    Private Function RevisarEstado() As Integer
        Dim Resultado As Integer = 0
        If EstadoModificado Then
            Resultado = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.ApplicationModal, "Departamentos")
        End If
        Return Resultado
    End Function

    Private Sub EstadoLeyendo()
        BtnNuevo.Enabled = True
        If PRIFRM001.Departamentos.Count > 0 Then
            BtnModificar.Enabled = True
            BtnBuscar.Enabled = True
            BarraNavegacion.Enabled = True
        End If
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        TxtNombreDpto.Enabled = False
        TxtNombreDpto.BackColor = SystemColors.Control
        TxtDescripcionDpto.Enabled = False
        TxtDescripcionDpto.BackColor = SystemColors.Control
        EstadoFormulario = "Leyendo"
        EstadoModificado = False
    End Sub

    Private Sub Guardar()
        If EstadoFormulario = "Agregando" Then
            PRIFRM001.Departamento = New ClaseDepartamento
            PRIFRM001.Departamento.ProNombre = TxtNombreDpto.Text
            PRIFRM001.Departamento.ProDescripcion = TxtDescripcionDpto.Text
            PRIFRM001.Departamentos.Add(PRIFRM001.Departamento)
            PosicionActual = PRIFRM001.Departamentos.Count
            TxtPosicion.Text = PRIFRM001.Departamentos.Count
            LabelElementos.Text = "de {" & PRIFRM001.Departamentos.Count & "}"
        ElseIf EstadoFormulario = "Modificando" Then
            PRIFRM001.Departamentos.Item(PosicionActual).ProNombre = TxtNombreDpto.Text
            PRIFRM001.Departamentos.Item(PosicionActual).ProDescripcion = TxtDescripcionDpto.Text
        End If
    End Sub

    Private Sub BotonPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPrimero.Click
        MostrarDepartamento(1)
    End Sub

    Private Sub BotonAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnterior.Click
        If PosicionActual = 1 Then
            MostrarDepartamento(1)
        Else
            MostrarDepartamento(PosicionActual - 1)
        End If
    End Sub

    Private Sub BotonSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSiguiente.Click
        If PosicionActual = PRIFRM001.Departamentos.Count Then
            MostrarDepartamento(PosicionActual)
        Else
            MostrarDepartamento(PosicionActual + 1)
        End If
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        MostrarDepartamento(PRIFRM001.Departamentos.Count)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Guardar()
        EstadoLeyendo()
    End Sub

    Private Sub BtnBuscarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarPanel.Click
        Buscar(CmbFiltro.SelectedIndex)
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        If DgridDepartamentos.Rows.Count > 0 Then
            MostrarDepartamento(DgridDepartamentos.CurrentRow.Index + 1)
            TimerPanel.Start()
        End If
    End Sub

    Private Sub LabelNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelNombre.Click

    End Sub
End Class
