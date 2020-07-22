Namespace PaySafe.Payment

    Public Class [error] : Implements IDisposable

        Private _code As String
        ''' <summary> 
        ''' The error code. Also shown in the X-Application-Status-Code response header.
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

        Private _message As String
        ''' <summary> 
        ''' A description of the error.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [message] As String
            Get
                Return _message
            End Get
            Set(value As String)
                _message = value
            End Set
        End Property

        Private _details As String
        ''' <summary> 
        ''' Details of any parameter value errors (optional).
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [details] As String
            Get
                Return _details
            End Get
            Set(value As String)
                _details = value
            End Set
        End Property

        Private _links As String
        ''' <summary> 
        ''' One or more rel/href pairs, where rel is "errorinfo", and href is the Developer Center URL containing a description of the error.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [links] As String
            Get
                Return _links
            End Get
            Set(value As String)
                _links = value
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
