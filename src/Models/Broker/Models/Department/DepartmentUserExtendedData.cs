using System;

namespace LT.DigitalOffice.Models.Broker.Models.Department;

public class DepartmentUserExtendedData
{
  public Guid UserId { get; }
  public Guid DepartmentId { get; }
  public bool IsActive { get; }
  public bool IsPending { get; }

  public DepartmentUserExtendedData(
    Guid userId,
    Guid departmentId,
    bool isActive,
    bool isPending)
  {
    UserId = userId;
    DepartmentId = departmentId;
    IsActive = isActive;
    IsPending = isPending;
  }
}
