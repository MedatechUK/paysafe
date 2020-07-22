Namespace PaySafe
    Public Class transaction : Implements IDisposable

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

        Private _currencyCode As Constant.ISO.tCurrency
        ''' <summary> 
        '''This is the currency of the merchant account, e.g., USD or CAD, returned in the request response.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property currencyCode As Constant.ISO.tCurrency
            Get
                Return _currencyCode
            End Get
            Set(value As Constant.ISO.tCurrency)
                _currencyCode = value
            End Set
        End Property

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            ' TODO: uncomment the following line if Finalize() is overridden above.
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Namespace
