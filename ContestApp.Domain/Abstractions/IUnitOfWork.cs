using ContestApp.Domain.Entities;

namespace ContestApp.Domain.Abstractions;

public interface IUnitOfWork
{
    IRepository<Nomination> Nominations { get; }
    IRepository<Participant> Participants { get; }

    Task SaveAsync();
}
