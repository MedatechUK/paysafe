Namespace PaySafe.Payment

Public Class [cardExpiry] : Implements IDisposable

Private _month As String
''' <summary> 
''' This is the card expiry month.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [month] As String 
Get 
Return _month
End Get 
Set(value As String) 
_month = value
End Set
End Property

Private _year As String
''' <summary> 
''' This is the card expiry year.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [year] As String 
Get 
Return _year
End Get 
Set(value As String) 
_year = value
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
