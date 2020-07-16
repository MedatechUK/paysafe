Module Currency
    Public Enum tCurrency
        ARS = 1
        AUD = 2
        AZN = 3
        BHD = 4
        BYR = 5
        BOB = 6
        BAM = 7
        BRL = 8
        BGN = 9
        CAD = 10
        CLP = 11
        CNY = 12
        COP = 13
        CRC = 14
        HRK = 15
        CZK = 16
        DKK = 17
        DOP = 18
        XCD = 19
        EGP = 20
        ETB = 21
        EUR = 22
        FJD = 23
        GEL = 24
        GTQ = 25
        HTG = 26
        HNL = 27
        HKD = 28
        HUF = 29
        ISK = 30
        INR = 31
        IDR = 32
        IRR = 33
        JMD = 34
        JPY = 35
        JOD = 36
        KZT = 37
        KES = 38
        KRW = 39
        KWD = 40
        LVL = 41
        LBP = 42
        LYD = 43
        LTL = 44
        MWK = 45
        MYR = 46
        MUR = 47
        MXN = 48
        MDL = 49
        MAD = 50
        ILS = 51
        NZD = 52
        NGN = 53
        NOK = 54
        OMR = 55
        PKR = 56
        PAB = 57
        PYG = 58
        PEN = 59
        PHP = 60
        PLN = 61
        GBP = 62
        QAR = 63
        RON = 64
        RUB = 65
        SAR = 66
        RSD = 67
        SGD = 68
        ZAR = 69
        LKR = 70
        SEK = 71
        CHF = 72
        SYP = 73
        TWD = 74
        THB = 75
        TTD = 76
        TND = 77
        UAH = 79
        AED = 80
        UYU = 81
        USD = 82
        VEF = 83
        VND = 84

    End Enum

    Public Function CurrencyName(c As tCurrency) As String
        Select Case c
            Case 1 : Return "Argentine Peso"
            Case 2 : Return "Australian Dollar"
            Case 3 : Return "Azerbaijanian Manat"
            Case 4 : Return "Bahraini Dinar"
            Case 5 : Return "Belarusian Ruble"
            Case 6 : Return "Bolivian Boliviano"
            Case 7 : Return "Bosnia and Herzegovina Convertible Mark"
            Case 8 : Return "Brazilian Real"
            Case 9 : Return "Bulgarian Lev"
            Case 10 : Return "Canadian Dollar"
            Case 11 : Return "Chilean Peso"
            Case 12 : Return "China Yuan Renminbi"
            Case 13 : Return "Columbian Peso"
            Case 14 : Return "Costa Rican Colon"
            Case 15 : Return "Croatian Kuna"
            Case 16 : Return "Czech Koruna"
            Case 17 : Return "Danish Krone"
            Case 18 : Return "Dominican Peso"
            Case 19 : Return "East Caribbean Dollar"
            Case 20 : Return "Egyptian Pound"
            Case 21 : Return "Ethiopian Birr"
            Case 22 : Return "Euro"
            Case 23 : Return "Fiji Dollar"
            Case 24 : Return "Georgian Lari"
            Case 25 : Return "Guatemala Quetzal"
            Case 26 : Return "Haiti Goude"
            Case 27 : Return "Honduran Lempira"
            Case 28 : Return "Hong Kong Dollar"
            Case 29 : Return "Hungarian Forint"
            Case 30 : Return "Iceland Krona"
            Case 31 : Return "Indian Rupee"
            Case 32 : Return "Indonesia Rupiah"
            Case 33 : Return "Iranian Rial"
            Case 34 : Return "Jamaican Dollar"
            Case 35 : Return "Japanese Yen"
            Case 36 : Return "Jordanian Dinar"
            Case 37 : Return "Kazakhstan Tenge"
            Case 38 : Return "Kenyan Shilling"
            Case 39 : Return "Korean Won"
            Case 40 : Return "Kuwaiti Dinar"
            Case 41 : Return "Latvian Lats"
            Case 42 : Return "Lebanese Pound"
            Case 43 : Return "Libyan Dinars"
            Case 44 : Return "Lithuanian Litas"
            Case 45 : Return "Malawi Kwacha"
            Case 46 : Return "Malaysian Ringotgit"
            Case 47 : Return "Mauritius Rupee"
            Case 48 : Return "Mexican Peso"
            Case 49 : Return "Moldovan Leu"
            Case 50 : Return "Moroccan Dirham"
            Case 51 : Return "New Israeli Shekel"
            Case 52 : Return "New Zealand Dollar"
            Case 53 : Return "Nigerian Naira"
            Case 54 : Return "Norwegian Krone"
            Case 55 : Return "Omani Rial"
            Case 56 : Return "Pakistan Rupee"
            Case 57 : Return "Panamanian Balboa"
            Case 58 : Return "Paraguayan Guarani"
            Case 59 : Return "Peruvian Sol"
            Case 60 : Return "Philippine Peso"
            Case 61 : Return "Polish Zloty"
            Case 62 : Return "Pound Sterling"
            Case 63 : Return "Qatari Rial"
            Case 64 : Return "Romanian New Leu"
            Case 65 : Return "Russian Ruble"
            Case 66 : Return "Saudi Arabian Riyal"
            Case 67 : Return "Serbian Dinar"
            Case 68 : Return "Singapore Dollar"
            Case 69 : Return "South African Rand"
            Case 70 : Return "Sri Lanka Rupee"
            Case 71 : Return "Swedish Krona"
            Case 72 : Return "Swiss Franc"
            Case 73 : Return "Syrian Pound"
            Case 74 : Return "Taiwan New Dollar"
            Case 75 : Return "Thai Baht"
            Case 76 : Return "Trinidad and Tobago Dollar"
            Case 77 : Return "Tunisian Dinar"
            Case 78 : Return "Turkish Lira"
            Case 79 : Return "Ukranian Hryunia"
            Case 80 : Return "UAE Dirham"
            Case 81 : Return "Uruguay Peso"
            Case 82 : Return "US Dollar"
            Case 83 : Return "Venezuelan Bolivar"
            Case 84 : Return "Viet Nam Dong"
            Case Else : Throw New Exception("Invalid Country Code.")

        End Select
    End Function

End Module
