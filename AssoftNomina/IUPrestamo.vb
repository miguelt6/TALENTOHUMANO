Public Class IUPrestamo
    Dim PanelMostrado As Boolean = False
    Dim EstadoFormulario As String = "Leyendo"
    Dim PosicionActual As Integer = 0
    Dim EstadoModificado As Boolean = False
    Private Sub TlsBtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnBuscar.Click        
        TimerPanel.Start()
    End Sub

    Private Sub IUPrestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IUPrincipal.Personas.Count > 0 Then
            TlsBtnBuscar.Enabled = True
            CmbFiltro.SelectedIndex = 0        
        End If
        If IUPrincipal.Prestamos.Count > 0 Then        
            BarraNavegacion.Enabled = True
            TlsBtnModificar.Enabled = True
        End If                        
    End Sub

    Private Sub TimerPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanel.Tick
        If PanelMostrado Then
            PanelBuscarPersonas.Top = PanelBuscarPersonas.Top - 25
        Else
            PanelBuscarPersonas.Top = PanelBuscarPersonas.Top + 25
        End If
        If PanelBuscarPersonas.Top >= 0 Then
            TimerPanel.Stop()
            PanelMostrado = True
        End If
        If PanelBuscarPersonas.Top <= -425 Then
            TimerPanel.Stop()
            PanelMostrado = False
        End If
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Buscar(CmbFiltro.SelectedIndex, TxtBusqueda.Text)
    End Sub

    Private Sub Buscar(ByVal Tipo As Integer, ByVal Busqueda As String)
        DgridPersonas.Rows.Clear()
        Dim i As Integer = 0
        If Tipo = 2 Then
            While i < IUPrincipal.Personas.Count
                If IUPrincipal.Personas.Item(i + 1).ProApellidos.ToLower Like Busqueda.ToLower + "*" Then
                    DgridPersonas.Rows.Add()
                    DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
                    DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
                    DgridPersonas.Item(2, DgridPersonas.RowCount - 1).Value = i + 1
                End If
                i = i + 1
            End While
        ElseIf Tipo = 0 Then
            i = 0
            While i < IUPrincipal.Personas.Count
                If IUPrincipal.Personas.Item(i + 1).ProCedula Like Busqueda + "*" Then
                    DgridPersonas.Rows.Add()
                    DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
                    DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
                    DgridPersonas.Item(2, DgridPersonas.RowCount - 1).Value = i + 1
                End If
                i = i + 1
            End While
        ElseIf Tipo = 1 Then
            i = 0
            While i < IUPrincipal.Personas.Count
                If IUPrincipal.Personas.Item(i + 1).ProNombres.ToLower Like Busqueda.ToLower + "*" Then
                    DgridPersonas.Rows.Add()
                    DgridPersonas.Item(0, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
                    DgridPersonas.Item(1, DgridPersonas.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
                    DgridPersonas.Item(2, DgridPersonas.RowCount - 1).Value = i + 1
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        If DgridPersonas.RowCount > 0 Then            
            LblDatoCedula.Text = DgridPersonas.Item(0, DgridPersonas.CurrentRow.Index).Value
            LblDatoNombre.Text = DgridPersonas.Item(1, DgridPersonas.CurrentRow.Index).Value
            LblPosicion.Text = DgridPersonas.Item(2, DgridPersonas.CurrentRow.Index).Value
            Limpiar_Prestamo()
            TlsBtnNuevo.Enabled = True        
            TimerPanel.Start()
        End If
    End Sub
    Private Sub Limpiar_Prestamo()
        TxtMonto.Text = ""
        TxtNumCuotas.Text = ""
        CmbPago.SelectedIndex = 0
        CmbCobro.SelectedIndex = 0
        DteFechaInicio.Value = Today
        Establecer_Fecha_Inicial()
    End Sub

    Private Sub BtnCancelarPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelarPanel.Click
        TimerPanel.Start()
    End Sub

    Private Sub TlsBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnNuevo.Click
        Limpiar_Prestamo()
        EstadoFormulario = "Agregando"
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
        GbxPrestamo.Enabled = True
    End Sub

    Private Sub Establecer_Fecha_Inicial()
        Dim Numero_Dias As Integer
        Dim Fecha As String        
        If Today.Day > 15 Then
            Numero_Dias = Date.DaysInMonth(Today.Year, Today.Month)
        Else
            Numero_Dias = 15
        End If
        Fecha = CStr(Numero_Dias) + "/" + CStr(Today.Month) + "/" + CStr(Today.Year)
        DteFechaInicio.Value = CDate(Fecha)
    End Sub
    Private Sub CmbPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPago.SelectedIndexChanged
        If CmbPago.SelectedIndex = 1 Then
            CmbCobro.Enabled = True
            CmbCobro.SelectedIndex = 0
        Else
            CmbCobro.Enabled = False
        End If
        Establecer_Fecha_Inicial()
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

    Private Sub TxtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonto.KeyPress
        e.Handled = IUGenerarContratos.ValidarNumerico(TxtMonto, e.KeyChar, True)
    End Sub

    Private Sub TxtNumCuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumCuotas.KeyPress
        e.Handled = IUGenerarContratos.ValidarNumerico(TxtNumCuotas, e.KeyChar, False)
    End Sub

    Private Sub BtnCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCuota.Click
        If TxtMonto.Text = "" Then
            MsgBox("Falta Ingresar el Valor del Monto")
            Exit Sub
        End If
        If TxtNumCuotas.Text = "" Then
            MsgBox("Falta Ingresar el Numero de Cuotas")
            Exit Sub
        End If
        LblMontoCuotaValor.Text = FormatNumber(CDbl(TxtMonto.Text) / CDbl(TxtNumCuotas.Text), 2)
    End Sub

    Private Sub TlsBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnGuardar.Click
        Validar()
    End Sub
    Private Sub Validar()
        If Me.TxtMonto.Text = Nothing Then
            MsgBox("Falta Ingresar El Monto")
            Exit Sub
        End If
        If Me.TxtNumCuotas.Text = Nothing Then
            MsgBox("Falta Ingresar el Numero de Cuotas")
            Exit Sub        
        End If
        Guardar()
        Estado_Leyendo()
    End Sub
    Private Sub Estado_Leyendo()
        TlsBtnNuevo.Enabled = True        
        GbxPrestamo.Enabled = False
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False
    End Sub
    Private Sub Guardar()
        If EstadoFormulario = "Agregando" Then
            IUPrincipal.Prestamo = New ClasePrestamo
            IUPrincipal.Prestamo.ProFk_Cedula = LblDatoCedula.Text
            IUPrincipal.Prestamo.ProMonto = TxtMonto.Text
            IUPrincipal.Prestamo.ProNum_Cuotas = TxtNumCuotas.Text
            IUPrincipal.Prestamo.ProPago = CmbPago.SelectedIndex
            IUPrincipal.Prestamo.ProCobro = CmbCobro.SelectedIndex
            IUPrincipal.Prestamo.ProFechaInicio = DteFechaInicio.Value
            IUPrincipal.Prestamo.ProFechaFinal = DteFechaInicio.Value            
            IUPrincipal.Prestamos.Add(IUPrincipal.Prestamo)
            PosicionActual = IUPrincipal.Prestamos.Count
            TxtPosicion.Text = IUPrincipal.Prestamos.Count()
            LabelElementos.Text = "de {" & IUPrincipal.Prestamos.Count & "}"
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("INSERT INTO `PRESTAMOS` set `Fk_Txt_Cedula` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProFk_Cedula + "',`Dbl_Monto` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProMonto + "',`Int_Num_Cuotas` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProNum_Cuotas + "',`Int_Forma_Pago` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProPago + "',`Int_Cobro` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProCobro + "',`Dte_Fecha_Inicio` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProFechaInicio + "',`Dte_Fecha_Final` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProFechaFinal + "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        ElseIf EstadoFormulario = "Modificando" Then
            IUPrincipal.Prestamos.Item(PosicionActual).ProFk_Cedula = LblDatoCedula.Text
            IUPrincipal.Prestamos.Item(PosicionActual).ProMonto = TxtMonto.Text
            IUPrincipal.Prestamos.Item(PosicionActual).ProNum_Cuotas = TxtNumCuotas.Text
            IUPrincipal.Prestamos.Item(PosicionActual).ProPago = CmbPago.SelectedIndex
            IUPrincipal.Prestamos.Item(PosicionActual).ProCobro = CmbCobro.SelectedIndex
            IUPrincipal.Prestamos.Item(PosicionActual).ProFechaInicio = DteFechaInicio.Value
            IUPrincipal.Prestamos.Item(PosicionActual).ProFechaFinal = DteFechaInicio.Value
            ''''REALIZAR UPDATE EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("UPDATE `PRESTAMOS` set `Dbl_Monto` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProMonto + "',`Int_Num_Cuotas` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProNum_Cuotas + "',`Int_Forma_Pago` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProPago + "',`Int_Cobro` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProCobro + "',`Dte_Fecha_Inicio` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProFechaInicio + "',`Dte_Fecha_Final` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProFechaFinal + "' where `Fk_Txt_Cedula` = '" + IUPrincipal.Prestamos.Item(PosicionActual).ProFkCedula + "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        End If
    End Sub

    Private Sub CmbCobro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCobro.SelectedIndexChanged
        Dim Numero_Dias As Integer
        If CmbCobro.SelectedIndex = 0 Then
            If Today.Day > 15 Then
                DteFechaInicio.Value = CDate("15/" + CStr(Today.Month + 1) + "/" + CStr(Today.Year))
            Else
                DteFechaInicio.Value = CDate("15/" + CStr(Today.Month) + "/" + CStr(Today.Year))
            End If
        Else
            Numero_Dias = Date.DaysInMonth(Today.Year, Today.Month)
            DteFechaInicio.Value = CDate(CStr(Numero_Dias) + "/" + CStr(Today.Month) + "/" + CStr(Today.Year))
        End If
    End Sub
End Class