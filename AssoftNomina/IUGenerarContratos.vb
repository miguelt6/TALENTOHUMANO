Imports Crystaldecisions.shared
Public Class IUGenerarContratos
    Dim PanelMostrado As Boolean = False
    Dim EstadoFormulario As String = "Leyendo"
    Dim PosicionActual As Integer = 0
    Dim EstadoModificado As Boolean = False
    Dim EstadoBusqueda As String = "Normal"
    Dim indicedpto As Integer = -1
    Public Conexion As ClaseBaseDatos
    Dim IndiceCargos As Integer() = {}
    Dim tienecontrato As Integer = -1
    Dim bConexionExitosa As Boolean
    Dim dr As System.Data.IDataReader
    Public dire As String
    Public fecnac As Date

    Private Sub TlsBtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnBuscar.Click
        EstadoBusqueda = "Normal"
        GbxContrato.Visible = True
        GbxPersona.Visible = True
        LblNoDisponible.Visible = False
        Me.Size = New System.Drawing.Size(521, 475)
        TimerPanel.Start()
    End Sub

    Private Sub TimerPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanel.Tick
        If PanelMostrado Then
            PanelBuscarPersonas.Top = PanelBuscarPersonas.Top - 20
        Else
            PanelBuscarPersonas.Top = PanelBuscarPersonas.Top + 20
        End If
        If PanelBuscarPersonas.Top >= 0 Then
            TimerPanel.Stop()
            PanelMostrado = True
        End If
        If PanelBuscarPersonas.Top <= -320 Then
            TimerPanel.Stop()
            PanelMostrado = False
        End If
    End Sub

    Public Sub Buscar_Contrato(ByVal Busqueda As String)
        Dim i As Integer = 0
        Dim status As String
        Dim dr As System.Data.IDataReader
        Dim con As String
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then


            'status = IUPrincipal.Personas(CInt(Me.LblPosicion.Text)).proestatus
            dr = Conexion.Seleccionar("SELECT * FROM `CONTRATOS` WHERE `Txt_Fk_Cedula` = '" + Busqueda + "' ; ")
            If (dr.Read()) Then
                MostrarContrato(Busqueda)
            Else
                GbxContrato.Visible = False
                LblNoDisponible.Text = "PERSONA SIN CONTRATO"
                tienecontrato = 0
                LblNoDisponible.Visible = True
                Me.Size = New System.Drawing.Size(521, 269)
                TlsBtnBuscar.Enabled = True
                TlsBtnNuevo.Enabled = True
                TlsbtnImprimir.Enabled = False
                TlsBtnModificar.Enabled = False
                TlsBtnCancelar.Enabled = False
                TlsBtnGuardar.Enabled = False
            End If
            dr.Dispose()
            dr.Close()

        End If
        Conexion.Cerrar_Conexion()
        'While i < IUPrincipal.Contratos.Count
        '    If IUPrincipal.Contratos.Item(i + 1).ProFk_Cedula Like Busqueda Then
        '        tienecontrato = 1
        '        MostrarContrato(i + 1)
        '        Exit Sub
        '    End If
        '    i = i + 1
        'End While


    End Sub

    Public Sub buscar_contrato2(ByVal Busqueda As String, ByVal estatus As String)
        Dim i As Integer = 0
        Dim dr As System.Data.IDataReader
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `CONTRATOS` WHERE `Txt_Fk_Cedula` = '" + Busqueda + "' ; ")
            If (dr.Read()) Then
                tienecontrato = 1
                MostrarContrato(Busqueda)
            Else
                LblNoDisponible.Text = "CONTRATO NO DISPONIBLE"
                tienecontrato = 0
                LblNoDisponible.Visible = True
                Me.Size = New System.Drawing.Size(521, 269)
                TlsBtnBuscar.Enabled = True
                TlsBtnNuevo.Enabled = True
                TlsbtnImprimir.Enabled = False
                TlsBtnModificar.Enabled = False
                TlsBtnCancelar.Enabled = False
                TlsBtnGuardar.Enabled = False
            End If
        End If
        dr.Dispose()
        dr.Close()
        Conexion.Cerrar_Conexion()


        'While i < IUPrincipal.Contratos.Count
        '    If IUPrincipal.Contratos.Item(i + 1).ProFk_Cedula Like Busqueda Then
        '        tienecontrato = 1
        '        MostrarContrato(i + 1)
        '        Exit Sub
        '    End If
        '    i = i + 1
        'End While
        'GbxContrato.Visible = False
        'If estatus = "Empleado" Then
        '    LblNoDisponible.Text = "EMPLEADO SIN CONTRATO DISPONIBLE"
        'Else
        '    LblNoDisponible.Text = "ASPIRANTE SIN CONTRATO"
        'End If
        'tienecontrato = 0
        'LblNoDisponible.Visible = True
        'Me.Size = New System.Drawing.Size(521, 269)
        'TlsBtnBuscar.Enabled = True
        'TlsBtnNuevo.Enabled = True
        'TlsbtnImprimir.Enabled = False
        'TlsBtnModificar.Enabled = False
        'TlsBtnCancelar.Enabled = False
        'TlsBtnGuardar.Enabled = False
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        'Dim dr As System.Data.IDataReader
        'Dim bConexionExitosa As Boolean
        'Conexion = New ClaseBaseDatos
        'bConexionExitosa = Conexion.Conectar

        If DgridPersonas.RowCount > 0 Then
            Buscar_Contrato(DgridPersonas.Item(0, DgridPersonas.CurrentRow.Index).Value)

            'If bConexionExitosa Then
            '    LblDatoCedula.Text = DgridPersonas.Item(0, DgridPersonas.CurrentRow.Index).Value
            '    LblDatoNombre.Text = DgridPersonas.Item(1, DgridPersonas.CurrentRow.Index).Value
            '    LblPosicion.Text = DgridPersonas.Item(2, DgridPersonas.CurrentRow.Index).Value
            '    Limpiar_Contrato()
            '    dr = Conexion.Seleccionar("SELECT * FROM `CONTRATOS` WHERE `Txt_Fk_Cedula` = '" + LblDatoCedula.Text + "' ; ")
            '    If (dr.Read()) Then
            '        Buscar_Contrato(LblDatoCedula.Text)
            '        TlsBtnModificar.Enabled = True
            '        TlsbtnImprimir.Enabled = True
            '        TlsBtnIngreso.Enabled = True
            '    Else
            '        tienecontrato = 0
            '        GbxContrato.Visible = False
            '        LblNoDisponible.Text = "CONTRATO NO DISPONIBLE"
            '        LblNoDisponible.Visible = True
            '        Me.Size = New System.Drawing.Size(521, 269)
            '        TlsBtnBuscar.Enabled = True
            '        TlsBtnNuevo.Enabled = True
            '        TlsbtnImprimir.Enabled = False
            '        TlsBtnModificar.Enabled = False
            '    End If
            'End If
            TimerPanel.Start()
        End If


        'If DgridPersonas.RowCount > 0 Then
        '    If EstadoBusqueda = "Normal" Then
        '        LblDatoCedula.Text = DgridPersonas.Item(0, DgridPersonas.CurrentRow.Index).Value
        '        LblDatoNombre.Text = DgridPersonas.Item(1, DgridPersonas.CurrentRow.Index).Value
        '        LblPosicion.Text = DgridPersonas.Item(2, DgridPersonas.CurrentRow.Index).Value
        '        Limpiar_Contrato()

        '        If IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 4 Or IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 5 Or IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 6 Or IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 7 Then
        '            Buscar_Contrato(LblDatoCedula.Text)
        '            'TlsBtnCancelar.Enabled = False
        '            'TlsBtnGuardar.Enabled = False
        '            TlsBtnModificar.Enabled = True
        '            TlsbtnImprimir.Enabled = True
        '            TlsBtnIngreso.Enabled = True
        '        ElseIf IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 3 Then
        '            tienecontrato = 0
        '            GbxContrato.Visible = False
        '            LblNoDisponible.Text = "EMPLEADO SIN CONTRATO"
        '            LblNoDisponible.Visible = True
        '            Me.Size = New System.Drawing.Size(521, 269)
        '            TlsBtnBuscar.Enabled = True
        '            TlsBtnNuevo.Enabled = True
        '            TlsbtnImprimir.Enabled = False
        '            TlsBtnModificar.Enabled = False
        '        ElseIf IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 1 Or IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 2 Or IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = 8 Then
        '            tienecontrato = 0
        '            GbxContrato.Visible = False
        '            LblNoDisponible.Text = "ASPIRANTE SIN CONTRATO"
        '            LblNoDisponible.Visible = True
        '            Me.Size = New System.Drawing.Size(521, 269)
        '            TlsBtnBuscar.Enabled = True
        '            TlsBtnNuevo.Enabled = True
        '            TlsbtnImprimir.Enabled = False
        '            TlsBtnModificar.Enabled = False
        '        End If

        '        'If IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = "Empleado" Then
        '        '    Buscar_Contrato(LblDatoCedula.Text)
        '        '    'TlsBtnCancelar.Enabled = False
        '        '    'TlsBtnGuardar.Enabled = False
        '        '    TlsBtnModificar.Enabled = True
        '        '    TlsbtnImprimir.Enabled = True
        '        '    TlsBtnIngreso.Enabled = True
        '        'Else
        '        '    tienecontrato = 0
        '        '    GbxContrato.Visible = False
        '        '    LblNoDisponible.Text = "ASPIRANTE SIN CONTRATO"
        '        '    LblNoDisponible.Visible = True
        '        '    Me.Size = New System.Drawing.Size(521, 269)
        '        '    TlsBtnBuscar.Enabled = True
        '        '    TlsBtnNuevo.Enabled = True
        '        '    TlsbtnImprimir.Enabled = False
        '        '    TlsBtnModificar.Enabled = False
        '        'End If
        '        TlsBtnNuevo.Enabled = True
        '    End If
        '    If EstadoBusqueda = "Cubrir" Then
        '        LblCedulaCubrir.Text = DgridPersonas.Item(0, DgridPersonas.CurrentRow.Index).Value
        '        LblNombreCubrir.Text = DgridPersonas.Item(1, DgridPersonas.CurrentRow.Index).Value
        '    End If
        '    TimerPanel.Start()
        'End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Buscar(CmbFiltro.SelectedIndex, TxtBusqueda.Text)
    End Sub

    Private Sub Buscar(ByVal Tipo As Integer, ByVal Busqueda As String)
        Dim dr As System.Data.IDataReader
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        DgridPersonas.Rows.Clear()

        If bConexionExitosa Then
            If Tipo = 2 Then
                dr = Conexion.Seleccionar("SELECT * FROM `personas_temp`; ")
                If (dr.Read()) Then
                    DgridPersonas.Rows.Add()
                    DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = dr(1)
                    DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = dr(3) + " " + dr(4)
                End If
            ElseIf Tipo = 0 Then
                dr = Conexion.Seleccionar("SELECT * FROM `personas_temp` where `Txt_Cedula` = '" + Busqueda + "'; ")
                If (dr.Read()) Then
                    DgridPersonas.Rows.Add()
                    DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = dr(1)
                    DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = dr(3) + " " + dr(4)
                End If
            ElseIf Tipo = 1 Then
                dr = Conexion.Seleccionar("SELECT * FROM `personas_temp` where `Txt_Nombres` like '%" + Busqueda + "%' or `Txt_Apellidos` like '%" + Busqueda + "%'; ")
                If (dr.Read()) Then
                    DgridPersonas.Rows.Add()
                    DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = dr(1)
                    DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = dr(3) + " " + dr(4)
                End If
            End If
        End If
        dr.Dispose()
        dr.Close()
        Conexion.Cerrar_Conexion()

        'DgridPersonas.Rows.Clear()
        'Dim i As Integer = 0
        'If Tipo = 2 Then
        '    While i < IUPrincipal.Personas.Count
        '        DgridPersonas.Rows.Add()
        '        DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
        '        DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
        '        DgridPersonas.Item(2, DgridPersonas.RowCount - 1).Value = i + 1
        '        i = i + 1
        '    End While
        'ElseIf Tipo = 0 Then
        '    i = 0
        '    While i < IUPrincipal.Personas.Count
        '        If IUPrincipal.Personas.Item(i + 1).ProCedula Like Busqueda + "*" Then
        '            DgridPersonas.Rows.Add()
        '            DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
        '            DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
        '            DgridPersonas.Item(2, DgridPersonas.RowCount - 1).Value = i + 1
        '        End If
        '        i = i + 1
        '    End While
        'ElseIf Tipo = 1 Then
        '    i = 0
        '    While i < IUPrincipal.Personas.Count
        '        If IUPrincipal.Personas.Item(i + 1).ProNombres Like Busqueda + "*" Then
        '            DgridPersonas.Rows.Add()
        '            DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
        '            DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
        '            DgridPersonas.Item(2, DgridPersonas.RowCount - 1).Value = i + 1
        '        End If
        '        i = i + 1
        '    End While
        'End If
    End Sub

    Private Sub IUGenerarContratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim contratoss As New ClaseContrato
        'Dim personass As String
        'Dim status As String
        Dim conexion2 As ClaseBaseDatos
        Dim pos As New Integer
        conexion2 = New ClaseBaseDatos
        bConexionExitosa = conexion2.Conectar
        pos = -1

        TlsBtnBuscar.Enabled = True
        If IUPrincipal.Departamentos.Count > 0 Then
            Cargar_Departamentos()
        End If

        If Me.LblPosicion.Text <> "" Then
            If bConexionExitosa Then
                dr = conexion2.Seleccionar("SELECT * FROM `contratos` where `Txt_Fk_Cedula` = (select `Txt_Cedula` from `personas_temp` where `Num_Identificador`='" + Me.LblPosicion.Text + "') ; ")
                dr.Read()
                If dr.FieldCount > 0 Then
                    tienecontrato = 1
                    BarraNavegacion.Enabled = True
                    TlsbtnImprimir.Enabled = True
                    TlsBtnIngreso.Enabled = True
                    TlsBtnModificar.Enabled = True
                    formulario_lectura()
                    MostrarContrato(dr(2))
                Else
                    tienecontrato = 0
                    GbxContrato.Visible = False
                    LblNoDisponible.Text = "CONTRATO NO DISPONIBLE"
                    LblNoDisponible.Visible = True
                    Me.Size = New System.Drawing.Size(521, 269)
                    TlsBtnBuscar.Enabled = True
                    TlsBtnNuevo.Enabled = True
                End If
            End If
        Else
            GbxPersona.Visible = False
            LblNoDisponible.Visible = False
            Me.Size = New System.Drawing.Size(521, 126)
            TlsBtnBuscar.Enabled = True
            'TlsBtnNuevo.Enabled = True
        End If
        conexion2.Cerrar_Conexion()
        'If IUPrincipal.Personas.Count > 0 Then
        '    TlsBtnBuscar.Enabled = True
        'End If

        'If IUPrincipal.Departamentos.Count > 0 Then
        '    Cargar_Departamentos()
        'End If

        'If Me.LblPosicion.Text <> "" Then
        '    personass = IUPrincipal.Personas(CInt(Me.LblPosicion.Text)).procedula
        '    status = IUPrincipal.Personas(CInt(Me.LblPosicion.Text)).proestatus
        '    Dim i As Integer = 0
        '    While i < IUPrincipal.Contratos.Count
        '        contratoss = IUPrincipal.Contratos(i + 1)
        '        If personass = IUPrincipal.Contratos(i + 1).ProFk_Cedula Then
        '            pos = i + 1
        '        End If
        '        i = i + 1
        '    End While
        '    If pos = -1 Then
        '        tienecontrato = 0
        '        GbxContrato.Visible = False
        '        LblNoDisponible.Text = UCase(status) + " SIN CONTRATO"
        '        LblNoDisponible.Visible = True
        '        Me.Size = New System.Drawing.Size(521, 269)
        '        TlsBtnBuscar.Enabled = True
        '        TlsBtnNuevo.Enabled = True
        '    Else
        '        tienecontrato = 1
        '        BarraNavegacion.Enabled = True
        '        TlsbtnImprimir.Enabled = True
        '        TlsBtnIngreso.Enabled = True
        '        TlsBtnModificar.Enabled = True
        '        formulario_lectura()
        '        MostrarContrato(personass)
        '        'MostrarContrato(pos)
        '    End If
        '    CmbFiltro.SelectedIndex = 2
        '    CmbHorario.SelectedIndex = 0

        'Else
        '    GbxPersona.Visible = False
        '    LblNoDisponible.Visible = False
        '    Me.Size = New System.Drawing.Size(521, 126)
        '    TlsBtnBuscar.Enabled = True
        '    'TlsBtnNuevo.Enabled = True
        'End If
        ''If IUPrincipal.Contratos.Count > 0 Then
        ''    If LblPosicionContrato.Text <> "0" Then

        ''        MostrarContrato(CInt(LblPosicionContrato.Text))
        ''    End If
        ''End If

    End Sub
    Private Sub Cargar_Departamentos()
        Dim i As Integer = 0
        While i < IUPrincipal.Departamentos.Count
            CmbDepartamento.Items.Add(IUPrincipal.Departamentos(i + 1).ProNombre)
            i = i + 1
        End While
        CmbDepartamento.SelectedIndex = 0
    End Sub
    Private Sub BtnCancelarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarPanel.Click
        TimerPanel.Start()
    End Sub

    Private Sub TlsBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnNuevo.Click
        'If IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = "Empleado" Then
        If tienecontrato = 1 Then
            MsgBox("La Persona Ya Tiene Un Contrato Asignado")
            Exit Sub
        End If
        GbxContrato.Visible = True
        LblNoDisponible.Visible = False
        Me.Size = New System.Drawing.Size(521, 475)
        TlsBtnNuevo.Enabled = False
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
        'GbxContrato.Enabled = True
        EstadoFormulario = "Agregando"
        Limpiar_Contrato()
        formulario_editable()
    End Sub
    Private Sub formulario_editable()
        CmbContrato.Visible = True
        CmbDepartamento.Visible = True
        CmbCargo.Visible = True
        CmbHorario.Visible = True
        DteFechaInicio.Visible = True
        DteFechaFinal.Visible = True
        TxtDuracion.Visible = True
        TxtJornada.Visible = True
        TxtSueldoMensual.Visible = True
        LblCargoEmp.Visible = False
        LblTipoEmp.Visible = False
        LblDepartamentoEmp.Visible = False
        LblHorarioEmp.Visible = False
        LblFInicioEmp.Visible = False
        LblFFinalEmp.Visible = False
        LblDuracionEmp.Visible = False
        LblJornadaEmp.Visible = False
        LblSueldoEmp.Visible = False
        LblFechaFinal.Visible = True
    End Sub
    Private Sub formulario_lectura()
        CmbContrato.Visible = False
        CmbDepartamento.Visible = False
        CmbCargo.Visible = False
        CmbHorario.Visible = False
        DteFechaInicio.Visible = False
        DteFechaFinal.Visible = False
        TxtDuracion.Visible = False
        TxtJornada.Visible = False
        TxtSueldoMensual.Visible = False
        LblCargoEmp.Visible = True
        LblTipoEmp.Visible = True
        LblDepartamentoEmp.Visible = True
        LblHorarioEmp.Visible = True
        LblFInicioEmp.Visible = True
        LblFFinalEmp.Visible = True
        LblDuracion.Visible = True
        LblDuracionEmp.Visible = True
        LblJornadaEmp.Visible = True
        LblSueldoEmp.Visible = True
        LblFechaFinal.Visible = True
    End Sub
    Private Sub Limpiar_Contrato()
        CmbContrato.SelectedIndex = 0
        CmbHorario.SelectedIndex = 0
        TxtJornada.Text = ""
        TxtSueldoMensual.Text = ""
        DteFechaInicio.Value = Today
        DteFechaFinal.Value = Today
        TxtDuracion.Text = ""
        If IUPrincipal.Departamentos.Count > 0 Then
            CmbDepartamento.SelectedIndex = 0
        End If
    End Sub
    Private Sub Cargar_Cargos()
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `cargos` WHERE `Num_Codigo_Departamento` = '" & indicedpto & "' ; ")
            While dr.Read()
                CmbCargo.Items.Add(dr(1))
            End While
            'dr.Read()
        End If
        Conexion.Cerrar_Conexion()

        'Dim cargostemp As ClaseCargo

        'ReDim IndiceCargos(10)
        'If IndiceCargos.Length > 0 Then
        '    Array.Clear(IndiceCargos, 0, IndiceCargos.Length)
        'End If
        'Dim i As Integer = 0
        'Dim j As Integer = 0

        'While i < IUPrincipal.Cargos.Count
        '    cargostemp = IUPrincipal.Cargos(i + 1)
        '    If indicedpto >= 0 Then
        '        If indicedpto = (IUPrincipal.Cargos(i + 1).ProDepartamento + 1) Then
        '            IndiceCargos(j) = IUPrincipal.Cargos(i + 1).ProCodigo
        '            j = j + 1
        '            CmbCargo.Items.Add(IUPrincipal.Cargos(i + 1).ProNombre)
        '        End If
        '    End If
        '    i = i + 1
        'End While
        'If CmbCargo.Items.Count > 0 Then
        '    CmbCargo.SelectedIndex = 0
        'End If
    End Sub

    Private Sub Cargar_Cargos2()
        Dim cargostemp As ClaseCargo
        ReDim IndiceCargos(10)
        If IndiceCargos.Length > 0 Then
            Array.Clear(IndiceCargos, 0, IndiceCargos.Length)
        End If
        Dim i As Integer = 0
        Dim j As Integer = 0

        indicedpto = CmbDepartamento.SelectedIndex + 1
        While i < IUPrincipal.Cargos.Count
            cargostemp = IUPrincipal.Cargos(i + 1)
            If indicedpto >= 0 Then
                If indicedpto = (IUPrincipal.Cargos(i + 1).ProDepartamento + 1) Then
                    IndiceCargos(j) = IUPrincipal.Cargos(i + 1).ProCodigo
                    j = j + 1
                    CmbCargo.Items.Add(IUPrincipal.Cargos(i + 1).ProNombre)
                End If
            End If
            i = i + 1
        End While
        If CmbCargo.Items.Count > 0 Then
            CmbCargo.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDepartamento.SelectedIndexChanged
        If IUPrincipal.Cargos.Count > 0 Then
            CmbCargo.Items.Clear()
            If EstadoFormulario = "Modificando" Or EstadoFormulario = "Agregando" Then
                Cargar_Cargos2()
            Else
                Cargar_Cargos()
            End If


        End If
    End Sub

    Private Sub TlsbtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsbtnImprimir.Click
        Dim Parametro1 As New ParameterValues
        Dim Parametro2 As New ParameterValues
        Dim ParametroNombre As New ParameterDiscreteValue
        Dim ParametroEdad As New ParameterDiscreteValue
        Dim Parametro3 As New ParameterValues
        Dim ParametroCedula As New ParameterDiscreteValue
        Dim Parametro4 As New ParameterValues
        Dim ParametroDireccion As New ParameterDiscreteValue
        Dim Parametro5 As New ParameterValues
        Dim ParametroContrato As New ParameterDiscreteValue
        Dim Parametro6 As New ParameterValues
        Dim ParametroCargo As New ParameterDiscreteValue
        Dim Parametro7 As New ParameterValues
        Dim ParametroJornada As New ParameterDiscreteValue
        Dim Parametro8 As New ParameterValues
        Dim ParametroSueldo As New ParameterDiscreteValue
        Dim Parametro9 As New ParameterValues
        Dim ParametroFechaInicio As New ParameterDiscreteValue
        Dim Parametro10 As New ParameterValues
        Dim ParametroFechaFinal As New ParameterDiscreteValue
        Dim Parametro11 As New ParameterValues
        Dim ParametroNombreCubrir As New ParameterDiscreteValue
        Dim Parametro12 As New ParameterValues
        Dim ParametroCedulaCubrir As New ParameterDiscreteValue
        Dim Parametro13 As New ParameterValues
        Dim ParametroDuracion As New ParameterDiscreteValue
        Dim Parametro14 As New ParameterValues
        Dim ParametroHorario As New ParameterDiscreteValue
        Dim reporte As New CrystalReport1
        Dim ReporteVacaciones As New RptContratoVacaciones
        Dim ReportePeriodoPrueba As New RptPeriodoPrueba
        Dim FechaNacimiento As Date
        Dim Edad As Integer
        Dim EdadenLetras As String
        Dim SueldoenLetras As String
        Dim JornadaenLetras As String

        If CrystalReportViewer1.Visible = True Then
            CrystalReportViewer1.Hide()
            TlsBtnNuevo.Enabled = False
            TlsBtnModificar.Enabled = True
            TlsBtnBuscar.Enabled = True
            TlsBtnIngreso.Enabled = True
            TlsbtnImprimir.Text = "Imprimir"
            Me.WindowState = FormWindowState.Normal
        Else
            TlsBtnNuevo.Enabled = False
            TlsBtnModificar.Enabled = False
            TlsBtnGuardar.Enabled = False
            TlsBtnBuscar.Enabled = False
            TlsBtnCancelar.Enabled = False
            TlsBtnIngreso.Enabled = False
            TlsbtnImprimir.Text = "Regresar"
            ParametroNombre.Value = LblDatoNombre.Text.ToUpper
            Parametro1.Add(ParametroNombre)
            FechaNacimiento = fecnac
            Edad = Today.Year - FechaNacimiento.Year
            If (Today.Month < FechaNacimiento.Month Or (Today.Month = FechaNacimiento.Month And Today.Day < FechaNacimiento.Day)) Then
                Edad = Edad - 1
            End If
            EdadenLetras = Num2Text(Edad)
            ParametroEdad.Value = EdadenLetras + " (" + Edad.ToString + ")"
            Parametro2.Add(ParametroEdad)
            ParametroCedula.Value = LblDatoCedula.Text
            Parametro3.Add(ParametroCedula)
            ParametroDireccion.Value = dire
            Parametro4.Add(ParametroDireccion)
            ParametroCargo.Value = CmbCargo.Text
            Parametro6.Add(ParametroCargo)
            JornadaenLetras = Num2Text(CInt(TxtJornada.Text))
            ParametroJornada.Value = JornadaenLetras + " (" + TxtJornada.Text + ")"
            Parametro7.Add(ParametroJornada)
            SueldoenLetras = NumeroATexto(CDbl(TxtSueldoMensual.Text))
            ParametroSueldo.Value = SueldoenLetras + " (Bs." + TxtSueldoMensual.Text + ")"
            Parametro8.Add(ParametroSueldo)
            ParametroHorario.Value = CmbHorario.Text
            Parametro14.Add(ParametroHorario)
            If CmbContrato.SelectedIndex = 0 Or LblTipoEmp.Text = "PERIODO DE PRUEBA" Then
                ParametroDuracion.Value = " (" + TxtDuracion.Text + ")"
                Parametro13.Add(ParametroDuracion)
                ParametroContrato.Value = "CONTRATO DE TRABAJO DE PERIODO DE PRUEBA"
                Parametro5.Add(ParametroContrato)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Edad").ApplyCurrentValues(Parametro2)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Cedula").ApplyCurrentValues(Parametro3)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Direccion").ApplyCurrentValues(Parametro4)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Cargo").ApplyCurrentValues(Parametro6)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Jornada").ApplyCurrentValues(Parametro7)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Sueldo").ApplyCurrentValues(Parametro8)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Contrato").ApplyCurrentValues(Parametro5)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Duracion").ApplyCurrentValues(Parametro13)
                ReportePeriodoPrueba.DataDefinition.ParameterFields("Horario").ApplyCurrentValues(Parametro14)
                CrystalReportViewer1.ReportSource = ReportePeriodoPrueba
            Else
                ParametroFechaInicio.Value = DteFechaInicio.Value.ToLongDateString
                Parametro9.Add(ParametroFechaInicio)
                ParametroFechaFinal.Value = DteFechaFinal.Value.ToLongDateString
                Parametro10.Add(ParametroFechaFinal)
                If CmbContrato.SelectedIndex = 1 Or LblTipoEmp.Text = "INDETERMINADO" Or LblTipoEmp.Text = "DETERMINADO" Then
                    ParametroContrato.Value = "CONTRATO DE TRABAJO A TIEMPO DETERMINADO POR LA NATURALEZA DEL SERVICIO"
                    Parametro5.Add(ParametroContrato)
                    reporte.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
                    reporte.DataDefinition.ParameterFields("Edad").ApplyCurrentValues(Parametro2)
                    reporte.DataDefinition.ParameterFields("Cedula").ApplyCurrentValues(Parametro3)
                    reporte.DataDefinition.ParameterFields("Direccion").ApplyCurrentValues(Parametro4)
                    reporte.DataDefinition.ParameterFields("Cargo").ApplyCurrentValues(Parametro6)
                    reporte.DataDefinition.ParameterFields("Jornada").ApplyCurrentValues(Parametro7)
                    reporte.DataDefinition.ParameterFields("Sueldo").ApplyCurrentValues(Parametro8)
                    reporte.DataDefinition.ParameterFields("Contrato").ApplyCurrentValues(Parametro5)
                    reporte.DataDefinition.ParameterFields("FechaInicio").ApplyCurrentValues(Parametro9)
                    reporte.DataDefinition.ParameterFields("FechaFinal").ApplyCurrentValues(Parametro10)
                    reporte.DataDefinition.ParameterFields("Horario").ApplyCurrentValues(Parametro14)
                    CrystalReportViewer1.ReportSource = reporte
                ElseIf CmbContrato.SelectedIndex = 2 Or LblTipoEmp.Text = "CUBRIR" Then
                    ParametroContrato.Value = "CONTRATO DE TRABAJO A TIEMPO DETERMINADO PARA CUBRIR PROVISIONALMENTE"
                    ParametroNombreCubrir.Value = LblNombreCubrir.Text
                    Parametro11.Add(ParametroNombreCubrir)
                    ParametroCedulaCubrir.Value = LblCedulaCubrir.Text
                    Parametro12.Add(ParametroCedulaCubrir)
                    Parametro5.Add(ParametroContrato)
                    ReporteVacaciones.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
                    ReporteVacaciones.DataDefinition.ParameterFields("Edad").ApplyCurrentValues(Parametro2)
                    ReporteVacaciones.DataDefinition.ParameterFields("Cedula").ApplyCurrentValues(Parametro3)
                    ReporteVacaciones.DataDefinition.ParameterFields("Direccion").ApplyCurrentValues(Parametro4)
                    ReporteVacaciones.DataDefinition.ParameterFields("Cargo").ApplyCurrentValues(Parametro6)
                    ReporteVacaciones.DataDefinition.ParameterFields("Jornada").ApplyCurrentValues(Parametro7)
                    ReporteVacaciones.DataDefinition.ParameterFields("Sueldo").ApplyCurrentValues(Parametro8)
                    ReporteVacaciones.DataDefinition.ParameterFields("Contrato").ApplyCurrentValues(Parametro5)
                    ReporteVacaciones.DataDefinition.ParameterFields("FechaInicio").ApplyCurrentValues(Parametro9)
                    ReporteVacaciones.DataDefinition.ParameterFields("FechaFinal").ApplyCurrentValues(Parametro10)
                    ReporteVacaciones.DataDefinition.ParameterFields("NombreCubrir").ApplyCurrentValues(Parametro11)
                    ReporteVacaciones.DataDefinition.ParameterFields("CedulaCubrir").ApplyCurrentValues(Parametro12)
                    ReporteVacaciones.DataDefinition.ParameterFields("Horario").ApplyCurrentValues(Parametro14)
                    CrystalReportViewer1.ReportSource = ReporteVacaciones
                End If
            End If
            CrystalReportViewer1.Show()
            Me.WindowState = FormWindowState.Maximized
            CrystalReportViewer1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub TlsBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnGuardar.Click
        Validacion()
    End Sub    
    Private Sub Validacion()     
        If TxtJornada.Text = "" Then
            MsgBox("Falta Ingresar La Cantidad de Horas de la Jornada Laboral", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TxtSueldoMensual.Text = "" Then
            MsgBox("Falta Ingresar el Sueldo Mensual del Empleado", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If CmbDepartamento.Items.Count <= 0 Then
            MsgBox("No Hay Departamento Asignado", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If CmbCargo.Items.Count <= 0 Then
            MsgBox("No Hay Cargo Asignado", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Guardar()
        'EstadoLeyendo()
    End Sub
    Private Sub EstadoLeyendo()
        TlsBtnNuevo.Enabled = True
        If IUPrincipal.Contratos.Count > 0 Then
            TlsBtnModificar.Enabled = True
            BarraNavegacion.Enabled = True
            TlsbtnImprimir.Enabled = True
            TlsBtnIngreso.Enabled = True
        End If
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False
        GbxContrato.Enabled = False
        EstadoFormulario = "Leyendo"
        EstadoModificado = False
    End Sub
    Private Sub Guardar()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If EstadoFormulario = "Agregando" Then
            IUPrincipal.Contrato = New ClaseContrato
            bConexionExitosa = Conexion.Conectar

            'IUPrincipal.Contrato.ProCargo = IndiceCargos(CmbCargo.SelectedIndex)
            'IUPrincipal.Contrato.ProFechaFinal = DteFechaFinal.Value
            'IUPrincipal.Contrato.ProFechaInicial = DteFechaInicio.Value
            If TxtDuracion.Text = "" Then
                TxtDuracion.Text = "0"
            End If
            'IUPrincipal.Contrato.ProDuracion = CInt(TxtDuracion.Text)
            'IUPrincipal.Contrato.ProSueldo = CDbl(TxtSueldoMensual.Text)
            'IUPrincipal.Contrato.ProFk_Cedula = LblDatoCedula.Text
            'IUPrincipal.Personas.Item(CInt(LblPosicion.Text)).ProEstatus = "4"
            'IUPrincipal.Contratos.Add(IUPrincipal.Contrato)
            'PosicionActual = IUPrincipal.Contratos.Count
            'TxtPosicion.Text = IUPrincipal.Contratos.Count
            LabelElementos.Text = "de {" & IUPrincipal.Contratos.Count & "}"
            If bConexionExitosa Then
                Conexion.Insertar("INSERT INTO `CONTRATOS` set `Int_Descripcion` = '" & CmbContrato.SelectedIndex & "',`Int_Fk_Codigo_Departamento` = '" & CmbDepartamento.SelectedIndex + 1 & "',`Int_Fk_Codgio_Cargo` = '" & IndiceCargos(CmbCargo.SelectedIndex) & "',`Int_Jornada` = '" & TxtJornada.Text & "',`Dbl_Sueldo_Mensual` = '" & CDbl(TxtSueldoMensual.Text) & "',`Dte_Fecha_Inicial` = '" + DteFechaInicio.Value.ToString("yyyy-MM-dd") + "',`Dte_Fecha_Final` = '" + DteFechaFinal.Value.ToString("yyyy-MM-dd") + "',`Int_Duracion` = '" & TxtDuracion.Text & "',`Int_Horario` = '" & CmbHorario.SelectedIndex & "',`Txt_Fk_Cedula` = '" + LblDatoCedula.Text + "',`Txt_Fk_Cedula_Cubrir` = '" + LblCedulaCubrir.Text + "',`Txt_Fk_Nombre_Cubrir` = '" + LblNombreCubrir.Text + "'")
                Conexion.Insertar("UPDATE `PERSONAS` set `Int_Estatus` = '4' where `Txt_Cedula`= '" + LblDatoCedula.Text + "';")
            End If
            Conexion.Cerrar_Conexion()

        ElseIf EstadoFormulario = "Modificando" Then
            'Dim bConexionExitosa As Boolean
            'IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = Conexion.Conectar

            'IUPrincipal.Contratos.Item(PosicionActual).ProCargo = IndiceCargos(CmbCargo.SelectedIndex)
            'IUPrincipal.Contratos.Item(PosicionActual).ProDepartamento = CmbDepartamento.SelectedIndex + 1
            'IUPrincipal.Contratos.Item(PosicionActual).ProDescripcion = CmbContrato.SelectedIndex
            'IUPrincipal.Contratos.Item(PosicionActual).ProFechaFinal = DteFechaFinal.Value
            'IUPrincipal.Contratos.Item(PosicionActual).ProFechaInicial = DteFechaInicio.Value
            'IUPrincipal.Contratos.Item(PosicionActual).ProDuracion = TxtDuracion.Text
            'IUPrincipal.Contratos.Item(PosicionActual).ProJornada = TxtJornada.Text
            'IUPrincipal.Contratos.Item(PosicionActual).ProHorario = CmbHorario.SelectedIndex
            'IUPrincipal.Contratos.Item(PosicionActual).ProFk_Cedula_Cubrir = LblCedulaCubrir.Text
            'IUPrincipal.Contratos.Item(PosicionActual).ProFk_Nombre_Cubrir = LblNombreCubrir.Text
            'IUPrincipal.Contratos.Item(PosicionActual).ProSueldo = CDbl(TxtSueldoMensual.Text)
            'IUPrincipal.Contratos.Item(PosicionActual).ProFk_Cedula = LblDatoCedula.Text
            If bConexionExitosa Then
                Conexion.Insertar("UPDATE `CONTRATOS` set `Int_Descripcion` = '" & CmbContrato.SelectedIndex & "',`Int_Fk_Codigo_Departamento` = '" & CmbDepartamento.SelectedIndex + 1 & "',`Int_Fk_Codgio_Cargo` = '" & IndiceCargos(CmbCargo.SelectedIndex) & "',`Int_Jornada` = '" & TxtJornada.Text & "',`Dbl_Sueldo_Mensual` = '" & CDbl(TxtSueldoMensual.Text) & "',`Dte_Fecha_Inicial` = '" + DteFechaInicio.Value.ToString("yyyy-MM-dd") + "',`Dte_Fecha_Final` = '" + DteFechaFinal.Value.ToString("yyyy-MM-dd") + "',`Int_Duracion` = '" & TxtDuracion.Text & "',`Int_Horario` = '" & CmbHorario.SelectedIndex & "',`Txt_Fk_Cedula` = '" + LblDatoCedula.Text + "',`Txt_Fk_Cedula_Cubrir` = '" + LblCedulaCubrir.Text + "',`Txt_Fk_Nombre_Cubrir` = '" + LblNombreCubrir.Text + "' where `Txt_Fk_Cedula`= '" + LblDatoCedula.Text + "';")
            End If
            Conexion.Cerrar_Conexion()
        End If
        TlsBtnNuevo.Enabled = True
        TlsBtnBuscar.Enabled = True

        TlsBtnModificar.Enabled = True
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False
        TlsbtnImprimir.Enabled = True
        TlsBtnIngreso.Enabled = True
        EstadoFormulario = "Leyendo"
        MostrarContrato(PosicionActual)
        formulario_lectura()
    End Sub

    Private Sub BotonSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSiguiente.Click
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If PosicionActual = IUPrincipal.Contratos.Count Then
            dr = Conexion.Seleccionar("SELECT `Txt_Fk_Cedula` FROM `contratos` WHERE `Num_Codigo` = '" & PosicionActual & "' ; ")
            dr.Read()
            MostrarContrato(dr(0))
        Else
            dr = Conexion.Seleccionar("SELECT `Txt_Fk_Cedula` FROM `contratos` WHERE `Num_Codigo` = '" & (PosicionActual + 1) & "' ; ")
            dr.Read()
            MostrarContrato(dr(0))
        End If
    End Sub
    Private Sub MostrarContrato(ByVal Posicion As String)
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Dim dr2 As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar
        Dim NombreCubrir As String
        Dim pos As Integer
        Dim nom As String

        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `contratos` WHERE `Txt_Fk_Cedula` = '" + Posicion + "' ; ")
            dr.Read()
            pos = dr(0)
            'indicedpto = dr(0)
            'dr2 = Conexion.Seleccionar("SELECT * FROM `personas_temp` WHERE `Txt_Cedula` = '" + Posicion + "' ; ")
            'dr2.Read()
            GbxPersona.Visible = True
            LblNoDisponible.Visible = False
            Me.Size = New System.Drawing.Size(521, 475)
            LblDatoCedula.Text = dr(2)
            'LblDatoCedula.Text = Posicion
            'Buscar(0, LblDatoCedula.Text)
            dr2 = Conexion.Seleccionar("SELECT * FROM `personas_temp` WHERE `Txt_Cedula` = '" + Posicion + "' ; ")
            dr2.Read()
            nom = dr2(3) + " " + dr2(4)
            dr2.Dispose()
            dr2.Close()
            'Buscar(0, Posicion)
            'LblDatoNombre.Text = DgridPersonas.Item(1, DgridPersonas.CurrentRow.Index).Value
            LblDatoNombre.Text = nom
            'Dim contrato As New ClaseContrato
            'contrato = IUPrincipal.Contratos.Item(pos)
            LblTipoEmp.Text = dr(1)
            'If IUPrincipal.Contratos.Item(Posicion).ProDescripcion = "0" Then
            '    LblTipoEmp.Text = "Periodo de Prueba"
            'ElseIf IUPrincipal.Contratos.Item(Posicion).ProDescripcion = "1" Then
            '    LblTipoEmp.Text = "Por Tiempo Determinado"
            'ElseIf IUPrincipal.Contratos.Item(Posicion).ProDescripcion = "2" Then
            '    LblTipoEmp.Text = "Para Cubrir Vacacion"
            'End If
            dr2 = Conexion.Seleccionar("SELECT * FROM `departamentos` WHERE `Num_Codigo` = (SELECT `Num_Codigo_Departamento` from `cargos` WHERE `Num_Codigo` = '" & dr(3) & "') ; ")
            dr2.Read()
            indicedpto = dr2(0)
            dr2.Dispose()
            dr2.Close()
            LblDepartamentoEmp.Text = IUPrincipal.Departamentos(indicedpto).Prodescripcion
            LblCargoEmp.Text = Trim(IUPrincipal.Cargos(dr(3)).Prodescripcion)
            CmbContrato.SelectedItem = dr(2)
            CmbDepartamento.SelectedIndex = indicedpto - 1
            'CmbCargo.SelectedIndex = IUPrincipal.Contratos.Item(Posicion).ProCargo
            'CmbCargo.SelectedText = LblCargoEmp.Text
            CmbCargo.SelectedItem = LblCargoEmp.Text

            LblJornadaEmp.Text = dr(16)
            LblSueldoEmp.Text = dr(5)
            LblDuracionEmp.Text = dr(8)
            LblFInicioEmp.Text = dr(6)
            LblFFinalEmp.Text = dr(7)
            If dr(17) = 1 Then
                LblNomina.Visible = True
                LblNomina.Text = "LOCALIDAD: GUAYANA"
            ElseIf dr(17) = 2 Then
                LblNomina.Visible = True
                LblNomina.Text = "LOCALIDAD: VEGAS"
            ElseIf dr(17) = 3 Then
                LblNomina.Visible = True
                LblNomina.Text = "LOCALIDAD: CORPORATIVA"
            End If
            'LblJornadaEmp.Text = IUPrincipal.Contratos.Item(pos).ProJornadaDiaria
            'LblSueldoEmp.Text = IUPrincipal.Contratos.Item(pos).ProSueldo
            'LblDuracionEmp.Text = IUPrincipal.Contratos.Item(pos).ProDuracion
            'LblFInicioEmp.Text = IUPrincipal.Contratos.Item(pos).ProFechaInicial
            'LblFFinalEmp.Text = IUPrincipal.Contratos.Item(pos).ProFechaFinal

            If dr(4) = "2" Then
                LblHorarioEmp.Text = "Rotativo"
            ElseIf dr(4) = "1" Then
                LblHorarioEmp.Text = "Fijo"
            End If

            TxtJornada.Text = dr(16)
            TxtSueldoMensual.Text = dr(5)
            TxtDuracion.Text = dr(8)
            If dr(15) IsNot DBNull.Value Then
                LblCedulaCubrir.Text = dr(15)
            End If


            If LblCedulaCubrir.Text <> "" Then
                dr2 = Conexion.Seleccionar("SELECT * FROM `personas_temp` WHERE `Txt_Cedula` = '" + LblCedulaCubrir.Text + "' ; ")
                dr2.Read()
                NombreCubrir = dr2(3) + " " + dr2(4)
                dr2.Dispose()
                dr2.Close()
                LblNombreCubrir.Text = NombreCubrir
            End If


            DteFechaInicio.Value = dr(6)
            DteFechaFinal.Value = dr(7)
            dr.Dispose()
            dr.Close()
        End If
        Conexion.Cerrar_Conexion()
        CmbContrato.Visible = False
        CmbDepartamento.Visible = False
        CmbCargo.Visible = False
        CmbHorario.Visible = False
        DteFechaInicio.Visible = False
        DteFechaFinal.Visible = False
        TxtDuracion.Visible = False
        TxtJornada.Visible = False
        TxtSueldoMensual.Visible = False
        LblCargoEmp.Visible = True
        LblTipoEmp.Visible = True
        LblDepartamentoEmp.Visible = True
        LblHorarioEmp.Visible = True
        LblFInicioEmp.Visible = True
        LblFFinalEmp.Visible = True
        LblDuracion.Visible = True
        LblDuracionEmp.Visible = True
        LblJornadaEmp.Visible = True
        LblSueldoEmp.Visible = True

        PosicionActual = pos
        TxtPosicion.Text = pos
        LabelElementos.Text = "de {" & IUPrincipal.Contratos.Count & "}"
        TlsLblEstado.Text = "Leyendo..."
    End Sub

    Private Sub BotonAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnterior.Click
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If PosicionActual = 1 Then
            dr = Conexion.Seleccionar("SELECT `Txt_Fk_Cedula` FROM `contratos` WHERE `Num_Codigo` = '1' ; ")
            dr.Read()
            MostrarContrato(dr(0))
        Else
            dr = Conexion.Seleccionar("SELECT `Txt_Fk_Cedula` FROM `contratos` WHERE `Num_Codigo` = '" & PosicionActual - 1 & "' ; ")
            dr.Read()
            MostrarContrato(dr(0))
        End If
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        dr = Conexion.Seleccionar("Select * from contratos order by Num_Codigo DESC LIMIT 1; ")
        dr.Read()
        MostrarContrato(dr(2))

        'MostrarContrato(IUPrincipal.Contratos.Item(IUPrincipal.Contratos.Count).ProFk_Cedula)
    End Sub

    Private Sub BotonPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPrimero.Click
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        dr = Conexion.Seleccionar("Select * from contratos order by Num_Codigo LIMIT 1; ")
        dr.Read()
        MostrarContrato(dr(2))
        'MostrarContrato(IUPrincipal.Contratos.Item(1).ProFk_Cedula)
    End Sub


    Public Function Num2Text(ByVal value As Integer) As String        
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
        End Select
        Return Num2Text
    End Function
    Public Function NumeroATexto(ByVal d As Double) As String
        Dim parteEntera As Double = Math.Truncate(d)
        Dim parteDecimal As Double = Math.Truncate((d - parteEntera) * 100)
        If (parteDecimal > 0) Then
            Return Num2Text(parteEntera) + " BOLIVARES CON " + Num2Text(parteDecimal) + " CENTIMOS"
        Else
            Return Num2Text(parteEntera) + " BOLIVARES CON 0 CENTIMOS"
        End If        
    End Function
    
    Private Sub TlsBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnModificar.Click
        TlsBtnNuevo.Enabled = False
        TlsBtnModificar.Enabled = False
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
        EstadoFormulario = "Modificando"
        formulario_editable()

        'CmbContrato.Visible = True
        'CmbDepartamento.Visible = True
        'CmbCargo.Visible = True
        'CmbHorario.Visible = True
        'DteFechaInicio.Visible = True
        'DteFechaFinal.Visible = True
        'TxtDuracion.Visible = True
        'TxtJornada.Visible = True
        'TxtSueldoMensual.Visible = True
        'LblCargoEmp.Visible = False
        'LblTipoEmp.Visible = False
        'LblDepartamentoEmp.Visible = False
        'LblHorarioEmp.Visible = False
        'LblFInicioEmp.Visible = False
        'LblFFinalEmp.Visible = False
        'LblDuracionEmp.Visible = False
        'LblJornadaEmp.Visible = False
        'LblSueldoEmp.Visible = False
        'GbxContrato.Enabled = True

    End Sub

    Public Function ValidarNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub TxtSueldoMensual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSueldoMensual.KeyPress
        e.Handled = ValidarNumerico(TxtSueldoMensual, e.KeyChar, True)
    End Sub

    Private Sub TxtJornada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJornada.KeyPress
        e.Handled = ValidarNumerico(TxtJornada, e.KeyChar, False)
    End Sub
    Private Sub CmbContrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbContrato.SelectedIndexChanged
        If CmbContrato.SelectedIndex = 0 Then
            LblFechaInicio.Visible = True
            LblFechaFinal.Visible = True
            If EstadoFormulario <> "Leyendo" Then
                DteFechaInicio.Visible = True
                TxtDuracion.Visible = True
            End If
            DteFechaFinal.Visible = False

            LblDuracion.Visible = True
            GbxProvisional.Visible = False
            TxtDuracion.Text = "30"
        ElseIf CmbContrato.SelectedIndex = 1 Then
            LblFechaInicio.Visible = True
            LblFechaFinal.Visible = True
            If EstadoFormulario <> "Leyendo" Then
                DteFechaInicio.Visible = True
            End If
            DteFechaFinal.Visible = True
            TxtDuracion.Visible = False
            LblDuracion.Visible = False
            GbxProvisional.Visible = False
        ElseIf CmbContrato.SelectedIndex = 2 Then
            LblFechaInicio.Visible = True
            LblFechaFinal.Visible = True
            If EstadoFormulario <> "Leyendo" Then
                DteFechaInicio.Visible = True
            End If
            DteFechaFinal.Visible = True
            TxtDuracion.Visible = False
            LblDuracion.Visible = False
            LblNombreCubrir.Text = ""
            LblCedulaCubrir.Text = ""
            GbxProvisional.Visible = True
        End If
    End Sub

  
    Private Sub BtnBuscarCubrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarCubrir.Click
        EstadoBusqueda = "Cubrir"
        TimerPanel.Start()
    End Sub

    Private Sub TlsBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnCancelar.Click
        LblPosicionContrato.Text = 1
        LblDatoCedula.Text = ""
        LblDatoNombre.Text = ""
        EstadoFormulario = "Leyendo"
        CmbContrato.Visible = False
        CmbDepartamento.Visible = False
        CmbCargo.Visible = False
        CmbHorario.Visible = False
        DteFechaInicio.Visible = False
        DteFechaFinal.Visible = False
        TxtDuracion.Visible = False
        TxtJornada.Visible = False
        TxtSueldoMensual.Visible = False
        TlsBtnNuevo.Enabled = False
        TlsBtnModificar.Enabled = False
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False

        GbxPersona.Visible = False
        LblNoDisponible.Visible = False
        Me.Size = New System.Drawing.Size(521, 126)

        'GbxContrato.Enabled = False
        'If IUPrincipal.Contratos.Count > 0 Then
        '    TlsBtnModificar.Enabled = True
        '    MostrarContrato(1)
        'End If        
    End Sub

    Private Sub TlsBtnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnIngreso.Click
        Dim Parametro1 As New ParameterValues
        Dim Parametro2 As New ParameterValues
        Dim Parametro3 As New ParameterValues
        Dim Parametro4 As New ParameterValues
        Dim Parametro5 As New ParameterValues
        Dim Parametro6 As New ParameterValues
        Dim Parametro7 As New ParameterValues
        Dim ParametroNombre As New ParameterDiscreteValue
        Dim ParametroCedula As New ParameterDiscreteValue
        Dim ParametroFechaInicio As New ParameterDiscreteValue
        Dim ParametroDireccion As New ParameterDiscreteValue
        Dim ParametroCargo As New ParameterDiscreteValue
        Dim ParametroDepartamento As New ParameterDiscreteValue
        Dim ParametroSueldo As New ParameterDiscreteValue
        Dim ReporteIngreso As New RptIngreso
        
        If CrystalReportViewer1.Visible = True Then
            CrystalReportViewer1.Hide()
            TlsBtnNuevo.Enabled = False
            TlsBtnModificar.Enabled = True
            TlsBtnBuscar.Enabled = True
            TlsbtnImprimir.Enabled = True
            TlsBtnIngreso.Text = "Ingreso"
            Me.WindowState = FormWindowState.Normal
        Else
            TlsBtnNuevo.Enabled = False
            TlsBtnModificar.Enabled = False
            TlsBtnGuardar.Enabled = False
            TlsBtnBuscar.Enabled = False
            TlsBtnCancelar.Enabled = False
            TlsbtnImprimir.Enabled = False
            TlsBtnIngreso.Text = "Regresar"
            ParametroNombre.Value = LblDatoNombre.Text.ToUpper
            Parametro1.Add(ParametroNombre)
            ParametroCedula.Value = LblDatoCedula.Text
            Parametro2.Add(ParametroCedula)
            ParametroFechaInicio.Value = DteFechaInicio.Value
            Parametro3.Add(ParametroFechaInicio)
            ParametroDireccion.Value = dire
            Parametro4.Add(ParametroDireccion)
            ParametroCargo.Value = CmbCargo.Text
            Parametro5.Add(ParametroCargo)
            ParametroDepartamento.Value = CmbDepartamento.Text
            Parametro6.Add(ParametroDepartamento)            
            ParametroSueldo.Value = TxtSueldoMensual.Text
            Parametro7.Add(ParametroSueldo)

            ReporteIngreso.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
            ReporteIngreso.DataDefinition.ParameterFields("Cedula").ApplyCurrentValues(Parametro2)
            ReporteIngreso.DataDefinition.ParameterFields("FechaInicial").ApplyCurrentValues(Parametro3)
            ReporteIngreso.DataDefinition.ParameterFields("Direccion").ApplyCurrentValues(Parametro4)
            ReporteIngreso.DataDefinition.ParameterFields("Cargo").ApplyCurrentValues(Parametro5)
            ReporteIngreso.DataDefinition.ParameterFields("Departamento").ApplyCurrentValues(Parametro6)
            ReporteIngreso.DataDefinition.ParameterFields("Sueldo").ApplyCurrentValues(Parametro7)

            CrystalReportViewer1.ReportSource = ReporteIngreso                    
            CrystalReportViewer1.Show()
            Me.WindowState = FormWindowState.Maximized
            CrystalReportViewer1.Dock = DockStyle.Fill
        End If
    End Sub
End Class