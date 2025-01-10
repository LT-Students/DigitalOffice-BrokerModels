using DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Enums;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IGetDepartmentsRequest
  {
    public List<Guid> DepartmentIds { get; set; }
    public List<Guid> UserIds { get; set; }
    public DepartmentUserRole? Role { get; set; }
    public DepartmentUserAssignment? Assignment { get; set; }

    static object CreateObj(
      List<Guid> departmentIds,
      List<Guid> userIds,
      DepartmentUserRole? role,
      DepartmentUserAssignment? assignment)
    {
      return new
      {
        DepartmentIds = departmentIds,
        UserIds = userIds,
        Role = role,
        Assignment = assignment
      };
    }
  }
}
