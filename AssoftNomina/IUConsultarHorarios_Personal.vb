Imports CrystalDecisions.Shared

Public Class IUConsultarHorarios_Personal
    Public Conexion As ClaseBaseDatos

    Private Sub IUConsultarHorarios_Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bConexionExitosa As Boolean
        Dim dr As System.Data.IDataReader
        Dim g As Graphics
        Dim max As Integer = 0
        Dim fuente As Font
        Dim cadena As String
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar
        If bConexionExitosa Then
            dr = Conexion.Seleccionar("SELECT * FROM `sub_departamentos`; ")
            While dr.Read()
                Label2.Text = dr(1)
                g = Label2.CreateGraphics()
                fuente = Label2.Font
                If (g.MeasureString(dr(1), ComboBox2.Font).Width > max) Then
                    max = g.MeasureString(dr(1), ComboBox2.Font).Width
                    cadena = dr(1)
                End If
                ComboBox2.Items.Add(dr(1))
            End While
            ComboBox2.DropDownWidth = max + 18
            'dr.Read()
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class