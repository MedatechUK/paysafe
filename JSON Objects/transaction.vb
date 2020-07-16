Public Class transaction

    Private _amount As Integer
    ''' <summary> 
    '''This is the amount of the request, in minor units.
    '''For example, to process US $10.99, this value should be 1099. To process 1000 Japanese yen, this value should be 1000. 
    '''To process 10.139 Tunisian dinar, this value should be 10139.
    '''Note: For a currency that has 3 decimal units, our system will half round up the least significant digit. 
    '''Therefore, a transaction of 10.139 Tunisian dinar would be processed as 10.14.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property amount As Integer
        Get
            Return _amount
        End Get
        Set(value As Integer)
            _amount = value
        End Set
    End Property

    Private _currencyCode As tCurrency
    ''' <summary> 
    '''This is the currency of the merchant account, e.g., USD or CAD, returned in the request response.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property currencyCode As tCurrency
        Get
            Return _currencyCode
        End Get
        Set(value As tCurrency)
            _currencyCode = value
        End Set
    End Property

End Class
