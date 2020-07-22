Namespace PaySafe.Payment

    Public Class [leg] : Implements IDisposable

        Private _flight As flight
        ''' <summary> 
        ''' Operating Carrier Code and the Number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
        ''' </summary> 
        ''' <returns></returns> 
        Public Property flight As flight
            Get
                Return _flight
            End Get
            Set(value As flight)
                _flight = value
            End Set
        End Property

        Private _serviceClass As String
        ''' <summary> 
        ''' Indicates service class (first class, business class, etc.). Example values (not limited to):
        ''' F - first class
        ''' J - business class
        ''' W - premium economy class
        ''' Y - economy class
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [serviceClass] As String
            Get
                Return _serviceClass
            End Get
            Set(value As String)
                _serviceClass = value
            End Set
        End Property

        Private _isStopOverAllowed As Boolean
        ''' <summary> 
        ''' Indicates whether a stopover is allowed on this ticket. Valid values are:
        ''' false - not allowed
        ''' true - allowed
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [isStopOverAllowed] As Boolean
            Get
                Return _isStopOverAllowed
            End Get
            Set(value As Boolean)
                _isStopOverAllowed = value
            End Set
        End Property

        Private _destination As String
        ''' <summary> 
        ''' Destination Airport Code (IATA Airport Code).Example �YUL�
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [destination] As String
            Get
                Return _destination
            End Get
            Set(value As String)
                _destination = value
            End Set
        End Property

        Private _fareBasis As String
        ''' <summary> 
        ''' Contains a Fare Basis Code for Leg that carriers assign to a particular ticket type, such as business class or discounted/nonrefundable.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [fareBasis] As String
            Get
                Return _fareBasis
            End Get
            Set(value As String)
                _fareBasis = value
            End Set
        End Property

        Private _departureDate As String
        ''' <summary> 
        ''' Date of passenger�s departure for this leg. Date format = YYYY-MM-DD, ISO 8601 expected. For example, 2014-01-26
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [departureDate] As String
            Get
                Return _departureDate
            End Get
            Set(value As String)
                _departureDate = value
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
    End Class

End Namespace
