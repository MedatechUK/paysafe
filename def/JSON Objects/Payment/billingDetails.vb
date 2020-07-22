Namespace PaySafe.Payment

Public Class [billingDetails] : Implements IDisposable

Private _street As String
''' <summary> 
''' This is the first line of the street address in the billing address.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [street] As String 
Get 
Return _street
End Get 
Set(value As String) 
_street = value
End Set
End Property

Private _street2 As String
''' <summary> 
''' This is the second line of the street address in the billing address, if required (e.g., apartment number).
''' 
''' </summary> 
''' <returns></returns> 
Public Property [street2] As String 
Get 
Return _street2
End Get 
Set(value As String) 
_street2 = value
End Set
End Property

Private _city As String
''' <summary> 
''' This is the city in the billing address.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [city] As String 
Get 
Return _city
End Get 
Set(value As String) 
_city = value
End Set
End Property

Private _state As String
''' <summary> 
''' See�Province Codes�or�State Codes�for Canada or the United States.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [state] As String 
Get 
Return _state
End Get 
Set(value As String) 
_state = value
End Set
End Property

Private _country As String
''' <summary> 
''' See�Country Codes.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [country] As String 
Get 
Return _country
End Get 
Set(value As String) 
_country = value
End Set
End Property

Private _zip As String
''' <summary> 
''' This is the postal/zip code in the billing address.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [zip] As String 
Get 
Return _zip
End Get 
Set(value As String) 
_zip = value
End Set
End Property

Private _phone As String
''' <summary> 
''' This is the customer's telephone number.
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
