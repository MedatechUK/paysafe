Imports System.IO
Imports System.Net

Namespace PaySafe.Request


    Public Class Monitor : Inherits PaySafe.Base.getRequest

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

#End Region

#Region "Overrides Request Methods"

        Public Overrides ReadOnly Property responseType As Type
            Get
                Throw New NotImplementedException()
            End Get

        End Property

#End Region

    End Class

End Namespace

