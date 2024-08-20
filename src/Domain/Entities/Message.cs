using EmployeeManagement.Domian.Entities;

namespace Domain.Entities
{
  public class Message
  {
    // Details
    public string Content { get; set; } = null!;

    public bool IsRead { get; set; }

    // Relationships
    public long SenderId { get; set; }

    public Employee Sender { get; set; } = null!;

    public long ChatId { get; set; }

    public Chat Chat { get; set; } = null!;

    // Audit
    public DateTime? ModifiedAt { get; set; }

    public DateTime CreatedAt { get; set; }
  }
}
