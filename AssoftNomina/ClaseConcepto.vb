Public Class ClaseConcepto
    Private Codigo As Integer
    Private Descripcion As String
    Private Proceso As Integer
    Private Formula As String
    Private Estado As Boolean
    Private Tipo As Integer

    Public Property ProDescripcion() As String
        Get
            Return Descripcion
        End Get
        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property
    Public Property ProProceso() As Integer
        Get
            Return Proceso
        End Get
        Set(ByVal value As Integer)
            Proceso = value
        End Set
    End Property

    Public Property ProFormula() As String
        Get
            Return Formula
        End Get
        Set(ByVal value As String)
            Formula = value
        End Set
    End Property

    Public Property ProEstado() As Boolean
        Get
            Return Estado
        End Get
        Set(ByVal value As Boolean)
            Estado = value
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

    Public Property ProCodigo() As Integer
        Get
            Return Codigo
        End Get
        Set(ByVal value As Integer)
            Codigo = value
        End Set
    End Property
End Class
