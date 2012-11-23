Public Class ClaseUsuario
    Private Codigo As Integer
    Private Nombre As String
    Private Apellido As String
    Private Login As String
    Private Password As String
    Public Property ProCodigo() As Integer
        Get
            Return Codigo
        End Get
        Set(ByVal value As Integer)
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

    Public Property ProApellido() As String
        Get
            Return Apellido
        End Get
        Set(ByVal value As String)
            Apellido = value
        End Set
    End Property

    Public Property ProLogin() As String
        Get
            Return Login
        End Get
        Set(ByVal value As String)
            Login = value
        End Set
    End Property
    Public Property ProPassword() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property
End Class
