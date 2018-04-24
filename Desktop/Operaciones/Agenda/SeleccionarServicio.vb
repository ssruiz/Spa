Imports Backend

Public Class SeleccionarServicio
    Public servicio As String
    Public id_serv As String
    Dim info
    Private Sub SeleccionarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim daoSer As New ServicioDAO
            Dim list = daoSer.cargarServiciosNombre
            listServicios.DataSource = list.Tables("tabla")
            listServicios.ValueMember = "ID"
            listServicios.DisplayMember = "Nombre"
            listServicios.ClearSelected()
            info = New PasarInfo()
            Me.Top = Owner.Top
            Me.Left = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Event MessageSending(sender As Object, e As DataTable)

    Public ReadOnly Property LastMessage() As String
        Get
            Return servicio
        End Get
    End Property

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblAgregar.Click
        If listServicios.SelectedIndex >= 0 Then
            Dim s = listServicios.SelectedValue
            Dim n = listServicios.SelectedItem("Nombre").ToString
            servicio = s.ToString
            Dim daoS As New ServicioDAO
            Dim list = daoS.obtenerServicioReserva(s)
            info.cargarDato(list, n)
            RaiseEvent MessageSending(Me, info.tabla)
        Else
            MsgBox("Debe seleccionar un servicio para agregar", MsgBoxStyle.Critical, "Atención")
        End If
    End Sub

    Private Sub RectangleShape1_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape1.MouseMove, lblAgregar.MouseMove
        Me.SuspendLayout()
        lblAgregar.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave, lblAgregar.MouseLeave
        Me.SuspendLayout()
        lblAgregar.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.MouseMove, lblSalir.MouseMove
        Me.SuspendLayout()
        lblSalir.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape2.MouseLeave, lblSalir.MouseLeave
        Me.SuspendLayout()
        lblSalir.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_Click_1(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblSalir.Click
        Me.Close()


    End Sub
End Class