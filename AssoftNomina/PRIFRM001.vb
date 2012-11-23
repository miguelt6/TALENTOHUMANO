Public Class PRIFRM001
    Public Empresa As New ClaseEmpresa
    Public Pais As ClasePais
    Public Paises As New Collection
    Public Estado As ClaseEstados
    Public Estados As New Collection
    Public Actividad As ClaseActividad
    Public Actividades As New Collection
    Public TipoEmpresa As ClaseTipoEmpresa
    Public TipoEmpresas As New Collection
    Public Sector As ClaseSector
    Public Sectores As New Collection
    Public Sucursal As ClaseSucursal
    Public Sucursales As New Collection
    Public Departamento As ClaseDepartamento
    Public Departamentos As New Collection
    Public Cargo As ClaseCargo
    Public Cargos As New Collection
    Public Persona As ClasePersona
    Public Personas As New Collection
    Public Familiares As New Collection
    Public Familiar As ClaseFamiliares
    Public Titulos As New Collection
    Public Titulo As ClaseTitulos
    Public Contrato As ClaseContrato
    Public Contratos As New Collection

    Private Sub Empresa_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        EMPFRM001.MdiParent = Me
        EMPFRM001.Show()
    End Sub
    Private Sub Departamentos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DOMFRM001.MdiParent = Me
        DOMFRM001.Show()
    End Sub
    Private Sub Cargos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MAEFRM001.MdiParent = Me
        MAEFRM001.Show()
    End Sub
    Private Sub Empleado_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUGestionPersonas.MdiParent = Me
        IUGestionPersonas.Show()
    End Sub
    Private Sub Contrato_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        IUGenerarContratos.MdiParent = Me
        IUGenerarContratos.Show()
    End Sub
    Private Sub Estadisticas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("No es Posible Visualizar Estadisticas Sin la Información de Nómina")
    End Sub    

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        ToolStrip1.Items.Clear()
        ToolStrip1.Items.Add("Datos Empresa", ImageList1.Images(0), New EventHandler(AddressOf Empresa_Click))
        ToolStrip1.Items.Add("Departamentos", ImageList1.Images(1), New EventHandler(AddressOf Departamentos_Click))
        ToolStrip1.Items.Add("Cargos", ImageList1.Images(1), New EventHandler(AddressOf Cargos_Click))
        ToolStrip1.Items.Add("Estadisticas", ImageList1.Images(2), New EventHandler(AddressOf Estadisticas_Click))
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PersonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonasToolStripMenuItem.Click
        ToolStrip1.Items.Clear()        
        'ToolStrip1.Items.Add("Aspirantes", ImageList1.Images(3))
        'ToolStrip1.Items.Add("Vacantes", ImageList1.Images(6))
        ToolStrip1.Items.Add("Personas", ImageList1.Images(5), New EventHandler(AddressOf Empleado_Click))
        ToolStrip1.Items.Add("Generar Contrato", ImageList1.Images(7), New EventHandler(AddressOf Contrato_Click))
        'ToolStrip1.Items.Add("Accionistas", ImageList1.Images(4))
    End Sub

    Private Sub DatosMaestrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosMaestrosToolStripMenuItem.Click
        'ToolStrip1.Items.Clear()
        'ToolStrip1.Items.Add("Cargos", ImageList1.Images(1), New EventHandler(AddressOf Cargos_Click))
        'ToolStrip1.Items.Add("Bancos")
        'ToolStrip1.Items.Add("Profesiones")
        'ToolStrip1.Items.Add("Areas Conocimiento")
        'ToolStrip1.Items.Add("Paises")
        'ToolStrip1.Items.Add("Estados")
    End Sub

    Private Sub PRIFRM001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
