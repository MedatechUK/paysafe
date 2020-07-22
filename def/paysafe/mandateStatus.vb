Public Enum tmandateStatus
    INITIAL ' The mandate has been created but is not ready to be batched
    PENDING ' The mandate is ready to be batched
    DECLINED ' The mandate was not accepted for batching
    BATCHED ' The mandate has been batched (sent into the bacs system)
    ACTIVE ' The mandate has been batch for more than 5 business days and no returns have been received that would invalidate it
    CANCELLED ' The mandate has been cancelled
    REJECTED ' A return has been received that prevents the mandate from being used in a transaction
    DISPUTED ' A return has been received that disputes the mandates validity
    INACTIVE ' The mandate has been deleted

End Enum
