using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Models.Department;

public class DepartmentUserPublishData
{
  public Guid UserId { get; }
  public Guid? DepartmentId { get; }
  public DepartmentUserRole? Role { get; set; }
  public DepartmentUserAssignment? Assignment { get; set; }
  public bool? IsActive { get; }

  public DepartmentUserPublishData(
    Guid userId,
    Guid? departmentId = null,
    DepartmentUserRole? role = null,
    DepartmentUserAssignment? assignment = null,
    bool? isActive = null)
  {
    UserId = userId;
    DepartmentId = departmentId;
    Role = role;
    Assignment = assignment;
    IsActive = isActive;
  }
}
