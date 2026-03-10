namespace OmniBiz.Core.Entities;

public class Notification {
    public Guid Id { get; set; }
    public Guid BusinessId { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }
}