
Imports System.IO
Imports System.Net
Imports oData

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load

        Using o As New oClient("/ORDERS", "GET", "$select=ORDNAME,ZASH_TOKEN&$filter=ZASH_TOKEN Ne ''&$expand=ORDERITEMS_SUBFORM($filter=ZASH_PAYSAFEREADY eq 'Y';$select=VPRICE)")
            Dim resp = o.GetResponse()
            If resp.GetType = GetType(System.Net.HttpWebResponse) Then
                With TryCast(resp, WebResponse)
                    Using sr As New StreamReader(.GetResponseStream)
                        result = Newtonsoft.Json.JsonConvert.DeserializeObject(sr.ReadToEnd)

                    End Using

                End With

            Else
                Response.Write(TryCast(resp, Exception).Message)

            End If


        End Using

    End Sub

End Class
