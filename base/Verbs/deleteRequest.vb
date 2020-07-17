Imports System.Net

Public MustInherit Class deleteRequest : Inherits Request

    Sub New(ParamArray Args() As String)
        MyBase.New(Args)

    End Sub

    Public Overrides ReadOnly Property verb As String
        Get
            Return "DELETE"
        End Get
    End Property

End Class
