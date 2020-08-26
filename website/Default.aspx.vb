﻿Imports System.IO
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

        Using settings As New MedatechUK.PaySafe.Settings
            With settings
                .APIUser = WebConfigurationManager.AppSettings("APIUser")
                .APIkey = WebConfigurationManager.AppSettings("APIkey")
                .baseUrl = WebConfigurationManager.AppSettings("baseUrl")

            End With

            Using l As New oData.Loading("PAY", AddressOf hLog)
                Try
                    Using o As New oClient("/ORDERS", "GET", "$select=ORDNAME,ZASH_TOKEN&$filter=ZASH_TOKEN Ne ''&$expand=ORDERITEMS_SUBFORM($filter=ZASH_PAYSAFEREADY eq 'Y';$select=VPRICE)")

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
                                    Using a As New auths
                                        With a
                                            .merchantRefNum = ath.ORDNAME
                                            .settleWithAuth = True
                                            .card.paymentToken = ath.ZASH_TOKEN
                                            .dupCheck = False
                                            .currencyCode = Constant.ISO.tCurrency.GBP.ToString
                                            .amount = ath.value * 100

                                            With .storedCredential
                                                .type = tcredentialType.RECURRING.ToString
                                                .occurrence = toccurance.SUBSEQUENT.ToString

                                            End With

                                            With .billingDetails
                                                .zip = "BA22 8EX"

                                            End With

                                            Using auth As New Payment.Request.auths.Create(settings, a, WebConfigurationManager.AppSettings("accountID"))
                                                With auth
                                                    Select Case .Result.GetType()
                                                        Case GetType(ResponseErr)
                                                            Throw New Exception(TryCast(.Result, ResponseErr).ToString)

                                                        Case GetType(Exception)
                                                            Throw New Exception(TryCast(.Result, Exception).Message)

                                                        Case Else
                                                            With l.AddRow(1)
                                                                .TEXT29 = TryCast(auth.Result, PaySafe.Payment.auths).id
                                                                .TEXT1 = TryCast(auth.Result, PaySafe.Payment.auths).merchantRefNum
                                                                .TEXT2 = TryCast(auth.Result, PaySafe.Payment.auths).authCode
                                                                .TEXT3 = TryCast(auth.Result, PaySafe.Payment.auths).status
                                                                .TEXT30 = ""

                                                            End With

                                                    End Select

                                                End With

                                            End Using

                                        End With

                                    End Using

                                End If

                            Next

                            Dim EX As Exception = l.Post()
                            If Not EX Is Nothing Then Throw New Exception(EX.Message)

                        Else
                            Throw New Exception(TryCast(resp, Exception).Message)

                        End If

                    End Using

                Catch ex As Exception
                    Response.Write(ex.Message & "<br/>")

                End Try

            End Using

        End Using

    End Sub

    Private Sub hLog(sender As Object, e As oData.LogArgs)
        Response.Write(e.Message & "<br/>")

    End Sub

End Class
