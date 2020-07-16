Public Class cardExpiry

    Private _month As Integer
    ''' <summary> 
    '''This is the month the card expires.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property month As Integer
        Get
            Return _month
        End Get
        Set(value As Integer)
            _month = value
        End Set
    End Property

    Private _year As Integer
    ''' <summary> 
    '''This is the year the card expires.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property


End Class
