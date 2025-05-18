using System.Collections.ObjectModel;
using System.Windows.Input;
using ContestApp.Domain.Entities;
using MediatR;
using ContestApp.Application.Nominations.Queries;

namespace ContestApp.UI.ViewModels;

public class NominationsViewModel
{
    private readonly IMediator _mediator;

    public ObservableCollection<Nomination> Nominations { get; set; } = new();

    public ICommand LoadNominationsCommand { get; }

    public NominationsViewModel(IMediator mediator)
    {
        _mediator = mediator;
        LoadNominationsCommand = new Command(async () => await LoadNominationsAsync());
    }

    private async Task LoadNominationsAsync()
    {
        var list = await _mediator.Send(new GetNominationsQuery());

        Nominations.Clear();
        foreach (var nomination in list)
            Nominations.Add(nomination);
    }
}
