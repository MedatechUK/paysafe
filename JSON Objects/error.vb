Public Class [error]

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

End Class
