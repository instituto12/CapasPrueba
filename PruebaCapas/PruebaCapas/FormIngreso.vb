﻿Imports wflSistema
Public Class FormIngreso

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim x As New wflClientes

        Dim dt As New DataTable

        If txtIdCliente.Text = Nothing Then
            x.obtenerRegistroCuil(txtCUIL.Text, dt)
        Else

            x.obtenerRegistro(txtIdCliente.Text, dt)
            'MsgBox("BUSQUEDA POR CLIENTE", vbInformation + vbOKOnly, "Aviso al operador")

        End If

        If dt.Rows.Count > 0 Then
            For Each MiDataRow As DataRow In dt.Rows
                Me.txtIdCliente.Text = MiDataRow(0).ToString()
                Me.txtrazonsocial.Text = MiDataRow(1).ToString()
                Me.txtpaginaweb.Text = MiDataRow(4).ToString()
                Me.txtCUIL.Text = MiDataRow(2).ToString()
                Me.txtapellido.Text = MiDataRow(3).ToString()
            Next
        Else
            MsgBox("El cliente no existe en la base de datos", vbInformation + vbOKOnly, "Aviso al operador")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.insertarRegistro(strmensaje, txtIdCliente.Text, txtCUIL.Text, txtrazonsocial.Text, txtapellido.Text, paginaweb.Text)

        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

        Me.LimpiaPantalla()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.eliminarRegistro(txtIdCliente.Text, strmensaje)
        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

        Me.LimpiaPantalla()

    End Sub
    Public Sub LimpiaPantalla()
        txtIdCliente.Text = ""
        txtrazonsocial.Text = ""
        txtCUIL.Text = ""
        txtpaginaweb.Text = ""

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcalle_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCUIL_TextChanged(sender As Object, e As EventArgs) Handles txtCUIL.TextChanged

    End Sub

    Private Sub txtLocalidad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
