Imports Backend

Public Class VisualizarReserva
    Public reserva As New Reserva
    Dim tabla As New DataTable

    Private Sub VisualizarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim daoCli As New ClienteDAO

            Dim cliente = daoCli.cargarCliente(reserva.cliente)
            txtClienteNombre.Text = cliente.nombre
            txtClienteApe.Text = cliente.apellido
            txtClienteCI.Text = cliente.ci
            txtClienteRUC.Text = cliente.ruc
            txtFecha.Text = reserva.fecha
            txtHoraInicio.Text = reserva.horaInicio
            txtHoraFin.Text = reserva.horaFin
            Dim duracion = TimeSpan.Parse(reserva.horaFin) - TimeSpan.Parse(reserva.horaInicio)
            txtDuracion.Value = duracion.TotalMinutes
            Dim daor As New ReservaDAO
            Dim lista = daor.cargarServiciosReserva(reserva.id)
            tabla = lista.Tables("tabla")
            listServicios.DataSource = tabla
            listServicios.ValueMember = "ID"
            listServicios.DisplayMember = "Nombre"
            listServicios.ClearSelected()

            Dim daoP As New PersonalDAO
            Dim empleados = daoP.getEmp
            cbEmpleados.DataSource = empleados.Tables("tabla")
            cbEmpleados.ValueMember = "ID"
            cbEmpleados.DisplayMember = "Nombre"
            Dim encargado = daor.cargarEncargado(reserva.id)

            cbEmpleados.SelectedValue = encargado.id
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub txtDuracion_ValueChanged(sender As Object, e As EventArgs) Handles txtDuracion.ValueChanged
        Dim count As TimeSpan = TimeSpan.Parse(txtHoraInicio.Text)
        txtHoraFin.Text = ((count + TimeSpan.FromMinutes(txtDuracion.Value)).ToString("hh\:mm"))
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

    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape3.MouseMove, lblCancelar.MouseMove
        Me.SuspendLayout()
        lblCancelar.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape3.MouseLeave, lblCancelar.MouseLeave
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