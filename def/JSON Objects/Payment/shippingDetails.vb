Namespace PaySafe.Payment

Public Class [shippingDetails] : Implements IDisposable

Private _carrier As String
''' <summary> 
''' This is the shipment carrier. Possible values are:
''' APC � APC Overnight
''' APS � Anpost
''' CAD � Canada Postal Service
''' DHL � DHL
''' FEX � Fedex
''' RML � Royal Mail
''' UPS � United Parcel Service
''' USPS � United States Postal Service
''' CLK � CityLink
''' EMS � EMS (US Postal Service)
''' NEX � Nexworldwide
''' OTHER
''' </summary> 
''' <returns></returns> 
Public Property [carrier] As String 
Get 
Return _carrier
End Get 
Set(value As String) 
_carrier = value
End Set
End Property

Private _shipMethod As String
''' <summary> 
''' This is the method of shipment. Possible values are:
''' N � Next Day/Overnight
''' T � Two-Day Service
''' C � Lowest Cost
''' O � Other
''' </summary> 
''' <returns></returns> 
Public Property [shipMethod] As String 
Get 
Return _shipMethod
End Get 
Set(value As String) 
_shipMethod = value
End Set
End Property

Private _recipientName As String
''' <summary> 
''' This is the name of the person receiving the goods.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [recipientName] As String 
Get 
Return _recipientName
End Get 
Set(value As String) 
_recipientName = value
End Set
End Property

Private _street As String
''' <summary> 
''' This is the recipient's street address.
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

Private _city As String
''' <summary> 
''' This is the city in which the recipient resides.
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
''' This is the recipient's postal/zip code.
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
