Imports Microsoft.VisualBasic
Imports Newtonsoft.Json


Public Class ORD
    <JsonProperty("@odata.context")>
    Public context As String
    Public value As New List(Of Order)

End Class

Public Class Order
    Public ORDNAME As String
    Public ZASH_TOKEN As String
    Public ORDERITEMS_SUBFORM As New List(Of SUBFORM)

End Class

Public Class SUBFORM
    Public VPRICE As Double

End Class