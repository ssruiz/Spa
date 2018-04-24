Imports Backend

Public Class AgregarTratamiento
    Public idFicha
    Private Sub lblAgregarHistorial_Click(sender As Object, e As EventArgs) Handles lblAgregarHistorial.Click
        Try
            If controlarCampos() Then
                Dim historial As New Historial
                historial.idFicha = idFicha
                historial.imc = txtImc.Text
                historial.enfermedad = txtTratamiento.Text
                historial.altura = txtAltura.Text
                historial.bd = txtBD.Text
                historial.bi = txtBI.Text
                historial.bomb = txtBOMB.Text
                historial.cinth = txtCINT.Text
                historial.omb = txtOMB.Text
                historial.pd = txtPD.Text
                historial.peso = txtPeso.Text
                historial.pesoI = txtPesoI.Text
                historial.pi = txtPI.Text
                historial.fecha = Date.Today
                Dim clieDao As New ClienteDAO
                clieDao.guardarHistorial(historial)
                MsgBox("¡Tratamiento agregado!", MsgBoxStyle.Information, "Tratamiento")
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function controlarCampos() As Boolean
        Try
            If txtTratamiento.Text.Length > 0 Then
                If txtPeso.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPeso.Focus()
                    Return False
                ElseIf txtPesoI.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPesoI.Focus()
                    Return False
                ElseIf txtAltura.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtAltura.Focus()
                    Return False
                ElseIf txtImc.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtImc.Focus()
                    Return False
                ElseIf txtCINT.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtCINT.Focus()
                    Return False
                ElseIf txtOMB.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtOMB.Focus()
                    Return False
                ElseIf txtBOMB.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtBOMB.Focus()
                    Return False
                ElseIf txtPD.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPD.Focus()
                    Return False
                ElseIf txtBD.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtBD.Focus()
                    Return False
                ElseIf txtPI.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPI.Focus()
                    Return False
                ElseIf txtBI.Text = "" Then
                    MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtBI.Focus()
                    Return False
                End If
            Else
                MsgBox("Si va registrar un tratamiento rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                txtTratamiento.Focus()
                Return False
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        txtImc.Text = ""
        txtAltura.Text = ""
        txtBD.Text = ""
        txtBI.Text = ""
        txtBOMB.Text = ""
        txtCINT.Text = ""
        txtOMB.Text = ""
        txtPD.Text = ""
        txtPeso.Text = ""
        txtPesoI.Text = ""
        txtPI.Text = ""
        txtTratamiento.Text = ""
    End Sub

    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles lblAgregarHistorial.MouseMove, lblReset.MouseMove, lblCancelar.MouseMove

        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
        lbl.BackColor = Color.FromArgb(217, 69, 78)
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles lblAgregarHistorial.MouseLeave, lblReset.MouseLeave, lblCancelar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
        lbl.BackColor = Color.FromArgb(186, 69, 78)
    End Sub

    Private Sub AgregarTratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class