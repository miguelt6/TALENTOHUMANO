Public Class IUConceptos
    Private Formula As New ClaseFormula
    Dim EstadoFormulario = "Leyendo"
    Dim PosicionActual As Integer = 0
    Dim EstadoModificado As Boolean = False
    Dim PanelMostrado As Boolean = False
    Private Sub TlsBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnNuevo.Click
        EstadoFormulario = "Agregando"
        TxtDescripcion.Enabled = True
        CmbProceso.Enabled = True     
        BtnVerificar.Enabled = True
        BtnVariable.Enabled = True
        TxtFormula.Text = ""
        TxtFormula.BackColor = Color.White
        GbxEstado.Enabled = True
        CmbTipoConcepto.Enabled = True
        GbxCalculadora.Enabled = True
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True        
        BarraNavegacion.Enabled = False
    End Sub

    Private Sub IUConceptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RbtnActivo.Checked = True
        CmbProceso.SelectedIndex = 0
        CmbTipoConcepto.SelectedIndex = 0
        If IUPrincipal.Variables.Count > 0 Then
            Cargar_Variables()
        End If
        If IUPrincipal.Conceptos.Count > 0 Then
            MostrarConcepto(1)
            TlsBtnModificar.Enabled = True        
        End If
    End Sub
    Private Sub MostrarConcepto(ByVal Posicion As Integer)        
        TxtDescripcion.Text = IUPrincipal.Conceptos.Item(Posicion).ProDescripcion
        RbtnActivo.Checked = IUPrincipal.Conceptos.Item(Posicion).ProEstado
        RbtnNoActivo.Checked = Not IUPrincipal.Conceptos.Item(Posicion).ProEstado
        TxtFormula.Text = IUPrincipal.Conceptos.Item(Posicion).ProFormula
        CmbProceso.SelectedIndex = IUPrincipal.Conceptos.Item(Posicion).ProProceso
        CmbTipoConcepto.SelectedIndex = IUPrincipal.Conceptos.Item(Posicion).ProTipo
        PosicionActual = Posicion
        TxtPosicion.Text = Posicion
        LabelElementos.Text = "de {" & IUPrincipal.Conceptos.Count & "}"
    End Sub
    Private Sub Cargar_Variables()
        DgridVariables.Rows.Clear()
        Dim i As Integer = 0
            i = 0
        While i < IUPrincipal.Variables.Count            
            DgridVariables.Rows.Add()
            DgridVariables.Item(0, DgridVariables.RowCount - 1).Value = IUPrincipal.Variables.Item(i + 1).ProNombreCorto
            DgridVariables.Item(1, DgridVariables.RowCount - 1).Value = IUPrincipal.Variables.Item(i + 1).ProDescripcion
            DgridVariables.Item(2, DgridVariables.RowCount - 1).Value = i + 1            
            i = i + 1
        End While
    End Sub
    Private Function Verificar_Formula()
        Formula = New ClaseFormula
        Formula.ProVariable = "Formula1"
        Formula.ProFormuladescriptiva = TxtFormula.Text
        If Formula.Procesar(TxtFormula.Text) Then
            MsgBox("Sintaxis Correcta")
            Return True
        End If
        Return False
    End Function
    Private Sub BtnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar.Click
        Verificar_Formula()
        'DataGridView1.DataSource = ProcesarFormula.Tbl
        'Toma y muestra el valor del RESULTADO

        '////////////////////////////////////////////////////77
        'Dim i As Integer = 0
        'Dim Abierto As Integer = 0
        'For i = 0 To TxtFormula.Text.Length - 1
        ' If TxtFormula.Text.Chars(i) = "(" Then
        'Abierto += 1
        'End If
        'If TxtFormula.Text.Chars(i) = ")" Then
        ' If Abierto = 0 Then
        'MsgBox("Error De Formula")
        'Exit Sub
        'Else
        'Abierto -= 1
        'End If
        'End If
        'Next i
        'If Abierto <> 0 Then
        ' MsgBox("Error De Formula")
        'Exit Sub
        'End If
    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        TxtFormula.Text = TxtFormula.Text + "1"
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        TxtFormula.Text = TxtFormula.Text + "2"
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        TxtFormula.Text = TxtFormula.Text + "3"
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        TxtFormula.Text = TxtFormula.Text + "4"
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        TxtFormula.Text = TxtFormula.Text + "5"
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        TxtFormula.Text = TxtFormula.Text + "6"
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        TxtFormula.Text = TxtFormula.Text + "7"
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        TxtFormula.Text = TxtFormula.Text + "8"
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        TxtFormula.Text = TxtFormula.Text + "9"
    End Sub

    Private Sub BtnSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuma.Click
        TxtFormula.Text = TxtFormula.Text + "+"
    End Sub

    Private Sub BtnResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResta.Click
        TxtFormula.Text = TxtFormula.Text + "-"
    End Sub

    Private Sub BtnMultiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiplicacion.Click
        TxtFormula.Text = TxtFormula.Text + "*"
    End Sub

    Private Sub BtnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDivision.Click
        TxtFormula.Text = TxtFormula.Text + "/"
    End Sub

    Private Sub BtnPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPunto.Click
        TxtFormula.Text = TxtFormula.Text + "."
    End Sub

    Private Sub BtnCero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCero.Click
        TxtFormula.Text = TxtFormula.Text + "0"
    End Sub

    Private Sub BtnParentesisAbierto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParentesisAbierto.Click
        TxtFormula.Text = TxtFormula.Text + "("
    End Sub

    Private Sub BtnParentesisCerrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParentesisCerrado.Click
        TxtFormula.Text = TxtFormula.Text + ")"
    End Sub

    Private Sub TimerPanel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanel.Tick
        If PanelMostrado Then
            PanelBuscar.Top = PanelBuscar.Top - 20
        Else
            PanelBuscar.Top = PanelBuscar.Top + 20
        End If
        If PanelBuscar.Top >= 0 Then
            TimerPanel.Stop()
            PanelMostrado = True
        End If
        If PanelBuscar.Top <= -320 Then
            TimerPanel.Stop()
            PanelMostrado = False
        End If
    End Sub

    Private Sub BtnVariable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVariable.Click
        TimerPanel.Start()
    End Sub

    Private Sub Guardar()
        If EstadoFormulario = "Agregando" Then
            IUPrincipal.Concepto = New ClaseConcepto
            IUPrincipal.Concepto.ProDescripcion = TxtDescripcion.Text
            IUPrincipal.Concepto.ProEstado = RbtnActivo.Checked
            IUPrincipal.Concepto.ProFormula = TxtFormula.Text
            IUPrincipal.Concepto.ProProceso = CmbProceso.SelectedIndex
            IUPrincipal.Concepto.ProTipo = CmbTipoConcepto.SelectedIndex
            IUPrincipal.Conceptos.Add(IUPrincipal.Concepto)
            PosicionActual = IUPrincipal.Conceptos.Count
            TxtPosicion.Text = IUPrincipal.Conceptos.Count
            LabelElementos.Text = "de {" & IUPrincipal.Conceptos.Count & "}"
            Dim Estado As Integer = 0
            If IUPrincipal.Concepto.ProEstado = True Then
                Estado = 1
            End If
            ''''REALIZAR INSERCION EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("INSERT INTO `CONCEPTOS` set `Txt_Descripcion` = '" + IUPrincipal.Conceptos.Item(PosicionActual).ProDescripcion + "',`Int_Codigo_Proceso` = '" & IUPrincipal.Conceptos.Item(PosicionActual).ProProceso & "',`Txt_Formula` = '" + IUPrincipal.Conceptos.Item(PosicionActual).ProFormula + "',`Boo_Estado` = '" & Estado & "',`Int_Tipo` = '" & IUPrincipal.Conceptos.Item(PosicionActual).ProTipo & "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        ElseIf EstadoFormulario = "Modificando" Then
            IUPrincipal.Conceptos.Item(PosicionActual).ProEstado = RbtnActivo.Checked
            IUPrincipal.Conceptos.Item(PosicionActual).ProDescripcion = TxtDescripcion.Text
            IUPrincipal.Conceptos.Item(PosicionActual).ProFormula = TxtFormula.Text
            IUPrincipal.Conceptos.Item(PosicionActual).ProProceso = CmbProceso.SelectedIndex
            IUPrincipal.Conceptos.Item(PosicionActual).ProTipo = CmbTipoConcepto.SelectedIndex
            Dim Estado As Integer = 0
            If IUPrincipal.Conceptos.Item(PosicionActual).ProEstado = True Then
                Estado = 1
            End If
            ''''REALIZAR UPDATE EN LA BASE DE DATOS''''''''''''''
            Dim bConexionExitosa As Boolean
            IUPrincipal.Conexion = New ClaseBaseDatos
            bConexionExitosa = IUPrincipal.Conexion.Conectar
            If bConexionExitosa Then
                IUPrincipal.Conexion.Insertar("UPDATE `CONCEPTOS` set `Txt_Descripcion` = '" + IUPrincipal.Conceptos.Item(PosicionActual).ProDescripcion + "',`Int_Codigo_Proceso` = '" & IUPrincipal.Conceptos.Item(PosicionActual).ProProceso & "',`Txt_Formula` = '" + IUPrincipal.Conceptos.Item(PosicionActual).ProFormula + "',`Boo_Estado` = '" & Estado & "',`Int_Tipo` = '" & IUPrincipal.Conceptos.Item(PosicionActual).ProTipo & "' where `Num_Codigo` = '" & IUPrincipal.Conceptos.Item(PosicionActual).ProCodigo & "';")
            End If
            '////////////////////////////////////////////////////////
            '////////////////////////////////////////////////////////
        End If
    End Sub
    Private Sub Estado_Leyendo()
        TlsBtnNuevo.Enabled = True
        If IUPrincipal.Variables.Count > 0 Then
            TlsBtnModificar.Enabled = True
            BarraNavegacion.Enabled = True
        End If
        TxtDescripcion.Enabled = False        
        CmbProceso.Enabled = False
        CmbTipoConcepto.Enabled = False
        TxtFormula.BackColor = Control.DefaultBackColor
        GbxEstado.Enabled = False
        GbxCalculadora.Enabled = False
        TlsBtnGuardar.Enabled = False
        TlsBtnCancelar.Enabled = False
        BtnVerificar.Enabled = False
        BtnVariable.Enabled = False
    End Sub
    Private Sub TlsBtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnGuardar.Click
        Validar()
    End Sub
    Private Sub Validar()
        If Me.TxtDescripcion.Text = Nothing Then
            MsgBox("Falta Ingresar la Descripcion")
            Exit Sub
        End If
        If Me.TxtFormula.Text = Nothing Then
            MsgBox("Falta Ingresar La Fórmula")
            Exit Sub        
        End If
        If RbtnActivo.Checked = False And RbtnNoActivo.Checked = False Then
            MsgBox("Seleccione Si el Concepto esta Activo o No")
            Exit Sub
        End If
        If Not Verificar_Formula() Then
            Exit Sub
        End If
        Guardar()
        Estado_Leyendo()
    End Sub

    
    Private Sub BtnSuprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuprimir.Click        
        Dim i As Integer
        Dim Contador As Integer = 0
        i = TxtFormula.Text.Length - 1
        While i >= 0
            If Char.IsLetter(TxtFormula.Text.Chars(i)) Then
                Contador += 1
            Else
                Contador = 1
                Exit While
            End If
            i -= 1
        End While
        If TxtFormula.Text.Length > 0 Then
            TxtFormula.Text = TxtFormula.Text.Remove(TxtFormula.Text.Length - Contador, Contador)
        End If
    End Sub

    Private Sub BtnCancelarPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarPanel.Click
        TimerPanel.Start()
    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        If DgridVariables.RowCount > 0 Then
            TxtFormula.Text = TxtFormula.Text + DgridVariables.Item(0, DgridVariables.CurrentRow.Index).Value()            
        End If
        TimerPanel.Start()
    End Sub

    Private Sub BotonPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonPrimero.Click
        MostrarConcepto(1)
    End Sub

    Private Sub BotonAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAnterior.Click
        If PosicionActual = 1 Then
            MostrarConcepto(1)
        Else
            MostrarConcepto(PosicionActual - 1)
        End If
    End Sub

    Private Sub BotonSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSiguiente.Click
        If PosicionActual = IUPrincipal.Conceptos.Count Then
            MostrarConcepto(PosicionActual)
        Else
            MostrarConcepto(PosicionActual + 1)
        End If
    End Sub

    Private Sub BotonUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonUltimo.Click
        MostrarConcepto(IUPrincipal.Conceptos.Count)
    End Sub

    Private Sub TlsBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TlsBtnModificar.Click        
        TlsBtnModificar.Enabled = False
        TlsBtnNuevo.Enabled = False
        TlsBtnGuardar.Enabled = True
        TlsBtnCancelar.Enabled = True
        BarraNavegacion.Enabled = False        
        EstadoFormulario = "Modificando"      
        TxtDescripcion.Enabled = True
        CmbProceso.Enabled = True
        BtnVerificar.Enabled = True
        BtnVariable.Enabled = True        
        TxtFormula.BackColor = Color.White
        GbxEstado.Enabled = True
        CmbTipoConcepto.Enabled = True
        GbxCalculadora.Enabled = True        
    End Sub
End Class