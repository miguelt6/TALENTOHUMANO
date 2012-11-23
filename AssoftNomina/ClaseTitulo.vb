Public Class ClaseTitulo
    Private Id As Integer
    Private descripcion As String

    Public Property Proid() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property

    Public Property Prodescripcion() As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property
End Class
