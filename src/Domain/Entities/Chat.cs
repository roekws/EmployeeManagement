using Domain.Common;
using EmployeeManagement.Domian.Entities;

namespace Domain.Entities
{
  public class Chat : BaseEntity, IAuditable
  {
    // Relationships
    public long CreatorId { get; set; }

    public Employee Creator { get; set; } = null!;

    public List<Message> Messages { get; set; } = new();

    // Audit
    public DateTime? ModifiedAt { get; set; }

    public DateTime CreatedAt { get; set; }
  }
}
