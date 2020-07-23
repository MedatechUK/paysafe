Imports System.IO
Imports System.Net

Namespace PaySafe.Payment.Request.ocredit

    '''<summary>
    ''' Cancel an Original Credit
    '''</summary>
    Public Class [Update] : Inherits PaySafe.Base.updateRequest

#Region "ctor"

        Sub New(Settings As PaySafe.Settings, e As Object, ParamArray Args() As String)
            MyBase.New(Settings, e, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "originalcredits/{0}"
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

