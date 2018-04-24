Imports Backend

Public Class ReservasDelDia
    Public tagHora As Integer
    Public fecha As Date
    Public trabajador As New Personal
    Dim tabla As New DataTable
    Dim dsServicios As New DataSet
    Dim cliente As New Cliente
    Dim list As New DataSet
    Private Sub ReservasDelDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim daoR As New ReservaDAO

        cargarReservasServicio()
        cargarSesiones()
        lblTitulo.Text = lblTitulo.Text + " " + fecha
        'dgvCitas.ClearSelection()

        listS.Height = pnlCitas.Height
    End Sub

    Private Sub cargarReservasServicio()
        Try
            Dim daor As New ReservaDAO
            Dim citas = daor.cargarCitasDelDia(fecha, tagHora)
            dgvCitas.DataSource = citas.Tables("tabla")
            dgvCitas.Columns("ID").Visible = False
            dgvCitas.Update()
            dgvCitas.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarSesiones()
        Dim daoR As New ReservaDAO
        Dim sesiones = daoR.cargarSesionesDelDia(fecha, tagHora)
        dgvCitasPaquete.DataSource = sesiones.Tables("tabla")
        dgvCitasPaquete.ClearSelection()
    End Sub
    Private Sub dgv_style()
        For i As Integer = 0 To dgvCitas.RowCount - 1
            If i Mod 2 = 0 Then
                dgvCitas.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                dgvCitas.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(219, 219, 219)
            End If
        Next
    End Sub

    Private Sub dgvClientes_DataSourceChanged(sender As Object, e As EventArgs)
        dgv_style()
        dgvCitas.AutoResizeRows()
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles rectVolver.Click, lblVolver.Click
        Me.DialogResult = DialogResult.OK


    End Sub

    Private Sub RectangleShape1_MouseMove(sender As Object, e As MouseEventArgs) Handles rectModificar.MouseMove, lblMod.MouseMove
        Me.SuspendLayout()
        lblMod.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles rectModificar.MouseLeave, lblMod.MouseLeave
        Me.SuspendLayout()
        lblMod.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_MouseMove(sender As Object, e As MouseEventArgs) Handles rectCancelar.MouseMove, lblCancelar.MouseMove
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_MouseLeave(sender As Object, e As EventArgs) Handles rectCancelar.MouseLeave, lblCancelar.MouseLeave
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles rectNuevaR.MouseMove, lblNuevaR.MouseMove
        Me.SuspendLayout()
        lblNuevaR.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles rectNuevaR.MouseLeave, lblNuevaR.MouseLeave
        Me.SuspendLayout()
        lblNuevaR.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape4_MouseMove(sender As Object, e As MouseEventArgs) Handles rectVolver.MouseMove, lblVolver.MouseMove
        Me.SuspendLayout()
        lblVolver.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape4_MouseLeave(sender As Object, e As EventArgs) Handles rectVolver.MouseLeave, lblVolver.MouseLeave
        Me.SuspendLayout()
        lblVolver.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub


    Private Sub rectNuevaR_Click(sender As Object, e As EventArgs) Handles rectNuevaR.Click, lblNuevaR.Click
        Try

            If tabCitasPaquetes.SelectedIndex = 0 Then
                Dim nuevareserva As New NuevaReservaServicio
                nuevareserva.hora = tagHora
                nuevareserva.fechaSel = fecha
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
                cargarSesiones()
            End If
            'Dim nuevaReserva As New RealizarReserva

            'nuevaReserva.tagHora = tagHora
            'nuevaReserva.fecha = fecha
            'Dim result = nuevaReserva.ShowDialog()
            'If result = DialogResult.OK Then
            '    Dim daoR As New ReservaDAO
            '    Dim citas = daoR.cargarCitasDelDia(fecha, tagHora)
            '    dgvCitas.DataSource = citas.Tables("tabla")

            '    lblTitulo.Text = lblTitulo.Text + " " + fecha
            '    'dgvCitas.ClearSelection()
            '    dgvCitas.Columns("ID").Visible = False
            '    dgvCitas.Update()
            '    listS.Height = pnlCitas.Height
            '    dgvCitas.ClearSelection()
            'ElseIf result = DialogResult.Yes Then
            '    Dim agend As New AgendarServiciosPaquete
            '    agend.idReservaM = nuevaReserva.idr
            '    agend.ShowDialog()
            '    agend.Dispose()
            'End If
            'nuevaReserva.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Se ha producido un error")
        End Try
    End Sub

    Private Sub ReservasDelDia_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvCitas.ClearSelection()
    End Sub



    Private Sub rectCancelar_Click(sender As Object, e As EventArgs) Handles rectCancelar.Click, lblCancelar.Click
        Try
            If tabCitasPaquetes.SelectedIndex = 0 Then
                If dgvCitas.SelectedRows.Count > 0 Then

                    Dim row = dgvCitas.CurrentRow.Index
                    Dim codigo = dgvCitas.Item(0, row).Value
                    Dim daoR As New ReservaDAO
                    Dim result As Integer = MessageBox.Show("¿Cancelar la reserva? Esta acción no se puede deshacer", "Atención", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        daoR.cancelarReserva(codigo)
                        dgvCitas.Rows.Remove(dgvCitas.CurrentRow)
                        dgvCitas.ClearSelection()
                    End If

                Else
                    MsgBox("Seleccione una reserva para cancelarla", MsgBoxStyle.OkOnly, "Atención")
                End If

            Else
                If dgvCitasPaquete.SelectedRows.Count > 0 Then

                    Dim row = dgvCitasPaquete.CurrentRow.Index
                    Dim codigo = dgvCitasPaquete.Item(0, row).Value
                    Dim daoR As New ReservaDAO
                    Dim result As Integer = MessageBox.Show("¿Cancelar la reserva? Esta acción no se puede deshacer", "Atención", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        daoR.cancelarReservaSesion(codigo)
                        dgvCitasPaquete.Rows.Remove(dgvCitasPaquete.CurrentRow)
                        dgvCitasPaquete.ClearSelection()
                    End If

                Else
                    MsgBox("Seleccione una reserva para cancelarla", MsgBoxStyle.OkOnly, "Atención")
                End If



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvCitas_SelectionChanged_1(sender As Object, e As EventArgs) Handles dgvCitas.SelectionChanged
        Try
            If dgvCitas.SelectedRows.Count > 0 Then
                dgvCitasPaquete.ClearSelection()
                listS.SuspendLayout()
                Dim row = dgvCitas.CurrentRow.Index
                Dim codigo = dgvCitas.Item(0, row).Value
                Dim daoR As New ReservaDAO
                Dim lista = daoR.cargarServiciosReserva(codigo)
                tabla = lista.Tables("tabla")
                listS.DataSource = tabla
                listS.ValueMember = "ID"
                listS.DisplayMember = "Nombre"
                listS.ClearSelected()
                listS.Enabled = False

                listS.ResumeLayout()
            Else
                tabla.Clear()
                listS.DataSource = tabla
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvCitasPaquete_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCitasPaquete.SelectionChanged
        If dgvCitasPaquete.SelectedRows.Count > 0 Then
            dgvCitas.ClearSelection()
            listS.SuspendLayout()
            Dim row = dgvCitasPaquete.CurrentRow.Index
            Dim codigo = dgvCitasPaquete.Item(0, row).Value
            Dim daoR As New ReservaDAO
            Dim lista = daoR.cargarServiciosReservaP(codigo)
            tabla = lista.Tables("tabla")
            listS.DataSource = tabla
            listS.ValueMember = "ID"
            listS.DisplayMember = "Nombre"
            listS.ClearSelected()
            listS.Enabled = False

            listS.ResumeLayout()
        Else
            tabla.Clear()
            listS.DataSource = tabla
        End If
    End Sub

    Private Sub tabCitasPaquetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCitasPaquetes.SelectedIndexChanged
        If tabCitasPaquetes.SelectedIndex = 0 Then
            dgvCitas.ClearSelection()
        Else
            dgvCitasPaquete.ClearSelection()
        End If
    End Sub

    Private Sub lblMod_Click(sender As Object, e As EventArgs) Handles lblMod.Click

    End Sub
End Class