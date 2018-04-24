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

    Private _total As Double
    Public Property total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    Private _entrega As Double
    Public Property entrega() As Double
        Get
            Return _entrega
        End Get
        Set(ByVal value As Double)
            _entrega = value
        End Set
    End Property

    Private _saldo As Double
    Public Property saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
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

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _descuento As Double
    Public Property descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
        End Set
    End Property

    Private _formaPago As String
    Public Property formaPago() As String
        Get
            Return _formaPago
        End Get
        Set(ByVal value As String)
            _formaPago = value
        End Set
    End Property
End Class
