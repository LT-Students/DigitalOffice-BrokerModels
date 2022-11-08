using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Department
{
  public interface IGetDepartmentsRequest
  {
    List<Guid> DepartmentsIds { get; }
    List<Guid> UsersIds { get; }
    bool IncludeChildDepartmentsIds { get; }

        static object CreateObj(
      List<Guid> departmentsIds = null,
      List<Guid> usersIds = null,
      bool includeChildDepartmentsIds = false)
    {
      return new
      {
        DepartmentsIds = departmentsIds,
        UsersIds = usersIds,
        IncludeChildDepartmentsIds = includeChildDepartmentsIds
      };
    }
  }
}
