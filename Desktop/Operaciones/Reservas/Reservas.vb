Imports Backend

Public Class Reservas
    Dim list As New DataSet
    Dim tablaPaquetes As New DataTable
    Private Sub ReservasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        list.Tables.Add("servicios")
        list.Tables.Add("paquetes")
        cargarReservasServicio()
        cargarReservaPaquetes()
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)


    End Sub


    Private Sub cargarReservasServicio()
        Try
            Dim daor As New ReservaDAO

            Dim rs = daor.cargarReservas()
            list.Tables("servicios").Clear()
            rs.Fill(list.Tables("servicios"))
            dgvReservasServicios.DataSource = list.Tables("servicios")

            dgvReservasServicios.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarReservaPaquetes()
        Try
            Dim daor As New ReservaDAO

            Dim rs = daor.cargarReservasPaquetes()
            list.Tables("paquetes").Clear()
            rs.Fill(list.Tables("paquetes"))
            dgvReservaP.DataSource = list.Tables("paquetes")
            dgvReservaP.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_style()
        For i As Integer = 0 To dgvReservasServicios.RowCount - 1
            If i Mod 2 = 0 Then
                dgvReservasServicios.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                dgvReservasServicios.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(219, 219, 219)
            End If
        Next
    End Sub

    Private Sub dgvInicio_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvReservasServicios.DataSourceChanged
        dgv_style()
        dgvReservasServicios.AutoResizeRows()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub lblNuevaReserva_Click(sender As Object, e As EventArgs) Handles lblNuevaReserva.Click
        Try
            If tabReservas.SelectedIndex = 0 Then
                Dim nuevareserva As New NuevaReservaServicio
                nuevareserva.hora = 0
                nuevareserva.fechaSel = Date.Today
                Dim res = nuevareserva.ShowDialog
                If res = DialogResult.OK Then
                    cargarReservasServicio()
                End If
                nuevareserva.Dispose()
            Else
                Dim nuevaReserva As New NuevaReservaPaquete
                Dim res = nuevaReserva.ShowDialog()
                If res = DialogResult.OK Then
                    Dim agend As New AgendarServiciosPaquete
                    agend.idReservaM = nuevaReserva.idr
                    agend.ShowDialog()
                    agend.Dispose()
                End If
                nuevaReserva.Dispose()
                cargarReservaPaquetes()
            End If

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        
        End Try
    End Sub

    Private Sub tabReservas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabReservas.SelectedIndexChanged

        dgvReservaP.ClearSelection()
        dgvReservasServicios.ClearSelection()
        If tabReservas.SelectedIndex = 0 Then
            lblNuevaReserva.Text = "NUEVA RESERVA"
            dgvReservasServicios.DataSource = list.Tables("servicios")
        Else
            lblNuevaReserva.Text = "NUEVA RESERVA PAQUETE"
            dgvReservaP.DataSource = list.Tables("paquetes")

        End If
    End Sub

    Private Sub lblCancelarR_Click(sender As Object, e As EventArgs) Handles lblCancelarR.Click
        If tabReservas.SelectedIndex = 0 Then
            If dgvReservasServicios.SelectedRows.Count > 0 Then

                Dim row = dgvReservasServicios.CurrentRow.Index
                Dim codigo = dgvReservasServicios.Item(0, row).Value
                Dim daoR As New ReservaDAO
                Dim result As Integer = MessageBox.Show("¿Cancelar la reserva? Esta acción no se puede deshacer", "Atención", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    daoR.cancelarReserva(codigo)
                    MsgBox("Reserva cancelada", MsgBoxStyle.Information, "Notificación")
                    dgvReservasServicios.Rows.Remove(dgvReservasServicios.CurrentRow)
                    dgvReservasServicios.ClearSelection()
                End If
            End If

        Else
            If dgvReservaP.SelectedRows.Count > 0 Then
                Dim row = dgvReservaP.CurrentRow.Index
                Dim codigo = dgvReservaP.Item(0, row).Value
                Dim daoR As New ReservaDAO
                Dim result As Integer = MessageBox.Show("¿Cancelar la reserva del paquete? Esta acción no se puede deshacer", "Atención", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    daoR.cancelarReservaP(codigo)
                    MsgBox("Reserva cancelada", MsgBoxStyle.Information, "Notificación")
                    dgvReservaP.Rows.Remove(dgvReservaP.CurrentRow)
                    dgvReservaP.ClearSelection()
                End If
            End If
        End If

    End Sub

    Private Sub lblVerR_Click(sender As Object, e As EventArgs) Handles lblVerR.Click
        If tabReservas.SelectedIndex = 0 Then
            If dgvReservasServicios.SelectedRows.Count > 0 Then
                Dim row = dgvReservasServicios.CurrentRow.Index
                Dim codigo = dgvReservasServicios.Item(0, row).Value
                Dim agend As New VisualizarReserva

                agend.idReserM = codigo
                agend.ShowDialog()
                agend.Dispose()
                cargarReservasServicio()
            End If
        Else
            If dgvReservaP.SelectedRows.Count > 0 Then
                Dim row = dgvReservaP.CurrentRow.Index
                Dim codigo = dgvReservaP.Item(0, row).Value
                Dim verR As New AgendarServiciosPaquete
                verR.idReservaM = codigo
                verR.ShowDialog()
                verR.Dispose()
                cargarReservaPaquetes()
            End If

        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblSalir.MouseMove, lblCancelarR.MouseMove, lblNuevaReserva.MouseMove, lblVerR.MouseMove, lblBuscar.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
        lbl.BackColor = Color.FromArgb(217, 69, 78)
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblSalir.MouseLeave, lblCancelarR.MouseLeave, lblNuevaReserva.MouseLeave, lblVerR.MouseLeave, lblBuscar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
        lbl.BackColor = Color.FromArgb(186, 69, 78)
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tabReservas.SelectedIndex = 0 Then
                Dim dv As New DataView(list.Tables("servicios"))
                dv.RowFilter = String.Format("Cliente like '%{0}%'", txtBusqueda.Text)
                dgvReservasServicios.DataSource = dv
                dgvReservasServicios.Update()
                dgvReservasServicios.ClearSelection()
            Else
                Dim dv As New DataView(list.Tables("paquetes"))
                dv.RowFilter = String.Format("Cliente like '%{0}%'", txtBusqueda.Text)
                dgvReservaP.DataSource = dv
                dgvReservaP.Update()
                dgvReservaP.ClearSelection()
            End If



        End If
    End Sub

    Private Sub lblBuscar_Click(sender As Object, e As EventArgs) Handles lblBuscar.Click

        If tabReservas.SelectedIndex = 0 Then
            Dim dv As New DataView(list.Tables("servicios"))

            dv.RowFilter = String.Format("Fecha  <= '{0:yyyy-MM-dd}'  AND Fecha >=  '{1:yyyy-MM-dd}'", dpfin.Value, dpInicio.Value)

            dgvReservasServicios.DataSource = dv
            dgvReservasServicios.Update()
            dgvReservasServicios.ClearSelection()
        Else
            Dim dv As New DataView(list.Tables("paquetes"))
            dv.RowFilter = String.Format("Cliente like '%{0}%'", txtBusqueda.Text)
            dgvReservaP.DataSource = dv
            dgvReservaP.Update()
            dgvReservaP.ClearSelection()
        End If
    End Sub
End Class