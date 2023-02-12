using Rightek.Ticket.Domain.Enum;

namespace Rightek.Ticket.Domain.Entities;

public class Issue : Entity
{
    public int CreatedBy { get; set; }
    public int DepartmentId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public IssueStatus Status { get; set; }
    public string Json { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
}