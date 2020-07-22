Namespace PaySafe.Payment

    Public Class [level2level3] : Implements IDisposable

        Private _exemptLocalTax As Boolean
        ''' <summary> 
        ''' This indicates whether or not local tax is exempted for the request. If set to true, then the localTaxAmount parameter will be ignored.
        ''' Note:�This value defaults to�false.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [exemptLocalTax] As Boolean
            Get
                Return _exemptLocalTax
            End Get
            Set(value As Boolean)
                _exemptLocalTax = value
            End Set
        End Property

        Private _localTaxAmount As Integer
        ''' <summary> 
        ''' This is the local sales tax applied to the purchase.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [localTaxAmount] As Integer
            Get
                Return _localTaxAmount
            End Get
            Set(value As Integer)
                _localTaxAmount = value
            End Set
        End Property

        Private _nationalTaxAmount As String
        ''' <summary> 
        ''' This is the national tax included in the transaction amount.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [nationalTaxAmount] As String
            Get
                Return _nationalTaxAmount
            End Get
            Set(value As String)
                _nationalTaxAmount = value
            End Set
        End Property

        Private _freightAmount As String
        ''' <summary> 
        ''' This is the freight or shipping portion of the total transaction amount.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [freightAmount] As String
            Get
                Return _freightAmount
            End Get
            Set(value As String)
                _freightAmount = value
            End Set
        End Property

        Private _dutyAmount As String
        ''' <summary> 
        ''' This is the duty associated with the import of the purchased goods.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [dutyAmount] As String
            Get
                Return _dutyAmount
            End Get
            Set(value As String)
                _dutyAmount = value
            End Set
        End Property

        Private _destinationZip As String
        ''' <summary> 
        ''' This is the postal/zip code of the address to which the purchased goods will be delivered. This field can be identical to the shipFromZip if the customer is present and takes immediate possession of the goods.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [destinationZip] As String
            Get
                Return _destinationZip
            End Get
            Set(value As String)
                _destinationZip = value
            End Set
        End Property

        Private _destinationCountry As String
        ''' <summary> 
        ''' This is the country to which the goods are being shipped. See�Country Codes.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [destinationCountry] As String
            Get
                Return _destinationCountry
            End Get
            Set(value As String)
                _destinationCountry = value
            End Set
        End Property

        Private _shipFromZip As String
        ''' <summary> 
        ''' This is the postal/zip code of the address from which the purchased goods are being shipped.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [shipFromZip] As String
            Get
                Return _shipFromZip
            End Get
            Set(value As String)
                _shipFromZip = value
            End Set
        End Property

        Private _lineItems As New List(Of lineItems)
        ''' <summary> 
        ''' This is more detailed information about the items that are being purchased.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [lineItems] As List(Of lineItems)
            Get
                Return _lineItems
            End Get
            Set(value As List(Of lineItems))
                _lineItems = value
            End Set
        End Property

#Region "Disposable Support"

        Private disposedValue As Boolean ' To detect redundant calls

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                End If
            End If
            disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
        End Sub

#End Region

    End Class

End Namespace
