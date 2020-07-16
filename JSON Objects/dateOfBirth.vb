Public Class dateOfBirth

    Sub New()

    End Sub

    Sub New(dt As Date)
        _year = dt.Year
        _month = dt.Month
        _day = dt.Day

    End Sub

    Private _year As Integer
    ''' <summary> 
    '''This is the year of birth.
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

    Private _month As Integer
    ''' <summary> 
    '''This is the month of birth.
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

    Private _day As Integer
    ''' <summary> 
    '''This is the day of birth.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property day As Integer
        Get
            Return _day
        End Get
        Set(value As Integer)
            _day = value
        End Set
    End Property


End Class
