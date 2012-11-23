Public Class ClasePais
    Private Codigo As Integer
    Private Descripcion As String

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
End Class
