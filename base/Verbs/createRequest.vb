Imports System.Net

Namespace PaySafe.Base
    Public MustInherit Class createRequest : Inherits Request

        Sub New(Settings As PaySafe.Settings, e As Object, ParamArray Args() As String)
            MyBase.New(Settings, e, Args)

        End Sub

        Public Overrides ReadOnly Property verb As String
            Get
                Return "POST"
            End Get
        End Property

    End Class

End Namespace
