using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Publishing.Subscriber.CompanyStructure;

public interface IUpdateDepartmentUsersDataPublish
{
  List<Guid> UsersIds { get; set; }
  Guid? DepartmentId { get; set; }
  DepartmentUserRole? Role { get; set; }
  DepartmentUserAssignment? Assignment { get; set; }
  bool? IsActive { get; set; }
  Guid ModifiedBy { get; set; }

  static object CreateObj(
    List<Guid> usersIds,
    Guid? departmentId,
    DepartmentUserRole? role,
    DepartmentUserAssignment? assignment,
    bool? isActive,
    Guid modifiedBy)
  {
    return new
    {
      UsersIds = usersIds,
      DepartmentId = departmentId,
      Role = role,
      Assignment = assignment,
      IsActive = isActive,
      ModifiedBy = modifiedBy
    };
  }
}
