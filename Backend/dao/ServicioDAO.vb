Imports MySql.Data.MySqlClient

Public Class ServicioDAO
    Public Function cargarServicios() As MySqlDataAdapter
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM listadoserviciosview WHERE Precio > 0"
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
            Return adp

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return adp
    End Function

    Public Function cargarServiciosNombre() As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT ID,Nombre FROM listadoserviciosview WHERE Precio > 0"
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
    Public Function cargarPaquetesNombre() As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT `id_paquete` AS ID, `nombre_paquete` AS Nombre, `precio_paquete` AS Precio FROM `paquetes`;"
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function cargarPaqueteDetalle(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM paquetedetalleview where IDP = " & id & ""
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function cargarSesiones(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT * FROM sesionesview where IDR = " & id & ""
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
    Public Function getTipos() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT id_tipo AS ID, nombre_tipo AS Nombre FROM tiposervicio"

            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Sub agregarServicio(ByVal servicio As Servicio)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "INSERT INTO `servicios` (`nombre_serv`, `descripcion_serv`, `precio_serv`, `id_tipo`, `duracion_serv`)" _
                        & " VALUES (@nombre, @desc, @precio, @tipo, @duracion);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@nombre", servicio.nombre)
            cmd.Parameters.AddWithValue("@desc", servicio.descripcion)
            cmd.Parameters.AddWithValue("@precio", servicio.costo)
            cmd.Parameters.AddWithValue("@tipo", servicio.tipo)
            cmd.Parameters.AddWithValue("@duracion", servicio.duracion)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function obtenerServicio(ByVal id As String) As Servicio
        Dim servicio As New Servicio
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * from servicios where id_serv = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                servicio.id = id
                servicio.nombre = SafeGetString(reader, 1)
                servicio.descripcion = SafeGetString(reader, 2)
                servicio.costo = SafeGetDouble(reader, 3)
                servicio.tipo = SafeGetInt(reader, 4)
                servicio.duracion = SafeGetInt(reader, 5)
            End While

            reader.Close()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return servicio
    End Function
    Public Function obtenerServicioReserva(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "SELECT id_serv AS ID,nombre_serv AS Nombre,precio_serv AS Precio from servicios where id_serv = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim adp As New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))


            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Sub actualizarServicio(ByVal servicio As Servicio)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `servicios` SET `nombre_serv` = @nombre, `descripcion_serv` = @desc, `precio_serv` = @precio, `id_tipo` = @tipo," _
                        & " `duracion_serv` = @duracion WHERE `id_serv` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", servicio.id)
            cmd.Parameters.AddWithValue("@nombre", servicio.nombre)
            cmd.Parameters.AddWithValue("@desc", servicio.descripcion)
            cmd.Parameters.AddWithValue("@precio", servicio.costo)
            cmd.Parameters.AddWithValue("@tipo", servicio.tipo)
            cmd.Parameters.AddWithValue("@duracion", servicio.duracion)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub
End Class
