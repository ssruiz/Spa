Public Class Reporte
    Public tipo As String = ""
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
    End Sub

    Private Sub lblGUARDAR_Click(sender As Object, e As EventArgs) Handles lblHoy.Click
        Try
            Dim objreporte As New ReporteCaja
            objreporte.SetParameterValue("inicio", Date.Today)
            objreporte.SetParameterValue("fin", Date.Today)
            crystalReportv.ReportSource = objreporte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblHovers(sender As Object, e As EventArgs) Handles lblHoy.MouseMove, lblMensual.MouseMove, lblSemana.MouseMove, lblFechaEsp.MouseMove
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblUnhover(sender As Object, e As EventArgs) Handles lblHoy.MouseLeave, lblSemana.MouseLeave, lblMensual.MouseLeave, lblFechaEsp.MouseLeave, lblFechaEsp.MouseLeave
        Dim lbl = CType(sender, Label)
        lbl.ForeColor = Color.FromArgb(22, 23, 24)

    End Sub

    Private Sub lblSemana_Click(sender As Object, e As EventArgs) Handles lblSemana.Click
        Try
            Dim today = Date.Today
            Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Monday
            Dim monday As Date = today.AddDays(-dayDiff)
            dayDiff = today.DayOfWeek - DayOfWeek.Saturday
            Dim saturday As Date = today.AddDays(-dayDiff)
            Dim objreporte As New ReporteCaja
            objreporte.SetParameterValue("inicio", monday)
            objreporte.SetParameterValue("fin", saturday)
            crystalReportv.ReportSource = objreporte
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblMensual_Click(sender As Object, e As EventArgs) Handles lblMensual.Click
        Try
            Dim firstDay = New DateTime(Today.Year, Today.Month, 1)
            Dim lastDay = firstDay.AddMonths(1).AddDays(-1)
            Dim objreporte As New ReporteCaja
            objreporte.SetParameterValue("inicio", firstDay)
            objreporte.SetParameterValue("fin", lastDay)
            crystalReportv.ReportSource = objreporte
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblHovers(sender As Object, e As MouseEventArgs) Handles lblSemana.MouseMove, lblMensual.MouseMove, lblHoy.MouseMove, lblFechaEsp.MouseMove

    End Sub

    Private Sub lblFechaEsp_Click(sender As Object, e As EventArgs) Handles lblFechaEsp.Click
        Try
            Dim objreporte As New ReporteCaja
            objreporte.SetParameterValue("inicio", dpFechaEsp.Value)
            objreporte.SetParameterValue("fin", dpFechaEsp.Value)
            crystalReportv.ReportSource = objreporte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class