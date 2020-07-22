Namespace PaySafe.Payment

Public Class [tripLegs] : Implements IDisposable

Private _leg1 As String
''' <summary> 
''' Description of first leg of trip.
''' </summary> 
''' <returns></returns> 
Public Property [leg1] As String 
Get 
Return _leg1
End Get 
Set(value As String) 
_leg1 = value
End Set
End Property

Private _leg2 As String
''' <summary> 
''' Description of second leg of trip.
''' </summary> 
''' <returns></returns> 
Public Property [leg2] As String 
Get 
Return _leg2
End Get 
Set(value As String) 
_leg2 = value
End Set
End Property

Private _leg3 As String
''' <summary> 
''' Description of third leg of trip.
''' </summary> 
''' <returns></returns> 
Public Property [leg3] As String 
Get 
Return _leg3
End Get 
Set(value As String) 
_leg3 = value
End Set
End Property

Private _leg4 As String
''' <summary> 
''' Description of fourth leg of trip.
''' </summary> 
''' <returns></returns> 
Public Property [leg4] As String 
Get 
Return _leg4
End Get 
Set(value As String) 
_leg4 = value
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
