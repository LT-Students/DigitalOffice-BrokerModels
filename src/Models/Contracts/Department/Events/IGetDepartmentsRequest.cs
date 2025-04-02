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
    public bool IncludeCreateDate { get; set; }

    static object CreateObj(
      bool includeCreateDate,
      List<Guid> departmentIds = null,
      List<Guid> userIds = null,
      DepartmentUserRole? role = null,
      DepartmentUserAssignment? assignment = null)
    {
      return new
      {
        DepartmentIds = departmentIds,
        UserIds = userIds,
        Role = role,
        Assignment = assignment,
        IncludeCreateDate = includeCreateDate
      };
    }
  }
}
