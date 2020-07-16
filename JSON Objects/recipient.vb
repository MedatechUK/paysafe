Public Class recipient

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

End Class
