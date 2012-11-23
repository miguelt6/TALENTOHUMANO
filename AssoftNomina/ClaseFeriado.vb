Public Class ClaseFeriado
    Private Fecha As Date
    
    Public Property ProFecha() As Date
        Get
            Return Fecha
        End Get
        Set(ByVal value As Date)
            Fecha = value
        End Set
    End Property
End Class
