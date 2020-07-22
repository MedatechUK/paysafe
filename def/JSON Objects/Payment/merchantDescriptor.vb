Namespace PaySafe.Payment

Public Class [merchantDescriptor] : Implements IDisposable

Private _dynamicDescriptor As String
''' <summary> 
''' This is a merchant descriptor that will be displayed on a customer�s card statement.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [dynamicDescriptor] As String 
Get 
Return _dynamicDescriptor
End Get 
Set(value As String) 
_dynamicDescriptor = value
End Set
End Property

Private _phone As String
''' <summary> 
''' This is the merchant�s phone number, which will be appended to the merchant descriptor on a customer�s card statement.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [phone] As String 
Get 
Return _phone
End Get 
Set(value As String) 
_phone = value
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
