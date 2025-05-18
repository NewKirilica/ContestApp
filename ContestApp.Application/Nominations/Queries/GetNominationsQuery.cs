using MediatR;
using ContestApp.Domain.Entities;
using ContestApp.Domain.Abstractions;

namespace ContestApp.Application.Nominations.Queries;

public record GetNominationsQuery : IRequest<List<Nomination>>;

public class GetNominationsQueryHandler : IRequestHandler<GetNominationsQuery, List<Nomination>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetNominationsQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Nomination>> Handle(GetNominationsQuery request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.Nominations.ListAllAsync(cancellationToken);
        return result.ToList();
    }
}
