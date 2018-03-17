Imports System.Windows.Forms
Imports Backend
Imports Desktop.My.Resources
Imports MySql.Data.MySqlClient

Public Class Inicio
    '' ---------------------------------------- VARIABLES COMUNES USADAS EN EL FORM ------------------------------------------
    Dim target As String = ""
    Dim list As New DataSet
    Dim adpCliente As New MySqlDataAdapter
    Dim adpPersonal As New MySqlDataAdapter
    Dim adpServicios As New MySqlDataAdapter

    '' --------------------------------------------------- OPERACIONES DE CARGA ----------------------------------------------
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        crearBackGrounds()

        list.Tables.Add("clientes")
        list.Tables.Add("reservas")
        list.Tables.Add("servicios")
        list.Tables.Add("personal")
        dgvInicio.ForeColor = Color.FromArgb(24, 25, 27)
        'sender.BackColor = Color.FromArgb(56, 142, 60)

        dgvInicio.Font = New Font("Segoe UI Semibold", 12,
                    FontStyle.Bold)
        Me.ResumeLayout()
    End Sub

    Private Sub crearBackGrounds()
        'Dim bm = New Bitmap(inicio_fondo_spa, New Size(pnlImagenInicio.Width, pnlImagenInicio.Height))
        'pnlImagenInicio.BackgroundImage = bm
        'pnlImagenInicio.BackgroundImageLayout = ImageLayout.None

        'pnlBotones.BackColor = Color.FromArgb(80, Color.Black)
        'Button1.Image = New Bitmap(if_search_80px_510919, New Size(25, 25))
        'Dim bm = New Bitmap(margaritteSinFondo, New Size(ptLogo.Width, ptLogo.Height))
        'ptLogo.Image = bm

    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub


    '' -------------------------------------------   OPERACIONES CLIENTES --------------------------------------------------------

    Private Sub listadoClientes(sender As Object, e As EventArgs) Handles lblClientes.Click
        Try
            txtBuscar_Leave(sender, e)
            Me.SuspendLayout()
            If target <> "clientes" Then
                target = "clientes"
                lblReservas.Visible = True
                RectangleShape1.Visible = True
                If list.Tables("clientes").Rows.Count > 0 Then
                    dgvInicio.DataSource = ""
                    dgvInicio.DataSource = list.Tables("clientes")
                    dgvInicio.Columns("ID").Visible = False
                    dgvInicio.Visible = True
                    txtTarget.Text = "LISTADO CLIENTES"
                    dgvInicio.ClearSelection()
                Else
                    Dim daoc As New ClienteDAO
                    adpCliente = daoc.cargarClientes()
                    adpCliente.Fill(list.Tables("clientes"))
                    dgvInicio.DataSource = ""
                    dgvInicio.DataSource = list.Tables("clientes")
                    dgvInicio.Columns("ID").Visible = False
                    dgvInicio.Visible = True
                    dgvInicio.ClearSelection()
                    txtTarget.Text = "LISTADO CLIENTES"
                End If
            End If
            Me.ResumeLayout()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    '' ---------------------------------- LISTADO -------------------------------------------------------------
    'Private Sub listadoClientes(sender As Object, e As EventArgs) Handles listadoClientMI.Click
    '    Try
    '        target = "clientes"
    '        Dim daoc As New ClienteDAO
    '        adp = daoc.cargarClientes()
    '        adp.Fill(list.Tables("clientes"))
    '        dgvListado.DataSource = list.Tables("clientes")
    '        dgvListado.Columns("ID").Visible = False
    '        dgvListado.Visible = True
    '        panelListado.Visible = True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub



    'Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
    '    Try
    '        If target = "clientes" Then
    '            Dim cmdBuild As New MySqlCommandBuilder(adp)
    '            adp.Update(list, "clientes")
    '            MsgBox("Informacion Actualizada!")
    '            Me.SuspendLayout()
    '            dgvListado.DataSource = ""
    '            dgvListado.DataSource = list.Tables("clientes")
    '            dgvListado.Columns("ID").Visible = False
    '            dgvListado.Refresh()
    '            Me.ResumeLayout()
    '        ElseIf target = "reservas" Then

    '        ElseIf target = "empleados" Then

    '        ElseIf target = "servicios" Then

    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    '' ----------------------------- OPERACIONES PERSONAL ------------------------------------------------

    '' ----------------------- LISTADO --------------------------------------------

    Private Sub cargar_personal(sender As Object, e As EventArgs) Handles lblPersonal.Click
        Try
            If target <> "personal" Then
                Me.SuspendLayout()
                target = "personal"
                lblReservas.Visible = False
                RectangleShape1.Visible = False
                If list.Tables("personal").Rows.Count = 0 Then
                    Dim daop As New PersonalDAO
                    adpPersonal = daop.cargarPersonal()
                    adpPersonal.Fill(list.Tables("personal"))

                End If

                dgvInicio.DataSource = ""
                dgvInicio.DataSource = list.Tables("personal")
                dgvInicio.Columns("ID").Visible = False
                dgvInicio.Visible = True
                txtTarget.Text = "LISTADO PERSONAL"
                dgvInicio.ClearSelection()
                Me.ResumeLayout()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    '' ----------------------------- OPERACIONES SERVICIOS ------------------------------------------------

    '' ----------------------- LISTADO --------------------------------------------

    Private Sub cargar_servicios(sender As Object, e As EventArgs) Handles lblServicios.Click
        Try
            If target <> "servicios" Then
                Me.SuspendLayout()
                lblReservas.Visible = False
                RectangleShape1.Visible = False
                target = "servicios"
                If list.Tables("servicios").Rows.Count = 0 Then
                    Dim daos As New ServicioDAO
                    adpServicios = daos.cargarServicios()
                    adpServicios.Fill(list.Tables("servicios"))

                End If

                dgvInicio.DataSource = ""
                dgvInicio.DataSource = list.Tables("servicios")
                dgvInicio.Columns("ID").Visible = False
                dgvInicio.Visible = True
                txtTarget.Text = "LISTADO SERVICIOS"
                dgvInicio.ClearSelection()
                Me.ResumeLayout()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Me.Close()

    End Sub

    '' ------------------------------ AGENDA ----------------
    Private Sub abrirAgenda(sender As Object, e As EventArgs) Handles lblAgenda.Click
        Dim agenda As New Agenda
        agenda.ShowDialog()
        agenda.Dispose()
    End Sub



    '' ------------------------------ CONTROLES VISUALES ----------------
    'Private Sub lblSistemaMov(sender As Object, e As EventArgs) Handles lblSpa.MouseMove
    '    Me.SuspendLayout()
    '    'sender.BackColor = Color.FromArgb(116, 142, 47)
    '    sender.BackColor = Color.FromArgb(129, 161, 43)
    '    'sender.BackColor = Color.FromArgb(56, 142, 60)

    '    sender.Font = New Font("Segoe UI", 14,
    '                FontStyle.Bold)
    '    Me.ResumeLayout()
    'End Sub



    Private Sub lblSistemLeave(sender As Object, e As EventArgs)
        Me.SuspendLayout()
        'sender.BackColor = Color.FromArgb(116, 142, 47)
        sender.BackColor = Color.FromArgb(118, 148, 39)
        'sender.BackColor = Color.FromArgb(56, 142, 60)

        sender.Font = New Font("Segoe UI Semibold", 14,
                    FontStyle.Bold)
        Me.ResumeLayout()
    End Sub

    Private Sub lblHovers(sender As Object, e As EventArgs) Handles lblSalir.MouseMove, lblClientes.MouseMove, lblPersonal.MouseMove, lblServicios.MouseMove, lblAgenda.MouseMove, lblSalir.MouseMove, lblVentas.MouseMove
        Me.SuspendLayout()
        'sender.BackColor = Color.FromArgb(116, 142, 47)
        sender.BackColor = Color.FromArgb(24, 25, 27)
        'sender.BackColor = Color.FromArgb(56, 142, 60)

        sender.Font = New Font("Segoe UI", 12,
                    FontStyle.Bold)
        Me.ResumeLayout()
    End Sub

    Private Sub lblUnhover(sender As Object, e As EventArgs) Handles lblServicios.MouseLeave, lblSalir.MouseLeave, lblPersonal.MouseLeave, lblClientes.MouseLeave, lblAgenda.MouseLeave, lblVentas.MouseLeave
        Me.SuspendLayout()
        sender.BackColor = Color.Transparent
        sender.Font = New Font("Segoe UI Semibold", 12,
                    FontStyle.Bold)
        Me.ResumeLayout()
    End Sub



    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If target = "clientes" Then
                Dim dv As New DataView(list.Tables("clientes"))

                If IsNumeric(txtBuscar.Text) Then
                    Dim aux = txtBuscar.Text
                    dv.RowFilter = String.Format("`C.I` like '%{0}%'", aux)
                Else
                    dv.RowFilter = String.Format("Nombre like '%{0}%' or Apellido like '%{0}%' or RUC like '%{0}%' ", txtBuscar.Text)

                End If
                dgvInicio.DataSource = dv
            End If

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles lblActualizar.Click, rectActualizar.Click
        Try
            If target = "clientes" Then
                Dim dao As New ClienteDAO
                Dim cmdBuild As New MySqlCommandBuilder(adpCliente)
                adpCliente.Update(list, "clientes")
                MsgBox("Informacion Actualizada!")
                Me.SuspendLayout()
                dgvInicio.DataSource = ""
                dgvInicio.DataSource = list.Tables("clientes")
                dgvInicio.Columns("ID").Visible = False
                dgvInicio.Refresh()
                dgvInicio.ClearSelection()
                Me.ResumeLayout()

            ElseIf target = "reservas" Then

            ElseIf target = "empleados" Then

            ElseIf target = "servicios" Then

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    ''--------------------------------------------------- OPERACIONES COMUNES ---------------------------------------


    Private Sub lblNuevo_Click(sender As Object, e As EventArgs) Handles lblNuevo.Click, rectAgregar.Click

        If target = "clientes" Then
            Dim nuevoCliente As New AgregarCliente
            Dim result = nuevoCliente.ShowDialog()

            nuevoCliente.Dispose()
            If (result = DialogResult.OK) Then
                actualizarData()
            End If

        ElseIf target = "personal" Then
            Dim nuevoPersonal As New AgregarPersonal
            Dim result = nuevoPersonal.ShowDialog()
            nuevoPersonal.Dispose()
            If (result = DialogResult.OK) Then
                actualizarData()
            End If
        ElseIf target = "servicios" Then
            Dim nuevoServicio As New AgregarServicio
            Dim result = nuevoServicio.ShowDialog()
            nuevoServicio.Dispose()
            If (result = DialogResult.OK) Then
                actualizarData()
            End If
        End If
    End Sub


    '' OPERACIONES COMUNES CONTROLADAS POR MISMOS CONTROLADOR
    Private Sub rectModificar_Click(sender As Object, e As EventArgs) Handles rectModificar.Click, lblModificar.Click
        Try
            If target = "clientes" Then

                If dgvInicio.SelectedRows.Count = 1 Then
                    Dim row = dgvInicio.CurrentRow.Index
                    Dim codigo = dgvInicio.Item(0, row).Value

                    Dim modificar As New ModificarCliente(codigo)
                    modificar.ShowDialog()
                    modificar.Dispose()
                    actualizarData()
                ElseIf dgvInicio.SelectedRows.Count > 1 Then
                    MsgBox("¡Seleccione solamente un cliente para modificar!", MsgBoxStyle.Information, "Notificación")
                Else
                    MsgBox("¡Seleccione un cliente para modificar!", MsgBoxStyle.Information, "Notificación")
                End If
            ElseIf target = "personal" Then
                If dgvInicio.SelectedRows.Count = 1 Then
                    Dim row = dgvInicio.CurrentRow.Index
                    Dim codigo = dgvInicio.Item(0, row).Value

                    Dim modificar As New ModificarPersonal(codigo)
                    modificar.ShowDialog()
                    modificar.Dispose()
                    actualizarData()
                ElseIf dgvInicio.SelectedRows.Count > 1 Then
                    MsgBox("¡Seleccione solamente un empleado para modificar!", MsgBoxStyle.Information, "Notificación")
                Else
                    MsgBox("¡Seleccione un empleado para modificar!", MsgBoxStyle.Information, "Notificación")
                End If
            ElseIf target = "servicios" Then
                If dgvInicio.SelectedRows.Count = 1 Then
                    Dim row = dgvInicio.CurrentRow.Index
                    Dim codigo = dgvInicio.Item(0, row).Value

                    Dim modificar As New ModificarServicio(codigo)
                    modificar.ShowDialog()
                    modificar.Dispose()
                    actualizarData()
                ElseIf dgvInicio.SelectedRows.Count > 1 Then
                    MsgBox("¡Seleccione solamente un servicio para modificar!", MsgBoxStyle.Information, "Notificación")
                Else
                    MsgBox("¡Seleccione un servicio para modificar!", MsgBoxStyle.Information, "Notificación")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub actualizarData()
        If target = "clientes" Then
            Dim daoc As New ClienteDAO
            list.Tables("clientes").Clear()

            adpCliente = daoc.cargarClientes()
            adpCliente.Fill(list.Tables("clientes"))
            dgvInicio.DataSource = ""
            dgvInicio.DataSource = list.Tables("clientes")
            dgvInicio.Columns("ID").Visible = False
            dgvInicio.ClearSelection()
        ElseIf target = "personal" Then

            Dim daop As New PersonalDAO
            adpPersonal = daop.cargarPersonal()
            list.Tables("personal").Clear()
            adpPersonal.Fill(list.Tables("personal"))
            dgvInicio.DataSource = ""
            dgvInicio.DataSource = list.Tables("personal")
            dgvInicio.Columns("ID").Visible = False
            dgvInicio.ClearSelection()

        ElseIf target = "servicios" Then
            Dim daos As New ServicioDAO
            adpServicios = daos.cargarServicios()
            list.Tables("servicios").Clear()
            adpServicios.Fill(list.Tables("servicios"))

            dgvInicio.DataSource = ""
            dgvInicio.DataSource = list.Tables("servicios")
            dgvInicio.Columns("ID").Visible = False


            dgvInicio.ClearSelection()
        End If

    End Sub

    '' ----------------------------------------- HOVERS Y EFECTOS VISUALES --------------------------------
    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        txtBuscar.Text = ""
        txtBuscar.ForeColor = Color.Black
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtBuscar.Leave
        txtBuscar.Text = "Buscar"
        txtBuscar.ForeColor = Color.DarkGray

    End Sub


    Private Sub agregar_MouseMove(sender As Object, e As MouseEventArgs) Handles rectAgregar.MouseMove, lblNuevo.MouseMove
        'CType(sender, ).BackColor = Color.FromArgb(189, 48, 72)
        rectAgregar.BackColor = Color.FromArgb(189, 48, 72)
        lblNuevo.BackColor = Color.FromArgb(189, 48, 72)
        lblNuevo.ForeColor = Color.White
    End Sub

    Private Sub agregar_MouseLeave(sender As Object, e As EventArgs) Handles rectAgregar.MouseLeave
        rectAgregar.BackColor = Color.FromArgb(98, 149, 40)
        lblNuevo.BackColor = Color.FromArgb(98, 149, 40)
        lblNuevo.ForeColor = Color.FromArgb(32, 34, 36)
    End Sub

    Private Sub rectModificar_MouseMove(sender As Object, e As MouseEventArgs) Handles rectModificar.MouseMove, lblModificar.MouseMove
        rectModificar.BackColor = Color.FromArgb(189, 48, 72)
        lblModificar.BackColor = Color.FromArgb(189, 48, 72)
        lblModificar.ForeColor = Color.White
    End Sub

    Private Sub rectModificar_MouseLeave(sender As Object, e As EventArgs) Handles rectModificar.MouseLeave
        rectModificar.BackColor = Color.FromArgb(98, 149, 40)
        lblModificar.BackColor = Color.FromArgb(98, 149, 40)
        lblModificar.ForeColor = Color.FromArgb(32, 34, 36)
    End Sub




    Private Sub rectActualizar_MouseMove(sender As Object, e As MouseEventArgs) Handles rectActualizar.MouseMove, lblActualizar.MouseMove
        rectActualizar.BackColor = Color.FromArgb(189, 48, 72)
        lblActualizar.BackColor = Color.FromArgb(189, 48, 72)
        lblActualizar.ForeColor = Color.White
    End Sub

    Private Sub rectActualizar_MouseLeave(sender As Object, e As EventArgs) Handles rectActualizar.MouseLeave, lblActualizar.MouseLeave
        rectActualizar.BackColor = Color.FromArgb(98, 149, 40)
        lblActualizar.BackColor = Color.FromArgb(98, 149, 40)
        lblActualizar.ForeColor = Color.FromArgb(32, 34, 36)
    End Sub

    Private Sub reservas_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape1.MouseMove, lblReservas.MouseMove
        RectangleShape1.BackColor = Color.FromArgb(189, 48, 72)
        lblReservas.BackColor = Color.FromArgb(189, 48, 72)
        lblReservas.ForeColor = Color.White
    End Sub

    Private Sub reservas_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave, lblReservas.MouseLeave
        RectangleShape1.BackColor = Color.FromArgb(98, 149, 40)
        lblReservas.BackColor = Color.FromArgb(98, 149, 40)
        lblReservas.ForeColor = Color.FromArgb(32, 34, 36)
    End Sub

    Private Sub dgv_style()
        For i As Integer = 0 To dgvInicio.RowCount - 1
            If i Mod 2 = 0 Then
                dgvInicio.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                dgvInicio.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(219, 219, 219)
            End If
        Next
    End Sub

    Private Sub dgvInicio_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvInicio.DataSourceChanged
        dgv_style()
        dgvInicio.AutoResizeRows()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim acercaDe As New AcercaDe
        acercaDe.ShowDialog()
        acercaDe.Dispose()
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        Label1.ForeColor = Color.FromArgb(98, 149, 40)
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblVentas.Click
        lblReservas.Visible = False
        RectangleShape1.Visible = False
    End Sub
End Class
