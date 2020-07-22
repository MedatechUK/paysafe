Imports System.IO
Imports System.Net

Namespace PaySafe.Request.GETrefund

''' '''<summary>
''' Look Up a Refund
''' '''<summary>
    Public Class [Get] Inherits PaySafe.Base.getRequest

#Region "ctor"

        Sub New(Settings As PaySafe.Settings, e As Object, ParamArray Args() As String)
            MyBase.New(Settings, e, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "refunds/{0}"
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

