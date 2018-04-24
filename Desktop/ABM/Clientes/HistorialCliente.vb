Imports Backend

Public Class HistorialCliente
    Public idficha
    Public nombreTrat
    Private Sub HistorialCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTratamiento.Text = nombreTrat
    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblGUARDAR.MouseMove, lblCancelar.MouseMove, lblReset.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblGUARDAR.MouseLeave, lblCancelar.MouseLeave, lblReset.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles lblGUARDAR.Click
        Try
            Dim clieDao As New ClienteDAO
            If controlarCampos() Then
                Dim historial As New Historial
                historial.idFicha = idficha
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
                clieDao.guardarDetalleTratamiento(historial)
                MsgBox("Historial agregado", MsgBoxStyle.Information, "Registro")
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Function controlarCampos() As Boolean
        If txtPeso.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtPeso.Focus()
            Return False
        ElseIf txtTratamiento.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtTratamiento.Focus()
            Return False
        ElseIf txtPesoI.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtPesoI.Focus()
            Return False
        ElseIf txtAltura.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtAltura.Focus()
            Return False
        ElseIf txtImc.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtImc.Focus()
            Return False
        ElseIf txtCINT.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtCINT.Focus()
            Return False
        ElseIf txtOMB.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtOMB.Focus()
            Return False
        ElseIf txtBOMB.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtBOMB.Focus()
            Return False
        ElseIf txtPD.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtPD.Focus()
            Return False
        ElseIf txtBD.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtBD.Focus()
            Return False
        ElseIf txtPI.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtPI.Focus()
            Return False
        ElseIf txtBI.Text = "" Then
            MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
            txtBI.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles lblReset.Click
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
    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click

    End Sub
End Class