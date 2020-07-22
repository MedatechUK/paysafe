Public Enum tverificationStatus
    RECEIVED '  Our system has received the request and is waiting for the downstream processors response.
    COMPLETED '  The transaction has been completed.
    FAILED '  The transaction failed, due to either an error or being declined.

End Enum
