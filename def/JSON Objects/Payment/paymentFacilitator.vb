Namespace PaySafe.Payment

Public Class [paymentFacilitator] : Implements IDisposable

Private _paymentFacilitatorName As String
''' <summary> 
''' This is the payment facilitator name.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [paymentFacilitatorName] As String 
Get 
Return _paymentFacilitatorName
End Get 
Set(value As String) 
_paymentFacilitatorName = value
End Set
End Property

Private _subMerchantId As String
''' <summary> 
''' This is an ID that the schemes can use to identify the sub merchant of the payment facilitator. Possible values could be our FMA or some other identifier that the merchant wishes to identify a sub merchant as. The default should be our FMA number.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [subMerchantId] As String 
Get 
Return _subMerchantId
End Get 
Set(value As String) 
_subMerchantId = value
End Set
End Property

Private _subMerchantName As String
''' <summary> 
''' The name of the sub merchant. Potentially can be used as part of the transaction descriptor. Each acquirer integration could be different please see individual implementation for actual behavior.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [subMerchantName] As String 
Get 
Return _subMerchantName
End Get 
Set(value As String) 
_subMerchantName = value
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
