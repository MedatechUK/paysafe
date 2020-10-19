Namespace PaySafe.Payment

    Public Class [originalcredits] : Implements IDisposable

        Private _id As String
        ''' <summary> 
        ''' This is the ID returned in the response. This ID can be used for future associated requests.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [id] As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property

        Private _merchantRefNum As String
        ''' <summary> 
        ''' This is the merchant reference number created by the merchant and submitted as part of the request. It must be unique for each request.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [merchantRefNum] As String
            Get
                Return _merchantRefNum
            End Get
            Set(value As String)
                _merchantRefNum = value
            End Set
        End Property

        Private _amount As String
        ''' <summary> 
        ''' This is the amount of the request, in minor units. For example, to process US $10.99, this value should be 1099. To process 1000 Japanese yen, this value should be 1000. To process 10.139 Tunisian dinar, this value should be 10139.
        ''' Note:�If the merchant account is set up for a currency that has 3 decimal units, our system will half round up the least significant digit.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [amount] As String
            Get
                Return _amount
            End Get
            Set(value As String)
                _amount = value
            End Set
        End Property

        Private _childAccountNum As String
        ''' <summary> 
        ''' This is the child merchant account number. It is returned only if the transaction was processed via a master account.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [childAccountNum] As String
            Get
                Return _childAccountNum
            End Get
            Set(value As String)
                _childAccountNum = value
            End Set
        End Property

        Private _card As New card
        ''' <summary> 
        ''' These are the details of the card used.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [card] As card
            Get
                Return _card
            End Get
            Set(value As card)
                _card = value
            End Set
        End Property

        Private _authCode As String
        ''' <summary> 
        ''' This is the Authorization code assigned by the issuing bank and returned in the response.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [authCode] As String
            Get
                Return _authCode
            End Get
            Set(value As String)
                _authCode = value
            End Set
        End Property

        Private _profile As profile
        ''' <summary> 
        ''' These are some details about the customer.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [profile] As profile
            Get
                Return _profile
            End Get
            Set(value As profile)
                _profile = value
            End Set
        End Property

        Private _billingDetails As billingDetails
        ''' <summary> 
        ''' These are the billing details for the request.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [billingDetails] As billingDetails
            Get
                Return _billingDetails
            End Get
            Set(value As billingDetails)
                _billingDetails = value
            End Set
        End Property

        Private _customerIp As String
        ''' <summary> 
        ''' This is the customer's IP address.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [customerIp] As String
            Get
                Return _customerIp
            End Get
            Set(value As String)
                _customerIp = value
            End Set
        End Property

        Private _dupCheck As Boolean
        ''' <summary> 
        ''' This validates that this request is not a duplicate. A request is considered a duplicate if the�merchantRefNum�has already been used in a previous request within the past 90 days.
        ''' Note:�This value defaults to�true.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [dupCheck] As Boolean
            Get
                Return _dupCheck
            End Get
            Set(value As Boolean)
                _dupCheck = value
            End Set
        End Property

        Private _description As String
        ''' <summary> 
        ''' This is a description of the transaction, provided by the merchant.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [description] As String
            Get
                Return _description
            End Get
            Set(value As String)
                _description = value
            End Set
        End Property

        Private _txnTime As Date?
        ''' <summary> 
        ''' This is the date and time the request was processed. For example:
        ''' 2014-01-26T10:32:28Z
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [txnTime] As Date?
            Get
                Return _txnTime
            End Get
            Set(value As Date?)
                _txnTime = value
            End Set
        End Property

        Private _currencyCode As String
        ''' <summary> 
        ''' This is the currency of the merchant account, e.g., USD or CAD, returned in the request response. See�Currency Codes
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [currencyCode] As String
            Get
                Return _currencyCode
            End Get
            Set(value As String)
                _currencyCode = value
            End Set
        End Property

        Private _error As [error]
        ''' <summary> 
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [error] As [error]
            Get
                Return _error
            End Get
            Set(value As [error])
                _error = value
            End Set
        End Property

        Private _status As tocStatus?
        ''' <summary> 
        ''' This is the status of the transaction request. Possible values are:
        ''' RECEIVED � Our system has received the request and is waiting for the downstream processor�s response.
        ''' COMPLETED � The transaction has been completed.
        ''' PENDING � Our system has received the request but it has not yet been batched.
        ''' FAILED � The transaction failed, due to either an error or being declined.
        ''' CANCELLED � The request has been fully voided (reversed).
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [status] As tocStatus?
            Get
                Return _status
            End Get
            Set(value As tocStatus?)
                _status = value
            End Set
        End Property

        Private _riskReasonCode As String
        ''' <summary> 
        ''' An array of integers is returned, displaying the detailed Risk reason codes if your transaction was declined. It is returned only if your account is configured accordingly.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [riskReasonCode] As String
            Get
                Return _riskReasonCode
            End Get
            Set(value As String)
                _riskReasonCode = value
            End Set
        End Property

        Private _acquirerData As acquirerData
        ''' <summary> 
        ''' This is additional information about your card acquirer, required�only when�you are using Credorax (CRX) as your acquirer for Original Credits. Contact your account manager for more information.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [acquirerData] As acquirerData
            Get
                Return _acquirerData
            End Get
            Set(value As acquirerData)
                _acquirerData = value
            End Set
        End Property

        Private _acquirerResponse As String
        ''' <summary> 
        ''' This is the raw response returned by an acquirer. It is returned only if your account is configured accordingly.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [acquirerResponse] As String
            Get
                Return _acquirerResponse
            End Get
            Set(value As String)
                _acquirerResponse = value
            End Set
        End Property

#Region "Disposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                End If
            End If
            disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
        End Sub
#End Region
    End Class

End Namespace
