Option Explicit On
Option Strict On
Option Compare Text
'Una vez a�adida la referencia a MySQLDriverCS.dll
'a�adimos la cl�sula Imports correspondiente
'#Region "C�digo generado por el Dise�ador[...]"
Imports MySQLDriverCS
Public Class ClaseConexion
    Inherits System.Windows.Forms.Form

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'La variable bConexionExitosa nos permitir� finalizar el 
        'programa si la conexi�n falla
        Dim bConexionExitosa As Boolean = True

        'Creamos un objeto de tipo Connection y configuramos los par�metros de la conexi�n
        Dim DBCon As MySQLConnection
        'Los par�metros de la sobrecarga con m�s par�metros son:
        '1. Direcci�n IP o nombre de la m�quina con el servidor de MySQLS
        '2. Nombre de la base de datos
        '3. Nombre de usuario con acceso a la base de datos se�alada anteriormente
        '4. Contrase�a para el nombre de usuario citado
        '5. Puerto por el que se acede al servidor. T�picamente 3306
        DBCon = New MySQLConnection(New MySQLConnectionString("192.168.1.41", "prueba", "ivan", "1234", 3306).AsString)

        Try
            'Abrimos la conexi�n y comprobamos que no hay error
            DBCon.Open()
        Catch ex As MySQLException
            'Si hubiese error en la conexi�n mostramos el texto de la descripci�n
            MsgBox(ex.Message.ToString)
            bConexionExitosa = False
        End Try

        'Si no hay ning�n problema continuamos
        If bConexionExitosa Then

            'EJEMPLO 1: Uso de la consulta predefinida MySQLSelectCommand, que ejecuta
            'una consulta SELECT

            'Definimos dos arrays de String, f y t, que contendr�n, respectivamente, los
            'campos (fields) que la consulta devolver� y la tablas sobre las que se ejecutar�.
            'Las cl�usulas WHERE y ORDER BY no las utilizaremos, de ah� los Nothing
            Dim f() As String = {"nombre"}
            Dim t() As String = {"tabla"}

            'Ejecutamos la consulta mediante el comando MySQLSelectCommand
            Dim dt As DataTable = New MySQLSelectCommand(DBCon, f, t, Nothing, Nothing, Nothing).Table
            'Si la consulta produjo alg�n resultado los mostraremos mediante un MsgBox
            'La clase DataTable contiene una colecci�n accesible mediante .Rows
            'en la que se almacenan los resultados como variables DataRow
            If (dt.Rows.Count <> 0) Then
                'Creamos una variable DataRow para contener los elementos resultantes
                Dim drow As DataRow
                'Al tratarse de una colecci�n podemos recorrerla mediante For Each...In
                For Each drow In dt.Rows
                    'DataRow tiene un m�todo por defecto llamado .Item(...) que permite
                    'devolver el elemento indicado por el �ndice o el nombre de la columna
                    MsgBox(drow("nombre"))
                Next
            End If


            'EJEMPLO 2: Uso de una consulta gen�rica en SQL utilizando el m�todo
            'MySQLCommand del Namespace MySQLDriverCS

            'Instanciamos un objeto de la clase MySQLCommand utilizando el constructor por defecto
            Dim sql As MySQLCommand = New MySQLCommand
            'Establecemos el tipo Connection que usar� para realizar la petici�n
            sql.Connection = DBCon
            'Escribimos la consulta que deseamos en T-SQL. Nuestro ejemplo buscar� todos
            'los nombres cuya segunda letra sea 'a' y pen�ltima 'e'
            sql.CommandText = "SELECT * FROM `tabla` WHERE `nombre` LIKE '%an';"
            'Como el comando no es almacenado ni vinculado a un tabla elegimos el tipo .Text
            sql.CommandType = CommandType.Text

            'Creamos un lector de datos (IDataReader) y lo inicializamos
            'con el lector del objeto MySQLCommand
            Dim dr As System.Data.IDataReader
            dr = sql.ExecuteReader()
            'Mientras haya datos para leer los mostramos
            While dr.Read()
                'Al igual de los objetos DataRow, la clase IDataReader tambi�n tiene
                'un m�todo por defecto .Item que funciona exactamente igual
                MsgBox(dr("nombre"))
            End While

            'Cerramos la conexi�n con el servidor
            DBCon.Close()
        End If
    End Sub

    Private Sub ClaseConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ClaseConexion
        '
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "ClaseConexion"
        Me.ResumeLayout(False)

    End Sub
End Class
