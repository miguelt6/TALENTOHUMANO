Public Class ClaseVariable
    Private NombreCorto As String
    Private Descripcion As String
    Private Valor As String
    Private Tipo As Integer

    Public Property ProNombreCorto() As String
        Get
            Return NombreCorto
        End Get
        Set(ByVal value As String)
            NombreCorto = value
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

    Public Property ProValor() As String
        Get
            Return Valor
        End Get
        Set(ByVal value As String)
            Valor = value
        End Set
    End Property

    Public Property ProTipo() As Integer
        Get
            Return Tipo
        End Get
        Set(ByVal value As Integer)
            Tipo = value
        End Set
    End Property
End Class
