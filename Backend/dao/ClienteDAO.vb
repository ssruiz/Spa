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
                cliente.edad = SafeGetInt(reader, 4)
                cliente.sex = SafeGetString(reader, 5)

                cliente.ruc = SafeGetString(reader, 6)
                cliente.dir = SafeGetString(reader, 7)

                cliente.tel = SafeGetString(reader, 8)
                cliente.cel = SafeGetString(reader, 9)
                cliente.email = SafeGetString(reader, 10)
                cliente.nacio = SafeGetString(reader, 12)
                cliente.estadoC = SafeGetString(reader, 13)
                cliente.dirDep = SafeGetString(reader, 14)
                cliente.dirCiudad = SafeGetString(reader, 15)
                cliente.dirBarrio = SafeGetString(reader, 16)
            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return cliente
    End Function

    Public Function cargarEncargado(ByVal id As String) As Encargado


        Dim encargado As New Encargado
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from encargado where id_cliente = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read

                encargado.cliente = id
                encargado.nombre = SafeGetString(reader, 1)
                encargado.apellido = SafeGetString(reader, 2)
                encargado.ci = SafeGetInt(reader, 3)
                encargado.edad = SafeGetInt(reader, 4)
                encargado.ocupacion = SafeGetString(reader, 5)
                encargado.telefono = SafeGetString(reader, 6)

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return encargado
    End Function



    Public Function cargarHistorialUnico(ByVal id As String) As Historial

        Dim historial As New Historial
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `historial` where id_historial = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                historial.idFicha = SafeGetInt(reader, 0)
                historial.id = SafeGetInt(reader, 1)
                historial.enfermedad = SafeGetString(reader, 2)
                historial.fecha = SafeGetDate(reader, 3)
                historial.peso = SafeGetString(reader, 4)
                historial.altura = SafeGetString(reader, 5)
                historial.imc = SafeGetString(reader, 6)
                historial.pesoI = SafeGetString(reader, 7)
                historial.cinth = SafeGetString(reader, 8)
                historial.omb = SafeGetString(reader, 9)
                historial.bomb = SafeGetString(reader, 10)
                historial.pd = SafeGetString(reader, 11)
                historial.pi = SafeGetString(reader, 12)
                historial.bd = SafeGetString(reader, 13)
                historial.bi = SafeGetString(reader, 14)



            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return historial
    End Function
    Public Function cargarAntecedentes(ByVal id As String) As FichaM


        Dim ante As New FichaM
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from ficha_cliente where id_cliente = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ante.id = SafeGetInt(reader, 0)
                ante.idCliente = SafeGetInt(reader, 1)
                ante.anteP = SafeGetString(reader, 2)
                ante.anteM = SafeGetString(reader, 3)
                ante.anteH = SafeGetString(reader, 4)
                ante.anteHj = SafeGetString(reader, 5)
                ante.anteCardio = SafeGetBool(reader, 6)
                ante.anteResp = SafeGetBool(reader, 7)
                ante.anteAlerg = SafeGetBool(reader, 8)
                ante.anteNeop = SafeGetBool(reader, 9)
                ante.anteDig = SafeGetBool(reader, 10)
                ante.anteGenit = SafeGetBool(reader, 11)
                ante.anteAsm = SafeGetBool(reader, 12)
                ante.anteMeta = SafeGetBool(reader, 13)
                ante.anteOsteo = SafeGetBool(reader, 14)
                ante.anteNeuro = SafeGetBool(reader, 15)
                ante.anteInter = SafeGetBool(reader, 16)
                ante.anteCiru = SafeGetBool(reader, 17)
                ante.antePsico = SafeGetBool(reader, 18)

                ante.anteAudioV = SafeGetBool(reader, 19)
                ante.anteTransfu = SafeGetBool(reader, 20)
                ante.anteOtros = SafeGetString(reader, 21)

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ante
    End Function
    Public Sub actualizarCliente(ByVal cliente As Cliente)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim query = "UPDATE `clientes` SET `ci_cliente` = @ci, `nombre_cliente` = @nombre, `apellido_cliente` = @apellido, `edad_cliente` = @edad, " _
                        & "`sexo_cliente` = @sex, `ruc_cliente` = @ruc, `direccion_cliente` = @dir, `telefono_cliente` = @tel, " _
                        & "`celular_cliente` = @cel, `email_cliente` = @email, `nacionalidad_cliente` = @nacio, `estado_civil_cliente` = @estadoc, " _
                        & " `dir_depa_cliente` = @depa, `dir_ciudad_cliente` = @ciudad, `dir_barrio_cliente` = @barrio WHERE `id_cliente` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ci", cliente.ci)
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre)
            cmd.Parameters.AddWithValue("@apellido", cliente.apellido)
            cmd.Parameters.AddWithValue("@edad", cliente.edad)
            cmd.Parameters.AddWithValue("@ruc", cliente.ruc)
            cmd.Parameters.AddWithValue("@tel", cliente.tel)
            cmd.Parameters.AddWithValue("@cel", cliente.cel)
            cmd.Parameters.AddWithValue("@email", cliente.email)
            cmd.Parameters.AddWithValue("@sex", cliente.sex)
            cmd.Parameters.AddWithValue("@id", cliente.id)
            cmd.Parameters.AddWithValue("@dir", cliente.dir)
            cmd.Parameters.AddWithValue("@nacio", cliente.nacio)
            cmd.Parameters.AddWithValue("@estadoc", cliente.estadoC)
            cmd.Parameters.AddWithValue("@depa", cliente.dirDep)
            cmd.Parameters.AddWithValue("@ciudad", cliente.dirCiudad)
            cmd.Parameters.AddWithValue("@barrio", cliente.dirBarrio)

            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function guardarCliente(ByVal cliente As Cliente) As Integer
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()

            Dim query = "INSERT INTO clientes (`ci_cliente`, `nombre_cliente`, `apellido_cliente`, `sexo_cliente`," _
                            & " `edad_cliente`, `ruc_cliente`,`direccion_cliente`, `telefono_cliente`, `celular_cliente`, `email_cliente`," _
                            & " `nacionalidad_cliente`, `estado_civil_cliente`, `dir_depa_cliente`, `dir_ciudad_cliente`, `dir_barrio_cliente`)" _
                            & " VALUES  (@ci, @nombre, @apellido, @sex , @edad, @ruc,@dir, @tel, @cel, @mail, @nacio, @estadoC,@depart,@ciudad,@barrio);  SELECT LAST_INSERT_ID(); "
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ci", cliente.ci)
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre)
            cmd.Parameters.AddWithValue("@apellido", cliente.apellido)
            cmd.Parameters.AddWithValue("@sex", cliente.sex)
            cmd.Parameters.AddWithValue("@edad", cliente.edad)
            cmd.Parameters.AddWithValue("@ruc", cliente.ruc)
            cmd.Parameters.AddWithValue("@dir", cliente.dir)
            cmd.Parameters.AddWithValue("@tel", cliente.tel)
            cmd.Parameters.AddWithValue("@cel", cliente.cel)
            cmd.Parameters.AddWithValue("@mail", cliente.email)
            cmd.Parameters.AddWithValue("@nacio", cliente.nacio)
            cmd.Parameters.AddWithValue("@estadoC", cliente.estadoC)
            cmd.Parameters.AddWithValue("@depart", cliente.dirDep)
            cmd.Parameters.AddWithValue("@ciudad", cliente.dirCiudad)
            cmd.Parameters.AddWithValue("@barrio", cliente.dirBarrio)
            Dim id = CInt(cmd.ExecuteScalar)
            cmd.Dispose()
            con.Close()
            Return id
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function

    Public Function buscarClientes(ByVal buscar As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
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


    Public Function guardarFichaCliente(ByVal ficha As FichaM) As Integer
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "INSERT INTO `ficha_cliente` (`id_cliente`, `antece_padre`, `antece_madre`, `antece_hermanos`, `antece_hijos`, `ante_cardio`, `ante_respiratorio`, `ante_alergico`, `ante_neoplas`, `ante_digest`, `ante_genito`, `ante_asmatico`, `ante_metabolico`, `ante_osteo`, `ante_neuro`, `ante_internaciones`, `ante_cirugia`, `ante_psicolo`, `ante_visuales`, `ante_transfu`, `otros`)" _
                        & " VALUES (@cliente, @antP, @antM, @antH, @antHj, @antCard, @antResp, @antAlerg, @antNeop, @antDig, @antGeni, @antAsma," _
                        & " @antMeta, @antOsteo, @antNeuro, @antInterna, @antCiru, @antPsico, @antAuvi, @antTransfu, @otros); SELECT LAST_INSERT_ID();"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cliente", ficha.idCliente)
            cmd.Parameters.AddWithValue("@antP", ficha.anteP)

            cmd.Parameters.AddWithValue("@antM", ficha.anteM)
            cmd.Parameters.AddWithValue("@antH", ficha.anteH)
            cmd.Parameters.AddWithValue("@antHj", ficha.anteHj)
            cmd.Parameters.AddWithValue("@antCard", ficha.anteCardio)
            cmd.Parameters.AddWithValue("@antResp", ficha.anteResp)
            cmd.Parameters.AddWithValue("@antAlerg", ficha.anteAlerg)
            cmd.Parameters.AddWithValue("@antNeop", ficha.anteNeop)
            cmd.Parameters.AddWithValue("@antDig", ficha.anteDig)
            cmd.Parameters.AddWithValue("@antGeni", ficha.anteGenit)
            cmd.Parameters.AddWithValue("@antAsma", ficha.anteAsm)
            cmd.Parameters.AddWithValue("@antMeta", ficha.anteMeta)
            cmd.Parameters.AddWithValue("@antOsteo", ficha.anteOsteo)
            cmd.Parameters.AddWithValue("@antNeuro", ficha.anteNeuro)

            cmd.Parameters.AddWithValue("@antInterna", ficha.anteInter)
            cmd.Parameters.AddWithValue("@antCiru", ficha.anteCiru)
            cmd.Parameters.AddWithValue("@antPsico", ficha.antePsico)
            cmd.Parameters.AddWithValue("@antAuvi", ficha.anteAudioV)
            cmd.Parameters.AddWithValue("@antTransfu", ficha.anteTransfu)
            cmd.Parameters.AddWithValue("@otros", ficha.anteOtros)

            id = CInt(cmd.ExecuteScalar)
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return id
    End Function

    Public Sub guardarHistorial(ByVal histo As Historial)
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim queryTratamiento = "INSERT INTO `tratamiento_ficha` (`id_ficha`, `nombre_tratamiento`, `fecha_inicio`) VALUES (@ficha, @trata, @fecha); SELECT LAST_INSERT_ID();"
            Dim cmdTrata As New MySqlCommand(queryTratamiento, con)
            cmdTrata.Parameters.AddWithValue("@ficha", histo.idFicha)
            cmdTrata.Parameters.AddWithValue("@trata", histo.enfermedad)
            cmdTrata.Parameters.AddWithValue("@fecha", Date.Today)

            Dim idt = CInt(cmdTrata.ExecuteScalar)

            Dim query = "INSERT INTO `historial` (`id_tratamiento`, `enfermedad_tratada`, `fecha_historial`, `peso`, `altura`, `imc`, `p_ideal`, `cint`, `omb`, `bomb`, `pd`, `pi`, `bd`, `bi`)" _
                        & " VALUES (@ficha, @enfer, @fecha, @peso, @altura, @imc, @pesoi, @cint, @omb, @bomb, @pd, @pi, @bd, @bi);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ficha", idt)
            cmd.Parameters.AddWithValue("@enfer", histo.enfermedad)
            cmd.Parameters.AddWithValue("@fecha", Date.Today)
            cmd.Parameters.AddWithValue("@peso", histo.peso)
            cmd.Parameters.AddWithValue("@altura", histo.altura)
            cmd.Parameters.AddWithValue("@imc", histo.imc)
            cmd.Parameters.AddWithValue("@pesoi", histo.pesoI)
            cmd.Parameters.AddWithValue("@cint", histo.cinth)
            cmd.Parameters.AddWithValue("@omb", histo.omb)
            cmd.Parameters.AddWithValue("@bomb", histo.bomb)
            cmd.Parameters.AddWithValue("@pd", histo.pd)
            cmd.Parameters.AddWithValue("@pi", histo.pi)
            cmd.Parameters.AddWithValue("@bd", histo.bd)
            cmd.Parameters.AddWithValue("@bi", histo.bi)
            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub guardarDetalleTratamiento(ByVal histo As Historial)
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()


            Dim query = "INSERT INTO `historial` (`id_tratamiento`, `enfermedad_tratada`, `fecha_historial`, `peso`, `altura`, `imc`, `p_ideal`, `cint`, `omb`, `bomb`, `pd`, `pi`, `bd`, `bi`)" _
                        & " VALUES (@ficha, @enfer, @fecha, @peso, @altura, @imc, @pesoi, @cint, @omb, @bomb, @pd, @pi, @bd, @bi);"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ficha", histo.idFicha)
            cmd.Parameters.AddWithValue("@enfer", histo.enfermedad)
            cmd.Parameters.AddWithValue("@fecha", Date.Today)
            cmd.Parameters.AddWithValue("@peso", histo.peso)
            cmd.Parameters.AddWithValue("@altura", histo.altura)
            cmd.Parameters.AddWithValue("@imc", histo.imc)
            cmd.Parameters.AddWithValue("@pesoi", histo.pesoI)
            cmd.Parameters.AddWithValue("@cint", histo.cinth)
            cmd.Parameters.AddWithValue("@omb", histo.omb)
            cmd.Parameters.AddWithValue("@bomb", histo.bomb)
            cmd.Parameters.AddWithValue("@pd", histo.pd)
            cmd.Parameters.AddWithValue("@pi", histo.pi)
            cmd.Parameters.AddWithValue("@bd", histo.bd)
            cmd.Parameters.AddWithValue("@bi", histo.bi)
            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub guardarEncargado(ByVal encargado As Encargado)
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            'Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
            con.Open()
            Dim query = "INSERT INTO `encargado` (`id_cliente`, `nombre_encargado`, `apellido_encargado`, `ci_encargado`, `edad_encargado`, `ocupacion_encargado`, `telefono_encargado`) " _
                    & "VALUES (@id, @nombre, @apellido, @ci, @edad, @ocup, @tel);"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", encargado.cliente)
            cmd.Parameters.AddWithValue("@nombre", encargado.nombre)
            cmd.Parameters.AddWithValue("@apellido", encargado.apellido)
            cmd.Parameters.AddWithValue("@ci", encargado.ci)
            cmd.Parameters.AddWithValue("@edad", encargado.edad)
            cmd.Parameters.AddWithValue("@ocup", encargado.ocupacion)
            cmd.Parameters.AddWithValue("@tel", encargado.telefono)

            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub actualizarEncargado(ByVal encargado As Encargado)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim query = "UPDATE `encargado` SET  `nombre_encargado` = @nombre, `apellido_encargado` = @apellido, `ci_encargado` = @ci, `edad_encargado` = @edad, `ocupacion_encargado` = @ocupacion, `telefono_encargado` = @tel WHERE `id_cliente` = @id;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ci", encargado.ci)
            cmd.Parameters.AddWithValue("@nombre", encargado.nombre)
            cmd.Parameters.AddWithValue("@apellido", encargado.apellido)
            cmd.Parameters.AddWithValue("@edad", encargado.edad)
            cmd.Parameters.AddWithValue("@ocupacion", encargado.ocupacion)
            cmd.Parameters.AddWithValue("@tel", encargado.telefono)
            cmd.Parameters.AddWithValue("@id", encargado.cliente)



            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub actualizarFicha(ByVal ficha As FichaM)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim query = "UPDATE `ficha_cliente` SET  `antece_padre` = @antP, `antece_madre` = @antM, `antece_hermanos` = @antH , `antece_hijos` = @antHj," _
                        & " `ante_cardio` = @antCard, `ante_respiratorio` = @antResp, `ante_alergico` = @antAlerg, `ante_neoplas` = @antNeop, " _
                        & " `ante_digest` = @antDig, `ante_genito` = @antGeni, `ante_asmatico` = @antAsma, `ante_metabolico` = @antMeta, " _
                        & " `ante_osteo` = @antOsteo, `ante_neuro` = @antNeuro, `ante_internaciones` = @antInterna, `ante_cirugia` = @antCiru, `ante_psicolo` = @antPsico, " _
                        & "`ante_visuales` = @antAuvi, `ante_transfu` = @antTransfu, `otros` = @otros WHERE `id_ficha` = @id;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@antP", ficha.anteP)

            cmd.Parameters.AddWithValue("@antM", ficha.anteM)
            cmd.Parameters.AddWithValue("@antH", ficha.anteH)
            cmd.Parameters.AddWithValue("@antHj", ficha.anteHj)
            cmd.Parameters.AddWithValue("@antCard", ficha.anteCardio)
            cmd.Parameters.AddWithValue("@antResp", ficha.anteResp)
            cmd.Parameters.AddWithValue("@antAlerg", ficha.anteAlerg)
            cmd.Parameters.AddWithValue("@antNeop", ficha.anteNeop)
            cmd.Parameters.AddWithValue("@antDig", ficha.anteDig)
            cmd.Parameters.AddWithValue("@antGeni", ficha.anteGenit)
            cmd.Parameters.AddWithValue("@antAsma", ficha.anteAsm)
            cmd.Parameters.AddWithValue("@antMeta", ficha.anteMeta)
            cmd.Parameters.AddWithValue("@antOsteo", ficha.anteOsteo)
            cmd.Parameters.AddWithValue("@antNeuro", ficha.anteNeuro)

            cmd.Parameters.AddWithValue("@antInterna", ficha.anteInter)
            cmd.Parameters.AddWithValue("@antCiru", ficha.anteCiru)
            cmd.Parameters.AddWithValue("@antPsico", ficha.antePsico)
            cmd.Parameters.AddWithValue("@antAuvi", ficha.anteAudioV)
            cmd.Parameters.AddWithValue("@antTransfu", ficha.anteTransfu)
            cmd.Parameters.AddWithValue("@otros", ficha.anteOtros)
            cmd.Parameters.AddWithValue("@id", ficha.id)
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function cargarHistorial(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM historialview where IDF = " & id & ""
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function cargarRegistrosTratamientos(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM historialview where IDT = " & id & ""
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function cargarTratamientos(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT id_tratamiento as ID, id_ficha as Ficha,nombre_tratamiento as Tratamiento,fecha_inicio as `Fecha Inicio` FROM tratamiento_ficha where id_ficha = " & id & ""
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
End Class
