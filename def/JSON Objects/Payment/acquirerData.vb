Namespace PaySafe.Payment

Public Class [acquirerData] : Implements IDisposable

Private _authId As String
''' <summary> 
''' This is the ID returned in the response to a previous successful Authorization or Settlement request.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [authId] As String 
Get 
Return _authId
End Get 
Set(value As String) 
_authId = value
End Set
End Property

Private _code As String
''' <summary> 
''' This is the code for your card acquirer.
''' 
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
