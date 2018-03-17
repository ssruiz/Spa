Imports MySql.Data.MySqlClient

Public Class ClienteDAO
    Public Function cargarClientes() As MySqlDataAdapter
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM listadoclientesview"
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

    Public Function cargarCliente(ByVal id As String) As Cliente


        Dim cliente As New Cliente
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from clientes where id_cliente = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                cliente.id = id
                cliente.ci = SafeGetString(reader, 1)
                cliente.nombre = SafeGetString(reader, 2)
                cliente.apellido = SafeGetString(reader, 3)
                cliente.sex = SafeGetString(reader, 4)
                cliente.fechaNaci = SafeGetDate(reader, 5)
                cliente.ruc = SafeGetString(reader, 6)
                cliente.tel = SafeGetString(reader, 8)
                cliente.cel = SafeGetString(reader, 9)
                cliente.email = SafeGetString(reader, 10)
            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return cliente
    End Function

    Public Sub actualizarCliente(ByVal cliente As Cliente)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `clientes` SET  `ci_cliente` = @ci, `nombre_cliente` = @nombre, `apellido_cliente` = @apellido, `sexo_cliente` = @sex" _
                        & ", `fecha_nac` = @fechaNac, `ruc_cliente` = @ruc,  `telefono_cliente` = @tel, `celular_cliente` = @cel, `email_cliente` = @email" _
                        & " WHERE `id_cliente` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ci", cliente.ci)
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre)
            cmd.Parameters.AddWithValue("@apellido", cliente.apellido)
            cmd.Parameters.AddWithValue("@fechaNac", cliente.fechaNaci)
            cmd.Parameters.AddWithValue("@ruc", cliente.ruc)
            cmd.Parameters.AddWithValue("@tel", cliente.tel)
            cmd.Parameters.AddWithValue("@cel", cliente.cel)
            cmd.Parameters.AddWithValue("@email", cliente.email)
            cmd.Parameters.AddWithValue("@sex", cliente.sex)
            cmd.Parameters.AddWithValue("@id", cliente.id)
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub guardarCliente(ByVal cliente As Cliente)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "INSERT INTO clientes (`ci_cliente`, `nombre_cliente`, `apellido_cliente`, `sexo_cliente`," _
                            & " `fecha_nac`, `ruc_cliente`, `telefono_cliente`, `celular_cliente`, `email_cliente`)" _
                            & " VALUES  (@ci, @nombre, @apellido, @sex , @naci, @ruc, @tel, @cel, @mail); "
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ci", cliente.ci)
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre)
            cmd.Parameters.AddWithValue("@apellido", cliente.apellido)
            cmd.Parameters.AddWithValue("@sex", cliente.sex)
            cmd.Parameters.AddWithValue("@naci", cliente.fechaNaci)
            cmd.Parameters.AddWithValue("@ruc", cliente.ruc)
            cmd.Parameters.AddWithValue("@tel", cliente.tel)
            cmd.Parameters.AddWithValue("@cel", cliente.cel)
            cmd.Parameters.AddWithValue("@mail", cliente.email)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function buscarClientes(ByVal buscar As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = ""
            'Dim cmd As New MySqlCommand(query, con)


            query = "SELECT id_cliente as ID, nombre_cliente as Nombre, apellido_cliente as Apellido, ci_cliente as CI, " _
                            & "ruc_cliente as RUC from clientes where nombre_cliente LIKE CONCAT('%',@nombre,'%') or apellido_cliente LIKE CONCAT('%',@nombre,'%')"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@nombre", buscar)
            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function


End Class
