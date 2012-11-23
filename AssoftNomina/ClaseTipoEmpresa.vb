Public Class ClaseTipoEmpresa
    Private Descripcion As String


    Public Property ProDescripcion() As String
        Get
            Return Descripcion
        End Get
        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property
End Class
