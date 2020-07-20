Imports System.Net

Namespace PaySafe.Base

    Public MustInherit Class getRequest : Inherits Request

        Sub New(Settings As PaySafe.Settings, ParamArray Args() As String)
            MyBase.New(Settings, Args)

        End Sub

        Public Overrides ReadOnly Property verb As String
            Get
                Return "GET"
            End Get
        End Property

    End Class

End Namespace
