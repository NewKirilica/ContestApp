using Microsoft.EntityFrameworkCore;
using ContestApp.Domain.Entities;

namespace ContestApp.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Nomination> Nominations { get; set; }
    public DbSet<Participant> Participants { get; set; }
}
