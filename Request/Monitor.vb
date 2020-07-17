Imports System.IO
Imports System.Net

Public Class Monitor : Inherits Request

#Region "ctor"

    Sub New(ParamArray Args() As String)
        MyBase.New(Args)

    End Sub

#End Region

#Region "Overrides Request Properties"

    Public Overrides ReadOnly Property uri As String
        Get
            Return "monitor"
        End Get
    End Property

    Public Overrides ReadOnly Property verb As String
        Get
            Return "GET"
        End Get
    End Property

#End Region

#Region "Overrides Request Methods"

    Public Overrides Sub response(ByRef r As HttpWebResponse)
        Using reader = New IO.StreamReader(r.GetResponseStream())
            Console.Write(reader.ReadToEnd())

        End Using

    End Sub

#End Region

End Class

