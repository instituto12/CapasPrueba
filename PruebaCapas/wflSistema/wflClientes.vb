Imports brlSistema
Public Class wflClientes
    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)
        Dim x As New brlClientes
        x.obtenerRegistro(idcliente, clientes)

    End Sub

    Public Sub insertarRegistro(ByVal idcliente As Integer, ByVal strrazonsocial As String, ByRef strmensaje As String, ByRef calle As String, ByRef CUIL As String)
        Dim x As New brlClientes
        Dim id As Integer

        If Not x.ExisteCliente(idcliente) Then
            If Not x.ExisteCUIL(CUIL, id) Then
                x.insertarRegistro(idcliente, strrazonsocial, calle, CUIL)
                strmensaje = "El cliente se agrego con exito"
            Else
                strmensaje = "El CUIL ya fue ingresado para el IdCliente " & id.ToString()
            End If
        Else
            strmensaje = "El cliente ya existe en la base"
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
