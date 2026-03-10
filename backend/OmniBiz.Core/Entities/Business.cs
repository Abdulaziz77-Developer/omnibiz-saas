namespace OmniBiz.Core.Entities;

public class Business {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public DateTime CreatedAt { get; set; }
}