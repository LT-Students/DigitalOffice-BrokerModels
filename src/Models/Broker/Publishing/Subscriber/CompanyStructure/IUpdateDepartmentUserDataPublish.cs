using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;

public interface IUpdateDepartmentUserDataPublish
{
  Guid UserId { get; set; }
  Guid? DepartmentId { get; set; }
  DepartmentUserRole? Role { get; set; }
  DepartmentUserAssignment? Assignment { get; set; }
  bool? IsActive { get; set; }
  Guid ModifiedBy { get; set; }

  static object CreateObj(
    Guid userId,
    Guid? departmentId,
    DepartmentUserRole? role,
    DepartmentUserAssignment? assignment,
    bool? isActive,
    Guid modifiedBy)
  {
    return new
    {
      UserId = userId,
      DepartmentId = departmentId,
      Role = role,
      Assignment = assignment,
      IsActive = isActive,
      ModifiedBy = modifiedBy
    };
  }
}
