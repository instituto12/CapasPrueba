Imports System.Data.SqlClient
Public Class dtlClientes

    Private Property oConn As SqlConnection



    Public Sub obtenerRegistro(ByRef idcliente As Integer, ByRef clientes As DataTable)

        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")

        If oConn.State = 1 Then oConn.Close()
        oConn.Open()

        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()

        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión

        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.CommandText = "Clientes_obtenerRegistro"

        Adp.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int, 0)
        Adp.SelectCommand.Parameters("@idcliente").Value = idcliente

        Adp.Fill(table)

        clientes = table

        oConn.Close()

    End Sub

    Public Sub obtenerRegistroCuil(ByRef CUIL As String, ByRef clientes As DataTable)

        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")

        If oConn.State = 1 Then oConn.Close()
        oConn.Open()

        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()

        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión

        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.CommandText = "clientes_obtenerRegistroPorCUIL"

        Adp.SelectCommand.Parameters.Add("@CUIL", SqlDbType.Char, 11)
        Adp.SelectCommand.Parameters("@CUIL").Value = CUIL

        Adp.Fill(table)

        clientes = table

        oConn.Close()

    End Sub

    Public Sub insertarRegistro(ByRef intidcliente As Integer, ByRef CUIL As String, ByRef strrazonSocial As String, ByRef calle As String, Optional ByRef email As String = Nothing, Optional ByRef dirWeb As String = Nothing, Optional ByRef telefono As String = Nothing, Optional ByRef telefonocelular As String = Nothing, Optional ByRef localidad As String = Nothing)
        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(8) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)
        param(1) = New SqlParameter("@razonsocial", strrazonSocial)
        param(2) = New SqlParameter("@cuil", CUIL)
        param(3) = New SqlParameter("@calle", calle)
        ' Andrés: Modifico la propiedad de cada instancia de parámetro para que se pueda pasar nulos.
        param(4) = New SqlParameter("@email", SqlDbType.VarChar)
        param(4).IsNullable = True
        param(4).Value = IIf(email Is Nothing, DBNull.Value, email)
        param(5) = New SqlParameter("@dirWeb", SqlDbType.VarChar)
        param(5).IsNullable = True
        param(5).Value = IIf(dirWeb Is Nothing, DBNull.Value, dirWeb)
        param(6) = New SqlParameter("@telefono", SqlDbType.VarChar)
        param(6).IsNullable = True
        param(6).Value = IIf(telefono Is Nothing, DBNull.Value, telefono)
        param(7) = New SqlParameter("@telefonocelular", SqlDbType.VarChar)
        param(7).IsNullable = True
        param(7).Value = IIf(telefonocelular Is Nothing, DBNull.Value, telefonocelular)
        param(8) = New SqlParameter("@localidad", SqlDbType.VarChar)
        param(8).IsNullable = True
        param(8).Value = IIf(localidad Is Nothing, DBNull.Value, localidad)







        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "clientes_insertarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarRegistro(ByRef intidcliente As Integer)
        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "clientes_eliminarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

  
End Class
