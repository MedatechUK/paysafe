Namespace PaySafe.Payment

Public Class [storedCredential] : Implements IDisposable

Private _type As String
''' <summary> 
''' This specifies the type of request being made. Possible values are:
''' ADHOC � Ad hoc consumer-initiated request
''' TOPUP � Unscheduled merchant-iniitated request
''' RECURRING � Scheduled, merchant-initiated recurring request
''' 
''' Note:�This value defaults to�ADHOC.
''' </summary> 
''' <returns></returns> 
Public Property [type] As String 
Get 
Return _type
End Get 
Set(value As String) 
_type = value
End Set
End Property

Private _occurrence As String
''' <summary> 
''' This specifies whether this stored credential request is initial or recurring. Possible values are:
''' INITIAL � Used when this is the first time the consumer uses this credit card
''' SUBSEQUENT � Used when the consumer uses this credit card for subsquent requests
''' 
''' Note:�This value defaults to�INITIAL.
''' </summary> 
''' <returns></returns> 
Public Property [occurrence] As String 
Get 
Return _occurrence
End Get 
Set(value As String) 
_occurrence = value
End Set
End Property

Private _initialTransactionId As String
''' <summary> 
''' Id of the initial Recurring Payment transaction.
''' This id should be stored from the auth response of the transaction indicated as initial with the following: type=RECURRING/TOPUP, occurrence=INITIAL.
''' This reference should be provided when:
''' type=RECURRING and occurrence=SUBSEQUENT
''' type=TOPUP and occurrence=SUBSEQUENT
''' 
''' Note:�This reference is a must to meet PSD 2 authentication process requirements for merchant initiated transactions successfully.
''' </summary> 
''' <returns></returns> 
Public Property [initialTransactionId] As String 
Get 
Return _initialTransactionId
End Get 
Set(value As String) 
_initialTransactionId = value
End Set
End Property

Private _externalInitialTransactionId As String
''' <summary> 
''' Id of the initial Recurring Payment transaction in case this transaction was processed through external PSP.
''' This reference should be provided only when:
''' type=RECURRING and occurrence=SUBSEQUENT
''' type=TOPUP and occurrence=SUBSEQUENT
''' 
''' Note:�This reference cannot be provided along with initialTransactionId.
''' </summary> 
''' <returns></returns> 
Public Property [externalInitialTransactionId] As String 
Get 
Return _externalInitialTransactionId
End Get 
Set(value As String) 
_externalInitialTransactionId = value
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
end class

end Namespace
