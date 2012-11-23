Imports MySQLDriverCS
Public Class ClaseBaseDatos
    Private DBCon As MySQLConnection
    Public Property ProDBCon() As MySQLConnection
        Get
            Return DBCon
        End Get
        Set(ByVal value As MySQLConnection)
            DBCon = value
        End Set
    End Property
    Function Conectar()
        Dim bConexionExitosa As Boolean = True
        DBCon = New MySQLConnection(New MySQLConnectionString("192.168.6.21", "nomina", "root", "Adminorion1", 3306).AsString)
        Try
            'Abrimos la conexión y comprobamos que no hay error
            DBCon.Open()
        Catch ex As MySQLException
            'Si hubiese error en la conexión mostramos el texto de la descripción
            MsgBox(ex.Message.ToString)
            bConexionExitosa = False
        End Try
        Return bConexionExitosa
    End Function
    Function Cerrar_Conexion()
        DBCon.Dispose()
        DBCon.Close()
        Return True
    End Function
    Function Insertar(ByVal Sentencia As String)
        'Instanciamos un objeto de la clase MySQLCommand utilizando el constructor por defecto
        Dim sql As MySQLCommand = New MySQLCommand
        'Establecemos el tipo Connection que usará para realizar la petición
        sql.Connection = DBCon
        'Escribimos la consulta que deseamos en T-SQL. Nuestro ejemplo buscará todos
        'los nombres cuya segunda letra sea 'a' y penúltima 'e'
        sql.CommandText = Sentencia
        'Como el comando no es almacenado ni vinculado a un tabla elegimos el tipo .Text
        sql.CommandType = CommandType.Text
        sql.ExecuteReader()
        Return True
    End Function
    Function Seleccionar(ByVal Sentencia As String)
        'Instanciamos un objeto de la clase MySQLCommand utilizando el constructor por defecto
        Dim sql As MySQLCommand = New MySQLCommand
        'Establecemos el tipo Connection que usará para realizar la petición
        sql.Connection = DBCon
        'Escribimos la consulta que deseamos en T-SQL. Nuestro ejemplo buscará todos
        'los nombres cuya segunda letra sea 'a' y penúltima 'e'
        sql.CommandText = Sentencia
        'Como el comando no es almacenado ni vinculado a un tabla elegimos el tipo .Text
        sql.CommandType = CommandType.Text
        'Creamos un lector de datos (IDataReader) y lo inicializamos
        'con el lector del objeto MySQLCommand
        Dim dr As System.Data.IDataReader
        dr = Sql.ExecuteReader()
        'Mientras haya datos para leer los mostramos        
        Return dr
    End Function    
End Class
