Imports Backend

Public Class TratamientoDetalle
    Public idtrat
    Public nombreTrat
    Private Sub txtBD_TextChanged(sender As Object, e As EventArgs) Handles txtBD.TextChanged

    End Sub

    Private Sub TratamientoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarDatos()
            lbltitulo.Text = nombreTrat
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarDatos()
        Dim clie As New ClienteDAO
        Dim list = clie.cargarRegistrosTratamientos(idtrat)
        dgvRegistros.DataSource = list.Tables("tabla")
        dgvRegistros.Columns("IDH").Visible = False
        dgvRegistros.Columns("IDT").Visible = False
        dgvRegistros.ClearSelection()
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


    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles lblAgregarHistorial.MouseMove, lblCancelar.MouseMove

        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles lblAgregarHistorial.MouseLeave, lblCancelar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)

    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub dgvRegistros_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRegistros.SelectionChanged
        Try
            Dim idhisto = dgvRegistros.CurrentRow.Cells("IDH").Value
            cargarHistorial(idhisto)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargarHistorial(ByVal id As Integer)
        Try
            Dim daoCli As New ClienteDAO

            Dim historial = daoCli.cargarHistorialUnico(id)

            txtImc.Text = historial.imc
            ''txtEnfermedad.Text = historial.enfermedad
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
            'txtFecha.Text = historial.fecha


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblAgregarHistorial_Click(sender As Object, e As EventArgs) Handles lblAgregarHistorial.Click

        Try
            Dim hist As New HistorialCliente
            hist.idficha = idtrat
            hist.nombreTrat = nombreTrat
            Dim res = hist.ShowDialog()
            If res = DialogResult.OK Then
                cargarDatos()
            End If
            hist.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class