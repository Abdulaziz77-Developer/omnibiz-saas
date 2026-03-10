namespace OmniBiz.Core.Entities;

public class Booking {
    public Guid Id { get; set; }
    public Guid BusinessId { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ResourceId { get; set; }
    public DateTime StartTime { get; set; }
    public string Status { get; set; } // Pending, Confirmed, Completed, Canceled
}