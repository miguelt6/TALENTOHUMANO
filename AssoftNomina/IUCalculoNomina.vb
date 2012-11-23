Public Class IUCalculoNomina
    Dim Conceptos_Auxiliar As New Collection
    Private Formula As New ClaseFormula
    Private Sub TlsBtnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnNueva.Click
        GbxNomina.Enabled = True
        Establecer_Fecha_Nomina()
        TlsBtnNueva.Enabled = False
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
    End Sub
    Private Sub Establecer_Fecha_Nomina()
        Dim Numero_Dias As Integer
        Dim Fecha As String
        If Today.Day > 15 Then
            Numero_Dias = Date.DaysInMonth(Today.Year, Today.Month)
        Else
            Numero_Dias = 15
        End If
        Fecha = CStr(Numero_Dias) + "/" + CStr(Today.Month) + "/" + CStr(Today.Year)
        DteFechaNomina.Value = CDate(Fecha)
    End Sub

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        ''''REALIZAR BUSQUEDA EN LA BASE DE DATOS''''''''''''''
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Dim i As Integer = 0
        Cargar_Conceptos_Nomina()
        IUPrincipal.Conexion = New ClaseBaseDatos
        bConexionExitosa = IUPrincipal.Conexion.Conectar
        If bConexionExitosa Then
            dr = IUPrincipal.Conexion.Seleccionar("SELECT * FROM `nomina`.`personas`,`nomina`.`contratos` where `nomina`.`personas`.txt_cedula = `nomina`.`contratos`.txt_fk_cedula and `nomina`.`personas`.Int_Estatus = 'Empleado' and `nomina`.`personas`.txt_cedula = '16540560'")
            While dr.Read()
                'Al igual de los objetos DataRow, la clase IDataReader también tiene
                'un método por defecto .Item que funciona exactamente igual
                MsgBox(dr("txt_nombres") + CStr(dr("dbl_sueldo_mensual")))
                While i < Conceptos_Auxiliar.Count                                        
                    'Conceptos_Auxiliar(i + 1).ProFormula
                    'Conceptos_Auxiliar(i + 1).ProProceso
                    'Conceptos_Auxiliar(i + 1).ProTipo

                    Calcular_Detalle_Nomina(Conceptos_Auxiliar(i + 1).ProFormula)
                    Conceptos_Auxiliar.Add(Concepto)
                    i = i + 1
                End While
            End While
        End If
    End Sub
    Private Sub Calcular_Detalle_Nomina(ByVal Detalle_Formula As String)
        Formula = New ClaseFormula
        Formula.ProVariable = "Formula1"
        Formula.ProFormuladescriptiva = Detalle_Formula
        If Formula.Procesar(Detalle_Formula) Then
            MsgBox("Sintaxis Correcta")            
        End If        
    End Sub
    Private Sub Cargar_Conceptos_Nomina()        
        Dim i As Integer = 0
        i = 0
        While i < IUPrincipal.Conceptos.Count
            If IUPrincipal.Conceptos.Item(i + 1).ProProceso = 0 Then
                IUPrincipal.Concepto = New ClaseConcepto
                IUPrincipal.Concepto.ProDescripcion = IUPrincipal.Conceptos(i + 1).ProDescripcion
                IUPrincipal.Concepto.ProCodigo = IUPrincipal.Conceptos(i + 1).ProCodigo
                IUPrincipal.Concepto.ProEstado = IUPrincipal.Conceptos(i + 1).ProEstado
                IUPrincipal.Concepto.ProFormula = IUPrincipal.Conceptos(i + 1).ProFormula
                IUPrincipal.Concepto.ProProceso = IUPrincipal.Conceptos(i + 1).ProProceso
                IUPrincipal.Concepto.ProTipo = IUPrincipal.Conceptos(i + 1).ProTipo
                Conceptos_Auxiliar.Add(Concepto)
            End If            
            i = i + 1
        End While
    End Sub
    Private Sub TlsBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnGuardar.Click

    End Sub
End Class