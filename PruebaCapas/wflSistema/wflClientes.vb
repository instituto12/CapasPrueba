Imports brlSistema
Public Class wflClientes
    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)

        Dim x As New brlClientes
        'MsgBox("WFL-busca ID", vbInformation + vbOKOnly, "Aviso al operador")
        x.obtenerRegistro(idcliente, clientes)

    End Sub
    Public Sub obtenerRegistroCuil(ByVal CUIL As String, ByRef clientes As DataTable)

        Dim x As New brlClientes

        x.obtenerRegistroCuil(CUIL, clientes)

    End Sub



    Public Sub insertarRegistro(ByRef strmensaje As String,
                                ByRef idcliente As Integer,
                                ByRef CUIL As String,
                                ByVal strrazonsocial As String,
                                ByRef calle As String,
                                ByRef email As String,
                                ByRef dirWeb As String,
                                ByRef telefono As String,
                                ByRef telefonocelular As String)
        Dim x As New brlClientes
        Dim clientes As New DataTable
        Dim id As Integer

        If Not x.ExisteCliente(idcliente) Then

            If Not x.ExisteCUIL(CUIL) Then
                x.insertarRegistro(idcliente, CUIL, strrazonsocial, calle, email, dirWeb, telefono, telefonocelular)
                strmensaje = "El cliente se agrego con exito"
            Else
                x.obtenerRegistroCuil(CUIL, clientes)
                If clientes.Rows.Count > 0 Then
                    id = clientes.Rows(0)("idcliente")
                    strmensaje = "El CUIL ya fue ingresado para el IdCliente: " & id.ToString()
                End If
            End If
        Else
            strmensaje = "El cliente Nº: " & idcliente & " ya existe en la base"
        End If

    End Sub

    Public Sub eliminarRegistro(ByVal idcliente As Integer, ByRef strmensaje As String)
        Dim x As New brlClientes
        If x.ExisteCliente(idcliente) Then
            x.eliminarRegistro(idcliente)
            strmensaje = "El cliente se eliminó con exito"
        Else
            strmensaje = "El cliente no existe en la base"
        End If
    End Sub
    'En las wFL generalmente van procesos complejos que invlucran
    ' llamados a las otras capas. 
    ' Ejemplo Procesar Consumos Cliente
    ' En ese caso debere tener en la dtl un una dtl de facturas
    ' Una brl de facturas
    ' y aca traerlas y trabajarlas.
End Class
