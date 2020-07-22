Namespace PaySafe.Payment

    Public Class [verifications] : Implements IDisposable

        Private _id As String
        '''<summary> 
        '''This is the ID returned in the response. This ID can be used for future associated requests.         
        '''</summary> 
        '''<returns></returns> 
        Public Property [id] As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property

        Private _merchantRefNum As String
        '''<summary> 
        '''This Is the merchant reference number created by the merchant And submitted as part of the request. It must be unique for each request.         
        '''</summary> 
        '''<returns></returns> 
        Public Property [merchantRefNum] As String
            Get
                Return _merchantRefNum
            End Get
            Set(value As String)
                _merchantRefNum = value
            End Set
        End Property

        Private _childAccountNum As String
        '''<summary> 
        '''This Is the child merchant account number. It Is returned only if the transaction was processed via a master account.         
        '''</summary> 
        '''<returns></returns> 
        Public Property [childAccountNum] As String
            Get
                Return _childAccountNum
            End Get
            Set(value As String)
                _childAccountNum = value
            End Set
        End Property

        Private _card As card
        '''<summary> 
        '''These are the details Of the card used.
        '''</summary> 
        '''<returns></returns> 
        Public Property [card] As card
            Get
                Return _card
            End Get
            Set(value As card)
                _card = value
            End Set
        End Property

        Private _authCode As String
        '''<summary> 
        ''' This Is the Authorization code assigned by the issuing bank And returned in the response.         
        '''</summary> 
        '''<returns></returns> 
        Public Property [authCode] As String
            Get
                Return _authCode
            End Get
            Set(value As String)
                _authCode = value
            End Set
        End Property

        Private _profile As profile
        '''<summary> 
        '''These are some details about the customer.
        '''</summary> 
        '''<returns></returns> 
        Public Property [profile] As profile
            Get
                Return _profile
            End Get
            Set(value As profile)
                _profile = value
            End Set
        End Property

        Private _billingDetails As billingDetails
        '''<summary> 
        '''These are the billing details For the request.
        '''</summary> 
        '''<returns></returns> 
        Public Property [billingDetails] As billingDetails
            Get
                Return _billingDetails
            End Get
            Set(value As billingDetails)
                _billingDetails = value
            End Set
        End Property

        Private _customerIp As String
        '''<summary> 
        '''This Is the customer's IP address.         
        '''</summary> 
        '''<returns></returns> 
        Public Property [customerIp] As String
            Get
                Return _customerIp
            End Get
            Set(value As String)
                _customerIp = value
            End Set
        End Property

        Private _dupCheck As Boolean
        '''<summary> 
        ''' This validates that this request Is Not a duplicate. A request Is considered a duplicate If themerchantRefNumhas already been used In a previous request within the past 90 days.
        ''' Note:This value defaults totrue.
        '''</summary> 
        '''<returns></returns> 
        Public Property [dupCheck] As Boolean
            Get
                Return _dupCheck
            End Get
            Set(value As Boolean)
                _dupCheck = value
            End Set
        End Property

        Private _description As String
        '''<summary> 
        '''This Is a description of the transaction, provided by the merchant.         
        '''</summary> 
        '''<returns></returns> 
        Public Property [description] As String
            Get
                Return _description
            End Get
            Set(value As String)
                _description = value
            End Set
        End Property

        Private _txnTime As Date
        '''<summary> 
        ''' This Is the date And time the request was processed. For example
        ''' 2014-01-26T10:32:28Z
        '''</summary> 
        '''<returns></returns> 
        Public Property [txnTime] As Date
            Get
                Return _txnTime
            End Get
            Set(value As Date)
                _txnTime = value
            End Set
        End Property

        Private _currencyCode As String
        '''<summary> 
        '''This Is the currency of the merchant account, e.g., USD Or CAD, returned in the request response. SeeCurrency Codes         
        '''</summary> 
        '''<returns></returns> 
        Public Property [currencyCode] As String
            Get
                Return _currencyCode
            End Get
            Set(value As String)
                _currencyCode = value
            End Set
        End Property

        Private _avsResponse As tavsResponse
        '''<summary> 
        '''This Is the AVS response from the card issuer. Possible values are
        '''MATCH
        '''MATCH_ADDRESS_ONLY
        '''MATCH_ZIP_ONLY
        '''NO_MATCH
        '''NOT_PROCESSED
        '''UNKNOWN
        '''</summary> 
        '''<returns></returns> 
        Public Property [avsResponse] As tavsResponse
            Get
                Return _avsResponse
            End Get
            Set(value As tavsResponse)
                _avsResponse = value
            End Set
        End Property

        Private _cvvVerification As tcvvVerification
        '''<summary> 
        '''This Is the response to thecvvsubmitted with the transaction request. Possible values are
        '''MATCH
        '''NO_MATCH
        '''NOT_PROCESSED
        '''UNKNOWN
        '''</summary> 
        '''<returns></returns> 
        Public Property [cvvVerification] As tcvvVerification
            Get
                Return _cvvVerification
            End Get
            Set(value As tcvvVerification)
                _cvvVerification = value
            End Set
        End Property

        Private _error As [error]
        '''<summary> 
        '''</summary> 
        '''<returns></returns> 
        Public Property [error] As [error]
            Get
                Return _error
            End Get
            Set(value As [error])
                _error = value
            End Set
        End Property

        Private _status As tverificationStatus
        '''<summary> 
        '''This Is the status of the transaction request. Possible values are:
        '''RECEIVED  Our system has received the request And Is waiting For the downstream processors response.
        '''COMPLETED  The transaction has been completed.
        '''FAILED  The transaction failed, due To either an Error Or being declined.
        '''</summary> 
        '''<returns></returns> 
        Public Property [status] As tverificationStatus
            Get
                Return _status
            End Get
            Set(value As tverificationStatus)
                _status = value
            End Set
        End Property

        Private _riskReasonCode As String
        '''<summary> 
        ''' An array Of integers Is returned, displaying the detailed Risk reason codes If your transaction was declined. It Is returned only If your account Is configured accordingly.
        '''</summary> 
        '''<returns></returns> 
        Public Property [riskReasonCode] As String
            Get
                Return _riskReasonCode
            End Get
            Set(value As String)
                _riskReasonCode = value
            End Set
        End Property

        Private _acquirerResponse As acquirerResponse
        '''<summary> 
        '''This Is the raw response returned by an acquirer. It Is returned only if your account Is configured accordingly.
        '''</summary> 
        '''<returns></returns> 
        Public Property [acquirerResponse] As acquirerResponse
            Get
                Return _acquirerResponse
            End Get
            Set(value As acquirerResponse)
                _acquirerResponse = value
            End Set
        End Property

        Private _storedCredential As storedCredential
        '''<summary> 
        ''' Identifies requests that use stored credentials that the merchant has On file For the consumer, In order To improve authorization rates And reduce fraud.
        ''' Note:You cannot include both therecurringparameter And thestoredCredentialobject In the same authorization request. Paysafe recommends Using thestoredCredentialobject.
        '''</summary> 
        '''<returns></returns> 
        Public Property [storedCredential] As storedCredential
            Get
                Return _storedCredential
            End Get
            Set(value As storedCredential)
                _storedCredential = value
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
