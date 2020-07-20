Imports System.Net

Namespace PaySafe.Request.Addresses

    Public Class [Update] : Inherits PaySafe.Base.updateRequest

#Region "ctor"

        Sub New(Settings As PaySafe.Settings, e As Object, ParamArray Args() As String)
            MyBase.New(e, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "v1/profiles/{0}/addresses/{1}"
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