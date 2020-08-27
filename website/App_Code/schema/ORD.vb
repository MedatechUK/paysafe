Imports Microsoft.VisualBasic
Imports Newtonsoft.Json


Public Class ORD
    <JsonProperty("@odata.context")>
    Public context As String
    Public value As New List(Of Order)

End Class

Public Class Order
    Public ORDNAME As String
    Public CODE As String
    Public ZASH_TOKEN As String
    Public ZASH_MAGORDID As String
    Public ZASH_ZIP As String
    Public ORDERITEMS_SUBFORM As New List(Of SUBFORM)

    Public ReadOnly Property value As Double
        Get
            Dim ret As Double = 0
            For Each i As SUBFORM In ORDERITEMS_SUBFORM
                ret += i.VPRICE
            Next
            Return ret
        End Get
    End Property
End Class

Public Class SUBFORM
    Public VPRICE As Double
    Public ORDI As Integer

End Class