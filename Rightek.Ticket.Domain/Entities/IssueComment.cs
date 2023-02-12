namespace Rightek.Ticket.Domain.Entities;

public class IssueComment : Entity
{
    public int IssueId { get; set; }
    public int CreatedBy { get; set; }
    public string Body { get; set; }
    public string Json { get; set; }
    public DateTime CreatedAt { get; set; }
}