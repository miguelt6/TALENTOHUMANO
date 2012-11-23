Public Class IUCrearHorario
    Public Conexion As ClaseBaseDatos
    Private Sub IUCrearHorario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `sub_departamentos`; ")
            While dr.Read()
                CmbDepartamento.Items.Add(dr(1))
            End While
            'CmbDepartamento.DropDownWidth = max + 18
            'dr.Read()
        End If
        Conexion.Cerrar_Conexion()
        dr.Dispose()
        dr.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        Dim format As String
        'Dim provider As CultureInfo = CultureInfo.InvariantCulture
        Dim horastrabajadas As Double
        Dim horasbono As Double
        Dim horaentrada As DateTime

        horastrabajadas = CDbl(ComboBox3.Items(CmbHoraHasta.SelectedIndex)) - CDbl(ComboBox2.Items(CmbHoraDesde.SelectedIndex))
        If CDbl(ComboBox3.Items(CmbHoraHasta.SelectedIndex)) > 19 Then
            horasbono = CDbl(ComboBox3.Items(CmbHoraHasta.SelectedIndex)) - 19
        End If
        'horas = CmbHoraHasta.SelectedItem.ToString.Substring(0, InStr(CmbHoraHasta.SelectedItem.ToString, " ") - 1) - CmbHoraDesde.SelectedItem
        'format = "yyyy-MM-dd HH:mm:ss"

        'horaentrada = DateTime.ParseExact(ComboBox1.Items(CmbHoraDesde.SelectedIndex), format, Nothing)

        Dim dpto As Integer = CmbDepartamento.SelectedIndex
        'horario = horario.Substring(0, InStr(horario, "Descanso") - 1)
        If bConexionExitosa Then
            'Conexion.Insertar("INSERT INTO `horario` set `Int_Hora_Entrada` = '" + CmbHoraDesde.SelectedItem + "',`Int_Hora_Salida` = '" + CmbHoraHasta.SelectedItem + "',`Horas_Descanso` = '" & CDbl(CmbHorasDescanso.SelectedItem) / 60 & "',`Horas_Bono_Nocturno` = '" & horasbono & "',`Horas_Trabajadas` = '" & horastrabajadas & "',`Dte_Hora_Entrada` = STR_TO_DATE('" + horaentrada + "', '%d/%m/%Y %h:%i:%s %k') ,`Fk_Id_Dpto` = '" & CmbDepartamento.SelectedIndex + 3 & "';")
            Conexion.Insertar("INSERT INTO `horario` set `Int_Hora_Entrada` = '" + CmbHoraDesde.SelectedItem + "',`Int_Hora_Salida` = '" + CmbHoraHasta.SelectedItem + "',`Horas_Descanso` = '" & CDbl(CmbHorasDescanso.SelectedItem) / 60 & "',`Horas_Bono_Nocturno` = '" & horasbono & "',`Horas_Trabajadas` = '" & horastrabajadas & "',`Dte_Hora_Entrada` = '" + ComboBox1.Items(CmbHoraDesde.SelectedIndex) + "' ,`Fk_Id_Dpto` = '" & CmbDepartamento.SelectedIndex + 3 & "';")
            'Conexion.Insertar("UPDATE `PERSONAS` set `Int_Estatus` = '4' where `Txt_Cedula`= '" + LblDatoCedula.Text + "';")
        End If
        Conexion.Cerrar_Conexion()

    End Sub
End Class