Public Class ClasePrivilegio
    Private Fk_Codigo_Usuario As Integer
    Private Fk_Codigo_Formulario As Integer

    Public Property ProFk_Codigo_Usuario() As Integer
        Get
            Return Fk_Codigo_Usuario
        End Get
        Set(ByVal value As Integer)
            Fk_Codigo_Usuario = value
        End Set
    End Property
    Public Property ProFk_Codigo_Formulario() As Integer
        Get
            Return Fk_Codigo_Formulario
        End Get
        Set(ByVal value As Integer)
            Fk_Codigo_Formulario = value
        End Set
    End Property
End Class
