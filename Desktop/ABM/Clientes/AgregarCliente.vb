Imports System.Globalization
Imports System.Net.Mail
Imports Backend

Public Class AgregarCliente
    Dim agregados = 0
    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSexo.SelectedIndex = 0
        cbEstadoC.SelectedIndex = 0
        centrarElementos()
        txtNombre.Focus()
    End Sub

    Private Sub centrarElementos()
        Me.SuspendLayout()
        gbDatosPersonales.Left = (Me.ClientSize.Width / 2) - (gbDatosPersonales.Width / 2)
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Panel4.Left = (Me.ClientSize.Width / 2) - (Panel4.Width / 2)
        gbFichaMed.Left = gbDatosPersonales.Left
        gbAntecedentesEnfer.Left = gbDatosPersonales.Left
        Me.ResumeLayout()
    End Sub
    Private Sub guardarCliente(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblGUARDAR.Click
        Try
            If controlarCampos() Then
                Dim clieDao As New ClienteDAO
                Dim clienteNuevo As New Cliente
                clienteNuevo.nombre = txtNombre.Text
                clienteNuevo.apellido = txtApellido.Text
                clienteNuevo.ci = txtCI.Text
                clienteNuevo.cel = txtCelular.Text
                clienteNuevo.email = txtEmail.Text
                clienteNuevo.tel = txtTelefono.Text
                clienteNuevo.ruc = txtRUC.Text
                clienteNuevo.dir = txtDir.Text
                clienteNuevo.dirDep = txtDepartamento.Text
                clienteNuevo.dirCiudad = txtCiudad.Text
                clienteNuevo.dirBarrio = txtBarrio.Text
                clienteNuevo.nacio = txtNacionalidad.Text
                If cbSexo.SelectedIndex = 1 Then
                    clienteNuevo.sex = "F"
                Else
                    clienteNuevo.sex = "M"
                End If

                'Dim fech = DateTime.Parse(fechaNac).Date
                'Date.TryParseExact(fechaNac, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyle.None, out fech)
                clienteNuevo.edad = CInt(txtEdad.Text)
                If cbEstadoC.SelectedIndex = 1 Then
                    clienteNuevo.estadoC = "S"
                ElseIf cbEstadoC.SelectedIndex = 2 Then
                    clienteNuevo.estadoC = "C"
                ElseIf cbEstadoC.SelectedIndex = 3 Then
                    clienteNuevo.estadoC = "V"
                ElseIf cbEstadoC.SelectedIndex = 4 Then
                    clienteNuevo.estadoC = "D"
                End If

                Dim idCli = clieDao.guardarCliente(clienteNuevo)
                Dim ficha As New FichaM
                ficha.idCliente = idCli
                ficha.anteM = txtAntMadre.Text
                ficha.anteP = txtAntPadre.Text
                ficha.anteH = txtAntHermanos.Text
                ficha.anteHj = txtAntHijos.Text
                ficha.anteAlerg = r1Alérgicos.Checked
                ficha.anteAsm = r1Asma.Checked
                ficha.anteCardio = r1Cardio.Checked
                ficha.anteDig = r1Digestivos.Checked
                ficha.anteGenit = r1Genito.Checked
                ficha.anteMeta = r1Metabol.Checked
                ficha.anteNeop = r1Neoplasicos.Checked
                ficha.anteOsteo = r1Osteo.Checked
                ficha.anteResp = r1Respiratorios.Checked
                ficha.anteAudioV = r1AudioV.Checked
                ficha.anteCiru = r1Cirugias.Checked
                ficha.anteNeuro = r1Neuro.Checked
                ficha.antePsico = r1Psico.Checked
                ficha.anteTransfu = r1Transfu.Checked
                ficha.anteInter = r1Interna.Checked
                ficha.anteOtros = txtOtrosAntecedentes.Text
                Dim idFicha = clieDao.guardarFichaCliente(ficha)


                If txtEnfermedad.Text.Length > 0 Then
                    Dim historial As New Historial
                    historial.idFicha = idFicha
                    historial.imc = txtImc.Text
                    historial.enfermedad = txtEnfermedad.Text
                    historial.altura = txtAltura.Text
                    historial.bd = txtBD.Text
                    historial.bi = txtBI.Text
                    historial.bomb = txtBOMB.Text
                    historial.cinth = txtCINT.Text
                    historial.omb = txtOMB.Text
                    historial.pd = txtPD.Text
                    historial.peso = txtPeso.Text
                    historial.pesoI = txtPesoI.Text
                    historial.pi = txtPI.Text
                    historial.fecha = Date.Today
                    clieDao.guardarHistorial(historial)
                End If

                If cbEncargado.Checked = True Then
                    Dim encargado As New Encargado
                    encargado.ci = txtCiEncargado.Text
                    encargado.apellido = txtApellidoEncargado.Text
                    encargado.edad = txtEdad.Text
                    encargado.nombre = txtNombreEncargado.Text
                    encargado.ocupacion = txtOcupacionEncargado.Text
                    encargado.telefono = txtTelefonoEncargado.Text
                    encargado.cliente = idCli
                    clieDao.guardarEncargado(encargado)
                End If
                Dim result As Integer = MessageBox.Show("¡Cliente registrado con éxito Desea continuar agregando? ", "Continuar", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    Me.DialogResult = DialogResult.OK
                ElseIf result = DialogResult.Yes Then
                    agregados += 1
                    resetValores(sender, e)
                    txtNombre.Focus()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function controlarCampos() As Boolean
        Try
            If txtNombre.Text = "" Then
                MsgBox("Debe ingresar un nombre para el cliente", MsgBoxStyle.Critical, "Atención")
                txtNombre.Focus()
                Return False
            ElseIf txtApellido.Text = "" Then
                MsgBox("Debe ingresar un apellido para el cliente", MsgBoxStyle.Critical, "Atención")
                txtApellido.Focus()
                Return False
            ElseIf txtCI.Text = "" Then
                MsgBox("Debe ingresar una C.I para el cliente", MsgBoxStyle.Critical, "Atención")
                txtCI.Focus()
                Return False
            ElseIf cbSexo.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un sexo para el cliente", MsgBoxStyle.Critical, "Atención")
                cbSexo.Focus()
                Return False
            ElseIf cbEstadoC.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un estado civil para el cliente", MsgBoxStyle.Critical, "Atención")
                cbSexo.Focus()
                Return False
            ElseIf Not IsNumeric(txtEdad.Text) Then
                MsgBox("Ingrese una edad válida", MsgBoxStyle.Critical, "Atención")
                txtEdad.Focus()
                Return False
            ElseIf txtTelefono.Text = "" Then
                MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
                txtTelefono.Focus()
                Return False
            ElseIf txtCelular.Text = "" Then
                MsgBox("Debe ingresar un celular válido", MsgBoxStyle.Critical, "Atención")
                txtCelular.Focus()
                Return False
            ElseIf txtTelefono.Text = "" Then
                MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
                txtTelefono.Focus()
                Return False
            ElseIf txtNacionalidad.Text = "" Then
                MsgBox("Debe ingresar una nacionalidad", MsgBoxStyle.Critical, "Atención")
                txtNacionalidad.Focus()
                Return False
            ElseIf txtdir.Text = "" Then
                MsgBox("Debe ingresar una dirección", MsgBoxStyle.Critical, "Atención")
                txtDir.Focus()
                Return False
            ElseIf txtDepartamento.Text = "" Then
                MsgBox("Debe ingresar un departamento", MsgBoxStyle.Critical, "Atención")
                txtDepartamento.Focus()
                Return False
            ElseIf txtCiudad.Text = "" Then
                MsgBox("Debe ingresar una ciudad", MsgBoxStyle.Critical, "Atención")
                txtCiudad.Focus()
                Return False
            ElseIf txtBarrio.Text = "" Then
                MsgBox("Debe ingresar un barrio", MsgBoxStyle.Critical, "Atención")
                txtBarrio.Focus()
                Return False
            End If

            If txtEnfermedad.Text.Length > 0 Then

                If txtPeso.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPeso.Focus()
                    Return False
                ElseIf txtPesoI.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPesoI.Focus()
                    Return False
                ElseIf txtAltura.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtAltura.Focus()
                    Return False
                ElseIf txtImc.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtImc.Focus()
                    Return False
                ElseIf txtCINT.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtCINT.Focus()
                    Return False
                ElseIf txtOMB.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtOMB.Focus()
                    Return False
                ElseIf txtBOMB.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtBOMB.Focus()
                    Return False
                ElseIf txtPD.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPD.Focus()
                    Return False
                ElseIf txtBD.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtBD.Focus()
                    Return False
                ElseIf txtPI.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtPI.Focus()
                    Return False
                ElseIf txtBI.Text = "" Then
                    MsgBox("Si va registrar una enfermedad tratada actualmente, rellene todos los campos", MsgBoxStyle.Critical, "Atención")
                    txtBI.Focus()
                    Return False
                End If
            End If
            If txtEmail.Text <> "" Then
                Dim testAddress = New MailAddress(txtEmail.Text)
            End If




        Catch ex As Exception

            MsgBox("Debe ingresar un email válido", MsgBoxStyle.Critical, "Atención")
            txtEmail.Focus()
            Return False
        End Try
        Return True
    End Function

    Private Sub resetValores(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        txtNombre.Text = ""

        txtApellido.Text = ""
        txtCI.Text = ""
        cbSexo.SelectedIndex = 0
        txtEdad.Text = ""

        txtRUC.Text = ""

        txtTelefono.Text = ""

        txtCelular.Text = ""

        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        resetValores(sender, e)
    End Sub

    Private Sub cancelarNuevo(sender As Object, e As EventArgs) Handles RectangleShape3.Click, lblCancelar.Click
        If agregados = 0 Then
            Me.DialogResult = DialogResult.Cancel
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    '' --------------------------------- HOVERS BOTONES
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

    '' ---------------------- ELEMENTOS  VARIOS

    Private Sub fecha_foco(sender As Object, e As EventArgs) Handles txtEdad.Enter

        txtEdad.ForeColor = Color.FromArgb(22, 23, 24)
        If txtEdad.Text = "dd" Then
            txtEdad.Text = ""
        End If

    End Sub





    Private Sub txtDia_Leave(sender As Object, e As EventArgs) Handles txtEdad.Leave
        If txtEdad.Text = "" Then
            txtEdad.Text = ""
            txtEdad.ForeColor = Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub soloNumerosTxt(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress, txtCI.KeyPress, txtEdadEncargado.KeyPress
        soloNumeros(e)
    End Sub





    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbEncargado.CheckedChanged
        If cbEncargado.Checked = False Then
            gbEncargado.Visible = False
            gbDatosPersonales.Height = gbDatosPersonales.Height - gbEncargado.Height
            gbFichaMed.Top = gbDatosPersonales.Bottom + 10

        Else
            gbEncargado.Visible = True
            gbDatosPersonales.Height = gbDatosPersonales.Height + gbEncargado.Height
            gbFichaMed.Top = gbDatosPersonales.Bottom + 10
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles r1Cardio.CheckedChanged

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class