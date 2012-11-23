Imports CrystalDecisions.Shared
Imports MySQLDriverCS
Public Class IUGestionAspirantes
    Public Conexion As ClaseBaseDatos
    Public Persona As ClasePersona
    Public Personas As New Collection
    Private Sub ChkCertificado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCertificado.CheckedChanged

    End Sub

    Private Sub IUGestionAspirantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IUPrincipal.Personas.Count > 0 Then
            TlsBtnBuscar.Enabled = True
        End If
        If IUPrincipal.Profesiones.Count > 0 Then
            Cargar_Profesiones()
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
    Private Sub TlsBtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnBuscar.Click
        TlsBtnContrato.Enabled = False
        Buscar(2)
    End Sub


    Private Sub Buscar(ByVal Tipo As Integer)
        DgridAspirantes.Rows.Clear()
        Dim i As Integer = 0
        Dim Mostrar As Boolean = False
        Dim profesion As Boolean = False
        Dim edocivil As Boolean = False
        Dim sexo As Boolean = False
        Dim certif As Boolean = False
        Dim rif As Boolean = False
        Dim pre As Boolean = False


        While i < IUPrincipal.Personas.Count
            If ChkPre.Checked = True Then
                If IUPrincipal.Personas.Item(i + 1).ProEstatus = "2" Or IUPrincipal.Personas.Item(i + 1).ProEstatus = "8" Then
                    Mostrar = True
                End If
            Else
                If ChkProfesion.Checked = True Then
                    If ChkSexo.Checked = True Then
                        If ChkEdoCivil.Checked = True Then
                            If IUPrincipal.Personas.Item(i + 1).ProProfesion = CmbProfesion.SelectedIndex And IUPrincipal.Personas.Item(i + 1).prosexo = CmbSexo.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProEdoCivil = CmbEdoCivil.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        Else
                            If IUPrincipal.Personas.Item(i + 1).ProProfesion = CmbProfesion.SelectedIndex And IUPrincipal.Personas.Item(i + 1).prosexo = CmbSexo.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        End If
                    Else
                        If ChkEdoCivil.Checked = True Then
                            If IUPrincipal.Personas.Item(i + 1).ProProfesion = CmbProfesion.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProEdoCivil = CmbEdoCivil.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        Else
                            If IUPrincipal.Personas.Item(i + 1).ProProfesion = CmbProfesion.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        End If
                    End If
                Else
                    If ChkSexo.Checked = True Then
                        If ChkEdoCivil.Checked = True Then
                            If IUPrincipal.Personas.Item(i + 1).prosexo = CmbSexo.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProEdoCivil = CmbEdoCivil.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        Else
                            If IUPrincipal.Personas.Item(i + 1).prosexo = CmbSexo.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        End If
                    Else
                        If ChkEdoCivil.Checked = True Then
                            If IUPrincipal.Personas.Item(i + 1).ProEdoCivil = CmbEdoCivil.SelectedIndex And IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        Else
                            If IUPrincipal.Personas.Item(i + 1).ProCertificado = ChkCertificado.Checked And IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                                Mostrar = True
                            End If
                        End If
                    End If
                End If
            End If


            If Mostrar Then
                DgridAspirantes.Rows.Add()
                DgridAspirantes.Item(0, DgridAspirantes.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
                DgridAspirantes.Item(1, DgridAspirantes.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres
                DgridAspirantes.Item(2, DgridAspirantes.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProApellidos
                If IUPrincipal.Profesiones.Count > 0 Then
                    CmbProfesion.SelectedIndex = IUPrincipal.Personas.Item(i + 1).ProProfesion
                End If
                DgridAspirantes.Item(3, DgridAspirantes.RowCount - 1).Value = CmbProfesion.Text
                DgridAspirantes.Item(4, DgridAspirantes.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCertificado
                If IUPrincipal.Personas.Item(i + 1).ProRif <> "" Then
                    DgridAspirantes.Item(5, DgridAspirantes.RowCount - 1).Value = True
                End If
                CmbSexo.SelectedIndex = IUPrincipal.Personas.Item(i + 1).ProSexo
                DgridAspirantes.Item(6, DgridAspirantes.RowCount - 1).Value = CmbSexo.Text
                DgridAspirantes.Item(7, DgridAspirantes.RowCount - 1).Value = i + 1
                DgridAspirantes.Item(8, DgridAspirantes.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProEstatus
                If IUPrincipal.Personas.Item(i + 1).ProEstatus = "2" Then
                    DgridAspirantes.Item(9, DgridAspirantes.RowCount - 1).Value = False
                ElseIf IUPrincipal.Personas.Item(i + 1).ProEstatus = "8" Then
                    DgridAspirantes.Item(9, DgridAspirantes.RowCount - 1).Value = True
                End If
            End If
            Mostrar = False
            i = i + 1
        End While
    End Sub

    Private Sub ChkProfesion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkProfesion.CheckedChanged
        CmbProfesion.Enabled = ChkProfesion.Checked
    End Sub


    Private Sub ChkSexo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSexo.CheckedChanged
        CmbSexo.Enabled = ChkSexo.Checked
    End Sub

    Private Sub ChkRif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRif.CheckedChanged

    End Sub


    Private Sub ChkEdoCivil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEdoCivil.CheckedChanged
        CmbEdoCivil.Enabled = ChkEdoCivil.Checked
    End Sub

    Private Sub CmbProfesion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProfesion.KeyDown
        If e.KeyValue = 13 Then
            CmbProfesion.Items.Add(CmbProfesion.Text)
            IUPrincipal.Profesion = New ClaseProfesion
            IUPrincipal.Profesion.ProDescripcion = CmbProfesion.Text
            IUPrincipal.Profesiones.Add(IUPrincipal.Profesion)
            CmbProfesion.SelectedIndex = CmbProfesion.Items.Count - 1
        End If
    End Sub

    Private Sub DgridAspirantes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgridAspirantes.CellClick
        TlsBtnContrato.Enabled = False
        TlsBtnExamen.Enabled = True
        If DgridAspirantes.Item(8, DgridAspirantes.CurrentRow.Index).Value = "1" Then
            TlsBtnExamen.Text = "Examen Laboratorio"
        ElseIf DgridAspirantes.Item(8, DgridAspirantes.CurrentRow.Index).Value = "2" Then
            TlsBtnExamen.Text = "Examen Pre-Empleo"
        ElseIf DgridAspirantes.Item(8, DgridAspirantes.CurrentRow.Index).Value = "8" Then
            TlsBtnExamen.Enabled = False
            TlsBtnContrato.Enabled = True
        End If
    End Sub

    Private Sub TlsBtnContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnContrato.Click
        IUGenerarContratos.LblDatoCedula.Text = DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value
        IUGenerarContratos.LblDatoNombre.Text = DgridAspirantes.Item(1, DgridAspirantes.CurrentRow.Index).Value + " " + DgridAspirantes.Item(2, DgridAspirantes.CurrentRow.Index).Value
        IUGenerarContratos.LblPosicion.Text = DgridAspirantes.Item(7, DgridAspirantes.CurrentRow.Index).Value
        IUGenerarContratos.LblPosicionContrato.Text = 0
        IUGenerarContratos.MdiParent = IUPrincipal
        IUGenerarContratos.Show()
        IUGenerarContratos.Buscar_Contrato(DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value)
        IUGenerarContratos.TlsBtnNuevo.Enabled = True
        IUGenerarContratos.BarraNavegacion.Enabled = True
    End Sub



    Private Sub TlsBtnExamen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnExamen.Click
        Dim Parametro1 As New ParameterValues
        Dim ParametroNombre As New ParameterDiscreteValue
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If CrystalReportViewer1.Visible = True Then
            CrystalReportViewer1.Hide()
            TlsBtnCancelar.Enabled = False
            TlsBtnContrato.Enabled = False
            TlsBtnBuscar.Enabled = True
            TlsBtnExamen.Enabled = True
            TlsBtnExamen.Text = "Examen Laboratorio"
            Me.WindowState = FormWindowState.Normal
            Buscar(2)
        ElseIf CrystalReportViewer2.Visible = True Then
            CrystalReportViewer2.Hide()
            TlsBtnCancelar.Enabled = False
            TlsBtnContrato.Enabled = False
            TlsBtnBuscar.Enabled = True
            TlsBtnExamen.Enabled = True
            TlsBtnExamen.Text = "Examen Pre-Empleo"
            Me.WindowState = FormWindowState.Normal
            Buscar(2)
        Else
            If TlsBtnExamen.Text = "Examen Laboratorio" Then
                If MsgBox("¿Confirma que desea Pre-Seleccionar al empleado?", MsgBoxStyle.YesNoCancel, "Merca Facil C.A") = MsgBoxResult.Yes Then
                    'bConexionExitosa = IUPrincipal.Conexion.Conectar
                    'dr = Conexion.Seleccionar("select `Int_fk_Codigo_Departamento` from nomina.personas where `Txt_Cedula` = '" + DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value + "'")
                    'If (dr.Read()) Then
                    '    If dr("Num_Codigo") = "NULL" Then
                    '        asignar_departamento(DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value)
                    '    End If

                    'Else
                    '    MsgBox("Error Al Iniciar Sesión Verifique su Nombre de Usuario y Password")
                    'End If
                    'Conexion.Cerrar_Conexion()
                    TlsBtnCancelar.Enabled = False
                    TlsBtnContrato.Enabled = False
                    TlsBtnBuscar.Enabled = False
                    TlsBtnExamen.Enabled = True
                    TlsBtnExamen.Text = "Regresar"
                    bConexionExitosa = IUPrincipal.Conexion.Conectar
                    If bConexionExitosa Then
                        IUPrincipal.Conexion.Insertar("UPDATE `PERSONAS_TEMP` set `Int_Estatus` = '2' where `Txt_Cedula`= '" + DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value + "';")
                    End If
                    IUPrincipal.Personas.Item(DgridAspirantes.Item(7, DgridAspirantes.CurrentRow.Index).Value).ProEstatus = "2"
                    ParametroNombre.Value = DgridAspirantes.Item(1, DgridAspirantes.CurrentRow.Index).Value + " " + DgridAspirantes.Item(2, DgridAspirantes.CurrentRow.Index).Value
                    Parametro1.Add(ParametroNombre)
                    examenLaboratorio1.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
                    CrystalReportViewer1.ReportSource = examenLaboratorio1
                    CrystalReportViewer1.Show()
                    Me.WindowState = FormWindowState.Maximized
                    CrystalReportViewer1.Dock = DockStyle.Fill
                End If
            ElseIf TlsBtnExamen.Text = "Examen Pre-Empleo" Then
                TlsBtnCancelar.Enabled = False
                TlsBtnContrato.Enabled = False
                TlsBtnBuscar.Enabled = False
                TlsBtnExamen.Enabled = True
                TlsBtnExamen.Text = "Regresar"
                bConexionExitosa = IUPrincipal.Conexion.Conectar
                If bConexionExitosa Then
                    IUPrincipal.Conexion.Insertar("UPDATE `PERSONAS_TEMP` set `Int_Estatus` = '8' where `Txt_Cedula`= '" + DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value + "';")
                End If
                IUPrincipal.Personas.Item(DgridAspirantes.Item(7, DgridAspirantes.CurrentRow.Index).Value).ProEstatus = "8"
                ParametroNombre.Value = DgridAspirantes.Item(1, DgridAspirantes.CurrentRow.Index).Value + " " + DgridAspirantes.Item(2, DgridAspirantes.CurrentRow.Index).Value
                Parametro1.Add(ParametroNombre)
                examenPreEmpleo1.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
                CrystalReportViewer2.ReportSource = examenPreEmpleo1
                CrystalReportViewer2.Show()
                Me.WindowState = FormWindowState.Maximized
                CrystalReportViewer2.Dock = DockStyle.Fill
            End If
        End If


        'If TlsBtnExamen.Text = "Examen Laboratorio" Then
        '    If CrystalReportViewer1.Visible = True Then
        '        CrystalReportViewer1.Hide()
        '        TlsBtnCancelar.Enabled = False
        '        TlsBtnContrato.Enabled = False
        '        TlsBtnBuscar.Enabled = True
        '        TlsBtnExamen.Enabled = True
        '        TlsBtnExamen.Text = "Examen Laboratorio"
        '        Me.WindowState = FormWindowState.Normal
        '    Else
        '        If MsgBox("¿Confirma que desea Pre-Seleccionar al empleado?", MsgBoxStyle.YesNoCancel, "Merca Facil C.A") = MsgBoxResult.Yes Then
        '            TlsBtnCancelar.Enabled = False
        '            TlsBtnContrato.Enabled = False
        '            TlsBtnBuscar.Enabled = False
        '            TlsBtnExamen.Enabled = True
        '            TlsBtnExamen.Text = "Regresar"
        '            bConexionExitosa = IUPrincipal.Conexion.Conectar
        '            If bConexionExitosa Then
        '                IUPrincipal.Conexion.Insertar("UPDATE `PERSONAS` set `Int_Estatus` = '2' where `Txt_Cedula`= '" + DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value + "';")
        '            End If
        '            IUPrincipal.Personas.Item(DgridAspirantes.Item(7, DgridAspirantes.CurrentRow.Index).Value).ProEstatus = "2"
        '            ParametroNombre.Value = DgridAspirantes.Item(1, DgridAspirantes.CurrentRow.Index).Value + " " + DgridAspirantes.Item(2, DgridAspirantes.CurrentRow.Index).Value
        '            Parametro1.Add(ParametroNombre)
        '            examenLaboratorio1.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
        '            CrystalReportViewer1.ReportSource = examenLaboratorio1
        '            CrystalReportViewer1.Show()
        '            Me.WindowState = FormWindowState.Maximized
        '            CrystalReportViewer1.Dock = DockStyle.Fill
        '        End If
        '    End If
        'Else
        '    If CrystalReportViewer2.Visible = True Then
        '        CrystalReportViewer2.Hide()
        '        TlsBtnCancelar.Enabled = False
        '        TlsBtnContrato.Enabled = False
        '        TlsBtnBuscar.Enabled = True
        '        TlsBtnExamen.Enabled = True
        '        TlsBtnExamen.Text = "Examen Pre-Empleo"
        '        Me.WindowState = FormWindowState.Normal
        '    Else
        '        TlsBtnCancelar.Enabled = False
        '        TlsBtnContrato.Enabled = False
        '        TlsBtnBuscar.Enabled = False
        '        TlsBtnExamen.Enabled = True
        '        TlsBtnExamen.Text = "Regresar"
        '        bConexionExitosa = IUPrincipal.Conexion.Conectar
        '        If bConexionExitosa Then
        '            IUPrincipal.Conexion.Insertar("UPDATE `PERSONAS` set `Int_Estatus` = '8' where `Txt_Cedula`= '" + DgridAspirantes.Item(0, DgridAspirantes.CurrentRow.Index).Value + "';")
        '        End If
        '        IUPrincipal.Personas.Item(DgridAspirantes.Item(7, DgridAspirantes.CurrentRow.Index).Value).ProEstatus = "8"
        '        ParametroNombre.Value = DgridAspirantes.Item(1, DgridAspirantes.CurrentRow.Index).Value + " " + DgridAspirantes.Item(2, DgridAspirantes.CurrentRow.Index).Value
        '        Parametro1.Add(ParametroNombre)
        '        examenPreEmpleo1.DataDefinition.ParameterFields("Nombre").ApplyCurrentValues(Parametro1)
        '        CrystalReportViewer2.ReportSource = examenPreEmpleo1
        '        CrystalReportViewer2.Show()
        '        Me.WindowState = FormWindowState.Maximized
        '        CrystalReportViewer2.Dock = DockStyle.Fill
        '    End If
        'End If

    End Sub

    Private Sub ChkPre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPre.CheckedChanged
        If ChkPre.Checked = True Then
            CmbEdoCivil.Enabled = False
            CmbProfesion.Enabled = False
            CmbSexo.Enabled = False
            ChkCertificado.Enabled = False
            ChkEdoCivil.Enabled = False
            ChkProfesion.Enabled = False
            ChkSexo.Enabled = False
            ChkRif.Enabled = False
        Else
            CmbEdoCivil.Enabled = True
            CmbProfesion.Enabled = True
            CmbSexo.Enabled = True
            ChkCertificado.Enabled = True
            ChkEdoCivil.Enabled = True
            ChkProfesion.Enabled = True
            ChkSexo.Enabled = True
            ChkRif.Enabled = True
        End If
    End Sub
End Class