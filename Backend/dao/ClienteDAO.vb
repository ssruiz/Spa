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
End Class
