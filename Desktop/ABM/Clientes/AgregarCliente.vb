Imports System.Globalization
Imports System.Net.Mail
Imports Backend

Public Class AgregarCliente
    Dim agregados = 0
    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSexo.SelectedIndex = 0
        txtNombre.Focus()
    End Sub

    Private Sub guardarCliente(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblGUARDAR.Click
        Try
            If controlarCampos() Then
                Dim clieDao As New ClienteDAO
                Dim clienteNuevo As New Cliente
                clienteNuevo.nombre = txtNombre.Text
                clienteNuevo.apellido = txtApellido.Text
                clienteNuevo.ci = txtCI.Text
                clienteNuevo.cel = txtCelular.Text
                clienteNuevo.email = txtEmail.Text
                clienteNuevo.tel = txtTelefono.Text
                clienteNuevo.ruc = txtRUC.Text
                If cbSexo.SelectedIndex = 1 Then
                    clienteNuevo.sex = "F"
                Else
                    clienteNuevo.sex = "M"
                End If
                Dim fechaNac = txtDia.Text + "/" + txtMes.Text + "/" + txtAnho.Text
                Dim fech = DateTime.Parse(fechaNac).Date
                'Date.TryParseExact(fechaNac, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyle.None, out fech)
                clienteNuevo.fechaNaci = fech
                clieDao.guardarCliente(clienteNuevo)
                Dim result As Integer = MessageBox.Show("¡Cliente registrado con éxito Desea continuar agregando? ", "Continuar", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Me.DialogResult = DialogResult.OK
                ElseIf result = DialogResult.Yes Then
                    agregados += 1
                    resetValores(sender, e)
                    txtNombre.Focus()
                End If

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
            ElseIf Not IsNumeric(txtDia.Text) Or Not IsNumeric(txtMes.Text) Or Not IsNumeric(txtAnho.Text) Then
                MsgBox("Ingrese una fecha de nacimiento válida", MsgBoxStyle.Critical, "Atención")
                txtDia.Focus()
                Return False
            ElseIf txtTelefono.Text = "" Then
                MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
                txtTelefono.Focus()
                Return False
            ElseIf txtCelular.Text = "" Then
                MsgBox("Debe ingresar un celular válido", MsgBoxStyle.Critical, "Atención")
                txtCelular.Focus()
                Return False
            ElseIf txtTelefono.Text = "" Then
                MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
                txtTelefono.Focus()
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

    Private Sub resetValores(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        txtNombre.Text = ""

        txtApellido.Text = ""
        txtCI.Text = ""
        cbSexo.SelectedIndex = 0
        txtDia.Text = "dd"
        txtMes.Text = "mm"
        txtAnho.Text = "aaaa"
        txtRUC.Text = ""

        txtTelefono.Text = ""

        txtCelular.Text = ""

        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        resetValores(sender, e)
    End Sub

    Private Sub cancelarNuevo(sender As Object, e As EventArgs) Handles RectangleShape3.Click, lblCancelar.Click
        If agregados = 0 Then
            Me.DialogResult = DialogResult.Cancel
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    '' --------------------------------- HOVERS BOTONES
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

    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape3.MouseMove
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape3.MouseLeave
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    '' ---------------------- ELEMENTOS  VARIOS

    Private Sub fecha_foco(sender As Object, e As EventArgs) Handles txtDia.Enter

        txtDia.ForeColor = Color.FromArgb(22, 23, 24)
        If txtDia.Text = "dd" Then
            txtDia.Text = ""
        End If

    End Sub

    Private Sub txtMes_Enter(sender As Object, e As EventArgs) Handles txtMes.Enter
        txtMes.ForeColor = Color.FromArgb(22, 23, 24)
        If txtMes.Text = "mm" Then
            txtMes.Text = ""
        End If

    End Sub

    Private Sub txtAnho_Enter(sender As Object, e As EventArgs) Handles txtAnho.Enter
        txtAnho.ForeColor = Color.FromArgb(22, 23, 24)
        If txtAnho.Text = "aaaa" Then
            txtAnho.Text = ""
        End If

    End Sub

    Private Sub txtDia_Leave(sender As Object, e As EventArgs) Handles txtDia.Leave
        If txtDia.Text = "" Then
            txtDia.Text = "dd"
            txtDia.ForeColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub soloNumerosTxt(sender As Object, e As KeyPressEventArgs) Handles txtDia.KeyPress, txtMes.KeyPress, txtAnho.KeyPress, txtCI.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtMes_Leave(sender As Object, e As EventArgs) Handles txtMes.Leave
        If txtMes.Text = "" Then
            txtMes.Text = "mm"
            txtMes.ForeColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub txtAnho_Leave(sender As Object, e As EventArgs) Handles txtAnho.Leave
        If txtAnho.Text = "" Then
            txtAnho.Text = "aaaa"
            txtAnho.ForeColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub


End Class