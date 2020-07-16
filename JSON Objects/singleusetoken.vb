Public Class singleusetoken

    Private _card As String
    ''' <summary> 
    '''These are the details of the card.
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

    Private _billingAddress As billingAddress
    ''' <summary> 
    '''This is the billing address associated with the card.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property billingAddress As billingAddress
        Get
            Return _billingAddress
        End Get
        Set(value As billingAddress)
            _billingAddress = value
        End Set
    End Property

    Private _paymentToken As String
    ''' <summary> 
    '''This is the single-use payment token for the mobile device.
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
