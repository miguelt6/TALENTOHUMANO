Public Class ClaseGrupoNomina    
    Private Descripcion As String
    Private Frecuencia As Integer
    Private FormaPago As Integer

    Public Property ProDescripcion() As String
        Get
            Return Descripcion
        End Get
        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property ProFrecuencia() As Integer
        Get
            Return Frecuencia
        End Get
        Set(ByVal value As Integer)
            Frecuencia = value
        End Set
    End Property
    Public Property ProFormaPago() As Integer
        Get
            Return FormaPago
        End Get
        Set(ByVal value As Integer)
            FormaPago = value
        End Set
    End Property
End Class
