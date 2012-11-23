Imports MySQLDriverCS
Public Class IUPrincipal
    Public Empresa As New ClaseEmpresa
    Public Banco As ClaseBanco
    Public Bancos As New Collection
    Public Pais As ClasePais
    Public Paises As New Collection
    Public Estado As ClaseEstados
    Public Estados As New Collection
    Public Actividad As ClaseActividad
    Public Actividades As New Collection
    Public Familiares As New Collection
    Public Familiar As ClaseFamiliares
    Public TipoEmpresa As ClaseTipoEmpresa
    Public TipoEmpresas As New Collection
    Public Sector As ClaseSector
    Public Sectores As New Collection
    Public Departamento As ClaseDepartamento
    Public Departamentos As New Collection
    Public Cargo As ClaseCargo
    Public Cargos As New Collection
    Public Persona As ClasePersona
    Public Personas As New Collection
    Public Titulos As New Collection
    Public Titulo As ClaseTitulos
    Public Titulos1 As New Collection
    Public Titulo1 As ClaseTitulo
    Public Contrato As ClaseContrato
    Public Contratos As New Collection
    Public GrupoNomina As ClaseGrupoNomina
    Public GruposNomina As New Collection
    Public Profesion As ClaseProfesion
    Public Profesiones As New Collection
    Public Feriado As ClaseFeriado
    Public Feriados As New Collection
    Public Concepto As ClaseConcepto
    Public Conceptos As New Collection
    Public Variable As ClaseVariable
    Public Variables As New Collection
    Public Prestamo As ClasePrestamo
    Public Prestamos As New Collection
    Public Usuario As New ClaseUsuario
    Public Usuarios As New Collection
    Public Privilegio As New claseprivilegio
    Public Privilegios As New Collection
    Public Conexion As ClaseBaseDatos
    Public Codigo_Usuario As Integer

    Private Sub Empresa_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        EMPFRM001.MdiParent = Me
        EMPFRM001.Show()
    End Sub
    Private Sub Departamentos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DOMFRM001.MdiParent = Me
        DOMFRM001.Show()
    End Sub
    Private Sub Cargos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUGestionCargos.MdiParent = Me
        IUGestionCargos.Show()
    End Sub
    Private Sub Empleado_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUGestionPersonas.MdiParent = Me
        IUGestionPersonas.Show()
    End Sub
    Private Sub Aspirante_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUGestionAspirantes.MdiParent = Me
        IUGestionAspirantes.Show()
    End Sub
    Private Sub Reportes_Personas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("Módulo en construcción", MsgBoxStyle.Information, "Merca Facil C.A")
    End Sub

    Private Sub Contrato_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUGenerarContratos.MdiParent = Me
        IUGenerarContratos.Show()
    End Sub
    Private Sub GruposNomina_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUGruposNomina.MdiParent = Me
        IUGruposNomina.Show()
    End Sub

    Private Sub Estadisticas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("No es Posible Visualizar Estadisticas Sin la Información de Nómina", MsgBoxStyle.Information, "Merca Facil C.A")
    End Sub
    Private Sub Feriados_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUFeriados.MdiParent = Me
        IUFeriados.Show()
    End Sub
    Private Sub Conceptos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUConceptos.MdiParent = Me
        IUConceptos.Show()
    End Sub
    Private Sub Variables_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUVariables.MdiParent = Me
        IUVariables.Show()
    End Sub
    Private Sub Prestamos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUPrestamo.MdiParent = Me
        IUPrestamo.Show()
    End Sub

    Private Sub Calculo_Nomina_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUCalculoNomina.MdiParent = Me
        IUCalculoNomina.Show()
    End Sub
    Private Sub Reportes_Consultorio_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'MsgBox("Módulo en construcción", MsgBoxStyle.Information, "Merca Facil C.A")
        ImportarPersonal.MdiParent = Me
        ImportarPersonal.Show()
    End Sub
    Private Sub Examenes_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("Módulo en construcción", MsgBoxStyle.Information, "Merca Facil C.A")
    End Sub
    Private Sub AsigHorario_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUAsignarHorarios.MdiParent = Me
        IUAsignarHorarios.Show()
    End Sub
    Private Sub CrearHorario_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUCrearHorario.MdiParent = Me
        IUCrearHorario.Show()
    End Sub
    Private Sub Preempleo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUCitasPreEmpleo.MdiParent = Me
        IUCitasPreEmpleo.Show()
    End Sub
    Private Sub MontarIncidencias_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUMontarIncidencias.MdiParent = Me
        IUMontarIncidencias.Show()
        'MsgBox("Módulo en construcción", MsgBoxStyle.Information, "Merca Facil C.A")
    End Sub
    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Datos Empresa", ImageList1.Images(0), New EventHandler(AddressOf Empresa_Click))
        ToolStrip1.Items.Add("Departamentos", ImageList1.Images(1), New EventHandler(AddressOf Departamentos_Click))
        ToolStrip1.Items.Add("Cargos", ImageList1.Images(1), New EventHandler(AddressOf Cargos_Click))
        ToolStrip1.Items.Add("Grupos de Nomina", ImageList1.Images(8), New EventHandler(AddressOf GruposNomina_Click))
        ToolStrip1.Items.Add("Estadisticas", ImageList1.Images(2), New EventHandler(AddressOf Estadisticas_Click))
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PersonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonasToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Buscar Aspirantes", ImageList1.Images(3), New EventHandler(AddressOf Aspirante_Click))
        ToolStrip1.Items.Add("Personas", ImageList1.Images(5), New EventHandler(AddressOf Empleado_Click))
        ToolStrip1.Items.Add("Generar Contrato", ImageList1.Images(7), New EventHandler(AddressOf Contrato_Click))
        ToolStrip1.Items.Add("Reportes", ImageList1.Images(13), New EventHandler(AddressOf Reportes_Personas_Click))
        'ToolStrip1.Items.Add("Accionistas", ImageList1.Images(4))
    End Sub

    Private Sub DatosMaestrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosMaestrosToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Dias Feriados", ImageList1.Images(9), New EventHandler(AddressOf Feriados_Click))
    End Sub

    Private Sub CalculoDeNóminaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculoDeNóminaToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Conceptos", ImageList1.Images(10), New EventHandler(AddressOf Conceptos_Click))
        ToolStrip1.Items.Add("Variables", ImageList1.Images(14), New EventHandler(AddressOf Variables_Click))
        ToolStrip1.Items.Add("Procesar Prestamo", ImageList1.Images(15), New EventHandler(AddressOf Prestamos_Click))
        ToolStrip1.Items.Add("Calculo Nómina", ImageList1.Images(11), New EventHandler(AddressOf Calculo_Nomina_Click))
        'ToolStrip1.Items.Add("Cesta Tickets", ImageList1.Images(12))
        'ToolStrip1.Items.Add("Config. Archivo Txt", ImageList1.Images(13))
    End Sub
    Private Sub ConsultorioMédicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultorioMédicoToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Citas Pre-empleo", ImageList1.Images(10), New EventHandler(AddressOf Preempleo_Click))
        ToolStrip1.Items.Add("Examen Médico", ImageList1.Images(14), New EventHandler(AddressOf Examenes_Click))
        ToolStrip1.Items.Add("Reportes", ImageList1.Images(15), New EventHandler(AddressOf Reportes_Consultorio_Click))
    End Sub
    Private Sub HorariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorariosToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Crear Horario", ImageList1.Images(3), New EventHandler(AddressOf CrearHorario_Click))
        ToolStrip1.Items.Add("Asignar Horarios", ImageList1.Images(5), New EventHandler(AddressOf AsigHorario_Click))
        ToolStrip1.Items.Add("Modificar Horarios", ImageList1.Images(7), New EventHandler(AddressOf Contrato_Click))
        'ToolStrip1.Items.Add("Reportes", ImageList1.Images(13), New EventHandler(AddressOf Reportes_Personas_Click))
    End Sub

    Private Sub IncidenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncidenciasToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Montar Incidencias", ImageList1.Images(3), New EventHandler(AddressOf MontarIncidencias_Click))
    End Sub
    Private Sub IUPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        IuAutenticacion.Close()
    End Sub

    Private Sub IUPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Empresa()
        Cargar_Departamentos()
        'Cargar_Empleados()
        'Cargar_Familiares()
        Cargar_Cargos()
        'Cargar_Usuarios()
        'Cargar_Privilegios()
        'Cargar_Variables()
        'Cargar_Conceptos()
        'Cargar_Paises()
        'Cargar_Contratos()
        Cargar_Titulos_personas()
        Cargar_Titulos()
    End Sub

    Private Sub Cargar_Titulos_personas()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"titulos_personas"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Titulo = New ClaseTitulos
                    Titulo.Proidtitulo = drow("fk_id_titulo")
                    Titulo.Propersona = drow("fk_id_persona")
                    Titulo.Proinstitucion = drow("Txt_institucion")
                    Titulo.Profecha = drow("Dte_fecha")
                    Titulos.Add(Titulo)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub

    Private Sub Cargar_Titulos()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"titulos"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Titulo1 = New ClaseTitulo
                    Titulo1.Proid = drow("Int_Id")
                    Titulo1.Prodescripcion = drow("Txt_Descripcion")
                    Titulos1.Add(Titulo1)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub

    Private Sub Cargar_Conceptos()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"conceptos"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Concepto = New ClaseConcepto
                    Concepto.ProDescripcion = drow("Txt_Descripcion")
                    Concepto.ProCodigo = drow("Num_Codigo")
                    Concepto.ProEstado = drow("Boo_Estado")
                    Concepto.ProFormula = drow("Txt_Formula")
                    Concepto.ProProceso = drow("Int_Codigo_Proceso")
                    Concepto.ProTipo = drow("Int_Tipo")
                    Conceptos.Add(Concepto)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub

    Private Sub Cargar_Variables()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"variables"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Variable = New ClaseVariable
                    Variable.ProDescripcion = drow("Txt_Descripcion")
                    Variable.ProNombreCorto = drow("Txt_Nombre_Corto")
                    Variable.ProValor = drow("Txt_Valor")
                    Variable.ProTipo = drow("Int_Tipo")
                    Variables.Add(Variable)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub

    Private Sub Cargar_Contratos()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"contratos"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Contrato = New ClaseContrato
                    Contrato.ProId = drow("Num_Codigo")
                    Contrato.ProDescripcion = drow("Txt_Descripcion")
                    Contrato.ProFk_Cedula = drow("Txt_Fk_Cedula")
                    Contrato.ProCargo = drow("Int_Fk_Codgio_Cargo")
                    Contrato.ProTipoHorario = drow("Int_Tipo_Horario")
                    Contrato.ProSueldo = drow("Dbl_Sueldo_Mensual")
                    Contrato.ProFechaInicial = drow("Dte_Fecha_Inicial")
                    Contrato.ProFechaFinal = drow("Dte_Fecha_Final")
                    Contrato.ProDuracion = drow("Int_Duracion")
                    Contrato.ProTipoPago = drow("Int_Tipo_Pago")
                    Contrato.ProFkBanco = drow("fk_id_Cod_Banco")
                    Contrato.ProFkNomina = drow("fk_id_Cod_Nomina")
                    Contrato.ProCuenta = drow("Txt_Numero_Cuenta")
                    Contrato.ProFrecuencia = drow("Txt_Frecuencia_Pago")
                    Contrato.ProFechaEgreso = drow("Dte_Fecha_Egreso")
                    Contrato.ProFk_Cedula_Cubrir = drow("Txt_fk_cedula_cubrir")
                    Contrato.ProJornadaDiaria = drow("Dbl_Jornada_Diaria")
                    Contratos.Add(Contrato)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub

    Private Sub Cargar_Privilegios()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"privilegios"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Privilegio = New ClasePrivilegio
                    Privilegio.ProFk_Codigo_Formulario = drow("Fk_Codigo_Formulario")
                    Privilegio.ProFk_Codigo_Usuario = drow("Fk_Codigo_Usuario")
                    Privilegios.Add(Privilegio)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub
    Private Sub Cargar_Usuarios()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"usuarios"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Usuario = New ClaseUsuario
                    Usuario.ProCodigo = drow("Num_Codigo")
                    Usuario.ProNombre = drow("Txt_Nombre")
                    Usuario.ProApellido = drow("Txt_Apellido")
                    Usuario.ProLogin = drow("Txt_Login")
                    Usuario.ProPassword = drow("Txt_Password")
                    Usuarios.Add(Usuario)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub
    Private Sub Cargar_Empresa()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"empresa"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                                                            
                    Empresa.ProRif = drow("Txt_Rif")
                    Empresa.ProLRif = drow("Int_LRif")
                    Empresa.ProRazonSocial = drow("Txt_Razon_Social")
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub

    Private Sub Cargar_Departamentos()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"departamentos"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                    
                    Departamento = New ClaseDepartamento
                    Departamento.ProCodigo = drow("Num_Codigo")
                    Departamento.ProNombre = drow("Txt_Nombre")
                    Departamento.ProDescripcion = drow("Txt_Descripcion")
                    Departamentos.Add(Departamento)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub
    Private Sub Cargar_Cargos()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"cargos"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                    
                    Cargo = New ClaseCargo
                    Cargo.ProCodigo = drow("Num_Codigo")
                    Cargo.ProDepartamento = drow("Num_Codigo_Departamento") - 1
                    Cargo.ProNombre = drow("Txt_Nombre")
                    Cargo.ProDescripcion = drow("Txt_Descripcion")
                    Cargos.Add(Cargo)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub
    Private Sub Cargar_Paises()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"paises"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                    
                    Pais = New ClasePais
                    Pais.ProCodigo = drow("Int_Codigo")
                    Pais.ProDescripcion = drow("Txt_Descripcion")
                    Paises.Add(Pais)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub
    Private Sub Cargar_Familiares()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"familiares"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                    
                    Familiar = New ClaseFamiliares
                    Familiar.ProApellido = drow("Txt_Apellido")
                    Familiar.ProNombre = drow("Txt_Nombre")
                    Familiar.ProFk_Cedula = drow("Fk_Txt_Cedula")
                    Familiar.ProFechaNacimiento = drow("Dte_Fecha_Nacimiento")
                    Familiar.ProEstudia = drow("Boo_Estudia")
                    Familiar.ProParentesco = drow("Int_Parentesco")
                    Familiares.Add(Familiar)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub
    Public Sub Cargar_Empleados()
        Dim bConexionExitosa As Boolean
        Conexion = New ClaseBaseDatos
        bConexionExitosa = Conexion.Conectar

        If bConexionExitosa Then
            Dim f() As String = {"*"}
            Dim t() As String = {"personas_temp"}

            Dim dt As DataTable = New MySQLSelectCommand(Conexion.ProDBCon, f, t, Nothing, Nothing, Nothing).Table
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colección podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un método por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el índice o el nombre de la columna                    
                    Persona = New ClasePersona
                    Persona.ProCodigo = drow("Num_Identificador")
                    Persona.ProCedula = drow("Txt_Cedula")
                    Persona.ProRif = drow("Txt_Rif")
                    Persona.ProApellidos = drow("Txt_Apellidos")
                    Persona.ProNombres = drow("Txt_Nombres")
                    Persona.ProEdoCivil = drow("Int_Edo_Civil")
                    Persona.ProFechaNacimiento = drow("Dte_Fecha_Nacimiento")
                    Persona.ProLugarNacimiento = drow("Txt_Lugar_Nacimiento")
                    Persona.ProSexo = drow("Int_Sexo")
                    Persona.ProAlergias = drow("Txt_Alergias")
                    Persona.ProAltura = drow("Int_Altura")
                    Persona.ProCorreoElectronico = drow("Txt_Correo")
                    Persona.ProDescripcionContacto = drow("Txt_Descripcion_Contacto")
                    Persona.ProDireccion = drow("Txt_Direccion")
                    Persona.ProEnfermedades = drow("Txt_Enfermedades")
                    Persona.ProFuma = drow("Boo_Fuma")
                    Persona.ProGrupoSanguineo = drow("Txt_Grupo_Sanguineo")
                    Persona.ProIncapacitado = drow("Boo_Incapacitado")
                    Persona.ProLentes = drow("Boo_Lentes")
                    Persona.ProNombreContacto = drow("Txt_Nombre_Contacto")
                    Persona.ProOperaciones = drow("Boo_Operaciones")
                    Persona.ProPeso = drow("Int_Peso")
                    Persona.ProPuntoReferencia = drow("Txt_Punto_Ref")
                    Persona.ProTallaCalzado = drow("Int_Talla_Calzado")
                    Persona.ProTallaCamisa = drow("Txt_Talla_Camisa")
                    Persona.ProTallaPantalon = drow("Int_Talla_Pantalon")
                    Persona.ProTelefonoContacto = drow("Txt_Tel_Contacto")
                    Persona.ProTelefonoHabitacion = drow("Txt_Tel_Habitacion")
                    Persona.ProTelefonoMovil = drow("Txt_Tel_Movil")
                    Persona.ProFoto = Persona.ProCedula + ".bmp"
                    Persona.ProTelefonoMovilContacto = drow("Txt_Tel_Movil_Contacto")
                    Persona.ProCertificado = drow("Boo_Certificado")
                    Persona.ProHabilidades = drow("Txt_Habilidades")
                    Persona.ProCuentaBancaria = drow("Txt_Cuenta_Bancaria")
                    Persona.ProEstatus = drow("Int_Estatus")
                    Persona.ProDedo_1 = drow("Int_Dedo1")
                    Persona.ProDedo_2 = drow("Int_Dedo2")
                    Persona.ProFechaPreEmpleo = drow("Dte_Fechapreempleo")
                    Personas.Add(Persona)
                Next
            End If
            Conexion.Cerrar_Conexion()
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub



End Class
