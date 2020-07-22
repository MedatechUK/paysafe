Namespace PaySafe.Payment

Public Class [flight] : Implements IDisposable

Private _carrierCode As String
''' <summary> 
''' Operating Carrier Code; the standard abbreviation code indicating name of the operating carrier (United Airlines, Jet Blue, etc.).
''' 
''' </summary> 
''' <returns></returns> 
Public Property [carrierCode] As String 
Get 
Return _carrierCode
End Get 
Set(value As String) 
_carrierCode = value
End Set
End Property

Private _flightNumber As String
''' <summary> 
''' Number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
''' 
''' </summary> 
''' <returns></returns> 
Public Property [flightNumber] As String 
Get 
Return _flightNumber
End Get 
Set(value As String) 
_flightNumber = value
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
