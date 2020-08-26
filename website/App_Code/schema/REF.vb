Imports Microsoft.VisualBasic
Imports Newtonsoft.Json


Public Class REF
    <JsonProperty("@odata.context")>
    Public context As String
    Public value As New List(Of Refund)

End Class

Public Class Refund
    Public ORDNAME As String
    Public settlement_id As String

End Class