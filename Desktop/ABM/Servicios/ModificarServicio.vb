Imports Backend

Public Class ModificarServicio
    Dim servicio As New Servicio
    Dim id_servicio
    Public Sub New(ByVal serv As String)
        InitializeComponent()
        id_servicio = serv
    End Sub

    Private Sub ModificarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Public Sub cargarDatos()
        Try
            Dim daoServ As New ServicioDAO
            Dim tipos = daoServ.getTipos()
            cbTipos.DataSource = tipos.Tables("tabla")

            servicio = daoServ.obtenerServicio(id_servicio)
            txtNombre.Text = servicio.nombre
            txtDuracion.Value = servicio.duracion
            txtDesc.Text = servicio.descripcion
            txtCosto.Text = servicio.costo
            cbTipos.SelectedIndex = servicio.tipo
            cbTipos.DisplayMember = "Nombre"
            cbTipos.ValueMember = "ID"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub soloNumerosTxt(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        soloNumeros(e)
    End Sub

    '' --------------------------- HOVERS DE BOTONES
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

    Private Function controlarCampos() As Boolean

        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar un nombre para el cliente", MsgBoxStyle.Critical, "Atención")
            txtNombre.Focus()
            Return False
        ElseIf txtDesc.Text = "" Then
            MsgBox("Agregue una descripción para el servicio", MsgBoxStyle.Critical, "Atención")
            txtDesc.Focus()
            Return False
        ElseIf cbTipos.SelectedIndex = 0 Then
            MsgBox("Seleccion un tipo para el servicio", MsgBoxStyle.Critical, "Atención")
            cbTipos.Focus()
            Return False
        ElseIf txtCosto.Text = "" Then
            MsgBox("Ingrese un monto para el costo del servicio", MsgBoxStyle.Critical, "Atención")
            txtCosto.Focus()
            Return False
            'ElseIf Not IsNumeric(txtDia.Text) Or Not IsNumeric(txtMes.Text) Or Not IsNumeric(txtAnho.Text) Then
            '    MsgBox("Ingrese una fecha de nacimiento válida", MsgBoxStyle.Critical, "Atención")
            '    txtDia.Focus()
            '    Return False
        End If

        Return True
    End Function
    Private Sub guardarServicio(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblGUARDAR.Click
        Try
            If controlarCampos() Then
                Dim servMod As New Servicio
                Dim daoServ As New ServicioDAO
                servMod.id = id_servicio
                servMod.nombre = txtNombre.Text
                servMod.descripcion = txtDesc.Text
                servMod.costo = txtCosto.Text
                servMod.duracion = txtDuracion.Value
                servMod.tipo = cbTipos.SelectedIndex
                daoServ.actualizarServicio(servMod)
                MsgBox("Servicio <<" + servicio.nombre + ">> modificado! Volviendo al menu principal")
                Me.DialogResult = DialogResult.OK

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cancelarModificacion(sender As Object, e As EventArgs) Handles lblCancelar.Click, RectangleShape3.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub resetValores(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblReset.Click
        txtNombre.Text = servicio.nombre
        txtDuracion.Value = servicio.duracion
        txtDesc.Text = servicio.descripcion
        txtCosto.Text = servicio.costo
        cbTipos.SelectedIndex = servicio.tipo
    End Sub
End Class