Public Class IUDetalleIncidencias
    Public fecha As Date
    Public col As Integer
    Public fil As Integer


    Private Sub IUDetalleIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label9.Text = fecha.ToString("d")
        Dim stringSeparators() As String = {";"}
        Dim result() As String
        Dim source As String
        Dim numero As Integer
        If IUMontarIncidencias.DgvHorario.Rows(fil).Cells(col).Value <> "" Then
            source = IUMontarIncidencias.DgvHorario.Rows(fil).Cells(col).Value
            result = source.Split(stringSeparators, StringSplitOptions.None)
            If Int32.TryParse(result(0), numero) Then
                NumericUpDown1.Value = CInt(result(0))
                NumericUpDown2.Value = CInt(result(1))
                NumericUpDown3.Value = CInt(result(2))
                CheckBox1.Checked = CInt(result(3))
                CheckBox2.Checked = CInt(result(4))
                CheckBox3.Checked = CInt(result(5))
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim incidencia As String
        If NumericUpDown1.Value = 0 And NumericUpDown2.Value = 0 And NumericUpDown3.Value = 0 And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            incidencia = ""
        Else
            incidencia = NumericUpDown1.Value.ToString + ";" + NumericUpDown2.Value.ToString + ";" + NumericUpDown3.Value.ToString + ";" + CInt(CheckBox1.Checked).ToString + ";" + CInt(CheckBox2.Checked).ToString + ";" + CInt(CheckBox3.Checked).ToString
        End If
        IUMontarIncidencias.DgvHorario.Rows(fil).Cells(col).Value = incidencia
        'If IUMontarIncidencias.DgvHorario.Rows(fil).Cells(col).Value <> "" Then
        '    IUMontarIncidencias.DgvHorario.Rows(fil).Cells(col).Value = incidencia + ";" + IUMontarIncidencias.DgvHorario.Rows(fil).Cells(col).Value
        'End If
        Me.Close()
    End Sub
End Class