Imports MedatechUK.PaySafe

Module Module1

    Sub Main()

        'Dim r As New Monitor("this")
        Settings.APIkey = "YOUR-BASE64-ENCODED-API-KEY"
        Settings.baseUrl = "https://api.test.paysafe.com/customervault/"

        Using prof As New PaySafe.profiles
            With prof
                Using p As New Request.Profile.Create(prof)
                    With p.Result

                    End With
                End Using
                Using p As New Request.Profile.Get("1234", "cards,addresses")

                End Using

            End With

        End Using

    End Sub

End Module
