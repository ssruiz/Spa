Public Class Encargado

    Private _cliente As Integer
    Public Property cliente() As Integer
        Get
            Return _cliente
        End Get
        Set(ByVal value As Integer)
            _cliente = value
        End Set
    End Property
    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _apellido As String
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _edad As Integer
    Public Property edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    Private _ci As String
    Public Property ci() As String
        Get
            Return _ci
        End Get
        Set(ByVal value As String)
            _ci = value
        End Set
    End Property

    Private _ocupacion As String
    Public Property ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    Private _telefono As String
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
End Class
