Imports System.IO
Imports System.Net

Namespace PaySafe.Payment.Request.refund

    '''<summary>
    ''' Cancel a Refund
    '''</summary>
    Public Class [Cancel] : Inherits PaySafe.Base.updateRequest

#Region "ctor"

        Sub New(Settings As PaySafe.Settings, e As Object, ParamArray Args() As String)
            MyBase.New(Settings, e, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "cardpayments/v1/accounts/{0}/refunds/{1}"
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

