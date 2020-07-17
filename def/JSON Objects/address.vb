Public Class address : Implements IDisposable

    Private _id As String
    ''' <summary> 
    '''This is the ID for the request.
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
    '''This is an alias defined by the customer for this address (e.g., "home address").
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

    Private _street As String
    ''' <summary> 
    '''This is the first line of the customer's street address.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property street As String
        Get
            Return _street
        End Get
        Set(value As String)
            _street = value
        End Set
    End Property

    Private _street2 As String
    ''' <summary> 
    '''  This is the second line of the customer's street address, if required (e.g., apartment number).
    ''' </summary> 
    ''' <returns></returns> 
    Public Property street2 As String
        Get
            Return _street2
        End Get
        Set(value As String)
            _street2 = value
        End Set
    End Property

    Private _city As String
    ''' <summary> 
    '''  This is the city where the address is located.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property city As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Private _country As tCountry
    ''' <summary> 
    '''  This is the country where the address is located. See Country Codes.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property country As tCountry
        Get
            Return _country
        End Get
        Set(value As tCountry)
            _country = value
        End Set
    End Property

    Private _state As String
    ''' <summary> 
    '''This is the state/province/region in which the customer lives.
    '''For Canada see Province Codes. For the United States see State Codes. Other countries have no restrictions.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property state As String
        Get
            Return _state
        End Get
        Set(value As String)
            _state = value
        End Set
    End Property

    Private _zip As String
    ''' <summary> 
    '''  This is the zip, postal, or post code of the customer's address.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property zip As String
        Get
            Return _zip
        End Get
        Set(value As String)
            _zip = value
        End Set
    End Property

    Private _recipientName As String
    ''' <summary> 
    '''  This is the name of the recipient at this address, if it is different from the name in the profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property recipientName As String
        Get
            Return _recipientName
        End Get
        Set(value As String)
            _recipientName = value
        End Set
    End Property

    Private _phone As String
    ''' <summary> 
    '''  This is the phone number to contact the recipient at this address, if it is different from the phone number in the profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Private _status As String
    ''' <summary> 
    ''' This is the status of the address. Possible values are:
    ''' ACTIVE
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

    Private _defaultShippingAddressIndicator As String
    ''' <summary> 
    '''  Flag to mark this address as the default shipping address.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property defaultShippingAddressIndicator As String
        Get
            Return _defaultShippingAddressIndicator
        End Get
        Set(value As String)
            _defaultShippingAddressIndicator = value
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
