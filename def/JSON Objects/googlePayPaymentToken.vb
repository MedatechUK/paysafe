Namespace PaySafe
    Public Class googlePayPaymentToken : Implements IDisposable

    Private _signature As String
    ''' <summary> 
    '''This is the signature of the payment data.
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

    Private _protocolVersion As String
    ''' <summary> 
    '''This is version information about the payments token.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property protocolVersion As String
        Get
            Return _protocolVersion
        End Get
        Set(value As String)
            _protocolVersion = value
        End Set
    End Property

    Private _signedMessage As String
    ''' <summary> 
    '''This is a UTF-8 encoded, serialized JSON dictionary with values for encryptedMessage, ephemeralPublicKey, and tag.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property signedMessage As String
        Get
            Return _signedMessage
        End Get
        Set(value As String)
            _signedMessage = value
        End Set
    End Property

    Private _ephemeralPublicKey As String
    ''' <summary> 
    '''This is the ephemeral public key associated with the private key to encrypt the message.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property ephemeralPublicKey As String
        Get
            Return _ephemeralPublicKey
        End Get
        Set(value As String)
            _ephemeralPublicKey = value
        End Set
    End Property

    Private _tag As String
    ''' <summary> 
    '''This is the MAC (media access control) of the encryptedMessage, which is used to verify the integrity of the encryptedMessage.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property tag As String
        Get
            Return _tag
        End Get
        Set(value As String)
            _tag = value
        End Set
    End Property

    Private _authMethod As String
    ''' <summary> 
    '''This is a constant for 3D Secure requests.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property authMethod As String
        Get
            Return _authMethod
        End Get
        Set(value As String)
            _authMethod = value
        End Set
    End Property

    Private _tdsCryptogram As String
    ''' <summary> 
    '''This is the 3D Secure cryptogram.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property tdsCryptogram As String
        Get
            Return _tdsCryptogram
        End Get
        Set(value As String)
            _tdsCryptogram = value
        End Set
    End Property

    Private _tdsEciIndicator As String
    ''' <summary> 
    '''This is the 3D Secure ECI indicator.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property tdsEciIndicator As String
        Get
            Return _tdsEciIndicator
        End Get
        Set(value As String)
            _tdsEciIndicator = value
        End Set
    End Property

    Private _paymentMethod As String
    ''' <summary> 
    '''This indicates the status of the card.
    '''TOKENIZED_CARD – The card has been tokenized with Android Pay
    '''CARD_ON_FILE – The card has been stored by Google
    ''' </summary> 
    ''' <returns></returns> 
    Public Property paymentMethod As String
        Get
            Return _paymentMethod
        End Get
        Set(value As String)
            _paymentMethod = value
        End Set
    End Property

    Private _messageId As String
    ''' <summary> 
    '''This is a unique ID to identify the message in case it needs to be located later.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property messageId As String
        Get
            Return _messageId
        End Get
        Set(value As String)
            _messageId = value
        End Set
    End Property

    Private _messageExpiration As String
    ''' <summary> 
    '''This is the length of time, in seconds, the message is valid.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property messageExpiration As String
        Get
            Return _messageExpiration
        End Get
        Set(value As String)
            _messageExpiration = value
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

End Namespace