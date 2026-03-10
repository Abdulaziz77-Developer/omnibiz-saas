namespace OmniBiz.Core.Entities;

public class Customer {
    public Guid Id { get; set; }
    public Guid BusinessId { get; set; } // Для изоляции данных
    public string FullName { get; set; }
    public string Phone { get; set; }
}