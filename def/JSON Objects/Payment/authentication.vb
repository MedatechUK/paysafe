Namespace PaySafe.Payment

    Public Class [authentication] : Implements IDisposable

        Private _eci As String
        ''' <summary> 
        ''' This is the Electronic Commerce Indicator code, which gets returned by the card issuer indicating whether the cardholder was successfully authenticated. Note that in some cases the�eci�value includes a leading zero, e.g., 01 or 02.
        ''' Visa
        ''' 5 � Identifies a successfully authenticated transaction.
        ''' 6 � Identifies an attempted authenticated transaction.
        ''' 7 � Identifies a non-authenticated transaction.
        ''' 
        ''' Mastercard
        ''' 0 � Identifies a non-authenticated transaction.
        ''' 1 � Identifies a non-authenticated transaction.
        ''' 2 � Identifies a successfully authenticated transaction.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [eci] As String
            Get
                Return _eci
            End Get
            Set(value As String)
                _eci = value
            End Set
        End Property

        Private _cavv As String
        ''' <summary> 
        ''' This is the Cardholder Authentication Verification Value, which gets returned by the card issuer, indicating that the transaction has been authenticated. This value should be appended to the Authorization request signifying that the transaction has been successfully authenticated.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [cavv] As String
            Get
                Return _cavv
            End Get
            Set(value As String)
                _cavv = value
            End Set
        End Property

        Private _xid As String
        ''' <summary> 
        ''' This is the transaction identifier returned by the card issuer.
        ''' Note:�This exists only for 3DS 1.0.2.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [xid] As String
            Get
                Return _xid
            End Get
            Set(value As String)
                _xid = value
            End Set
        End Property

        Private _threeDEnrollment As tthreeDEnrollment
        ''' <summary> 
        ''' This indicates whether or not the cardholder is enrolled in 3D Secure.
        ''' Y � Authentication is available
        ''' N � Cardholder is not enrolled
        ''' U � Authentication is unavailable
        ''' 
        ''' Note:�This exists only for 3DS 1.0.2.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [threeDEnrollment] As tthreeDEnrollment
            Get
                Return _threeDEnrollment
            End Get
            Set(value As tthreeDEnrollment)
                _threeDEnrollment = value
            End Set
        End Property

        Private _threeDResult As tthreeDResult
        ''' <summary> 
        ''' This indicates the outcome of the authentication.
        ''' Y � The cardholder successfully authenticated with their card issuer.
        ''' A � The cardholder authentication was attempted.
        ''' N � The cardholder failed to authenticate with their card issuer.
        ''' U � Authentication with the card issuer was unavailable.
        ''' E � An error occurred during authentication.
        ''' R � Rejected transaction.
        ''' 
        ''' Note:�The�R�value exists only for 3D Secure 2.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [threeDResult] As tthreeDResult
            Get
                Return _threeDResult
            End Get
            Set(value As tthreeDResult)
                _threeDResult = value
            End Set
        End Property

        Private _signatureStatus As tsignatureStatus
        ''' <summary> 
        ''' This is the 3D Secure signature verification result value.
        ''' Y � All transaction and signature checks satisfied.
        ''' N � At least one transaction or signature check failed.
        ''' 
        ''' Note:�This exists only for 3DS 1.0.2.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [signatureStatus] As tsignatureStatus
            Get
                Return _signatureStatus
            End Get
            Set(value As tsignatureStatus)
                _signatureStatus = value
            End Set
        End Property

        Private _directoryServerTransactionId As String
        ''' <summary> 
        ''' This is the unique directory server transaction ID required for Mastercard.
        ''' Note:�This exists only for 3D Secure 2.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [directoryServerTransactionId] As String
            Get
                Return _directoryServerTransactionId
            End Get
            Set(value As String)
                _directoryServerTransactionId = value
            End Set
        End Property

        Private _threeDSecureVersion As String
        ''' <summary> 
        ''' This is the 3D secure protocol version.
        ''' Note:�Paysafe strongly recommends including the correct 3D Secure version, exactly as it is returned from the 3D Secure API. If no version is specified in the request, the value defaults to 1.0.2. and is echoed in the response.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [threeDSecureVersion] As String
            Get
                Return _threeDSecureVersion
            End Get
            Set(value As String)
                _threeDSecureVersion = value
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
