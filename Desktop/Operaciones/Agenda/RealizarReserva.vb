Imports Backend

Public Class RealizarReserva
    Public tagHora As Integer
    Public fecha As Date
    Public trabajador As New Personal
    Dim tabla As New DataTable
    Dim dsServicios As New DataSet
    Dim cliente As New Cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim agregarSer As New SeleccionarServicio
            agregarSer.ShowDialog()


        Catch ex As System.Data.ConstraintException
            MsgBox("Ya agregó ese servicio", MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Sub RealizarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = fecha

        txtHoraInicio.Text = VariablesUtiles.horas.Item(tagHora).ToString
        txtTrabajador.Text = trabajador.nombre
        dsServicios.Tables.Add("servicios")

    End Sub


    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click, lblMas.Click
        Try


            Dim selectSer As New SeleccionarServicio
            AddHandler selectSer.MessageSending, AddressOf Form2_MessageSending
            AddHandler selectSer.FormClosed, AddressOf Form2_FormClosed
            selectSer.ShowDialog(Me)
            selectSer.Dispose()
            tabla = CType(listServicios.DataSource, DataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_MessageSending(sender As Object, e As DataTable)
        Try
            tabla.Merge(e)
            Me.listServicios.DataSource = tabla
            listServicios.DisplayMember = "Nombre"
            listServicios.ValueMember = "ID"
            listServicios.ClearSelected()
        Catch ex As Exception
            MsgBox("Ya agregó ese servicio!!!", MsgBoxStyle.Information, "Info")
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




    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click, lblCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblReset.Click
        txtClienteNombre.Text = ""
        txtClienteApe.Text = ""
        txtClienteCI.Text = ""
        txtClienteRUC.Text = ""
        tabla = New DataTable

        listServicios.DataSource = tabla
        txtComentario.Text = ""
        txtDuracion.Value = 0
        txtBusqueda.Text = ""
    End Sub




    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub RectangleShape6_Click(sender As Object, e As EventArgs) Handles RectangleShape6.Click, lblBuscar.Click
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

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblGUARDAR.Click
        Try
            If validarReserva() Then

                Dim daoR As New ReservaDAO
                Dim n = daoR.solapamiento(TimeSpan.Parse(txtHoraInicio.Text), TimeSpan.Parse(txtHoraFin.Text), Date.Parse(txtFecha.Text))
                If n > 0 Then
                    MsgBox("Horario no disponible", MsgBoxStyle.Information, "Atención")
                Else
                    Dim r As New Reserva
                    r.cliente = cliente.id
                    r.comentario = txtComentario.Text
                    r.horaInicio = txtHoraInicio.Text
                    r.horaFin = txtHoraFin.Text
                    r.fecha = txtFecha.Text
                    r.tag = tagHora
                    daoR.guardarReserva(r, trabajador, tabla)
                    MsgBox("Reserva registrada exitosamente!", MsgBoxStyle.Information, "Notificación")
                    Me.DialogResult = DialogResult.OK
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Function validarReserva() As Boolean
        If txtClienteCI.Text = "" Then
            MsgBox("Deber seleccionar un cliente", MsgBoxStyle.Critical, "Notificación")
            txtBusqueda.Focus()
            Return False
        ElseIf txtDuracion.Value = 0 Then
            MsgBox("La reserva debe tener una duración aproximanda en minutos", MsgBoxStyle.Critical, "Notificación")
            txtDuracion.Focus()
            Return False
        ElseIf listServicios.Items.Count = 0 Then
            MsgBox("La reserva debe tener al menos un servicio asignado. Escoja servicios para la reserva", MsgBoxStyle.Critical, "Notificación")

            Return False
        End If
        Return True
    End Function

    Private Sub RectangleShape5_Click(sender As Object, e As EventArgs) Handles RectangleShape5.Click, lblMenos.Click
        If listServicios.Items.Count = 0 Then
            MsgBox("La lista de servicios ya se encuentra vacía actualmente", MsgBoxStyle.Information, "Notificación")
        ElseIf listServicios.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un servicio de la lista para eliminar", MsgBoxStyle.Information, "Notificación")
        Else
            Dim elemento = listServicios.SelectedItem
            MsgBox(listServicios.SelectedIndex)
            tabla.Rows.RemoveAt(listServicios.SelectedIndex)
            listServicios.DataSource = tabla
        End If
    End Sub

    Private Sub txtDuracion_ValueChanged(sender As Object, e As EventArgs) Handles txtDuracion.ValueChanged
        Dim count As TimeSpan = TimeSpan.Parse(txtHoraInicio.Text)
        txtHoraFin.Text = ((count + TimeSpan.FromMinutes(txtDuracion.Value)).ToString("hh\:mm"))
    End Sub





    '' ----------------------------------- HOVERS DE BOTONES
    Private Sub RectangleShape1_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape1.MouseMove, lblGUARDAR.MouseMove
        Me.SuspendLayout()
        lblGUARDAR.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave, lblGUARDAR.MouseLeave
        Me.SuspendLayout()
        lblGUARDAR.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub


    Private Sub RectangleShape2_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape2.MouseMove, lblReset.MouseMove
        Me.SuspendLayout()
        lblReset.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape2.MouseLeave, lblReset.MouseLeave
        Me.SuspendLayout()
        lblReset.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape3.MouseMove
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape3.MouseLeave
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub



    ''------------------------- hovers-------------------------------------------------------------------------
    Private Sub RectangleShape4_MouseEnter(sender As Object, e As EventArgs) Handles RectangleShape4.MouseMove, lblMas.MouseMove
        Me.SuspendLayout()
        lblMas.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape4_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape4.MouseLeave, lblMas.MouseLeave
        Me.SuspendLayout()
        lblMas.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape5_MouseEnter(sender As Object, e As EventArgs) Handles RectangleShape5.MouseMove, lblMenos.MouseMove
        Me.SuspendLayout()
        lblMenos.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape5_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape5.MouseLeave, lblMenos.MouseLeave
        Me.SuspendLayout()
        lblMenos.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub
End Class