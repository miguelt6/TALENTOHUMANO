Imports System.String

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
            While i < IUPrincipal.Departamentos.Count
                DgridDepartamentos.Rows.Add()
                DgridDepartamentos.Item(0, DgridDepartamentos.RowCount - 1).Value = IUPrincipal.Departamentos.Item(i + 1).ProNombre
                DgridDepartamentos.Item(1, DgridDepartamentos.RowCount - 1).Value = IUPrincipal.Departamentos.Item(i + 1).ProDescripcion
                i = i + 1
            End While
        ElseIf Tipo = 0 Then
            i = 0
            While i < IUPrincipal.Departamentos.Count
                If IUPrincipal.Departamentos.Item(i + 1).ProNombre Like TxtBusqueda.Text.ToUpper + "*" Then
                    DgridDepartamentos.Rows.Add()
                    DgridDepartamentos.Item(0, DgridDepartamentos.RowCount - 1).Value = IUPrincipal.Departamentos.Item(i + 1).ProNombre
                    DgridDepartamentos.Item(1, DgridDepartamentos.RowCount - 1).Value = IUPrincipal.Departamentos.Item(i + 1).ProDescripcion
                End If
                i = i + 1
            End While
        ElseIf Tipo = 1 Then
            i = 0
            While i < IUPrincipal.Departamentos.Count
                If IUPrincipal.Departamentos.Item(i + 1).ProDescripcion Like TxtBusqueda.Text + "*" Then
                    DgridDepartamentos.Rows.Add()
                    DgridDepartamentos.Item(0, DgridDepartamentos.RowCount - 1).Value = IUPrincipal.Departamentos.Item(i + 1).ProNombre
                    DgridDepartamentos.Item(1, DgridDepartamentos.RowCount - 1).Value = IUPrincipal.Departamentos.Item(i + 1).ProDescripcion
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
        If IUPrincipal.Departamentos.Count > 0 Then
            MostrarDepartamento(1)
            BtnBuscar.Enabled = True
            BarraNavegacion.Enabled = True
            BtnModificar.Enabled = True
        End If
        CmbFiltro.SelectedIndex = 0
    End Sub

    Private Sub MostrarDepartamento(ByVal Posicion As Integer)
        TxtNombreDpto.Text = IUPrincipal.Departamentos.Item(Posicion).Pronombre
        TxtDescripcionDpto.Text = IUPrincipal.Departamentos.Item(Posicion).ProDescripcion
        PosicionActual = Posicion
        TxtPosicion.Text = Posicion
        LabelElementos.Text = "de {" & IUPrincipal.Departamentos.Count & "}"        
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim Resultado As Integer
        Resultado = RevisarEstado()
        If Resultado = MsgBoxResult.Yes Then            
            Guardar()
            EstadoLeyendo()
            Exit Sub
        End If
        If Resultado = MsgBoxResult.No Or Resultado = 0 Then            
            EstadoLeyendo()
            If IUPrincipal.Departamentos.Count > 0 Then
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
        If IUPrincipal.Departamentos.Count > 0 Then
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
        If Me.TxtNombreDpto.Text <> Nothing Then
            If EstadoFormulario = "Agregando" Then
                IUPrincipal.Departamento = New ClaseDepartamento
                IUPrincipal.Departamento.ProNombre = TxtNombreDpto.Text
                IUPrincipal.Departamento.ProDescripcion = TxtDescripcionDpto.Text
                IUPrincipal.Departamentos.Add(IUPrincipal.Departamento)
                PosicionActual = IUPrincipal.Departamentos.Count
                TxtPosicion.Text = IUPrincipal.Departamentos.Count
                LabelElementos.Text = "de {" & IUPrincipal.Departamentos.Count & "}"
                ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
                Dim bConexionExitosa As Boolean
                IUPrincipal.Conexion = New ClaseBaseDatos
                bConexionExitosa = IUPrincipal.Conexion.Conectar
                If bConexionExitosa Then
                    IUPrincipal.Conexion.Insertar("INSERT INTO `DEPARTAMENTOS` set `Txt_Nombre` = '" + IUPrincipal.Departamentos.Item(PosicionActual).ProNombre + "',`Txt_Descripcion` = '" + IUPrincipal.Departamentos.Item(PosicionActual).ProDescripcion + "';")
                End If
                '////////////////////////////////////////////////////////
                '////////////////////////////////////////////////////////
            ElseIf EstadoFormulario = "Modificando" Then
                IUPrincipal.Departamentos.Item(PosicionActual).ProNombre = TxtNombreDpto.Text
                IUPrincipal.Departamentos.Item(PosicionActual).ProDescripcion = TxtDescripcionDpto.Text

                ''''REALIZAR MODIFICACION EN LA BASE DE DATOS''''''''''''''
                Dim bConexionExitosa As Boolean
                IUPrincipal.Conexion = New ClaseBaseDatos
                bConexionExitosa = IUPrincipal.Conexion.Conectar
                If bConexionExitosa Then
                    IUPrincipal.Conexion.Insertar("UPDATE `DEPARTAMENTOS` set `Txt_Nombre` = '" + IUPrincipal.Departamentos.Item(PosicionActual).ProNombre + "',`Txt_Descripcion` = '" + IUPrincipal.Departamentos.Item(PosicionActual).ProDescripcion + "' where `Num_Codigo`= '" + IUPrincipal.Departamentos.Item(PosicionActual).ProCodigo + "';")
                End If
                '////////////////////////////////////////////////////////
                '////////////////////////////////////////////////////////
            End If
        Else
            If EstadoFormulario = "Agregando" Then
                Me.TxtNombreDpto.Clear()
                Me.TxtDescripcionDpto.Clear()
            Else
                Me.TxtNombreDpto.Text = IUPrincipal.Departamentos.Item(PosicionActual).ProNombre
                Me.TxtDescripcionDpto.Text = IUPrincipal.Departamentos.Item(PosicionActual).ProDescripcion
            End If
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
        If PosicionActual = IUPrincipal.Departamentos.Count Then
            MostrarDepartamento(PosicionActual)
        Else
            MostrarDepartamento(PosicionActual + 1)
        End If
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        MostrarDepartamento(IUPrincipal.Departamentos.Count)
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
