Public Class [error] : Implements IDisposable

    Private _code As String
    ''' <summary> 
    '''The error code.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Private _message As String
    ''' <summary> 
    '''A description of the error. Also shown in the X-Application-Status-Code response header.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property message As String
        Get
            Return _message
        End Get
        Set(value As String)
            _message = value
        End Set
    End Property

    Private _fieldErrors() As String
    ''' <summary> 
    '''Details of any parameter value errors (optional). One or more field:error pairs, where field is the field name and error is the error in the field.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property fieldErrors As String()
        Get
            Return _fieldErrors
        End Get
        Set(value As String())
            _fieldErrors = value
        End Set
    End Property

    Private _links() As String
    ''' <summary> 
    '''One or more rel/href pairs, where rel is "errorinfo", and href is the Developer Center URL containing a description of the error.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property links As String()
        Get
            Return _links
        End Get
        Set(value As String())
            _links = value
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
