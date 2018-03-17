Imports System.Net.Mail
Imports Backend

Public Class ModificarCliente
    Dim id_cliente
    Dim cliente_mod As New Cliente
    Public Sub New(ByVal cli As String)
        InitializeComponent()
        id_cliente = cli
    End Sub

    Private Sub ModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim daoCliente As New ClienteDAO

        cliente_mod = daoCliente.cargarCliente(id_cliente)
        txtNombre.Text = cliente_mod.nombre
        txtApellido.Text = cliente_mod.apellido
        txtCI.Text = cliente_mod.ci
        txtRUC.Text = cliente_mod.ruc
        dpFechaNc.Value = cliente_mod.fechaNaci
        txtTel.Text = cliente_mod.tel
        txtCelular.Text = cliente_mod.cel
        txtEmail.Text = cliente_mod.email
        If cliente_mod.sex = "F" Then
            cbSexo.SelectedIndex = 1
        Else
            cbSexo.SelectedIndex = 2
        End If

    End Sub

    Private Sub RectangleShape1_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape1.MouseMove, lblGUARDAR.MouseMove
        Me.SuspendLayout()
        lblGUARDAR.ForeColor = Color.WhiteSmoke
        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave, lblGUARDAR.MouseLeave
        Me.SuspendLayout()
        lblGUARDAR.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub


    Private Sub RectangleShape2_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape2.MouseMove, lblReset.MouseMove
        Me.SuspendLayout()
        lblReset.ForeColor = Color.WhiteSmoke
        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape2.MouseLeave, lblReset.MouseLeave
        Me.SuspendLayout()
        lblReset.ForeColor = Color.FromArgb(22, 23, 24)


        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape3.MouseMove, lblCancelar.MouseMove
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.WhiteSmoke
        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape3.MouseLeave, lblCancelar.MouseLeave
        Me.SuspendLayout()

        lblCancelar.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub guardarCliente(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblGUARDAR.Click
        Try
            If controlarCampos() Then
                Dim clienteModificado As New Cliente
                Dim daoCli As New ClienteDAO
                clienteModificado.id = id_cliente
                clienteModificado.nombre = txtNombre.Text
                clienteModificado.apellido = txtApellido.Text
                clienteModificado.ci = txtCI.Text
                clienteModificado.ruc = txtRUC.Text
                clienteModificado.tel = txtTel.Text
                clienteModificado.cel = txtCelular.Text
                clienteModificado.fechaNaci = dpFechaNc.Value.Date
                clienteModificado.email = txtEmail.Text
                If cbSexo.SelectedIndex = 1 Then
                    clienteModificado.sex = "F"
                Else
                    clienteModificado.sex = "M"
                End If
                daoCli.actualizarCliente(clienteModificado)
                MsgBox("¡Cliente Modificado con éxito!", MsgBoxStyle.Information, "Notificación")
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function controlarCampos() As Boolean
        Try
            If txtNombre.Text = "" Then
                MsgBox("Debe ingresar un nombre para el cliente", MsgBoxStyle.Critical, "Atención")
                txtNombre.Focus()
                Return False
            ElseIf txtApellido.Text = "" Then
                MsgBox("Debe ingresar un apellido para el cliente", MsgBoxStyle.Critical, "Atención")
                txtApellido.Focus()
                Return False
            ElseIf txtCI.Text = "" Then
                MsgBox("Debe ingresar una C.I para el cliente", MsgBoxStyle.Critical, "Atención")
                txtCI.Focus()
                Return False
            ElseIf cbSexo.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un sexo para el cliente", MsgBoxStyle.Critical, "Atención")
                cbSexo.Focus()
                Return False
                'ElseIf Not IsNumeric(txtDia.Text) Or Not IsNumeric(txtMes.Text) Or Not IsNumeric(txtAnho.Text) Then
                '    MsgBox("Ingrese una fecha de nacimiento válida", MsgBoxStyle.Critical, "Atención")
                '    txtDia.Focus()
                '    Return False
            ElseIf txtTel.Text = "" Then
                MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
                txtTel.Focus()
                Return False
            ElseIf txtCelular.Text = "" Then
                MsgBox("Debe ingresar un celular válido", MsgBoxStyle.Critical, "Atención")
                txtCelular.Focus()
                Return False
            ElseIf txtTel.Text = "" Then
                MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
                txtTel.Focus()
                Return False
            End If

            Dim testAddress = New MailAddress(txtEmail.Text)



        Catch ex As Exception

            MsgBox("Debe ingresar un email válido", MsgBoxStyle.Critical, "Atención")
            txtEmail.Focus()
            Return False
        End Try
        Return True
    End Function

    Private Sub refeshDatos(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblReset.Click
        txtNombre.Text = cliente_mod.nombre
        txtApellido.Text = cliente_mod.apellido
        txtCI.Text = cliente_mod.ci
        txtRUC.Text = cliente_mod.ruc
        dpFechaNc.Value = cliente_mod.fechaNaci
        txtTel.Text = cliente_mod.tel
        txtCelular.Text = cliente_mod.cel
        txtEmail.Text = cliente_mod.email
        If cliente_mod.sex = "F" Then
            cbSexo.SelectedIndex = 1
        Else
            cbSexo.SelectedIndex = 2
        End If
    End Sub

    Private Sub cancelarModificacion(sender As Object, e As EventArgs) Handles lblCancelar.Click, RectangleShape3.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub soloNumerosTxt(sender As Object, e As KeyPressEventArgs) Handles txtCI.KeyPress, txtTel.KeyPress, txtCelular.KeyPress
        soloNumeros(e)
    End Sub
End Class