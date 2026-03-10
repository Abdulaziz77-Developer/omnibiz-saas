namespace OmniBiz.Core.Entities;

public class Invoice {
    public Guid Id { get; set; }
    public Guid BusinessId { get; set; }
    public Guid BookingId { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; } // Unpaid, Paid, Overdue
}