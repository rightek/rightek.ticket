namespace Rightek.Ticket.Domain.Entities;

public class Label : Entity
{
    public string Title { get; set; }
    public string BgColor { get; set; }
    public string FgColor { get; set; }
}