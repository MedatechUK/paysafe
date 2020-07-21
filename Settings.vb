Imports System.Text

Namespace PaySafe

    Public Class Settings : Implements IDisposable

        Private _APIUser As String = ""
        Public Property APIUser As String
            Get
                Return _APIUser
            End Get
            Set(value As String)
                _APIUser = value
            End Set
        End Property

        Private _BaseURL As String = "https://api.test.paysafe.com/customervault/"
        Public Property baseUrl As String
            Get
                Return _BaseURL
            End Get
            Set(value As String)
                _BaseURL = value
            End Set
        End Property

        Private _APIKey As String = "YOUR-BASE64-ENCODED-API-KEY"
        Public Property APIkey As String
            Get
                Return _APIKey
            End Get
            Set(value As String)
                _APIKey = value
            End Set
        End Property

        Public ReadOnly Property Auth As String
            Get
                Return String.Format("Basic {0}",
                    System.Convert.ToBase64String(
                        ASCIIEncoding.ASCII.GetBytes(
                            String.Format(
                                "{0}:{1}",
                                APIUser,
                                APIkey
                            )
                        )
                    )
                ).ToString()
            End Get
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