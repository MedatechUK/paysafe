Imports MedatechUK.PaySafe.Constant

Namespace PaySafe.Payment

    Public Class [DJN] : Implements IDisposable

        Private _batchNumber As String
        ''' <summary> 
        ''' This is the batch number.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [batchNumber] As String
            Get
                Return _batchNumber
            End Get
            Set(value As String)
                _batchNumber = value
            End Set
        End Property

        Private _effectiveDate As String
        ''' <summary> 
        ''' This is the date of the bank deposit associated with the transaction.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [effectiveDate] As String
            Get
                Return _effectiveDate
            End Get
            Set(value As String)
                _effectiveDate = value
            End Set
        End Property

        Private _financingType As tFinacingType
        ''' <summary> 
        ''' This is the type of financing offered.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [financingType] As tFinacingType
            Get
                Return _financingType
            End Get
            Set(value As tFinacingType)
                _financingType = value
            End Set
        End Property

        Private _gracePeriod As String
        ''' <summary> 
        ''' This is the grace period, in months, associated with deferred payment transactions.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [gracePeriod] As String
            Get
                Return _gracePeriod
            End Get
            Set(value As String)
                _gracePeriod = value
            End Set
        End Property

        Private _nonReusableToken As String
        ''' <summary> 
        ''' This is a credit card ID used by the merchant to track consumer behavior.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [nonReusableToken] As String
            Get
                Return _nonReusableToken
            End Get
            Set(value As String)
                _nonReusableToken = value
            End Set
        End Property

        Private _plan As String
        ''' <summary> 
        ''' This is the plan number for this financing transaction.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [plan] As String
            Get
                Return _plan
            End Get
            Set(value As String)
                _plan = value
            End Set
        End Property

        Private _seqNumber As String
        ''' <summary> 
        ''' This is the merchant's sequence number.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [seqNumber] As String
            Get
                Return _seqNumber
            End Get
            Set(value As String)
                _seqNumber = value
            End Set
        End Property

        Private _term As String
        ''' <summary> 
        ''' This is the number of payments, in months, for equal payment transactions.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [term] As String
            Get
                Return _term
            End Get
            Set(value As String)
                _term = value
            End Set
        End Property

        Private _terminalId As String
        ''' <summary> 
        ''' This is the merchant's terminal ID.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [terminalId] As String
            Get
                Return _terminalId
            End Get
            Set(value As String)
                _terminalId = value
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
