using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Models.Department
{
  public class DepartmentUserInfo
  {
    public Guid UserId { get; }
    public DepartmentUserRole Role { get; }
    public DepartmentUserAssignment Assignment { get; }
    
    public DepartmentUserInfo(
      Guid userId,
      DepartmentUserRole role,
      DepartmentUserAssignment assignment)
    {
      UserId = userId;
      Role = role;
      Assignment = assignment;
    }
  }
}