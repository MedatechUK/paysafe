Imports System.IO
Imports System.Net
Imports oData
Imports Newtonsoft
Imports MedatechUK.PaySafe
Imports MedatechUK.PaySafe.Payment
Imports MedatechUK
Imports System.Web.Configuration

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load

        Dim p As Boolean = False
        Dim t As Boolean = False

        Using settings As New MedatechUK.PaySafe.Settings(AddressOf hLog2)
            With settings
                .APIUser = WebConfigurationManager.AppSettings("APIUser")
                .APIkey = WebConfigurationManager.AppSettings("APIkey")
                .baseUrl = WebConfigurationManager.AppSettings("baseUrl")

            End With

            Using tok As New oData.Loading("STA", AddressOf hLog2)
                Using l As New oData.Loading("PAY", AddressOf hLog)
                    Try
                        Using o As New oClient(
                            "/ORDERS",
                            "GET",
                            "$select=ZASH_MAGORDID,ORDNAME,ZASH_TOKEN,CODE,ZASH_ZIP&" &
                            "$filter=ZASH_TOKEN Ne ''&$expand=ORDERITEMS_SUBFORM($filter=ZASH_PAYSAFEREADY eq 'Y';$select=VPRICE,ORDI)"
                        )
                            Dim resp = o.GetResponse()
                            If resp.GetType = GetType(System.Net.HttpWebResponse) Then
                                Dim ord As ORD
                                With TryCast(resp, WebResponse)
                                    Using sr As New StreamReader(.GetResponseStream)
                                        ord = Json.JsonConvert.DeserializeObject(Of ORD)(sr.ReadToEnd)
                                    End Using
                                End With

                                For Each ath As Order In ord.value
                                    If ath.value > 0 Then
                                        Try
                                            Using a As New auths
                                                With a
                                                    .merchantRefNum = ath.ZASH_MAGORDID
                                                    .settleWithAuth = True
                                                    .card.paymentToken = ath.ZASH_TOKEN
                                                    .dupCheck = False
                                                    .currencyCode = ath.CODE
                                                    .amount = ath.value * 100

                                                    With .storedCredential
                                                        .type = tcredentialType.RECURRING.ToString
                                                        .occurrence = toccurance.SUBSEQUENT.ToString

                                                    End With

                                                    With .billingDetails
                                                        .zip = ath.ZASH_ZIP

                                                    End With

                                                    Using auth As New Payment.Request.auths.Create(settings, a, WebConfigurationManager.AppSettings("accountID"))
                                                        With auth
                                                            Select Case .Result.GetType()
                                                                Case GetType(Exception)
                                                                    Throw New Exception(TryCast(.Result, Exception).Message)

                                                                Case GetType(ResponseErr)
                                                                    t = True
                                                                    Select Case CInt(TryCast(.Result, ResponseErr).error.code)
                                                                        Case 5502 ' Payment token is invalid                                                                            
                                                                            With tok.AddRow(1)
                                                                                .TEXT1 = ath.ORDNAME
                                                                                .TEXT2 = "PAYLINKREQ"
                                                                                .TEXT30 = System.Guid.NewGuid.ToString
                                                                            End With

                                                                            For Each i As SUBFORM In ath.ORDERITEMS_SUBFORM
                                                                                With tok.AddRow(2)
                                                                                    .INT1 = i.ORDI
                                                                                    .TEXT20 = "N"
                                                                                    .TEXT21 = "N"
                                                                                End With
                                                                            Next

                                                                        Case Else
                                                                            With tok.AddRow(1)
                                                                                .TEXT1 = ath.ORDNAME
                                                                                .TEXT2 = "ERROR"
                                                                                .TEXT29 = TryCast(auth.Result, ResponseErr).ToString.Substring(0, 99)
                                                                            End With

                                                                            For Each i As SUBFORM In ath.ORDERITEMS_SUBFORM
                                                                                With tok.AddRow(2)
                                                                                    .INT1 = i.ORDI
                                                                                    .TEXT20 = "N"
                                                                                    .TEXT21 = "N"
                                                                                End With
                                                                            Next

                                                                    End Select

                                                                Case Else
                                                                    p = True
                                                                    With l.AddRow(1)
                                                                        .TEXT1 = ath.ORDNAME
                                                                        .TEXT2 = "001"
                                                                    End With

                                                                    With l.AddRow(2)
                                                                        .TEXT1 = "18"
                                                                        .TEXT2 = TryCast(auth.Result, PaySafe.Payment.auths).merchantRefNum
                                                                        .TEXT3 = TryCast(auth.Result, PaySafe.Payment.auths).authCode
                                                                        .TEXT4 = TryCast(auth.Result, PaySafe.Payment.auths).status
                                                                        .REAL1 = TryCast(auth.Result, PaySafe.Payment.auths).amount / 100
                                                                        .INT1 = DateDiff(DateInterval.Minute, #01/01/1988#, Now())
                                                                        .TEXT29 = TryCast(auth.Result, PaySafe.Payment.auths).id

                                                                    End With

                                                                    t = True
                                                                    With tok.AddRow(1)
                                                                        .TEXT1 = ath.ORDNAME
                                                                        .TEXT2 = "PAYMENTRCVD"
                                                                    End With

                                                                    For Each i As SUBFORM In ath.ORDERITEMS_SUBFORM
                                                                        With tok.AddRow(2)
                                                                            .INT1 = i.ORDI
                                                                            .TEXT20 = "N"
                                                                            .TEXT21 = "Y"
                                                                        End With
                                                                    Next

                                                            End Select

                                                        End With

                                                    End Using

                                                End With

                                            End Using

                                        Catch exep As Exception
                                            Response.Write(exep.Message & "<br/>")

                                        End Try

                                    End If

                                Next

                                If p Then
                                    Dim EX As Exception = l.Post()
                                    If Not EX Is Nothing Then Throw New Exception(EX.Message)

                                End If

                                If t Then
                                    Dim EX As Exception = tok.Post()
                                    If Not EX Is Nothing Then Throw New Exception(EX.Message)
                                End If

                            End If

                        End Using

                    Catch ex As Exception
                        Response.Write(ex.Message & "<br/>")

                    End Try

                End Using

            End Using

        End Using

    End Sub

    Private Sub hLog(sender As Object, e As LogArgs)
        HttpContext.Current.Response.Write(e.Message & "<br/>")

    End Sub

    Private Sub hLog2(sender As Object, e As LogArgs)
        'HttpContext.Current.Response.Write(e.Message & "<br/>")

    End Sub

End Class
