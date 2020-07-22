Namespace PaySafe.Vault
    Public Class header : Implements IDisposable

        Private _applicationData As String
        ''' <summary> 
        '''This is a hash of the applicationData property of the original PKPaymentRequest object. 
        '''If the value of that property is nil, this key is omitted.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property applicationData As String
            Get
                Return _applicationData
            End Get
            Set(value As String)
                _applicationData = value
            End Set
        End Property

        Private _transactionId As String
        ''' <summary> 
        '''This is the transaction identifier, generated on the device.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property transactionId As String
            Get
                Return _transactionId
            End Get
            Set(value As String)
                _transactionId = value
            End Set
        End Property

        Private _ephemeralPublicKey As String
        ''' <summary> 
        '''This is the ephemeral public key bytes (X.509 encoded key bytes, Base64 encoded string).
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

        Private _publicKeyHash As String
        ''' <summary> 
        '''This is a hash of the x.509 encoded public key bytes of the merchant's certificate as a Base64 encoded string.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property publicKeyHash As String
            Get
                Return _publicKeyHash
            End Get
            Set(value As String)
                _publicKeyHash = value
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
