Public Class SesionP

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _reservap As Integer
    Public Property reservap() As Integer
        Get
            Return _reservap
        End Get
        Set(ByVal value As Integer)
            _reservap = value
        End Set
    End Property

    Private _servicio As Integer
    Public Property servicio() As Integer
        Get
            Return _servicio
        End Get
        Set(ByVal value As Integer)
            _servicio = value
        End Set
    End Property


    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property



    Private _estado As String
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Private _tag As Integer
    Public Property tag() As Integer
        Get
            Return _tag
        End Get
        Set(ByVal value As Integer)
            _tag = value
        End Set
    End Property

    Private _horaInicio As TimeSpan
    Public Property horaInicio() As TimeSpan
        Get
            Return _horaInicio
        End Get
        Set(ByVal value As TimeSpan)
            _horaInicio = value
        End Set
    End Property
End Class
