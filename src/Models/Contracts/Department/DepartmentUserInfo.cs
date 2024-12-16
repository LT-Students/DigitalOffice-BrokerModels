using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Contracts.Department
{
  public record DepartmentUserInfo
  {
    public Guid UserId { get; init; }
    public bool IsActive { get; init; }
    public DepartmentUserRole Role { get; init; }
    public DepartmentUserAssignment Assignment { get; init; }

    public DepartmentUserInfo(
      Guid userId,
      bool isActive,
      DepartmentUserRole role,
      DepartmentUserAssignment assignment)
    {
      UserId = userId;
      IsActive = isActive;
      Role = role;
      Assignment = assignment;
    }
  }
}
