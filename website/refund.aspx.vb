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

        Using settings As New MedatechUK.PaySafe.Settings
            With settings
                .APIUser = WebConfigurationManager.AppSettings("APIUser")
                .APIkey = WebConfigurationManager.AppSettings("APIkey")
                .baseUrl = WebConfigurationManager.AppSettings("baseUrl")

            End With

            Using l As New oData.Loading("PAY", AddressOf hLog)
                Try
                    ' TODO: Feed of refunds
                    Using o As New oClient("/ORDERS", "GET", "$select=ORDNAME,ZASH_TOKEN&$filter=ZASH_TOKEN Ne ''&$expand=ORDERITEMS_SUBFORM($filter=ZASH_PAYSAFEREADY eq 'Y';$select=VPRICE)")

                        Dim resp = o.GetResponse()
                        If resp.GetType = GetType(System.Net.HttpWebResponse) Then
                            Dim ref As REF
                            With TryCast(resp, WebResponse)
                                Using sr As New StreamReader(.GetResponseStream)
                                    ref = Json.JsonConvert.DeserializeObject(Of REF)(sr.ReadToEnd)
                                End Using
                            End With

                            For Each r As Refund In ref.value
                                Using a As New refunds
                                    With a
                                        .merchantRefNum = r.ORDNAME
                                        .dupCheck = False

                                        ' Raise a refund against a token
                                        Using refu As New refunds
                                            Using refund As New Payment.Request.refund.Create(settings, r, WebConfigurationManager.AppSettings("accountID"), r.settlement_id)
                                                With refund
                                                    Select Case .Result.GetType()
                                                        Case GetType(ResponseErr)
                                                            Throw New Exception(TryCast(.Result, ResponseErr).ToString)

                                                        Case GetType(Exception)
                                                            Throw New Exception(TryCast(.Result, Exception).Message)

                                                        Case Else
                                                            With l.AddRow(1)
                                                                .TEXT29 = TryCast(refund.Result, refunds).id
                                                                .TEXT1 = TryCast(refund.Result, refunds).merchantRefNum
                                                                .TEXT3 = TryCast(refund.Result, refunds).status
                                                                .TEXT30 = ""

                                                            End With

                                                    End Select

                                                End With

                                            End Using
                                        End Using

                                    End With

                                End Using

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
