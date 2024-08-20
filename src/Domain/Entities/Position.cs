using Domain.Common;

namespace EmployeeManagement.Domian.Entities
{
  public class Position : BaseEntity, ISoftDelete
  {
    // Detail
    public string? Description { get; set; }

    // Relationships
    public List<Employee> Employees { get; set; } = new();

    // Audit
    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }
  }
}
