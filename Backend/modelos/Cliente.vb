Public Class Cliente
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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


    Private _ruc As String
    Public Property ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
        End Set
    End Property

    Private _tel As String
    Public Property tel() As String
        Get
            Return _tel
        End Get
        Set(ByVal value As String)
            _tel = value
        End Set
    End Property

    Private _cel As String
    Public Property cel() As String
        Get
            Return _cel
        End Get
        Set(ByVal value As String)
            _cel = value
        End Set
    End Property

    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property


    Private _sex As String
    Public Property sex() As String
        Get
            Return _sex
        End Get
        Set(ByVal value As String)
            _sex = value
        End Set
    End Property

    Private _estadoC As String
    Public Property estadoC() As String
        Get
            Return _estadoC
        End Get
        Set(ByVal value As String)
            _estadoC = value
        End Set
    End Property

    Private _fechaAlta As Date
    Public Property fechaAlta() As Date
        Get
            Return _fechaAlta
        End Get
        Set(ByVal value As Date)
            _fechaAlta = value
        End Set
    End Property

    Private _fechaNaci As Date
    Public Property fechaNaci() As Date
        Get
            Return _fechaNaci
        End Get
        Set(ByVal value As Date)
            _fechaNaci = value
        End Set
    End Property

    Private _dir As String
    Public Property dir() As String
        Get
            Return _dir
        End Get
        Set(ByVal value As String)
            _dir = value
        End Set
    End Property


    Private _dirDep As String
    Public Property dirDep() As String
        Get
            Return _dirDep
        End Get
        Set(ByVal value As String)
            _dirDep = value
        End Set
    End Property


    Private _dirCiudad As String
    Public Property dirCiudad() As String
        Get
            Return _dirCiudad
        End Get
        Set(ByVal value As String)
            _dirCiudad = value
        End Set
    End Property


    Private _dirBarrio As String
    Public Property dirBarrio() As String
        Get
            Return _dirBarrio
        End Get
        Set(ByVal value As String)
            _dirBarrio = value
        End Set
    End Property

    Private _nacio As String
    Public Property nacio() As String
        Get
            Return _nacio
        End Get
        Set(ByVal value As String)
            _nacio = value
        End Set
    End Property
End Class
