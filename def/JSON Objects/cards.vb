Public Class cards : Implements IDisposable

    Private _id As String
    ''' <summary> 
    '''This is the card ID returned by Paysafe that can be used later to look up or update a card on the profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Private _nickName As String
    ''' <summary> 
    '''This is an alias defined by the customer for this card (e.g., "corporate card").
    ''' </summary> 
    ''' <returns></returns> 
    Public Property nickName As String
        Get
            Return _nickName
        End Get
        Set(value As String)
            _nickName = value
        End Set
    End Property

    Private _merchantRefNum As String
    ''' <summary> 
    '''This is the merchant’s own card identification, which can be included in the request if desired. 
    '''This value is only stored by the Paysafe system and has no bearing on the request.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property merchantRefNum As String
        Get
            Return _merchantRefNum
        End Get
        Set(value As String)
            _merchantRefNum = value
        End Set
    End Property

    Private _holderName As String
    ''' <summary> 
    '''This is the name of the card holder.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property holderName As String
        Get
            Return _holderName
        End Get
        Set(value As String)
            _holderName = value
        End Set
    End Property

    Private _cardNum As String
    ''' <summary> 
    '''This is the card number.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property cardNum As String
        Get
            Return _cardNum
        End Get
        Set(value As String)
            _cardNum = value
        End Set
    End Property

    Private _cardBin As String
    ''' <summary> 
    '''This is the card BIN (typically the first 6 digits).
    ''' </summary> 
    ''' <returns></returns> 
    Public Property cardBin As String
        Get
            Return _cardBin
        End Get
        Set(value As String)
            _cardBin = value
        End Set
    End Property

    Private _lastDigits As String
    ''' <summary> 
    '''This is the last digits of the card number.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property lastDigits As String
        Get
            Return _lastDigits
        End Get
        Set(value As String)
            _lastDigits = value
        End Set
    End Property

    Private _cardExpiry As cardExpiry
    ''' <summary> 
    '''  cardExpiry
    ''' </summary> 
    ''' <returns></returns> 
    Public Property cardExpiry As cardExpiry
        Get
            Return _cardExpiry
        End Get
        Set(value As cardExpiry)
            _cardExpiry = value
        End Set
    End Property

    Private _cardType As String
    ''' <summary> 
    '''This is the type of card associated with the profile. Possible values are:
    '''AM = American Express
    '''DC = Diners Club
    '''DI = Discover
    '''MC = Mastercard
    '''VI =Visa
    ''' </summary> 
    ''' <returns></returns> 
    Public Property cardType As String
        Get
            Return _cardType
        End Get
        Set(value As String)
            _cardType = value
        End Set
    End Property

    Private _cardCategory As String
    ''' <summary> 
    '''This value is determined by the system and returned in the response.
    '''This denotes the card category. Possible values are:
    '''CREDIT = Credit card
    '''DEBIT = Debit card
    '''PREPAID = Prepaid card
    '''UNKNOWN = BIN not found in database
    ''' </summary> 
    ''' <returns></returns> 
    Public Property cardCategory As String
        Get
            Return _cardCategory
        End Get
        Set(value As String)
            _cardCategory = value
        End Set
    End Property

    Private _billingAddress As billingAddress
    ''' <summary> 
    '''  billingAddress
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

    Private _billingAddressId As String
    ''' <summary> 
    '''This is the ID returned in response to the creation of the address that will be associated with this card. 
    '''Note: Although the billingAddressID parameter is optional, it is recommended that you include it when you create the card because Authorization 
    '''or Purchase requests in the Card Payments API that use the resulting payment token will fail AVS checks unless there is a billing address associated with it. 
    '''If you do not include it when creating the card, you should then update the card with the billingAddressId at a later time before using it for transaction requests.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property billingAddressId As String
        Get
            Return _billingAddressId
        End Get
        Set(value As String)
            _billingAddressId = value
        End Set
    End Property

    Private _defaultCardIndicator As Boolean
    ''' <summary> 
    '''This indicates whether this is the default card for this profile, and is returned in the response. 
    '''Possible values are:
    '''TRUE
    '''FALSE
    ''' </summary> 
    ''' <returns></returns> 
    Public Property defaultCardIndicator As Boolean
        Get
            Return _defaultCardIndicator
        End Get
        Set(value As Boolean)
            _defaultCardIndicator = value
        End Set
    End Property

    Private _paymentToken As String
    ''' <summary> 
    '''This is a token generated by Paysafe that represents the card and is returned in the response to the card creation request. 
    '''It can be used for subsequent payments in our payment APIs.
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

    Private _singleUseToken As String
    ''' <summary> 
    '''This is the paymentToken returned in the response to a single-use token creation request. 
    '''You can use this token to create a card to be stored in a customer profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property singleUseToken As String
        Get
            Return _singleUseToken
        End Get
        Set(value As String)
            _singleUseToken = value
        End Set
    End Property

    Private _status As String
    ''' <summary> 
    '''This is the status of the card. 
    '''Possible values are:
    '''ACTIVE
    ''' </summary> 
    ''' <returns></returns> 
    Public Property status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
