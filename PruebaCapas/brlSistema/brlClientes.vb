﻿Imports dtlSistema
Public Class brlClientes

    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        'MsgBox("BRL-busca ID", vbInformation + vbOKOnly, "Aviso al operador")
        x.obtenerRegistro(idcliente, clientes)
    End Sub
    Public Sub obtenerRegistroCuil(ByVal CUIL As String, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        x.obtenerRegistroCuil(CUIL, clientes)
    End Sub

    Public Sub insertarRegistro(ByVal idcliente As Integer, ByRef CUIL As String, ByRef strrazonsocial As String, ByRef calle As String, ByRef email As String, ByRef dirWeb As String, ByRef telefono As String)
        Dim x As New dtlClientes
        x.insertarRegistro(idcliente, CUIL, strrazonsocial, calle, email, dirWeb, telefono)
    End Sub

    Public Function ExisteCliente(ByVal idcliente As Integer) As Boolean
        Dim x As New dtlClientes
        Dim clientes As New DataTable

        x.obtenerRegistro(idcliente, clientes)

        If clientes.Rows.Count > 0 Then
            ExisteCliente = True
        Else
            ExisteCliente = False
        End If
    End Function

    Public Function ExisteCUIL(ByVal CUIL As String) As Boolean
        Dim x As New dtlClientes
        Dim clientes As New DataTable
        'Dim idcliente As Integer

        x.obtenerRegistroCuil(CUIL, clientes)

        If clientes.Rows.Count > 0 Then
            'idcliente = clientes.Rows(0)("idcliente")
            ExisteCUIL = True
        Else
            ExisteCUIL = False
        End If
    End Function

    ''' <summary>
    ''' Este es un metodo que elimina un cliente dado su id
    ''' </summary>
    ''' <param name="idcliente"></param>
    ''' <remarks></remarks>
    Public Sub eliminarRegistro(ByVal idcliente As Integer)
        Dim x As New dtlClientes
        x.eliminarRegistro(idcliente)
    End Sub
End Class
