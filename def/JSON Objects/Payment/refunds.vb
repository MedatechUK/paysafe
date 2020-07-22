Namespace PaySafe.Payment

    Public Class [refunds] : Implements IDisposable

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
        ''' Note:�If the merchant account is set up for a currency that has 3 decimal units, our system will half round up the least significant digit. Therefore, a transaction of 10.139 Tunisian dinar would be processed as 10.14.
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

        Private _txnTime As Date
        ''' <summary> 
        ''' This is the date and time the request was processed. For example:
        ''' 2014-01-26T10:32:28Z
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [txnTime] As Date
            Get
                Return _txnTime
            End Get
            Set(value As Date)
                _txnTime = value
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

        Private _status As trefundStatus
        ''' <summary> 
        ''' This is the status of the transaction request. Possible values are:
        ''' RECEIVED � Our system has received the request and is waiting for the downstream processor�s response.
        ''' COMPLETED � The transaction has been completed.
        ''' PENDING � Our system has received the request but it has not yet been batched.
        ''' FAILED � The transaction failed, due to either an error or being declined.
        ''' CANCELLED � The request has been fully voided (reversed).
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [status] As trefundStatus
            Get
                Return _status
            End Get
            Set(value As trefundStatus)
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

        Private _acquirerResponse As acquirerResponse
        ''' <summary> 
        ''' This is the raw response returned by an acquirer. It is returned only if your account is configured accordingly.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [acquirerResponse] As acquirerResponse
            Get
                Return _acquirerResponse
            End Get
            Set(value As acquirerResponse)
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
