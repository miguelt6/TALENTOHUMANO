Imports CrystalDecisions.Shared
Public Class IUMontarIncidencias
    Public Conexion As ClaseBaseDatos
    Public fechas As Date
    Public incid As String
    Public DTIncidencias As System.Data.DataTable
    Public dset As New DSIncidencias

Public Function DameDataTableDeDataGridView(ByVal miDataGrid as DataGridView) As System.Data.DataTable
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
                If filaDatos.Cells(i).Value = "" Then
                    filaNueva(i) = "-"
                Else
                    If i < 2 Then
                        filaNueva(i) = filaDatos.Cells(i).Value
                    Else
                        filaNueva(i) = dia_detalle(filaDatos.Cells(i).Value)
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

    Public Function dia_detalle(ByVal cadena As String)
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim detalle As String
        result = cadena.Split(stringSeparators, StringSplitOptions.None)
        If result(0) = "AJ" Then
            detalle = detalle + "AJ"
        ElseIf result(0) = "AI" Then
            detalle = detalle + "AI"
        ElseIf result(0) = "RL" Then
            detalle = detalle + "RL"
        ElseIf result(0) = "RNL" Then
            detalle = detalle + "RNL"
        ElseIf result(0) = "PR" Then
            detalle = detalle + "PR"
        ElseIf result(0) = "PNR" Then
            detalle = detalle + "PNR"
        Else
            If CInt(result(0)) <> 0 Then
                detalle = detalle + result(0) + "HED"
            End If
            If CInt(result(1)) <> 0 Then
                detalle = detalle + ";" + result(1) + "HEN"
            End If
            If CInt(result(2)) <> 0 Then
                detalle = detalle + ";" + result(1) + "HBN"
            End If
            'HED = CInt(result(0))
            'HEN = CInt(result(1))
            'HBN = CInt(result(2))
            If CInt(result(3)) = -1 Then
                detalle = detalle + "; JA"
            End If
            If CInt(result(4)) = -1 Then
                detalle = detalle + "; DF"
            End If
            If CInt(result(5)) = -1 Then
                detalle = detalle + "; DLL"
            End If

        End If
        Return detalle
    End Function

    Private Sub IUMontarIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar
        Dim g As Graphics
        Dim max As Integer = 0
        Dim fuente As Font
        Dim cadena As String
        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `sub_departamentos`; ")
            While dr.Read()
                Label1.Text = dr(1)
                g = Label1.CreateGraphics()
                fuente = Label1.Font
                If (g.MeasureString(dr(1), CmbDepartamento.Font).Width > max) Then
                    max = g.MeasureString(dr(1), CmbDepartamento.Font).Width
                    cadena = dr(1)
                End If
                CmbDepartamento.Items.Add(dr(1))
            End While
            CmbDepartamento.DropDownWidth = max + 18
        End If
        Conexion.Cerrar_Conexion()
        dr.Dispose()
        dr.Close()
    End Sub

    Private Sub BtnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIr.Click
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Dim i As Integer = 1
        Dim j As Integer
        Dim fecha As Date
        Dim nomdia As String
        Dim columna As DataGridViewColumn
        Dim columna2 As DataGridViewColumn
        Dim celda As DataGridViewCell
        Dim ancho As Integer
        Dim diad As Integer
        Dim diah As Integer
        Dim mesd As Integer
        Dim mesh As Integer
        Dim anho As Integer
        Dim dias As Integer
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar



        diad = DateTimePicker1.Value.Day
        'diah = DateTimePicker2.Value.Day
        diah = DateAdd(DateInterval.Day, 7, DateTimePicker1.Value).Day

        mesd = DateTimePicker1.Value.Month
        'mesh = DateTimePicker2.Value.Month
        mesh = DateAdd(DateInterval.Day, 7, DateTimePicker1.Value).Month

        anho = DateTimePicker1.Value.Year

        'dias = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value)
        dias = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateAdd(DateInterval.Day, 7, DateTimePicker1.Value))

        'DgvHorario.Rows.Clear()
        'DgvHorario.Columns.Clear()
        'columna = New DataGridViewColumn()
        'columna.Width = 300
        'columna.Name = "EMPLEADO"
        'columna.HeaderText = "EMPLEADO"
        'celda = New DataGridViewTextBoxCell
        'columna.CellTemplate = celda
        'DgvHorario.Columns.Add(columna)
        'columna = New DataGridViewColumn()
        'columna.Width = 100
        'columna.Name = "CEDULA"
        'columna.HeaderText = "CEDULA"
        'celda = New DataGridViewTextBoxCell
        'columna.CellTemplate = celda
        'DgvHorario.Columns.Add(columna)

        For j = 2 To 8
            fecha = DateAdd(DateInterval.Day, j - 2, DateTimePicker1.Value)
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
            'DgvHorario.Columns(j).HeaderText = nomdia + " " + fecha.Day.ToString
            DgvHorario.Columns(j).HeaderText = fecha.ToString("d")

            'columna = New DataGridViewColumn()
            'columna2 = New DataGridViewColumn()
            'columna.Width = 80
            'columna2.Width = 80
            'columna.Name = fecha.ToString("d")
            'columna2.Name = fecha.ToString
            'columna.HeaderText = nomdia + " " + fecha.Day.ToString
            'columna2.HeaderText = nomdia + " " + fecha.Day.ToString
            'celda = New DataGridViewTextBoxCell
            'columna.CellTemplate = celda
            'columna2.CellTemplate = celda
            'columna.DefaultCellStyle.Font = New Font("Arial", 8.5F, GraphicsUnit.Pixel)
            'DgvHorario.Columns.Add(columna)
        Next

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
                DgvHorario.Rows.Add(dr(0) + " " + dr(1), dr(2))
                i = i + 1
            End While
        End If
        Conexion.Cerrar_Conexion()
        dr.Dispose()
        dr.Close()
    End Sub

    Private Sub DgvHorario_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvHorario.CellDoubleClick
        'IUDetalleIncidencias.MdiParent = Me
        IUDetalleIncidencias.fecha = DgvHorario.Columns(e.ColumnIndex).HeaderText
        IUDetalleIncidencias.col = e.ColumnIndex
        IUDetalleIncidencias.fil = e.RowIndex
        IUDetalleIncidencias.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'AUSENCIA JUSTIFICADA
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim repetido As Integer = 0
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    'If DgvHorario.Rows(j).Cells(i).Value <> "" Then
                    '    source = DgvHorario.Rows(j).Cells(i).Value
                    '    result = source.Split(stringSeparators, StringSplitOptions.None)
                    '    For Each s As String In result
                    '        If s = "AJ" Then
                    '            repetido = 1
                    '        End If
                    '    Next
                    '    If repetido = 0 Then
                    '        DgvHorario.Rows(j).Cells(i).Value = DgvHorario.Rows(j).Cells(i).Value + ";AJ"
                    '    End If
                    'Else
                    '    DgvHorario.Rows(j).Cells(i).Value = "AJ"
                    'End If
                    DgvHorario.Rows(j).Cells(i).Value = "AJ"
                End If
            Next
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'AUSENCIA INJUSTIFICADA
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim repetido As Integer = 0
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    'If DgvHorario.Rows(j).Cells(i).Value <> "" Then
                    '    source = DgvHorario.Rows(j).Cells(i).Value
                    '    result = source.Split(stringSeparators, StringSplitOptions.None)
                    '    For Each s As String In result
                    '        If s = "AI" Then
                    '            repetido = 1
                    '        End If
                    '    Next
                    '    If repetido = 0 Then
                    '        DgvHorario.Rows(j).Cells(i).Value = DgvHorario.Rows(j).Cells(i).Value + ";AI"
                    '    End If
                    'Else
                    '    DgvHorario.Rows(j).Cells(i).Value = "AI"
                    'End If
                    DgvHorario.Rows(j).Cells(i).Value = "AI"
                End If
            Next
        Next
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'REPOSO LABORAL
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim repetido As Integer = 0
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    'If DgvHorario.Rows(j).Cells(i).Value <> "" Then
                    '    source = DgvHorario.Rows(j).Cells(i).Value
                    '    result = source.Split(stringSeparators, StringSplitOptions.None)
                    '    For Each s As String In result
                    '        If s = "RL" Then
                    '            repetido = 1
                    '        End If
                    '    Next
                    '    If repetido = 0 Then
                    '        DgvHorario.Rows(j).Cells(i).Value = DgvHorario.Rows(j).Cells(i).Value + ";RL"
                    '    End If
                    'Else
                    '    DgvHorario.Rows(j).Cells(i).Value = "RL"
                    'End If
                    DgvHorario.Rows(j).Cells(i).Value = "RL"
                End If
            Next
        Next
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'REPOSO NO LABORAL
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim repetido As Integer = 0
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    'If DgvHorario.Rows(j).Cells(i).Value <> "" Then
                    '    source = DgvHorario.Rows(j).Cells(i).Value
                    '    result = source.Split(stringSeparators, StringSplitOptions.None)
                    '    For Each s As String In result
                    '        If s = "RNL" Then
                    '            repetido = 1
                    '        End If
                    '    Next
                    '    If repetido = 0 Then
                    '        DgvHorario.Rows(j).Cells(i).Value = DgvHorario.Rows(j).Cells(i).Value + ";RNL"
                    '    End If
                    'Else
                    '    DgvHorario.Rows(j).Cells(i).Value = "RNL"
                    'End If
                    DgvHorario.Rows(j).Cells(i).Value = "RNL"
                End If
            Next
        Next
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'PERMISO REMUNERADO
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim repetido As Integer = 0
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    'If DgvHorario.Rows(j).Cells(i).Value <> "" Then
                    '    source = DgvHorario.Rows(j).Cells(i).Value
                    '    result = source.Split(stringSeparators, StringSplitOptions.None)
                    '    For Each s As String In result
                    '        If s = "PR" Then
                    '            repetido = 1
                    '        End If
                    '    Next
                    '    If repetido = 0 Then
                    '        DgvHorario.Rows(j).Cells(i).Value = DgvHorario.Rows(j).Cells(i).Value + ";PR"
                    '    End If
                    'Else
                    '    DgvHorario.Rows(j).Cells(i).Value = "PR"
                    'End If
                    DgvHorario.Rows(j).Cells(i).Value = "PR"
                End If
            Next
        Next
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'PERMISO NO REMUNERADO
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim repetido As Integer = 0
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    'If DgvHorario.Rows(j).Cells(i).Value <> "" Then
                    '    source = DgvHorario.Rows(j).Cells(i).Value
                    '    result = source.Split(stringSeparators, StringSplitOptions.None)
                    '    For Each s As String In result
                    '        If s = "PNR" Then
                    '            repetido = 1
                    '        End If
                    '    Next
                    '    If repetido = 0 Then
                    '        DgvHorario.Rows(j).Cells(i).Value = DgvHorario.Rows(j).Cells(i).Value + ";PNR"
                    '    End If
                    'Else
                    '    DgvHorario.Rows(j).Cells(i).Value = "PNR"
                    'End If
                    DgvHorario.Rows(j).Cells(i).Value = "PNR"
                End If
            Next
        Next
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim i As Integer = 1
        Dim j As Integer = 1
        For i = 1 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Selected = True Then
                    DgvHorario.Rows(j).Cells(i).Value = ""
                End If
            Next
        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos

        Dim dr As System.Data.IDataReader
        Dim id As Integer
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim numero As Integer
        Dim HED, HEN, HBN, JA, DF, DLL, AJ, AI, RL, RNL, PNR, PR As Integer
        Dim fec As Date



        bConexionExitosa = Conexion.Conectar
        If bConexionExitosa Then
            Conexion.Insertar("INSERT INTO `incidencias` set `Fecha_Desde` = '" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "',`Fecha_Hasta` = '" + DateAdd(DateInterval.Day, 7, DateTimePicker1.Value).ToString("yyyy-MM-dd") + "',`Localidad` = '" & CmbLocalidad.SelectedIndex & "',`Departamento` = '" & CmbDepartamento.SelectedIndex + 3 & "',`Observaciones` = '" + TextBox1.Text + "';")
            dr = Conexion.Seleccionar("SELECT idincidencias FROM incidencias ORDER BY idincidencias DESC LIMIT 1")
            dr.Read()
            id = dr(0)
        End If
        Conexion.Cerrar_Conexion()

        Dim i As Integer = 1
        Dim j As Integer = 1
        For i = 2 To DgvHorario.ColumnCount - 1
            For j = 0 To DgvHorario.RowCount - 1
                If DgvHorario.Rows(j).Cells(i).Value <> "" Then
                    source = DgvHorario.Rows(j).Cells(i).Value
                    result = source.Split(stringSeparators, StringSplitOptions.None)
                    If result(0) = "AJ" Then
                        HED = 0
                        HEN = 0
                        HBN = 0
                        JA = 0
                        DF = 0
                        DLL = 0
                        AJ = 1
                        AI = 0
                        RL = 0
                        RNL = 0
                        PNR = 0
                        PR = 0
                    ElseIf result(0) = "AI" Then
                        HED = 0
                        HEN = 0
                        HBN = 0
                        JA = 0
                        DF = 0
                        DLL = 0
                        AJ = 0
                        AI = 1
                        RL = 0
                        RNL = 0
                        PNR = 0
                        PR = 0
                    ElseIf result(0) = "RL" Then
                        HED = 0
                        HEN = 0
                        HBN = 0
                        JA = 0
                        DF = 0
                        DLL = 0
                        AJ = 0
                        AI = 0
                        RL = 1
                        RNL = 0
                        PNR = 0
                        PR = 0
                    ElseIf result(0) = "RNL" Then
                        HED = 0
                        HEN = 0
                        HBN = 0
                        JA = 0
                        DF = 0
                        DLL = 0
                        AJ = 0
                        AI = 0
                        RL = 0
                        RNL = 1
                        PNR = 0
                        PR = 0
                    ElseIf result(0) = "PR" Then
                        HED = 0
                        HEN = 0
                        HBN = 0
                        JA = 0
                        DF = 0
                        DLL = 0
                        AJ = 0
                        AI = 0
                        RL = 0
                        RNL = 0
                        PNR = 0
                        PR = 1
                    ElseIf result(0) = "PNR" Then
                        HED = 0
                        HEN = 0
                        HBN = 0
                        JA = 0
                        DF = 0
                        DLL = 0
                        AJ = 0
                        AI = 0
                        RL = 0
                        RNL = 0
                        PNR = 1
                        PR = 0
                    Else
                        HED = CInt(result(0))
                        HEN = CInt(result(1))
                        HBN = CInt(result(2))
                        If CInt(result(3)) = -1 Then
                            JA = 1
                        End If
                        If CInt(result(4)) = -1 Then
                            DF = 1
                        End If
                        If CInt(result(5)) = -1 Then
                            DLL = 1
                        End If
                        AJ = 0
                        AI = 0
                        RL = 0
                        RNL = 0
                        PNR = 0
                        PR = 0
                    End If
                    bConexionExitosa = Conexion.Conectar
                    If bConexionExitosa Then
                        Conexion.Insertar("INSERT INTO `incidencias_detalle` set `Int_Fk_Incidencias` = '" & id & "',`Dte_Fecha` = '" + DateTime.Parse(DgvHorario.Columns(i).Name).ToString("yyyy-MM-dd") + "',`Int_HED` = '" & HED & "',`Int_HEN` = '" & HEN & "',`Int_HBN` = '" & HBN & "',`Int_JA` = '" & JA & "',`Int_DF` = '" & DF & "',`Int_DLL` = '" & DLL & "',`Int_AJ` = '" & AJ & "',`Int_AI` = '" & AI & "',`Int_RL` = '" & RL & "',`Int_RNL` = '" & RNL & "',`Int_PNR` = '" & PNR & "',`Int_PR` = '" & PR & "',`Txt_Fk_Cedula` = '" + DgvHorario.Rows(j).Cells(1).Value + "';")
                    End If
                    Conexion.Cerrar_Conexion()
                End If

            Next
        Next
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim reporteinc As New Incidencias
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
        Dim i As Integer = 0
        Dim fecha As Date
        Dim nomdia As String

        ParametroFechas.Value = "INCIDENCIAS DEL " + DateTimePicker1.Value + " AL " + DateAdd(DateInterval.Day, 7, DateTimePicker1.Value)
        Parametro.Add(ParametroFechas)

        For i = 0 To 6
            fecha = DateAdd(DateInterval.Day, i, DateTimePicker1.Value)
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
            End If
        Next

        DTIncidencias = DameDataTableDeDataGridView(DgvHorario)

        reporteinc.SetDataSource(DTIncidencias)
        reporteinc.DataDefinition.ParameterFields("Fecha").ApplyCurrentValues(Parametro)
        reporteinc.DataDefinition.ParameterFields("Dia1").ApplyCurrentValues(Parametro1)
        reporteinc.DataDefinition.ParameterFields("Dia2").ApplyCurrentValues(Parametro2)
        reporteinc.DataDefinition.ParameterFields("Dia3").ApplyCurrentValues(Parametro3)
        reporteinc.DataDefinition.ParameterFields("Dia4").ApplyCurrentValues(Parametro4)
        reporteinc.DataDefinition.ParameterFields("Dia5").ApplyCurrentValues(Parametro5)
        reporteinc.DataDefinition.ParameterFields("Dia6").ApplyCurrentValues(Parametro6)
        reporteinc.DataDefinition.ParameterFields("Dia7").ApplyCurrentValues(Parametro7)
        'reporteinc.SetDataSource(dset.Tables("Incid"))
        CrystalReportViewer1.ReportSource = reporteinc
        CrystalReportViewer1.Show()
        Me.WindowState = FormWindowState.Maximized
        CrystalReportViewer1.Dock = DockStyle.Fill
    End Sub
End Class