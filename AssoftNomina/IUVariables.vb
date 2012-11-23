Public Class IUVariables
    Dim EstadoFormulario = "Leyendo"
    Dim PosicionActual As Integer = 0
    Dim EstadoModificado As Boolean = False
    Dim PanelMostrado As Boolean = False
    Private Sub TlsBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnNuevo.Click
        TxtDescripcion.Enabled = True
        TxtDescripcion.Text = ""
        TxtNombreCorto.Enabled = True
        TxtNombreCorto.Text = ""
        TxtValor.Enabled = True
        TxtValor.Text = ""        
        TlsBtnModificar.Enabled = False
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
        TlsBtnNuevo.Enabled = False
        BarraNavegacion.Enabled = False
        TlsBtnBuscar.Enabled = False
        EstadoFormulario = "Agregando"
    End Sub
    Private Sub Validar()
        If Me.TxtDescripcion.Text = Nothing Then
            MsgBox("Falta Ingresar la Descripcion")
            Exit Sub
        End If
        If Me.TxtNombreCorto.Text = Nothing Then
            MsgBox("Falta Ingresar el Nombre Corto")
            Exit Sub
        ElseIf TxtNombreCorto.Text Like "* *" Then
            MsgBox("El Nombre Corto No debe Tener Espacios en Blanco")
            Exit Sub
        End If
        Guardar()
        Estado_Leyendo()
    End Sub
    Private Sub Estado_Leyendo()
        TlsBtnNuevo.Enabled = True
        If IUPrincipal.Variables.Count > 0 Then
            TlsBtnModificar.Enabled = True
            TlsBtnBuscar.Enabled = True
            BarraNavegacion.Enabled = True
        End If
        TxtDescripcion.Enabled = False
        TxtNombreCorto.Enabled = False
        TxtValor.Enabled = False
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False
    End Sub
    Private Sub Guardar()
        If EstadoFormulario = "Agregando" Then
            IUPrincipal.Variable = New ClaseVariable
            IUPrincipal.Variable.ProNombreCorto = TxtNombreCorto.Text
            IUPrincipal.Variable.ProDescripcion = TxtDescripcion.Text
            IUPrincipal.Variable.ProValor = TxtValor.Text          
            IUPrincipal.Variables.Add(IUPrincipal.Variable)
            PosicionActual = IUPrincipal.Variables.Count
            TxtPosicion.Text = IUPrincipal.Variables.Count
            LabelElementos.Text = "de {" & IUPrincipal.Variables.Count & "}"
        ElseIf EstadoFormulario = "Modificando" Then
            IUPrincipal.Variables.Item(PosicionActual).ProNombreCorto = TxtNombreCorto.Text
            IUPrincipal.Variables.Item(PosicionActual).ProDescripcion = TxtDescripcion.Text
            IUPrincipal.Variables.Item(PosicionActual).ProValor = TxtValor.Text
            ''''REALIZAR UPDATE EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("UPDATE `VARIABLES` set `Txt_Descripcion` = '" + IUPrincipal.Variables.Item(PosicionActual).ProDescripcion + "',`Int_Tipo` = '" & IUPrincipal.Variables.Item(PosicionActual).ProTipo & "',`Txt_Valor` = '" + IUPrincipal.Variables.Item(PosicionActual).ProValor + "',`Int_Tipo` = '" & IUPrincipal.Variables.Item(PosicionActual).ProTipo & "' where `Txt_Nombre_Corto` = '" & IUPrincipal.Variables.Item(PosicionActual).ProNombreCorto & "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        End If                
    End Sub
    Private Sub TlsBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnGuardar.Click
        Validar()        
    End Sub

    Private Sub IUVariables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load       
        If IUPrincipal.Variables.Count > 0 Then
            TlsBtnBuscar.Enabled = True
            TlsBtnModificar.Enabled = True
            BarraNavegacion.Enabled = True
            MostrarVariable(1)
        End If
        CmbFiltro.SelectedIndex = 0
    End Sub

    Private Sub TlsBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnModificar.Click        
        If IUPrincipal.Variables.Item(PosicionActual).ProTipo = 1 Then
            TlsBtnBuscar.Enabled = False
            TlsBtnModificar.Enabled = False
            TlsBtnNuevo.Enabled = False
            TlsBtnGuardar.Enabled = True
            TlsBtnCancelar.Enabled = True
            BarraNavegacion.Enabled = False
            TxtValor.Enabled = True
            EstadoFormulario = "Modificando"
        Else
            MsgBox("No se Puede Modificar es una Variable de BD")
        End If
    End Sub

    Private Sub TlsBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnCancelar.Click        
        Limpiar_Formulario()
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False
        If IUPrincipal.Variables.Count > 0 Then
            MostrarVariable(1)
            TlsBtnBuscar.Enabled = True
            TlsBtnModificar.Enabled = True
            BarraNavegacion.Enabled = True
        End If
        TlsBtnNuevo.Enabled = True
    End Sub
    Private Sub Limpiar_Formulario()
        TxtDescripcion.Text = ""
        TxtNombreCorto.Text = ""
        TxtValor.Text = ""
        TxtDescripcion.Enabled = False
        TxtNombreCorto.Enabled = False
        TxtValor.Enabled = False
    End Sub
    Private Sub MostrarVariable(ByVal Posicion As Integer)
        TxtNombreCorto.Text = IUPrincipal.Variables.Item(Posicion).ProNombreCorto
        TxtDescripcion.Text = IUPrincipal.Variables.Item(Posicion).ProDescripcion
        TxtValor.Text = IUPrincipal.Variables.Item(Posicion).ProValor       
        PosicionActual = Posicion
        TxtPosicion.Text = Posicion
        LabelElementos.Text = "de {" & IUPrincipal.Variables.Count & "}"        
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        MostrarVariable(IUPrincipal.Variables.Count)
    End Sub

    Private Sub BotonSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSiguiente.Click
        If PosicionActual = IUPrincipal.Variables.Count Then
            MostrarVariable(PosicionActual)
        Else
            MostrarVariable(PosicionActual + 1)
        End If
    End Sub

    Private Sub BotonAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnterior.Click
        If PosicionActual = 1 Then
            MostrarVariable(1)
        Else
            MostrarVariable(PosicionActual - 1)
        End If
    End Sub

    Private Sub BotonPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPrimero.Click
        MostrarVariable(1)
    End Sub

    Private Sub TlsBtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnBuscar.Click
        TimerPanel.Start()        
    End Sub

    Private Sub TimerPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanel.Tick
        If PanelMostrado Then
            PanelBuscar.Top = PanelBuscar.Top - 22
        Else
            PanelBuscar.Top = PanelBuscar.Top + 22
        End If
        If PanelBuscar.Top >= 0 Then
            TimerPanel.Stop()
            PanelMostrado = True
        End If
        If PanelBuscar.Top <= -220 Then
            TimerPanel.Stop()
            PanelMostrado = False
        End If
    End Sub

    Private Sub BtnBuscarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarPanel.Click
        Buscar(CmbFiltro.SelectedIndex)
    End Sub

    Private Sub Buscar(ByVal Tipo As Integer)
        DgridVariables.Rows.Clear()
        Dim i As Integer = 0
        If Tipo = 0 Then
            i = 0
            While i < IUPrincipal.Variables.Count
                If IUPrincipal.Variables.Item(i + 1).ProNombreCorto Like TxtBusqueda.Text + "*" Then
                    DgridVariables.Rows.Add()
                    DgridVariables.Item(0, DgridVariables.RowCount - 1).Value = IUPrincipal.Variables.Item(i + 1).ProNombreCorto
                    DgridVariables.Item(1, DgridVariables.RowCount - 1).Value = IUPrincipal.Variables.Item(i + 1).ProDescripcion
                    DgridVariables.Item(2, DgridVariables.RowCount - 1).Value = i + 1
                End If
                i = i + 1
            End While
        ElseIf Tipo = 1 Then
            i = 0
            While i < IUPrincipal.Variables.Count
                If IUPrincipal.Variables.Item(i + 1).ProDescripcion Like TxtBusqueda.Text + "*" Then
                    DgridVariables.Rows.Add()
                    DgridVariables.Item(0, DgridVariables.RowCount - 1).Value = IUPrincipal.Variables.Item(i + 1).ProNombreCorto
                    DgridVariables.Item(1, DgridVariables.RowCount - 1).Value = IUPrincipal.Variables.Item(i + 1).ProDescripcion
                    DgridVariables.Item(2, DgridVariables.RowCount - 1).Value = i + 1
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        If DgridVariables.RowCount > 0 Then
            MostrarVariable(CInt(DgridVariables.Item(2, DgridVariables.CurrentRow.Index).Value))
            TimerPanel.Start()
        End If
    End Sub

    Private Sub BtnCancelarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarPanel.Click
        TimerPanel.Start()
    End Sub
End Class