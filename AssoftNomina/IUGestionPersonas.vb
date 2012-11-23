Imports System.Globalization
Public Class IUGestionPersonas
    Dim PanelMostrado As Boolean = False
    Dim PosicionActual As Integer = 0
    Dim EstadoFormulario As String = "Leyendo"
    Dim EstadoCargaFamiliares As String = "Agregando"
    Dim EstadoCargaTitulos As String = "Agregando"
    Dim EstadoModificado As Boolean = False
    Dim bConexionExitosa As Boolean
    Dim dr As System.Data.IDataReader
    Public Conexion As ClaseBaseDatos
    Dim fechapre As Date
    Dim statusg As Integer

    Private Sub TlsBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnNuevo.Click
        GbxDatosPersonales.Enabled = True
        TxtCedula.Text = ""
        TxtCedula.Focus()
        TxtRif.Text = ""
        TxtApellido.Text = ""
        TxtNombre.Text = ""
        CmbEdoCivil.SelectedIndex = 0
        DteFechaNacimiento.Value = Today
        TxtLugarNacimiento.Text = ""
        CmbSexo.SelectedIndex = 0
        PbxFoto.ImageLocation = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1) + "\nofoto.jpg"
        TxtDireccion.Text = ""
        TxtPuntoReferencia.Text = ""
        TxtTelefono.Text = ""
        TxtTelefonoMovil.Text = ""
        TxtCorreoElectronico.Text = ""
        TxtNombreContacto.Text = ""
        TxtDescripcion.Text = ""
        TxtTelefonoContacto.Text = ""
        TxtTelefonoMovilContacto.Text = ""
        TxtGrupoSanguineo.Text = ""
        TxtAltura.Text = ""
        TxtTallaCalzado.Text = ""
        TxtTallaPantalon.Text = ""
        TxtTallaCamisa.Text = ""
        TxtPeso.Text = ""
        TxtHabilidades.Text = ""
        RbtnCertificadoSi.Checked = False
        If IUPrincipal.Profesiones.Count > 0 Then
            CmbProfesion.SelectedIndex = 0
        End If
        If IUPrincipal.Bancos.Count > 0 Then
            CmbBanco.SelectedIndex = 0
        End If
        TxtCuentaBancaria.Text = ""
        PanelCuenta.Enabled = False
        RbtnCuentaNo.Checked = True
        RbtnLentesSi.Checked = False
        RbtnLentesNo.Checked = False
        RbtnFumaSi.Checked = False
        RbtnFumaNo.Checked = False
        RbtnOperacionesSi.Checked = False
        RbtnOperacionesNo.Checked = False
        RbtnIncapacitadoSi.Checked = False
        RbtnIncapacitadoNo.Checked = False
        TxtAlergias.Text = ""
        TxtEnfermedades.Text = ""
        PanelDatosFisicos.Enabled = True       
        PanelUbicacion.Enabled = True
        PanelPersonaContacto.Enabled = True
        PanelFamiliares.Enabled = True
        PanelExperiencia.Enabled = True
        PanelTitulos.Enabled = True
        PanelLaborales.Enabled = True
        BarraNavegacion.Enabled = False
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
        TlsBtnModificar.Enabled = False
        TlsBtnBuscar.Enabled = False
        TlsBtnContrato.Enabled = False
        CmbCedula.Enabled = True
        TxtCedula.Enabled = True
        ChkRif.Enabled = True
        DGridFamiliares.Rows.Clear()
        DgridAcademico.Rows.Clear()
        EstadoFormulario = "Agregando"
        Limpiar_DatosLaborales()
    End Sub

    Private Sub TlsBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnModificar.Click
        GbxDatosPersonales.Enabled = True
        TbcOtrosDatos.Enabled = True
        PanelDatosFisicos.Enabled = True
        PanelUbicacion.Enabled = True
        PanelPersonaContacto.Enabled = True
        PanelFamiliares.Enabled = True
        PanelExperiencia.Enabled = True
        PanelTitulos.Enabled = True
        PanelLaborales.Enabled = True
        BarraNavegacion.Enabled = False
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
        TlsBtnContrato.Enabled = False
        CmbCedula.Enabled = False
        TxtCedula.Enabled = False
        TxtRif.Enabled = False
        ChkRif.Enabled = False
        EstadoFormulario = "Modificando"
    End Sub
    Private Sub Cargar_Familiares()
        Dim i As Integer
        DGridFamiliares.Rows.Clear()
        While i < IUPrincipal.Familiares.Count
            i = i + 1
            If IUPrincipal.Familiares.Item(i).ProFk_Cedula = TxtCedula.Text Then
                DGridFamiliares.Rows.Add()
                DGridFamiliares.Item(0, DGridFamiliares.RowCount - 1).Value = CmbParentesco.Items.Item(IUPrincipal.Familiares.Item(i).ProParentesco)
                DGridFamiliares.Item(1, DGridFamiliares.RowCount - 1).Value = IUPrincipal.Familiares.Item(i).ProNombre
                DGridFamiliares.Item(2, DGridFamiliares.RowCount - 1).Value = i
            End If
        End While
    End Sub
  
    Private Sub Cargar_Titulos2()
        Dim i As Integer = 0

        DgridAcademico.Rows.Clear()
        While i < IUPrincipal.Titulos.Count
            i = i + 1

            If IUPrincipal.Titulos.Item(i).Propersona = TxtCedula.Text Then
                DgridAcademico.Rows.Add()
                DgridAcademico.Item(0, DgridAcademico.RowCount - 1).Value = CmbTitulos.Items(IUPrincipal.Titulos.Item(i).Proidtitulo - 1).ToString
                DgridAcademico.Item(1, DgridAcademico.RowCount - 1).Value = IUPrincipal.Titulos.Item(i).ProInstitucion
                DgridAcademico.Item(2, DgridAcademico.RowCount - 1).Value = IUPrincipal.Titulos.Item(i).ProFecha
                DgridAcademico.Item(3, DgridAcademico.RowCount - 1).Value = i
                DgridAcademico.Item(4, DgridAcademico.RowCount - 1).Value = IUPrincipal.Titulos.Item(i).Proidtitulo
            End If
        End While
    End Sub

    Private Sub MostrarPersona(ByVal Posicion As Integer)
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `personas_temp` where `Num_Identificador` = '" & Posicion & "' ; ")
            'dr.Read()
            While dr.Read()
                TxtCedula.Text = dr(1)
                Buscar_Contrato(TxtCedula.Text)
                If dr(2) <> "" Then
                    ChkRif.Checked = True
                End If
                LblCodigo.Text = dr(0)
                TxtRif.Text = dr(2).ToString
                TxtApellido.Text = dr(4).ToString
                TxtNombre.Text = dr(3).ToString
                CmbEdoCivil.SelectedIndex = dr(8)
                DteFechaNacimiento.Value = dr(5)
                TxtLugarNacimiento.Text = dr(6).ToString
                CmbSexo.SelectedIndex = dr(7) + 1
                PbxFoto.ImageLocation = dr(9).ToString
                TxtAlergias.Text = dr(29).ToString
                TxtAltura.Text = dr(20).ToString

                TxtCorreoElectronico.Text = dr(14).ToString
                TxtDescripcion.Text = dr(15).ToString
                TxtDireccion.Text = dr(10).ToString
                TxtEnfermedades.Text = dr(30).ToString
                RbtnFumaSi.Checked = dr(26)
                RbtnFumaNo.Checked = Not dr(26)
                TxtGrupoSanguineo.Text = dr(19).ToString
                RbtnIncapacitadoSi.Checked = dr(28)
                RbtnIncapacitadoNo.Checked = Not dr(28)
                RbtnLentesSi.Checked = dr(25)
                RbtnLentesNo.Checked = Not dr(25)
                TxtNombreContacto.Text = dr(15).ToString
                RbtnOperacionesSi.Checked = dr(27)
                RbtnOperacionesNo.Checked = Not dr(27)
                TxtPeso.Text = dr(21).ToString
                TxtPuntoReferencia.Text = dr(11).ToString
                TxtTallaCalzado.Text = dr(23).ToString
                TxtTallaCamisa.Text = dr(24).ToString

                TxtTallaPantalon.Text = dr(22).ToString
                TxtTelefonoContacto.Text = dr(17).ToString
                TxtTelefono.Text = dr(12).ToString
                TxtTelefonoMovil.Text = dr(13).ToString
                TxtTelefonoMovilContacto.Text = dr(18).ToString
                LblEstatus.Text = dr(31).ToString
                RbtnCertificadoSi.Checked = dr(34)
                RbtnCertificadoNo.Checked = Not dr(34)
                TxtHabilidades.Text = dr(36).ToString

                fechapre = dr(39).ToString
                statusg = dr(31)

                If IUPrincipal.Profesiones.Count > 0 Then
                    CmbProfesion.SelectedIndex = dr(35)
                End If
                If IUPrincipal.Bancos.Count > 0 Then
                    CmbBanco.SelectedIndex = dr(32)
                End If
                TxtCuentaBancaria.Text = dr(33)
                If dr(31) = 4 Or dr(31) = 5 Or dr(31) = 6 Or dr(31) = 7 Then
                    PanelCuenta.Enabled = True
                    If TxtCuentaBancaria.Text <> "" Then
                        RbtnCuentaSi.Checked = True
                        CmbBanco.Enabled = True
                        TxtCuentaBancaria.Enabled = True
                    End If
                Else
                    RbtnCuentaNo.Checked = True
                    PanelCuenta.Enabled = False
                    CmbBanco.Enabled = False
                    TxtCuentaBancaria.Enabled = False
                End If
                If CmbProfesion.Items.Count > 0 Then
                    CmbProfesion.SelectedIndex = dr(35)
                End If
                If CmbBanco.Items.Count > 0 Then
                    CmbBanco.SelectedIndex = dr(32)
                End If
            End While
        End If
        Conexion.Cerrar_Conexion()

        'TxtCedula.Text = IUPrincipal.Personas.Item(Posicion).ProCedula
        'Buscar_Contrato(TxtCedula.Text)
        'If IUPrincipal.Personas.Item(Posicion).ProRif <> "" Then
        '    ChkRif.Checked = True
        'End If
        'LblCodigo.Text = IUPrincipal.Personas.Item(Posicion).ProCodigo
        'TxtRif.Text = IUPrincipal.Personas.Item(Posicion).ProRif
        'TxtApellido.Text = IUPrincipal.Personas.Item(Posicion).ProApellidos
        'TxtNombre.Text = IUPrincipal.Personas.Item(Posicion).ProNombres
        'CmbEdoCivil.SelectedIndex = IUPrincipal.Personas.Item(Posicion).ProEdoCivil
        'DteFechaNacimiento.Value = IUPrincipal.Personas.Item(Posicion).ProFechaNacimiento
        'TxtLugarNacimiento.Text = IUPrincipal.Personas.Item(Posicion).ProLugarNacimiento
        'CmbSexo.SelectedIndex = IUPrincipal.Personas.Item(Posicion).ProSexo + 1
        'PbxFoto.ImageLocation = IUPrincipal.Personas.Item(Posicion).ProFoto
        'TxtAlergias.Text = IUPrincipal.Personas.Item(Posicion).ProAlergias
        'TxtAltura.Text = IUPrincipal.Personas.Item(Posicion).ProAltura

        'TxtCorreoElectronico.Text = IUPrincipal.Personas.Item(Posicion).ProCorreoElectronico
        'TxtDescripcion.Text = IUPrincipal.Personas.Item(Posicion).ProDescripcionContacto
        'TxtDireccion.Text = IUPrincipal.Personas.Item(Posicion).ProDireccion
        'TxtEnfermedades.Text = IUPrincipal.Personas.Item(Posicion).ProEnfermedades
        'RbtnFumaSi.Checked = IUPrincipal.Personas.Item(Posicion).ProFuma
        'RbtnFumaNo.Checked = Not IUPrincipal.Personas.Item(Posicion).ProFuma
        'TxtGrupoSanguineo.Text = IUPrincipal.Personas.Item(Posicion).ProGrupoSanguineo
        'RbtnIncapacitadoSi.Checked = IUPrincipal.Personas.Item(Posicion).ProIncapacitado
        'RbtnIncapacitadoNo.Checked = Not IUPrincipal.Personas.Item(Posicion).ProIncapacitado
        'RbtnLentesSi.Checked = IUPrincipal.Personas.Item(Posicion).ProLentes
        'RbtnLentesNo.Checked = Not IUPrincipal.Personas.Item(Posicion).ProLentes
        'TxtNombreContacto.Text = IUPrincipal.Personas.Item(Posicion).ProNombreContacto
        'RbtnOperacionesSi.Checked = IUPrincipal.Personas.Item(Posicion).ProOperaciones
        'RbtnOperacionesNo.Checked = Not IUPrincipal.Personas.Item(Posicion).ProOperaciones
        'TxtPeso.Text = IUPrincipal.Personas.Item(Posicion).ProPeso
        'TxtPuntoReferencia.Text = IUPrincipal.Personas.Item(Posicion).ProPuntoReferencia
        'TxtTallaCalzado.Text = IUPrincipal.Personas.Item(Posicion).ProTallaCalzado
        'TxtTallaCamisa.Text = IUPrincipal.Personas.Item(Posicion).ProTallaCamisa

        'TxtTallaPantalon.Text = IUPrincipal.Personas.Item(Posicion).ProTallaPantalon
        'TxtTelefonoContacto.Text = IUPrincipal.Personas.Item(Posicion).ProTelefonoContacto
        'TxtTelefono.Text = IUPrincipal.Personas.Item(Posicion).ProTelefonoHabitacion
        'TxtTelefonoMovil.Text = IUPrincipal.Personas.Item(Posicion).ProTelefonoMovil
        'TxtTelefonoMovilContacto.Text = IUPrincipal.Personas.Item(Posicion).ProTelefonoMovilContacto
        'LblEstatus.Text = IUPrincipal.Personas.Item(Posicion).ProEstatus
        'RbtnCertificadoSi.Checked = IUPrincipal.Personas.Item(Posicion).ProCertificado
        'RbtnCertificadoNo.Checked = Not IUPrincipal.Personas.Item(Posicion).ProCertificado
        'TxtHabilidades.Text = IUPrincipal.Personas.Item(Posicion).ProHabilidades
        'If IUPrincipal.Profesiones.Count > 0 Then
        '    CmbProfesion.SelectedIndex = IUPrincipal.Personas.Item(Posicion).ProProfesion
        'End If
        'If IUPrincipal.Bancos.Count > 0 Then
        '    CmbBanco.SelectedIndex = IUPrincipal.Personas.Item(Posicion).ProBanco
        'End If
        'TxtCuentaBancaria.Text = IUPrincipal.Personas.Item(Posicion).ProCuentaBancaria
        'If LblEstatus.Text = "Empleado" Then
        '    PanelCuenta.Enabled = True
        '    If TxtCuentaBancaria.Text <> "" Then
        '        RbtnCuentaSi.Checked = True
        '        CmbBanco.Enabled = True
        '        TxtCuentaBancaria.Enabled = True
        '    End If
        'ElseIf LblEstatus.Text = "Aspirante" Then
        '    RbtnCuentaNo.Checked = True
        '    PanelCuenta.Enabled = False
        '    CmbBanco.Enabled = False
        '    TxtCuentaBancaria.Enabled = False
        'End If
        'If CmbProfesion.Items.Count > 0 Then
        '    CmbProfesion.SelectedIndex = IUPrincipal.Personas.Item(Posicion).ProProfesion
        'End If
        'If CmbBanco.Items.Count > 0 Then
        '    CmbBanco.SelectedIndex = IUPrincipal.Personas.Item(Posicion).ProBanco
        'End If
        Cargar_Familiares()
        Cargar_Titulos()
        Cargar_Titulos2()
        PosicionActual = Posicion
        TxtPosicion.Text = Posicion
        LabelElementos.Text = "de {" & IUPrincipal.Personas.Count & "}"
        TlsLblEstado.Text = "Leyendo..."
    End Sub
    Private Function RevisarEstado() As Integer
        Dim Resultado As Integer = 0
        If EstadoModificado Then
            Resultado = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.ApplicationModal, "Departamentos")
        End If
        Return Resultado
    End Function
    Private Sub TlsBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnCancelar.Click
        Dim Resultado As Integer
        Resultado = RevisarEstado()
        If Resultado = MsgBoxResult.Yes Then
            TlsLblEstado.Text = "Guardando..."
            Validacion()
            Exit Sub
        End If
        If Resultado = MsgBoxResult.No Or Resultado = 0 Then
            TlsLblEstado.Text = "Cancelando..."
            EstadoLeyendo()
            If IUPrincipal.Personas.Count > 0 Then
                MostrarPersona(1)
            End If
        End If
    End Sub

    Private Sub EstadoLeyendo()
        TlsBtnNuevo.Enabled = True
        If IUPrincipal.Personas.Count > 0 Then
            TlsBtnModificar.Enabled = True
            TlsBtnBuscar.Enabled = True
            TlsBtnContrato.Enabled = True
            BarraNavegacion.Enabled = True
        End If
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False
        GbxDatosPersonales.Enabled = False
        PanelDatosFisicos.Enabled = False
        PanelUbicacion.Enabled = False
        PanelPersonaContacto.Enabled = False
        PanelFamiliares.Enabled = False
        PanelExperiencia.Enabled = False
        PanelTitulos.Enabled = False
        PanelLaborales.Enabled = False
        EstadoFormulario = "Leyendo"
        EstadoModificado = False        
    End Sub
    Private Sub Validacion()
        If TxtCedula.Text = "" Then
            MsgBox("Falta Ingresar la Cedula del Empleado", MsgBoxStyle.Exclamation)
            TxtCedula.Focus()
            Exit Sub
        End If
        If TxtNombre.Text = "" Then
            MsgBox("Falta Ingresar el Nombre del Empleado", MsgBoxStyle.Exclamation)
            TxtNombre.Focus()
            Exit Sub
        End If
        If TxtApellido.Text = "" Then
            MsgBox("Falta Ingresar el Apellido del Empleado", MsgBoxStyle.Exclamation)
            TxtApellido.Focus()
            Exit Sub
        End If
        If CInt(LblEdad.Text) < 14 Then
            MsgBox("Debe ingresar una fecha de nacimiento válida", MsgBoxStyle.Exclamation)
            DteFechaNacimiento.Focus()
            Exit Sub
        End If
        If CmbEdoCivil.SelectedItem = "" Then
            MsgBox("Falta Ingresar el Estado Civil del Empleado", MsgBoxStyle.Exclamation)
            CmbEdoCivil.Focus()
            Exit Sub
        End If
        If CmbSexo.SelectedItem = "" Then
            MsgBox("Falta Ingresar el Sexo del Empleado", MsgBoxStyle.Exclamation)
            CmbSexo.Focus()
            Exit Sub
        End If
        If TxtTelefono.Text = "" And TxtTelefonoMovil.Text = "" Then
            MsgBox("Debe ingresar un número de teléfono de contacto", MsgBoxStyle.Exclamation)
            TxtTelefono.Focus()
            Exit Sub
        End If

        If TxtAltura.Text = "" Then TxtAltura.Text = "0"
        If TxtPeso.Text = "" Then TxtPeso.Text = "0"
        If TxtTallaPantalon.Text = "" Then TxtTallaPantalon.Text = "0"
        If TxtTallaCalzado.Text = "" Then TxtTallaCalzado.Text = "0"
        Guardar()
        EstadoLeyendo()
    End Sub
    Private Sub Guardar()
        If EstadoFormulario = "Agregando" Then
            'IUPrincipal.Persona = New ClasePersona
            'IUPrincipal.Persona.ProCedula = TxtCedula.Text
            'IUPrincipal.Persona.ProRif = TxtRif.Text
            'IUPrincipal.Persona.ProApellidos = TxtApellido.Text
            'IUPrincipal.Persona.ProNombres = TxtNombre.Text
            'IUPrincipal.Persona.ProEdoCivil = CmbEdoCivil.SelectedIndex - 1
            'IUPrincipal.Persona.ProFechaNacimiento = DteFechaNacimiento.Value
            'IUPrincipal.Persona.ProLugarNacimiento = TxtLugarNacimiento.Text
            'IUPrincipal.Persona.ProSexo = CmbSexo.SelectedIndex - 1
            'PbxFoto.Image.Save(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1) + "\" + TxtCedula.Text + ".jpg")
            'IUPrincipal.Persona.ProFoto = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1) + "\" + TxtCedula.Text + ".jpg"
            'IUPrincipal.Persona.ProAlergias = TxtAlergias.Text
            'IUPrincipal.Persona.ProAltura = TxtAltura.Text
            'IUPrincipal.Persona.ProCorreoElectronico = TxtCorreoElectronico.Text
            'IUPrincipal.Persona.ProDescripcionContacto = TxtDescripcion.Text
            'IUPrincipal.Persona.ProDireccion = TxtDireccion.Text
            'IUPrincipal.Persona.ProEnfermedades = TxtEnfermedades.Text
            'IUPrincipal.Persona.ProFuma = RbtnFumaSi.Checked
            'IUPrincipal.Persona.ProGrupoSanguineo = TxtGrupoSanguineo.Text
            'IUPrincipal.Persona.ProIncapacitado = RbtnIncapacitadoSi.Checked
            'IUPrincipal.Persona.ProLentes = RbtnLentesSi.Checked
            'IUPrincipal.Persona.ProNombreContacto = TxtNombreContacto.Text
            'IUPrincipal.Persona.ProOperaciones = RbtnOperacionesSi.Checked
            'IUPrincipal.Persona.ProPeso = TxtPeso.Text
            'IUPrincipal.Persona.ProPuntoReferencia = TxtPuntoReferencia.Text
            'IUPrincipal.Persona.ProTallaCalzado = TxtTallaCalzado.Text
            'IUPrincipal.Persona.ProTallaCamisa = TxtTallaCamisa.Text
            'IUPrincipal.Persona.ProTallaPantalon = TxtTallaPantalon.Text
            'IUPrincipal.Persona.ProTelefonoContacto = TxtTelefonoContacto.Text
            'IUPrincipal.Persona.ProTelefonoHabitacion = TxtTelefono.Text
            'IUPrincipal.Persona.ProTelefonoMovil = TxtTelefonoMovil.Text
            'IUPrincipal.Persona.ProTelefonoMovilContacto = TxtTelefonoMovilContacto.Text
            'IUPrincipal.Persona.ProCertificado = RbtnCertificadoSi.Checked
            'IUPrincipal.Persona.ProHabilidades = TxtHabilidades.Text
            'If CmbProfesion.Items.Count > 0 Then
            '    IUPrincipal.Persona.ProProfesion = CmbProfesion.SelectedIndex
            'End If
            'If CmbBanco.Items.Count > 0 Then
            '    IUPrincipal.Persona.ProBanco = CmbBanco.SelectedIndex
            'End If
            'IUPrincipal.Persona.ProCuentaBancaria = TxtCuentaBancaria.Text
            'IUPrincipal.Persona.ProFechaPreEmpleo = "01/01/1900"
            'IUPrincipal.Persona.ProEstatus = "1"
            'IUPrincipal.Personas.Add(IUPrincipal.Persona)
            'PosicionActual = IUPrincipal.Personas.Count
            'TxtPosicion.Text = IUPrincipal.Personas.Count
            'LabelElementos.Text = "de {" & IUPrincipal.Personas.Count & "}"
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            Dim Lentes As Integer
            Dim Fuma As Integer
            Dim Operaciones As Integer
            Dim Incapacitado As Integer
            Dim Certificado As Integer
            If RbtnLentesSi.Checked = True Then
                Lentes = 1
            Else
                Lentes = 0
            End If
            If RbtnFumaSi.Checked = True Then
                Fuma = 1
            Else
                Fuma = 0
            End If
            If RbtnOperacionesSi.Checked = True Then
                Operaciones = 1
            Else
                Operaciones = 0
            End If
            If RbtnIncapacitadoSi.Checked = True Then
                Incapacitado = 1
            Else
                Incapacitado = 0
            End If
            If RbtnCertificadoSi.Checked = True Then
                Certificado = 1
            Else
                Certificado = 0
            End If
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("INSERT INTO `PERSONAS_TEMP` set `Txt_Cedula` = '" + TxtCedula.Text + "',`Txt_Rif` = '" + TxtRif.Text + "',`Txt_Nombres` = '" + TxtNombre.Text + "',`Txt_Apellidos` = '" + TxtApellido.Text + "',`Dte_Fecha_Nacimiento` = '" + DteFechaNacimiento.Value.ToString("yyyy-MM-dd") + "',`Txt_Lugar_Nacimiento` = '" + TxtLugarNacimiento.Text + "',`Int_Sexo` = '" & CmbSexo.SelectedIndex - 1 & "',`Int_Edo_Civil` = '" & CmbEdoCivil.SelectedIndex - 1 & "',`Txt_Foto` = '" + Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1) + "\" + TxtCedula.Text + ".jpg" + "',`Txt_Direccion` = '" + TxtDireccion.Text + "',`Txt_Punto_Ref` = '" + TxtPuntoReferencia.Text + "',`Txt_Tel_Habitacion` = '" + TxtTelefono.Text + "',`Txt_Tel_Movil` = '" + TxtTelefonoMovil.Text + "',`Txt_Correo` = '" + TxtCorreoElectronico.Text + "',`Txt_Nombre_Contacto` = '" + TxtNombreContacto.Text + "',`Txt_Descripcion_Contacto` = '" + TxtDescripcion.Text + "',`Txt_Tel_Contacto` = '" + TxtTelefonoContacto.Text + "',`Txt_Tel_Movil_Contacto` = '" + TxtTelefonoMovilContacto.Text + "',`Txt_Grupo_Sanguineo` = '" + TxtGrupoSanguineo.Text + "',`Int_Altura` = '" & TxtAltura.Text & "',`Int_Peso` = '" & TxtPeso.Text & "',`Int_Talla_Pantalon` = '" & TxtTallaPantalon.Text & "',`Int_Talla_Calzado` = '" & TxtTallaCalzado.Text & "',`Txt_Talla_Camisa` = '" + TxtTallaCamisa.Text + "',`Boo_Lentes` = '" & Lentes & "',`Boo_Fuma` = '" & Fuma & "',`Boo_Operaciones` = '" & Operaciones & "',`Boo_Incapacitado` = '" & Incapacitado & "',`Txt_Alergias` = '" + TxtAlergias.Text + "',`Txt_Enfermedades` = '" + TxtEnfermedades.Text + "',`Int_Estatus` = '1',`Int_Banco` = '1',`Txt_Cuenta_Bancaria` = '" + TxtCuentaBancaria.Text + "',`Boo_Certificado` = '" & Certificado & "',`Int_Profesion` = '0',`Txt_Habilidades` = '" + TxtHabilidades.Text + "', `Dte_fechapreempleo` = '01/01/1900';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        ElseIf EstadoFormulario = "Modificando" Then
            'IUPrincipal.Personas.Item(PosicionActual).ProCedula = TxtCedula.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProRif = TxtRif.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProApellidos = TxtApellido.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProNombres = TxtNombre.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProEdoCivil = CmbEdoCivil.SelectedIndex - 1
            'IUPrincipal.Personas.Item(PosicionActual).ProFechaNacimiento = DteFechaNacimiento.Value
            'IUPrincipal.Personas.Item(PosicionActual).ProLugarNacimiento = TxtLugarNacimiento.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProSexo = CmbSexo.SelectedIndex - 1
            'PbxFoto.Image.Save(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1) + "\" + TxtCedula.Text + ".jpg")
            'IUPrincipal.Personas.Item(PosicionActual).ProFoto = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1) + "\" + TxtCedula.Text + ".jpg"
            'IUPrincipal.Personas.Item(PosicionActual).ProAlergias = TxtAlergias.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProAltura = TxtAltura.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProCorreoElectronico = TxtCorreoElectronico.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProDescripcionContacto = TxtDescripcion.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProDireccion = TxtDireccion.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProEnfermedades = TxtEnfermedades.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProFuma = RbtnFumaSi.Checked
            'IUPrincipal.Personas.Item(PosicionActual).ProGrupoSanguineo = TxtGrupoSanguineo.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProIncapacitado = RbtnIncapacitadoSi.Checked
            'IUPrincipal.Personas.Item(PosicionActual).ProLentes = RbtnLentesSi.Checked
            'IUPrincipal.Personas.Item(PosicionActual).ProNombreContacto = TxtNombreContacto.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProOperaciones = RbtnOperacionesSi.Checked
            'IUPrincipal.Personas.Item(PosicionActual).ProPeso = TxtPeso.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProPuntoReferencia = TxtPuntoReferencia.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProTallaCalzado = TxtTallaCalzado.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProTallaCamisa = TxtTallaCamisa.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProTallaPantalon = TxtTallaPantalon.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProTelefonoContacto = TxtTelefonoContacto.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProTelefonoHabitacion = TxtTelefono.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProTelefonoMovil = TxtTelefonoMovil.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProTelefonoMovilContacto = TxtTelefonoMovilContacto.Text
            'IUPrincipal.Personas.Item(PosicionActual).ProCertificado = RbtnCertificadoSi.Checked
            'IUPrincipal.Personas.Item(PosicionActual).ProHabilidades = TxtHabilidades.Text
            'If CmbProfesion.Items.Count > 0 Then
            '    IUPrincipal.Personas.Item(PosicionActual).ProProfesion = CmbProfesion.SelectedIndex
            'End If
            'If CmbBanco.Items.Count > 0 Then
            '    IUPrincipal.Personas.Item(PosicionActual).ProBanco = CmbBanco.SelectedIndex
            'End If
            'IUPrincipal.Personas.Item(PosicionActual).ProCuentaBancaria = TxtCuentaBancaria.Text
            ''''REALIZAR MODIFICACION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            Dim Lentes As Integer
            Dim Fuma As Integer
            Dim Operaciones As Integer
            Dim Incapacitado As Integer
            Dim Certificado As Integer
            If RbtnLentesSi.Checked = True Then
                Lentes = 1
            Else
                Lentes = 0
            End If
            If RbtnFumaSi.Checked = True Then
                Fuma = 1
            Else
                Fuma = 0
            End If
            If RbtnOperacionesSi.Checked = True Then
                Operaciones = 1
            Else
                Operaciones = 0
            End If
            If RbtnIncapacitadoSi.Checked = True Then
                Incapacitado = 1
            Else
                Incapacitado = 0
            End If
            If RbtnCertificadoSi.Checked = True Then
                Certificado = 1
            Else
                Certificado = 0
            End If
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("UPDATE `PERSONAS_TEMP` set `Txt_Nombres` = '" + TxtNombre.Text + "',`Txt_Apellidos` = '" + TxtApellido.Text + "',`Dte_Fecha_Nacimiento` = '" + DteFechaNacimiento.Value.ToString("yyyy-MM-dd") + "',`Txt_Lugar_Nacimiento` = '" + TxtLugarNacimiento.Text + "',`Int_Sexo` = '" & CmbSexo.SelectedIndex - 1 & "',`Int_Edo_Civil` = '" & CmbEdoCivil.SelectedIndex - 1 & "',`Txt_Foto` = '" + Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\") + 1) + "\" + TxtCedula.Text + ".jpg" + "',`Txt_Direccion` = '" + TxtDireccion.Text + "',`Txt_Punto_Ref` = '" + TxtPuntoReferencia.Text + "',`Txt_Tel_Habitacion` = '" + TxtTelefono.Text + "',`Txt_Tel_Movil` = '" + TxtTelefonoMovil.Text + "',`Txt_Correo` = '" + TxtCorreoElectronico.Text + "',`Txt_Nombre_Contacto` = '" + TxtNombreContacto.Text + "',`Txt_Descripcion_Contacto` = '" + TxtDescripcion.Text + "',`Txt_Tel_Contacto` = '" + TxtTelefonoContacto.Text + "',`Txt_Tel_Movil_Contacto` = '" + TxtTelefonoMovilContacto.Text + "',`Txt_Grupo_Sanguineo` = '" + TxtGrupoSanguineo.Text + "',`Int_Altura` = '" & TxtAltura.Text & "',`Int_Peso` = '" & TxtPeso.Text & "',`Int_Talla_Pantalon` = '" & TxtTallaPantalon.Text & "',`Int_Talla_Calzado` = '" & TxtTallaCalzado.Text & "',`Txt_Talla_Camisa` = '" + TxtTallaCamisa.Text + "',`Boo_Lentes` = '" & Lentes & "',`Boo_Fuma` = '" & Fuma & "',`Boo_Operaciones` = '" & Operaciones & "',`Boo_Incapacitado` = '" & Incapacitado & "',`Txt_Alergias` = '" + TxtAlergias.Text + "',`Txt_Enfermedades` = '" + TxtEnfermedades.Text + "',`Int_Estatus` = '" & statusg & "',`Int_Banco` = '1',`Txt_Cuenta_Bancaria` = '" + TxtCuentaBancaria.Text + "',`Boo_Certificado` = '" & Certificado & "',`Int_Profesion` = '0',`Txt_Habilidades` = '" + TxtHabilidades.Text + "', `Dte_fechapreempleo` = '" + fechapre.ToString("yyyy-MM-dd") + "' WHERE `Txt_Cedula`='" + TxtCedula.Text + "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        End If
    End Sub
    Private Sub TlsBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnGuardar.Click
        Validacion()
    End Sub

    Private Sub IUGestionPersonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstadoLeyendo()
        If IUPrincipal.Departamentos.Count > 0 Then
            Cargar_Departamentos()
        End If
        If IUPrincipal.Profesiones.Count > 0 Then
            Cargar_Profesiones()
        End If
        If IUPrincipal.Cargos.Count > 0 Then
            Cargar_Cargos()
        End If
        Inicializando_Cmb()
        'If IUPrincipal.Personas.Count > 0 Then
        MostrarPersona(1)
        BarraNavegacion.Enabled = True
        TlsBtnModificar.Enabled = True
        TlsBtnBuscar.Enabled = True
        TlsBtnContrato.Enabled = True
        'End If
        If IUPrincipal.Bancos.Count > 0 Then
            Cargar_Bancos()
        End If
    End Sub
    Private Sub Cargar_Profesiones()
        Dim i As Integer = 0
        While i < IUPrincipal.Profesiones.Count
            CmbProfesion.Items.Add(IUPrincipal.Profesiones(i + 1).ProDescripcion)
            i = i + 1
        End While
        CmbProfesion.SelectedIndex = 0
    End Sub
    Private Sub Cargar_Titulos()
        Dim i As Integer = 0
        While i < IUPrincipal.Titulos1.Count
            CmbTitulos.Items.Add(IUPrincipal.Titulos1(i + 1).ProDescripcion)
            i = i + 1
        End While
        CmbTitulos.SelectedIndex = 0
    End Sub
    Private Sub Cargar_Bancos()
        Dim i As Integer = 0
        While i < IUPrincipal.Bancos.Count
            CmbBanco.Items.Add(IUPrincipal.Bancos(i + 1).ProDescripcion)
            i = i + 1
        End While
        CmbBanco.SelectedIndex = 0
    End Sub
    Private Sub Cargar_Departamentos()
        'Conexion = New ClaseBaseDatos
        'bConexionExitosa = Conexion.Conectar

        'If bConexionExitosa Then
        '    dr = Conexion.Seleccionar("SELECT * FROM `departamentos` ; ")
        '    dr.Read()
        '    While dr.Read()
        '        CmbDepartamento.Items.Add(dr(1))
        '    End While
        'End If
        'Conexion.Cerrar_Conexion()
        Dim i As Integer = 0
        While i < IUPrincipal.Departamentos.Count
            CmbDepartamento.Items.Add(IUPrincipal.Departamentos(i + 1).ProNombre)
            i = i + 1
        End While
        CmbDepartamento.SelectedIndex = 0
    End Sub
    Private Sub Inicializando_Cmb()
        CmbCedula.SelectedIndex = 0
        CmbSexo.SelectedIndex = 0
        CmbEdoCivil.SelectedIndex = 0
        CmbParentesco.SelectedIndex = 0        
        CmbFiltro.SelectedIndex = 0
        DteFechaNacimiento.Value = Today
    End Sub

    Private Sub BotonPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPrimero.Click
        MostrarPersona(1)
    End Sub

    Private Sub BotonAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnterior.Click
        If PosicionActual = 1 Then
            MostrarPersona(1)
        Else
            MostrarPersona(PosicionActual - 1)
        End If
    End Sub

    Private Sub BotonSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSiguiente.Click
        If PosicionActual = IUPrincipal.Personas.Count Then
            MostrarPersona(PosicionActual)
        Else
            MostrarPersona(PosicionActual + 1)
        End If
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        MostrarPersona(IUPrincipal.Personas.Count)
    End Sub

    Private Sub TlsBtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnBuscar.Click
        BarraNavegacion.Enabled = False
        TimerPanel.Start()        
    End Sub

    Private Sub ChkRif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRif.CheckedChanged
        If ChkRif.Checked Then
            TxtRif.Enabled = True
        Else
            TxtRif.Enabled = False
            TxtRif.Text = ""
        End If
    End Sub

    Private Sub DteFechaNacimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DteFechaNacimiento.ValueChanged
        Dim Anio As Integer
        Anio = Today.Year - DteFechaNacimiento.Value.Year
        If (Today.Month < DteFechaNacimiento.Value.Month Or (Today.Month = DteFechaNacimiento.Value.Month And Today.Day < DteFechaNacimiento.Value.Day)) Then
            Anio = Anio - 1
        End If
        LblEdad.Text = Anio
    End Sub

    Private Sub BtnBuscarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarFoto.Click
        OfdFoto.ShowDialog()
        PbxFoto.ImageLocation = OfdFoto.FileName
    End Sub

    Private Sub Limpiar_Familiares()
        TxtNombreFamiliares.Text = ""
        TxtApellidoFamiliares.Text = ""
        CmbParentesco.SelectedIndex = 0
        RbtnSiEstudia.Checked = True
        DteFechaNacimientoFamiliares.Value = Today
        TxtNombreFamiliares.Enabled = False
        TxtApellidoFamiliares.Enabled = False
        CmbParentesco.Enabled = False
        RbtnSiEstudia.Enabled = False
        RbtnNoEstudia.Enabled = False
        DteFechaNacimientoFamiliares.Enabled = False
        BtnGuardarFamiliares.Enabled = False
        BtnEditarFamiliares.Enabled = False
        BtnQuitarFamiliares.Enabled = False
    End Sub

    Private Sub BtnQuitarFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarFamiliares.Click
        Dim Item As Integer
        Item = CInt(DGridFamiliares.Item(2, DGridFamiliares.CurrentRow.Index).Value)
        If DGridFamiliares.RowCount > 0 Then
            IUPrincipal.Familiares.Remove(Item)
            DGridFamiliares.Rows.RemoveAt(DGridFamiliares.CurrentRow.Index)
            Limpiar_Familiares()
            Cargar_Familiares()
        End If
    End Sub

    Private Sub DteFechaNacimientoFamiliares_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DteFechaNacimientoFamiliares.ValueChanged
        Dim Anio As Integer
        Anio = Today.Year - DteFechaNacimientoFamiliares.Value.Year
        If (Today.Month < DteFechaNacimientoFamiliares.Value.Month Or (Today.Month = DteFechaNacimientoFamiliares.Value.Month And Today.Day < DteFechaNacimientoFamiliares.Value.Day)) Then
            Anio = Anio - 1
        End If
        LblEdadFamiliares.Text = Anio
    End Sub

    Private Sub DGridFamiliares_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridFamiliares.CellClick
        Dim Item As Integer = 0
        If DGridFamiliares.Rows.Count >= 1 Then
            Item = CInt(DGridFamiliares.Item(2, DGridFamiliares.CurrentRow.Index).Value)
            TxtNombreFamiliares.Text = IUPrincipal.Familiares.Item(Item).ProNombre
            TxtApellidoFamiliares.Text = IUPrincipal.Familiares.Item(Item).ProApellido
            CmbParentesco.SelectedIndex = IUPrincipal.Familiares.Item(Item).ProParentesco
            DteFechaNacimientoFamiliares.Value = IUPrincipal.Familiares.Item(Item).ProFechaNacimiento
            RbtnSiEstudia.Checked = IUPrincipal.Familiares.Item(Item).ProEstudia
            RbtnNoEstudia.Checked = Not IUPrincipal.Familiares.Item(Item).ProEstudia
            BtnEditarFamiliares.Enabled = True
            BtnQuitarFamiliares.Enabled = True
        End If
    End Sub

    Private Sub BtnEditarFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditarFamiliares.Click
        BtnGuardarFamiliares.Enabled = True
        TxtNombreFamiliares.Enabled = True
        TxtApellidoFamiliares.Enabled = True
        CmbParentesco.Enabled = True
        RbtnSiEstudia.Enabled = True
        RbtnNoEstudia.Enabled = True
        DteFechaNacimientoFamiliares.Enabled = True
        EstadoCargaFamiliares = "Modificando"
    End Sub


    Private Sub BtnNuevoTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoTitulo.Click
        If TxtCedula.Text = "" Then
            MsgBox("No Se Puede Agregar un Titulo sin definir la Cedula de la Persona")
            Exit Sub
        End If
        CmbTitulos.Enabled = True
        TxtInstituto.Enabled = True
        DteFechaTitulo.Enabled = True
        BtnGuardarTitulo.Enabled = True
        BtnEditarTitulo.Enabled = False
        BtnQuitarTitulo.Enabled = False
        EstadoCargaTitulos = "Agregando"
    End Sub

    Private Sub BtnGuardarTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarTitulo.Click
        Dim Item As Integer
        Dim idtitulo As Integer
        If EstadoCargaTitulos = "Agregando" Then
            DgridAcademico.Rows.Add()
            DgridAcademico.Item(0, DgridAcademico.RowCount - 1).Value = CmbTitulos.Text
            DgridAcademico.Item(1, DgridAcademico.RowCount - 1).Value = TxtInstituto.Text
            DgridAcademico.Item(2, DgridAcademico.RowCount - 1).Value = DteFechaTitulo.Value
            DgridAcademico.Item(4, DgridAcademico.RowCount - 1).Value = CmbTitulos.SelectedIndex + 1
            IUPrincipal.Titulo = New ClaseTitulos
            IUPrincipal.Titulo.Proidtitulo = CmbTitulos.SelectedIndex + 1
            IUPrincipal.Titulo.Propersona = TxtCedula.Text
            IUPrincipal.Titulo.Proinstitucion = TxtInstituto.Text
            IUPrincipal.Titulo.Profecha = DteFechaTitulo.Value
            'IUPrincipal.Titulos.Item(Item).ProFk_Cedula = TxtCedula.Text
            'IUPrincipal.Titulo.ProFecha = DteFechaTitulo.Value
            'IUPrincipal.Titulo.ProFk_Cedula = TxtCedula.Text
            IUPrincipal.Titulos.Add(IUPrincipal.Titulo)
            DgridAcademico.Item(3, DgridAcademico.RowCount - 1).Value = IUPrincipal.Titulos.Count
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("INSERT INTO `TITULOS_PERSONAS` set `fk_id_titulo` = '" & IUPrincipal.Titulo.Proidtitulo & "',`fk_id_persona` = '" + IUPrincipal.Titulo.Propersona + "' , `Txt_institucion` = '" + IUPrincipal.Titulo.Proinstitucion + "' , `Dte_fecha` = '" + IUPrincipal.Titulo.Profecha.ToString("yyyy-MM-dd") + "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        Else
            Item = CInt(DgridAcademico.Item(3, DgridAcademico.CurrentRow.Index).Value)
            idtitulo = CInt(DgridAcademico.Item(4, DgridAcademico.CurrentRow.Index).Value)
            DgridAcademico.Item(0, DgridAcademico.CurrentRow.Index).Value = CmbTitulos.Text
            DgridAcademico.Item(1, DgridAcademico.CurrentRow.Index).Value = TxtInstituto.Text
            DgridAcademico.Item(2, DgridAcademico.CurrentRow.Index).Value = DteFechaTitulo.Value
            DgridAcademico.Item(4, DgridAcademico.RowCount - 1).Value = CmbTitulos.SelectedIndex + 1
            IUPrincipal.Titulos.Item(Item).Proidtitulo = CmbTitulos.SelectedIndex + 1
            IUPrincipal.Titulos.Item(Item).Propersona = TxtCedula.Text
            IUPrincipal.Titulos.Item(Item).Proinstitucion = TxtInstituto.Text
            IUPrincipal.Titulos.Item(Item).Profecha = DteFechaTitulo.Value
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("UPDATE `TITULOS_PERSONAS` set `fk_id_titulo` = '" & CmbTitulos.SelectedIndex + 1 & "' , `Txt_institucion` = '" + TxtInstituto.Text + "' , `Dte_fecha` = '" + DteFechaTitulo.Value.ToString("yyyy-MM-dd") + "' where `fk_id_persona` = '" + TxtCedula.Text + "' and `fk_id_titulo` = '" & idtitulo & "';")
            End If
            ''////////////////////////////////////////////////////////
            ''////////////////////////////////////////////////////////
        End If
        Limpiar_Titulos()
    End Sub
    Private Sub Limpiar_Titulos()
        CmbTitulos.Text = ""
        TxtInstituto.Text = ""
        DteFechaTitulo.Value = Today
        CmbTitulos.Enabled = False
        TxtInstituto.Enabled = False
        DteFechaTitulo.Enabled = False
        BtnGuardarTitulo.Enabled = False
        BtnEditarTitulo.Enabled = False
        BtnQuitarTitulo.Enabled = False
    End Sub

    Private Sub DgridAcademico_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgridAcademico.CellClick
        Dim Item As Integer = 0
        If DgridAcademico.Rows.Count >= 1 Then
            Item = CInt(DgridAcademico.Item(3, DgridAcademico.CurrentRow.Index).Value)
            CmbTitulos.Text = DgridAcademico.Item(0, DgridAcademico.CurrentRow.Index).Value
            TxtInstituto.Text = IUPrincipal.Titulos.Item(Item).ProInstitucion
            DteFechaTitulo.Value = IUPrincipal.Titulos.Item(Item).ProFecha
            BtnEditarTitulo.Enabled = True
            BtnQuitarTitulo.Enabled = True
        End If
    End Sub

    Private Sub BtnEditarTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditarTitulo.Click
        BtnGuardarTitulo.Enabled = True
        CmbTitulos.Enabled = True
        TxtInstituto.Enabled = True
        DteFechaTitulo.Enabled = True
        EstadoCargaTitulos = "Modificando"
    End Sub

    Private Sub BtnQuitarTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarTitulo.Click
        Dim Item As Integer
        Item = CInt(DgridAcademico.Item(3, DgridAcademico.CurrentRow.Index).Value)
        If DgridAcademico.RowCount > 0 Then
            IUPrincipal.Titulos.Remove(Item)
            DgridAcademico.Rows.RemoveAt(DgridAcademico.CurrentRow.Index)
            Limpiar_Titulos()
            Cargar_Titulos()
        End If
    End Sub

    Private Sub TimerPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanel.Tick
        If PanelMostrado Then
            panelBuscarEmpleados.Top = panelBuscarEmpleados.Top - 33
        Else
            panelBuscarEmpleados.Top = panelBuscarEmpleados.Top + 33
        End If
        If panelBuscarEmpleados.Top >= 0 Then
            TimerPanel.Stop()
            PanelMostrado = True
        End If
        If panelBuscarEmpleados.Top <= -330 Then
            TimerPanel.Stop()
            PanelMostrado = False
        End If
    End Sub

    Private Sub BtnCancelarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarPanel.Click
        TimerPanel.Start()
    End Sub

    Private Sub BtnBuscarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarPanel.Click
        Buscar(CmbFiltro.SelectedIndex)
    End Sub

    Private Sub Buscar(ByVal Tipo As Integer)
        Dim dr As System.Data.IDataReader
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        DgridEmpleados.Rows.Clear()

        If bConexionExitosa Then
            If Tipo = 2 Then
                dr = Conexion.Seleccionar("SELECT * FROM `personas_temp`; ")
                If (dr.Read()) Then
                    DgridEmpleados.Rows.Add()
                    DgridEmpleados.Item(0, DgridEmpleados.RowCount - 1).Value = dr(1)
                    DgridEmpleados.Item(1, DgridEmpleados.RowCount - 1).Value = dr(3) + " " + dr(4)
                    DgridEmpleados.Item(2, DgridEmpleados.RowCount - 1).Value = dr(0)
                End If
            ElseIf Tipo = 0 Then
                dr = Conexion.Seleccionar("SELECT * FROM `personas_temp` where `Txt_Cedula` = '" + TxtBusqueda.Text + "'; ")
                If (dr.Read()) Then
                    DgridEmpleados.Rows.Add()
                    DgridEmpleados.Item(0, DgridEmpleados.RowCount - 1).Value = dr(1)
                    DgridEmpleados.Item(1, DgridEmpleados.RowCount - 1).Value = dr(3) + " " + dr(4)
                    DgridEmpleados.Item(2, DgridEmpleados.RowCount - 1).Value = dr(0)
                End If
            ElseIf Tipo = 1 Then
                dr = Conexion.Seleccionar("SELECT * FROM `personas_temp` where `Txt_Nombres` like '%" + TxtBusqueda.Text.ToLower + "%' or `Txt_Apellidos` like '%" + TxtBusqueda.Text.ToLower + "%'; ")
                If (dr.Read()) Then
                    DgridEmpleados.Rows.Add()
                    DgridEmpleados.Item(0, DgridEmpleados.RowCount - 1).Value = dr(1)
                    DgridEmpleados.Item(1, DgridEmpleados.RowCount - 1).Value = dr(3) + " " + dr(4)
                    DgridEmpleados.Item(2, DgridEmpleados.RowCount - 1).Value = dr(0)
                End If
            End If
        End If
        dr.Dispose()
        dr.Close()
        Conexion.Cerrar_Conexion()

        'DgridEmpleados.Rows.Clear()
        'Dim i As Integer = 0
        'If Tipo = 2 Then
        '    While i < IUPrincipal.Personas.Count
        '        DgridEmpleados.Rows.Add()
        '        DgridEmpleados.Item(0, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
        '        DgridEmpleados.Item(1, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres
        '        DgridEmpleados.Item(3, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProApellidos
        '        DgridEmpleados.Item(2, DgridEmpleados.RowCount - 1).Value = i + 1
        '        i = i + 1
        '    End While
        'ElseIf Tipo = 0 Then
        '    i = 0
        '    While i < IUPrincipal.Personas.Count
        '        If IUPrincipal.Personas.Item(i + 1).ProCedula Like TxtBusqueda.Text + "*" Then
        '            DgridEmpleados.Rows.Add()
        '            DgridEmpleados.Item(0, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
        '            DgridEmpleados.Item(1, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres
        '            DgridEmpleados.Item(3, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProApellidos
        '            DgridEmpleados.Item(2, DgridEmpleados.RowCount - 1).Value = i + 1
        '        End If
        '        i = i + 1
        '    End While
        'ElseIf Tipo = 1 Then
        '    i = 0
        '    While i < IUPrincipal.Personas.Count
        '        If IUPrincipal.Personas.Item(i + 1).ProNombres.ToLower Like TxtBusqueda.Text.ToLower + "*" Then
        '            DgridEmpleados.Rows.Add()
        '            DgridEmpleados.Item(0, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
        '            DgridEmpleados.Item(1, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres
        '            DgridEmpleados.Item(3, DgridEmpleados.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProApellidos
        '            DgridEmpleados.Item(2, DgridEmpleados.RowCount - 1).Value = i + 1
        '        End If
        '        i = i + 1
        '    End While
        'End If
    End Sub

    Private Sub BtnCapturarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCapturarFoto.Click
        IUCapturaCamara.Show()
    End Sub

    Private Sub TlsBtnContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnContrato.Click
        IUGenerarContratos.LblDatoCedula.Text = TxtCedula.Text
        IUGenerarContratos.LblDatoNombre.Text = TxtNombre.Text + " " + TxtApellido.Text
        IUGenerarContratos.LblPosicion.Text = PosicionActual
        IUGenerarContratos.dire = TxtDireccion.Text
        IUGenerarContratos.fecnac = DteFechaNacimiento.Value
        IUGenerarContratos.MdiParent = IUPrincipal
        IUGenerarContratos.Show()
        'IUGenerarContratos.buscar_contrato2(TxtCedula.Text, IUPrincipal.Personas.Item(PosicionActual).ProEstatus)
        IUGenerarContratos.TlsBtnNuevo.Enabled = True
        IUGenerarContratos.BarraNavegacion.Enabled = True
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        If DgridEmpleados.RowCount > 0 Then
            MostrarPersona(CInt(DgridEmpleados.Item(2, DgridEmpleados.CurrentRow.Index).Value))
            TimerPanel.Start()
        End If
    End Sub
    Public Sub Buscar_Contrato(ByVal Busqueda As String)
        Dim i As Integer = 0
        While i < IUPrincipal.Contratos.Count
            If IUPrincipal.Contratos.Item(i + 1).ProFk_Cedula Like Busqueda Then
                MostrarContrato(i + 1)
                Exit Sub
            End If
            i = i + 1
        End While
        Limpiar_DatosLaborales()
    End Sub
    Private Sub Limpiar_DatosLaborales()
        CmbBanco.Enabled = False
        TxtCuentaBancaria.Enabled = False
        TxtCuentaBancaria.Text = ""
        LblDatoDepartamento.Text = ""
        LblDatoCargo.Text = ""
        LblDatoSueldoMensual.Text = ""
        LblDatoFechaInicio.Text = ""
        LblDatoFechaFinal.Text = ""
    End Sub
    Private Sub MostrarContrato(ByVal Posicion As Integer)
        CmbBanco.Enabled = True
        TxtCuentaBancaria.Enabled = True
        If IUPrincipal.Departamentos.Count > 0 Then
            Cargar_Departamentos()
        End If
        'CmbDepartamento.SelectedIndex = IUPrincipal.Contratos.Item(Posicion).ProDepartamento() - 1
        'LblDatoDepartamento.Text = CmbDepartamento.Text

        CmbCargo.SelectedIndex = IUPrincipal.Contratos.Item(Posicion).ProCargo - 1
        LblDatoCargo.Text = CmbCargo.Text
        LblDatoSueldoMensual.Text = IUPrincipal.Contratos.Item(Posicion).ProSueldo
        LblDatoFechaInicio.Text = IUPrincipal.Contratos.Item(Posicion).ProFechaInicial
        LblDatoFechaFinal.Text = IUPrincipal.Contratos.Item(Posicion).ProFechaFinal                
    End Sub

    Private Sub CmbDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IUPrincipal.Cargos.Count > 0 Then
            CmbCargo.Items.Clear()
            Cargar_Cargos()
        End If
    End Sub

    Private Sub Cargar_Cargos()
        Dim i As Integer = 0
        While i < IUPrincipal.Cargos.Count
            CmbCargo.Items.Add(IUPrincipal.Cargos(i + 1).ProNombre)
            'If CmbDepartamento.SelectedIndex = IUPrincipal.Cargos(i + 1).ProDepartamento Then
            '    CmbCargo.Items.Add(IUPrincipal.Cargos(i + 1).ProNombre)
            'End If
            i = i + 1
        End While
        If CmbCargo.Items.Count > 0 Then
            CmbCargo.SelectedIndex = 0
        End If
    End Sub

    Private Sub TxtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCedula.KeyPress
        e.Handled = ValidarNumerico(TxtCedula, e.KeyChar, False)
    End Sub

    Private Sub TxtRif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRif.KeyPress
        e.Handled = ValidarNumerico(TxtRif, e.KeyChar, False)
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
    Private Sub CmbBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            CmbBanco.Items.Add(CmbBanco.Text)
            IUPrincipal.Banco = New ClaseBanco
            IUPrincipal.Banco.ProDescripcion = CmbBanco.Text
            IUPrincipal.Bancos.Add(IUPrincipal.Banco)
            CmbBanco.SelectedIndex = CmbBanco.Items.Count - 1
        End If
    End Sub

    Private Sub CmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCedula.TextChanged

    End Sub

    Private Sub RbtnCuentaSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RbtnCuentaSi.Checked = True Then
            CmbBanco.Enabled = True
            TxtCuentaBancaria.Enabled = True
        Else
            CmbBanco.Enabled = False
            TxtCuentaBancaria.Enabled = False
        End If
    End Sub

    Private Sub RbtnCuentaNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RbtnCuentaNo.Checked = True Then
            If IUPrincipal.Bancos.Count > 0 Then
                CmbBanco.SelectedIndex = 0
            End If
            TxtCuentaBancaria.Text = ""
        End If
    End Sub

    Private Sub CmbProfesion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProfesion.KeyDown
        If e.KeyValue = 13 Then
            CmbProfesion.Items.Add(CmbProfesion.Text)
            IUPrincipal.Profesion = New ClaseProfesion
            IUPrincipal.Profesion.ProDescripcion = CmbProfesion.Text
            IUPrincipal.Profesiones.Add(IUPrincipal.Profesion)
            CmbProfesion.SelectedIndex = CmbProfesion.Items.Count - 1
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("INSERT INTO `PROFESIONES` set `Txt_Descripcion` = '" + IUPrincipal.Profesion.ProDescripcion + "';")
            End If
            '////////////////////////////////////////////////////////
        End If
    End Sub


    Private Sub BtnNuevoFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoFamiliares.Click    
        If TxtCedula.Text = "" Then
            MsgBox("No Se Puede Agregar un Familiar sin definir la Cedula de la Persona")
            Exit Sub
        End If
        TxtNombreFamiliares.Enabled = True
        TxtApellidoFamiliares.Enabled = True
        CmbParentesco.Enabled = True
        RbtnSiEstudia.Enabled = True
        RbtnNoEstudia.Enabled = True
        DteFechaNacimientoFamiliares.Enabled = True
        BtnGuardarFamiliares.Enabled = True
        BtnEditarFamiliares.Enabled = False
        BtnQuitarFamiliares.Enabled = False
        EstadoCargaFamiliares = "Agregando"
    End Sub

    Private Sub BtnGuardarFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarFamiliares.Click
        Dim Item As Integer
        If EstadoCargaFamiliares = "Agregando" Then
            DGridFamiliares.Rows.Add()
            DGridFamiliares.Item(0, DGridFamiliares.RowCount - 1).Value = CmbParentesco.Text
            DGridFamiliares.Item(1, DGridFamiliares.RowCount - 1).Value = TxtNombreFamiliares.Text
            IUPrincipal.Familiar = New ClaseFamiliares
            IUPrincipal.Familiar.ProApellido = TxtApellidoFamiliares.Text
            IUPrincipal.Familiar.ProEstudia = RbtnSiEstudia.Checked
            IUPrincipal.Familiar.ProFechaNacimiento = DteFechaNacimientoFamiliares.Value
            IUPrincipal.Familiar.ProFk_Cedula = TxtCedula.Text
            IUPrincipal.Familiar.ProNombre = TxtNombreFamiliares.Text
            IUPrincipal.Familiar.ProParentesco = CmbParentesco.SelectedIndex
            IUPrincipal.Familiares.Add(IUPrincipal.Familiar)
            DGridFamiliares.Item(2, DGridFamiliares.RowCount - 1).Value = IUPrincipal.Familiares.Count
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            Dim Estudia As Integer
            If IUPrincipal.Familiar.ProEstudia = True Then
                Estudia = 1
            Else
                Estudia = 0
            End If
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("INSERT INTO `FAMILIARES` set `Fk_Txt_Cedula` = '" + IUPrincipal.Familiar.ProFk_Cedula + "',`Txt_Nombre` = '" + IUPrincipal.Familiar.ProNombre + "',`Txt_Apellido` = '" + IUPrincipal.Familiar.ProApellido + "',`Dte_Fecha_Nacimiento` = '" + IUPrincipal.Familiar.ProFechaNacimiento.ToString("yyyy-MM-dd") + "',`Int_Parentesco` = '" & IUPrincipal.Familiar.ProParentesco & "',`Boo_Estudia` = '" & Estudia & "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        Else
            Item = CInt(DGridFamiliares.Item(2, DGridFamiliares.CurrentRow.Index).Value)
            DGridFamiliares.Item(0, DGridFamiliares.CurrentRow.Index).Value = CmbParentesco.Text
            DGridFamiliares.Item(1, DGridFamiliares.CurrentRow.Index).Value = TxtNombreFamiliares.Text
            IUPrincipal.Familiares.Item(Item).ProApellido = TxtApellidoFamiliares.Text
            IUPrincipal.Familiares.Item(Item).ProEstudia = RbtnSiEstudia.Checked
            IUPrincipal.Familiares.Item(Item).ProFechaNacimiento = DteFechaNacimientoFamiliares.Value
            IUPrincipal.Familiares.Item(Item).ProFk_Cedula = TxtCedula.Text
            IUPrincipal.Familiares.Item(Item).ProNombre = TxtNombreFamiliares.Text
            IUPrincipal.Familiares.Item(Item).ProParentesco = CmbParentesco.SelectedIndex
            ''''REALIZAR UPDATE EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            Dim Estudia As Integer
            If IUPrincipal.Familiar.ProEstudia = True Then
                Estudia = 1
            Else
                Estudia = 0
            End If
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("update `FAMILIARES` set `Txt_Nombre` = '" + IUPrincipal.Familiar.ProNombre + "',`Txt_Apellido` = '" + IUPrincipal.Familiar.ProApellido + "',`Dte_Fecha_Nacimiento` = '" + IUPrincipal.Familiar.ProFechaNacimiento.ToString("yyyy-MM-dd") + "',`Int_Parentesco` = '" & IUPrincipal.Familiar.ProParentesco & "',`Boo_Estudia` = '" & Estudia & "' where `Fk_Txt_Cedula` = '" + IUPrincipal.Familiar.ProFk_Cedula + "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        End If
        Limpiar_Familiares()
    End Sub



    Private Sub DgridAcademico_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgridAcademico.CellContentClick

    End Sub

    Private Sub CmbProfesion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProfesion.SelectedIndexChanged

    End Sub

    Private Sub TxtRif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRif.TextChanged
        If Me.Text = "" Then
            Me.Enabled = False
            ChkRif.Checked = False
        End If
    End Sub


End Class
