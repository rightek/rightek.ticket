namespace Rightek.Ticket.Domain.Entities;

public class Project : Entity
{
    public int CustomerId { get; set; }
    public string Title { get; set; }
    public string Json { get; set; }
}