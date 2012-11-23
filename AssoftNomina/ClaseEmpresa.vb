Public Class ClaseEmpresa
    Private RazonSocial As String
    Private Rif As String
    Private LRif As Integer
    Private Domicilio As String
    Private Representante As String
    Private Web As String
    Private Pais As Integer
    Private Estado As Integer
    Private Municipio As String
    Private Ciudad As String
    Private Email As String
    Private Telefono As String    
    Private Fax As String
    Private Actividad As Integer
    Private TipoEmpresa As Integer
    Private Sector As Integer
    Private NumeroEmpleados As Integer
    Private NumeroAccionistas As Integer
    Private Orientacion As Integer
    Private Logo As String
    Private FechaRegistro As Date = Today
    Private Entidad As String
    Private ActaConstitutiva As String
    Private Tomo As String
    Private Sso As String
    Private Expediente As String
    Private Capital As String
    Private Acciones As String
    Private ValorAccion As String
    Private Inces As String
    Private Nil As String
    Private CodPagoNomina As String
    Private TipoContribuyente As Integer
    Private Declaracion As Integer
    Private PorRetencion As String
    Private AgentePercepcion As Integer
    Private AgenteRetencion As Integer
    Private Contribuyente As Integer

    Public Property ProRazonSocial() As String
        Get
            Return RazonSocial
        End Get
        Set(ByVal value As String)
            RazonSocial = value
        End Set
    End Property

    Public Property ProRif() As String
        Get
            Return Rif
        End Get
        Set(ByVal value As String)
            Rif = value
        End Set
    End Property

    Public Property ProDomicilio() As String
        Get
            Return Domicilio
        End Get
        Set(ByVal value As String)
            Domicilio = value
        End Set
    End Property

    Public Property ProTelefono() As String
        Get
            Return Telefono
        End Get
        Set(ByVal value As String)
            Telefono = value
        End Set
    End Property
    Public Property ProRepresentante() As String
        Get
            Return Representante
        End Get
        Set(ByVal value As String)
            Representante = value
        End Set
    End Property
    Public Property ProWeb() As String
        Get
            Return Web
        End Get
        Set(ByVal value As String)
            Web = value
        End Set
    End Property
    Public Property ProLRif() As Integer
        Get
            Return LRif
        End Get
        Set(ByVal value As Integer)
            LRif = value
        End Set
    End Property
    Public Property ProPais() As Integer
        Get
            Return Pais
        End Get
        Set(ByVal value As Integer)
            Pais = value
        End Set
    End Property
    Public Property ProEstado() As Integer
        Get
            Return Estado
        End Get
        Set(ByVal value As Integer)
            Estado = value
        End Set
    End Property

    Public Property ProMunicipio() As String
        Get
            Return Municipio
        End Get
        Set(ByVal value As String)
            Municipio = value
        End Set
    End Property
    Public Property ProCiudad() As String
        Get
            Return Ciudad
        End Get
        Set(ByVal value As String)
            Ciudad = value
        End Set
    End Property
    Public Property ProEmail() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value
        End Set
    End Property
    Public Property ProFax() As String
        Get
            Return Fax
        End Get
        Set(ByVal value As String)
            Fax = value
        End Set
    End Property
    Public Property ProActividad() As Integer
        Get
            Return Actividad
        End Get
        Set(ByVal value As Integer)
            Actividad = value
        End Set
    End Property
    Public Property ProTipoEmpresa() As Integer
        Get
            Return TipoEmpresa
        End Get
        Set(ByVal value As Integer)
            TipoEmpresa = value
        End Set
    End Property
    Public Property ProSector() As Integer
        Get
            Return Sector
        End Get
        Set(ByVal value As Integer)
            Sector = value
        End Set
    End Property
    Public Property ProOrientacion() As Integer
        Get
            Return Orientacion
        End Get
        Set(ByVal value As Integer)
            Orientacion = value
        End Set
    End Property
    Public Property ProLogo() As String
        Get
            Return Logo
        End Get
        Set(ByVal value As String)
            Logo = value
        End Set
    End Property
    Public Property ProFechaRegistro() As Date
        Get
            Return FechaRegistro
        End Get
        Set(ByVal value As Date)
            FechaRegistro = value
        End Set
    End Property
    Public Property ProEntidad() As String
        Get
            Return Entidad
        End Get
        Set(ByVal value As String)
            Entidad = value
        End Set
    End Property
    Public Property ProActaConstitutiva() As String
        Get
            Return ActaConstitutiva
        End Get
        Set(ByVal value As String)
            ActaConstitutiva = value
        End Set
    End Property
    Public Property ProTomo() As String
        Get
            Return Tomo
        End Get
        Set(ByVal value As String)
            Tomo = value
        End Set
    End Property
    Public Property ProSso() As String
        Get
            Return Sso
        End Get
        Set(ByVal value As String)
            Sso = value
        End Set
    End Property
    Public Property ProExpediente() As String
        Get
            Return Expediente
        End Get
        Set(ByVal value As String)
            Expediente = value
        End Set
    End Property
    Public Property ProCapital() As String
        Get
            Return Capital
        End Get
        Set(ByVal value As String)
            Capital = value
        End Set
    End Property

    Public Property ProAcciones() As String
        Get
            Return Acciones
        End Get
        Set(ByVal value As String)
            Acciones = value
        End Set
    End Property
    Public Property ProValorAccion() As String
        Get
            Return ValorAccion
        End Get
        Set(ByVal value As String)
            ValorAccion = value
        End Set
    End Property
    Public Property ProInces() As String
        Get
            Return Inces
        End Get
        Set(ByVal value As String)
            Inces = value
        End Set
    End Property

    Public Property ProNil() As String
        Get
            Return Nil
        End Get
        Set(ByVal value As String)
            Nil = value
        End Set
    End Property
    Public Property ProCodPagoNomina() As String
        Get
            Return CodPagoNomina
        End Get
        Set(ByVal value As String)
            CodPagoNomina = value
        End Set
    End Property
    Public Property ProTipoContribuyente() As Integer
        Get
            Return TipoContribuyente
        End Get
        Set(ByVal value As Integer)
            TipoContribuyente = value
        End Set
    End Property
    Public Property ProDeclaracion() As Integer
        Get
            Return Declaracion
        End Get
        Set(ByVal value As Integer)
            Declaracion = value
        End Set
    End Property
    Public Property ProPorRetencion() As String
        Get
            Return PorRetencion
        End Get
        Set(ByVal value As String)
            PorRetencion = value
        End Set
    End Property
    Public Property ProAgentePercepcion() As Integer
        Get
            Return AgentePercepcion
        End Get
        Set(ByVal value As Integer)
            AgentePercepcion = value
        End Set
    End Property
    Public Property ProAgenteRetencion() As Integer
        Get
            Return AgenteRetencion
        End Get
        Set(ByVal value As Integer)
            AgenteRetencion = value
        End Set
    End Property
    Public Property ProContribuyente() As Integer
        Get
            Return Contribuyente
        End Get
        Set(ByVal value As Integer)
            Contribuyente = value
        End Set
    End Property
End Class
