namespace OmniBiz.Core.Entities;

public class Service {
    public Guid Id { get; set; }
    public Guid BusinessId { get; set; }
    public string Title { get; set; }
    public int DurationMinutes { get; set; }
    public decimal Price { get; set; }
}