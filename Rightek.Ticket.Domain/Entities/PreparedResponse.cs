namespace Rightek.Ticket.Domain.Entities;

public class PreparedResponse : Entity
{
    public int DepartmentId { get; set; }
    public string Body { get; set; }
}