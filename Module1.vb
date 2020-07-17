Module Module1

    Public ReadOnly Property baseUrl As String
        Get
            Return "https://api.test.paysafe.com/customervault/"
        End Get
    End Property

    Public ReadOnly Property APIkey As String
        Get
            Return "YOUR-BASE64-ENCODED-API-KEY"
        End Get
    End Property

    Sub Main()

        'Dim r As New Monitor("this")

        Using prof As New profiles
            With prof
                Using p As New Profile.Create(prof)

                End Using
                Using p As New Profile.Get("1234", "cards,addresses")

                End Using

            End With

        End Using

    End Sub

End Module
