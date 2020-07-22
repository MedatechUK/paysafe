Namespace PaySafe.Vault

    Public Class recipient : Implements IDisposable

        Private _dateOfBirth As dateOfBirth
        ''' <summary> 
        '''This is the recipient's date of birth.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property dateOfBirth As dateOfBirth
            Get
                Return _dateOfBirth
            End Get
            Set(value As dateOfBirth)
                _dateOfBirth = value
            End Set
        End Property

        Private _zip As String
        ''' <summary> 
        '''This is the recipient's postcode.
        '''Note: The last 3 characters are not sent to the banking network.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property zip As String
            Get
                Return _zip
            End Get
            Set(value As String)
                _zip = value
            End Set
        End Property

        Private _lastName As String
        ''' <summary> 
        '''This is the recipient's last name.
        '''Note: Only the first 6 characters are sent to the banking network.
        ''' </summary> 
        ''' <returns></returns> 
        Public Property lastName As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                _lastName = value
            End Set
        End Property

        Private _accountNumber As String
        ''' <summary> 
        '''This is the recipient's account number, e.g., a loan agreement number or customer ID. 
        '''In the case where the recipient account is a prepaid card, the card number may be sent in full.
        '''Note: Only the first 6 and last 4 characters are sent to the banking network and will be masked accordingly 
        '''within the back office and any other reports, to comply with PCI regulations.
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
