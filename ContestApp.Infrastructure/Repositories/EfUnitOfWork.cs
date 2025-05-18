using ContestApp.Domain.Abstractions;
using ContestApp.Domain.Entities;
using ContestApp.Infrastructure.Data;

namespace ContestApp.Infrastructure.Repositories;

public class EfUnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IRepository<Nomination> Nominations { get; }
    public IRepository<Participant> Participants { get; }

    public EfUnitOfWork(AppDbContext context)
    {
        _context = context;
        Nominations = new EfRepository<Nomination>(context);
        Participants = new EfRepository<Participant>(context);
    }

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}
