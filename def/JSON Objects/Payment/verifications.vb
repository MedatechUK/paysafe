Namespace PaySafe.Payment

Public Class [verifications] : Implements IDisposable

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
''' FAILED � The transaction failed, due to either an error or being declined.
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

Private _storedCredential As String
''' <summary> 
''' Identifies requests that use stored credentials that the merchant has on file for the consumer, in order to improve authorization rates and reduce fraud.
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
