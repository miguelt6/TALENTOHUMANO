Imports CrystalDecisions.Shared
Public Class IUAsignarHorarios
    Public Conexion As ClaseBaseDatos
    Dim diadesde As Integer
    Dim diahasta As Integer
    Dim anho As Integer = Today.Year
    Dim mes As Integer = Today.Month
    Dim dia As Integer = Today.Day
    Dim horario As String
    Dim hbono As Double
    Dim indhorario As Integer
    Public DTHorario As System.Data.DataTable

    Public Function DameDataTableDeDataGridView(ByVal miDataGrid As DataGridView) As System.Data.DataTable
        Dim dtNuevo As System.Data.DataTable = New System.Data.DataTable
        Dim colNueva As System.Data.DataColumn
        Dim filaNueva As System.Data.DataRow
        Dim numCols As Integer
        Dim hay As Integer = 0
        'Dim dset As New DSIncidencias
        Dim tinc As New DataTable '= dset.Tables.Add("Incid")

        ' Replicamos las columnas del DataGridView en el DataTable nuevo
        For Each dataGridViewCol As DataGridViewColumn In miDataGrid.Columns
            colNueva = New System.Data.DataColumn(dataGridViewCol.Name)

            'colNueva = New System.Data.DataColumn(dataGridViewCol.DataPropertyName, dataGridViewCol.ValueType)
            'dtNuevo.Columns.Add(colNueva)
            tinc.Columns.Add(colNueva)
        Next

        numCols = tinc.Columns.Count

        ' Rellenamos los valores del DataTable nuevo con los valores de las celdas del DataGridView

        For Each filaDatos As DataGridViewRow In miDataGrid.Rows
            'hay = 0
            'If filaDatos.DataBoundItem IsNot Nothing Then
            filaNueva = tinc.NewRow()
            For i As Integer = 0 To numCols - 1
                'If filaDatos.Cells(i).Value <> "" Then
                '    hay = 1
                'End If
                If CStr(filaDatos.Cells(i).Value) = "" Then
                    filaNueva(i) = "-"
                Else
                    If i < 2 Then
                        filaNueva(i) = CStr(filaDatos.Cells(i).Value)
                    Else
                        filaNueva(i) = CStr(filaDatos.Cells(i).Value)
                    End If
                End If

            Next
            tinc.Rows.Add(filaNueva)
            'If hay = 1 Then
            '    'dtNuevo.Rows.Add(filaNueva)
            '    tinc.Rows.Add(filaNueva)
            'End If

            'End If
        Next
        'DSIncidencias.IncidenciasRow rowincidencias

        Return tinc
    End Function

    Private Sub IUAsignarHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim d As Integer = 0
        Dim n As Integer = 0
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Dim g As Graphics
        Dim max As Integer = 0
        Dim fuente As Font
        Dim cadena As String
        Dim horad As String
        Dim horah As String
        Dim min As String
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `sub_departamentos`; ")
            While dr.Read()
                Label2.Text = dr(1)
                g = Label2.CreateGraphics()
                fuente = Label2.Font
                If (g.MeasureString(dr(1), CmbDepartamento.Font).Width > max) Then
                    max = g.MeasureString(dr(1), CmbDepartamento.Font).Width
                    cadena = dr(1)
                End If
                CmbDepartamento.Items.Add(dr(1))
            End While
            CmbDepartamento.DropDownWidth = max + 18
            'dr.Read()
        End If
        Conexion.Cerrar_Conexion()
        dr.Dispose()
        dr.Close()
        'CmbDepartamento.Items.Add("")
        'While i < IUPrincipal.Departamentos.Count
        '    CmbDepartamento.Items.Add(IUPrincipal.Departamentos(i + 1).ProNombre)
        '    i = i + 1
        'End While
        'CmbDepartamento.SelectedIndex = 0
        'i = 0
        CmbQuincena.Items.Add("")
        Label2.Text = ""

        If dia <= 15 Then
            mes = Today.Month
            CmbQuincena.Items.Add("SEGUNDA QUINCENA DE " + MonthName(mes).ToUpper)
            Label2.Text = "SEGUNDA QUINCENA DE " + MonthName(mes).ToUpper
            g = Label2.CreateGraphics()
            CmbQuincena.DropDownWidth = g.MeasureString("SEGUNDA QUINCENA DE " + MonthName(mes).ToUpper, CmbDepartamento.Font).Width + 18
            diadesde = 16
            If mes = 1 Or mes = 3 Or mes = 5 Or mes = 7 Or mes = 8 Or mes = 10 Or mes = 12 Then
                diahasta = 31
            ElseIf mes = 4 Or mes = 6 Or mes = 9 Or mes = 11 Then
                diahasta = 30
            Else
                If IsDate("29/02" & CStr(anho)) Then
                    diahasta = 29
                Else
                    diahasta = 28
                End If
            End If
        ElseIf dia > 15 And dia <= 31 Then
            mes = Today.Month + 1
            CmbQuincena.Items.Add("PRIMERA QUINCENA DE " + MonthName(mes).ToUpper)
            Label2.Text = "PRIMERA QUINCENA DE " + MonthName(mes).ToUpper
            g = Label2.CreateGraphics()
            CmbQuincena.DropDownWidth = g.MeasureString("SEGUNDA QUINCENA DE " + MonthName(mes).ToUpper, CmbDepartamento.Font).Width + 18
            diadesde = 1
            diahasta = 15
        End If
        CmbQuincena.SelectedIndex = 0
        'While mes <= 12
        '    If dias < 15 And i = 0 Then
        '        CmbQuincena.Items.Add("Primera quincena de " + MonthName(mes))
        '    ElseIf i > 0 Then
        '        CmbQuincena.Items.Add("Primera quincena de " + MonthName(mes))
        '        CmbQuincena.Items.Add("Segunda quincena de " + MonthName(mes))
        '    End If
        '    i = i + 1
        '    mes = mes + 1
        'End While
        CmbNocturno.Items.Add("")
        CmbDiurno.Items.Add("")
        bConexionExitosa = Conexion.Conectar
        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT `horario`.`id`,  `horario`.`Int_Hora_Entrada`, `horario`.`Int_Hora_Salida`, `horario`.`Horas_Descanso`, `horario`.`Horas_Bono_Nocturno`, `horario`.`Horas_Trabajadas`, date_format(`horario`.`Dte_Hora_Entrada`,'%H:%i'), `horario`.`Fk_Id_Dpto` FROM `nomina`.`horario`;")
            i = 1
            While dr.Read()
                horad = dr(1).ToString
                horah = dr(2).ToString
                min = ""
                If dr(3) < 60 And dr(3) > 0 Then
                    min = " Descanso: 1/2 hora"
                ElseIf dr(3) >= 60 Then
                    min = " Descanso: " & dr(3) / 60 & " hora"
                End If
                If dr(4) = "0" Then
                    CmbDiurno.Items.Add(dr(1).ToString + " a " + dr(2).ToString + min)
                    Dgvhdiur.Rows.Add(d, dr(5), dr(3), dr(4), dr(0))
                    d = d + 1
                Else
                    CmbNocturno.Items.Add(dr(1).ToString + " a " + dr(2).ToString + min)
                    Dgvhnoct.Rows.Add(n, dr(5), dr(3), dr(4), dr(0))
                    n = n + 1
                End If
                'Label2.Text = dr(1)
                'g = Label2.CreateGraphics()
                'fuente = Label2.Font
                'If (g.MeasureString(dr(1), CmbDepartamento.Font).Width > max) Then
                ' max = g.MeasureString(dr(1), CmbDepartamento.Font).Width
                ' cadena = dr(1)
                ' End If

                'CmbDepartamento.Items.Add(dr(1))
                i = i + 1
            End While
            CmbDepartamento.DropDownWidth = max + 18
            'dr.Read()
        End If
        CmbNocturno.SelectedIndex = 0
        CmbDiurno.SelectedIndex = 0
        Conexion.Cerrar_Conexion()
        dr.Dispose()
        dr.Close()

    End Sub
    Private Sub BtnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIr.Click
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Dim i As Integer = 1
        Dim j As Integer
        Dim k As Integer = 1
        Dim fecha As Date
        Dim nomdia As String
        Dim columna As DataGridViewColumn
        Dim columna2 As DataGridViewColumn
        Dim columna3 As DataGridViewColumn
        Dim celda As DataGridViewCell
        Dim ancho As Integer
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar
        DgvHorario.Rows.Clear()
        DgvHorario.Columns.Clear()
        columna = New DataGridViewColumn()
        columna.Width = 300
        columna.Name = "EMPLEADO"
        columna.HeaderText = "EMPLEADO"
        celda = New DataGridViewTextBoxCell
        columna.CellTemplate = celda
        DgvHorario.Columns.Add(columna)
        For j = diadesde To diahasta
            fecha = DateSerial(anho, mes, j)
            nomdia = fecha.DayOfWeek.ToString.ToUpper
            If nomdia = "SATURDAY" Then
                nomdia = "SABADO"
            ElseIf nomdia = "SUNDAY" Then
                nomdia = "DOMINGO"
            ElseIf nomdia = "MONDAY" Then
                nomdia = "LUNES"
            ElseIf nomdia = "TUESDAY" Then
                nomdia = "MARTES"
            ElseIf nomdia = "WEDNESDAY" Then
                nomdia = "MIERCOLES"
            ElseIf nomdia = "THURSDAY" Then
                nomdia = "JUEVES"
            ElseIf nomdia = "FRIDAY" Then
                nomdia = "VIERNES"
            End If
            columna = New DataGridViewColumn()
            columna2 = New DataGridViewColumn()
            columna3 = New DataGridViewColumn()
            columna.Width = 80
            columna2.Width = 80
            columna.Name = "DIA" & k
            columna2.Name = fecha.ToString("d")
            columna.HeaderText = nomdia + " " + j.ToString
            columna2.HeaderText = fecha.ToString("d")
            celda = New DataGridViewTextBoxCell
            columna.CellTemplate = celda
            columna2.CellTemplate = celda
            columna3.CellTemplate = celda
            columna3.HeaderText = fecha.ToString("d")
            columna.DefaultCellStyle.Font = New Font("Arial", 8.5F, GraphicsUnit.Pixel)
            'DgvHorario.Columns.Add("dia" & j, nomdia + " " + j.ToString)
            DgvHorario.Columns.Add(columna)
            'columna2 = columna
            Dgvhorario2.Columns.Add(columna2)
            Dgvhorario3.Columns.Add(columna3)
            k = k + 1
        Next
        columna = New DataGridViewColumn()
        columna.Width = 80
        columna.Name = "HORAS BONO"
        columna.HeaderText = "HORAS BONO"
        celda = New DataGridViewTextBoxCell
        columna.CellTemplate = celda
        columna.DefaultCellStyle.Font = New Font("Arial", 8.5F, GraphicsUnit.Pixel)
        'DgvHorario.Columns.Add("dia" & j, nomdia + " " + j.ToString)
        DgvHorario.Columns.Add(columna)
        columna = New DataGridViewColumn()
        columna.Width = 100
        columna.Name = "Firma"
        columna.HeaderText = "Firma"
        celda = New DataGridViewTextBoxCell
        columna.CellTemplate = celda
        columna.DefaultCellStyle.Font = New Font("Arial", 8.5F, GraphicsUnit.Pixel)
        DgvHorario.Columns.Add(columna)
        If bConexionExitosa Then
            dr = Conexion.Seleccionar("select distinct personas_temp.txt_nombres, personas_temp.txt_apellidos, personas_temp.txt_cedula, cargos.txt_nombre from personas_temp, contratos, cargos where personas_temp.txt_cedula = contratos.txt_fk_cedula and contratos.int_fk_codgio_cargo = cargos.num_codigo and cargos.num_codigo_subdpto = '" & CmbDepartamento.SelectedIndex + 3 & "' and (personas_temp.int_estatus='4' or personas_temp.int_estatus='5') and contratos.fk_id_cod_localidad='" & CmbLocalidad.SelectedIndex & "';")
            While dr.Read()
                'DgvHorario.Rows.Add(i, dr(0) + " " + dr(1), dr(2), dr(3))
                DgvHorario.Rows.Add(dr(0) + " " + dr(1))
                Dgvhorario2.Rows.Add(dr(2))
                Dgvhorario3.Rows.Add(dr(2))
                i = i + 1
            End While
            'dr.Read()
        End If
        Conexion.Cerrar_Conexion()
        'DgvHorario.Columns(0).Width = 300
        'Me.Width=DgvHorario.ColumnCount
        'For i = 0 To DgvHorario.ColumnCount - 1
        '    ancho = ancho + DgvHorario.Columns(i).Width
        'Next
        'DgvHorario.Width = ancho
        'Me.Width = ancho + 20
        dr.Dispose()
        dr.Close()
    End Sub

    Private Sub DgvHorario_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvHorario.CellContentDoubleClick

    End Sub

    Private Sub DgvHorario_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvHorario.CellDoubleClick
        If e.ColumnIndex > 0 Then
            If DgvHorario.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "LIBRE" Then
                DgvHorario.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                Dgvhorario2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                Dgvhorario3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
            Else
                If Dgvhorario2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                    DgvHorario.Rows(e.RowIndex).Cells("HORAS BONO").Value = DgvHorario.Rows(e.RowIndex).Cells("HORAS BONO").Value - Dgvhorario2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                End If
                DgvHorario.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "LIBRE"
                Dgvhorario2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                Dgvhorario3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
            End If
        End If
    End Sub

    Private Sub CmbDiurno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDiurno.SelectedIndexChanged
        If CmbDiurno.SelectedIndex > 0 Then
            horario = CmbDiurno.SelectedItem
            hbono = 0
            indhorario = Dgvhdiur.Rows(CmbDiurno.SelectedIndex - 1).Cells(4).Value
            CmbNocturno.SelectedIndex = 0
        End If
    End Sub

    Private Sub CmbNocturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNocturno.SelectedIndexChanged
        If CmbNocturno.SelectedIndex > 0 Then
            horario = CmbNocturno.SelectedItem
            hbono = Dgvhnoct.Rows(CmbNocturno.SelectedIndex - 1).Cells(3).Value
            indhorario = Dgvhnoct.Rows(CmbNocturno.SelectedIndex - 1).Cells(4).Value
            CmbDiurno.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim hor As String
        'Dim celda As DataGridViewCell
        'Dim estilo As DataGridViewCellStyle
        'estilo.Font.Size = 5
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    If Dgvhorario2.Rows(j).Cells(i).Value <> 0 Then
                        DgvHorario.Rows(j).Cells("HORAS BONO").Value = DgvHorario.Rows(j).Cells("HORAS BONO").Value - Dgvhorario2.Rows(j).Cells(i).Value
                        Dgvhorario3.Rows(j).Cells(i).Value = indhorario
                    End If
                    'posicion = InStr("Estoy tomando mate", "mate")
                    'hor =Left(horario,instr(
                    If InStr(horario, "Descanso") Then
                        horario = horario.Substring(0, InStr(horario, "Descanso") - 1)
                    End If
                    DgvHorario.Rows(j).Cells(i).Value = horario
                    DgvHorario.Rows(j).Cells("HORAS BONO").Value = DgvHorario.Rows(j).Cells("HORAS BONO").Value + hbono
                    Dgvhorario2.Rows(j).Cells(i).Value = hbono
                    Dgvhorario3.Rows(j).Cells(i).Value = indhorario
                End If
            Next
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim reportehor16 As New Horario16
        Dim reportehor15 As New Horario15
        Dim reportehor14 As New Horario14
        Dim reportehor13 As New Horario13
        Dim Parametro As New ParameterValues
        Dim ParametroFechas As New ParameterDiscreteValue
        Dim Parametro1 As New ParameterValues
        Dim ParametroDia1 As New ParameterDiscreteValue
        Dim Parametro2 As New ParameterValues
        Dim ParametroDia2 As New ParameterDiscreteValue
        Dim Parametro3 As New ParameterValues
        Dim ParametroDia3 As New ParameterDiscreteValue
        Dim Parametro4 As New ParameterValues
        Dim ParametroDia4 As New ParameterDiscreteValue
        Dim Parametro5 As New ParameterValues
        Dim ParametroDia5 As New ParameterDiscreteValue
        Dim Parametro6 As New ParameterValues
        Dim ParametroDia6 As New ParameterDiscreteValue
        Dim Parametro7 As New ParameterValues
        Dim ParametroDia7 As New ParameterDiscreteValue
        Dim Parametro8 As New ParameterValues
        Dim ParametroDia8 As New ParameterDiscreteValue
        Dim Parametro9 As New ParameterValues
        Dim ParametroDia9 As New ParameterDiscreteValue
        Dim Parametro10 As New ParameterValues
        Dim ParametroDia10 As New ParameterDiscreteValue
        Dim Parametro11 As New ParameterValues
        Dim ParametroDia11 As New ParameterDiscreteValue
        Dim Parametro12 As New ParameterValues
        Dim ParametroDia12 As New ParameterDiscreteValue
        Dim Parametro13 As New ParameterValues
        Dim ParametroDia13 As New ParameterDiscreteValue
        Dim Parametro14 As New ParameterValues
        Dim ParametroDia14 As New ParameterDiscreteValue
        Dim Parametro15 As New ParameterValues
        Dim ParametroDia15 As New ParameterDiscreteValue
        Dim Parametro16 As New ParameterValues
        Dim ParametroDia16 As New ParameterDiscreteValue
        Dim i As Integer = 0
        Dim fecha As Date
        Dim nomdia As String

        ParametroFechas.Value = Label2.Text
        Parametro.Add(ParametroFechas)

        For i = 0 To DgvHorario.Columns.Count - 3
            fecha = DateSerial(anho, mes, diadesde + i)
            'fecha = DateAdd(DateInterval.Day, i, DateTimePicker1.Value)
            nomdia = fecha.DayOfWeek.ToString.ToUpper
            If nomdia = "SATURDAY" Then
                nomdia = "SABADO"
            ElseIf nomdia = "SUNDAY" Then
                nomdia = "DOMINGO"
            ElseIf nomdia = "MONDAY" Then
                nomdia = "LUNES"
            ElseIf nomdia = "TUESDAY" Then
                nomdia = "MARTES"
            ElseIf nomdia = "WEDNESDAY" Then
                nomdia = "MIERCOLES"
            ElseIf nomdia = "THURSDAY" Then
                nomdia = "JUEVES"
            ElseIf nomdia = "FRIDAY" Then
                nomdia = "VIERNES"
            End If

            If i = 0 Then
                ParametroDia1.Value = nomdia + " " + fecha.Day.ToString
                Parametro1.Add(ParametroDia1)
            ElseIf i = 1 Then
                ParametroDia2.Value = nomdia + " " + fecha.Day.ToString
                Parametro2.Add(ParametroDia2)
            ElseIf i = 2 Then
                ParametroDia3.Value = nomdia + " " + fecha.Day.ToString
                Parametro3.Add(ParametroDia3)
            ElseIf i = 3 Then
                ParametroDia4.Value = nomdia + " " + fecha.Day.ToString
                Parametro4.Add(ParametroDia4)
            ElseIf i = 4 Then
                ParametroDia5.Value = nomdia + " " + fecha.Day.ToString
                Parametro5.Add(ParametroDia5)
            ElseIf i = 5 Then
                ParametroDia6.Value = nomdia + " " + fecha.Day.ToString
                Parametro6.Add(ParametroDia6)
            ElseIf i = 6 Then
                ParametroDia7.Value = nomdia + " " + fecha.Day.ToString
                Parametro7.Add(ParametroDia7)
            ElseIf i = 7 Then
                ParametroDia8.Value = nomdia + " " + fecha.Day.ToString
                Parametro8.Add(ParametroDia8)
            ElseIf i = 8 Then
                ParametroDia9.Value = nomdia + " " + fecha.Day.ToString
                Parametro9.Add(ParametroDia9)
            ElseIf i = 9 Then
                ParametroDia10.Value = nomdia + " " + fecha.Day.ToString
                Parametro10.Add(ParametroDia10)
            ElseIf i = 10 Then
                ParametroDia11.Value = nomdia + " " + fecha.Day.ToString
                Parametro11.Add(ParametroDia11)
            ElseIf i = 11 Then
                ParametroDia12.Value = nomdia + " " + fecha.Day.ToString
                Parametro12.Add(ParametroDia12)
            ElseIf i = 12 Then
                ParametroDia13.Value = nomdia + " " + fecha.Day.ToString
                Parametro13.Add(ParametroDia13)
            ElseIf i = 13 Then
                ParametroDia14.Value = nomdia + " " + fecha.Day.ToString
                Parametro14.Add(ParametroDia14)
            ElseIf i = 14 Then
                ParametroDia15.Value = nomdia + " " + fecha.Day.ToString
                Parametro15.Add(ParametroDia15)
            ElseIf i = 15 Then
                ParametroDia16.Value = nomdia + " " + fecha.Day.ToString
                Parametro16.Add(ParametroDia16)
            End If
        Next

        DTHorario = DameDataTableDeDataGridView(DgvHorario)
        If DgvHorario.Columns.Count - 3 = 16 Then
            reportehor16.SetDataSource(DTHorario)
            'reportehor16.DataDefinition.ParameterFields("Fecha").ApplyCurrentValues(Parametro)
            reportehor16.DataDefinition.ParameterFields("Dia1").ApplyCurrentValues(Parametro1)
            reportehor16.DataDefinition.ParameterFields("Dia2").ApplyCurrentValues(Parametro2)
            reportehor16.DataDefinition.ParameterFields("Dia3").ApplyCurrentValues(Parametro3)
            reportehor16.DataDefinition.ParameterFields("Dia4").ApplyCurrentValues(Parametro4)
            reportehor16.DataDefinition.ParameterFields("Dia5").ApplyCurrentValues(Parametro5)
            reportehor16.DataDefinition.ParameterFields("Dia6").ApplyCurrentValues(Parametro6)
            reportehor16.DataDefinition.ParameterFields("Dia7").ApplyCurrentValues(Parametro7)
            reportehor16.DataDefinition.ParameterFields("Dia8").ApplyCurrentValues(Parametro8)
            reportehor16.DataDefinition.ParameterFields("Dia9").ApplyCurrentValues(Parametro9)
            reportehor16.DataDefinition.ParameterFields("Dia10").ApplyCurrentValues(Parametro10)
            reportehor16.DataDefinition.ParameterFields("Dia11").ApplyCurrentValues(Parametro11)
            reportehor16.DataDefinition.ParameterFields("Dia12").ApplyCurrentValues(Parametro12)
            reportehor16.DataDefinition.ParameterFields("Dia13").ApplyCurrentValues(Parametro13)
            reportehor16.DataDefinition.ParameterFields("Dia14").ApplyCurrentValues(Parametro14)
            reportehor16.DataDefinition.ParameterFields("Dia15").ApplyCurrentValues(Parametro15)
            reportehor16.DataDefinition.ParameterFields("Dia16").ApplyCurrentValues(Parametro16)
            'reporteinc.SetDataSource(dset.Tables("Incid"))
            CrystalReportViewer1.ReportSource = reportehor16
            CrystalReportViewer1.Show()
            Me.WindowState = FormWindowState.Maximized
            CrystalReportViewer1.Dock = DockStyle.Fill
        ElseIf DgvHorario.Columns.Count - 3 = 15 Then
            reportehor15.SetDataSource(DTHorario)
            'reportehor15.DataDefinition.ParameterFields("Fecha").ApplyCurrentValues(Parametro)
            reportehor15.DataDefinition.ParameterFields("Dia1").ApplyCurrentValues(Parametro1)
            reportehor15.DataDefinition.ParameterFields("Dia2").ApplyCurrentValues(Parametro2)
            reportehor15.DataDefinition.ParameterFields("Dia3").ApplyCurrentValues(Parametro3)
            reportehor15.DataDefinition.ParameterFields("Dia4").ApplyCurrentValues(Parametro4)
            reportehor15.DataDefinition.ParameterFields("Dia5").ApplyCurrentValues(Parametro5)
            reportehor15.DataDefinition.ParameterFields("Dia6").ApplyCurrentValues(Parametro6)
            reportehor15.DataDefinition.ParameterFields("Dia7").ApplyCurrentValues(Parametro7)
            reportehor15.DataDefinition.ParameterFields("Dia8").ApplyCurrentValues(Parametro8)
            reportehor15.DataDefinition.ParameterFields("Dia9").ApplyCurrentValues(Parametro9)
            reportehor15.DataDefinition.ParameterFields("Dia10").ApplyCurrentValues(Parametro10)
            reportehor15.DataDefinition.ParameterFields("Dia11").ApplyCurrentValues(Parametro11)
            reportehor15.DataDefinition.ParameterFields("Dia12").ApplyCurrentValues(Parametro12)
            reportehor15.DataDefinition.ParameterFields("Dia13").ApplyCurrentValues(Parametro13)
            reportehor15.DataDefinition.ParameterFields("Dia14").ApplyCurrentValues(Parametro14)
            reportehor15.DataDefinition.ParameterFields("Dia15").ApplyCurrentValues(Parametro15)
            'reporteinc.SetDataSource(dset.Tables("Incid"))
            CrystalReportViewer1.ReportSource = reportehor15
            CrystalReportViewer1.Show()
            Me.WindowState = FormWindowState.Maximized
            CrystalReportViewer1.Dock = DockStyle.Fill
        ElseIf DgvHorario.Columns.Count - 3 = 14 Then
            reportehor14.SetDataSource(DTHorario)
            'reportehor14.DataDefinition.ParameterFields("Fecha").ApplyCurrentValues(Parametro)
            reportehor14.DataDefinition.ParameterFields("Dia1").ApplyCurrentValues(Parametro1)
            reportehor14.DataDefinition.ParameterFields("Dia2").ApplyCurrentValues(Parametro2)
            reportehor14.DataDefinition.ParameterFields("Dia3").ApplyCurrentValues(Parametro3)
            reportehor14.DataDefinition.ParameterFields("Dia4").ApplyCurrentValues(Parametro4)
            reportehor14.DataDefinition.ParameterFields("Dia5").ApplyCurrentValues(Parametro5)
            reportehor14.DataDefinition.ParameterFields("Dia6").ApplyCurrentValues(Parametro6)
            reportehor14.DataDefinition.ParameterFields("Dia7").ApplyCurrentValues(Parametro7)
            reportehor14.DataDefinition.ParameterFields("Dia8").ApplyCurrentValues(Parametro8)
            reportehor14.DataDefinition.ParameterFields("Dia9").ApplyCurrentValues(Parametro9)
            reportehor14.DataDefinition.ParameterFields("Dia10").ApplyCurrentValues(Parametro10)
            reportehor14.DataDefinition.ParameterFields("Dia11").ApplyCurrentValues(Parametro11)
            reportehor14.DataDefinition.ParameterFields("Dia12").ApplyCurrentValues(Parametro12)
            reportehor14.DataDefinition.ParameterFields("Dia13").ApplyCurrentValues(Parametro13)
            reportehor14.DataDefinition.ParameterFields("Dia14").ApplyCurrentValues(Parametro14)
            'reporteinc.SetDataSource(dset.Tables("Incid"))
            CrystalReportViewer1.ReportSource = reportehor14
            CrystalReportViewer1.Show()
            Me.WindowState = FormWindowState.Maximized
            CrystalReportViewer1.Dock = DockStyle.Fill
        ElseIf DgvHorario.Columns.Count - 3 = 13 Then
            reportehor13.SetDataSource(DTHorario)
            'reportehor13.DataDefinition.ParameterFields("Fecha").ApplyCurrentValues(Parametro)
            reportehor13.DataDefinition.ParameterFields("Dia1").ApplyCurrentValues(Parametro1)
            reportehor13.DataDefinition.ParameterFields("Dia2").ApplyCurrentValues(Parametro2)
            reportehor13.DataDefinition.ParameterFields("Dia3").ApplyCurrentValues(Parametro3)
            reportehor13.DataDefinition.ParameterFields("Dia4").ApplyCurrentValues(Parametro4)
            reportehor13.DataDefinition.ParameterFields("Dia5").ApplyCurrentValues(Parametro5)
            reportehor13.DataDefinition.ParameterFields("Dia6").ApplyCurrentValues(Parametro6)
            reportehor13.DataDefinition.ParameterFields("Dia7").ApplyCurrentValues(Parametro7)
            reportehor13.DataDefinition.ParameterFields("Dia8").ApplyCurrentValues(Parametro8)
            reportehor13.DataDefinition.ParameterFields("Dia9").ApplyCurrentValues(Parametro9)
            reportehor13.DataDefinition.ParameterFields("Dia10").ApplyCurrentValues(Parametro10)
            reportehor13.DataDefinition.ParameterFields("Dia11").ApplyCurrentValues(Parametro11)
            reportehor13.DataDefinition.ParameterFields("Dia12").ApplyCurrentValues(Parametro12)
            reportehor13.DataDefinition.ParameterFields("Dia13").ApplyCurrentValues(Parametro13)
            'reporteinc.SetDataSource(dset.Tables("Incid"))
            CrystalReportViewer1.ReportSource = reportehor13
            CrystalReportViewer1.Show()
            Me.WindowState = FormWindowState.Maximized
            CrystalReportViewer1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub CmbDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDepartamento.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ''Guardar''
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        'MsgBox("INSERT INTO `personal_horario` set `Dte_fecha` = '" + DateTime.Parse(Dgvhorario2.Columns(i).Name).ToString("yyyy-MM-dd") + "',`fk_id_horario` = '" + Dgvhorario3.Rows(j).Cells(i).Value + "',`fk_id_personal` = '" + Dgvhorario2.Rows(j).Cells(0).Value + "';", MsgBoxStyle.Information, "Merca Facil C.A")
        For j As Integer = 0 To DgvHorario.Rows.Count - 1
            For i As Integer = 1 To DgvHorario.Columns.Count - 3
                bConexionExitosa = Conexion.Conectar
                If bConexionExitosa Then
                    'MsgBox("INSERT INTO `personal_horario` set `Dte_fecha` = '" + DateTime.Parse(Dgvhorario2.Columns(i).Name).ToString("yyyy-MM-dd") + "',`fk_id_horario` = '" & Dgvhorario3.Rows(j).Cells(i).Value & "',`fk_id_personal` = '" & Dgvhorario2.Rows(j).Cells(0).Value & "';", MsgBoxStyle.Information, "Merca Facil C.A")
                    Conexion.Insertar("INSERT INTO `personal_horario` set `Dte_fecha` = '" + DateTime.Parse(Dgvhorario2.Columns(i).Name).ToString("yyyy-MM-dd") + "',`fk_id_horario` = '" & Dgvhorario3.Rows(j).Cells(i).Value & "',`fk_id_personal` = '" & Dgvhorario2.Rows(j).Cells(0).Value & "';")
                End If
                Conexion.Cerrar_Conexion()
            Next
        Next
        MsgBox("Registro Exitoso", MsgBoxStyle.Information, "Merca Facil C.A")
    End Sub
End Class