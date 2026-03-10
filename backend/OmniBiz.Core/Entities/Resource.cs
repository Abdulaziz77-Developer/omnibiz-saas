namespace OmniBiz.Core.Entities;

public class Resource {
    public Guid Id { get; set; }
    public Guid BusinessId { get; set; }
    public string Name { get; set; } // Например: "Мастер", "Кабинет"
}