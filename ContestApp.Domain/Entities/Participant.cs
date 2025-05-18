namespace ContestApp.Domain.Entities;

public class Participant
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // ФИО участника

    public int Points { get; set; } // ← Обязательное свойство по варианту: количество баллов

    public int Age { get; set; }
    public string Country { get; set; } = string.Empty;

    // Навигационные свойства
    public int NominationId { get; set; }  // внешний ключ
    public Nomination Nomination { get; set; } = default!;
}
