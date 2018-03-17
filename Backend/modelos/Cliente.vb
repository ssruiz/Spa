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
End Class
