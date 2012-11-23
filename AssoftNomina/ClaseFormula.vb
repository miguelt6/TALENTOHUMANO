Public Class ClaseFormula

    'El codigo de la variable a resolver con la formula asociada
    Private Variable As String
    ' Formula definida por el usuario, la cual se resuleve dinàmicamente
    Private formulaDescriptiva As String
    ' Resultado de la operacion
    Private resultado As Double
    'Lista de Operando o variables que conforman la formula. Estos se
    ' obtienen al desglozar la formula en sus componentes, sin operadores
    Private listaOperandos As New Collection
    ' Lista del valor de cada operando o variable de la formula. Estos
    'valores son los que entran a operar en la formula asociada.
    Private listaValores As Double()
    ' Tabla para desplegar el resultado
    Public Tbl As New DataTable()


    'Estas propiedades permites pasar los datos desde esta clase a la
    'clase llamadora
    Public Property ProVariable() As String
        Get
            Return Variable
        End Get
        Set(ByVal value As String)
            Variable = value
        End Set
    End Property
    Public Property ProFormuladescriptiva() As String
        Get
            Return formulaDescriptiva
        End Get
        Set(ByVal value As String)
            formulaDescriptiva = value
        End Set
    End Property
    Public Property ProResultado() As Double
        Get
            Return resultado
        End Get
        Set(ByVal value As Double)
            resultado = value
        End Set
    End Property

    Public Function Procesar(ByVal formula As String)
        desglozarformula(formula)
        Return VerificarFormula()
    End Function

    Public Sub desglozarformula(ByVal formula As String)
        'Se debe llenar este array ListaOperandos(), con los operandos
        'componentes de la formula obtenida arriba. Este proceso debe asegurar 
        'estos compoentes son solo operandos o constantes numèricas, pero
        'no operadores. Aqui, para efecto del ejemplo se asume que la formula
        'fue desglozada asì:
        Dim fraseformula As String = ""
        Dim i As Integer
        Dim j As Integer = 0
        For i = 0 To formula.Length - 1
            If formula(i) <> "+" And formula(i) <> "-" And formula(i) <> "/" And formula(i) <> "*" And formula(i) <> "(" And formula(i) <> ")" And formula(i) <> " " Then
                fraseformula = fraseformula + formula(i)
            Else
                If fraseformula <> "" Then
                    listaOperandos.Add(fraseformula)
                    fraseformula = ""
                    'MsgBox(listaOperandos.Item(listaOperandos.Count))
                End If
            End If
        Next i
        If fraseformula <> "" Then
            listaOperandos.Add(fraseformula)
            ' MsgBox(listaOperandos.Item(listaOperandos.Count))
        End If
    End Sub

    Public Sub LeerValorOperandos()
        'Para cada operando de la lista anterior, ListaOperandos[], se obtiene
        'un valor que està grabado en la Base de Datos, y que son resultados
        'de digitaciones o de otros càlculos. Esta nueva lista de valores, se
        'debe llenar con datos que se relacionan con la lista de arriba.
        'Por simplicidad se asume que se llena asì:
        listaValores(0) = 1000000
        listaValores(1) = 800000
        listaValores(2) = 1.2
        listaValores(3) = 0
        listaValores(4) = 0
    End Sub

    Public Function VerificarFormula()
        'Se crea una tabla en memoria con los datos de la listaOperandos, o sea
        'los campos o componentes de la formula. Al final se inluye siempre el
        'campo RESULTADOS de tipo expresion, el cual contiene la formula leida
        'arriba para la variable en proceso: en este caso UTILIDAD. 

        Tbl.Columns.Add("VARIABLE")
        Dim i As Integer = 1
        While i <= listaOperandos.Count
            Tbl.Columns.Add(listaOperandos.Item(i), System.Type.GetType("System.Double"))
            i += 1
        End While

        Try
            Tbl.Columns.Add("Respuesta", System.Type.GetType("System.Double"), formulaDescriptiva)
        Catch ex As DataException
            MsgBox(ex.Message.ToString)
            Return False
        End Try
        'Dim linea As DataRow
        'linea = Tbl.NewRow
        'Crea una nueva línea
        'Coloca los datos en cada una de las columnas de esta línea
        'linea(0) = "Suma"
        'linea(1) = 10 'listaValores(0)
        'linea(2) = 80 'listaValores(1)
        'linea(3) = 3 'listaValores(2)
        'Tbl.Rows.Add(linea)
        'Agrega la línea en la tabla
        'Esta tabla la toma la clase llamadora para su despliegue
        Return True
    End Function
    Public Function CalcularFormula()
        'Se crea una tabla en memoria con los datos de la listaOperandos, o sea
        'los campos o componentes de la formula. Al final se inluye siempre el
        'campo RESULTADOS de tipo expresion, el cual contiene la formula leida
        'arriba para la variable en proceso: en este caso UTILIDAD. 

        Tbl.Columns.Add("VARIABLE")
        Dim i As Integer = 1
        While i <= listaOperandos.Count
            Tbl.Columns.Add(listaOperandos.Item(i), System.Type.GetType("System.Double"))
            i += 1
        End While

        Try
            Tbl.Columns.Add("Respuesta", System.Type.GetType("System.Double"), formulaDescriptiva)
        Catch ex As DataException
            MsgBox(ex.Message.ToString)
            Return False
        End Try
        'Dim linea As DataRow
        'linea = Tbl.NewRow
        'Crea una nueva línea
        'Coloca los datos en cada una de las columnas de esta línea
        'linea(0) = "Suma"
        'linea(1) = 10 'listaValores(0)
        'linea(2) = 80 'listaValores(1)
        'linea(3) = 3 'listaValores(2)
        'Tbl.Rows.Add(linea)
        'Agrega la línea en la tabla
        'Esta tabla la toma la clase llamadora para su despliegue
        Return True
    End Function
End Class
