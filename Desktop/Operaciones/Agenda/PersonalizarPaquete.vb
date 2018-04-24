Imports Backend

Public Class PersonalizarPaquete
    Public servicio As String
    Public id_serv As String
    Public newServicio As New Servicio
    Dim info

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles lblAgregar.Click
        If validarPerso() Then
            Dim s = listServicios.SelectedValue
            Dim n = listServicios.SelectedItem("Nombre").ToString
            servicio = s.ToString
            newServicio.id = listServicios.SelectedItem("ID").ToString
            newServicio.nombre = n
            newServicio.duracion = nroSesion.Value
            RaiseEvent MessageSending(Me, newServicio)

        End If
    End Sub

    Public Event MessageSending(sender As Object, e As Servicio)

    Public ReadOnly Property LastMessage() As Servicio
        Get
            Return newServicio
        End Get
    End Property


    Private Function validarPerso()
        If listServicios.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un servicio")
            Return False
        ElseIf nroSesion.Value = 0 Then
            MsgBox("El número de sesiones debe ser mayor a cero")
            Return False
        End If
        Return True
    End Function



    Private Sub PersonalizarPaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub lblAgregar_Click(sender As Object, e As EventArgs) Handles lblAgregar.Click

    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub lblBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblSalir.MouseMove, lblAgregar.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
        lbl.BackColor = Color.FromArgb(217, 69, 78)
    End Sub

    Private Sub lblBuscar_MouseLeave(sender As Object, e As EventArgs) Handles lblSalir.MouseLeave, lblAgregar.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
        lbl.BackColor = Color.FromArgb(186, 69, 78)
    End Sub
End Class