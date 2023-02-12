using Microsoft.EntityFrameworkCore;

using Rightek.Ticket.Domain.Entities;

namespace Rightek.Ticket.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<Issue_Label> Issue_Labels { get; set; }
    public DbSet<Issue_Project> Issue_Projects { get; set; }
    public DbSet<IssueComment> IssueComments { get; set; }
    public DbSet<IssueParticipant> IssueParticipants { get; set; }
    public DbSet<Label> Labels { get; set; }
    public DbSet<PreparedResponse> PreparedResponses { get; set; }
    public DbSet<Project> Projects { get; set; }
}