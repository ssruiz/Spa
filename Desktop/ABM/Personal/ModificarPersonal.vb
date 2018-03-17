Imports Backend

Public Class ModificarPersonal
    Dim id_empleado
    Dim empleado As New Personal

    Public Sub New(ByVal id As String)
        InitializeComponent()
        id_empleado = id
    End Sub
    Private Sub ModificarPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim daoPersonal As New PersonalDAO
            empleado = daoPersonal.cargarEmpleado(id_empleado)
            txtNombre.Text = empleado.nombre
            txtApellido.Text = empleado.apellido
            txtTelefono.Text = empleado.tel
            txtCelular.Text = empleado.cel
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub resetCampos()
        txtApellido.Text = empleado.apellido
        txtNombre.Text = empleado.nombre
        txtTelefono.Text = empleado.tel
        txtCelular.Text = empleado.cel
    End Sub
    Private Sub soloNumerosTxt(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress, txtCelular.KeyPress
        soloNumeros(e)
    End Sub
    Private Function controlarCampos() As Boolean

        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar un nombre para el cliente", MsgBoxStyle.Critical, "Atención")
            txtNombre.Focus()
            Return False
        ElseIf txtApellido.Text = "" Then
            MsgBox("Debe ingresar un apellido para el cliente", MsgBoxStyle.Critical, "Atención")
            txtApellido.Focus()
            Return False
        ElseIf txtTelefono.Text = "" Then
            MsgBox("Debe ingresar un teléfono válido", MsgBoxStyle.Critical, "Atención")
            txtTelefono.Focus()
            Return False
        ElseIf txtCelular.Text = "" Then
            MsgBox("Debe ingresar un celular válido", MsgBoxStyle.Critical, "Atención")
            txtCelular.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click, lblCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblReset.Click
        resetCampos()
    End Sub

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

    Private Sub lblGUARDAR_Click(sender As Object, e As EventArgs) Handles lblGUARDAR.Click

    End Sub
End Class