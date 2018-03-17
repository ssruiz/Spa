Imports MySql.Data.MySqlClient

Public Class ReservaDAO
    Public Sub guardarReserva(ByVal reserva As Reserva, ByVal personal As Personal, ByVal servicios As DataTable)
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = "INSERT INTO `reserva` (`fecha_reserva`, `id_cliente`, `hora_inicio`,hora_fin, `comentario_reserva`, `tag_horario`,`id_encargado`) VALUES ( @fecha, @cliente, @hora,@horafin, @comentario, @tag,@encargado); SELECT LAST_INSERT_ID();"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", reserva.fecha)
            cmd.Parameters.AddWithValue("@cliente", reserva.cliente)
            cmd.Parameters.AddWithValue("@hora", reserva.horaInicio)
            cmd.Parameters.AddWithValue("@horafin", reserva.horaFin)
            cmd.Parameters.AddWithValue("@comentario", reserva.comentario)
            cmd.Parameters.AddWithValue("@tag", reserva.tag)
            cmd.Parameters.AddWithValue("@encargado", personal.id)
            Dim reservaCod = CInt(cmd.ExecuteScalar)
            Dim queryDetalle = "INSERT INTO `reserva_servicios` (`id_reserva`, `id_servicio`, `id_empleado`) VALUES (@reserva, @servicio, @empleado);"
            Dim cmd2 As New MySqlCommand(queryDetalle, con)
            For Each r As DataRow In servicios.Rows
                Dim idServ = r("ID")
                cmd2.Parameters.AddWithValue("@reserva", reservaCod)
                cmd2.Parameters.AddWithValue("@servicio", idServ)
                cmd2.Parameters.AddWithValue("@empleado", personal.id)
                cmd2.ExecuteNonQuery()
                cmd2.Parameters.Clear()
            Next
            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Function cargarCitasDelDia(ByVal fecha As Date, ByVal encargado As Integer) As Hashtable


        Dim citas As Hashtable = New Hashtable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM `reservadiaview` WHERE Fecha = @fecha AND Encargado = @encargado"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@encargado", encargado)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                Dim reserva As New Reserva
                reserva.id = SafeGetInt(reader, 0)
                reserva.cliente = SafeGetInt(reader, 1)
                reserva.fecha = fecha
                reserva.horaInicio = SafeGetTimeSpam(reader, 3).ToString("hh\:mm")
                reserva.horaFin = SafeGetTimeSpam(reader, 4).ToString("hh\:mm")
                reserva.comentario = SafeGetString(reader, 5)
                reserva.tag = SafeGetInt(reader, 6)
                reserva.clienteNombre = SafeGetString(reader, 7)
                reserva.encargado = SafeGetInt(reader, 8)
                citas(reserva.tag) = reserva

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return citas
    End Function

    Public Function cargarServiciosReserva(ByVal reserva As String) As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT IDServicio AS ID, Servicio AS Nombre FROM reservaview WHERE IDReserva = @reserva "
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)

            adp = New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function cargarEncargado(ByVal reserva As String) As Personal
        Dim ds As New DataSet
        Dim empleado As New Personal
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT IDEncargado AS ID, Encargado AS Nombre FROM reservaview WHERE IDReserva = @reserva LIMIT 1 "
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                empleado.id = SafeGetInt(reader, 0)
                empleado.nombre = SafeGetString(reader, 1)


            End While
            reader.Close()
            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return empleado
    End Function

    Public Function solapamiento(ByVal inicio As TimeSpan, ByVal fin As TimeSpan, ByVal fecha As Date) As Integer
        Dim ds As New DataSet
        Dim n As New Integer
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "CALL `solapamientohoras`(@inicio,@fin,@fecha)"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@inicio", inicio)
            cmd.Parameters.AddWithValue("@fin", fin)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                n = SafeGetInt(reader, 0)



            End While
            reader.Close()
            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return n
    End Function

End Class
