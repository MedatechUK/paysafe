Imports System.Net

Namespace Addresses

    Public Class [Update] : Inherits updateRequest

#Region "ctor"

        Sub New(e As Object, ParamArray Args() As String)
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

        Public Overrides Sub response(ByRef r As HttpWebResponse)
            Using reader = New IO.StreamReader(r.GetResponseStream())
                Console.Write(reader.ReadToEnd())

            End Using

        End Sub

#End Region

    End Class

End Namespace