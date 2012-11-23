Public Class IUGestionCargos
    Dim PanelMostrado As Boolean = False
    Dim PosicionActual As Integer = 0
    Dim EstadoFormulario As String = "Leyendo"
    Dim EstadoModificado As Boolean = False


    Private Sub MAEFRM001_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If IUPrincipal.Departamentos.Count > 0 Then
            Cargar_Departamentos()
        Else
            MsgBox("Debe crear al menos un departamento para poder gestionar cargos", MsgBoxStyle.Exclamation)
            Me.Close()
        End If
        CmbFiltro.SelectedIndex = 0
        If IUPrincipal.Cargos.Count > 0 Then
            MostrarCargo(1)
            BtnBuscar.Enabled = True
            BarraNavegacion.Enabled = True
            BtnModificar.Enabled = True
        End If
    End Sub

    Private Sub Cargar_Departamentos()
        Dim i As Integer = 0
        While i < IUPrincipal.Departamentos.Count
            CmbDepartamento.Items.Add(IUPrincipal.Departamentos(i + 1).ProNombre)
            i = i + 1
        End While
        CmbDepartamento.SelectedIndex = 0
    End Sub
    Private Sub MostrarCargo(ByVal Posicion As Integer)
        TxtNombreCargo.Text = IUPrincipal.Cargos.Item(Posicion).Pronombre
        TxtDescripcionCargo.Text = IUPrincipal.Cargos.Item(Posicion).ProDescripcion
        CmbDepartamento.SelectedIndex = IUPrincipal.Cargos.Item(Posicion).ProDepartamento
        PosicionActual = Posicion
        TxtPosicion.Text = Posicion
        LabelElementos.Text = "de {" & IUPrincipal.Cargos.Count & "}"
        LabelEstado.Text = "Leyendo..."
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        TimerPanel.Start()
        Buscar(3)
    End Sub
    Private Sub Buscar(ByVal Tipo As Integer)
        DgridCargos.Rows.Clear()
        Dim i As Integer = 0
        If Tipo = 3 Then
            While i < IUPrincipal.Cargos.Count
                DgridCargos.Rows.Add()
                DgridCargos.Item(0, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProNombre
                DgridCargos.Item(1, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProDescripcion
                DgridCargos.Item(2, DgridCargos.RowCount - 1).Value = CmbDepartamento.Items.Item(IUPrincipal.Cargos.Item(i + 1).ProDepartamento)
                i = i + 1
            End While
        ElseIf Tipo = 0 Then
            i = 0
            While i < IUPrincipal.Departamentos.Count
                If IUPrincipal.Cargos.Item(i + 1).ProNombre Like TxtBusqueda.Text.ToUpper + "*" Then
                    DgridCargos.Rows.Add()
                    DgridCargos.Item(0, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProNombre
                    DgridCargos.Item(1, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProDescripcion
                    DgridCargos.Item(2, DgridCargos.RowCount - 1).Value = CmbDepartamento.Items.Item(IUPrincipal.Cargos.Item(i + 1).ProDepartamento)
                End If
                i = i + 1
            End While
        ElseIf Tipo = 1 Then
            i = 0
            While i < IUPrincipal.Cargos.Count
                If IUPrincipal.Cargos.Item(i + 1).ProDescripcion Like TxtBusqueda.Text + "*" Then
                    DgridCargos.Rows.Add()
                    DgridCargos.Item(0, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProNombre
                    DgridCargos.Item(1, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProDescripcion
                    DgridCargos.Item(2, DgridCargos.RowCount - 1).Value = CmbDepartamento.Items.Item(IUPrincipal.Cargos.Item(i + 1).ProDepartamento)
                End If
                i = i + 1
            End While
        ElseIf Tipo = 2 Then
            i = 0
            While i < IUPrincipal.Cargos.Count
                If CmbDepartamento.Items.Item(IUPrincipal.Cargos.Item(i + 1).ProDepartamento) Like TxtBusqueda.Text.ToUpper + "*" Then
                    DgridCargos.Rows.Add()
                    DgridCargos.Item(0, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProNombre
                    DgridCargos.Item(1, DgridCargos.RowCount - 1).Value = IUPrincipal.Cargos.Item(i + 1).ProDescripcion
                    DgridCargos.Item(2, DgridCargos.RowCount - 1).Value = CmbDepartamento.Items.Item(IUPrincipal.Cargos.Item(i + 1).ProDepartamento)
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub BtnCancelarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarPanel.Click
        TimerPanel.Start()
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
            If IUPrincipal.Cargos.Count > 0 Then
                MostrarCargo(1)
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnBuscar.Enabled = False
        BarraNavegacion.Enabled = False
        TxtNombreCargo.Enabled = True
        TxtNombreCargo.BackColor = Color.White
        TxtDescripcionCargo.Enabled = True
        TxtDescripcionCargo.BackColor = Color.White
        CmbDepartamento.Enabled = True
        CmbDepartamento.BackColor = Color.White
        EstadoFormulario = "Modificando"
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
        If IUPrincipal.Cargos.Count > 0 Then
            BtnModificar.Enabled = True
            BtnBuscar.Enabled = True
            BarraNavegacion.Enabled = True
        End If
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        TxtNombreCargo.Enabled = False
        TxtNombreCargo.BackColor = SystemColors.Control
        TxtDescripcionCargo.Enabled = False
        TxtDescripcionCargo.BackColor = SystemColors.Control
        CmbDepartamento.Enabled = False
        CmbDepartamento.BackColor = SystemColors.Control
        EstadoFormulario = "Leyendo"
        EstadoModificado = False
    End Sub

    Private Sub Guardar()
        If Me.TxtNombreCargo.Text <> Nothing Then
            If EstadoFormulario = "Agregando" Then
                IUPrincipal.Cargo = New ClaseCargo
                IUPrincipal.Cargo.ProNombre = TxtNombreCargo.Text
                IUPrincipal.Cargo.ProDescripcion = TxtDescripcionCargo.Text
                IUPrincipal.Cargo.ProDepartamento = CmbDepartamento.SelectedIndex
                IUPrincipal.Cargos.Add(IUPrincipal.Cargo)
                PosicionActual = IUPrincipal.Cargos.Count
                TxtPosicion.Text = IUPrincipal.Cargos.Count
                LabelElementos.Text = "de {" & IUPrincipal.Cargos.Count & "}"
                ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
                Dim bConexionExitosa As Boolean
                IUPrincipal.Conexion = New ClaseBaseDatos
                bConexionExitosa = IUPrincipal.Conexion.Conectar
                If bConexionExitosa Then
                    IUPrincipal.Conexion.Insertar("INSERT INTO `CARGOS` set `Txt_Nombre` = '" + IUPrincipal.Cargos.Item(PosicionActual).ProNombre + "',`Txt_Descripcion` = '" + IUPrincipal.Cargos.Item(PosicionActual).ProDescripcion + "',`Num_Codigo_Departamento` = '" & IUPrincipal.Cargos.Item(PosicionActual).ProDepartamento + 1 & "';")
                End If
                '////////////////////////////////////////////////////////
                '////////////////////////////////////////////////////////
            ElseIf EstadoFormulario = "Modificando" Then
                IUPrincipal.Cargos.Item(PosicionActual).ProNombre = TxtNombreCargo.Text
                IUPrincipal.Cargos.Item(PosicionActual).ProDescripcion = TxtDescripcionCargo.Text
                IUPrincipal.Cargos.Item(PosicionActual).ProDepartamento = CmbDepartamento.SelectedIndex
                ''''REALIZAR MODIFICACION EN LA BASE DE DATOS''''''''''''''
                Dim bConexionExitosa As Boolean
                IUPrincipal.Conexion = New ClaseBaseDatos
                bConexionExitosa = IUPrincipal.Conexion.Conectar
                If bConexionExitosa Then
                    IUPrincipal.Conexion.Insertar("UPDATE `CARGOS` set `Txt_Nombre` = '" + IUPrincipal.Cargos.Item(PosicionActual).ProNombre + "',`Txt_Descripcion` = '" + IUPrincipal.Cargos.Item(PosicionActual).ProDescripcion + "',`Num_Codigo_Departamento` = '" & IUPrincipal.Cargos.Item(PosicionActual).ProDepartamento + 1 & "' where `Num_Codigo`= '" + IUPrincipal.Cargos.Item(PosicionActual).ProCodigo + "';")
                End If
                '////////////////////////////////////////////////////////
                '////////////////////////////////////////////////////////
            End If
        Else
            If EstadoFormulario = "Agregando" Then
                Me.TxtNombreCargo.Clear()
                Me.TxtDescripcionCargo.Clear()
            Else
                Me.TxtNombreCargo.Text = IUPrincipal.Cargos.Item(PosicionActual).ProNombre
                Me.TxtDescripcionCargo.Text = IUPrincipal.Cargos.Item(PosicionActual).ProDescripcion
            End If
        End If

    End Sub

    Private Sub BotonPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPrimero.Click
        MostrarCargo(1)
    End Sub

    Private Sub BotonAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnterior.Click
        If PosicionActual = 1 Then
            MostrarCargo(1)
        Else
            MostrarCargo(PosicionActual - 1)
        End If
    End Sub

    Private Sub BotonSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSiguiente.Click
        If PosicionActual = IUPrincipal.Cargos.Count Then
            MostrarCargo(PosicionActual)
        Else
            MostrarCargo(PosicionActual + 1)
        End If
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        MostrarCargo(IUPrincipal.Cargos.Count)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Guardar()
        EstadoLeyendo()
    End Sub

    Private Sub BtnBuscarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarPanel.Click
        Buscar(CmbFiltro.SelectedIndex)
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        If DgridCargos.Rows.Count > 0 Then
            MostrarCargo(DgridCargos.CurrentRow.Index + 1)
            TimerPanel.Start()
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnBuscar.Enabled = False
        BarraNavegacion.Enabled = False
        TxtNombreCargo.Text = ""
        TxtNombreCargo.Enabled = True
        TxtNombreCargo.BackColor = Color.White
        TxtDescripcionCargo.Text = ""
        TxtDescripcionCargo.Enabled = True
        TxtDescripcionCargo.BackColor = Color.White
        CmbDepartamento.Enabled = True
        CmbDepartamento.BackColor = Color.White
        EstadoFormulario = "Agregando"
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

    Private Sub IUGestionCargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class