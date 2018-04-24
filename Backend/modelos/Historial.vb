Public Class Historial
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _idFicha As Integer
    Public Property idFicha() As Integer
        Get
            Return _idFicha
        End Get
        Set(ByVal value As Integer)
            _idFicha = value
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
    Private _enfermedad As String
    Public Property enfermedad() As String
        Get
            Return _enfermedad
        End Get
        Set(ByVal value As String)
            _enfermedad = value
        End Set
    End Property

    Private _peso As String
    Public Property peso() As String
        Get
            Return _peso
        End Get
        Set(ByVal value As String)
            _peso = value
        End Set
    End Property

    Private _pesoI As String
    Public Property pesoI() As String
        Get
            Return _pesoI
        End Get
        Set(ByVal value As String)
            _pesoI = value
        End Set
    End Property

    Private _altura As String
    Public Property altura() As String
        Get
            Return _altura
        End Get
        Set(ByVal value As String)
            _altura = value
        End Set
    End Property

    Private _imc As String
    Public Property imc() As String
        Get
            Return _imc
        End Get
        Set(ByVal value As String)
            _imc = value
        End Set
    End Property

    Private _cinth As String
    Public Property cinth() As String
        Get
            Return _cinth
        End Get
        Set(ByVal value As String)
            _cinth = value
        End Set
    End Property

    Private _omb As String
    Public Property omb() As String
        Get
            Return _omb
        End Get
        Set(ByVal value As String)
            _omb = value
        End Set
    End Property

    Private _bomb As String
    Public Property bomb() As String
        Get
            Return _bomb
        End Get
        Set(ByVal value As String)
            _bomb = value
        End Set
    End Property

    Private _pd As String
    Public Property pd() As String
        Get
            Return _pd
        End Get
        Set(ByVal value As String)
            _pd = value
        End Set
    End Property

    Private _bd As String
    Public Property bd() As String
        Get
            Return _bd
        End Get
        Set(ByVal value As String)
            _bd = value
        End Set
    End Property

    Private _pi As String
    Public Property pi() As String
        Get
            Return _pi
        End Get
        Set(ByVal value As String)
            _pi = value
        End Set
    End Property

    Private _bi As String
    Public Property bi() As String
        Get
            Return _bi
        End Get
        Set(ByVal value As String)
            _bi = value
        End Set
    End Property
End Class
