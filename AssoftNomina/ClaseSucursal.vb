Public Class ClaseSucursal
    Private Nombre As String
    Private Direccion As String
    Private Telefono As String
    Private Gerente As String
    Private Pais As Integer
    Private Estado As Integer
    Private Municipio As String
    Private Ciudad As String

    Public Property ProNombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property ProDireccion() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value
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
    Public Property ProGerente() As String
        Get
            Return Gerente
        End Get
        Set(ByVal value As String)
            Gerente = value
        End Set
    End Property
    Public Property ProPais() As String
        Get
            Return Pais
        End Get
        Set(ByVal value As String)
            Pais = value
        End Set
    End Property
    Public Property ProEstado() As String
        Get
            Return Estado
        End Get
        Set(ByVal value As String)
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
End Class
