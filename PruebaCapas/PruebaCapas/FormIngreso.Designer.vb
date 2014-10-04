<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngreso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtrazonsocial = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtcalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCUIL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDirWeb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefonocelular = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Razón Social:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(129, 24)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(66, 20)
        Me.txtIdCliente.TabIndex = 0
        '
        'txtrazonsocial
        '
        Me.txtrazonsocial.Location = New System.Drawing.Point(129, 77)
        Me.txtrazonsocial.Name = "txtrazonsocial"
        Me.txtrazonsocial.Size = New System.Drawing.Size(234, 20)
        Me.txtrazonsocial.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(48, 296)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(187, 50)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Buscar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(171, 296)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 8
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(288, 296)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtcalle
        '
        Me.txtcalle.Location = New System.Drawing.Point(129, 103)
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(234, 20)
        Me.txtcalle.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Calle:"
        '
        'txtCUIL
        '
        Me.txtCUIL.Location = New System.Drawing.Point(253, 21)
        Me.txtCUIL.Name = "txtCUIL"
        Me.txtCUIL.Size = New System.Drawing.Size(110, 20)
        Me.txtCUIL.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CUIL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "e-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(129, 133)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(234, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dirección Web:"
        '
        'txtDirWeb
        '
        Me.txtDirWeb.Location = New System.Drawing.Point(129, 163)
        Me.txtDirWeb.Name = "txtDirWeb"
        Me.txtDirWeb.Size = New System.Drawing.Size(234, 20)
        Me.txtDirWeb.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(129, 197)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(234, 20)
        Me.txtTelefono.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Telefono celular:"
        '
        'txtTelefonocelular
        '
        Me.txtTelefonocelular.Location = New System.Drawing.Point(129, 232)
        Me.txtTelefonocelular.Name = "txtTelefonocelular"
        Me.txtTelefonocelular.Size = New System.Drawing.Size(234, 20)
        Me.txtTelefonocelular.TabIndex = 17
        '
        'FormIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 381)
        Me.Controls.Add(Me.txtTelefonocelular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDirWeb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCUIL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtrazonsocial)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormIngreso"
        Me.Text = "Ingreso de clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtrazonsocial As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtcalle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCUIL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDirWeb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonocelular As System.Windows.Forms.TextBox

End Class
