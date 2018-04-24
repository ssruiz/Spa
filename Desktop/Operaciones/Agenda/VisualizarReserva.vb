Imports Backend

Public Class VisualizarReserva
    Public reserva As New Reserva
    Dim tabla As New DataTable
    Public idReserM
    Private Sub VisualizarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarDatosReserva()
            cargarServicios()
            lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cargarServicios()
        Try
            Dim daor As New ReservaDAO
            Dim lista = daor.cargarServiciosReserva(reserva.id)
            dgvServicios.DataSource = lista.Tables("tabla")
            dgvServicios.Columns("ID").Visible = False
            dgvServicios.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cargarDatosReserva()
        Try
            Dim daor As New ReservaDAO
            reserva = daor.cargarReserva(idReserM)
            txtClienteNombre.Text = reserva.clienteNombre
            txtFecha.Text = reserva.fecha
            txtHoraInicio.Text = reserva.horaInicio
            txtSaldo.Text = FormatCurrency(reserva.saldo, 1)
            txtTotal.Text = FormatCurrency(reserva.total, 1)
            txtSub.Text = FormatCurrency(reserva.total + reserva.descuento, 1)
            txtDescuento.Text = FormatCurrency(reserva.descuento, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles lblMas.Click
    '    Try


    '        Dim selectSer As New SeleccionarServicio
    '        AddHandler selectSer.MessageSending, AddressOf Form2_MessageSending
    '        AddHandler selectSer.FormClosed, AddressOf Form2_FormClosed
    '        selectSer.ShowDialog(Me)
    '        selectSer.Dispose()
    '        tabla = CType(listServicios.DataSource, DataTable)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub Form2_MessageSending(sender As Object, e As DataTable)
    '    Try
    '        tabla.Merge(e)
    '        Me.listServicios.DataSource = tabla
    '        listServicios.DisplayMember = "Nombre"
    '        listServicios.ValueMember = "ID"
    '        listServicios.ClearSelected()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
    '    End Try


    'tabla.merge(e)
    'Me.listServicios.DataSource = tabla
    'listServicios.DisplayMember = "Nombre"
    'listServicios.ValueMember = "ID"



    'End Sub

    'Private Sub Form2_FormClosed(sender As Object, e As EventArgs)
    '    'Remove all handlers that you added for this form so that the form can be disposed of properly.
    '    Dim frm As SeleccionarServicio = TryCast(sender, SeleccionarServicio)
    '    If frm IsNot Nothing Then
    '        RemoveHandler frm.MessageSending, AddressOf Form2_MessageSending
    '        RemoveHandler frm.FormClosed, AddressOf Form2_FormClosed
    '    End If
    'End Sub

    'Private Sub RectangleShape5_Click(sender As Object, e As EventArgs) Handles lblMenos.Click
    '    If listServicios.Items.Count = 0 Then
    '        MsgBox("La lista de servicios ya se encuentra vacía actualmente", MsgBoxStyle.Information, "Notificación")
    '    ElseIf listServicios.SelectedItems.Count = 0 Then
    '        MsgBox("Seleccione un servicio de la lista para eliminar", MsgBoxStyle.Information, "Notificación")
    '    Else
    '        Dim elemento = listServicios.SelectedItem
    '        MsgBox(listServicios.SelectedIndex)
    '        tabla.Rows.RemoveAt(listServicios.SelectedIndex)
    '        listServicios.DataSource = tabla
    '    End If
    'End Sub



    '' ----------------------------------- HOVERS DE BOTONES


    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblSalir.MouseMove, lblPagar.MouseMove, lblCancelarReserva.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblSalir.MouseLeave, lblPagar.MouseLeave, lblCancelarReserva.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
    End Sub

    Private Sub lblGUARDAR_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblPagar_Click(sender As Object, e As EventArgs) Handles lblPagar.Click
        If CDbl(txtSaldo.Text) = 0 Then
            MsgBox("El costo de la reserva ya está saldado", MsgBoxStyle.Information, "Pago")
        ElseIf txtPago.Text = "" Then
            MsgBox("Ingrese un monto para el pago", MsgBoxStyle.Information, "Pago")
        ElseIf CDbl(txtPago.Text) = 0 Then
            MsgBox("Ingrese un monto mayor a 0 para el pago", MsgBoxStyle.Information, "Pago")

        Else
            Try
                Dim daor As New ReservaDAO
                Dim tipo = ""
                If rbTarjeta.Checked = True Then
                    tipo = "Tarjeta"
                Else
                    tipo = "Efectivo"
                End If
                daor.realizarPagoReserva(reserva.id, CDbl(txtPago.Text), tipo)
                MsgBox("¡Pago registrado!", MsgBoxStyle.Information, "Pago")
                cargarDatosReserva()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPago.KeyPress
        soloNumeros(e)

    End Sub

    Private Sub txtEntrega_TextChanged(sender As Object, e As EventArgs) Handles txtPago.TextChanged
        If txtPago.Text <> "" Then
            txtPago.Text = FormatCurrency(txtPago.Text, 1)
            txtPago.Select(txtPago.TextLength - 2, 0)
        Else
            txtPago.Text = FormatCurrency(0, 1)
            txtPago.Select(txtPago.TextLength - 2, 0)
        End If
    End Sub

    Private Sub txtEntrega_Click(sender As Object, e As EventArgs) Handles txtPago.Click
        If txtPago.Text <> "" Then
            txtPago.Select(txtPago.TextLength - 2, 0)
        End If
    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtHoraInicio_TextChanged(sender As Object, e As EventArgs) Handles txtHoraInicio.TextChanged, txtDescuento.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label5.Click

    End Sub

    Private Sub lblCancelarReserva_Click(sender As Object, e As EventArgs) Handles lblCancelarReserva.Click
        Dim result As Integer = MessageBox.Show("¿Cancelar la reserva? Esta acción no se puede deshacer", "Atención", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim daoR As New ReservaDAO
            daoR.cancelarReserva(idReserM)
            MsgBox("Reserva cancelada", MsgBoxStyle.Information, "Notificación")
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub
End Class