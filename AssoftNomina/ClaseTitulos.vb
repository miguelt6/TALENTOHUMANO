Public Class ClaseTitulos
    Private Id_titulo As Integer
    Private Id_persona As String
    Private Institucion As String
    Private Fecha As Date

    Public Property Proidtitulo() As Integer
        Get
            Return Id_titulo
        End Get
        Set(ByVal value As Integer)
            Id_titulo = value
        End Set
    End Property

    Public Property Propersona() As String
        Get
            Return Id_persona
        End Get
        Set(ByVal value As String)
            Id_persona = value
        End Set
    End Property

    Public Property Proinstitucion() As String
        Get
            Return Institucion
        End Get
        Set(ByVal value As String)
            Institucion = value
        End Set
    End Property

    Public Property Profecha() As Date
        Get
            Return Fecha
        End Get
        Set(ByVal value As Date)
            Fecha = value
        End Set
    End Property
End Class
