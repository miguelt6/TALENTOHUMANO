Public Class IUFeriados

    Private Sub IUFeriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        CalFeriados.SetDate(Today)
        If IUPrincipal.Feriados.Count > 0 Then
            Cargar_Feriados()
            BtnQuitar.Enabled = True
        End If
    End Sub
    Private Sub Cargar_Feriados()
        Dim i As Integer = 0
        Dim fechaferiado As Date
        While i < IUPrincipal.Feriados.Count
            DgridFeriados.Rows.Add()
            FechaFeriado = IUPrincipal.Feriados.Item(i + 1).ProFecha
            DgridFeriados.Item(0, DgridFeriados.RowCount - 1).Value = fechaferiado.ToString("dd/MM/yyyy")
            i = i + 1
        End While
    End Sub
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim i As Integer = 0
        While i < IUPrincipal.Feriados.Count
            If IUPrincipal.Feriados.Item(i + 1).ProFecha = CalFeriados.SelectionRange.Start Then
                MsgBox("Día Feriado Ya Agregado", MsgBoxStyle.Information)
                Exit Sub
            End If
            i = i + 1
        End While
        DgridFeriados.Rows.Add()
        DgridFeriados.Item(0, DgridFeriados.RowCount - 1).Value = CalFeriados.SelectionRange.Start.ToString("dd/MM/yyyy")
        IUPrincipal.Feriado = New ClaseFeriado
        IUPrincipal.Feriado.ProFecha = CalFeriados.SelectionRange.Start
        IUPrincipal.Feriados.Add(IUPrincipal.Feriado)
        BtnQuitar.Enabled = True
    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        IUPrincipal.Feriados.Remove(DgridFeriados.CurrentRow.Index + 1)
        DgridFeriados.Rows.RemoveAt(DgridFeriados.CurrentRow.Index)
        If IUPrincipal.Feriados.Count < 1 Then
            BtnQuitar.Enabled = False
        End If
    End Sub
End Class