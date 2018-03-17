Imports MySql.Data.MySqlClient

Public Class PersonalDAO
    Public Function cargarPersonal() As MySqlDataAdapter
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM listadopersonalview"
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

    Public Sub agregarPersonal(ByVal empleado As Personal)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "INSERT INTO `empleados` (`nombre_emp`, `apellido_emp`, `telefono_emp`, `celular_emp`)" _
                           & " VALUES( @nombre,@apellido, @tel, @cel);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@nombre", empleado.nombre)
            cmd.Parameters.AddWithValue("@apellido", empleado.apellido)
            cmd.Parameters.AddWithValue("@tel", empleado.tel)
            cmd.Parameters.AddWithValue("@cel", empleado.cel)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Function cargarEmpleado(ByVal id As String) As Personal
        Dim empleado As New Personal
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from empleados where id_emp = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                empleado.id = id
                empleado.nombre = SafeGetString(reader, 1)
                empleado.apellido = SafeGetString(reader, 2)
                empleado.tel = SafeGetString(reader, 3)
                empleado.cel = SafeGetString(reader, 4)
            End While

            reader.Close()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return empleado
    End Function

    Public Function getEmp() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT id_emp AS ID, nombre_emp AS Nombre FROM empleados"

            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
End Class
