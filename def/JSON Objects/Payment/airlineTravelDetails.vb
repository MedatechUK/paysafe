Namespace PaySafe.Payment

Public Class [airlineTravelDetails] : Implements IDisposable

Private _passengerName As String
''' <summary> 
''' Name of the passenger to whom the ticket was issued.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [passengerName] As String 
Get 
Return _passengerName
End Get 
Set(value As String) 
_passengerName = value
End Set
End Property

Private _departureDate As String
''' <summary> 
''' Date of passenger�s departure. Date format = YYYY-MM-DD, ISO 8601 expected. For example, 2014-01-26
''' 
''' </summary> 
''' <returns></returns> 
Public Property [departureDate] As String 
Get 
Return _departureDate
End Get 
Set(value As String) 
_departureDate = value
End Set
End Property

Private _origin As String
''' <summary> 
''' Departure Airport Code (IATA Airport Code).Example �YUL�
''' 
''' </summary> 
''' <returns></returns> 
Public Property [origin] As String 
Get 
Return _origin
End Get 
Set(value As String) 
_origin = value
End Set
End Property

Private _computerizedReservationSystem As String
''' <summary> 
''' Indicates the computerized reservation system used to make the reservation and purchase the ticket. Possible values for tickets purchased in Germany are:
''' STRT - Start
''' PARS - TWA
''' DATS - Delta
''' SABR - Sabre
''' DALA - Covia-Apollo
''' BLAN - Dr. Blank
''' DERD - DER
''' TUID - TUI
''' </summary> 
''' <returns></returns> 
Public Property [computerizedReservationSystem] As String 
Get 
Return _computerizedReservationSystem
End Get 
Set(value As String) 
_computerizedReservationSystem = value
End Set
End Property

Private _ticket As String
''' <summary> 
''' Information about the Airline Ticket Number and if the ticket is restricted.
''' </summary> 
''' <returns></returns> 
Public Property [ticket] As String 
Get 
Return _ticket
End Get 
Set(value As String) 
_ticket = value
End Set
End Property

Private _customerReferenceNumber As String
''' <summary> 
''' Contains the code that the cardholder supplied to the card acceptor.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [customerReferenceNumber] As String 
Get 
Return _customerReferenceNumber
End Get 
Set(value As String) 
_customerReferenceNumber = value
End Set
End Property

Private _travelAgency As String
''' <summary> 
''' Information about the travel agency if the ticket was issued by a travel agency.
''' </summary> 
''' <returns></returns> 
Public Property [travelAgency] As String 
Get 
Return _travelAgency
End Get 
Set(value As String) 
_travelAgency = value
End Set
End Property

Private _tripLegs As String
''' <summary> 
''' A grouping of up to four trip legs. Each leg provides detailed itinerary data.
''' </summary> 
''' <returns></returns> 
Public Property [tripLegs] As String 
Get 
Return _tripLegs
End Get 
Set(value As String) 
_tripLegs = value
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
