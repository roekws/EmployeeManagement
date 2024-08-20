using Domain.Common;
using Domain.Enums;
using EmployeeManagement.Domian.Entities;

namespace Domain.Entities
{
  internal class WorkTask : BaseEntity, ISoftDelete, IAuditable
  {
    // Details
    public string? Description { get; set; }

    public TaskPriority Priority { get; set; }

    public TaskState State { get; set; }

    // Relationships
    public long CreatorId { get; set; }

    public Employee Creator { get; set; } = null!;

    public long? MainTaskid { get; set; }

    public List<Employee> AssignedPersons { get; set; } = new();

    public List<Task> Subtasks { get; set; } = new();

    // Audit
    public DateTime? CompletedAt { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime CreatedAt { get; set; }
  }
}
