using Domain.Common;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Domian.Entities
{
  public class Employee : BaseEntity, ISoftDelete
  {
    //Details
    [Required]
    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    // Relationships
    [Required]
    public int PositionId { get; set; }

    public Position? Position { get; set; }

    [Required]
    public int DepartmentId { get; set; }

    public Department? Department { get; set; }

    // Audit
    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }
  }
}
