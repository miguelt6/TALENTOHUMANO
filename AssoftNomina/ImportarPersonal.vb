Imports System.Data.SqlClient

Public Class ImportarPersonal
    Private Sub ImportarPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conexion As SqlConnection
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim sexo As Integer
        Dim status As Integer
        Dim fecha As Date
        Dim cargo As String
        Dim codcargo As Integer
        Dim tipo As Integer
        Dim fecha1 As Date
        Dim fecha2 As Date
        Dim fecha3 As Date
        Dim dias As Integer
        Dim pago As Integer
        Dim contrato As String
        Dim jornada As Integer
        Dim calzado As Integer
        Dim camisa As String
        Dim pantalon As Integer
        Dim alergias As String
        Dim fumas As String
        Dim fumai As Integer
        Dim dr As System.Data.IDataReader


        conexion = New SqlConnection("Data Source=SRVLASVEGAS\CORPORATIVO;Initial Catalog=HHRR;User ID=sa")
        Dim bConexionExitosa As Boolean
        IUPrincipal.Conexion = New ClaseBaseDatos
        bConexionExitosa = IUPrincipal.Conexion.Conectar
        If bConexionExitosa Then
            Try
                conexion.Open()
                If (conexion.State = 1) Then
                    'Dim da As New SqlDataAdapter("SELECT * FROM MA_FERIADOS", conexion)
                    'Dim da As New SqlDataAdapter("SELECT * FROM MA_NOMINA", conexion)
                    Dim da As New SqlDataAdapter("SELECT * FROM MA_PERSONAL", conexion)
                    'Dim da As New SqlDataAdapter("SELECT * FROM MA_ESTRUCTURA_ORGANIZACIONAL WHERE (cu_descripcion = 'GERENCIA' OR cu_descripcion = 'DEPARTAMENTO LEGAL' OR cu_descripcion = 'AUDITORIA' OR cu_descripcion = 'PROYECTOS')", conexion)
                    'Dim da As New SqlDataAdapter("SELECT * FROM MA_ESTRUCTURA_ORGANIZACIONAL WHERE (cu_relacion = 'L1' or cu_codigo = '004' OR cu_codigo = '005' OR cu_codigo = '009' OR cu_codigo = '0102')", conexion)
                    'Dim da As New SqlDataAdapter("SELECT * FROM MA_CONCEPTOS", conexion)
                    'Dim da As New SqlDataAdapter("SELECT * FROM MA_FUNCIONESVARIABLES", conexion)
                    'Dim da As New SqlDataAdapter("SELECT * FROM MA_USUARIOS", conexion)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    While i < ds.Tables(0).Rows.Count

                        ''''''''''''''USUARIOS: ''''''''''''''''''''''''''''''
                        'IUPrincipal.Conexion.Insertar("INSERT INTO `USUARIOS` set `Txt_Nombre` = '" + ds.Tables(0).Rows(i).Item(3) + "',`Txt_Login` = '" & ds.Tables(0).Rows(i).Item(2) & "', `Txt_Password` = '" & ds.Tables(0).Rows(i).Item(1) & "', `Int_Nivel` = '" & ds.Tables(0).Rows(i).Item(4) & "';")
                        ''''''''''''''USUARIOS  ''''''''''''''''''''''''''''''

                        ''''''''''''''VARIABLES: ''''''''''''''''''''''''''''''
                        'IUPrincipal.Conexion.Insertar("INSERT INTO `VARIABLES` set `Txt_Descripcion` = '" + ds.Tables(0).Rows(i).Item(1) + "',`Txt_Nombre_Corto` = '" & ds.Tables(0).Rows(i).Item(0) & "', `Txt_Valor` = '" & ds.Tables(0).Rows(i).Item(3) & "', `Int_Tipo` = '" & ds.Tables(0).Rows(i).Item(4) & "';")
                        ''''''''''''''VARIABLES  ''''''''''''''''''''''''''''''

                        ''''''''''''''CONCEPTOS: ''''''''''''''''''''''''''''''
                        'IUPrincipal.Conexion.Insertar("INSERT INTO `CONCEPTOS` set `Txt_codigo` = '" + ds.Tables(0).Rows(i).Item(0) + "',`Txt_Descripcion` = '" & ds.Tables(0).Rows(i).Item(1) & "', `Int_Codigo_Proceso` = '" & ds.Tables(0).Rows(i).Item(2) & "', `Txt_Formula` = '" & ds.Tables(0).Rows(i).Item(5) & "', `Boo_Estado` = '1';")
                        ''''''''''''''CONCEPTOS  ''''''''''''''''''''''''''''''

                        ''''''''''''''DIAS FERIADOS: ''''''''''''''''''''''''''''''
                        'fecha = ds.Tables(0).Rows(i).Item(4)
                        'IUPrincipal.Conexion.Insertar("INSERT INTO `DIAS_FERIADOS` set `Dte_Fecha` = '" + fecha.ToString("yyyy-MM-dd") + "',`Int_Localidad` = '" & ds.Tables(0).Rows(i).Item(3) & "', `Txt_Descripcion` = '" & ds.Tables(0).Rows(i).Item(1) & "';")
                        ''''''''''''''DIAS FERIADOS  ''''''''''''''''''''''''''''''

                        ''''''''''NOMINA: '''''''''''''''''''''''''''''''''''''
                        'IUPrincipal.Conexion.Insertar("INSERT INTO `NOMINA` set `id` = '" + ds.Tables(0).Rows(i).Item(0) + "',`Txt_Nombre` = '" + ds.Tables(0).Rows(i).Item(1) + "';")
                        ''''''''''NOMINA  '''''''''''''''''''''''''''''''''''''

                        '''''''''PERSONAL: '''''''''''''''''''''''''''''''''''''''''''''''''''''-  
                        Dim da2 As New SqlDataAdapter
                        da2 = New SqlDataAdapter("SELECT cu_valor FROM MA_PERSONAL_PLANTILLAS WHERE (cu_codplantilla = 1) AND (cu_codpersonal = '" + ds.Tables(0).Rows(i).Item(0) + "')", conexion)
                        Dim ds2 As New DataSet
                        da2.Fill(ds2)
                        If ds2.Tables(0).Rows.Count > 0 Then
                            If Int32.TryParse(ds2.Tables(0).Rows(0).Item(0), calzado) Then
                                calzado = ds2.Tables(0).Rows(0).Item(0)
                            Else
                                calzado = 0
                            End If
                        Else
                            calzado = 0
                        End If

                        da2 = New SqlDataAdapter("SELECT cu_valor FROM MA_PERSONAL_PLANTILLAS WHERE (cu_codplantilla = 2) AND (cu_codpersonal = '" + ds.Tables(0).Rows(i).Item(0) + "')", conexion)
                        ds2 = New DataSet
                        da2.Fill(ds2)
                        If ds2.Tables(0).Rows.Count > 0 Then
                            camisa = ds2.Tables(0).Rows(0).Item(0)
                        Else
                            camisa = 0
                        End If

                        da2 = New SqlDataAdapter("SELECT cu_valor FROM MA_PERSONAL_PLANTILLAS WHERE (cu_codplantilla = 3) AND (cu_codpersonal = '" + ds.Tables(0).Rows(i).Item(0) + "')", conexion)
                        ds2 = New DataSet
                        da2.Fill(ds2)
                        If ds2.Tables(0).Rows.Count > 0 Then
                            If Int32.TryParse(ds2.Tables(0).Rows(0).Item(0), pantalon) Then
                                pantalon = ds2.Tables(0).Rows(0).Item(0)
                            Else
                                pantalon = 0
                            End If
                        Else
                            pantalon = 0
                        End If

                        da2 = New SqlDataAdapter("SELECT cu_valor FROM MA_PERSONAL_PLANTILLAS WHERE (cu_codplantilla = 5) AND (cu_codpersonal = '" + ds.Tables(0).Rows(i).Item(0) + "')", conexion)
                        ds2 = New DataSet
                        da2.Fill(ds2)
                        If ds2.Tables(0).Rows.Count > 0 Then
                            alergias = ds2.Tables(0).Rows(0).Item(0)
                        Else
                            alergias = "NO"
                        End If

                        da2 = New SqlDataAdapter("SELECT cu_valor FROM MA_PERSONAL_PLANTILLAS WHERE (cu_codplantilla = 6) AND (cu_codpersonal = '" + ds.Tables(0).Rows(i).Item(0) + "')", conexion)
                        ds2 = New DataSet
                        da2.Fill(ds2)
                        If ds2.Tables(0).Rows.Count > 0 Then
                            fumas = ds2.Tables(0).Rows(0).Item(0)
                            If fumas = "SI" Then
                                fumai = 1
                            Else
                                fumai = 0
                            End If
                        Else
                            fumai = 0
                        End If

                        If (ds.Tables(0).Rows(i).Item(30) = "F") Then
                            sexo = 1
                        Else
                            sexo = 0
                        End If
                        If (ds.Tables(0).Rows(i).Item(26) = "0000000001") Then
                            status = 4
                        ElseIf (ds.Tables(0).Rows(i).Item(26) = "0000000004") Then
                            status = 6
                        ElseIf (ds.Tables(0).Rows(i).Item(26) = "0000000005") Then
                            status = 7
                        ElseIf (ds.Tables(0).Rows(i).Item(26) = "0000000006") Then
                            status = 5
                        End If
                        'fecha = Date.ParseExact(ds.Tables(0).Rows(i).Item(6), "yyyy-MM-dd", Nothing)
                        fecha = ds.Tables(0).Rows(i).Item(6)
                        IUPrincipal.Conexion.Insertar("INSERT INTO `PERSONAS_TEMP` set `Txt_Cedula` = '" + ds.Tables(0).Rows(i).Item(0) + "',`Txt_Rif` = '" + Strings.Right(ds.Tables(0).Rows(i).Item(53), 1) + "',`Txt_Nombres` = '" + ds.Tables(0).Rows(i).Item(2) + "',`Txt_Apellidos` = '" + ds.Tables(0).Rows(i).Item(1) + "',`Dte_Fecha_Nacimiento` = '" + fecha.ToString("yyyy-MM-dd") + "',`Txt_Lugar_Nacimiento` = '" + ds.Tables(0).Rows(i).Item(14) + "',`Int_Sexo` = '" & sexo & "',`Int_Edo_Civil` = '" & CInt(ds.Tables(0).Rows(i).Item(5)) & "',`Txt_Direccion` = '" + ds.Tables(0).Rows(i).Item(7) + "',`Txt_Tel_Habitacion` = '" + ds.Tables(0).Rows(i).Item(12) + "',`Txt_Tel_Movil` = '" + ds.Tables(0).Rows(i).Item(12) + "',`Int_Talla_Pantalon`='" & pantalon & "',`Int_Talla_Calzado`='" & calzado & "',`Txt_Talla_Camisa`='" + camisa + "',`Boo_Fuma`='" & fumai & "',`Txt_Alergias`='" + alergias + "',`Int_Estatus` = '" & status & "',`Int_Banco` = '" & CInt(ds.Tables(0).Rows(i).Item(22)) & "',`Txt_Cuenta_Bancaria` = '" + ds.Tables(0).Rows(i).Item(23) + "';")
                        '''''''''PERSONAL  '''''''''''''''''''''''''''''''''''''''''''''''''''''



                        ''''''''''''''''''''''''''PARA MIGRAR LOS CONTRATOS'''''''''''''''''''''''''''
                        'If (ds.Tables(0).Rows(i).Item(35) = "F") Then
                        '    tipo = 1
                        'Else
                        '    tipo = 2
                        'End If
                        'If (ds.Tables(0).Rows(i).Item(54) = "Efectivo") Then
                        '    pago = 1
                        'Else
                        '    pago = 2
                        'End If
                        'fecha1 = ds.Tables(0).Rows(i).Item(18)
                        'fecha2 = ds.Tables(0).Rows(i).Item(25)
                        'dias = DateDiff("d", fecha1, fecha2)
                        'fecha3 = ds.Tables(0).Rows(i).Item(33)

                        ''Dim pru As String = "SELECT * FROM MA_ESTRUCTURA_ORGANIZACIONAL WHERE (id = '" + ds.Tables(0).Rows(i).Item(17) + "')"
                        'Dim da2 As New SqlDataAdapter("SELECT * FROM MA_ESTRUCTURA_ORGANIZACIONAL WHERE (cu_codigo = '" + ds.Tables(0).Rows(i).Item(17) + "')", conexion)
                        'Dim ds2 As New DataSet
                        'da2.Fill(ds2)
                        'cargo = ds2.Tables(0).Rows(0).Item(3)

                        'dr = IUPrincipal.Conexion.Seleccionar("SELECT * FROM `CARGOS` WHERE `Txt_Nombre` = '" + cargo + "' ; ")
                        'dr.Read()
                        'codcargo = dr(0)
                        'dr.Dispose()
                        'dr.Close()

                        'Dim da3 As New SqlDataAdapter("SELECT * FROM MA_TIPO_CONTRATO WHERE (cu_codigo = '" + ds.Tables(0).Rows(i).Item(24) + "')", conexion)
                        'Dim ds3 As New DataSet
                        'da3.Fill(ds3)
                        'contrato = ds3.Tables(0).Rows(0).Item(1)

                        'Dim quer As String = "SELECT DATEDIFF(hh, dHoraEntradaLunes, dHoraSalidaLunes) AS Expr1 FROM MA_Horario_Intervalos WHERE (cCodigoHorario = '" + ds.Tables(0).Rows(i).Item(36) + "') AND (cCodigo = '" + ds.Tables(0).Rows(i).Item(37) + "')"
                        'Dim da4 As New SqlDataAdapter("SELECT DATEDIFF(hh, dHoraEntradaLunes, dHoraSalidaLunes) AS Expr1 FROM MA_Horario_Intervalos WHERE (cCodigoHorario = '" + ds.Tables(0).Rows(i).Item(36) + "') AND (cCodigo = '" + ds.Tables(0).Rows(i).Item(37) + "')", conexion)
                        'Dim ds4 As New DataSet
                        'da4.Fill(ds4)

                        'If ds4.Tables(0).Rows.Count = 0 Then
                        '    jornada = 0
                        'Else
                        '    jornada = ds4.Tables(0).Rows(0).Item(0)
                        'End If


                        'IUPrincipal.Conexion.Insertar("INSERT INTO `CONTRATOS` set `Txt_Descripcion` = '" + contrato + "', `Txt_Fk_Cedula` = '" + ds.Tables(0).Rows(i).Item(0) + "',`Int_Fk_Codgio_Cargo` = '" & codcargo & "', `Int_Tipo_Horario` = '" & tipo & "',`Dbl_Sueldo_Mensual` = '" & ds.Tables(0).Rows(i).Item(19) & "',`Dte_Fecha_Inicial` = '" + fecha1.ToString("yyyy-MM-dd") + "',`Dte_Fecha_Final` = '" + fecha2.ToString("yyyy-MM-dd") + "',`Int_Duracion` = '" & dias & "',`Int_Tipo_Pago` = '" & pago & "',`fk_id_Cod_Banco` = '" & ds.Tables(0).Rows(i).Item(22) & "',`fk_id_Cod_Nomina` = '" & ds.Tables(0).Rows(i).Item(21) & "',`Txt_Numero_Cuenta` = '" + ds.Tables(0).Rows(i).Item(23) + "',`Txt_Frecuencia_Pago` = 'Quincenal',`Dte_Fecha_Egreso` = '" + fecha3.ToString("yyyy-MM-dd") + "' ,`Dbl_Jornada_Diaria` = '" & CDbl(jornada) & "', `fk_id_cod_localidad`='" & ds.Tables(0).Rows(i).Item(43) & "';")
                        ''''''''''''''''''''''''''CONTRATOS''''''''''''''''''''''

                        ''''''''''CARGOS: '''''''''''''''''''''''''''
                        'Dim da2 As New SqlDataAdapter("SELECT * FROM MA_ESTRUCTURA_ORGANIZACIONAL WHERE (cu_relacion = '" + ds.Tables(0).Rows(i).Item(1) + "')", conexion)
                        'Dim ds2 As New DataSet
                        'da2.Fill(ds2)
                        'j = 0
                        'While j < ds2.Tables(0).Rows.Count
                        '    IUPrincipal.Conexion.Insertar("INSERT INTO `CARGOS` set `Txt_Nombre` = '" + ds2.Tables(0).Rows(j).Item(3) + "',`Txt_Descripcion` = '" + ds2.Tables(0).Rows(j).Item(3) + "', `Num_Codigo_Departamento` = '" & i + 1 & "' ;")
                        '    j = j + 1
                        'End While
                        ''''''''''CARGOS  '''''''''''''''''''''''''''

                        ''''''''''DEPARTAMENTOS: '''''''''''''''''''''''''
                        'IUPrincipal.Conexion.Insertar("INSERT INTO `departamentos` set `Txt_Nombre` = '" + ds.Tables(0).Rows(i).Item(3) + "',`Txt_Descripcion` = '" + ds.Tables(0).Rows(i).Item(3) + "' ;")
                        ''''''''''DEPARTAMENTOS  '''''''''''''''''''''''''

                        i = i + 1
                    End While
                MsgBox("Listo!")
                End If
            Catch ex As SqlException
                MsgBox(ex)
            End Try
        End If
    End Sub
End Class