﻿Imports System.Net

Namespace PaySafe.Vault.Request.Mandates

    Public Class [Get] : Inherits PaySafe.Base.getRequest

#Region "ctor"

        Sub New(Settings As PaySafe.Settings, ParamArray Args() As String)
            MyBase.New(Settings, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "customervault/v1/profiles/profile_id/mandates/mandate_id"
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
