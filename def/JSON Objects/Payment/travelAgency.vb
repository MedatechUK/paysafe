Namespace PaySafe.Payment

    Public Class [travelAgency] : Implements IDisposable

        Private _code As String
        ''' <summary> 
        ''' Code identifying travel agency if the ticket was issued by a travel agency.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [code] As String
            Get
                Return _code
            End Get
            Set(value As String)
                _code = value
            End Set
        End Property

        Private _name As String
        ''' <summary> 
        ''' Name of travel agency if the ticket was issued by a travel agency.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [name] As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
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
    End Class

End Namespace
