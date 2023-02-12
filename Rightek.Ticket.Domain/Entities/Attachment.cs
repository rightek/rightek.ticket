namespace Rightek.Ticket.Domain.Entities;

public class Attachment : Entity
{
    public int? IssueId { get; set; }
    public int? IssueCommentId { get; set; }
    public string FileName { get; set; }
}