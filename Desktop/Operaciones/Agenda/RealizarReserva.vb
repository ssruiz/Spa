Imports Backend

Public Class RealizarReserva
    Public tagHora As Integer
    Public fecha As Date
    Public trabajador As New Personal
    Dim tabla As New DataTable
    Dim dsServicios As New DataSet
    Dim cliente As New Cliente
    Dim totalPaquete = 0
    Dim paqueteID
    Public idr
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim agregarSer As New SeleccionarServicio
            agregarSer.ShowDialog()


        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Sub RealizarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = fecha
        txtEntrega.Text = FormatCurrency(0, 1)
        txtHoraInicio.Text = VariablesUtiles.horas.Item(tagHora).ToString
        txtHoraFin.Text = VariablesUtiles.horas.Item(tagHora + 1).ToString
        'txtTrabajador.Text = trabajador.nombre
        dsServicios.Tables.Add("servicios")

    End Sub


    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles lblMas.Click
        Try
            If tabServiciosPaquetes.SelectedIndex = 0 Then
                Dim selectSer As New SeleccionarServicio
                AddHandler selectSer.MessageSending, AddressOf Form2_MessageSending
                AddHandler selectSer.FormClosed, AddressOf Form2_FormClosed
                selectSer.ShowDialog(Me)
                selectSer.Dispose()
                tabla = CType(dgvServicios.DataSource, DataTable)
            Else
                Dim selectSer As New SeleccionarPaquete
                Dim res = selectSer.ShowDialog(Me)
                If res = DialogResult.OK Then
                    paqueteID = selectSer.paqueteId
                    totalPaquete = selectSer.precio
                    txtTotal.Text = FormatCurrency(totalPaquete)
                    Dim daoS As New ServicioDAO
                    Dim detalle = daoS.cargarPaqueteDetalle(paqueteID)
                    lblPaquete.Text = selectSer.nombre
                    dgvPaquetes.DataSource = detalle.Tables("tabla")
                    dgvPaquetes.Columns("ID").Visible = False
                    dgvPaquetes.Columns("IDP").Visible = False
                    dgvPaquetes.ClearSelection()
                End If
                selectSer.Dispose()
            End If

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

    Private Function calcularTotal() As Double
        Dim tot As Double
        For Each row As DataGridViewRow In dgvServicios.Rows
            'formula for adding the values in the rows
            tot += row.Cells(2).Value
        Next
        Return tot
    End Function
    Private Sub Form2_FormClosed(sender As Object, e As EventArgs)
        'Remove all handlers that you added for this form so that the form can be disposed of properly.
        Dim frm As SeleccionarServicio = TryCast(sender, SeleccionarServicio)
        If frm IsNot Nothing Then
            RemoveHandler frm.MessageSending, AddressOf Form2_MessageSending
            RemoveHandler frm.FormClosed, AddressOf Form2_FormClosed
        End If
    End Sub




    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        txtClienteNombre.Text = ""
        txtClienteApe.Text = ""
        txtClienteCI.Text = ""
        txtClienteRUC.Text = ""
        tabla = New DataTable

        dgvServicios.DataSource = tabla
        txtComentario.Text = ""
        txtDuracion.Value = 0
        txtBusqueda.Text = ""
    End Sub




    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub RectangleShape6_Click(sender As Object, e As EventArgs) Handles lblBuscar.Click
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

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles lblGUARDAR.Click
        Try
            If validarReserva() Then
                If tabServiciosPaquetes.SelectedIndex = 0 Then
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
                    r.horaInicio = txtHoraInicio.Text
                    r.horaFin = txtHoraFin.Text
                    r.fecha = txtFecha.Text
                    r.total = CDbl(txtTotal.Text)
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

                    r.tag = tagHora
                    daoR.guardarReserva(r, dgvServicios.Rows)
                    MsgBox("¡Reserva registrada exitosamente!", MsgBoxStyle.Information, "Notificación")
                    Me.DialogResult = DialogResult.OK


                Else
                    Dim daoR As New ReservaDAO
                    Dim rp As New Reservap
                    rp.cliente = cliente.id
                    rp.comentario = txtComentario.Text
                    rp.entrega = CDbl(txtEntrega.Text)
                    rp.paquete = paqueteID
                    rp.fecha = Date.Today
                    rp.total = totalPaquete
                    rp.descripcion = lblPaquete.Text
                    If totalPaquete = CInt(txtEntrega.Text) Then
                        rp.estado = "AP"
                        rp.saldo = 0
                    Else
                        rp.estado = "AD"
                        rp.saldo = totalPaquete - CDbl(txtEntrega.Text)
                    End If

                    'End If
                    idr = daoR.guardarReservaP(rp)
                    MsgBox("¡Reserva de paquete realizada exitosamente! Se lo mandará a la ventana de agendar citas para la misma", MsgBoxStyle.Information, "Notificación")
                    Me.DialogResult = DialogResult.Yes
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Function validarReserva() As Boolean
        If tabServiciosPaquetes.SelectedIndex = 0 Then
            If txtClienteCI.Text = "" Then
                MsgBox("Deber seleccionar un cliente", MsgBoxStyle.Critical, "Notificación")
                txtBusqueda.Focus()
                Return False
            ElseIf txtDuracion.Value = 0 Then
                MsgBox("La reserva debe tener una duración aproximanda en minutos", MsgBoxStyle.Critical, "Notificación")
                txtDuracion.Focus()
                Return False
            ElseIf dgvServicios.Rows.Count = 0 Then
                MsgBox("La reserva debe tener al menos un servicio asignado. Escoja servicios para la reserva", MsgBoxStyle.Critical, "Notificación")
                Return False
            ElseIf CDbl(txtEntrega.text) > CDbl(txtTotal.text) Then
                MsgBox("La entrega inicial supera al monto total", MsgBoxStyle.Critical, "Notificación")
                txtEntrega.Focus()
                Return False
            End If

        Else
            If txtClienteCI.Text = "" Then
                MsgBox("Deber seleccionar un cliente", MsgBoxStyle.Critical, "Notificación")
                txtBusqueda.Focus()
                Return False
            ElseIf dgvPaquetes.Rows.Count = 0 Then
                MsgBox("La reserva debe tener al menos un paquete asignado. Escoja un paquete para la reserva", MsgBoxStyle.Critical, "Notificación")
                Return False
            ElseIf CDbl(txtEntrega.text) > CDbl(txtTotal.text) Then
                MsgBox("La entrega inicial supera al monto total", MsgBoxStyle.Critical, "Notificación")
                txtEntrega.Focus()
                Return False
            End If
            Return True

        End If
        Return True
    End Function

    Private Sub RectangleShape5_Click(sender As Object, e As EventArgs) Handles lblMenos.Click
        If tabServiciosPaquetes.SelectedIndex = 0 Then
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
        Else
            dgvPaquetes.DataSource = Nothing
        End If

    End Sub

    'Private Sub txtDuracion_ValueChanged(sender As Object, e As EventArgs) Handles txtDuracion.ValueChanged
    '    Dim count As TimeSpan = TimeSpan.Parse(txtHoraInicio.Text)
    '    txtHoraFin.Text = ((count + TimeSpan.FromMinutes(txtDuracion.Value)).ToString("hh\:mm"))
    'End Sub





    '' ----------------------------------- HOVERS DE BOTONES

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblBuscar.MouseMove, lblMas.MouseMove, lblMenos.MouseMove, lblGUARDAR.MouseMove, lblReset.MouseMove, lblCancelar.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblBuscar.MouseLeave, lblMas.MouseLeave, lblMenos.MouseLeave, lblGUARDAR.MouseLeave, lblReset.MouseLeave, lblCancelar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
    End Sub

    Private Sub lblDuracion_Click(sender As Object, e As EventArgs) Handles lblDuracion.Click

    End Sub

    Private Sub tabServiciosPaquetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabServiciosPaquetes.SelectedIndexChanged
        If tabServiciosPaquetes.SelectedIndex = 0 Then
            txtTotal.Text = FormatCurrency(calcularTotal())
        Else
            txtTotal.Text = FormatCurrency(totalPaquete)
        End If
    End Sub

    Private Sub txtEntrega_TextChanged(sender As Object, e As EventArgs) Handles txtEntrega.TextChanged
        txtEntrega.Text = FormatCurrency(txtEntrega.Text, 1)
        txtEntrega.Select(txtEntrega.TextLength - 2, 0)
    End Sub

    Private Sub txtEntrega_Click(sender As Object, e As EventArgs) Handles txtEntrega.Click
        If txtEntrega.Text <> "" Then
            txtEntrega.Select(txtEntrega.TextLength - 2, 0)
        End If
    End Sub
End Class