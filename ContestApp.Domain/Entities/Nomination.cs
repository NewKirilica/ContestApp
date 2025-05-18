namespace ContestApp.Domain.Entities;

public class Nomination
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty; // Название номинации
    public string Description { get; set; } = string.Empty; // Доп. свойство, например описание

    // Навигационное свойство: список участников
    public ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
