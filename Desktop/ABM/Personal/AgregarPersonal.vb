Imports Backend

Public Class AgregarPersonal
    Dim agregados = 0
    Private Sub lblGUARDAR_Click(sender As Object, e As EventArgs) Handles lblGUARDAR.Click

    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblGUARDAR.Click
        Try
            If controlarCampos() Then
                Dim empleado As New Personal
                empleado.nombre = txtNombre.Text
                empleado.apellido = txtApellido.Text
                empleado.tel = txtTelefono.Text
                empleado.cel = txtCelular.Text
                Dim daoPer As New PersonalDAO
                daoPer.agregarPersonal(empleado)
                Dim result As Integer = MessageBox.Show("¡Personal agreegado! Desea continuar agregando? ", "Continuar", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Me.DialogResult = DialogResult.OK
                ElseIf result = DialogResult.Yes Then
                    agregados += 1
                    resetCampos()
                    txtNombre.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub resetCampos()
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
    End Sub
    Private Sub soloNumerosTxt(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress, txtCelular.KeyPress
        soloNumeros(e)
    End Sub
    Private Function controlarCampos() As Boolean

        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar un nombre para el cliente", MsgBoxStyle.Critical, "Atención")
            txtNombre.Focus()
            Return False
        ElseIf txtApellido.Text = "" Then
            MsgBox("Debe ingresar un apellido para el cliente", MsgBoxStyle.Critical, "Atención")
            txtApellido.Focus()
            Return False
        ElseIf txtTelefono.Text = "" Then
            MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
            txtTelefono.Focus()
            Return False
        ElseIf txtCelular.Text = "" Then
            MsgBox("Debe ingresar un celular válido", MsgBoxStyle.Critical, "Atención")
            txtCelular.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click, lblCancelar.Click
        If agregados = 0 Then
            Me.DialogResult = DialogResult.Cancel
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblReset.Click
        resetCampos()
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


End Class