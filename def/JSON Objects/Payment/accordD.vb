Imports MedatechUK.PaySafe.Constant

Namespace PaySafe.Payment

    Public Class [accordD] : Implements IDisposable

        Private _financingType As tFinacingType
        ''' <summary> 
        ''' This is the type of financing offered.
        ''' DEFERRED_PAYMENT � Deferred payment financing
        ''' EQUAL_PAYMENT � Equal payment financing
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

        Private _plan As String
        ''' <summary> 
        ''' This is the plan number for this financing transaction.
        ''' 
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

        Private _gracePeriod As String
        ''' <summary> 
        ''' This is the grace period, in months, associated with deferred payment transactions.
        ''' 
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

        Private _term As String
        ''' <summary> 
        ''' This is the number of payments, in months, for equal payment transactions.
        ''' 
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
