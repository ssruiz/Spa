Imports Backend
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtUsuario.Focus()

        'Dim bm = New Bitmap(My.Resources.spa_fondo_log, New Size(Me.Width, Me.Height))
        'Me.BackgroundImage = bm
        txtUsuario.TabStop = False
        txtPassw.TabStop = False
        Me.PerformLayout()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs)
        conexion()
    End Sub
    Private Sub conexion()
        Try
            Dim conectar As New Acceso
            conectar.login(Me.txtUsuario.Text, Me.txtPassw.Text)
            Me.Visible = False

            Dim mdi As New Inicio
            lblAdvertencia.Text = ""
            Me.txtUsuario.Text = "usuario"
            Me.txtPassw.Text = "contraseña"
            txtPassw.UseSystemPasswordChar = False

            mdi.Show()

        Catch ex As Exception

            Me.lblAdvertencia.Visible = True
            Me.lblAdvertencia.Text = ex.Message

            Me.txtPassw.Text = "contraseña"
            Me.txtUsuario.Focus()
            txtPassw.UseSystemPasswordChar = False
        End Try
    End Sub

    Private Sub txtPassw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassw.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            conexion()


        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        txtUsuario.Focus()
    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click, txtUsuario.Enter
        If txtUsuario.Text = "usuario" Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.Black
            txtUsuario.TabStop = True
            txtPassw.TabStop = True
        End If
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "usuario"
            txtUsuario.ForeColor = Color.DarkGray
        Else
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtPassw_Enter(sender As Object, e As EventArgs) Handles txtPassw.GotFocus, txtPassw.Click

        If txtPassw.Text = "contraseña" Then
            txtPassw.UseSystemPasswordChar = True
            txtPassw.Text = ""
            sender.Font = New Font("Segoe UI Semibold", 12,
                    FontStyle.Bold)
            txtPassw.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassw_Leave(sender As Object, e As EventArgs) Handles txtPassw.Leave
        If txtPassw.Text = "" Then
            txtPassw.UseSystemPasswordChar = False
            txtPassw.Text = "contraseña"
            txtPassw.ForeColor = Color.DarkGray
        Else
            txtPassw.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs)
        conexion()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        conexion()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RectangleShape3_MouseMove(sender As Object, e As MouseEventArgs) Handles lblLogin.MouseMove

        lblLogin.BackColor = Color.FromArgb(189, 48, 72)
        lblLogin.ForeColor = Color.White
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles lblLogin.MouseLeave

        lblLogin.BackColor = Color.WhiteSmoke
        lblLogin.ForeColor = Color.FromArgb(32, 34, 36)

    End Sub


End Class