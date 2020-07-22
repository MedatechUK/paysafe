Namespace PaySafe.Payment

Public Class [acquirerResponse] : Implements IDisposable

Private _code As String
''' <summary> 
''' This is acquirer identification code, such as DJN, CRX, etc.
''' </summary> 
''' <returns></returns> 
Public Property [code] As String 
Get 
Return _code
End Get 
Set(value As String) 
_code = value
End Set
End Property

Private _responseCode As String
''' <summary> 
''' This is the raw response returned by the acquirer.
''' </summary> 
''' <returns></returns> 
Public Property [responseCode] As String 
Get 
Return _responseCode
End Get 
Set(value As String) 
_responseCode = value
End Set
End Property

Private _avsCode As String
''' <summary> 
''' This is the raw AVS code returned by the acquirer.
''' </summary> 
''' <returns></returns> 
Public Property [avsCode] As String 
Get 
Return _avsCode
End Get 
Set(value As String) 
_avsCode = value
End Set
End Property

Private _balanceResponse As String
''' <summary> 
''' This is the balance remaining on a gift card, if a gift card was used for the original transaction.
''' </summary> 
''' <returns></returns> 
Public Property [balanceResponse] As String 
Get 
Return _balanceResponse
End Get 
Set(value As String) 
_balanceResponse = value
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
