Imports Backend

Public Class AgendarServiciosPaquete
    Dim dtp As New DateTimePicker
    Dim rect As New Rectangle
    Dim reserva As New Reservap
    Public idReservaM
    Private Sub AgendarServiciosPaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centrarElementos()
        cargarDatosReserva()
        cargarSesionesAgendadas()

        cargarSesiones()

        'dgvPaquetes.Controls.Add(dp)
        'dp.Format = DateTimePickerFormat.Short
        'dp.Visible = False
        agregarColumnas()

        dgvPaquetes.Controls.Add(dtp)
        dtp.Format = DateTimePickerFormat.Short
        dtp.Visible = False
        AddHandler dtp.TextChanged, AddressOf dtp_OnTextChange
        AddHandler dtp.CloseUp, AddressOf dtp_cerrar




    End Sub

    Public Sub cargarSesionesAgendadas()
        Try
            Dim dr As New ReservaDAO
            Dim sesionesAgend = dr.cargarSesionesAgendadas(reserva.id)
            dgvSesionesAgend.DataSource = sesionesAgend.Tables("tabla")
            dgvSesionesAgend.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub centrarElementos()
        Me.SuspendLayout()

        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)


        Me.ResumeLayout()
    End Sub

    Private Sub cargarSesiones()
        dgvPaquetes.SuspendLayout()
        Dim daoS As New ServicioDAO
        Dim detalle = daoS.cargarSesiones(idReservaM)

        dgvPaquetes.DataSource = detalle.Tables("tabla")
        'dgvPaquetes.Columns("ID").Visible = False
        'dgvPaquetes.Columns("IDP").Visible = False

        dgvPaquetes.ClearSelection()

        dgvPaquetes.ResumeLayout()
        dgvPaquetes.Update()
        calcularSesionesRestantes()
    End Sub

    Private Sub cargarDatosReserva()
        Try
            Dim rs As New ReservaDAO
            reserva = rs.cargarReservaP(idReservaM)

            lblPaquete.Text = reserva.paqueteNombre
            txtClienteNombre.Text = reserva.clienteNombre
            txtComent.Text = reserva.comentario
            txtFecha.Text = reserva.fecha
            txtTotal.Text = FormatCurrency(reserva.total, 1)
            txtSaldo.Text = FormatCurrency(reserva.saldo, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub calcularSesionesRestantes()
        For Each row As DataGridViewRow In dgvPaquetes.Rows
            row.Cells("SesionesRest").Value = Convert.ToInt32(row.Cells("TotalS").Value) - Convert.ToInt32(row.Cells("SesionesR").Value)
        Next
    End Sub
    Private Sub agregarColumnas()
        Dim cmb As New DataGridViewComboBoxColumn()
        cmb.DataSource = horasCb
        cmb.Name = "Horas"
        cmb.HeaderText = "Hora"

        'cmb.DisplayIndex = 1
        'cmb.DisplayMember = "ID"
        dgvPaquetes.Columns.Add(cmb)

        Dim chb As New DataGridViewButtonColumn()
        chb.Name = "AgendarS"
        chb.HeaderText = "Agendar Cita"
        chb.Text = "Agendar"
        chb.UseColumnTextForButtonValue = True
        dgvPaquetes.Columns.Add(chb)
        'cbo.DataSource = bd
        'cbo.DisplayMember = "Value"
        'dgvPaquetes.Columns.Add(cbo)


        dgvPaquetes.Columns("Servicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim chb2 As New DataGridViewButtonColumn()
        chb2.Name = "CancelarCita"
        chb2.HeaderText = "Cancelar Cita"
        chb2.Text = "Cancelar"
        chb2.UseColumnTextForButtonValue = True
        dgvSesionesAgend.Columns.Add(chb2)

        dgvSesionesAgend.Columns("CancelarCita").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        'dgvPaquetes.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        'dgvPaquetes.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        'dgvPaquetes.Columns("HoraS").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub
    Private Sub dgvPaquetes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaquetes.CellClick
        Select Case dgvPaquetes.Columns(e.ColumnIndex).Name
            Case "FechaS"
                If e.RowIndex > -1 Then
                    rect = dgvPaquetes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    dtp.Size = New Size(rect.Width, rect.Height)
                    dtp.Location = New Point(rect.X, rect.Y)
                    dtp.Visible = True
                    If dgvPaquetes.CurrentCell.Value = "" Then
                        dtp.Value = Date.Today
                    Else
                        dtp.Value = Date.Parse(dgvPaquetes.CurrentCell.Value)
                    End If
                    Exit Select
                End If
            Case "AgendarS"
                Dim row = e.RowIndex
                Dim fc = dgvPaquetes.CurrentRow.Cells("FechaS").Value
                Dim ind = dgvPaquetes.CurrentRow.Cells("HoraS").Value
                If fc = "" Then

                    MsgBox("Debe ingresar una fecha para la sesión")
                    Exit Select
                ElseIf ind = "" Then
                    MsgBox("Seleccione una hora para la sesión")

                Else
                    Dim daor As New ReservaDAO
                    Dim sesion As New SesionP
                    Dim comboBox = CType(dgvPaquetes.CurrentRow.Cells("HoraS"), DataGridViewComboBoxCell)

                    Dim inde = comboBox.Items.IndexOf(dgvPaquetes.CurrentRow.Cells("HoraS").Value).ToString
                    sesion.reservap = dgvPaquetes.CurrentRow.Cells("IDR").Value
                    sesion.fecha = Date.Parse(fc)
                    sesion.servicio = dgvPaquetes.CurrentRow.Cells("IDS").Value
                    sesion.horaInicio = TimeSpan.Parse(dgvPaquetes.CurrentRow.Cells("HoraS").Value)
                    sesion.tag = inde

                    Dim res = daor.guardarSesion(sesion)
                    If res = True Then
                        MsgBox("Sesión agendada")
                        cargarSesiones()
                        cargarSesionesAgendadas()
                    End If
                End If

        End Select
    End Sub

    Private Sub dtp_OnTextChange(sender As Object, e As EventArgs)
        '' dgvPaquetes.CurrentCell.Value = dtp.Text.ToString()
        'dgvPaquetes.Columns("FechaS").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub dtp_cerrar(sender As Object, e As EventArgs)
        dgvPaquetes.CurrentCell.Value = dtp.Text.ToString()
        dtp.Visible = False
        dgvPaquetes.Update()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub dgvSesionesAgend_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSesionesAgend.CellClick
        Select Case dgvSesionesAgend.Columns(e.ColumnIndex).Name
            Case "CancelarCita"
                Try

                Catch ex As Exception
                    MsgBox("Error", MsgBoxStyle.Critical, "Error")
                End Try
                Dim fc = dgvSesionesAgend.CurrentRow.Cells("IDCita").Value
                Dim sv = dgvSesionesAgend.CurrentRow.Cells("IDServ").Value
                Dim rp = dgvSesionesAgend.CurrentRow.Cells("IDReserva").Value
                Dim daor As New ReservaDAO
                Dim res = daor.cancelarCita(fc, rp, sv)
                If res = True Then

                    MsgBox("Cita Cancelada", MsgBoxStyle.Information, "Notificación")
                    cargarSesiones()
                    cargarSesionesAgendadas()
                End If

        End Select
    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblCancelar.MouseMove, lblPagar.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblCancelar.MouseLeave, lblPagar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
    End Sub

    Private Sub lblPagar_Click(sender As Object, e As EventArgs) Handles lblPagar.Click
        If CDbl(txtSaldo.Text) = 0 Then
            MsgBox("El costo del paquete ya está saldado", MsgBoxStyle.Information, "Pago")
        ElseIf txtPago.text = "" Then
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
                daor.realizarPagoPaquete(idReservaM, CDbl(txtPago.Text), tipo)

                MsgBox("¡Pago Realizado!", MsgBoxStyle.Information, "Pago")
                txtPago.Text = ""
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
End Class