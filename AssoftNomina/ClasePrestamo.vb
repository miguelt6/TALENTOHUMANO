Public Class ClasePrestamo
    Private Fk_Cedula As String
    Private Monto As Double
    Private Num_Cuotas As Integer
    Private Pago As Integer
    Private Cobro As Integer
    Private FechaInicio As Date
    Private FechaFinal As Date

    Public Property ProFk_Cedula() As String
        Get
            Return Fk_Cedula
        End Get
        Set(ByVal value As String)
            Fk_Cedula = value
        End Set
    End Property
    Public Property ProMonto() As Double
        Get
            Return Monto
        End Get
        Set(ByVal value As Double)
            Monto = value
        End Set
    End Property

    Public Property ProNum_Cuotas() As Integer
        Get
            Return Num_Cuotas
        End Get
        Set(ByVal value As Integer)
            Num_Cuotas = value
        End Set
    End Property
    Public Property ProPago() As Integer
        Get
            Return Pago
        End Get
        Set(ByVal value As Integer)
            Pago = value
        End Set
    End Property
    Public Property ProCobro() As Integer
        Get
            Return Cobro
        End Get
        Set(ByVal value As Integer)
            Cobro = value
        End Set
    End Property
    Public Property ProFechaInicio() As Date
        Get
            Return FechaInicio
        End Get
        Set(ByVal value As Date)
            FechaInicio = value
        End Set
    End Property
    Public Property ProFechaFinal() As Date
        Get
            Return FechaFinal
        End Get
        Set(ByVal value As Date)
            FechaFinal = value
        End Set
    End Property
End Class
