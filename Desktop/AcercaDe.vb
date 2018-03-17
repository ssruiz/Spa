Public Class AcercaDe
    Private Sub LineShape1_Click(sender As Object, e As EventArgs) Handles LineShape1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Tag.ToString)
    End Sub

    Private Sub AcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = (Me.ClientSize.Width / 2) - (Label1.Width / 2)
        Label2.Left = (Me.ClientSize.Width / 2) - (Label2.Width / 2)
        LinkLabel1.Left = (Me.ClientSize.Width / 2) - (LinkLabel1.Width / 2)
        Label4.Left = (Me.ClientSize.Width / 2) - (Label4.Width / 2)
        RectangleShape2.Left = (Me.ClientSize.Width / 2) - (RectangleShape2.Width / 2)
        lblSalir.Left = (Me.ClientSize.Width / 2) - (lblSalir.Width / 2)
    End Sub

    Private Sub RectangleShape1_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape2.MouseMove, lblSalir.MouseMove
        Me.SuspendLayout()
        lblSalir.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape2.MouseLeave, lblSalir.MouseLeave
        Me.SuspendLayout()
        lblSalir.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click, lblSalir.Click
        Me.Close()
    End Sub
End Class