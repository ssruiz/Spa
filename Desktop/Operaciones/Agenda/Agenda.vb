Imports Backend

Public Class Agenda
    Dim mes_actual As Integer
    Dim year_actual As Integer
    Dim dia_actual As Integer
    Dim fecha_actual As Date
    Dim citasDia As New Hashtable
    Dim sesionesDia As New Hashtable
    Dim encargado
    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contenedorPrincipal.SuspendLayout()
        cargarImagenes()
        cargarCalendario(Date.Today)

        'cargarEmpleados()

        lblDiaSeleccionado.Text = "HOY (" + Date.Today.ToString("dddd") + " " + Date.Today + ")"
        contenedorPrincipal.ResumeLayout()
        'encargado = cbEmpleados.SelectedValue
    End Sub

    'Private Sub cargarEmpleados()
    '    Try
    '        cbEmpleados.SuspendLayout()
    '        Dim daoEmpleados As New PersonalDAO
    '        Dim list = daoEmpleados.getEmp()
    '        cbEmpleados.DataSource = list.Tables("tabla")
    '        cbEmpleados.DisplayMember = "Nombre"
    '        cbEmpleados.ValueMember = "ID"
    '        cbEmpleados.ResumeLayout()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Private Sub cargarImagenes()
        Dim bm = New Bitmap(My.Resources.flechaIzquierda, New Size(anterior.Width, anterior.Height))
        anterior.Image = bm
        bm = New Bitmap(My.Resources.flechaDerecha, New Size(sgte.Width, sgte.Height))
        sgte.Image = bm
    End Sub

    '' Metodo que crea graficamente el calendario
    Private Sub cargarCalendario(ByVal dia As Date)

        calendario.SuspendLayout()
        Dim aux = dia.ToString("MMMM").ToUpper + " " + dia.ToString("yyyy").ToUpper
        Label9.Text = aux
        mes_actual = dia.Month
        year_actual = dia.Year
        dia_actual = dia.Day
        Dim firstDay = New DateTime(dia.Year, dia.Month, 1)

        Dim lastDay = firstDay.AddMonths(1).AddDays(-1)
        Dim inicio = firstDay.DayOfWeek
        Dim total = DateTime.DaysInMonth(dia.Year, dia.Month)

        Dim cursorColumnas
        If inicio = 0 Then
            cursorColumnas = 6
        Else
            cursorColumnas = inicio - 1
        End If

        Dim cursor = 1

        Dim cursorFilas = 1
        Dim lblinicial As New Label

        For i As Integer = 1 To total
            Dim lbl As New Label()
            lbl.Text = cursor.ToString
            lbl.Anchor = RightToLeft
            lbl.Dock = DockStyle.Fill
            lbl.Name = "dia" + cursor.ToString
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Margin = New Padding(0, 0, 0, 0)
            lbl.Font = New Font(FontFamily.GenericSansSerif, 12.0F)
            If cursorColumnas = 5 Or cursorColumnas = 6 Then
                lbl.BackColor = Color.Gray
            Else
                lbl.BackColor = Color.White

            End If

            If cursor = dia.Day Then
                lbl.BackColor = Color.FromArgb(98, 149, 40)
            End If
            AddHandler lbl.Click, AddressOf lblClick
            calendario.Controls.Add(lbl, cursorColumnas, cursorFilas)
            cursorColumnas += 1
            If cursorColumnas = 7 Then
                cursorColumnas = 0
                cursorFilas += 1
            End If
            cursor += 1
        Next
        calendario.ResumeLayout()
        fecha_actual = dia
        cargarCitas()
        'MsgBox("PRIMER DIA DEL MES CAYÓ UN " + firstDay.ToString("dddd"))
        'MsgBox("ULTIMO DIA DEL MES CAERÁ UN " + lastDay.ToString("dddd"))
    End Sub

    '' Método que carga las citas de un día especificado/seleccionado
    Public Sub cargarCitas()
        Try
            Dim daoR As New ReservaDAO
            'Dim dia_aux = dia_actual.ToString + "/" + mes_actual.ToString + "/" + year_actual.ToString
            citasDia = New Hashtable

            citasDia = daoR.cargarCitasDelDiaAgenda(fecha_actual)
            tblAgenda.SuspendLayout()
            For Each r As DictionaryEntry In citasDia
                Dim clientes As String = r.Value
                Dim nombre = "cita" + r.Key.ToString

                'Me.Controls("tblAgenda").Controls(nombre).Text = "aa"
                Dim label = Me.Controls().Find(nombre, True)
                Dim l = CType(label(0), Label)

                l.Text = clientes
                l.BackColor = Color.FromArgb(249, 232, 93)


            Next
            sesionesDia = daoR.cargarSesiones(fecha_actual)
            For Each r As DictionaryEntry In sesionesDia
                Dim clientes As String = r.Value
                Dim nombre = "cita" + r.Key.ToString

                'Me.Controls("tblAgenda").Controls(nombre).Text = "aa"
                Dim label = Me.Controls().Find(nombre, True)
                Dim l = CType(label(0), Label)

                l.Text = l.Text + " - " + clientes
                l.BackColor = Color.FromArgb(249, 232, 93)


            Next
            tblAgenda.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '' Metodo que controla los dias del calendario
    Private Sub lblClick(sender As Object, e As EventArgs)
        Dim label = CType(sender, Label)
        label.BackColor = Color.FromArgb(138, 174, 46)
        Dim s = label.Name

        s = s.Remove(0, 3)
        Dim aux = "dia" + dia_actual.ToString


        Dim dia_aux = dia_actual.ToString + "/" + mes_actual.ToString + "/" + year_actual.ToString
        Dim dia_sgte = CInt(s).ToString + "/" + mes_actual.ToString + "/" + year_actual.ToString
        If dia_aux = dia_sgte Then
            Exit Sub
        End If
        For Each lbl As Label In Me.calendario.Controls.OfType(Of Label)()

            If lbl.Name = aux Then
                If DateTime.Parse(dia_aux).DayOfWeek = DayOfWeek.Saturday Or DateTime.Parse(dia_aux).DayOfWeek = DayOfWeek.Sunday Then
                    lbl.BackColor = Color.Gray
                    Exit For
                Else
                    lbl.BackColor = Color.White
                    Exit For
                End If
            End If
        Next

        dia_actual = CInt(s)
        dia_aux = dia_actual.ToString + "/" + mes_actual.ToString + "/" + year_actual.ToString
        fecha_actual = dia_aux
        vaciarAgenda()
        cargarCitas()
        lblDiaSeleccionado.Text = DateTime.Parse(dia_aux).ToString("dddd").ToUpper + " " + DateTime.Parse(dia_aux)
    End Sub

    '' Va al mes anterior y rebuildea el calendario
    Private Sub anterior_Click(sender As Object, e As EventArgs) Handles anterior.Click
        Dim con = 0

        vaciarAgenda()
        vaciarCalendario()

        Dim nuevo_year As Integer
        Dim nuevo_mes As Integer
        If mes_actual = 1 Then
            nuevo_mes = 12
            nuevo_year = year_actual - 1
        Else
            nuevo_mes = mes_actual - 1
            nuevo_year = year_actual
        End If

        Dim dia_aux = "1" + "/" + nuevo_mes.ToString + "/" + nuevo_year.ToString

        cargarCalendario(DateTime.Parse(dia_aux))

        'For Each lbl As Label In calendario.Controls.OfType(Of Label)()
        '    System.Console.WriteLine(lbl.Name)
        '    If lbl.Name.Contains("dia") Then
        '        Me.calendario.Controls.Remove(lbl)
        '    End If
        lblDiaSeleccionado.Text = DateTime.Parse(dia_aux).ToString("dddd").ToUpper + " " + DateTime.Parse(dia_aux)
        'Next


    End Sub

    Private Sub vaciarAgenda()

        'For Each r As DictionaryEntry In citasDia
        '    tblAgenda.SuspendLayout()
        '    Dim reserva As Reserva = r.Value
        '    Dim nombre = "cita" + r.Key.ToString

        '    'Me.Controls("tblAgenda").Controls(nombre).Text = "aa"
        '    Dim label = Me.Controls().Find(nombre, True)
        '    Dim l = CType(label(0), Label)

        '    l.Text = ""
        '    l.BackColor = Color.Transparent
        '    tblAgenda.ResumeLayout()

        'Next
        Dim aux = 0
        For Each r As DictionaryEntry In citasDia
            Dim clientes As String = r.Value
            Dim nombre = "cita" + r.Key.ToString

            'Me.Controls("tblAgenda").Controls(nombre).Text = "aa"
            Dim label = Me.Controls().Find(nombre, True)
            Dim l = CType(label(0), Label)


            l.Text = ""
            l.BackColor = Color.Transparent
            aux += 1

        Next


        For Each r As DictionaryEntry In sesionesDia
            Dim clientes As String = r.Value
            Dim nombre = "cita" + r.Key.ToString

            'Me.Controls("tblAgenda").Controls(nombre).Text = "aa"
            Dim label = Me.Controls().Find(nombre, True)
            Dim l = CType(label(0), Label)


            l.Text = ""
            l.BackColor = Color.Transparent


        Next


    End Sub
    Private Sub vaciarCalendario()
        calendario.SuspendLayout()
        Dim firstDay = New DateTime(year_actual, mes_actual, 1)
        Dim inicio = firstDay.DayOfWeek
        Dim total = DateTime.DaysInMonth(year_actual, mes_actual)

        Dim cursor = 1
        Dim cursorColumnas
        If inicio = 0 Then
            cursorColumnas = 6
        Else
            cursorColumnas = inicio - 1
        End If

        Dim cursorFilas = 1
        For i As Integer = 1 To total
            Dim lbl = calendario.GetControlFromPosition(cursorColumnas, cursorFilas)
            lbl.Dispose()
            cursorColumnas += 1
            If cursorColumnas = 7 Then
                cursorColumnas = 0
                cursorFilas += 1
            End If
        Next
        'calendario.PerformLayout()
        calendario.ResumeLayout()
    End Sub

    Private Sub sgte_Click(sender As Object, e As EventArgs) Handles sgte.Click
        vaciarAgenda()
        vaciarCalendario()

        Dim nuevo_year As Integer
        Dim nuevo_mes As Integer
        If mes_actual = 12 Then
            nuevo_mes = 1
            nuevo_year = year_actual + 1
        Else
            nuevo_mes = mes_actual + 1
            nuevo_year = year_actual
        End If

        Dim dia_aux = "1" + "/" + nuevo_mes.ToString + "/" + nuevo_year.ToString

        cargarCalendario(DateTime.Parse(dia_aux))

        'For Each lbl As Label In calendario.Controls.OfType(Of Label)()
        '    System.Console.WriteLine(lbl.Name)
        '    If lbl.Name.Contains("dia") Then
        '        Me.calendario.Controls.Remove(lbl)
        '    End If
        lblDiaSeleccionado.Text = DateTime.Parse(dia_aux).ToString("dddd").ToUpper + " " + DateTime.Parse(dia_aux)
        'Next
    End Sub



    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click, lblHoy.Click
        Dim dia_aux = dia_actual.ToString + "/" + mes_actual.ToString + "/" + year_actual.ToString
        If dia_aux = Date.Today Then
            Exit Sub

        End If
        lblDiaSeleccionado.Text = "HOY (" + Date.Today.ToString("dddd") + " " + Date.Today + ")"
        vaciarCalendario()
        vaciarAgenda()
        cargarCalendario(Date.Today)
    End Sub

    Private Sub cita_click(sender As Object, e As EventArgs) Handles cita0.Click, cita4.Click, cita3.Click, cita2.Click, cita13.Click, cita12.Click, cita11.Click, cita10.Click, cita9.Click, cita8.Click, cita7.Click, cita6.Click, cita5.Click, cita1.Click, cita14.Click


        Dim label = CType(sender, Label)

        Dim tagHora = label.Name
        tagHora = tagHora.Remove(0, 4)

        Dim reservas As New ReservasDelDia
        reservas.tagHora = tagHora
        Dim dia_aux = dia_actual.ToString + "/" + mes_actual.ToString + "/" + year_actual.ToString
        reservas.fecha = dia_aux
        'reservas.trabajador.nombre = cbEmpleados.SelectedItem.item("Nombre")
        'reservas.trabajador.id = cbEmpleados.SelectedItem.item("ID")
        Dim result = reservas.ShowDialog()
        'If result = DialogResult.OK Then
        '    vaciarAgenda()
        '    vaciarCalendario()
        '    cargarCalendario(dia_aux)

        'End If
        reservas.Dispose()

        vaciarAgenda()
        vaciarCalendario()
        cargarCalendario(dia_aux)



    End Sub

    'Private Sub cbEmpleados_SelectedValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        encargado = cbEmpleados.SelectedValue
    '        vaciarAgenda()
    '        cargarCitas()
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub RectangleShape1_MouseMove(sender As Object, e As MouseEventArgs) Handles RectangleShape1.MouseMove, lblHoy.MouseMove
        Me.SuspendLayout()
        lblHoy.ForeColor = Color.WhiteSmoke

        Me.ResumeLayout()
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave, lblHoy.MouseLeave
        Me.SuspendLayout()
        lblHoy.ForeColor = Color.FromArgb(22, 23, 24)

        Me.ResumeLayout()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class