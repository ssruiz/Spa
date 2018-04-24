Imports Backend

Public Class AgregarServicio
    Dim agregados = 0
    Private Sub AgregarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarServicios()

    End Sub

    Public Sub cargarServicios()
        Try
            Dim daoServicio As New ServicioDAO
            Dim tipos = daoServicio.getTipos()

            Dim listTipos = tipos.Tables("tabla")
            Dim rowD = listTipos.NewRow
            rowD("Nombre") = "--- Seleccione un Tipo --- "
            rowD("ID") = 0
            listTipos.Rows.InsertAt(rowD, 0)


            cbTipos.DataSource = listTipos
            cbTipos.DisplayMember = "Nombre"
            cbTipos.ValueMember = "ID"

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    '' ----------------------------- HOVERS BOTONES

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

    Private Sub guardarServicio(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblGUARDAR.Click
        Try
            If controlarCampos() Then

                Dim serv As New Servicio
                Dim daoServ As New ServicioDAO
                serv.nombre = txtNombre.Text
                serv.descripcion = txtDesc.Text
                serv.costo = txtCosto.Text
                serv.tipo = cbTipos.SelectedIndex
                serv.duracion = txtDuracion.Value
                daoServ.agregarServicio(serv)

                Dim result = MessageBox.Show("¡Servicio <<" + serv.nombre + ">> agregado! ¿Desea seguir agregando?", "Continuar", MessageBoxButtons.YesNo)
                If result = MsgBoxResult.No Then
                    Me.DialogResult = DialogResult.OK
                Else
                    agregados += 1
                    resetCampos()
                    txtNombre.Focus()
                End If
            End If

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub resetCampos()
        txtNombre.Text = ""
        txtCosto.Text = ""
        txtCosto.Text = ""
        txtDuracion.Value = 0
        cbTipos.SelectedIndex = 0
    End Sub
    Private Function controlarCampos() As Boolean

        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar un nombre para el servicio", MsgBoxStyle.Critical, "Atención")
            txtNombre.Focus()
            Return False
        ElseIf cbTipos.SelectedIndex = 0 Then
            MsgBox("Seleccion un tipo para el servicio", MsgBoxStyle.Critical, "Atención")
            cbTipos.Focus()
            Return False
        ElseIf txtCosto.text = "" Then
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

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblReset.Click
        resetCampos()
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click, lblCancelar.Click
        If agregados = 0 Then
            Me.DialogResult = DialogResult.Cancel
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub soloNumerosTxt(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        soloNumeros(e)
    End Sub



    Private Sub txtEntrega_TextChanged(sender As Object, e As EventArgs) Handles txtCosto.TextChanged
        If txtCosto.Text <> "" Then
            txtCosto.Text = FormatCurrency(txtCosto.Text, 1)
            txtCosto.Select(txtCosto.TextLength - 2, 0)
        Else
            txtCosto.Text = FormatCurrency(0, 1)
            txtCosto.Select(txtCosto.TextLength - 2, 0)
        End If
    End Sub

    Private Sub txtEntrega_Click(sender As Object, e As EventArgs) Handles txtCosto.Click
        If txtCosto.Text <> "" Then
            txtCosto.Select(txtCosto.TextLength - 2, 0)
        End If
    End Sub
End Class