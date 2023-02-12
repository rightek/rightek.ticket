namespace Rightek.Ticket.Domain.Enum;

public enum IssueStatus : byte
{
    // auto
    CLOSED,
    // auto
    OPEN,
    AWAITING_CUSTOMER_RESPONSE,
    // auto: after customer response
    CUSTOMER_RESPONSE,
    // auto: if issue is in 'AwaitingCustomerResponse' status and customer doesn't response in 72 hours
    ON_HOLD,
    // auto: if issue is in 'CustomerResponse' status and admin doesn't response in 12 hours
    NEEDS_REVIEW,
    IN_PROGRESS
}