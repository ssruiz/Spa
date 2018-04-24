Public Class PasarInfo
    Inherits EventArgs

    Private _tabla As DataTable
    Private _ds As DataSet
    Public Sub New()
        'I do not want to have the readonly property return a null reference (Nothing)
        'so I protect against that here.
        _tabla = New DataTable("tabla")
        Dim column As DataColumn


        ' Create new DataColumn, set DataType, ColumnName 
        ' and add to DataTable.    
        column = New DataColumn()

        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "ID"
        column.ReadOnly = True
        column.Unique = True
        _tabla.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Nombre"
        column.ReadOnly = True
        column.Unique = False
        _tabla.Columns.Add(column)

        Dim PrimaryKeyColumns(0) As DataColumn
        PrimaryKeyColumns(0) = tabla.Columns("ID")
        tabla.PrimaryKey = PrimaryKeyColumns
        _ds = New DataSet
        _ds.Tables.Add(tabla)
    End Sub

    Public ReadOnly Property tabla As DataTable
        Get
            Return _tabla
        End Get
    End Property

    Public ReadOnly Property ds As DataSet
        Get
            Return _ds
        End Get
    End Property

    Public Sub cargarDato(ByVal list As DataSet, ByVal nombre As String)
        Try
            'Dim row = tabla.NewRow
            'row("ID") = id
            'row("Nombre") = nombre
            _tabla.Merge(list.Tables("tabla"))
        Catch ex As System.Data.ConstraintException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
        End Try

        '_ds.Tables.Add(_tabla)
    End Sub
End Class
