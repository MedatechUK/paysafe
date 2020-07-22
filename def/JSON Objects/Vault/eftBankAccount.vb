﻿Namespace PaySafe.Vault
    Public Class eftBankAccount : Implements IDisposable

        Private _id As String
        ''' <summary> 
        '''This is the ID for the request, returned by Paysafe. It can be used later, e.g., to look up or update the bank account.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property id As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property

        Private _nickName As String
        ''' <summary> 
        '''This is an alias defined by the customer for the bank account (e.g., "CIBC Account").
        ''' </summary> 
        ''' <returns></returns> 
        Public Property nickName As String
            Get
                Return _nickName
            End Get
            Set(value As String)
                _nickName = value
            End Set
        End Property

        Private _merchantRefNum As String
        ''' <summary> 
        '''This is the merchant reference number created by the merchant and submitted as part of the request. 
        '''This value is only stored by the Paysafe system and has no bearing on the request.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property merchantRefNum As String
            Get
                Return _merchantRefNum
            End Get
            Set(value As String)
                _merchantRefNum = value
            End Set
        End Property

        Private _status As String
        ''' <summary> 
        '''This is the status of the request. Possible values are:
        '''ACTIVE – The bank account has been created.
        '''INVALID – The bank account is invalid.
        '''INACTIVE – The bank account has been deleted.
        '''Note: By default, the bank account is created with the status of ACTIVE.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property status As String
            Get
                Return _status
            End Get
            Set(value As String)
                _status = value
            End Set
        End Property

        Private _statusReason As String
        ''' <summary> 
        '''If the status is INVALID, this is a description of why the account is invalid (e.g., account closed).
        ''' </summary> 
        ''' <returns></returns> 
        Public Property statusReason As String
            Get
                Return _statusReason
            End Get
            Set(value As String)
                _statusReason = value
            End Set
        End Property

        Private _accountNumber As String
        ''' <summary> 
        '''This is the bank account number.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property accountNumber As String
            Get
                Return _accountNumber
            End Get
            Set(value As String)
                _accountNumber = value
            End Set
        End Property

        Private _accountHolderName As String
        ''' <summary> 
        '''This is the name of the customer or company that owns the bank account.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property accountHolderName As String
            Get
                Return _accountHolderName
            End Get
            Set(value As String)
                _accountHolderName = value
            End Set
        End Property

        Private _transitNumber As String
        ''' <summary> 
        '''This is the 5-digit transit number of the customer's bank branch.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property transitNumber As String
            Get
                Return _transitNumber
            End Get
            Set(value As String)
                _transitNumber = value
            End Set
        End Property

        Private _institutionId As String
        ''' <summary> 
        '''This is the 3-digit institution ID of the customer’s bank branch.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property institutionId As String
            Get
                Return _institutionId
            End Get
            Set(value As String)
                _institutionId = value
            End Set
        End Property

        Private _lastDigits As String
        ''' <summary> 
        '''This is the last two digits of the bank account number.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property lastDigits As String
            Get
                Return _lastDigits
            End Get
            Set(value As String)
                _lastDigits = value
            End Set
        End Property

        Private _billingAddressId As String
        ''' <summary> 
        '''This is the address ID returned in response to the request to create an address, which will be associated with this bank account.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property billingAddressId As String
            Get
                Return _billingAddressId
            End Get
            Set(value As String)
                _billingAddressId = value
            End Set
        End Property

        Private _paymentToken As String
        ''' <summary> 
        '''This is a token generated by Paysafe that represents the bank account and is returned in the response to the bank account creation request. 
        '''It can be used in the place of bank account information in Direct Debit transactions.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property paymentToken As String
            Get
                Return _paymentToken
            End Get
            Set(value As String)
                _paymentToken = value
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
