Public Class IUCitasPreEmpleo
    Public Conexion As ClaseBaseDatos
    Private PanelMostrado As Boolean
    Private fecha2 As Date

    Private Sub cargardgrid()
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
            'If IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" And IUPrincipal.Personas.Item(i + 1).ProFechaPreEmpleo = "1900-01-01" Then
            If IUPrincipal.Personas.Item(i + 1).ProEstatus = "1" Then
                Mostrar = True
            End If
            If Mostrar Then
                DgridAspirantes.Rows.Add()
                DgridAspirantes.Item(0, DgridAspirantes.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
                DgridAspirantes.Item(1, DgridAspirantes.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
                DgridAspirantes.Item(3, DgridAspirantes.RowCount - 1).Value = i + 1
            End If
            Mostrar = False
            i = i + 1
        End While
    End Sub

    Private Sub cargargrid2(ByVal fecha As Date)
        DgridAspirantes2.Rows.Clear()
        Dim i As Integer = 0
        Dim Mostrar As Boolean = False
        Dim profesion As Boolean = False
        Dim edocivil As Boolean = False
        Dim sexo As Boolean = False
        Dim certif As Boolean = False
        Dim rif As Boolean = False
        Dim pre As Boolean = False

        While i < IUPrincipal.Personas.Count
            If IUPrincipal.Personas.Item(i + 1).ProEstatus = "2" And IUPrincipal.Personas.Item(i + 1).ProFechaPreEmpleo = fecha.ToString("yyyy-MM-dd") Then
                Mostrar = True
            End If
            If Mostrar Then
                DgridAspirantes2.Rows.Add()
                DgridAspirantes2.Item(0, DgridAspirantes2.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProCedula
                DgridAspirantes2.Item(1, DgridAspirantes2.RowCount - 1).Value = IUPrincipal.Personas.Item(i + 1).ProNombres + " " + IUPrincipal.Personas.Item(i + 1).ProApellidos
                DgridAspirantes2.Item(2, DgridAspirantes2.RowCount - 1).Value = i + 1
            End If
            Mostrar = False
            i = i + 1
        End While
    End Sub

    Private Sub IUCitasPreEmpleo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargardgrid()
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar
        Dim query As String
        query = "UPDATE `nomina`.`personas_temp` SET `Int_Estatus`='2', `Dte_Fechapreempleo`='" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "' WHERE"
        With DgridAspirantes
            For i As Integer = 0 To .RowCount - 1
                If .Item(2, i).Value = True Then
                    IUPrincipal.Personas.Item(.Item(3, i).Value).ProFechaPreEmpleo = DateTimePicker1.Value.ToString("yyyy-MM-dd")
                    IUPrincipal.Personas.Item(.Item(3, i).Value).proEstatus = "2"
                    query = query + " `Txt_Cedula` = '" + .Item(0, i).Value + "' or "
                End If
            Next
        End With
        query = query.Substring(0, query.Length - 4)
        query = query + ";"
        bConexionExitosa = IUPrincipal.Conexion.Conectar
        If bConexionExitosa Then
            IUPrincipal.Conexion.Insertar(query)
        End If
        cargardgrid()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        PanAsignarCitas.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        fecha2 = e.Start.Date.ToShortDateString
        cargargrid2(e.Start.Date.ToShortDateString)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        cargargrid2(Date.Today)
        PanAsignarCitas.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PanelMostrado Then
            PanNuevaCita.Left = PanNuevaCita.Left + 50
        Else
            If PanNuevaCita.Left - 50 < 28 Then
                PanNuevaCita.Left = 28
            Else
                PanNuevaCita.Left = PanNuevaCita.Left - 50
            End If

        End If
        If PanNuevaCita.Left <= 28 Then
            Timer1.Stop()
            PanelMostrado = True
        End If
        If PanNuevaCita.Left >= 494 Then
            Timer1.Stop()
            PanelMostrado = False
        End If
    End Sub

    Private Sub DgridAspirantes2_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgridAspirantes2.CellContentDoubleClick
        Timer1.Start()
    End Sub

    Private Sub BtnGuardarNuevaCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarNuevaCita.Click
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar
        Dim query As String
        query = "UPDATE `nomina`.`personas_temp` SET `Dte_Fechapreempleo`='" + DateTimePicker2.Value.ToString("yyyy-MM-dd") + "' WHERE `Txt_Cedula` = '" + DgridAspirantes2.Item(0, DgridAspirantes2.CurrentRow.Index).Value + "';"
        IUPrincipal.Personas.Item(DgridAspirantes2.Item(2, DgridAspirantes2.CurrentRow.Index).Value).ProFechaPreEmpleo = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        bConexionExitosa = IUPrincipal.Conexion.Conectar
        If bConexionExitosa Then
            IUPrincipal.Conexion.Insertar(query)
        End If
        cargargrid2(fecha2)
        Timer1.Start()
    End Sub

    Private Sub BtnCancelarNuevacita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarNuevacita.Click
        Timer1.Start()
    End Sub
End Class