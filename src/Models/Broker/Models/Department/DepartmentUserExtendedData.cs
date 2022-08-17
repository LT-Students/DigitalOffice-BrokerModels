using System;

namespace LT.DigitalOffice.Models.Broker.Models.Department
{
  public class DepartmentUserExtendedData
  {
    public Guid UserId { get; }
    public Guid DepartmenId { get; }
    public bool IsActive { get; }

    public DepartmentUserExtendedData(
      Guid userId,
      Guid departmentId,
      bool isActive)
    {
      UserId = userId;
      DepartmenId = departmentId;
      IsActive = isActive;
    }
  }
}
