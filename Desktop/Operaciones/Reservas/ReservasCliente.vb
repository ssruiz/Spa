Public Class ReservasCliente
    Private Sub ReservasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub dgvInicio_DataSourceChanged(sender As Object, e As EventArgs)
        dgv_style()
        dgvInicio.AutoResizeRows()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class