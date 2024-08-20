using Domain.Common;
using EmployeeManagement.Domian.Entities;

namespace Domain.Entities
{
  public class Department : BaseEntity, ISoftDelete
  {
    // Details
    public string? Description { get; set; }

    public List<Employee> Employees { get; set; } = new();

    // Audit
    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }
  }
}
