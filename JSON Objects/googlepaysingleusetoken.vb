Public Class googlepaysingleusetoken

    Private _googlePayPaymentToken As String
    ''' <summary> 
    '''This is the payment data object generated from the Android device.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property googlePayPaymentToken As String
        Get
            Return _googlePayPaymentToken
        End Get
        Set(value As String)
            _googlePayPaymentToken = value
        End Set
    End Property

    Private _card As String
    ''' <summary> 
    '''These are the details of the virtual card.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property card As String
        Get
            Return _card
        End Get
        Set(value As String)
            _card = value
        End Set
    End Property

    Private _paymentToken As String
    ''' <summary> 
    '''This is the single-use payment token to use in the authorization or purchase request in the Card Payments API.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property paymentToken As String
        Get
            Return _paymentToken
        End Get
        Set(value As String)
            _paymentToken = value
        End Set
    End Property

    Private _timeToLiveSeconds As String
    ''' <summary> 
    '''This is the period of time the single-use token is valid before expiration, in seconds, returned in the response.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property timeToLiveSeconds As String
        Get
            Return _timeToLiveSeconds
        End Get
        Set(value As String)
            _timeToLiveSeconds = value
        End Set
    End Property

End Class
