Namespace PaySafe.Payment

    Public Class [profile] : Implements IDisposable

        Private _firstName As String
        ''' <summary> 
        ''' This is the customer�s first name.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [firstName] As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                _firstName = value
            End Set
        End Property

        Private _lastName As String
        ''' <summary> 
        ''' This is the customer's last name.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [lastName] As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                _lastName = value
            End Set
        End Property

        Private _email As String
        ''' <summary> 
        ''' This is the customer's email address.
        ''' 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property [email] As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
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
