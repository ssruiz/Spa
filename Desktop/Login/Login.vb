Imports Backend
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        conexion()
    End Sub
    Private Sub conexion()
        Try
            Dim conectar As New Acceso
            conectar.login(Me.txtUsuario.Text, Me.txtPassw.Text)
            Me.Visible = False

            Dim mdi As New Inicio
            lblAdvertencia.Text = ""
            txtUsuario.Text = ""
            txtPassw.Text = ""
            txtUsuario.Focus()

            mdi.Show()

        Catch ex As Exception

            Me.lblAdvertencia.Visible = True
            Me.lblAdvertencia.Text = ex.Message
            Me.txtUsuario.Text = ""
            Me.txtPassw.Text = ""
            Me.txtUsuario.Focus()
        End Try
    End Sub

    Private Sub txtPassw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassw.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            conexion()


        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()

    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        txtUsuario.Focus()
    End Sub
End Class