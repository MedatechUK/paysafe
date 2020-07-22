Namespace PaySafe.Payment

    Public Class [CRX] : Implements IDisposable

        Private _responseId As String
        ''' <summary> 
        ''' This is the response ID assigned by Credorax.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [responseId] As String
            Get
                Return _responseId
            End Get
            Set(value As String)
                _responseId = value
            End Set
        End Property

        Private _requestId As String
        ''' <summary> 
        ''' This is the request ID assigned by Paysafe.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [requestId] As String
            Get
                Return _requestId
            End Get
            Set(value As String)
                _requestId = value
            End Set
        End Property

        Private _description As String
        ''' <summary> 
        ''' This is a description of the response.
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

        Private _authCode As String
        ''' <summary> 
        ''' This is the authorization code.
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

        Private _txnDateTime As String
        ''' <summary> 
        ''' This is the transaction date and time.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [txnDateTime] As String
            Get
                Return _txnDateTime
            End Get
            Set(value As String)
                _txnDateTime = value
            End Set
        End Property

        Private _referenceNbr As String
        ''' <summary> 
        ''' Bank net transaction Id/Merch Tran Ref
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [referenceNbr] As String
            Get
                Return _referenceNbr
            End Get
            Set(value As String)
                _referenceNbr = value
            End Set
        End Property

        Private _responseReasonCode As String
        ''' <summary> 
        ''' This is the raw response reason code returned by Credorax.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [responseReasonCode] As String
            Get
                Return _responseReasonCode
            End Get
            Set(value As String)
                _responseReasonCode = value
            End Set
        End Property

        Private _cvv2Result As String
        ''' <summary> 
        ''' This is the raw cvv2 result code.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [cvv2Result] As String
            Get
                Return _cvv2Result
            End Get
            Set(value As String)
                _cvv2Result = value
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
