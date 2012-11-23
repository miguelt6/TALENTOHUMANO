Public Class EMPFRM001
    Private Sub Cargar_Paises()
        Dim i As Integer = 0
        While i < PRIFRM001.Paises.Count
            i = i + 1
            CmbPaises.Items.Add(PRIFRM001.Paises.Item(i).ProDescripcion)
            CmbPais.Items.Add(PRIFRM001.Paises.Item(i).ProDescripcion)
        End While
    End Sub
    Private Sub Cargar_TipoEmpresas()
        Dim i As Integer = 0
        While i < PRIFRM001.TipoEmpresas.Count
            i = i + 1
            CmbTipoEmpresa.Items.Add(PRIFRM001.TipoEmpresas.Item(i).ProDescripcion)
        End While
    End Sub
    Private Sub Cargar_Actividades()
        Dim i As Integer = 0
        While i < PRIFRM001.Actividades.Count
            i = i + 1
            CmbActividad.Items.Add(PRIFRM001.Actividades.Item(i).ProDescripcion)
        End While
    End Sub
    Private Sub Cargar_Sector()
        Dim i As Integer = 0
        While i < PRIFRM001.Sectores.Count
            i = i + 1
            CmbSector.Items.Add(PRIFRM001.Sectores.Item(i).ProDescripcion)
        End While
    End Sub

    Private Sub EMPFRM001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Paises()
        Cargar_Actividades()
        Cargar_TipoEmpresas()
        Cargar_Sector()
        Cargar_Sucursales()
        TxtCiudades.Text = PRIFRM001.Empresa.ProCiudad
        TxtDomicilio.Text = PRIFRM001.Empresa.ProDomicilio
        TxtMunicipio.Text = PRIFRM001.Empresa.ProMunicipio
        If PRIFRM001.Contratos.Count > 0 Then
            LblNumEmp.Text = PRIFRM001.Contratos.Count
        End If
        If CmbPaises.Items.Count > 0 Then
            CmbPaises.SelectedIndex = PRIFRM001.Empresa.ProPais
        End If
        If CmbEstados.Items.Count > 0 Then
            CmbEstados.SelectedIndex = PRIFRM001.Empresa.ProEstado
        End If
        TxtRazonSocial.Text = PRIFRM001.Empresa.ProRazonSocial
        TxtRepresentante.Text = PRIFRM001.Empresa.ProRepresentante
        TxtRif.Text = PRIFRM001.Empresa.ProRif
        If CmbRif.Items.Count > 0 Then
            CmbRif.SelectedIndex = PRIFRM001.Empresa.ProLRif
        End If
        TxtTelefono.Text = PRIFRM001.Empresa.ProTelefono
        If CmbActividad.Items.Count > 0 Then
            CmbActividad.SelectedIndex = PRIFRM001.Empresa.ProActividad
        End If
        TxtEmail.Text = PRIFRM001.Empresa.ProEmail
        TxtFax.Text = PRIFRM001.Empresa.ProFax
        OfdLogo.FileName = PRIFRM001.Empresa.ProLogo
        PbxLogo.ImageLocation = OfdLogo.FileName
        RbnHorizontal.Checked = PRIFRM001.Empresa.ProOrientacion
        If CmbSector.Items.Count > 0 Then
            CmbSector.SelectedIndex = PRIFRM001.Empresa.ProSector
        End If
        If CmbTipoEmpresa.Items.Count > 0 Then
            CmbTipoEmpresa.SelectedIndex = PRIFRM001.Empresa.ProTipoEmpresa
        End If
        TxtWeb.Text = PRIFRM001.Empresa.ProWeb
        TxtAcciones.Text = PRIFRM001.Empresa.ProAcciones
        TxtActa.Text = PRIFRM001.Empresa.ProActaConstitutiva
        RbnSi.Checked = PRIFRM001.Empresa.ProAgentePercepcion
        RbnRetSi.Checked = PRIFRM001.Empresa.ProAgenteRetencion
        TxtCapital.Text = PRIFRM001.Empresa.ProCapital
        TxtPagoNomina.Text = PRIFRM001.Empresa.ProCodPagoNomina
        RbnEspecialSi.Checked = PRIFRM001.Empresa.ProContribuyente
        CmbDeclaracion.SelectedIndex = PRIFRM001.Empresa.ProDeclaracion
        TxtEntidad.Text = PRIFRM001.Empresa.ProEntidad
        TxtExpediente.Text = PRIFRM001.Empresa.ProExpediente
        'If PRIFRM001.Empresa.Profrecharegistro = "" Then
        'DteFechaRegistro.Value = PRIFRM001.Empresa.ProFechaRegistro
        'End If
        TxtInces.Text = PRIFRM001.Empresa.ProInces
        TxtNil.Text = PRIFRM001.Empresa.ProNil
        TxtPorRetencion.Text = PRIFRM001.Empresa.ProPorRetencion
        TxtSso.Text = PRIFRM001.Empresa.ProSso
        CmbTipoContribuyente.SelectedIndex = PRIFRM001.Empresa.ProTipoContribuyente
        TxtTomo.Text = PRIFRM001.Empresa.ProTomo
        TxtValor.Text = PRIFRM001.Empresa.ProValorAccion
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

    Private Sub Cargar_Sucursales()
        Dim i As Integer = 0
        While i < PRIFRM001.Sucursales.Count
            i = i + 1
            TrvSucursales.Nodes(0).Nodes.Add(PRIFRM001.Sucursales.Item(i).ProNombre)
        End While
        TrvSucursales.Nodes(0).ExpandAll()
    End Sub
    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        TrvSucursales.Nodes(0).Nodes.Add("Nueva Sucursal")
        TrvSucursales.Nodes(0).ExpandAll()
        PRIFRM001.Sucursal = New ClaseSucursal
        PRIFRM001.Sucursal.ProNombre = "Nueva Sucursal"
        PRIFRM001.Sucursales.Add(PRIFRM001.Sucursal)
    End Sub

    Private Sub TrvSucursales_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TrvSucursales.AfterSelect
        If TrvSucursales.SelectedNode.Level <> 0 Then
            BtnEditar.Enabled = True
            If PRIFRM001.Sucursales.Count > 0 Then
                PRIFRM001.Sucursal = PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1)
                TxtNombre.Text = PRIFRM001.Sucursal.ProNombre
                TxtDireccion.Text = PRIFRM001.Sucursal.ProDireccion
                TxtGerente.Text = PRIFRM001.Sucursal.ProGerente
                TxtTelefono.Text = PRIFRM001.Sucursal.ProTelefono
                TxtCiudad.Text = PRIFRM001.Sucursal.ProCiudad
                If PRIFRM001.Paises.Count > 0 Then
                    CmbPais.Items.Clear()
                    Cargar_Paises()
                End If
                If CmbPais.Items.Count > 0 Then
                    CmbPais.SelectedIndex = PRIFRM001.Sucursal.ProPais
                End If
                If CmbEstado.Items.Count > 0 Then
                    CmbEstado.SelectedIndex = PRIFRM001.Sucursal.ProEstado
                End If
            Else
                TxtNombre.Text = TrvSucursales.SelectedNode.Text
            End If
        End If
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        TrvSucursales.SelectedNode.Text = TxtNombre.Text
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).Pronombre = TxtNombre.Text
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).ProDireccion = TxtDireccion.Text
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).ProGerente = TxtGerente.Text
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).ProTelefono = TxtTelefono.Text
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).ProPais = CmbPais.SelectedIndex
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).ProEstado = CmbEstado.SelectedIndex
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).ProCiudad = TxtCiudad.Text
        PRIFRM001.Sucursales.Item(TrvSucursales.SelectedNode.Index + 1).ProMunicipio = TxtMunicipio.Text

        TxtNombre.Text = ""
        TxtDireccion.Text = ""
        TxtGerente.Text = ""
        TxtTelefono.Text = ""
        TxtCiudad.Text = ""
        TxtNombre.Enabled = False
        TxtDireccion.Enabled = False
        TxtGerente.Enabled = False
        TxtTelefono.Enabled = False
        TxtMunicipio.Enabled = False
        CmbPais.Enabled = False
        CmbEstado.Enabled = False
        TxtMunicipios.Enabled = False
        TxtCiudad.Enabled = False
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtNombre.Text = ""
        TxtDireccion.Text = ""
        TxtGerente.Text = ""
        TxtTelefono.Text = ""
        TxtCiudad.Text = ""
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        BtnCancelar.Enabled = True
        BtnGrabar.Enabled = True
        TxtNombre.Enabled = True
        TxtDireccion.Enabled = True
        TxtGerente.Enabled = True
        TxtMunicipio.Enabled = True
        TxtTelefono.Enabled = True
        CmbPais.Enabled = True
        CmbEstado.Enabled = True
        TxtCiudad.Enabled = True
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        GbxDatosLegales.Enabled = True
        GbxDatosContribuyente.Enabled = True
        TxtRazonSocial.Enabled = True
        TrvSucursales.Enabled = True
        GbxSucursal.Enabled = True
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
        GbxSucursal.Enabled = False
        TrvSucursales.Enabled = False
        PRIFRM001.Empresa.ProCiudad = TxtCiudades.Text
        PRIFRM001.Empresa.ProDomicilio = TxtDomicilio.Text
        PRIFRM001.Empresa.ProEstado = CmbEstados.SelectedIndex
        PRIFRM001.Empresa.ProMunicipio = TxtMunicipio.Text
        PRIFRM001.Empresa.ProPais = CmbPaises.SelectedIndex
        PRIFRM001.Empresa.ProRazonSocial = TxtRazonSocial.Text
        PRIFRM001.Empresa.ProRepresentante = TxtRepresentante.Text
        PRIFRM001.Empresa.ProRif = TxtRif.Text
        PRIFRM001.Empresa.ProLRif = CmbRif.SelectedIndex
        PRIFRM001.Empresa.ProTelefono = TxtTelefono.Text
        PRIFRM001.Empresa.ProActividad = CmbActividad.SelectedIndex
        PRIFRM001.Empresa.ProEmail = TxtEmail.Text
        PRIFRM001.Empresa.ProFax = TxtFax.Text
        PRIFRM001.Empresa.ProLogo = OfdLogo.FileName
        PRIFRM001.Empresa.ProOrientacion = RbnHorizontal.Checked
        PRIFRM001.Empresa.ProSector = CmbSector.SelectedIndex
        PRIFRM001.Empresa.ProTipoEmpresa = CmbTipoEmpresa.SelectedIndex
        PRIFRM001.Empresa.ProWeb = TxtWeb.Text
        PRIFRM001.Empresa.ProAcciones = TxtAcciones.Text
        PRIFRM001.Empresa.ProActaConstitutiva = TxtActa.Text
        PRIFRM001.Empresa.ProAgentePercepcion = RbnSi.Checked
        PRIFRM001.Empresa.ProAgenteRetencion = RbnRetSi.Checked
        PRIFRM001.Empresa.ProCapital = TxtCapital.Text
        PRIFRM001.Empresa.ProCodPagoNomina = TxtPagoNomina.Text
        PRIFRM001.Empresa.ProContribuyente = RbnEspecialSi.Checked
        PRIFRM001.Empresa.ProDeclaracion = CmbDeclaracion.SelectedIndex
        PRIFRM001.Empresa.ProEntidad = TxtEntidad.Text
        PRIFRM001.Empresa.ProExpediente = TxtExpediente.Text
        PRIFRM001.Empresa.ProFechaRegistro = DteFechaRegistro.Value
        PRIFRM001.Empresa.ProInces = TxtInces.Text
        PRIFRM001.Empresa.ProNil = TxtNil.Text
        PRIFRM001.Empresa.ProPorRetencion = TxtPorRetencion.Text
        PRIFRM001.Empresa.ProSso = TxtSso.Text
        PRIFRM001.Empresa.ProTipoContribuyente = CmbTipoContribuyente.SelectedIndex
        PRIFRM001.Empresa.ProTomo = TxtTomo.Text
        PRIFRM001.Empresa.ProValorAccion = TxtValor.Text
    End Sub
    Private Sub CmbEstados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEstados.KeyDown
        If e.KeyValue = 13 Then
            If CmbPaises.Items.Count > 0 Then
                CmbEstados.Items.Add(CmbEstados.Text)
                PRIFRM001.Estado = New ClaseEstados
                PRIFRM001.Estado.ProDescripcion = CmbEstados.Text
                PRIFRM001.Estado.ProFk_Pais = CmbPaises.SelectedIndex
                PRIFRM001.Estados.Add(PRIFRM001.Estado)
            Else
                CmbEstados.Text = ""
                MsgBox("No Ha Ingresado Ningun Pais")
            End If            
        End If
    End Sub

    Private Sub CmbActividad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbActividad.KeyDown
        If e.KeyValue = 13 Then
            CmbActividad.Items.Add(CmbActividad.Text)
            PRIFRM001.Actividad = New ClaseActividad
            PRIFRM001.Actividad.ProDescripcion = CmbActividad.Text
            PRIFRM001.Actividades.Add(PRIFRM001.Actividad)
        End If
    End Sub

    Private Sub CmbTipoEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbTipoEmpresa.KeyDown
        If e.KeyValue = 13 Then
            CmbTipoEmpresa.Items.Add(CmbTipoEmpresa.Text)
            PRIFRM001.TipoEmpresa = New ClaseTipoEmpresa
            PRIFRM001.TipoEmpresa.ProDescripcion = CmbTipoEmpresa.Text
            PRIFRM001.TipoEmpresas.Add(PRIFRM001.TipoEmpresa)
        End If
    End Sub

    Private Sub CmbSector_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSector.KeyDown
        If e.KeyValue = 13 Then
            CmbSector.Items.Add(CmbSector.Text)
            PRIFRM001.Sector = New ClaseSector
            PRIFRM001.Sector.ProDescripcion = CmbSector.Text
            PRIFRM001.Sectores.Add(PRIFRM001.Sector)
        End If
    End Sub

    Private Sub CmbPaises_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPaises.KeyDown
        If e.KeyValue = 13 Then
            CmbPaises.Items.Add(CmbPaises.Text)
            PRIFRM001.Pais = New ClasePais
            PRIFRM001.Pais.ProDescripcion = CmbPaises.Text
            PRIFRM001.Paises.Add(PRIFRM001.Pais)
            CmbPaises.SelectedIndex = CmbPaises.Items.Count - 1
            CmbEstados.Items.Clear()
            CmbEstados.Text = ""
        End If
    End Sub

    Private Sub CmbPais_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPais.KeyDown
        If e.KeyValue = 13 Then
            CmbPais.Items.Add(CmbPais.Text)
            PRIFRM001.Pais = New ClasePais
            PRIFRM001.Pais.ProDescripcion = CmbPais.Text
            PRIFRM001.Paises.Add(PRIFRM001.Pais)
            CmbPais.SelectedIndex = CmbPais.Items.Count - 1
            CmbEstados.Items.Clear()
            CmbEstados.Text = ""
        End If
    End Sub

    Private Sub CmbEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEstado.KeyDown
        If e.KeyValue = 13 Then
            If CmbPais.Items.Count > 0 Then
                CmbEstado.Items.Add(CmbEstado.Text)
                PRIFRM001.Estado = New ClaseEstados
                PRIFRM001.Estado.ProDescripcion = CmbEstado.Text
                PRIFRM001.Estado.ProFk_Pais = CmbPais.SelectedIndex
                PRIFRM001.Estados.Add(PRIFRM001.Estado)
            Else
                CmbEstado.Text = ""
                MsgBox("No Ha Ingresado Ningun Pais")
            End If
        End If
    End Sub
    Private Sub Cargar_Estados()
        Dim i As Integer = 0
        While i < PRIFRM001.Estados.Count
            i = i + 1
            If CmbPaises.SelectedIndex = PRIFRM001.Estados.Item(i).ProFk_Pais Then
                CmbEstados.Items.Add(PRIFRM001.Estados.Item(i).ProDescripcion)
            End If
        End While
        If CmbEstados.Items.Count > 0 Then
            CmbEstados.SelectedIndex = 0
        End If
    End Sub
    Private Sub Cargar_Estados_Sucursales()
        Dim i As Integer = 0
        While i < PRIFRM001.Estados.Count
            i = i + 1
            If CmbPais.SelectedIndex = PRIFRM001.Estados.Item(i).ProFk_Pais Then
                CmbEstado.Items.Add(PRIFRM001.Estados.Item(i).ProDescripcion)
            End If
        End While
        If CmbEstado.Items.Count > 0 Then
            CmbEstado.SelectedIndex = 0
        End If
    End Sub
    Private Sub CmbPaises_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPaises.SelectedIndexChanged
        CmbEstados.Items.Clear()
        CmbEstados.Text = ""
        Cargar_Estados()
    End Sub

    Private Sub CmbPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPais.SelectedIndexChanged
        CmbEstado.Items.Clear()
        CmbEstado.Text = ""
        Cargar_Estados_Sucursales()
    End Sub
End Class
