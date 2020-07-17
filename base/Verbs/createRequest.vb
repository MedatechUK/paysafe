Imports System.Net

Public MustInherit Class createRequest : Inherits Request

    Sub New(e As Object, ParamArray Args() As String)
        MyBase.New(e, Args)

    End Sub

    Public Overrides ReadOnly Property verb As String
        Get
            Return "POST"
        End Get
    End Property

End Class
