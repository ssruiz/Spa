Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ReservaDAO
    Public Sub guardarReserva(ByVal reserva As Reserva, ByVal servicios As DataGridViewRowCollection)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()

            Dim query = "INSERT INTO `reserva` (`fecha_reserva`, `id_cliente`, `hora_inicio`,hora_fin, `comentario_reserva`, `tag_horario`,`total_pagar`, `total_pagado`, `estado_reserva`, `saldo_reserva`,`descripcion_reserva`,`descuento_reserva`)" _
                        & " VALUES ( @fecha, @cliente, @hora,@horafin, @comentario, @tag, @total,@pagado,@estado,@saldo,@desc,@descuento); SELECT LAST_INSERT_ID();"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", reserva.fecha)
            cmd.Parameters.AddWithValue("@cliente", reserva.cliente)
            cmd.Parameters.AddWithValue("@hora", reserva.horaInicio)
            cmd.Parameters.AddWithValue("@horafin", reserva.horaFin)
            cmd.Parameters.AddWithValue("@comentario", reserva.comentario)
            cmd.Parameters.AddWithValue("@tag", reserva.tag)
            cmd.Parameters.AddWithValue("@total", reserva.total)
            cmd.Parameters.AddWithValue("@pagado", reserva.entrega)
            cmd.Parameters.AddWithValue("@estado", reserva.estado)
            cmd.Parameters.AddWithValue("@saldo", reserva.saldo)
            cmd.Parameters.AddWithValue("@desc", reserva.descripcion)
            cmd.Parameters.AddWithValue("@descuento", reserva.descuento)
            Dim reservaCod = CInt(cmd.ExecuteScalar)
            Dim queryDetalle = "INSERT INTO `reserva_servicios` (`id_reserva`, `id_servicio`) VALUES (@reserva, @servicio);"
            Dim cmd2 As New MySqlCommand(queryDetalle, con)
            For Each r As DataGridViewRow In servicios
                Dim idServ = r.Cells("ID").Value
                cmd2.Parameters.AddWithValue("@reserva", reservaCod)
                cmd2.Parameters.AddWithValue("@servicio", idServ)

                cmd2.ExecuteNonQuery()
                cmd2.Parameters.Clear()
            Next

            If reserva.entrega > 0 Then
                Dim queryPago = "INSERT INTO `pagos_reserva` (`id_reserva`, `tipo_reserva`, `monto_pagado`, `fecha_pago`,`forma_pago`) " _
                & "VALUES (@reserva, 'S', @monto, @fecha,@forma);"
                Dim cmdPago As New MySqlCommand(queryPago, con)
                cmdPago.Parameters.AddWithValue("@reserva", reservaCod)
                cmdPago.Parameters.AddWithValue("@monto", reserva.entrega)
                cmdPago.Parameters.AddWithValue("@fecha", reserva.fecha)
                cmdPago.Parameters.AddWithValue("@forma", reserva.formaPago)
                cmdPago.ExecuteNonQuery()
            End If
            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Function guardarReservaP(ByVal reserva As Reservap) As Integer

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()

            Dim query = "INSERT INTO `reservap` (`id_paquete`, `id_cliente`, `fecha_compra`, `entrega_rp`, `saldo_rp`, `total_rp`, `estado_rp`, `comentario_rp`,`descripcion_reserva`,`descuento_reserva`)" _
                        & " VALUES ( @paquete, @cliente, @fecha, @entrega, @saldo, @total, @estado, @comentario,@desc,@descuento);  SELECT LAST_INSERT_ID();"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", reserva.fecha)
            cmd.Parameters.AddWithValue("@cliente", reserva.cliente)
            cmd.Parameters.AddWithValue("@paquete", reserva.paquete)
            cmd.Parameters.AddWithValue("@entrega", reserva.entrega)
            cmd.Parameters.AddWithValue("@saldo", reserva.saldo)
            cmd.Parameters.AddWithValue("@total", reserva.total)
            cmd.Parameters.AddWithValue("@comentario", reserva.comentario)
            cmd.Parameters.AddWithValue("@estado", reserva.estado)
            cmd.Parameters.AddWithValue("@desc", reserva.descripcion)
            cmd.Parameters.AddWithValue("@descuento", reserva.descuento)
            Dim reservaCod = CInt(cmd.ExecuteScalar)

            Dim queryDetalle = "INSERT INTO `sesionesp` (`id_reservap`,`sesiones_realizadas`, `id_servicio`, `total_sesiones`)  SELECT @reservap, 0 , `id_servicio`, `nro_sesiones` FROM paquete_detalle WHERE `id_paquete` = @paquete  "
            Dim cmd2 As New MySqlCommand(queryDetalle, con)

            cmd2.Parameters.AddWithValue("@paquete", reserva.paquete)
            cmd2.Parameters.AddWithValue("@reservap", reservaCod)

            cmd2.ExecuteNonQuery()
            If reserva.entrega > 0 Then
                Dim queryPago = "INSERT INTO `pagos_reserva` (`id_reservap`, `tipo_reserva`, `monto_pagado`, `fecha_pago`,`forma_pago`) " _
                & "VALUES (@reserva, 'P', @monto, @fecha,@forma);"
                Dim cmdPago As New MySqlCommand(queryPago, con)
                cmdPago.Parameters.AddWithValue("@reserva", reservaCod)
                cmdPago.Parameters.AddWithValue("@monto", reserva.entrega)
                cmdPago.Parameters.AddWithValue("@fecha", reserva.fecha)
                cmdPago.Parameters.AddWithValue("@forma", reserva.formaPago)
                cmdPago.ExecuteNonQuery()
                Dim queryCaja = "UPDATE `caja` SET  `monto_total` = `monto_total` + @monto WHERE `estado_caja` = 'A';"
                Dim cmdCaja As New MySqlCommand(queryCaja, con)
                cmdCaja.Parameters.AddWithValue("@monto", reserva.entrega)
                cmdCaja.ExecuteNonQuery()
            End If

            con.Close()
            Return reservaCod

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Function

    Public Function guardarReservaPPersonalizada(ByVal reserva As Reservap, ByVal detalle As DataGridViewRowCollection) As Integer

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim queryNuevoPaquete = "INSERT INTO `paquetes` (`nombre_paquete`, `precio_paquete`) VALUES (@nombre, @precio); SELECT LAST_INSERT_ID();"
            Dim cmdNuevoPaquete As New MySqlCommand(queryNuevoPaquete, con)
            cmdNuevoPaquete.Parameters.AddWithValue("@nombre", reserva.paqueteNombre)
            cmdNuevoPaquete.Parameters.AddWithValue("@precio", reserva.total)


            Dim idP = CInt(cmdNuevoPaquete.ExecuteScalar)
            Dim queryDetallePaquete = "INSERT INTO `paquete_detalle` (`id_servicio`, `id_paquete`, `nro_sesiones`) VALUES (@servicio, @paquete, @nro);"
            Dim cmdDetallePaquete As New MySqlCommand(queryDetallePaquete, con)
            For Each r As DataGridViewRow In detalle
                Dim idServ = r.Cells("ID").Value
                Dim nro = r.Cells(3).Value
                cmdDetallePaquete.Parameters.AddWithValue("@servicio", idServ)
                cmdDetallePaquete.Parameters.AddWithValue("@paquete", idP)
                cmdDetallePaquete.Parameters.AddWithValue("@nro", nro)

                cmdDetallePaquete.ExecuteNonQuery()
                cmdDetallePaquete.Parameters.Clear()
            Next

            Dim query = "INSERT INTO `reservap` (`id_paquete`, `id_cliente`, `fecha_compra`, `entrega_rp`, `saldo_rp`, `total_rp`, `estado_rp`, `comentario_rp`,`descripcion_reserva`,`descuento_reserva`)" _
                        & " VALUES ( @paquete, @cliente, @fecha, @entrega, @saldo, @total, @estado, @comentario,@desc,@descuento);  SELECT LAST_INSERT_ID();"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", reserva.fecha)
            cmd.Parameters.AddWithValue("@cliente", reserva.cliente)
            cmd.Parameters.AddWithValue("@paquete", idP)
            cmd.Parameters.AddWithValue("@entrega", reserva.entrega)
            cmd.Parameters.AddWithValue("@saldo", reserva.saldo)
            cmd.Parameters.AddWithValue("@total", reserva.total)
            cmd.Parameters.AddWithValue("@comentario", reserva.comentario)
            cmd.Parameters.AddWithValue("@estado", reserva.estado)
            cmd.Parameters.AddWithValue("@desc", reserva.descripcion)
            cmd.Parameters.AddWithValue("@descuento", reserva.descuento)
            Dim reservaCod = CInt(cmd.ExecuteScalar)

            Dim queryDetalle = "INSERT INTO `sesionesp` (`id_reservap`,`sesiones_realizadas`, `id_servicio`, `total_sesiones`)  SELECT @reservap, 0 , `id_servicio`, `nro_sesiones` FROM paquete_detalle WHERE `id_paquete` = @paquete  "
            Dim cmd2 As New MySqlCommand(queryDetalle, con)

            cmd2.Parameters.AddWithValue("@paquete", idP)
            cmd2.Parameters.AddWithValue("@reservap", reservaCod)

            cmd2.ExecuteNonQuery()
            If reserva.entrega > 0 Then
                Dim queryPago = "INSERT INTO `pagos_reserva` (`id_reservap`, `tipo_reserva`, `monto_pagado`, `fecha_pago`,`forma_pago`) " _
                & "VALUES (@reserva, 'P', @monto, @fecha,@forma);"
                Dim cmdPago As New MySqlCommand(queryPago, con)
                cmdPago.Parameters.AddWithValue("@reserva", reservaCod)
                cmdPago.Parameters.AddWithValue("@monto", reserva.entrega)
                cmdPago.Parameters.AddWithValue("@fecha", reserva.fecha)
                cmdPago.Parameters.AddWithValue("@forma", reserva.formaPago)
                cmdPago.ExecuteNonQuery()
                Dim queryCaja = "UPDATE `caja` SET  `monto_total` = `monto_total` + @monto WHERE `estado_caja` = 'A';"
                Dim cmdCaja As New MySqlCommand(queryCaja, con)
                cmdCaja.Parameters.AddWithValue("@monto", reserva.entrega)
                cmdCaja.ExecuteNonQuery()
            End If

            con.Close()
            Return reservaCod

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Function



    Public Sub realizarPagoPaquete(ByVal reserva As String, ByVal monto As Double, ByVal tipo As String)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim queryPago = "INSERT INTO `pagos_reserva` (`id_reservap`, `tipo_reserva`, `monto_pagado`, `fecha_pago`, `forma_pago`) " _
                              & "VALUES (@reserva, 'P', @monto, @fecha, @tipo);"
            Dim cmdPago As New MySqlCommand(queryPago, con)
            cmdPago.Parameters.AddWithValue("@reserva", reserva)
            cmdPago.Parameters.AddWithValue("@monto", monto)
            cmdPago.Parameters.AddWithValue("@fecha", Date.Today)
            cmdPago.Parameters.AddWithValue("@tipo", tipo)

            cmdPago.ExecuteNonQuery()

            Dim queryPaquete = "UPDATE `reservap` SET `saldo_rp` = `saldo_rp` - @monto WHERE `id_reservap` = @reserva;"
            Dim cmdPaquete As New MySqlCommand(queryPaquete, con)
            cmdPaquete.Parameters.AddWithValue("@monto", monto)
            cmdPaquete.Parameters.AddWithValue("@reserva", reserva)
            cmdPaquete.ExecuteNonQuery()

            Dim queryCaja = "UPDATE `caja` SET  `monto_total` = `monto_total` + @monto WHERE `estado_caja` = 'A' AND `fecha_apertura_caja` = @fecha;"
            Dim cmdCaja As New MySqlCommand(queryCaja, con)
            cmdCaja.Parameters.AddWithValue("@monto", monto)
            cmdCaja.Parameters.AddWithValue("@fecha", Date.Today)
            cmdCaja.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub realizarPagoReserva(ByVal reserva As String, ByVal monto As Double, ByVal tipo As String)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim queryPago = "INSERT INTO `pagos_reserva` (`id_reserva`, `tipo_reserva`, `monto_pagado`, `fecha_pago`, `forma_pago`) " _
                              & "VALUES (@reserva, 'S', @monto, @fecha, @tipo);"
            Dim cmdPago As New MySqlCommand(queryPago, con)
            cmdPago.Parameters.AddWithValue("@reserva", reserva)
            cmdPago.Parameters.AddWithValue("@monto", monto)
            cmdPago.Parameters.AddWithValue("@fecha", Date.Today)
            cmdPago.Parameters.AddWithValue("@tipo", tipo)

            cmdPago.ExecuteNonQuery()


            Dim queryReserva = "UPDATE `reserva` SET `saldo_reserva` = `saldo_reserva` - @monto WHERE `id_reserva` = @reserva;"
            Dim cmdReserva As New MySqlCommand(queryReserva, con)
            cmdReserva.Parameters.AddWithValue("@monto", monto)
            cmdReserva.Parameters.AddWithValue("@reserva", reserva)
            cmdReserva.ExecuteNonQuery()

            Dim queryCaja = "UPDATE `caja` SET  `monto_total` = `monto_total` + @monto WHERE `estado_caja` = 'A' AND `fecha_apertura_caja` = @fecha;"
            Dim cmdCaja As New MySqlCommand(queryCaja, con)
            cmdCaja.Parameters.AddWithValue("@monto", monto)
            cmdCaja.Parameters.AddWithValue("@fecha", Date.Today)
            cmdCaja.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Function cargarCitasDelDiaAgenda(ByVal fecha As Date) As Hashtable


        Dim citas As Hashtable = New Hashtable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT GROUP_CONCAT(Cliente  SEPARATOR ' - '), Tag FROM `reservadiaview` WHERE Fecha = @fecha AND (Estado='A' OR Estado= 'P') GROUP BY `tag`"
            Dim query2 = "SELECT GROUP_CONCAT(t1.clientes , ' - ' ,t2.s ), t2.Tag FROM (SELECT GROUP_CONCAT(r1.Cliente SEPARATOR ' - ') clientes, TagHora FROM `reservasesionesdiaview` r1 WHERE Fecha = @fecha AND (EstadoSesion='A') GROUP BY `TagHora`) t1 UNION ALL (SELECT GROUP_CONCAT(r2.Cliente SEPARATOR ' - ') s, Tag FROM `reservadiaview` r2 WHERE Fecha = @fecha AND (Estado='A' or Estado='P') GROUP BY `tag`) t2 ON t1.TagHora = t2.Tag GROUP BY t2.Tag "
            Dim query3 = "SELECT GROUP_CONCAT(COALESCE(t1.clientes,'') , ' - ' ,COALESCE(t2.s,'') ), t2.Tag FROM (SELECT GROUP_CONCAT(r1.Cliente SEPARATOR ' - ') clientes, TagHora FROM `reservasesionesdiaview` r1 WHERE Fecha = @fecha AND EstadoSesion='A' GROUP BY `TagHora`) t1 LEFT JOIN (SELECT GROUP_CONCAT(r2.Cliente SEPARATOR ' - ') s, Tag FROM `reservadiaview` r2 WHERE Fecha = @fecha AND (Estado='A' OR Estado= 'P') GROUP BY `tag`) t2 ON t1.TagHora = t2.Tag GROUP BY t2.Tag UNION SELECT GROUP_CONCAT(COALESCE(t1.clientes,'') , ' - ' ,COALESCE(t2.s,'') ), t2.Tag FROM (SELECT GROUP_CONCAT(r1.Cliente SEPARATOR ' - ') clientes, TagHora FROM `reservasesionesdiaview` r1 WHERE Fecha = @fecha AND EstadoSesion='A' GROUP BY `TagHora`) t1 RIGHT JOIN (SELECT GROUP_CONCAT(r2.Cliente SEPARATOR ' - ') s, Tag FROM `reservadiaview` r2 WHERE Fecha = @fecha AND (Estado='A' OR Estado= 'P') GROUP BY `tag`) t2 ON t1.TagHora = t2.Tag GROUP BY t2.Tag "

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", fecha)

            Dim reader = cmd.ExecuteReader()

            While reader.Read
                Dim reserva As New Reserva
                Dim clientes As String
                Dim tagH As Integer
                clientes = SafeGetString(reader, 0)
                tagH = SafeGetInt(reader, 1)

                citas(tagH) = clientes

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return citas
    End Function

    Public Function cargarSesiones(ByVal fecha As Date) As Hashtable
        Dim citas As Hashtable = New Hashtable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()

            Dim query = " Select GROUP_CONCAT(Cliente  SEPARATOR ' - '), TagHora FROM `reservasesionesagendaview` WHERE Fecha =  @fecha AND (EstadoSesion='A' OR EstadoSesion= 'P') GROUP BY `TagHora`"
            Dim query2 = "SELECT GROUP_CONCAT(t1.clientes , ' - ' ,t2.s ), t2.Tag FROM (SELECT GROUP_CONCAT(r1.Cliente SEPARATOR ' - ') clientes, TagHora FROM `reservasesionesdiaview` r1 WHERE Fecha = @fecha AND (EstadoSesion='A') GROUP BY `TagHora`) t1 UNION ALL (SELECT GROUP_CONCAT(r2.Cliente SEPARATOR ' - ') s, Tag FROM `reservadiaview` r2 WHERE Fecha = @fecha AND (Estado='A' or Estado='P') GROUP BY `tag`) t2 ON t1.TagHora = t2.Tag GROUP BY t2.Tag "
            Dim query3 = "SELECT GROUP_CONCAT(COALESCE(t1.clientes,'') , ' - ' ,COALESCE(t2.s,'') ), t2.Tag FROM (SELECT GROUP_CONCAT(r1.Cliente SEPARATOR ' - ') clientes, TagHora FROM `reservasesionesdiaview` r1 WHERE Fecha = @fecha AND EstadoSesion='A' GROUP BY `TagHora`) t1 LEFT JOIN (SELECT GROUP_CONCAT(r2.Cliente SEPARATOR ' - ') s, Tag FROM `reservadiaview` r2 WHERE Fecha = @fecha AND (Estado='A' OR Estado= 'P') GROUP BY `tag`) t2 ON t1.TagHora = t2.Tag GROUP BY t2.Tag UNION SELECT GROUP_CONCAT(COALESCE(t1.clientes,'') , ' - ' ,COALESCE(t2.s,'') ), t2.Tag FROM (SELECT GROUP_CONCAT(r1.Cliente SEPARATOR ' - ') clientes, TagHora FROM `reservasesionesdiaview` r1 WHERE Fecha = @fecha AND EstadoSesion='A' GROUP BY `TagHora`) t1 RIGHT JOIN (SELECT GROUP_CONCAT(r2.Cliente SEPARATOR ' - ') s, Tag FROM `reservadiaview` r2 WHERE Fecha = @fecha AND (Estado='A' OR Estado= 'P') GROUP BY `tag`) t2 ON t1.TagHora = t2.Tag GROUP BY t2.Tag "

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", fecha)

            Dim reader = cmd.ExecuteReader()

            While reader.Read
                Dim reserva As New Reserva
                Dim clientes As String
                Dim tagH As Integer
                clientes = SafeGetString(reader, 0)
                tagH = SafeGetInt(reader, 1)

                citas(tagH) = clientes

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return citas
    End Function


    Public Function cargarCitasDelDia(ByVal fecha As Date, ByVal tagHora As String) As DataSet

        Dim ds As New DataSet

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT ID, Cliente, Comentario FROM `reservadiaview` WHERE Fecha = @fecha AND tag = @tagh AND (Estado='A' OR Estado= 'P')"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@tagh", tagHora)
            Dim adp = New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))



            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
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

    Public Function cargarServiciosReservaP(ByVal reserva As String) As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT IDServ AS ID, Servicio AS Nombre FROM `historialsesionesview` WHERE IDS = @reserva "
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

    Public Sub cancelarReserva(ByVal reserva As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "UPDATE `reserva` SET `estado_reserva` = 'C' WHERE `id_reserva` = @reserva;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)

            cmd.ExecuteNonQuery()


            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub cancelarReservaP(ByVal reserva As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "UPDATE `reservap` SET `estado_rp` = 'A' WHERE `id_reservap` = @reserva;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)

            cmd.ExecuteNonQuery()


            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub


    Public Sub cancelarReservaSesion(ByVal reserva As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()

            Dim query = "UPDATE `historial_reservap` SET  `estado_hrp` = 'C' WHERE `id_hp` = @reserva;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)

            cmd.ExecuteNonQuery()


            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Function cargarReserva(ByVal reserva As String) As Reserva
        Dim ds As New DataSet
        Dim rp As New Reserva
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM `cargareservaview` WHERE IDR = @reserva "

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                rp.id = SafeGetInt(reader, 0)
                rp.fecha = SafeGetDate(reader, 1)
                rp.clienteNombre = SafeGetString(reader, 2)
                rp.horaInicio = SafeGetTimeSpam(reader, 3).ToString
                rp.total = SafeGetDouble(reader, 4)
                rp.entrega = SafeGetDouble(reader, 5)
                rp.comentario = SafeGetString(reader, 6)
                rp.estado = SafeGetString(reader, 7)
                rp.saldo = SafeGetDouble(reader, 8)
                rp.descuento = SafeGetDouble(reader, 9)
            End While


            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return rp
    End Function

    Public Function cargarReservaP(ByVal reserva As String) As Reservap
        Dim ds As New DataSet
        Dim rp As New Reservap
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM reservapview WHERE IDR = @reserva "

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                rp.id = SafeGetInt(reader, 0)
                rp.paqueteNombre = SafeGetString(reader, 1)
                rp.clienteNombre = SafeGetString(reader, 2)
                rp.fecha = SafeGetDate(reader, 3)
                rp.entrega = SafeGetDouble(reader, 4)
                rp.saldo = SafeGetDouble(reader, 5)
                rp.total = SafeGetDouble(reader, 6)
                rp.estado = SafeGetString(reader, 7)
                rp.comentario = SafeGetString(reader, 8)
            End While


            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return rp
    End Function

    Public Function guardarSesion(ByVal sesionp As SesionP) As Boolean
        Dim res As Boolean
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim queryControl = " SELECT COUNT(*) FROM historial_reservap WHERE id_reservap = @re AND  `fecha` = @fecha AND id_servicio = @serv AND tag_horario = @tag  AND `estado_hrp` <> 'C'"
            Dim cmd2 As New MySqlCommand(queryControl, con)
            cmd2.Parameters.AddWithValue("@re", sesionp.reservap)
            cmd2.Parameters.AddWithValue("@fecha", sesionp.fecha)

            cmd2.Parameters.AddWithValue("@serv", sesionp.servicio)
            cmd2.Parameters.AddWithValue("@tag", sesionp.tag)
            Dim reader = cmd2.ExecuteReader
            Dim rows
            While reader.Read
                rows = SafeGetInt(reader, 0)
            End While
            reader.Close()
            If rows > 0 Then
                MsgBox("Ya existe una reserva para esta sesión esa fecha y hora seleccionadas", MsgBoxStyle.Information, "Reserva cancelada")
                Return False
            End If

            Dim query = "INSERT INTO `historial_reservap` (`fecha`, `id_reservap`, `id_servicio`,hora_inicio, `tag_horario`) VALUES (@fecha, @reservap, @servicio,@hora, @tag);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", sesionp.fecha)
            cmd.Parameters.AddWithValue("@reservap", sesionp.reservap)
            cmd.Parameters.AddWithValue("@servicio", sesionp.servicio)
            cmd.Parameters.AddWithValue("@hora", sesionp.horaInicio)
            cmd.Parameters.AddWithValue("@tag", sesionp.tag)

            cmd.ExecuteNonQuery()



            con.Close()
            actualizarNroSesiones(sesionp)
            res = True

        Catch ex As Exception
            res = False
            Throw New DAOException(ex.ToString)

        End Try
        Return res
    End Function

    Private Sub actualizarNroSesiones(ByVal sesionp As SesionP)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "UPDATE `sesionesp` SET  `sesiones_realizadas` = `sesiones_realizadas` + 1 WHERE `id_reservap` = @rp AND `id_servicio` = @serv ;"
            Dim cmd2 As New MySqlCommand(query, con)
            cmd2.Parameters.AddWithValue("@rp", sesionp.reservap)
            cmd2.Parameters.AddWithValue("@serv", sesionp.servicio)
            cmd2.ExecuteNonQuery()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function cargarSesionesAgendadas(ByVal reserva As String) As DataSet
        Dim ds As New DataSet
        Dim rp As New Reservap
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM historialsesionesview WHERE IDR = @reserva AND Estado= 'A' order by Fecha"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@reserva", reserva)

            Dim adp = New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function cancelarCita(ByVal reservaS As String, ByVal reservaP As String, ByVal serv As String) As Boolean
        Dim ds As New DataSet
        Dim res As Boolean
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "UPDATE `historial_reservap` SET  `estado_hrp` = 'C' WHERE `id_hp` = @idr;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@idr", reservaS)
            cmd.ExecuteNonQuery()


            Dim query2 = "UPDATE `sesionesp` SET  `sesiones_realizadas` = `sesiones_realizadas` - 1 WHERE `id_reservap` = @rp AND `id_servicio` = @serv ;"
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd2.Parameters.AddWithValue("@rp", reservaP)
            cmd2.Parameters.AddWithValue("@serv", serv)
            cmd2.ExecuteNonQuery()
            con.Close()
            res = True

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return res
    End Function

    Public Function cargarSesionesDelDia(ByVal fecha As Date, ByVal tagHora As String) As DataSet

        Dim ds As New DataSet

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM reservasesionesdiaview WHERE Fecha = @fecha AND TagHora = @tagh AND EstadoSesion='A'"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@tagh", tagHora)
            Dim adp = New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))



            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function cargarReservas() As MySqlDataAdapter
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM `reservaserviciossueltosview` WHERE Estado = 'A'  OR Estado = 'P'"
            Dim cmd As New MySqlCommand(query, con)
            adp = New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
            Return adp

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return adp
    End Function

    Public Function cargarReservasPaquetes() As MySqlDataAdapter
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM `reservapaquetesview` WHERE Estado = 'AD' or Estado = 'AP' "
            Dim cmd As New MySqlCommand(query, con)
            adp = New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
            Return adp

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return adp
    End Function
End Class