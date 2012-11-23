Public Class ClasePersona
    Private Codigo As Integer
    Private Cedula As String
    Private Rif As String
    Private Nombres As String
    Private Apellidos As String
    Private FechaNacimiento As Date
    Private LugarNacimiento As String
    Private Sexo As Integer
    Private EdoCivil As Integer
    Private Foto As String
    Private Direccion As String
    Private PuntoReferencia As String
    Private TelefonoHabitacion As String
    Private TelefonoMovil As String
    Private CorreoElectronico As String
    Private NombreContacto As String
    Private DescripcionContacto As String
    Private TelefonoContacto As String
    Private TelefonoMovilContacto As String
    Private GrupoSanguineo As String
    Private Altura As Integer
    Private Peso As Integer
    Private TallaPantalon As Integer
    Private TallaCamisa As String
    Private TallaCalzado As Integer
    Private Lentes As Boolean
    Private Fuma As Boolean
    Private Operaciones As Boolean
    Private Incapacitado As Boolean
    Private Alergias As String
    Private Enfermedades As String
    Private Estatus As Integer = 1
    Private Banco As Integer
    Private CuentaBancaria As String
    Private Certificado As Boolean
    Private Profesion As Integer
    Private Habilidades As String
    Private Dedo_1 As Integer
    Private Dedo_2 As Integer
    Private fechapreempleo As Date

    Public Property ProCodigo() As String
        Get
            Return Codigo
        End Get
        Set(ByVal value As String)
            Codigo = value
        End Set
    End Property

    Public Property ProCedula() As String
        Get
            Return Cedula
        End Get
        Set(ByVal value As String)
            Cedula = value
        End Set
    End Property

    Public Property ProRif() As String
        Get
            Return Rif
        End Get
        Set(ByVal value As String)
            Rif = value
        End Set
    End Property

    Public Property ProNombres() As String
        Get
            Return Nombres
        End Get
        Set(ByVal value As String)
            Nombres = value
        End Set
    End Property

    Public Property ProApellidos() As String
        Get
            Return Apellidos
        End Get
        Set(ByVal value As String)
            Apellidos = value
        End Set
    End Property
    Public Property ProFechaNacimiento() As Date
        Get
            Return FechaNacimiento
        End Get
        Set(ByVal value As Date)
            FechaNacimiento = value
        End Set
    End Property
    Public Property ProLugarNacimiento() As String
        Get
            Return LugarNacimiento
        End Get
        Set(ByVal value As String)
            LugarNacimiento = value
        End Set
    End Property
    Public Property ProSexo() As Integer
        Get
            Return Sexo
        End Get
        Set(ByVal value As Integer)
            Sexo = value
        End Set
    End Property
    Public Property ProEdoCivil() As Integer
        Get
            Return EdoCivil
        End Get
        Set(ByVal value As Integer)
            EdoCivil = value
        End Set
    End Property
    Public Property ProFoto() As String
        Get
            Return Foto
        End Get
        Set(ByVal value As String)
            Foto = value
        End Set
    End Property
    Public Property ProDireccion() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value
        End Set
    End Property
    Public Property ProPuntoReferencia() As String
        Get
            Return PuntoReferencia
        End Get
        Set(ByVal value As String)
            PuntoReferencia = value
        End Set
    End Property
    Public Property ProTelefonoHabitacion() As String
        Get
            Return TelefonoHabitacion
        End Get
        Set(ByVal value As String)
            TelefonoHabitacion = value
        End Set
    End Property
    Public Property ProTelefonoMovil() As String
        Get
            Return TelefonoMovil
        End Get
        Set(ByVal value As String)
            TelefonoMovil = value
        End Set
    End Property
    Public Property ProCorreoElectronico() As String
        Get
            Return CorreoElectronico
        End Get
        Set(ByVal value As String)
            CorreoElectronico = value
        End Set
    End Property
    Public Property ProNombreContacto() As String
        Get
            Return NombreContacto
        End Get
        Set(ByVal value As String)
            NombreContacto = value
        End Set
    End Property
    Public Property ProDescripcionContacto() As String
        Get
            Return DescripcionContacto
        End Get
        Set(ByVal value As String)
            DescripcionContacto = value
        End Set
    End Property
    Public Property ProTelefonoContacto() As String
        Get
            Return TelefonoContacto
        End Get
        Set(ByVal value As String)
            TelefonoContacto = value
        End Set
    End Property
    Public Property ProTelefonoMovilContacto() As String
        Get
            Return TelefonoMovilContacto
        End Get
        Set(ByVal value As String)
            TelefonoMovilContacto = value
        End Set
    End Property
    Public Property ProGrupoSanguineo() As String
        Get
            Return GrupoSanguineo
        End Get
        Set(ByVal value As String)
            GrupoSanguineo = value
        End Set
    End Property

    Public Property ProAltura() As Integer
        Get
            Return Altura
        End Get
        Set(ByVal value As Integer)
            Altura = value
        End Set
    End Property
    Public Property ProPeso() As Integer
        Get
            Return Peso
        End Get
        Set(ByVal value As Integer)
            Peso = value
        End Set
    End Property
    Public Property ProTallaPantalon() As Integer
        Get
            Return TallaPantalon
        End Get
        Set(ByVal value As Integer)
            TallaPantalon = value
        End Set
    End Property
    Public Property ProTallaCalzado() As Integer
        Get
            Return TallaCalzado
        End Get
        Set(ByVal value As Integer)
            TallaCalzado = value
        End Set
    End Property
    Public Property ProTallaCamisa() As String
        Get
            Return TallaCamisa
        End Get
        Set(ByVal value As String)
            TallaCamisa = value
        End Set
    End Property
    Public Property ProEnfermedades() As String
        Get
            Return Enfermedades
        End Get
        Set(ByVal value As String)
            Enfermedades = value
        End Set
    End Property

    Public Property ProAlergias() As String
        Get
            Return Alergias
        End Get
        Set(ByVal value As String)
            Alergias = value
        End Set
    End Property
    Public Property ProLentes() As Boolean
        Get
            Return Lentes
        End Get
        Set(ByVal value As Boolean)
            Lentes = value
        End Set
    End Property
    Public Property ProFuma() As Boolean
        Get
            Return Fuma
        End Get
        Set(ByVal value As Boolean)
            Fuma = value
        End Set
    End Property
    Public Property ProOperaciones() As Boolean
        Get
            Return Operaciones
        End Get
        Set(ByVal value As Boolean)
            Operaciones = value
        End Set
    End Property
    Public Property ProIncapacitado() As Boolean
        Get
            Return Incapacitado
        End Get
        Set(ByVal value As Boolean)
            Incapacitado = value
        End Set
    End Property
    Public Property ProEstatus() As String
        Get
            Return Estatus
        End Get
        Set(ByVal value As String)
            Estatus = value
        End Set
    End Property
    Public Property ProBanco() As Integer
        Get
            Return Banco
        End Get
        Set(ByVal value As Integer)
            Banco = value
        End Set
    End Property
    Public Property ProCuentaBancaria() As String
        Get
            Return CuentaBancaria
        End Get
        Set(ByVal value As String)
            CuentaBancaria = value
        End Set
    End Property    
    Public Property ProCertificado() As Boolean
        Get
            Return Certificado
        End Get
        Set(ByVal value As Boolean)
            Certificado = value
        End Set
    End Property
    Public Property ProProfesion() As Integer
        Get
            Return Profesion
        End Get
        Set(ByVal value As Integer)
            Profesion = value
        End Set
    End Property
    Public Property ProHabilidades() As String
        Get
            Return Habilidades
        End Get
        Set(ByVal value As String)
            Habilidades = value
        End Set
    End Property
    Public Property ProDedo_1() As Integer
        Get
            Return Dedo_1
        End Get
        Set(ByVal value As Integer)
            Dedo_1 = value
        End Set
    End Property
    Public Property ProDedo_2() As Integer
        Get
            Return Dedo_2
        End Get
        Set(ByVal value As Integer)
            Dedo_2 = value
        End Set
    End Property
    Public Property ProFechaPreEmpleo() As Date
        Get
            Return fechapreempleo
        End Get
        Set(ByVal value As Date)
            fechapreempleo = value
        End Set
    End Property
End Class
