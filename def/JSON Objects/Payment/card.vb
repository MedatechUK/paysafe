Namespace PaySafe.Payment

Public Class [card] : Implements IDisposable

Private _paymentToken As String
''' <summary> 
''' If the payment token is provided, no other card information is necessary.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [paymentToken] As String 
Get 
Return _paymentToken
End Get 
Set(value As String) 
_paymentToken = value
End Set
End Property


        Private _cardNum As String
        ''' <summary> 
        ''' This is the card number used for the request.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [cardNum] As String
            Get
                Return _cardNum
            End Get
            Set(value As String)
                _cardNum = value
            End Set
        End Property

        Private _type As String
        ''' <summary> 
        ''' This is the type of card used for the request, returned in the response. Possible values are:
        ''' AM ? American Express
        ''' DI ? Discover
        ''' JC ? JCB
        ''' MC ? Mastercard
        ''' MD ? Maestro
        ''' SO ? Solo
        ''' VI ? Visa
        ''' VD ? Visa Debit
        ''' VE ? Visa Electron
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [type] As String
            Get
                Return _type
            End Get
            Set(value As String)
                _type = value
            End Set
        End Property

        Private _lastDigits As String
        ''' <summary> 
        ''' This is the last four digits of the card used for the request.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [lastDigits] As String
            Get
                Return _lastDigits
            End Get
            Set(value As String)
                _lastDigits = value
            End Set
        End Property

        Private _cardExpiry As cardExpiry
        ''' <summary> 
        ''' This is the card's expiry date.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [cardExpiry] As cardExpiry
            Get
                Return _cardExpiry
            End Get
            Set(value As cardExpiry)
                _cardExpiry = value
            End Set
        End Property

        Private _cvv As String
        ''' <summary> 
        ''' This is the 3- or 4-digit security code that appears on the card following the card number.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [cvv] As String
            Get
                Return _cvv
            End Get
            Set(value As String)
                _cvv = value
            End Set
        End Property

        Private _track1 As String
        ''' <summary> 
        ''' This is Track 1 information read from the card's magnetic stripe.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [track1] As String
            Get
                Return _track1
            End Get
            Set(value As String)
                _track1 = value
            End Set
        End Property

        Private _track2 As String
        ''' <summary> 
        ''' This is Track 2 information read from the card's magnetic stripe.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [track2] As String
            Get
                Return _track2
            End Get
            Set(value As String)
                _track2 = value
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
end class

end Namespace
