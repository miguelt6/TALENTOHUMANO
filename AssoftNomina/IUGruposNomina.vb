Public Class IUGruposNomina
    Dim PanelMostrado As Boolean = False
    Dim PosicionActual As Integer = 0
    Dim EstadoFormulario As String = "Agregando"
    Dim EstadoModificado As Boolean = False
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        TxtDescripcion.Text = ""
        CmbFrecuencia.SelectedIndex = 0
        CmbFormaPago.SelectedIndex = 0
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True        
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        GbxNomina.Enabled = True
        EstadoFormulario = "Agregando"
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Guardar()
        EstadoLeyendo()
    End Sub

    Private Sub Guardar()
        If TxtDescripcion.Text <> Nothing Then
            If EstadoFormulario = "Agregando" Then
                IUPrincipal.GrupoNomina = New ClaseGrupoNomina
                IUPrincipal.GrupoNomina.ProDescripcion = TxtDescripcion.Text
                IUPrincipal.GrupoNomina.ProFormaPago = CmbFormaPago.SelectedIndex
                IUPrincipal.GrupoNomina.ProFrecuencia = CmbFrecuencia.SelectedIndex
                IUPrincipal.GruposNomina.Add(IUPrincipal.GrupoNomina)
                PosicionActual = IUPrincipal.GruposNomina.Count
                TxtPosicion.Text = IUPrincipal.GruposNomina.Count
                LabelElementos.Text = "de {" & IUPrincipal.GruposNomina.Count & "}"
            ElseIf EstadoFormulario = "Modificando" Then
                IUPrincipal.GruposNomina.Item(PosicionActual).ProDescripcion = TxtDescripcion.Text
                IUPrincipal.GruposNomina.Item(PosicionActual).ProFormaPago = CmbFormaPago.SelectedIndex
                IUPrincipal.GruposNomina.Item(PosicionActual).ProFrecuencia = CmbFrecuencia.SelectedIndex
            End If
        Else
            If EstadoFormulario = "Agregando" Then
                TxtDescripcion.Clear()                
            Else
                TxtDescripcion.Text = IUPrincipal.GruposNomina.Item(PosicionActual).ProDescripcion
                CmbFormaPago.SelectedIndex = IUPrincipal.GruposNomina.Item(PosicionActual).ProFormaPago
                CmbFrecuencia.SelectedIndex = IUPrincipal.GruposNomina.Item(PosicionActual).ProFrecuencia
            End If
        End If
    End Sub
    Private Sub EstadoLeyendo()
        BtnNuevo.Enabled = True
        If IUPrincipal.GruposNomina.Count > 0 Then
            BtnModificar.Enabled = True           
            BarraNavegacion.Enabled = True
        End If
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        GbxNomina.Enabled = False
        EstadoFormulario = "Leyendo"
        EstadoModificado = False
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
            If IUPrincipal.GruposNomina.Count > 0 Then
                MostrarGrupoNomina(1)
            End If
        End If
    End Sub
    Private Sub MostrarGrupoNomina(ByVal Posicion As Integer)
        TxtDescripcion.Text = IUPrincipal.GruposNomina.Item(Posicion).ProDescripcion
        CmbFormaPago.SelectedIndex = IUPrincipal.GruposNomina.Item(Posicion).ProFormaPago
        CmbFrecuencia.SelectedIndex = IUPrincipal.GruposNomina.Item(Posicion).ProFrecuencia
        PosicionActual = Posicion
        TxtPosicion.Text = Posicion
        LabelElementos.Text = "de {" & IUPrincipal.GruposNomina.Count & "}"
        LabelEstado.Text = "Leyendo..."
    End Sub
    Private Function RevisarEstado() As Integer
        Dim Resultado As Integer = 0
        If EstadoModificado Then
            Resultado = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.ApplicationModal, "Departamentos")
        End If
        Return Resultado
    End Function

    Private Sub BotonSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSiguiente.Click
        If PosicionActual = IUPrincipal.GruposNomina.Count Then
            MostrarGrupoNomina(PosicionActual)
        Else
            MostrarGrupoNomina(PosicionActual + 1)
        End If
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        MostrarGrupoNomina(IUPrincipal.GruposNomina.Count)
    End Sub

    Private Sub BotonAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnterior.Click
        If PosicionActual = 1 Then
            MostrarGrupoNomina(1)
        Else
            MostrarGrupoNomina(PosicionActual - 1)
        End If
    End Sub

    Private Sub BotonPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPrimero.Click
        MostrarGrupoNomina(1)
    End Sub

    Private Sub IUGruposNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        If IUPrincipal.GruposNomina.Count > 0 Then
            MostrarGrupoNomina(1)
            BarraNavegacion.Enabled = True
            BtnModificar.Enabled = True
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True       
        BarraNavegacion.Enabled = False
        GbxNomina.Enabled = True
        EstadoFormulario = "Modificando"
    End Sub
End Class