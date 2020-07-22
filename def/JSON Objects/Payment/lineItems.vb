Namespace PaySafe.Payment

Public Class [lineItems] : Implements IDisposable

Private _description As String
''' <summary> 
''' This is a description of the item(s) being purchased.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [description] As String 
Get 
Return _description
End Get 
Set(value As String) 
_description = value
End Set
End Property

Private _productCode As String
''' <summary> 
''' This is a merchant-defined description code of the item being purchased.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [productCode] As String 
Get 
Return _productCode
End Get 
Set(value As String) 
_productCode = value
End Set
End Property

Private _quantity As String
''' <summary> 
''' This is the quantity of the item.
''' 
''' 
''' </summary> 
''' <returns></returns> 
Public Property [quantity] As String 
Get 
Return _quantity
End Get 
Set(value As String) 
_quantity = value
End Set
End Property

Private _unitAmount As String
''' <summary> 
''' This is the unit price of the item being purchased, in minor units. The currency will be based on the account setting.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [unitAmount] As String 
Get 
Return _unitAmount
End Get 
Set(value As String) 
_unitAmount = value
End Set
End Property

Private _taxRate As String
''' <summary> 
''' This is the tax rate used to calculate the tax amount. For example, if the tax rate is 10.5%, this value should be 10.5.
''' 
''' 
''' </summary> 
''' <returns></returns> 
Public Property [taxRate] As String 
Get 
Return _taxRate
End Get 
Set(value As String) 
_taxRate = value
End Set
End Property

Private _taxAmount As String
''' <summary> 
''' This is the amount of any value-added taxes that can be associated with the purchased item, in minor units. The currency will be based on the account setting.�Note:�Our system will not validate the accuracy of this value. The merchant's application must calculate this value correctly.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [taxAmount] As String 
Get 
Return _taxAmount
End Get 
Set(value As String) 
_taxAmount = value
End Set
End Property

Private _totalAmount As String
''' <summary> 
''' This is the total amount of the line item, typically calculated as price multiplied by quantity, in minor units. The currency will be based on the account setting.�Note:�Our system will not validate the accuracy of this value. The merchant's application must calculate this value correctly.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [totalAmount] As String 
Get 
Return _totalAmount
End Get 
Set(value As String) 
_totalAmount = value
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
