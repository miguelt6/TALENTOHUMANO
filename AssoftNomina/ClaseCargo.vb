Public Class ClaseCargo
    Private Codigo As String
    Private Nombre As String
    Private Descripcion As String
    Private Departamento As Integer
    Public Property ProCodigo() As String
        Get
            Return Codigo
        End Get
        Set(ByVal value As String)
            Codigo = value
        End Set
    End Property
    Public Property ProNombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property ProDescripcion() As String
        Get
            Return Descripcion
        End Get
        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property ProDepartamento() As Integer
        Get
            Return Departamento
        End Get
        Set(ByVal value As Integer)
            Departamento = value
        End Set
    End Property

End Class
