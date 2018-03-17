Imports Backend

Public Class SeleccionarCliente
    Dim buscar As String
    Public cliente_sel As New Cliente
    Public Sub New(ByVal cli As String)
        InitializeComponent()
        buscar = cli
    End Sub
    Private Sub SeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim daoCli As New ClienteDAO
            Dim list = daoCli.buscarClientes(buscar)
            dgvClientes.DataSource = list.Tables("tabla")
            dgvClientes.Columns("ID").Visible = False
            dgvClientes.Columns("RUC").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblAgregar.Click
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim row = dgvClientes.CurrentRow.Index
            Dim id = dgvClientes.Item(0, row).Value
            Dim nombre = dgvClientes.Item(1, row).Value
            Dim apellido = dgvClientes.Item(2, row).Value
            Dim ruc = dgvClientes.Item(4, row).Value
            Dim ci = dgvClientes.Item(3, row).Value
            cliente_sel.id = id
            cliente_sel.ci = ci
            cliente_sel.nombre = nombre
            cliente_sel.apellido = apellido
            cliente_sel.ruc = ruc
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("Seleccione un cliente", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub
    '' ------------------------------------ HOVERS ---------------------------------

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
    Private Sub dgv_style()
        For i As Integer = 0 To dgvClientes.RowCount - 1
            If i Mod 2 = 0 Then
                dgvClientes.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                dgvClientes.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(219, 219, 219)
            End If
        Next
    End Sub

    Private Sub dgvInicio_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvClientes.DataSourceChanged
        dgv_style()
        dgvClientes.AutoResizeRows()
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class