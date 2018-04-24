Public Class FichaM
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _idCliente As Integer
    Public Property idCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private _anteM As String
    Public Property anteM() As String
        Get
            Return _anteM
        End Get
        Set(ByVal value As String)
            _anteM = value
        End Set
    End Property

    Private _anteP As String
    Public Property anteP() As String
        Get
            Return _anteP
        End Get
        Set(ByVal value As String)
            _anteP = value
        End Set
    End Property

    Private _anteH As String
    Public Property anteH() As String
        Get
            Return _anteH
        End Get
        Set(ByVal value As String)
            _anteH = value
        End Set
    End Property

    Private _anteHj As String
    Public Property anteHj() As String
        Get
            Return _anteHj
        End Get
        Set(ByVal value As String)
            _anteHj = value
        End Set
    End Property


    Private _anteCardio As Boolean
    Public Property anteCardio() As Boolean
        Get
            Return _anteCardio
        End Get
        Set(ByVal value As Boolean)
            _anteCardio = value
        End Set
    End Property

    Private _anteResp As Boolean
    Public Property anteResp() As Boolean
        Get
            Return _anteResp
        End Get
        Set(ByVal value As Boolean)
            _anteResp = value
        End Set
    End Property

    Private _anteAlerg As Boolean
    Public Property anteAlerg() As Boolean
        Get
            Return _anteAlerg
        End Get
        Set(ByVal value As Boolean)
            _anteAlerg = value
        End Set
    End Property

    Private _anteNeop As Boolean
    Public Property anteNeop() As Boolean
        Get
            Return _anteNeop
        End Get
        Set(ByVal value As Boolean)
            _anteNeop = value
        End Set
    End Property

    Private _anteDig As Boolean
    Public Property anteDig() As Boolean
        Get
            Return _anteDig
        End Get
        Set(ByVal value As Boolean)
            _anteDig = value
        End Set
    End Property

    Private _anteGenit As Boolean
    Public Property anteGenit() As Boolean
        Get
            Return _anteGenit
        End Get
        Set(ByVal value As Boolean)
            _anteGenit = value
        End Set
    End Property

    Private _anteAsm As Boolean
    Public Property anteAsm() As Boolean
        Get
            Return _anteAsm
        End Get
        Set(ByVal value As Boolean)
            _anteAsm = value
        End Set
    End Property

    Private _anteMeta As Boolean
    Public Property anteMeta() As Boolean
        Get
            Return _anteMeta
        End Get
        Set(ByVal value As Boolean)
            _anteMeta = value
        End Set
    End Property

    Private _anteOsteo As Boolean
    Public Property anteOsteo() As Boolean
        Get
            Return _anteOsteo
        End Get
        Set(ByVal value As Boolean)
            _anteOsteo = value
        End Set
    End Property

    Private _anteNeuro As Boolean
    Public Property anteNeuro() As Boolean
        Get
            Return _anteNeuro
        End Get
        Set(ByVal value As Boolean)
            _anteNeuro = value
        End Set
    End Property

    Private _anteInter As Boolean
    Public Property anteInter() As Boolean
        Get
            Return _anteInter
        End Get
        Set(ByVal value As Boolean)
            _anteInter = value
        End Set
    End Property

    Private _anteCiru As Boolean
    Public Property anteCiru() As Boolean
        Get
            Return _anteCiru
        End Get
        Set(ByVal value As Boolean)
            _anteCiru = value
        End Set
    End Property

    Private _antePsico As Boolean
    Public Property antePsico() As Boolean
        Get
            Return _antePsico
        End Get
        Set(ByVal value As Boolean)
            _antePsico = value
        End Set
    End Property

    Private _anteAudioV As Boolean
    Public Property anteAudioV() As Boolean
        Get
            Return _anteAudioV
        End Get
        Set(ByVal value As Boolean)
            _anteAudioV = value
        End Set
    End Property

    Private _anteTransfu As Boolean
    Public Property anteTransfu() As Boolean
        Get
            Return _anteTransfu
        End Get
        Set(ByVal value As Boolean)
            _anteTransfu = value
        End Set
    End Property


    Private _anteOtros As String
    Public Property anteOtros() As String
        Get
            Return _anteOtros
        End Get
        Set(ByVal value As String)
            _anteOtros = value
        End Set
    End Property
End Class
