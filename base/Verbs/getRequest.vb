Imports System.Net

Namespace PaySafe.Base

    Public MustInherit Class getRequest : Inherits Request

        Sub New(ParamArray Args() As String)
            MyBase.New(Args)

        End Sub

        Public Overrides ReadOnly Property verb As String
            Get
                Return "GET"
            End Get
        End Property

    End Class

End Namespace
