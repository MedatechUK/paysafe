Imports System.IO
Imports System.Net

Namespace PaySafe.Request.DDToken

    Public Class CreateACH : Inherits PaySafe.Base.createRequest

#Region "ctor"

        Sub New(e As Object, ParamArray Args() As String)
            MyBase.New(e, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "v1/achsingleusetokens"
            End Get
        End Property

#End Region

#Region "Overrides Response"

        Public Overrides ReadOnly Property responseType As Type
            Get
                Throw New NotImplementedException()
            End Get

        End Property

#End Region

    End Class

End Namespace