Public Enum trefundStatus
    RECEIVED ' Our system has received the request and is waiting for the downstream processor's response.
    COMPLETED ' The transaction has been completed.
    PENDING ' Our system has received the request but it has not yet been batched.
    FAILED ' The transaction failed, due to either an error or being declined.
    CANCELLED ' The request has been fully voided (reversed).

End Enum
