Imports Backend

Public Class SeleccionarPaquete
    Public paqueteId
    Public precio
    Public nombre
    Private Sub SeleccionarPaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim daoSer As New ServicioDAO
            Dim list = daoSer.cargarPaquetesNombre
            dgvPaquetes.DataSource = list.Tables("tabla")
            dgvPaquetes.Columns("ID").Visible = False
            dgvPaquetes.Columns("Nombre").FillWeight = 250
            dgvPaquetes.ClearSelection()
            Me.Top = Owner.Top
            Me.Left = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles lblAgregar.Click
        If dgvPaquetes.SelectedRows.Count > 0 Then
            Dim row = dgvPaquetes.CurrentRow.Index
            paqueteId = dgvPaquetes.Item(0, row).Value
            precio = dgvPaquetes.Item(2, row).Value
            nombre = dgvPaquetes.Item(1, row).Value
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub lblAgregar_Click(sender As Object, e As EventArgs) Handles lblAgregar.Click

    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblAgregar.MouseMove, lblSalir.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblSalir.MouseLeave, lblAgregar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
    End Sub
End Class