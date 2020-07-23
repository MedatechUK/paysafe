Public Enum tauthStatus
    RECEIVED ' Our system has received the request and is waiting for the downstream processors response.
    COMPLETED ' The transaction has been completed.
    HELD ' The transaction has been placed On hold due To risk considerations.
    FAILED ' The transaction failed, due To either an Error Or being declined.
    CANCELLED ' The request has been fully voided (reversed).

End Enum
