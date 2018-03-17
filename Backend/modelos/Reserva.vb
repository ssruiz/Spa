Public Class Reserva

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _cliente As Integer
    Public Property cliente() As Integer
        Get
            Return _cliente
        End Get
        Set(ByVal value As Integer)
            _cliente = value
        End Set
    End Property

    Private _horaInicio As String
    Public Property horaInicio() As String
        Get
            Return _horaInicio
        End Get
        Set(ByVal value As String)
            _horaInicio = value
        End Set
    End Property

    Private _horaFin As String
    Public Property horaFin() As String
        Get
            Return _horaFin
        End Get
        Set(ByVal value As String)
            _horaFin = value
        End Set
    End Property

    Private _clienteNombre As String
    Public Property clienteNombre() As String
        Get
            Return _clienteNombre
        End Get
        Set(ByVal value As String)
            _clienteNombre = value
        End Set
    End Property

    Private _comentario As String
    Public Property comentario() As String
        Get
            Return _comentario
        End Get
        Set(ByVal value As String)
            _comentario = value
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

    Private _tag As Integer
    Public Property tag() As Integer
        Get
            Return _tag
        End Get
        Set(ByVal value As Integer)
            _tag = value
        End Set
    End Property

    Private _encargado As Integer
    Public Property encargado() As Integer
        Get
            Return _encargado
        End Get
        Set(ByVal value As Integer)
            _encargado = value
        End Set
    End Property
End Class
