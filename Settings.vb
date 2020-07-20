Namespace PaySafe.Settings

    Module Settings

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

    End Module

End Namespace