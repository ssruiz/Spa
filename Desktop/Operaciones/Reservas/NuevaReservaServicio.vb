Imports Backend

Public Class NuevaReservaServicio
    Dim cliente As New Cliente
    Dim tabla As New DataTable
    Dim total As Double = 0
    Public fechaSel As Date
    Public hora As Integer
    Private Sub lblBuscar_Click(sender As Object, e As EventArgs) Handles lblBuscar.Click
        Try
            Dim busc As New SeleccionarCliente(txtBusqueda.Text)
            Dim result = busc.ShowDialog(Me)
            If result = DialogResult.OK Then
                cliente = busc.cliente_sel
                txtClienteApe.Text = cliente.apellido
                txtClienteCI.Text = cliente.ci
                txtClienteNombre.Text = cliente.nombre
                txtClienteRUC.Text = cliente.ruc

            End If
            busc.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Sub lblMas_Click(sender As Object, e As EventArgs) Handles lblMas.Click
        Try
            Dim selectSer As New SeleccionarServicio
            AddHandler selectSer.MessageSending, AddressOf Form2_MessageSending
            AddHandler selectSer.FormClosed, AddressOf Form2_FormClosed
            selectSer.ShowDialog(Me)
            selectSer.Dispose()
            tabla = CType(dgvServicios.DataSource, DataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_MessageSending(sender As Object, e As DataTable)
        Try
            tabla.Merge(e)
            Me.dgvServicios.DataSource = tabla
            dgvServicios.Columns("ID").Visible = False
            dgvServicios.Update()
            'listServicios.DisplayMember = "Nombre"
            'listServicios.ValueMember = "ID"
            dgvServicios.ClearSelection()
            txtTotal.Text = calcularTotal()
            txtTotal.Text = FormatCurrency(txtTotal.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
        End Try


        'tabla.merge(e)
        'Me.listServicios.DataSource = tabla
        'listServicios.DisplayMember = "Nombre"
        'listServicios.ValueMember = "ID"



    End Sub
    Private Sub Form2_FormClosed(sender As Object, e As EventArgs)
        'Remove all handlers that you added for this form so that the form can be disposed of properly.
        Dim frm As SeleccionarServicio = TryCast(sender, SeleccionarServicio)
        If frm IsNot Nothing Then
            RemoveHandler frm.MessageSending, AddressOf Form2_MessageSending
            RemoveHandler frm.FormClosed, AddressOf Form2_FormClosed
        End If
    End Sub

    Private Function calcularTotal() As Double
        Dim tot As Double
        For Each row As DataGridViewRow In dgvServicios.Rows
            'formula for adding the values in the rows
            tot += row.Cells(2).Value
        Next
        Return tot
    End Function

    Private Sub lblGUARDAR_Click(sender As Object, e As EventArgs) Handles lblGUARDAR.Click
        If validarReserva() Then

            Dim daoR As New ReservaDAO
            'Dim n = daoR.solapamiento(TimeSpan.Parse(txtHoraInicio.Text), TimeSpan.Parse(txtHoraFin.Text), Date.Parse(txtFecha.Text))
            'If n > 0 Then
            '    MsgBox("Horario no disponible", MsgBoxStyle.Information, "Atención")
            'Else
            Dim r As New Reserva
            r.descripcion = ""
            For Each row As DataGridViewRow In dgvServicios.Rows
                If r.descripcion.Length < 200 Then
                    r.descripcion += row.Cells("Nombre").Value.ToString + " - "
                End If

            Next
            r.cliente = cliente.id
            r.comentario = txtComentario.Text
            r.horaInicio = cbHoras.SelectedValue
            r.horaFin = VariablesUtiles.horas.Item(cbHoras.SelectedIndex + 1).ToString
            r.fecha = dpFecha.Value
            r.total = CDbl(txtTotal.Text)
            r.descuento = CDbl(txtDescuento.Text)
            If rbTarjeta.Checked = True Then
                r.formaPago = "Tarjeta"
            Else
                r.formaPago = "Efectivo"
            End If

            If txtEntrega.Text = "" Then
                r.entrega = 0
                r.saldo = r.total
            Else
                r.entrega = CDbl(txtEntrega.Text)
                r.saldo = r.total - r.entrega
            End If

            If r.saldo = 0 Then
                r.estado = "P"
            Else
                r.estado = "A"
            End If

            r.tag = cbHoras.SelectedIndex
            daoR.guardarReserva(r, dgvServicios.Rows)
            MsgBox("¡Reserva registrada exitosamente!", MsgBoxStyle.Information, "Notificación")
            Me.DialogResult = DialogResult.OK

        End If
    End Sub

    Private Function validarReserva() As Boolean

        If txtClienteCI.Text = "" Then
            MsgBox("Deber seleccionar un cliente", MsgBoxStyle.Critical, "Notificación")
            txtBusqueda.Focus()
            Return False
        ElseIf dgvServicios.Rows.Count = 0 Then
            MsgBox("La reserva debe tener al menos un servicio asignado. Escoja servicios para la reserva", MsgBoxStyle.Critical, "Notificación")
            Return False
        ElseIf cbHoras.SelectedIndex = -1 Then
            MsgBox("Seleccione una hora de inicio", MsgBoxStyle.Critical, "Notificación")
            Return False
        End If

        Return True
    End Function

    Private Sub NuevaReservaServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbHoras.DataSource = VariablesUtiles.horasCb
            cbHoras.SelectedIndex = hora
            dpFecha.Value = fechaSel
            txtTotal.Text = FormatCurrency(0, 1)
            txtEntrega.Text = FormatCurrency(0, 1)
            txtDescuento.Text = FormatCurrency(0, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblBuscar.MouseMove, lblMas.MouseMove, lblMenos.MouseMove, lblGUARDAR.MouseMove, lblReset.MouseMove, lblCancelar.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
        lbl.BackColor = Color.FromArgb(217, 69, 78)
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblBuscar.MouseLeave, lblMas.MouseLeave, lblMenos.MouseLeave, lblGUARDAR.MouseLeave, lblReset.MouseLeave, lblCancelar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
        lbl.BackColor = Color.FromArgb(186, 69, 78)
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        txtClienteApe.Text = ""
        txtClienteCI.Text = ""
        txtClienteNombre.Text = ""
        txtClienteRUC.Text = ""
        txtComentario.Text = ""
        txtEntrega.Text = FormatCurrency(0, 1)
    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntrega.KeyPress, txtDescuento.KeyPress
        soloNumeros(e)

    End Sub

    Private Sub txtEntrega_TextChanged(sender As Object, e As EventArgs) Handles txtEntrega.TextChanged
        If txtEntrega.Text <> "" Then
            txtEntrega.Text = FormatCurrency(txtEntrega.Text, 1)
            txtEntrega.Select(txtEntrega.TextLength - 2, 0)
        Else
            txtEntrega.Text = FormatCurrency(0, 1)
            txtEntrega.Select(txtEntrega.TextLength - 2, 0)
        End If
    End Sub

    Private Sub txtEntrega_Click(sender As Object, e As EventArgs) Handles txtEntrega.Click
        If txtEntrega.Text <> "" Then
            txtEntrega.Select(txtEntrega.TextLength - 2, 0)
        End If
    End Sub
    'Private Sub txtEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntrega.KeyPress
    '    soloNumeros(e)

    'End Sub

    'Private Sub txtEntrega_TextChanged(sender As Object, e As EventArgs) Handles txtEntrega.TextChanged
    '    If txtEntrega.Text <> "" Then
    '        txtEntrega.Text = FormatCurrency(txtEntrega.Text, 1)
    '        txtEntrega.Select(txtEntrega.TextLength - 2, 0)
    '    End If
    'End Sub

    'Private Sub txtEntrega_Click(sender As Object, e As EventArgs) Handles txtEntrega.Click
    '    If txtEntrega.Text <> "" Then
    '        txtEntrega.Select(txtEntrega.TextLength - 2, 0)
    '    End If
    'End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        If txtDescuento.Text <> "" Then
            txtDescuento.Text = FormatCurrency(txtDescuento.Text, 1)

            txtDescuento.Select(txtDescuento.TextLength - 2, 0)
            txtTotal.Text = FormatCurrency(calcularTotal() - CDbl(txtDescuento.Text), 1)
        Else
            txtDescuento.Text = FormatCurrency(0, 1)
            txtDescuento.Select(txtDescuento.TextLength - 2, 0)
            txtTotal.Text = FormatCurrency(calcularTotal() - CDbl(txtDescuento.Text), 1)
        End If
    End Sub

    Private Sub txtDescuento_Click(sender As Object, e As EventArgs) Handles txtDescuento.Click
        If txtDescuento.Text <> "" Then
            txtDescuento.Select(txtDescuento.TextLength - 2, 0)
        End If
    End Sub

    Private Sub lblMenos_Click(sender As Object, e As EventArgs) Handles lblMenos.Click
        If dgvServicios.Rows.Count = 0 Then
            MsgBox("La lista de servicios ya se encuentra vacía actualmente", MsgBoxStyle.Information, "Notificación")
        ElseIf dgvServicios.SelectedRows.Count = 0 Then
            MsgBox("Seleccione un servicio de la lista para eliminar", MsgBoxStyle.Information, "Notificación")
        Else
            Dim row = dgvServicios.CurrentRow
            txtTotal.Text = (CDbl(txtTotal.Text) - CDbl(row.Cells(2).Value))
            txtTotal.Text = FormatCurrency(txtTotal.Text)
            'MsgBox(listServicios.SelectedIndex)
            dgvServicios.Rows.Remove(dgvServicios.CurrentRow)
            tabla = dgvServicios.DataSource
            'listServicios.DataSource = tabla
        End If
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            lblBuscar_Click(sender, e)
        End If
    End Sub
End Class