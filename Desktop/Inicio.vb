Imports System.Windows.Forms
Imports Backend
Imports Desktop.My.Resources
Imports MySql.Data.MySqlClient

Public Class Inicio
    '' ---------------------------------------- VARIABLES COMUNES USADAS EN EL FORM ------------------------------------------
    Dim target As String = ""
    Dim list As New DataSet
    Dim adp As New MySqlDataAdapter

    '' --------------------------------------------------- OPERACIONES DE CARGA ----------------------------------------------
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SuspendLayout()
        crearBackgrounds()
        Me.ResumeLayout()
        list.Tables.Add("clientes")
        list.Tables.Add("reservas")
        list.Tables.Add("servicios")
        list.Tables.Add("empleados")
        MenuStrip.Visible = False
    End Sub

    Private Sub crearBackGrounds()
        'Dim bm = New Bitmap(inicio_fondo_spa, New Size(pnlImagenInicio.Width, pnlImagenInicio.Height))
        'pnlImagenInicio.BackgroundImage = bm
        'pnlImagenInicio.BackgroundImageLayout = ImageLayout.None

        'pnlBotones.BackColor = Color.FromArgb(80, Color.Black)
        'Button1.Image = New Bitmap(if_search_80px_510919, New Size(25, 25))

    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub


    '' -------------------------------------------   OPERACIONES CLIENTES --------------------------------------------------------

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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub FileMenu_MouseHover(sender As Object, e As EventArgs) Handles FileMenu.MouseHover
        FileMenu.ForeColor = Color.Black

    End Sub

    Private Sub FileMenu_MouseLeave(sender As Object, e As EventArgs) Handles FileMenu.MouseLeave
        FileMenu.ForeColor = Color.AntiqueWhite
    End Sub





    Private Sub FileMenu_DropDownOpened(sender As Object, e As EventArgs) Handles FileMenu.DropDownOpened
        FileMenu.ForeColor = Color.Black
    End Sub

    Private Sub lblClientes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblHovers(sender As Object, e As EventArgs) Handles lblClientes.MouseMove, lblPersonal.MouseMove, lblServicios.MouseMove, lblAgenda.MouseMove, lblSalir.MouseMove
        Me.SuspendLayout()
        'sender.BackColor = Color.FromArgb(116, 142, 47)
        sender.BackColor = Color.FromArgb(50, 50, 50)
        'sender.BackColor = Color.FromArgb(56, 142, 60)

        sender.Font = New Font("Segoe UI", 12,
                    FontStyle.Bold)
        Me.ResumeLayout()
    End Sub

    Private Sub lblUnhover(sender As Object, e As EventArgs) Handles lblClientes.MouseLeave, lblPersonal.MouseLeave, lblServicios.MouseLeave, lblAgenda.MouseLeave, lblSalir.MouseLeave
        Me.SuspendLayout()
        sender.BackColor = Color.Transparent
        sender.Font = New Font("Segoe UI Semibold", 12,
                    FontStyle.Bold)
        Me.ResumeLayout()
    End Sub

    Private Sub lblHovers(sender As Object, e As MouseEventArgs) Handles lblServicios.MouseMove, lblPersonal.MouseMove, lblClientes.MouseMove, lblAgenda.MouseMove, lblSalir.MouseMove

    End Sub

    Private Sub lblclientes_Click_1(sender As Object, e As EventArgs)
        Try
            If target <> "clientes" Then
                target = "clientes"
                Dim daoc As New ClienteDAO
                adp = daoc.cargarClientes()
                adp.Fill(list.Tables("clientes"))
                'dgvInicio.DataSource = ""
                'dgvInicio.DataSource = list.Tables("clientes")
                'dgvInicio.Columns("ID").Visible = False
                'dgvInicio.Visible = True
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblSesion_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Me.Close()

    End Sub
End Class
