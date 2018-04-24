Imports Backend

Public Class NuevaReservaPaquete
    Dim cliente As New Cliente
    Dim paqueteID
    Dim totalPaquete = 0
    Dim dts
    Dim rowAux
    Dim personalizado As Boolean = False
    Dim detalle As DataSet
    Public idr


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
            Dim selectSer As New SeleccionarPaquete
            Dim res = selectSer.ShowDialog(Me)
            If res = DialogResult.OK Then
                paqueteID = selectSer.paqueteId
                totalPaquete = selectSer.precio
                txtTotal.Text = FormatCurrency(totalPaquete)
                Dim daoS As New ServicioDAO
                detalle = daoS.cargarPaqueteDetalle(paqueteID)
                rowAux = detalle.Tables("tabla").NewRow
                lblPaquete.Text = selectSer.nombre
                dgvPaquetes.DataSource = detalle.Tables("tabla")
                dgvPaquetes.Columns("ID").Visible = False
                dgvPaquetes.Columns("IDP").Visible = False
                dgvPaquetes.ClearSelection()
                txtTotal.ReadOnly = True
                txtTotal.Enabled = False
                personalizado = False
            End If
            selectSer.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblMenos_Click(sender As Object, e As EventArgs) Handles lblMenos.Click
        dgvPaquetes.DataSource = dts
    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblBuscar.MouseMove, lblGUARDAR.MouseMove, lblReset.MouseMove, lblCancelar.MouseMove, lblMas.MouseMove, lblMenos.MouseMove, lblPersonalizar.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
        lbl.BackColor = Color.FromArgb(217, 69, 78)
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblBuscar.MouseLeave, lblGUARDAR.MouseLeave, lblReset.MouseLeave, lblCancelar.MouseLeave, lblMas.MouseLeave, lblMenos.MouseLeave, lblPersonalizar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
        lbl.BackColor = Color.FromArgb(186, 69, 78)
    End Sub

    Private Sub lblGUARDAR_Click(sender As Object, e As EventArgs) Handles lblGUARDAR.Click
        Try
            If validarReserva() Then
                If personalizado = False Then
                    Dim daoR As New ReservaDAO
                    Dim rp As New Reservap
                    rp.cliente = cliente.id
                    rp.comentario = txtComentario.Text
                    rp.entrega = CDbl(txtEntrega.Text)
                    rp.paquete = paqueteID
                    rp.fecha = Date.Today
                    rp.total = CDbl(txtTotal.Text)
                    rp.descripcion = lblPaquete.Text
                    rp.descuento = CDbl(txtDescuento.Text)
                    If rbTarjeta.Checked = True Then
                        rp.formaPago = "Tarjeta"
                    Else
                        rp.formaPago = "Efectivo"
                    End If

                    If rp.total = CInt(txtEntrega.Text) Then
                        rp.estado = "AP"
                        rp.saldo = 0
                    Else
                        rp.estado = "AD"
                        rp.saldo = rp.total - CDbl(txtEntrega.Text)
                    End If

                    'End If
                    idr = daoR.guardarReservaP(rp)
                    MsgBox("¡Reserva de paquete realizada exitosamente! Se lo mandará a la ventana de agendar citas para la misma", MsgBoxStyle.Information, "Notificación")
                    Me.DialogResult = DialogResult.OK
                Else
                    Dim daoR As New ReservaDAO
                    Dim rp As New Reservap
                    rp.cliente = cliente.id
                    rp.comentario = txtComentario.Text
                    rp.entrega = CDbl(txtEntrega.Text)
                    rp.paquete = paqueteID
                    rp.fecha = Date.Today
                    rp.total = CDbl(txtTotal.Text)
                    rp.descripcion = lblPaquete.Text
                    rp.descuento = CDbl(txtDescuento.Text)
                    If rbTarjeta.Checked = True Then
                        rp.formaPago = "Tarjeta"
                    Else
                        rp.formaPago = "Efectivo"
                    End If

                    If rp.total = CInt(txtEntrega.Text) Then
                        rp.estado = "AP"
                        rp.saldo = 0
                    Else
                        rp.estado = "AD"
                        rp.saldo = rp.total - CDbl(txtEntrega.Text)
                    End If
                    rp.paqueteNombre = "Paquete personalizado"
                    'End If
                    idr = daoR.guardarReservaPPersonalizada(rp, dgvPaquetes.Rows)
                    MsgBox("¡Reserva de paquete realizada exitosamente! Se lo mandará a la ventana de agendar citas para la misma", MsgBoxStyle.Information, "Notificación")
                    Me.DialogResult = DialogResult.OK
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NuevaReservaPaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dts = dgvPaquetes.DataSource
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        pnlCtrl.Left = (Me.ClientSize.Width / 2) - (pnlCtrl.Width / 2)
        txtEntrega.Text = FormatCurrency(0, 1)
    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        txtClienteApe.Text = ""
        txtClienteCI.Text = ""
        txtClienteNombre.Text = ""
        txtClienteRUC.Text = ""
        txtTotal.Text = FormatCurrency("0", 1)
        txtComentario.Text = ""
        txtEntrega.Text = FormatCurrency("0", 1)
        dgvPaquetes.DataSource = ""
    End Sub

    Private Function validarReserva() As Boolean

        If txtClienteCI.Text = "" Then
            MsgBox("Deber seleccionar un cliente", MsgBoxStyle.Critical, "Notificación")
            txtBusqueda.Focus()
            Return False
        ElseIf dgvPaquetes.Rows.Count = 0 Then
            MsgBox("La reserva debe tener al menos un paquete asignado. Escoja servicios para la reserva", MsgBoxStyle.Critical, "Notificación")
            Return False
        ElseIf CDbl(txtEntrega.Text) > CDbl(txtTotal.Text) Then
            MsgBox("La entrega inicial supera al monto total", MsgBoxStyle.Critical, "Notificación")
            txtEntrega.Focus()
            Return False
        End If
        If txtEntrega.Text = "" Then
            txtEntrega.Text = "0"
        End If
        Return True



    End Function

    Private Sub txtEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntrega.KeyPress, txtDescuento.KeyPress, txtTotal.KeyPress
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

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        If txtDescuento.Text <> "" Then
            txtDescuento.Text = FormatCurrency(txtDescuento.Text, 1)

            txtDescuento.Select(txtDescuento.TextLength - 2, 0)
            txtTotal.Text = FormatCurrency(totalPaquete - CDbl(txtDescuento.Text), 1)
        Else
            txtDescuento.Text = FormatCurrency(0, 1)
            txtDescuento.Select(txtDescuento.TextLength - 2, 0)
            txtTotal.Text = FormatCurrency(totalPaquete - CDbl(txtDescuento.Text), 1)
        End If
    End Sub

    Private Sub txtDescuento_Click(sender As Object, e As EventArgs) Handles txtDescuento.Click
        If txtDescuento.Text <> "" Then
            txtDescuento.Select(txtDescuento.TextLength - 2, 0)
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text <> "" Then
            txtTotal.Text = FormatCurrency(txtTotal.Text, 1)
            txtTotal.Select(txtTotal.TextLength - 2, 0)
        Else
            txtTotal.Text = FormatCurrency(0, 1)
            txtTotal.Select(txtTotal.TextLength - 2, 0)
        End If
    End Sub

    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click
        If txtTotal.Text <> "" Then
            txtTotal.Select(txtTotal.TextLength - 2, 0)
        End If
    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            lblBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub lblPersonalizar_Click(sender As Object, e As EventArgs) Handles lblPersonalizar.Click
        Try
            If dgvPaquetes.RowCount = 0 Then
                MsgBox("Debe seleccionar un paquete antes de personalizar", MsgBoxStyle.Information, "Personalizar")
                Exit Sub
            End If
            Dim selectSer As New PersonalizarPaquete
            AddHandler selectSer.MessageSending, AddressOf Form2_MessageSending
            AddHandler selectSer.FormClosed, AddressOf Form2_FormClosed
            selectSer.ShowDialog(Me)
            selectSer.Dispose()
            txtTotal.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_MessageSending(sender As Object, e As Servicio)
        Try
            Dim MyNewRow As DataRow
            MyNewRow = detalle.Tables("tabla").NewRow
            With MyNewRow


                .Item(0) = e.id
                .Item(1) = e.nombre
                .Item(2) = 0
                .Item(3) = e.duracion
            End With
            detalle.Tables("tabla").Rows.Add(MyNewRow)
            dgvPaquetes.DataSource = detalle.Tables("tabla")
            personalizado = True
            txtTotal.Enabled = True
            txtTotal.ReadOnly = False
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
        Dim frm As PersonalizarPaquete = TryCast(sender, PersonalizarPaquete)
        If frm IsNot Nothing Then
            RemoveHandler frm.MessageSending, AddressOf Form2_MessageSending
            RemoveHandler frm.FormClosed, AddressOf Form2_FormClosed
        End If
    End Sub
End Class