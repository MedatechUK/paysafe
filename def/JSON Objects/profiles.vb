Public Class profiles : Implements IDisposable

    Private _id As String
    ''' <summary> 
    '''This is the ID returned in the response.
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

    Private _status As String
    ''' <summary> 
    '''This is the status of the customer profile. Possible values are:
    '''INITIAL
    '''ACTIVE
    '''By default the system automatically sets the profile status to an ACTIVE state. 
    '''If you want to prevent the profile from being used for payments, you can set the 
    '''status to an INITIAL state (e.g., in cases where you first want to validate the customer).
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

    Private _merchantCustomerId As String
    ''' <summary> 
    '''This is a customer ID that the merchant provides with the request for their own internal customer identification. 
    '''This value must be unique for each customer belonging to a merchant. In NETBANX this is known as the Ref ID.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property merchantCustomerId As String
        Get
            Return _merchantCustomerId
        End Get
        Set(value As String)
            _merchantCustomerId = value
        End Set
    End Property

    Private _locale As tlocale
    ''' <summary> 
    '''This indicates the language of the profile. Possible values are:
    '''en_US
    '''fr_CA
    '''en_GB
    ''' </summary> 
    ''' <returns></returns> 
    Public Property locale As tlocale
        Get
            Return _locale
        End Get
        Set(value As tlocale)
            _locale = value
        End Set
    End Property

    Private _firstName As String
    ''' <summary> 
    '''This is the customer’s first name.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property firstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Private _middleName As String
    ''' <summary> 
    '''This is the customer’s middle name.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property middleName As String
        Get
            Return _middleName
        End Get
        Set(value As String)
            _middleName = value
        End Set
    End Property

    Private _lastName As String
    ''' <summary> 
    '''This is the customer’s last name.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property lastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Private _dateOfBirth As dateOfBirth
    ''' <summary> 
    '''This is the customer's date of birth.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property dateOfBirth As dateOfBirth
        Get
            Return _dateOfBirth
        End Get
        Set(value As dateOfBirth)
            _dateOfBirth = value
        End Set
    End Property
    Private _ip As String
    ''' <summary> 
    '''This is the customer’s IP address.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property ip As String
        Get
            Return _ip
        End Get
        Set(value As String)
            _ip = value
        End Set
    End Property

    Private _gender As tGender
    ''' <summary> 
    '''This is the customer’s gender. Possible values are:
    '''M (male)
    '''F (female)
    ''' </summary> 
    ''' <returns></returns> 
    Public Property gender As tGender
        Get
            Return _gender
        End Get
        Set(value As tGender)
            _gender = value
        End Set
    End Property

    Private _nationality As String
    ''' <summary> 
    '''This is the customer’s nationality.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property nationality As String
        Get
            Return _nationality
        End Get
        Set(value As String)
            _nationality = value
        End Set
    End Property

    Private _email As String
    ''' <summary> 
    '''This is the customer's email address.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Private _phone As String
    ''' <summary> 
    '''This is the customer's phone number.
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

    Private _cellPhone As String
    ''' <summary> 
    '''This is the customer's cell phone number.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property cellPhone As String
        Get
            Return _cellPhone
        End Get
        Set(value As String)
            _cellPhone = value
        End Set
    End Property

    Private _paymentToken As String
    ''' <summary> 
    '''This is a token generated by Paysafe that represents the customer and returned in the response to the profile request.
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

    Private _address As New List(Of address)
    ''' <summary> 
    '''These are the address associated with this profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property address As List(Of address)
        Get
            Return _address
        End Get
        Set(value As List(Of address))
            _address = value
        End Set
    End Property

    Private _card As New List(Of cards)
    ''' <summary> 
    '''These are the cards associated with this profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property card As List(Of cards)
        Get
            Return _card
        End Get
        Set(value As List(Of cards))
            _card = value
        End Set
    End Property

    Private _achbankaccounts As New List(Of achBankAccount)
    ''' <summary> 
    '''These are the ACH bank accounts associated with this profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property achbankaccounts As List(Of achBankAccount)
        Get
            Return _achbankaccounts
        End Get
        Set(value As List(Of achBankAccount))
            _achbankaccounts = value
        End Set
    End Property

    Private _bacsbankaccounts As New List(Of bacsBankAccount)
    ''' <summary> 
    '''These are the BACS bank accounts associated with this profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property bacsbankaccounts As List(Of bacsBankAccount)
        Get
            Return _bacsbankaccounts
        End Get
        Set(value As List(Of bacsBankAccount))
            _bacsbankaccounts = value
        End Set
    End Property

    Private _eftbankaccounts As New List(Of eftBankAccount)
    ''' <summary> 
    '''These are the EFT bank accounts associated with this profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property eftbankaccounts As List(Of eftBankAccount)
        Get
            Return _eftbankaccounts
        End Get
        Set(value As List(Of eftBankAccount))
            _eftbankaccounts = value
        End Set
    End Property

    Private _sepabankaccounts As New List(Of sepaBankAccount)
    ''' <summary> 
    '''These are the SEPA bank accounts associated with this profile.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property sepabankaccounts As List(Of sepaBankAccount)
        Get
            Return _sepabankaccounts
        End Get
        Set(value As List(Of sepaBankAccount))
            _sepabankaccounts = value
        End Set
    End Property

    Private _recipient As recipient
    ''' <summary> 
    '''This allows additional data to be included with a profile and then used in an Authorization request using a payment token in the Card Payments API.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property recipient As recipient
        Get
            Return _recipient
        End Get
        Set(value As recipient)
            _recipient = value
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
