Public Class applePayPaymentToken

    Private _data As String
    ''' <summary> 
    '''This is the encrypted payment data.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property data As String
        Get
            Return _data
        End Get
        Set(value As String)
            _data = value
        End Set
    End Property

    Private _header As String
    ''' <summary> 
    '''This is additional version-dependent information used to decrypt and verify the payment.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property header As String
        Get
            Return _header
        End Get
        Set(value As String)
            _header = value
        End Set
    End Property

    Private _signature As String
    ''' <summary> 
    '''This is the signature of the payment and header data.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property signature As String
        Get
            Return _signature
        End Get
        Set(value As String)
            _signature = value
        End Set
    End Property

    Private _version As String
    ''' <summary> 
    '''This is version information about the payments token. Value is "EC_v1".
    ''' </summary> 
    ''' <returns></returns> 
    Public Property version As String
        Get
            Return _version
        End Get
        Set(value As String)
            _version = value
        End Set
    End Property

End Class
