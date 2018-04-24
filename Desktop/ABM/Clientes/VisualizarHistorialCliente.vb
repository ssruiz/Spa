Imports Backend

Public Class VisualizarHistorialCliente
    Public id
    Private Sub VisualizarHistorialCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarHistorial()
    End Sub
    Private Sub cargarHistorial()
        Try
            Dim daoCli As New ClienteDAO
            MsgBox(id)
            Dim historial = daoCli.cargarHistorialUnico(id)

            txtImc.Text = historial.imc
            txtEnfermedad.Text = historial.enfermedad
            txtAltura.Text = historial.altura
            txtBD.Text = historial.bd
            txtBI.Text = historial.bi
            txtBOMB.Text = historial.bomb
            txtCINT.Text = historial.cinth
            txtOMB.Text = historial.omb
            txtPD.Text = historial.pd
            txtPeso.Text = historial.peso
            txtPesoI.Text = historial.pesoI
            txtPI.Text = historial.pi
            txtFecha.Text = historial.fecha


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblCancelar.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblCancelar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class