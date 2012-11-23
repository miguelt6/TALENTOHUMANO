Imports MySQLDriverCS
Public Class IuAutenticacion
    Public Conexion As ClaseBaseDatos
    
    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click
        Verificar_Usuario()
    End Sub
    Private Sub Verificar_Usuario()
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            dr = Conexion.Seleccionar("select * from usuarios where txt_login = '" + TxtLogin.Text + "' and txt_password = '" + TxtPassword.Text + "'")
            If (dr.Read()) Then
                Me.Visible = False
                IUPrincipal.Codigo_Usuario = dr("Num_Codigo")
                IUPrincipal.Show()
            Else
                MsgBox("Error Al Iniciar Sesión Verifique su Nombre de Usuario y Password")
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub
End Class