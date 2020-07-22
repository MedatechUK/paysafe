Namespace PaySafe.Payment

Public Class [links] : Implements IDisposable

Private _rel As String
''' <summary> 
''' This is the link type that allows different endpoints to be targeted depending on the end state of the transaction.
''' </summary> 
''' <returns></returns> 
Public Property [rel] As String 
Get 
Return _rel
End Get 
Set(value As String) 
_rel = value
End Set
End Property

Private _href As String
''' <summary> 
''' This is the URI of the resource.    
''' </summary> 
''' <returns></returns> 
Public Property [href] As String 
Get 
Return _href
End Get 
Set(value As String) 
_href = value
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
