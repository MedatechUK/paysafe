Imports System.IO
Imports System.Net

Namespace PaySafe.Payment.Request.refund

    '''<summary>
    ''' Look Up a Refund
    '''</summary>
    Public Class [GETbyRef] : Inherits PaySafe.Base.getRequest

#Region "ctor"

        Sub New(Settings As PaySafe.Settings, ParamArray Args() As String)
            MyBase.New(Settings, Args)

        End Sub

#End Region

#Region "Overrides Request Properties"

        Public Overrides ReadOnly Property uri As String
            Get
                Return "cardpayments/v1/accounts/{0}/refunds?merchantRefNum={1}&limit={2}&offset={3}&startDate={4}&endDate={5}"
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

