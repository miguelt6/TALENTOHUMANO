Public Class ClaseEstados
    Private Codigo As Integer
    Private Descripcion As String
    Private Fk_Pais As Integer

    Public Property ProCodigo() As Integer
        Get
            Return Codigo
        End Get
        Set(ByVal value As Integer)
            Codigo = value
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
    Public Property ProFk_Pais() As Integer
        Get
            Return Fk_Pais
        End Get
        Set(ByVal value As Integer)
            Fk_Pais = value
        End Set
    End Property

End Class
