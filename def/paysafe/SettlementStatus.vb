Public Enum tSettlementStatus
    RECEIVED '  Our system has received the request and is waiting for the downstream processors response.
    PENDING '  Our system has received the request but it has not yet been batched.
    PROCESSING '  The Settlement batch has started.
    COMPLETED '  The transaction has been completed.
    FAILED '  The transaction failed, due to either an error or being declined.
    CANCELLED '  The transaction request has been cancelled.

End Enum
