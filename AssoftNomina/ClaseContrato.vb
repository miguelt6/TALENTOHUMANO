Public Class ClaseContrato
    Private id As Integer
    Private Descripcion As String
    Private Fk_Cedula As String
    Private Cargo As Integer
    Private Tipo_Horario As Integer
    Private Sueldo As Double
    Private FechaInicial As Date
    Private FechaFinal As Date
    Private Duracion As Integer
    Private Tipo_Pago As Integer
    Private Fk_Banco As Integer
    Private Fk_Nomina As Integer
    Private Cuenta As String
    Private Frecuencia As String
    Private FechaEgreso As Date
    Private Fk_Cedula_Cubrir As String
    Private Jornada_Diaria As Double

    Public Property ProId() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
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
    Public Property ProFk_Cedula() As String
        Get
            Return Fk_Cedula
        End Get
        Set(ByVal value As String)
            Fk_Cedula = value
        End Set
    End Property
    Public Property ProCargo() As Integer
        Get
            Return Cargo
        End Get
        Set(ByVal value As Integer)
            Cargo = value
        End Set
    End Property
    Public Property ProTipoHorario() As Integer
        Get
            Return Tipo_Horario
        End Get
        Set(ByVal value As Integer)
            Tipo_Horario = value
        End Set
    End Property
    Public Property ProSueldo() As Double
        Get
            Return Sueldo
        End Get
        Set(ByVal value As Double)
            Sueldo = value
        End Set
    End Property
    Public Property ProFechaInicial() As Date
        Get
            Return FechaInicial
        End Get
        Set(ByVal value As Date)
            FechaInicial = value
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
    Public Property ProDuracion() As Integer
        Get
            Return Duracion
        End Get
        Set(ByVal value As Integer)
            Duracion = value
        End Set
    End Property
    Public Property ProTipoPago() As Integer
        Get
            Return Tipo_Pago
        End Get
        Set(ByVal value As Integer)
            Tipo_Pago = value
        End Set
    End Property
    Public Property ProFkBanco() As Integer
        Get
            Return Fk_Banco
        End Get
        Set(ByVal value As Integer)
            Fk_Banco = value
        End Set
    End Property
    Public Property ProFkNomina() As Integer
        Get
            Return Fk_Nomina
        End Get
        Set(ByVal value As Integer)
            Fk_Nomina = value
        End Set
    End Property
    Public Property ProCuenta() As String
        Get
            Return Cuenta
        End Get
        Set(ByVal value As String)
            Cuenta = value
        End Set
    End Property
    Public Property ProFrecuencia() As String
        Get
            Return Frecuencia
        End Get
        Set(ByVal value As String)
            Frecuencia = value
        End Set
    End Property
    Public Property ProFechaEgreso() As Date
        Get
            Return FechaEgreso
        End Get
        Set(ByVal value As Date)
            FechaEgreso = value
        End Set
    End Property
    Public Property ProFk_Cedula_Cubrir() As String
        Get
            Return Fk_Cedula_Cubrir
        End Get
        Set(ByVal value As String)
            Fk_Cedula_Cubrir = value
        End Set
    End Property
    Public Property ProJornadaDiaria() As Double
        Get
            Return Jornada_Diaria
        End Get
        Set(ByVal value As Double)
            Jornada_Diaria = value
        End Set
    End Property
End Class
