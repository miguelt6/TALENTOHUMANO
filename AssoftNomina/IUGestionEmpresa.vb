Public Class EMPFRM001
    Dim EstadoModificado As Boolean = False
    Private Sub Cargar_Paises()
        Dim i As Integer = 0
        While i < IUPrincipal.Paises.Count
            i = i + 1
            CmbPaises.Items.Add(IUPrincipal.Paises.Item(i).ProDescripcion)
        End While
    End Sub
    Private Sub Cargar_TipoEmpresas()
        Dim i As Integer = 0
        While i < IUPrincipal.TipoEmpresas.Count
            i = i + 1
            CmbTipoEmpresa.Items.Add(IUPrincipal.TipoEmpresas.Item(i).ProDescripcion)
        End While
    End Sub
    Private Sub Cargar_Actividades()
        Dim i As Integer = 0
        While i < IUPrincipal.Actividades.Count
            i = i + 1
            CmbActividad.Items.Add(IUPrincipal.Actividades.Item(i).ProDescripcion)
        End While
    End Sub
    Private Sub Cargar_Sector()
        Dim i As Integer = 0
        While i < IUPrincipal.Sectores.Count
            i = i + 1
            CmbSector.Items.Add(IUPrincipal.Sectores.Item(i).ProDescripcion)
        End While
    End Sub

    Private Sub EMPFRM001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Paises()
        Cargar_Actividades()
        Cargar_TipoEmpresas()
        Cargar_Sector()
        TxtCiudades.Text = IUPrincipal.Empresa.ProCiudad
        TxtDomicilio.Text = IUPrincipal.Empresa.ProDomicilio
        TxtMunicipio.Text = IUPrincipal.Empresa.ProMunicipio
        If IUPrincipal.Contratos.Count > 0 Then
            LblNumEmp.Text = IUPrincipal.Contratos.Count
        End If
        If CmbPaises.Items.Count > 0 Then
            CmbPaises.SelectedIndex = IUPrincipal.Empresa.ProPais
        End If
        If CmbEstados.Items.Count > 0 Then
            CmbEstados.SelectedIndex = IUPrincipal.Empresa.ProEstado
        End If
        TxtRazonSocial.Text = IUPrincipal.Empresa.ProRazonSocial
        TxtRepresentante.Text = IUPrincipal.Empresa.ProRepresentante
        TxtRif.Text = IUPrincipal.Empresa.ProRif
        If CmbRif.Items.Count > 0 Then
            CmbRif.SelectedIndex = IUPrincipal.Empresa.ProLRif
        End If
        TxtTelefonoPrincipal.Text = IUPrincipal.Empresa.ProTelefono
        If CmbActividad.Items.Count > 0 Then
            CmbActividad.SelectedIndex = IUPrincipal.Empresa.ProActividad
        End If
        TxtEmail.Text = IUPrincipal.Empresa.ProEmail
        TxtFax.Text = IUPrincipal.Empresa.ProFax
        OfdLogo.FileName = IUPrincipal.Empresa.ProLogo
        PbxLogo.ImageLocation = OfdLogo.FileName
        RbnHorizontal.Checked = IUPrincipal.Empresa.ProOrientacion
        If CmbSector.Items.Count > 0 Then
            CmbSector.SelectedIndex = IUPrincipal.Empresa.ProSector
        End If
        If CmbTipoEmpresa.Items.Count > 0 Then
            CmbTipoEmpresa.SelectedIndex = IUPrincipal.Empresa.ProTipoEmpresa
        End If
        TxtWeb.Text = IUPrincipal.Empresa.ProWeb
        TxtAcciones.Text = IUPrincipal.Empresa.ProAcciones
        TxtActa.Text = IUPrincipal.Empresa.ProActaConstitutiva
        RbnSi.Checked = IUPrincipal.Empresa.ProAgentePercepcion
        RbnNo.Checked = Not IUPrincipal.Empresa.ProAgentePercepcion
        RbnRetNo.Checked = Not IUPrincipal.Empresa.ProAgenteRetencion
        RbnRetSi.Checked = IUPrincipal.Empresa.ProAgenteRetencion
        TxtCapital.Text = IUPrincipal.Empresa.ProCapital
        TxtPagoNomina.Text = IUPrincipal.Empresa.ProCodPagoNomina
        RbnEspecialSi.Checked = IUPrincipal.Empresa.ProContribuyente
        RbnEspecialNo.Checked = Not IUPrincipal.Empresa.ProContribuyente
        CmbDeclaracion.SelectedIndex = IUPrincipal.Empresa.ProDeclaracion
        TxtEntidad.Text = IUPrincipal.Empresa.ProEntidad
        TxtExpediente.Text = IUPrincipal.Empresa.ProExpediente
        DteFechaRegistro.Value = IUPrincipal.Empresa.ProFechaRegistro
        TxtInces.Text = IUPrincipal.Empresa.ProInces
        TxtNil.Text = IUPrincipal.Empresa.ProNil
        TxtPorRetencion.Text = IUPrincipal.Empresa.ProPorRetencion
        TxtSso.Text = IUPrincipal.Empresa.ProSso
        CmbTipoContribuyente.SelectedIndex = IUPrincipal.Empresa.ProTipoContribuyente
        TxtTomo.Text = IUPrincipal.Empresa.ProTomo
        TxtValor.Text = IUPrincipal.Empresa.ProValorAccion
    End Sub

    Private Sub RbnVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbnVertical.CheckedChanged
        If RbnVertical.Checked = True Then
            PbxLogo.Width = 90
            PbxLogo.Height = 130
            PbxLogo.Top = 320
        End If
    End Sub

    Private Sub RbnHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbnHorizontal.CheckedChanged
        If RbnHorizontal.Checked = True Then
            PbxLogo.Width = 139
            PbxLogo.Height = 88
            PbxLogo.Top = 350
        End If
    End Sub

    Private Sub BtnLogotipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogotipo.Click
        OfdLogo.ShowDialog()
        PbxLogo.ImageLocation = OfdLogo.FileName
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        TlsBtnGuardar.Enabled = True
        ToolStripButton3.Enabled = True
        GbxDatosLegales.Enabled = True
        GbxDatosContribuyente.Enabled = True
        TxtRazonSocial.Enabled = True
        CmbRif.Enabled = True
        TxtRif.Enabled = True
        TxtDomicilio.Enabled = True
        TxtRepresentante.Enabled = True
        TxtWeb.Enabled = True
        CmbPaises.Enabled = True
        CmbEstados.Enabled = True
        TxtMunicipio.Enabled = True
        TxtCiudades.Enabled = True
        TxtEmail.Enabled = True
        TxtFax.Enabled = True
        TxtTelefonoPrincipal.Enabled = True
        CmbActividad.Enabled = True
        CmbSector.Enabled = True
        CmbTipoEmpresa.Enabled = True
        BtnLogotipo.Enabled = True
        GbxOrientacion.Enabled = True
        DteFechaRegistro.Enabled = True
        TxtEntidad.Enabled = True
        TxtActa.Enabled = True
        TxtTomo.Enabled = True
        TxtSso.Enabled = True
        TxtExpediente.Enabled = True
        TxtCapital.Enabled = True
        TxtAcciones.Enabled = True
        TxtValor.Enabled = True
        TxtInces.Enabled = True
        TxtNil.Enabled = True
        TxtPagoNomina.Enabled = True
        CmbDeclaracion.Enabled = True
        CmbTipoContribuyente.Enabled = True
        TxtPorRetencion.Enabled = True
        GbxPercepcion.Enabled = True
        GbxRetencion.Enabled = True
        GbxContEspecial.Enabled = True
    End Sub

    Private Sub TlsBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnGuardar.Click
        If CmbPaises.Items.Count < 1 Then
            MsgBox("Debe Ingresar Un Pais de Ubicación de La Empresa")
            Exit Sub
        End If
        If CmbEstados.Items.Count < 1 Then
            MsgBox("Debe Ingresar Un Estado de Ubicación de La Empresa")
            Exit Sub
        End If
        TxtRazonSocial.Enabled = False
        CmbRif.Enabled = False
        TxtRif.Enabled = False
        TxtDomicilio.Enabled = False
        TxtRepresentante.Enabled = False
        TxtWeb.Enabled = False
        CmbPaises.Enabled = False
        CmbEstados.Enabled = False
        TxtMunicipio.Enabled = False
        TxtCiudades.Enabled = False
        TxtEmail.Enabled = False
        TxtFax.Enabled = False
        TxtTelefonoPrincipal.Enabled = False
        CmbActividad.Enabled = False
        CmbSector.Enabled = False
        CmbTipoEmpresa.Enabled = False
        BtnLogotipo.Enabled = False
        GbxOrientacion.Enabled = False
        GbxDatosLegales.Enabled = False
        GbxDatosContribuyente.Enabled = False
        IUPrincipal.Empresa.ProCiudad = TxtCiudades.Text
        IUPrincipal.Empresa.ProDomicilio = TxtDomicilio.Text
        IUPrincipal.Empresa.ProEstado = CInt(CmbEstados.SelectedIndex)
        IUPrincipal.Empresa.ProMunicipio = TxtMunicipio.Text
        IUPrincipal.Empresa.ProPais = CmbPaises.SelectedIndex
        IUPrincipal.Empresa.ProRazonSocial = TxtRazonSocial.Text
        IUPrincipal.Empresa.ProRepresentante = TxtRepresentante.Text
        IUPrincipal.Empresa.ProRif = TxtRif.Text
        IUPrincipal.Empresa.ProLRif = CmbRif.SelectedIndex
        IUPrincipal.Empresa.ProTelefono = TxtTelefonoPrincipal.Text
        If CmbActividad.SelectedIndex <> -1 Then
            IUPrincipal.Empresa.ProActividad = CInt(CmbActividad.SelectedIndex)
        Else
            IUPrincipal.Empresa.ProActividad = 0
        End If
        IUPrincipal.Empresa.ProEmail = TxtEmail.Text
        IUPrincipal.Empresa.ProFax = TxtFax.Text
        IUPrincipal.Empresa.ProLogo = OfdLogo.FileName
        If RbnHorizontal.Checked Then
            IUPrincipal.Empresa.ProOrientacion = 1
        Else
            IUPrincipal.Empresa.ProOrientacion = 0
        End If
        If CmbSector.SelectedIndex <> -1 Then
            IUPrincipal.Empresa.ProSector = CInt(CmbSector.SelectedIndex)
        Else
            IUPrincipal.Empresa.ProSector = 0
        End If
        If CmbTipoEmpresa.SelectedIndex <> -1 Then
            IUPrincipal.Empresa.ProTipoEmpresa = CInt(CmbTipoEmpresa.SelectedIndex)
        Else
            IUPrincipal.Empresa.ProTipoEmpresa = 0
        End If
        'IUPrincipal.Empresa.ProTipoEmpresa = CInt(CmbTipoEmpresa.SelectedIndex)
        IUPrincipal.Empresa.ProWeb = TxtWeb.Text
        IUPrincipal.Empresa.ProAcciones = TxtAcciones.Text
        IUPrincipal.Empresa.ProActaConstitutiva = TxtActa.Text
        If RbnSi.Checked Then
            IUPrincipal.Empresa.ProAgentePercepcion = 1
        Else
            IUPrincipal.Empresa.ProAgentePercepcion = 0
        End If
        If RbnRetSi.Checked Then
            IUPrincipal.Empresa.ProAgenteRetencion = 1
        Else
            IUPrincipal.Empresa.ProAgenteRetencion = 0
        End If
        IUPrincipal.Empresa.ProCapital = TxtCapital.Text
        IUPrincipal.Empresa.ProCodPagoNomina = TxtPagoNomina.Text
        If RbnEspecialSi.Checked Then
            IUPrincipal.Empresa.ProContribuyente = 1
        Else
            IUPrincipal.Empresa.ProContribuyente = 0
        End If
        IUPrincipal.Empresa.ProDeclaracion = CmbDeclaracion.SelectedIndex
        IUPrincipal.Empresa.ProEntidad = TxtEntidad.Text
        IUPrincipal.Empresa.ProExpediente = TxtExpediente.Text
        IUPrincipal.Empresa.ProFechaRegistro = DteFechaRegistro.Value
        IUPrincipal.Empresa.ProInces = TxtInces.Text
        IUPrincipal.Empresa.ProNil = TxtNil.Text
        IUPrincipal.Empresa.ProPorRetencion = TxtPorRetencion.Text
        IUPrincipal.Empresa.ProSso = TxtSso.Text
        IUPrincipal.Empresa.ProTipoContribuyente = CmbTipoContribuyente.SelectedIndex
        IUPrincipal.Empresa.ProTomo = TxtTomo.Text
        IUPrincipal.Empresa.ProValorAccion = TxtValor.Text
        ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
        Dim bConexionExitosa As Boolean
        IUPrincipal.Conexion = New ClaseBaseDatos
        bConexionExitosa = IUPrincipal.Conexion.Conectar
        If bConexionExitosa Then
            'query = "`Txt_Ciudad` = '" + IUPrincipal.Empresa.ProCiudad + "',`Txt_Email` = '" + IUPrincipal.Empresa.ProEmail + "',`Txt_Telefono` = '" + IUPrincipal.Empresa.ProTelefono + "',`Txt_Fax` = '" + IUPrincipal.Empresa.ProFax + "',`Int_Actividad` = '" + IUPrincipal.Empresa.ProActividad + "',`Int_Tipo_Empresa` = '" + IUPrincipal.Empresa.ProTipoEmpresa + "',`Int_Sector` = '" + IUPrincipal.Empresa.ProSector + "',`Boo_Orientacion` = '" & IUPrincipal.Empresa.ProOrientacion & "',`Txt_Logo` = '" + IUPrincipal.Empresa.ProLogo + "',`Dte_Fecha_Registro` = '" & IUPrincipal.Empresa.ProFechaRegistro & "',`Txt_Entidad` = '" + IUPrincipal.Empresa.ProEntidad + "',`Txt_Acta_Constitutiva` = '" + IUPrincipal.Empresa.ProActaConstitutiva + "',`Txt_Tomo` = '" + IUPrincipal.Empresa.ProTomo + "',`Txt_SSO` = '" + IUPrincipal.Empresa.ProSso + "',`Txt_Expediente` = '" + IUPrincipal.Empresa.ProExpediente + "',`Txt_Capital` = '" + IUPrincipal.Empresa.ProCapital + "',`Txt_Acciones` = '" + IUPrincipal.Empresa.ProAcciones + "',`Txt_Valor_Accion` = '" + IUPrincipal.Empresa.ProAcciones + "',`Txt_Inces` = '" + IUPrincipal.Empresa.ProInces + "',`Txt_NIL` = '" + IUPrincipal.Empresa.ProNil + "',`Txt_Codigo_Pago_Nomina` = '" + IUPrincipal.Empresa.ProCodPagoNomina + "',`Int_Tipo_Contribuyente` = '" & IUPrincipal.Empresa.ProTipoContribuyente & "',`Int_Declaracion` = '" & IUPrincipal.Empresa.ProDeclaracion & "',`Txt_Por_Retencion` = '" + IUPrincipal.Empresa.ProPorRetencion + "',`Boo_Agente_Percepcion` = '" & IUPrincipal.Empresa.ProAgentePercepcion & "',`Boo_Agente_Retencion` = '" & IUPrincipal.Empresa.ProAgenteRetencion & "',`Boo_Contribuyente` = '" & IUPrincipal.Empresa.ProContribuyente & "';"
            'query = "UPDATE `EMPRESA` set `Txt_Rif` = '" + IUPrincipal.Empresa.ProRif + "',`Int_LRif` = '" & IUPrincipal.Empresa.ProLRif & "',`Txt_Razon_Social` = '" + IUPrincipal.Empresa.ProRazonSocial + "',`Txt_Domicilio` = '" + IUPrincipal.Empresa.ProDomicilio + "',`Txt_Representante` = '" + IUPrincipal.Empresa.ProRepresentante + "',`Txt_Web` = '" + IUPrincipal.Empresa.ProWeb + "',`Int_Pais` = '" & IUPrincipal.Empresa.ProPais & "',`Int_Estado` = '" & IUPrincipal.Empresa.ProEstado & "', `Txt_Municipio` ='" + IUPrincipal.Empresa.ProMunicipio + "', `Txt_Ciudad` = '" + IUPrincipal.Empresa.ProCiudad + "',`Txt_Email` = '" + IUPrincipal.Empresa.ProEmail + "',`Txt_Telefono` = '" + IUPrincipal.Empresa.ProTelefono + "',`Txt_Fax` = '" + IUPrincipal.Empresa.ProFax + "',`Int_Actividad` = '" & IUPrincipal.Empresa.ProActividad & "',`Int_Tipo_Empresa` = '" & IUPrincipal.Empresa.ProTipoEmpresa & "',`Int_Sector` = '" & IUPrincipal.Empresa.ProSector & "',`Boo_Orientacion` = '" & IUPrincipal.Empresa.ProOrientacion & "',`Txt_Logo` = '" + IUPrincipal.Empresa.ProLogo + "',`Dte_Fecha_Registro` = '" + IUPrincipal.Empresa.ProFechaRegistro.ToString("yyyy-MM-dd") + "',`Txt_Entidad` = '" + IUPrincipal.Empresa.ProEntidad + "',`Txt_Acta_Constitutiva` = '" + IUPrincipal.Empresa.ProActaConstitutiva + "',`Txt_Tomo` = '" + IUPrincipal.Empresa.ProTomo + "',`Txt_SSO` = '" + IUPrincipal.Empresa.ProSso + "',`Txt_Expediente` = '" + IUPrincipal.Empresa.ProExpediente + "',`Txt_Capital` = '" + IUPrincipal.Empresa.ProCapital + "',`Txt_Acciones` = '" + IUPrincipal.Empresa.ProAcciones + "',`Txt_Valor_Accion` = '" + IUPrincipal.Empresa.ProAcciones + "',`Txt_Inces` = '" + IUPrincipal.Empresa.ProInces + "',`Txt_NIL` = '" + IUPrincipal.Empresa.ProNil + "',`Txt_Codigo_Pago_Nomina` = '" + IUPrincipal.Empresa.ProCodPagoNomina + "',`Int_Tipo_Contribuyente` = '" & IUPrincipal.Empresa.ProTipoContribuyente & "',`Int_Declaracion` = '" & IUPrincipal.Empresa.ProDeclaracion & "',`Txt_Por_Retencion` = '" + IUPrincipal.Empresa.ProPorRetencion + "',`Boo_Agente_Percepcion` = '" & IUPrincipal.Empresa.ProAgentePercepcion & "',`Boo_Agente_Retencion` = '" & IUPrincipal.Empresa.ProAgenteRetencion & "',`Boo_Contribuyente` = '" & IUPrincipal.Empresa.ProContribuyente & "';"
            IUPrincipal.Conexion.Insertar("UPDATE `EMPRESA` set `Txt_Rif` = '" + IUPrincipal.Empresa.ProRif + "',`Int_LRif` = '" & IUPrincipal.Empresa.ProLRif & "',`Txt_Razon_Social` = '" + IUPrincipal.Empresa.ProRazonSocial + "',`Txt_Domicilio` = '" + IUPrincipal.Empresa.ProDomicilio + "',`Txt_Representante` = '" + IUPrincipal.Empresa.ProRepresentante + "',`Txt_Web` = '" + IUPrincipal.Empresa.ProWeb + "',`Int_Pais` = '" & IUPrincipal.Empresa.ProPais & "',`Int_Estado` = '" & IUPrincipal.Empresa.ProEstado & "', `Txt_Municipio` ='" + IUPrincipal.Empresa.ProMunicipio + "', `Txt_Ciudad` = '" + IUPrincipal.Empresa.ProCiudad + "',`Txt_Email` = '" + IUPrincipal.Empresa.ProEmail + "',`Txt_Telefono` = '" + IUPrincipal.Empresa.ProTelefono + "',`Txt_Fax` = '" + IUPrincipal.Empresa.ProFax + "',`Int_Actividad` = '" & IUPrincipal.Empresa.ProActividad & "',`Int_Tipo_Empresa` = '" & IUPrincipal.Empresa.ProTipoEmpresa & "',`Int_Sector` = '" & IUPrincipal.Empresa.ProSector & "',`Boo_Orientacion` = '" & IUPrincipal.Empresa.ProOrientacion & "',`Txt_Logo` = '" + IUPrincipal.Empresa.ProLogo + "',`Dte_Fecha_Registro` = '" + IUPrincipal.Empresa.ProFechaRegistro.ToString("yyyy-MM-dd") + "',`Txt_Entidad` = '" + IUPrincipal.Empresa.ProEntidad + "',`Txt_Acta_Constitutiva` = '" + IUPrincipal.Empresa.ProActaConstitutiva + "',`Txt_Tomo` = '" + IUPrincipal.Empresa.ProTomo + "',`Txt_SSO` = '" + IUPrincipal.Empresa.ProSso + "',`Txt_Expediente` = '" + IUPrincipal.Empresa.ProExpediente + "',`Txt_Capital` = '" + IUPrincipal.Empresa.ProCapital + "',`Txt_Acciones` = '" + IUPrincipal.Empresa.ProAcciones + "',`Txt_Valor_Accion` = '" + IUPrincipal.Empresa.ProAcciones + "',`Txt_Inces` = '" + IUPrincipal.Empresa.ProInces + "',`Txt_NIL` = '" + IUPrincipal.Empresa.ProNil + "',`Txt_Codigo_Pago_Nomina` = '" + IUPrincipal.Empresa.ProCodPagoNomina + "',`Int_Tipo_Contribuyente` = '" & IUPrincipal.Empresa.ProTipoContribuyente & "',`Int_Declaracion` = '" & IUPrincipal.Empresa.ProDeclaracion & "',`Txt_Por_Retencion` = '" + IUPrincipal.Empresa.ProPorRetencion + "',`Boo_Agente_Percepcion` = '" & IUPrincipal.Empresa.ProAgentePercepcion & "',`Boo_Agente_Retencion` = '" & IUPrincipal.Empresa.ProAgenteRetencion & "',`Boo_Contribuyente` = '" & IUPrincipal.Empresa.ProContribuyente & "';")
            'IUPrincipal.Conexion.Insertar("UPDATE `EMPRESA` set `Txt_Rif` = '" + IUPrincipal.Empresa.ProRif + "',`Int_LRif` = '" & IUPrincipal.Empresa.ProLRif & "',`Txt_Razon_Social` = '" + IUPrincipal.Empresa.ProRazonSocial + "',`Txt_Domicilio` = '" + IUPrincipal.Empresa.ProDomicilio + "',`Txt_Representante` = '" + IUPrincipal.Empresa.ProRepresentante + "',`Txt_Web` = '" + IUPrincipal.Empresa.ProWeb + "',`Int_Pais` = '" & IUPrincipal.Empresa.ProPais & "',`Int_Estado` = '" & IUPrincipal.Empresa.ProEstado & "';")
        End If
        '////////////////////////////////////////////////////////
        '////////////////////////////////////////////////////////
    End Sub
    Private Sub CmbEstados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEstados.KeyDown
        If e.KeyValue = 13 Then
            If CmbPaises.Items.Count > 0 Then
                CmbEstados.Items.Add(CmbEstados.Text)
                IUPrincipal.Estado = New ClaseEstados
                IUPrincipal.Estado.ProDescripcion = CmbEstados.Text
                IUPrincipal.Estado.ProFk_Pais = CmbPaises.SelectedIndex
                IUPrincipal.Estados.Add(IUPrincipal.Estado)
                CmbEstados.SelectedIndex = CmbEstados.Items.Count - 1
            Else
                CmbEstados.Text = ""
                MsgBox("No Ha Ingresado Ningun Pais")
            End If
        End If
    End Sub

    Private Sub CmbActividad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbActividad.KeyDown
        If e.KeyValue = 13 Then
            CmbActividad.Items.Add(CmbActividad.Text)
            IUPrincipal.Actividad = New ClaseActividad
            IUPrincipal.Actividad.ProDescripcion = CmbActividad.Text
            IUPrincipal.Actividades.Add(IUPrincipal.Actividad)
            CmbActividad.SelectedIndex = CmbActividad.Items.Count - 1
        End If
    End Sub

    Private Sub CmbTipoEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbTipoEmpresa.KeyDown
        If e.KeyValue = 13 Then
            CmbTipoEmpresa.Items.Add(CmbTipoEmpresa.Text)
            IUPrincipal.TipoEmpresa = New ClaseTipoEmpresa
            IUPrincipal.TipoEmpresa.ProDescripcion = CmbTipoEmpresa.Text
            IUPrincipal.TipoEmpresas.Add(IUPrincipal.TipoEmpresa)
            CmbTipoEmpresa.SelectedIndex = CmbTipoEmpresa.Items.Count - 1
        End If
    End Sub

    Private Sub CmbSector_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSector.KeyDown
        If e.KeyValue = 13 Then
            CmbSector.Items.Add(CmbSector.Text)
            IUPrincipal.Sector = New ClaseSector
            IUPrincipal.Sector.ProDescripcion = CmbSector.Text
            IUPrincipal.Sectores.Add(IUPrincipal.Sector)
            CmbSector.SelectedIndex = CmbSector.Items.Count - 1
        End If
    End Sub

    Private Sub CmbPaises_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPaises.KeyDown
        If e.KeyValue = 13 Then
            CmbPaises.Items.Add(CmbPaises.Text)
            IUPrincipal.Pais = New ClasePais
            IUPrincipal.Pais.ProDescripcion = CmbPaises.Text
            IUPrincipal.Paises.Add(IUPrincipal.Pais)
            CmbPaises.SelectedIndex = CmbPaises.Items.Count - 1
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("INSERT INTO `PAISES` set `Txt_Descripcion` = '" + IUPrincipal.Paises.Item(CmbPaises.Items.Count).ProDescripcion + "';")
            End If
            '////////////////////////////////////////////////////////
            CmbEstados.Items.Clear()
            CmbEstados.Text = ""
        End If
    End Sub

    Private Sub Cargar_Estados()
        Dim i As Integer = 0
        While i < IUPrincipal.Estados.Count
            i = i + 1
            If CmbPaises.SelectedIndex = IUPrincipal.Estados.Item(i).ProFk_Pais Then
                CmbEstados.Items.Add(IUPrincipal.Estados.Item(i).ProDescripcion)
            End If
        End While
        If CmbEstados.Items.Count > 0 Then
            CmbEstados.SelectedIndex = 0
        End If
    End Sub
    Private Sub CmbPaises_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPaises.SelectedIndexChanged
        CmbEstados.Items.Clear()
        CmbEstados.Text = ""
        Cargar_Estados()
    End Sub

    Private Sub CmbActividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbActividad.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

    End Sub
End Class
