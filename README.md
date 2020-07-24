```C#
Imports MedatechUK.PaySafe
Imports MedatechUK.PaySafe.Vault
Imports MedatechUK.PaySafe.Payment

Module Module1

    Sub Main()

        Using settings As New MedatechUK.PaySafe.Settings
            With settings
                .APIUser = "YOUR-API-USER"
                .APIkey = "YOUR-BASE64-ENCODED-API-KEY"
                .baseUrl = "https://api.test.paysafe.com/"

            End With

            ' Check the validity of the token 
            Using verify As New Payment.Request.verify.Get(settings, "{account_id}", "{verification_id}")
                With verify
                    If Not .Result.GetType() Is GetType(ResponseErr) Then
                        ' todo:                   
                        ' handle the result

                    Else
                        Console.WriteLine(TryCast(.Result, ResponseErr).ToString)

                    End If
                End With
            End Using

            ' Raise a settlemet againt the token
            Using s As New settlements
                With s
                    .merchantRefNum = "{merchantRefNum}"
                    .amount = "1000"
                    .dupCheck = True
                    Using settle As New Payment.Request.settle.Create(settings, s, "{account_id}", "{auth_id}")
                        With settle
                            If Not .Result.GetType() Is GetType(ResponseErr) Then
                                ' todo:                   
                                ' handle the result

                            Else
                                Console.WriteLine(TryCast(.Result, ResponseErr).ToString)

                            End If
                        End With
                    End Using
                End With
            End Using

            ' Raise a refund against a token
            Using r As New refunds
                Using refund As New Payment.Request.refund.Create(settings, r, "{account_id}", "{settlement_id}")
                    With refund
                        If Not .Result.GetType() Is GetType(ResponseErr) Then
                            ' todo:                   
                            ' handle the result

                        Else
                            Console.WriteLine(TryCast(.Result, ResponseErr).ToString)

                        End If
                    End With
                End Using

            End Using

        End Using

    End Sub

End Module
```