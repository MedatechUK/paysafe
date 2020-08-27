Public Class LogArgs : Inherits EventArgs

    Public isException As Boolean = False
    Private _Message As String
    Public Property Message As String
        Get
            Return _Message
        End Get
        Set(value As String)
            _Message = value
        End Set
    End Property

    Sub New(str As String)
        _Message = str

    End Sub
    Sub New(format As String, ParamArray Args() As String)
        _Message = String.Format(format, Args)

    End Sub

    Sub New(ex As Exception)
        isException = True
        _Message = String.Format("{0}{2}{1}", ex.Message, ex.StackTrace, vbCrLf)

    End Sub

End Class

Public Module LogModule

    Public Event LogEvent(sender As Object, e As LogArgs)

    Public Sub Log(ByRef Sender As Object, str As String, ParamArray args() As String)
        RaiseEvent LogEvent(Sender, New LogArgs(str, args))

    End Sub

    Public Sub Log(ByRef Sender As Object, str As String)
        RaiseEvent LogEvent(Sender, New LogArgs(str))

    End Sub

    Public Sub Log(str As String, ParamArray args() As String)
        RaiseEvent LogEvent(Nothing, New LogArgs(str, args))

    End Sub

    Public Sub Log(ByRef Sender As Object, ex As Exception)
        RaiseEvent LogEvent(Sender, New LogArgs(ex))

    End Sub

    Public Sub Log(ex As Exception)
        RaiseEvent LogEvent(Nothing, New LogArgs(ex))

    End Sub

End Module
