﻿Imports System.IO
Imports System.Net

Namespace PaySafe.Request.SingleUseToken

    Public Class CreateApple : Inherits PaySafe.Base.createRequest

#Region "ctor"

        Sub New(e As Object, ParamArray Args() As String)
            MyBase.New(e, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "v1/applepaysingleusetokens"
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