using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Models.Department;

public class DepartmentUserRoleData
{
  public Guid Id { get; set; }
  public DepartmentUserRole Role { get; set; }
  public DepartmentUserAssignment Assignment { get; set; }

  public DepartmentUserRoleData(
    Guid id,
    DepartmentUserRole role,
    DepartmentUserAssignment assignment)
  {
    Id = id;
    Role = role;
    Assignment = assignment;
  }
}
