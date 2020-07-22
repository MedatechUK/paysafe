Namespace PaySafe.Payment

Public Class [ticket] : Implements IDisposable

Private _ticketNumber As String
''' <summary> 
''' Airline Ticket Number
''' 
''' </summary> 
''' <returns></returns> 
Public Property [ticketNumber] As String 
Get 
Return _ticketNumber
End Get 
Set(value As String) 
_ticketNumber = value
End Set
End Property

Private _isRestrictedTicket As String
''' <summary> 
''' Indicates whether this ticket is non-refundable. This entry should be supplied on CPS/Passenger Transport 1 or 2 transactions if the ticket was purchased as a non-refundable ticket.Valid values are:
''' false - No restriction (default)
''' true - Restricted (non-refundable) ticket
''' </summary> 
''' <returns></returns> 
Public Property [isRestrictedTicket] As String 
Get 
Return _isRestrictedTicket
End Get 
Set(value As String) 
_isRestrictedTicket = value
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
