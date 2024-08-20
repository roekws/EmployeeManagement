using Domain.Enums;

namespace Domain.Entities
{
  public class Notification
  {
    // Details
    public string Message { get; set; } = null!;

    public NotificationType Type { get; set; }

    public bool IsRead { get; set; }

    // Audit
    public DateTime? ModifiedAt { get; set; }

    public DateTime CreatedAt { get; set; }
  }
}
