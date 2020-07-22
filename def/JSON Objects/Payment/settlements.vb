Namespace PaySafe.Payment

    Public Class [settlements] : Implements IDisposable

        Private _id As String
        '''<summary> 
        '''This is the ID returned in the response. This ID can be used for future associated requests.         
        '''</summary> 
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
        '''<summary> 
        '''This Is the merchant reference number created by the merchant And submitted as part of the request. It must be unique for each request.
        '''</summary> 
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
        '''<summary> 
        ''' This Is the amount of the request, in minor units.For example, to process US $10.99, this value should be 1099. To process 1000 Japanese yen, this value should be 1000. To process 10.139 Tunisian dinar, this value should be 10139.
        ''' Note: If the merchant account Is Set up For a currency that has 3 Decimal units, our system will half round up the least significant digit. Therefore, a transaction Of 10.139 Tunisian dinar would be processed As 10.14.
        '''</summary> 
        ''' <returns></returns> 
        Public Property [amount] As String
            Get
                Return _amount
            End Get
            Set(value As String)
                _amount = value
            End Set
        End Property

        Private _availableToRefund As String
        '''<summary> 
        '''This Is the amount of this Settlement that Is available to Refund, in minor units. For example, US $10.99 would be 1099.         
        '''</summary> 
        ''' <returns></returns> 
        Public Property [availableToRefund] As String
            Get
                Return _availableToRefund
            End Get
            Set(value As String)
                _availableToRefund = value
            End Set
        End Property

        Private _childAccountNum As String
        '''<summary> 
        '''This Is the child merchant account number. It Is returned only if the transaction was processed via a master account.         
        '''</summary> 
        ''' <returns></returns> 
        Public Property [childAccountNum] As String
            Get
                Return _childAccountNum
            End Get
            Set(value As String)
                _childAccountNum = value
            End Set
        End Property

        Private _txnTime As Date
        '''<summary> 
        '''This Is the date And time the request was processed. For example
        '''2014-01-26T10:32:28Z
        '''</summary> 
        ''' <returns></returns> 
        Public Property [txnTime] As String
            Get
                Return _txnTime
            End Get
            Set(value As String)
                _txnTime = value
            End Set
        End Property

        Private _error As [error]
        '''<summary> 
        '''</summary> 
        ''' <returns></returns> 
        Public Property [error] As [error]
            Get
                Return _error
            End Get
            Set(value As [error])
                _error = value
            End Set
        End Property

        Private _dupCheck As Boolean
        '''<summary> 
        '''This validates that this request Is Not a duplicate. A request Is considered a duplicate If themerchantRefNumhas already been used In a previous request within the past 90 days.
        '''Note:This value defaults totrue.
        '''</summary> 
        ''' <returns></returns> 
        Public Property [dupCheck] As Boolean
            Get
                Return _dupCheck
            End Get
            Set(value As Boolean)
                _dupCheck = value
            End Set
        End Property

        Private _status As tSettlementStatus
        '''<summary> 
        '''This Is the status of the transaction request. Possible values are
        '''RECEIVED  Our system has received the request And Is waiting For the downstream processors response.
        '''PENDING  Our system has received the request but it has Not yet been batched.
        '''PROCESSING  The Settlement batch has started.
        '''COMPLETED  The transaction has been completed.
        '''FAILED  The transaction failed, due To either an Error Or being declined.
        '''CANCELLED  The transaction request has been cancelled.
        '''</summary> 
        ''' <returns></returns> 
        Public Property [status] As tSettlementStatus
            Get
                Return _status
            End Get
            Set(value As tSettlementStatus)
                _status = value
            End Set
        End Property

        Private _riskReasonCode As String
        '''<summary> 
        '''An array Of integers Is returned, displaying the detailed Risk reason codes If your transaction was declined. It Is returned only If your account Is configured accordingly.
        '''</summary> 
        ''' <returns></returns> 
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
        ''' This Is the raw response returned by an acquirer. It Is returned only if your account Is configured accordingly.
        '''</summary> 
        ''' <returns></returns> 
        Public Property [acquirerResponse] As acquirerResponse
            Get
                Return _acquirerResponse
            End Get
            Set(value As acquirerResponse)
                _acquirerResponse = value
            End Set
        End Property

        Private _splitpay As splitpay
        '''<summary> 
        '''This enables you To use the Split Payouts functionality When settleing an Authorization.
        '''</summary> 
        ''' <returns></returns> 
        Public Property [splitpay] As splitpay
            Get
                Return _splitpay
            End Get
            Set(value As splitpay)
                _splitpay = value
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
