Namespace PaySafe.Payment

    Public Class [NAG] : Implements IDisposable

        Private _mid As String
        ''' <summary> 
        ''' This is the acquirer MID that was sent to the clearing house.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [mid] As String
            Get
                Return _mid
            End Get
            Set(value As String)
                _mid = value
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
