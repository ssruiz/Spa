Imports System.Net.Mail
Imports Backend

Public Class FichaMedica
    Dim id_cliente
    Dim cliente_mod As New Cliente
    Dim hayEncargado As Boolean
    Dim idFicha As String
    Public Sub New(ByVal cli As String)
        InitializeComponent()
        id_cliente = cli
    End Sub

    Private Sub FichaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        centrarElementos()
        cargarClienteDatos()
        cargarEncargado()
        cargarAntecedentes()
        cargarHistorial()
    End Sub

    Private Sub cargarHistorial()
        Try
            Dim daoCli As New ClienteDAO
            ''           Dim listh = daoCli.cargarHistorial(idFicha)
            Dim listTratamientos = daoCli.cargarTratamientos(idFicha)
            dgvHistorial.DataSource = listTratamientos.Tables("tabla")
            dgvHistorial.Columns("ID").Visible = False
            dgvHistorial.Columns("Ficha").Visible = False
            dgvHistorial.ColumnHeadersDefaultCellStyle.WrapMode = False
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            ''dgvHistorial.Columns("BI").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            'dgvHistorial.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
            dgvHistorial.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarAntecedentes()
        Try
            gbAntecedentes.SuspendLayout()
            Dim daocli As New ClienteDAO
            Dim ante = daocli.cargarAntecedentes(id_cliente)
            idFicha = ante.id.ToString
            txtAntHermanos.Text = ante.anteH
            txtAntHijos.Text = ante.anteHj
            txtAntMadre.Text = ante.anteM
            txtAntPadre.Text = ante.anteP
            If ante.anteCardio = True Then
                r1Cardio.Checked = True
            Else
                r2Cardio.Checked = True
            End If

            If ante.anteResp = True Then
                r1Respiratorios.Checked = True
            Else
                r2Respiratorio.Checked = True
            End If

            If ante.anteAlerg = True Then
                r1Alergicos.Checked = True
            Else
                r2Alergicos.Checked = True
            End If

            If ante.anteNeop = True Then
                r1Neoplasicos.Checked = True
            Else
                r2Neoplasicos.Checked = True
            End If

            If ante.anteDig = True Then
                r1Digestivos.Checked = True
            Else
                r2Digestivos.Checked = True
            End If

            If ante.anteGenit = True Then
                r1Genito.Checked = True
            Else
                r2Genito.Checked = True
            End If

            If ante.anteAsm = True Then
                r1Asma.Checked = True
            Else
                r2Asma.Checked = True
            End If

            If ante.anteMeta = True Then
                r1Metabol.Checked = True
            Else
                r2Metabol.Checked = True
            End If

            If ante.anteOsteo = True Then
                r1Osteo.Checked = True
            Else
                r2Osteo.Checked = True
            End If

            If ante.anteNeuro = True Then
                r1Neuro.Checked = True
            Else
                r2Neuro.Checked = True
            End If

            If ante.anteInter = True Then
                r1Interna.Checked = True
            Else
                r2Interna.Checked = True
            End If

            If ante.anteCiru = True Then
                r1Cirugias.Checked = True
            Else
                r2Cirugias.Checked = True
            End If

            If ante.antePsico = True Then
                r1Psico.Checked = True
            Else
                r2Psico.Checked = True
            End If

            If ante.anteAudioV = True Then
                r1AudioV.Checked = True
            Else
                r2AudioV.Checked = True
            End If

            If ante.anteTransfu = True Then
                r1Transfu.Checked = True
            Else
                r2Transfu.Checked = True
            End If

            txtOtrosAntecedentes.Text = ante.anteOtros
            gbAntecedentes.ResumeLayout()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarEncargado()
        Try
            gbEncargado.SuspendLayout()
            Dim daocli As New ClienteDAO
            Dim encargado = daocli.cargarEncargado(id_cliente)

            If encargado.cliente = 0 Then
                hayEncargado = False
            Else

                txtNombreEncargado.Text = encargado.nombre
                txtApellidoEncargado.Text = encargado.apellido
                txtCiEncargado.Text = encargado.ci
                txtEdadEncargado.Text = encargado.edad
                txtOcupacionEncargado.Text = encargado.ocupacion
                txtTelefonoEncargado.Text = encargado.telefono
                hayEncargado = True

            End If
            gbEncargado.ResumeLayout()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarClienteDatos()
        Try
            gbDatosPersonales.SuspendLayout()
            Dim daoCliente As New ClienteDAO

            cliente_mod = daoCliente.cargarCliente(id_cliente)
            txtNombre.Text = cliente_mod.nombre
            txtApellido.Text = cliente_mod.apellido
            txtCI.Text = cliente_mod.ci
            txtRUC.Text = cliente_mod.ruc
            txtDir.Text = cliente_mod.dir
            txtTelefono.Text = cliente_mod.tel
            txtCelular.Text = cliente_mod.cel
            txtEmail.Text = cliente_mod.email
            txtEdad.Text = cliente_mod.edad
            txtNacionalidad.Text = cliente_mod.nacio
            txtDepartamento.Text = cliente_mod.dirDep
            txtCiudad.Text = cliente_mod.dirCiudad
            txtBarrio.Text = cliente_mod.dirBarrio

            If cliente_mod.sex = "F" Then
                cbSexo.SelectedIndex = 1
            Else
                cbSexo.SelectedIndex = 2
            End If

            If cliente_mod.estadoC = "S" Then
                cbEstadoC.SelectedIndex = 1
            ElseIf cliente_mod.estadoC = "C" Then
                cbEstadoC.SelectedIndex = 2
            ElseIf cliente_mod.estadoC = "V" Then
                cbEstadoC.SelectedIndex = 3
            ElseIf cliente_mod.estadoC = "D" Then
                cbEstadoC.SelectedIndex = 4
            End If
            gbDatosPersonales.ResumeLayout()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub centrarElementos()
        Me.SuspendLayout()
        gbDatosPersonales.Left = (Me.ClientSize.Width / 2) - (gbDatosPersonales.Width / 2)
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Panel4.Left = (Me.ClientSize.Width / 2) - (Panel4.Width / 2)
        gbFichaMed.Left = gbDatosPersonales.Left
        gbEncargado.Left = gbDatosPersonales.Left
        gbHistorial.Left = gbDatosPersonales.Left
        Me.ResumeLayout()
    End Sub

    '' --------------------------------------- HOVERS --------------------------------------
    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles lblActAnt.MouseMove, lblActCliente.MouseMove, lblActEncargado.MouseMove, lblAgregarHistorial.MouseMove, lblVerHistorial.MouseMove

        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
        lbl.BackColor = Color.FromArgb(217, 69, 78)
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles lblActAnt.MouseLeave, lblActCliente.MouseLeave, lblActEncargado.MouseLeave, lblAgregarHistorial.MouseLeave, lblVerHistorial.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)
        lbl.BackColor = Color.FromArgb(186, 69, 78)
    End Sub


    Private Sub actCliente_Click(sender As Object, e As EventArgs) Handles lblActCliente.Click
        Try
            If controlarCampos() Then
                Dim clieDao As New ClienteDAO
                Dim clienteNuevo As New Cliente
                clienteNuevo.id = id_cliente
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

                clieDao.actualizarCliente(clienteNuevo)
                MsgBox("¡Datos Personales actualizados!", MsgBoxStyle.Information, "Atención")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
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
            ElseIf txtDir.Text = "" Then
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

    Private Sub actEncargado_Click(sender As Object, e As EventArgs) Handles lblActEncargado.Click
        Try
            Dim daocli As New ClienteDAO
            Dim encargado As New Encargado
            encargado.nombre = txtNombreEncargado.Text
            encargado.apellido = txtApellidoEncargado.Text
            encargado.ci = txtCiEncargado.Text
            encargado.edad = txtEdadEncargado.Text
            encargado.ocupacion = txtOcupacionEncargado.Text
            encargado.telefono = txtTelefonoEncargado.Text
            encargado.cliente = id_cliente
            If hayEncargado = True Then
                daocli.actualizarEncargado(encargado)
            Else
                daocli.guardarEncargado(encargado)
            End If
            MsgBox("¡Información del encargado actualizada!", MsgBoxStyle.Information, "Info")
        Catch ex As Exception
            MsgBox("Error" + ex.Message, MsgBoxStyle.Critical, "Atención")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub txtEdadEncargado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdadEncargado.KeyPress, txtEdad.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub actAntecedents_Click(sender As Object, e As EventArgs) Handles lblActAnt.Click
        Try
            Dim ficha As New FichaM
            Dim clieDao As New ClienteDAO
            ficha.id = CInt(idFicha)
            ficha.idCliente = id_cliente
            ficha.anteM = txtAntMadre.Text
            ficha.anteP = txtAntPadre.Text
            ficha.anteH = txtAntHermanos.Text
            ficha.anteHj = txtAntHijos.Text
            ficha.anteAlerg = r1Alergicos.Checked
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
            If idFicha = 0 Then
                clieDao.guardarFichaCliente(ficha)
            Else
                clieDao.actualizarFicha(ficha)
            End If
            MsgBox("¡Información de la ficha actualizada!", MsgBoxStyle.Information, "Info")
        Catch ex As Exception
            MsgBox("Error" + ex.Message, MsgBoxStyle.Critical, "Atención")
        End Try
    End Sub

    Private Sub dgv_style()
        For i As Integer = 0 To dgvHistorial.RowCount - 1
            If i Mod 2 = 0 Then
                dgvHistorial.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                dgvHistorial.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(219, 219, 219)
            End If
        Next
    End Sub

    Private Sub dgvInicio_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvHistorial.DataSourceChanged
        dgv_style()
        dgvHistorial.AutoResizeRows()
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles lblAgregarHistorial.Click
        Try
            Dim hist As New AgregarTratamiento
            hist.idficha = idFicha
            Dim res = hist.ShowDialog()
            If res = DialogResult.OK Then
                cargarHistorial()
            End If
            hist.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try
        '    Dim hist As New HistorialCliente
        '    hist.idficha = idFicha
        '    Dim res = hist.ShowDialog()
        '    If res = DialogResult.OK Then
        '        cargarHistorial()
        '    End If
        '    hist.Dispose()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Label41_Click_1(sender As Object, e As EventArgs) Handles lblVerHistorial.Click
        Try
            If dgvHistorial.SelectedRows.Count > 0 Then
                'Dim visualizarHistorial As New VisualizarHistorialCliente
                'visualizarHistorial.id = dgvHistorial.CurrentRow.Cells("IDH").Value
                'visualizarHistorial.ShowDialog()
                'visualizarHistorial.Dispose()
                Dim trata As New TratamientoDetalle
                trata.idtrat = dgvHistorial.CurrentRow.Cells("ID").Value
                trata.nombreTrat = dgvHistorial.CurrentRow.Cells("Tratamiento").Value
                trata.ShowDialog()
                trata.Dispose()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class