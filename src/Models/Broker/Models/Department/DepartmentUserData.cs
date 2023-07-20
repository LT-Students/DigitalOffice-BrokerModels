using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace LT.DigitalOffice.Models.Broker.Models.Department;

public class DepartmentUserData
{
  public Guid UserId { get; }
  public DepartmentUserRole Role { get; }
  public bool IsActive { get; }

  public DepartmentUserData(
    Guid userId,
    DepartmentUserRole role,
    bool isActive)
  {
    UserId = userId;
    Role = role;
    IsActive = isActive;
  }
}
