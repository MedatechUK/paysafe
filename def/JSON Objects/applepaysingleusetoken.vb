Namespace PaySafe

    Public Class applepaysingleusetoken : Implements IDisposable

        Private _applePayPaymentToken As String
        ''' <summary> 
        '''This is the payment data object generated from the iOS device for Apple Pay.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property applePayPaymentToken As String
            Get
                Return _applePayPaymentToken
            End Get
            Set(value As String)
                _applePayPaymentToken = value
            End Set
        End Property

        Private _card As String
        ''' <summary> 
        '''These are the details of the virtual card.
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

        Private _transaction As String
        ''' <summary> 
        '''These are the Apple Pay transaction details.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property transaction As String
            Get
                Return _transaction
            End Get
            Set(value As String)
                _transaction = value
            End Set
        End Property

        Private _paymentToken As String
        ''' <summary> 
        '''This is the single-use payment token, returned in the response, to use in the authorization or purchase request in the Card Payments API.
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