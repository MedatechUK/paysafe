Namespace PaySafe.Payment

Public Class [auths] : Implements IDisposable

Private _id As String
''' <summary> 
''' This is the ID returned in the response. This ID can be used for future associated requests.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [id] As String 
Get 
Return _id
End Get 
Set(value As String) 
_id = value
End Set
End Property

Private _merchantRefNum As String
''' <summary> 
''' This is the merchant reference number created by the merchant and submitted as part of the request. It must be unique for each request.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [merchantRefNum] As String 
Get 
Return _merchantRefNum
End Get 
Set(value As String) 
_merchantRefNum = value
End Set
End Property

Private _amount As String
''' <summary> 
''' This is the amount of the request, in minor units. For example, to process US $10.99, this value should be 1099. To process 1000 Japanese yen, this value should be 1000. To process 10.139 Tunisian dinar, this value should be 10139.
''' Note:�If the merchant account is set up for a currency that has 3 decimal units, our system will half round up the least significant digit. Therefore, a transaction of 10.139 Tunisian dinar would be processed as 10.14.
''' </summary> 
''' <returns></returns> 
Public Property [amount] As String 
Get 
Return _amount
End Get 
Set(value As String) 
_amount = value
End Set
End Property

Private _settleWithAuth As String
''' <summary> 
''' This indicates whether the request is an Authorization only (no Settlement), or a Purchase (Authorization and Settlement).
''' false � The request is not settled
''' true � The request is settled
''' 
''' Note:�If the merchant wants to find out whether an Authorization has been settled, they should check the�availableToSettle�element. If the amount is 0, the Authorization has been fully settled.
''' </summary> 
''' <returns></returns> 
Public Property [settleWithAuth] As String 
Get 
Return _settleWithAuth
End Get 
Set(value As String) 
_settleWithAuth = value
End Set
End Property

Private _availableToSettle As String
''' <summary> 
''' This is the amount of of the Authorization remaining to settle, in minor units.
''' </summary> 
''' <returns></returns> 
Public Property [availableToSettle] As String 
Get 
Return _availableToSettle
End Get 
Set(value As String) 
_availableToSettle = value
End Set
End Property

Private _childAccountNum As String
''' <summary> 
''' This is the child merchant account number. It is returned only if the transaction was processed via a master account.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [childAccountNum] As String 
Get 
Return _childAccountNum
End Get 
Set(value As String) 
_childAccountNum = value
End Set
End Property

Private _card As String
''' <summary> 
''' These are the details of the card used.
''' </summary> 
''' <returns></returns> 
Public Property [card] As String 
Get 
Return _card
End Get 
Set(value As String) 
_card = value
End Set
End Property

Private _authentication As String
''' <summary> 
''' These are 3D Secure details.
''' </summary> 
''' <returns></returns> 
Public Property [authentication] As String 
Get 
Return _authentication
End Get 
Set(value As String) 
_authentication = value
End Set
End Property

Private _authCode As String
''' <summary> 
''' This is the Authorization code assigned by the issuing bank and returned in the response.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [authCode] As String 
Get 
Return _authCode
End Get 
Set(value As String) 
_authCode = value
End Set
End Property

Private _profile As String
''' <summary> 
''' These are some details about the customer.
''' </summary> 
''' <returns></returns> 
Public Property [profile] As String 
Get 
Return _profile
End Get 
Set(value As String) 
_profile = value
End Set
End Property

Private _billingDetails As String
''' <summary> 
''' These are the billing details for the request.
''' </summary> 
''' <returns></returns> 
Public Property [billingDetails] As String 
Get 
Return _billingDetails
End Get 
Set(value As String) 
_billingDetails = value
End Set
End Property

Private _shippingDetails As String
''' <summary> 
''' These are the shipping details for the request.
''' </summary> 
''' <returns></returns> 
Public Property [shippingDetails] As String 
Get 
Return _shippingDetails
End Get 
Set(value As String) 
_shippingDetails = value
End Set
End Property

Private _recurring As String
''' <summary> 
''' This indicates whether this is an initial or repeat transaction for a customer for whom you will be processing recurring transactions. The Recurring Indicator is used to identify transactions that are eligible for repeat processing. The merchant should identity the initial transaction processed with full billing information including the card security code (CVV) by setting the recurring indicator to �INITIAL�. Subsequent charges to the same card can be identified with the recurring indicator set to �RECURRING�. For these transactions the card security code is not required and could not be passed in because card regulations do not allow merchants to store it.
''' INITIAL
''' RECURRING
''' 
''' Note:�Not all processing gateways support this parameter. Contact your account manager for more information. You cannot include both the�recurring�parameter and the�storedCredential�object in the same authorization request. Paysafe recommends using the�storedCredential�object.
''' </summary> 
''' <returns></returns> 
Public Property [recurring] As String 
Get 
Return _recurring
End Get 
Set(value As String) 
_recurring = value
End Set
End Property

Private _storedCredential As String
''' <summary> 
''' This object is used to identify requests that use stored credentials that the merchant has on file for the consumer, in order to improve authorization rates and reduce fraud.
''' Note:�You cannot include both the�recurring�parameter and the�storedCredential�object in the same authorization request. Paysafe recommends using the�storedCredential�object.
''' </summary> 
''' <returns></returns> 
Public Property [storedCredential] As String 
Get 
Return _storedCredential
End Get 
Set(value As String) 
_storedCredential = value
End Set
End Property

Private _customerIp As String
''' <summary> 
''' This is the customer's IP address.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [customerIp] As String 
Get 
Return _customerIp
End Get 
Set(value As String) 
_customerIp = value
End Set
End Property

Private _dupCheck As String
''' <summary> 
''' This validates that this request is not a duplicate. A request is considered a duplicate if the�merchantRefNum�has already been used in a previous request within the past 90 days.
''' Note:�This value defaults to�true.
''' </summary> 
''' <returns></returns> 
Public Property [dupCheck] As String 
Get 
Return _dupCheck
End Get 
Set(value As String) 
_dupCheck = value
End Set
End Property

Private _keywords As String
''' <summary> 
''' This value can be any text the merchant wants to use, e.g., the merchant could use this as a tag to identify the transaction or the product purchased at their site. You can search on keywords in the merchant back office reporting tools.
''' Note:�The maximum number of keywords allowed in a request is 10.
''' </summary> 
''' <returns></returns> 
Public Property [keywords] As String 
Get 
Return _keywords
End Get 
Set(value As String) 
_keywords = value
End Set
End Property

Private _merchantDescriptor As String
''' <summary> 
''' This is the merchant descriptor that will be displayed on the customer's card statement.
''' Note:�Not all processing gateways support this parameter. Contact your account manager for more information.
''' </summary> 
''' <returns></returns> 
Public Property [merchantDescriptor] As String 
Get 
Return _merchantDescriptor
End Get 
Set(value As String) 
_merchantDescriptor = value
End Set
End Property

Private _accordD As String
''' <summary> 
''' These are parameters for financing plans supported for certain merchant configurations.
''' Include this element�only when�instructed to do so by your account manager.
''' </summary> 
''' <returns></returns> 
Public Property [accordD] As String 
Get 
Return _accordD
End Get 
Set(value As String) 
_accordD = value
End Set
End Property

Private _description As String
''' <summary> 
''' This is a description of the transaction, provided by the merchant.
''' 
''' </summary> 
''' <returns></returns> 
Public Property [description] As String 
Get 
Return _description
End Get 
Set(value As String) 
_description = value
End Set
End Property

Private _txnTime As String
''' <summary> 
''' This is the date and time the request was processed. For example:
''' 2014-01-26T10:32:28Z
''' </summary> 
''' <returns></returns> 
Public Property [txnTime] As String 
Get 
Return _txnTime
End Get 
Set(value As String) 
_txnTime = value
End Set
End Property

Private _currencyCode As String
''' <summary> 
''' This is the currency of the merchant account, e.g., USD or CAD, returned in the request response. See�Currency Codes
''' 
''' </summary> 
''' <returns></returns> 
Public Property [currencyCode] As String 
Get 
Return _currencyCode
End Get 
Set(value As String) 
_currencyCode = value
End Set
End Property

Private _avsResponse As String
''' <summary> 
''' This is the AVS response from the card issuer. Possible values are:
''' MATCH
''' MATCH_ADDRESS_ONLY
''' MATCH_ZIP_ONLY
''' NO_MATCH
''' NOT_PROCESSED
''' UNKNOWN
''' </summary> 
''' <returns></returns> 
Public Property [avsResponse] As String 
Get 
Return _avsResponse
End Get 
Set(value As String) 
_avsResponse = value
End Set
End Property

Private _cvvVerification As String
''' <summary> 
''' This is the response to the�cvv�submitted with the transaction request. Possible values are:
''' MATCH
''' NO_MATCH
''' NOT_PROCESSED
''' UNKNOWN
''' </summary> 
''' <returns></returns> 
Public Property [cvvVerification] As String 
Get 
Return _cvvVerification
End Get 
Set(value As String) 
_cvvVerification = value
End Set
End Property

Private _error As String
''' <summary> 
''' 
''' </summary> 
''' <returns></returns> 
Public Property [error] As String 
Get 
Return _error
End Get 
Set(value As String) 
_error = value
End Set
End Property

Private _status As String
''' <summary> 
''' This is the status of the transaction request. Possible values are:
''' RECEIVED � Our system has received the request and is waiting for the downstream processor�s response.
''' COMPLETED � The transaction has been completed.
''' HELD � The transaction has been placed on hold due to risk considerations.
''' FAILED � The transaction failed, due to either an error or being declined.
''' CANCELLED � The request has been fully voided (reversed).
''' </summary> 
''' <returns></returns> 
Public Property [status] As String 
Get 
Return _status
End Get 
Set(value As String) 
_status = value
End Set
End Property

Private _riskReasonCode As String
''' <summary> 
''' An array of integers is returned, displaying the detailed Risk reason codes if your transaction was declined. It is returned only if your account is configured accordingly.
''' </summary> 
''' <returns></returns> 
Public Property [riskReasonCode] As String 
Get 
Return _riskReasonCode
End Get 
Set(value As String) 
_riskReasonCode = value
End Set
End Property

Private _acquirerResponse As String
''' <summary> 
''' This is the raw response returned by an acquirer. It is returned only if your account is configured accordingly.
''' </summary> 
''' <returns></returns> 
Public Property [acquirerResponse] As String 
Get 
Return _acquirerResponse
End Get 
Set(value As String) 
_acquirerResponse = value
End Set
End Property

Private _recipient As String
''' <summary> 
''' In certain cases, this allows additional data to be included with a payment request.
''' </summary> 
''' <returns></returns> 
Public Property [recipient] As String 
Get 
Return _recipient
End Get 
Set(value As String) 
_recipient = value
End Set
End Property

Private _level2level3 As String
''' <summary> 
''' This allows merchants who are enabled to provide additional L2/L3 transaction data.
''' Note:�Not all processing gateways support this parameter. Contact your account manager for more information.
''' </summary> 
''' <returns></returns> 
Public Property [level2level3] As String 
Get 
Return _level2level3
End Get 
Set(value As String) 
_level2level3 = value
End Set
End Property

Private _splitpay As String
''' <summary> 
''' This enables you to use the Split Payouts functionality when authorizing with a Settlement.
''' </summary> 
''' <returns></returns> 
Public Property [splitpay] As String 
Get 
Return _splitpay
End Get 
Set(value As String) 
_splitpay = value
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
