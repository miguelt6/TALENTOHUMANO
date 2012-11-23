Public Class ClaseFamiliares
    Private Nombre As String
    Private Apellido As String
    Private Parentesco As Integer
    Private FechaNacimiento As Date
    Private Estudia As Boolean
    Private Fk_Cedula As String

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

    Public Property ProParentesco() As Integer
        Get
            Return Parentesco
        End Get
        Set(ByVal value As Integer)
            Parentesco = value
        End Set
    End Property

    Public Property ProFechaNacimiento() As Date
        Get
            Return FechaNacimiento
        End Get
        Set(ByVal value As Date)
            FechaNacimiento = value
        End Set
    End Property
    Public Property ProEstudia() As Boolean
        Get
            Return Estudia
        End Get
        Set(ByVal value As Boolean)
            Estudia = value
        End Set
    End Property
    Public Property ProFk_Cedula() As String
        Get
            Return Fk_Cedula
        End Get
        Set(ByVal value As String)
            Fk_Cedula = value
        End Set
    End Property
End Class
